﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VarietyScreenRecorder.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.4.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1")]
        public int Version {
            get {
                return ((int)(this["Version"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string FullSizeScreenshot_Path {
            get {
                return ((string)(this["FullSizeScreenshot_Path"]));
            }
            set {
                this["FullSizeScreenshot_Path"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("png")]
        public string FullSizeScreenshot_Extension {
            get {
                return ((string)(this["FullSizeScreenshot_Extension"]));
            }
            set {
                this["FullSizeScreenshot_Extension"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string SizedScreenshot_Path {
            get {
                return ((string)(this["SizedScreenshot_Path"]));
            }
            set {
                this["SizedScreenshot_Path"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("png")]
        public string SizedScreenshot_Extension {
            get {
                return ((string)(this["SizedScreenshot_Extension"]));
            }
            set {
                this["SizedScreenshot_Extension"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool SizedScreenshot_IsEdit {
            get {
                return ((bool)(this["SizedScreenshot_IsEdit"]));
            }
            set {
                this["SizedScreenshot_IsEdit"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string TimeLapseScreenshot_Path {
            get {
                return ((string)(this["TimeLapseScreenshot_Path"]));
            }
            set {
                this["TimeLapseScreenshot_Path"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("png")]
        public string TimeLapseScreenshot_Extension {
            get {
                return ((string)(this["TimeLapseScreenshot_Extension"]));
            }
            set {
                this["TimeLapseScreenshot_Extension"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("5")]
        public int TimeLapseScreenshot_Interval {
            get {
                return ((int)(this["TimeLapseScreenshot_Interval"]));
            }
            set {
                this["TimeLapseScreenshot_Interval"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string VideoRecord_Path {
            get {
                return ((string)(this["VideoRecord_Path"]));
            }
            set {
                this["VideoRecord_Path"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Ctrl+P")]
        public string VSRHotKey_PhotoCam {
            get {
                return ((string)(this["VSRHotKey_PhotoCam"]));
            }
            set {
                this["VSRHotKey_PhotoCam"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Ctrl+C")]
        public string VSRHotKey_PhotoCamSized {
            get {
                return ((string)(this["VSRHotKey_PhotoCamSized"]));
            }
            set {
                this["VSRHotKey_PhotoCamSized"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Ctrl+T")]
        public string VSRHotKey_TimeLapse {
            get {
                return ((string)(this["VSRHotKey_TimeLapse"]));
            }
            set {
                this["VSRHotKey_TimeLapse"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Ctrl+V")]
        public string VSRHotKey_VideoCam {
            get {
                return ((string)(this["VSRHotKey_VideoCam"]));
            }
            set {
                this["VSRHotKey_VideoCam"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Ctrl+S")]
        public string VSRHotKey_Setting {
            get {
                return ((string)(this["VSRHotKey_Setting"]));
            }
            set {
                this["VSRHotKey_Setting"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Ctrl+I")]
        public string VSRHotKey_Info {
            get {
                return ((string)(this["VSRHotKey_Info"]));
            }
            set {
                this["VSRHotKey_Info"] = value;
            }
        }
    }
}