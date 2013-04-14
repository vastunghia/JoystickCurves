﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.DirectX.DirectInput;
using System.Threading;
using System.Diagnostics;

namespace JoystickCurves
{
    
    public class DeviceManager
    {
        public event EventHandler<EventArgs> OnJoystickList;
        public event EventHandler<EventArgs> OnKeyboardList;
        public event EventHandler<EventArgs> OnMouseList;
        public object pollLock = new object();
        private String[] virtualTags = new String[] { "vjoy" };
        private Timer _pollTimer;
        private const int POLLINTERVAL = 1000;
        public DeviceManager()
        {
            Joysticks = new List<DirectInputJoystick>();
            Mouses = new List<DirectInputMouse>();
            Keyboards = new List<DirectInputKeyboard>();

            _pollTimer = new Timer(new TimerCallback(poll_Tick), null, 0, POLLINTERVAL);           
        }

        private void poll_Tick(object o)
        {
            lock (pollLock)
            {
                RefreshJoystickList();
                RefreshKeyboardList();
                RefreshMouseList();
            }
        }

        public void OnNoNeed(object sender, EventArgs e)
        {
            if (sender.GetType() == typeof(DirectInputJoystick) )
            {
                var joystick = sender as DirectInputJoystick;
                Debug.Print("Joystick {0} removed", ((DirectInputJoystick)sender).Name);

                if (joystick.Type == DeviceType.Virtual && joystick.VirtualJoystick != null)
                    joystick.VirtualJoystick.Unacquire();

                Joysticks.Remove(joystick);
            }
            else if( sender.GetType() == typeof(DirectInputKeyboard))
            {
                Debug.Print("Keyboard {0} removed", ((DirectInputKeyboard)sender).Name);
                Keyboards.Remove((DirectInputKeyboard)sender);
            }
            else if ( sender.GetType() == typeof(DirectInputMouse))
            {
                Debug.Print("Mouse {0} removed", ((DirectInputMouse)sender).Name);
                Mouses.Remove((DirectInputMouse)sender);
            }
        }

        public void RefreshMouseList()
        {
            List<DeviceInstance> mouseInstances;
            mouseInstances = Utils.DevList(Manager.GetDevices(DeviceClass.Pointer, EnumDevicesFlags.AttachedOnly));

            if (Mouses == null)
                Mouses = new List<DirectInputMouse>();

            Mouses.Where(dev => !mouseInstances.Exists(d => dev.Guid == d.InstanceGuid)).ToList().ForEach(
                gc => { gc.Unacquire(); Mouses.Remove(gc); }
            );

            var addList = mouseInstances.Where(d => !Mouses.Exists(dev => dev.Guid == d.InstanceGuid));

            if (addList == null || addList.Count() <= 0)
                return;

            foreach (DeviceInstance dev in addList)
            {
                var mouse = new DirectInputMouse(dev);
                mouse.OnError +=new EventHandler<EventArgs>(OnNoNeed);
                mouse.OnUnacquire += new EventHandler<EventArgs>(OnNoNeed);

                Mouses.Add(mouse);
                if (Mouses.Where(d => d.Name.StartsWith(mouse.Name)).Count() > 1)
                {
                    Mouses.Where(d => d.Name.StartsWith(mouse.Name) && d.Index == 0).ToList().ForEach(
                            d => d.Index = Mouses.Max(dm => dm.Index) + 1
                        );
                }
            }

            if (OnMouseList != null)
                OnMouseList(this, EventArgs.Empty);

        }


        public void RefreshKeyboardList()
        {
            List<DeviceInstance> keyboardInstances;
            keyboardInstances = Utils.DevList(Manager.GetDevices(DeviceClass.Keyboard, EnumDevicesFlags.AttachedOnly));

            if (Keyboards == null)
                Keyboards = new List<DirectInputKeyboard>();

            Keyboards.Where(dev => !keyboardInstances.Exists(d => dev.Guid == d.InstanceGuid)).ToList().ForEach(
                gc => { gc.Unacquire(); Keyboards.Remove(gc); }
            );

            var addList = keyboardInstances.Where(d => !Keyboards.Exists(dev => dev.Guid == d.InstanceGuid));

            if (addList == null || addList.Count() <= 0)
                return;

            foreach (DeviceInstance dev in addList)
            {
                var keyboard = new DirectInputKeyboard(dev);
                keyboard.OnError += new EventHandler<EventArgs>(OnNoNeed);
                keyboard.OnUnacquire += new EventHandler<EventArgs>(OnNoNeed);

                Keyboards.Add(keyboard);
                if (Keyboards.Where(d => d.Name.StartsWith(keyboard.Name)).Count() > 1)
                {
                    Keyboards.Where(d => d.Name.StartsWith(keyboard.Name) && d.Index == 0).ToList().ForEach(
                            d => d.Index = Keyboards.Max(dm => dm.Index) + 1
                        );
                }
            }

            if (OnKeyboardList != null)
                OnKeyboardList(this, EventArgs.Empty);

        }

