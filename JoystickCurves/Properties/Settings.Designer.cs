﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.296
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JoystickCurves.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::JoystickCurves.ProfileManager Profiles {
            get {
                return ((global::JoystickCurves.ProfileManager)(this["Profiles"]));
            }
            set {
                this["Profiles"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::JoystickCurves.Profile CurrentProfile {
            get {
                return ((global::JoystickCurves.Profile)(this["CurrentProfile"]));
            }
            set {
                this["CurrentProfile"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string TesterVirtualJoystick {
            get {
                return ((string)(this["TesterVirtualJoystick"]));
            }
            set {
                this["TesterVirtualJoystick"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string TesterPhysicalJoystick {
            get {
                return ((string)(this["TesterPhysicalJoystick"]));
            }
            set {
                this["TesterPhysicalJoystick"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string TesterVirtualJoystickX {
            get {
                return ((string)(this["TesterVirtualJoystickX"]));
            }
            set {
                this["TesterVirtualJoystickX"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string TesterVirtualJoystickY {
            get {
                return ((string)(this["TesterVirtualJoystickY"]));
            }
            set {
                this["TesterVirtualJoystickY"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string TesterVirtualJoystickRZ {
            get {
                return ((string)(this["TesterVirtualJoystickRZ"]));
            }
            set {
                this["TesterVirtualJoystickRZ"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string TesterPhysicalJoystickX {
            get {
                return ((string)(this["TesterPhysicalJoystickX"]));
            }
            set {
                this["TesterPhysicalJoystickX"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string TesterPhysicalJoystickY {
            get {
                return ((string)(this["TesterPhysicalJoystickY"]));
            }
            set {
                this["TesterPhysicalJoystickY"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string TesterPhysicalJoystickRZ {
            get {
                return ((string)(this["TesterPhysicalJoystickRZ"]));
            }
            set {
                this["TesterPhysicalJoystickRZ"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool generalMinimizeOnClose {
            get {
                return ((bool)(this["generalMinimizeOnClose"]));
            }
            set {
                this["generalMinimizeOnClose"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool generalAutoStart {
            get {
                return ((bool)(this["generalAutoStart"]));
            }
            set {
                this["generalAutoStart"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool generalStartMinimized {
            get {
                return ((bool)(this["generalStartMinimized"]));
            }
            set {
                this["generalStartMinimized"] = value;
            }
        }
    }
}
