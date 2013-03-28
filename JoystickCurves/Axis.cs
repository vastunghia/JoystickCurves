﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.DirectX.DirectInput;

namespace JoystickCurves
{
    
    public class Axis
    {
        private JoystickOffset _joystickOffset;
        private string _name;
        public Axis(int min, int max)
        {
            if (min == max)
                throw new Exception("Minimum and maximum value of axies should not be equal!");

            Min = min;
            Max = max;
        }
        public int Value
        {
            get;
            set;
        }
        public int PercentValue
        {
            get { return (100 / (Max - Min)) * Value; }
            set { Value = value * 100 / (Max - Min); }
        }
        public int Max
        {
            get;
            set;
        }
        public int Min
        {
            get;
            set;
        }
        public string Name
        {
            get{ return _name; }
            set{
                JoystickOffset result;
                Enum.TryParse<JoystickOffset>(value, out result);
                if ((int)result == 0)
                    _name = "Unknown";
                else
                {
                    DirectInputID = result;
                    _name = value;
                }

            }
        }
        public JoystickOffset DirectInputID
        {
            get { return _joystickOffset; }
            set
            {
                _name = value.ToString();
                _joystickOffset = value;
            }        
        }
    }
}