        public void RefreshJoystickList()
        {
            List<DeviceInstance> joystickInstances;
            var devices = Manager.GetDevices(DeviceClass.GameControl, EnumDevicesFlags.AttachedOnly );

            joystickInstances= Utils.DevList(devices);

            if (Joysticks == null)
                Joysticks = new List<DirectInputJoystick>();

            Joysticks.Where(dev => !joystickInstances.Exists(d => dev.Guid == d.InstanceGuid)).ToList().ForEach(
                gc => { gc.Unacquire(); Joysticks.Remove(gc); }
            );
           
            var addList = joystickInstances.Where(d => !Joysticks.Exists(dev => dev.Guid == d.InstanceGuid));
            
            if (addList == null || addList.Count() <= 0)
                return;

            foreach (DeviceInstance dev in addList)
            {                
                var joystick = new DirectInputJoystick(dev, GetDeviceType(dev.ProductName));
                joystick.OnError += new EventHandler<EventArgs>(OnNoNeed);
                joystick.OnUnacquire += new EventHandler<EventArgs>(OnNoNeed);


                
                Joysticks.Add(joystick);
                if (Joysticks.Where(d => d.Name.StartsWith(joystick.Name)).Count() > 1)
                {
                    Joysticks.Where(d => d.Name.StartsWith(joystick.Name) && d.Index == 0).ToList().ForEach(
                            d => d.Index = Joysticks.Max(dm => dm.Index) + 1
                        );
                }
            }

            var virtualCount = Joysticks.Count(j => j.Type == DeviceType.Virtual);
            if ( virtualCount >= 1)
            {
                foreach (var joystick in Joysticks.Where(j => j.Type == DeviceType.Virtual))
                {
                    joystick.OnButtonDown += new EventHandler<CustomEventArgs<DirectInputData>>(gameController_OnButtonDown);
                }
                for (uint i = 1; i <= 16; i++)
                {
                    var vjoy = new VirtualJoystick(i);
                    vjoy.OnAcquire += new EventHandler<EventArgs>(vjoy_OnAcquire);
                    vjoy.Acquire();
                }
            }

            if (OnJoystickList != null)
                OnJoystickList(this, EventArgs.Empty);
        }

        void vjoy_OnAcquire(object sender, EventArgs e)
        {
            VirtualJoystick vjoy = sender as VirtualJoystick;
            vjoy.SetButton(vjoy.DeviceID, true);
            vjoy.Unacquire();
        }

        void gameController_OnButtonDown(object sender, CustomEventArgs<DirectInputData> e)
        {
            DirectInputJoystick device = Joysticks.Where( d => d.Name == e.Data.DeviceName).FirstOrDefault();
            if (device == null)
                return;

            var i = Joysticks.IndexOf(device);
            var devName = device.Name;
            var deviceId = (uint)e.Data.JoystickOffset - (uint)JoystickOffset.Button0 + 1;
            
            Joysticks[i].VirtualJoystick = new VirtualJoystick(deviceId);

            device.OnButtonPress -= gameController_OnButtonDown;
            device.VirtualJoystick.SetButton(device.VirtualJoystick.DeviceID, false);
        }

        private DeviceType GetDeviceType( string name )
        {
            return virtualTags.Where(vt => name.ToLower().Contains(vt)).Count() > 0 ? DeviceType.Virtual : DeviceType.Physical;
        }

        public List<DirectInputJoystick> Joysticks
        {
            get;
            set;
        }
        public List<DirectInputKeyboard> Keyboards
        {
            get;
            set;
        }
        public List<DirectInputMouse> Mouses
        {
            get;
            set;
        }
    }

}
