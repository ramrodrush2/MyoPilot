﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyoPilot.UserSettings {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0")]
    internal sealed partial class UISettings : global::System.Configuration.ApplicationSettingsBase {
        
        private static UISettings defaultInstance = ((UISettings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new UISettings())));
        
        public static UISettings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Black")]
        public global::System.Drawing.Color IconDefaultColor {
            get {
                return ((global::System.Drawing.Color)(this["IconDefaultColor"]));
            }
            set {
                this["IconDefaultColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Red")]
        public global::System.Drawing.Color IconHighlightColor {
            get {
                return ((global::System.Drawing.Color)(this["IconHighlightColor"]));
            }
            set {
                this["IconHighlightColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool DebugInfo {
            get {
                return ((bool)(this["DebugInfo"]));
            }
            set {
                this["DebugInfo"] = value;
            }
        }
    }
}
