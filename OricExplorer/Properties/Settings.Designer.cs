﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OricExplorer.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("2.0")]
        public decimal Version {
            get {
                return ((decimal)(this["Version"]));
            }
            set {
                this["Version"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("I:\\Documents")]
        public string DirectoryListingsFolder {
            get {
                return ((string)(this["DirectoryListingsFolder"]));
            }
            set {
                this["DirectoryListingsFolder"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool CheckForUpdatesOnStartup {
            get {
                return ((bool)(this["CheckForUpdatesOnStartup"]));
            }
            set {
                this["CheckForUpdatesOnStartup"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("I:\\Development\\Windows .NET\\Oric Test Files\\Oricutron\\oricutron.exe")]
        public string EmulatorExecutable {
            get {
                return ((string)(this["EmulatorExecutable"]));
            }
            set {
                this["EmulatorExecutable"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("White")]
        public global::System.Drawing.Color BasicLineNumberColor {
            get {
                return ((global::System.Drawing.Color)(this["BasicLineNumberColor"]));
            }
            set {
                this["BasicLineNumberColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Regular")]
        public string BasicLineNumberStyle {
            get {
                return ((string)(this["BasicLineNumberStyle"]));
            }
            set {
                this["BasicLineNumberStyle"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("White")]
        public global::System.Drawing.Color BasicDataKeywordColor {
            get {
                return ((global::System.Drawing.Color)(this["BasicDataKeywordColor"]));
            }
            set {
                this["BasicDataKeywordColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Bold")]
        public string BasicDataKeywordStyle {
            get {
                return ((string)(this["BasicDataKeywordStyle"]));
            }
            set {
                this["BasicDataKeywordStyle"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("<?xml version=\"1.0\" encoding=\"utf-16\"?>\r\n<ArrayOfString xmlns:xsi=\"http://www.w3." +
            "org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <s" +
            "tring>I:\\Development\\Windows .NET\\Oric Test Files\\Tapes</string>\r\n</ArrayOfStrin" +
            "g>")]
        public global::System.Collections.Specialized.StringCollection TapeFolders {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["TapeFolders"]));
            }
            set {
                this["TapeFolders"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"<?xml version=""1.0"" encoding=""utf-16""?>
<ArrayOfString xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <string>I:\Development\Windows .NET\Oric Test Files\Disks</string>
  <string>I:\Development\Windows .NET\Oric Test Files</string>
</ArrayOfString>")]
        public global::System.Collections.Specialized.StringCollection DiskFolders {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["DiskFolders"]));
            }
            set {
                this["DiskFolders"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("<?xml version=\"1.0\" encoding=\"utf-16\"?>\r\n<ArrayOfString xmlns:xsi=\"http://www.w3." +
            "org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <s" +
            "tring>I:\\Development\\Windows .NET\\Oric Test Files\\ROMS</string>\r\n</ArrayOfString" +
            ">")]
        public global::System.Collections.Specialized.StringCollection RomFolders {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["RomFolders"]));
            }
            set {
                this["RomFolders"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("White")]
        public global::System.Drawing.Color BasicStringColor {
            get {
                return ((global::System.Drawing.Color)(this["BasicStringColor"]));
            }
            set {
                this["BasicStringColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("White")]
        public global::System.Drawing.Color BasicCommentColor {
            get {
                return ((global::System.Drawing.Color)(this["BasicCommentColor"]));
            }
            set {
                this["BasicCommentColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("White")]
        public global::System.Drawing.Color BasicKeywordColor {
            get {
                return ((global::System.Drawing.Color)(this["BasicKeywordColor"]));
            }
            set {
                this["BasicKeywordColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("White")]
        public global::System.Drawing.Color BasicNumberColor {
            get {
                return ((global::System.Drawing.Color)(this["BasicNumberColor"]));
            }
            set {
                this["BasicNumberColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("White")]
        public global::System.Drawing.Color BasicHexNumberColor {
            get {
                return ((global::System.Drawing.Color)(this["BasicHexNumberColor"]));
            }
            set {
                this["BasicHexNumberColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Regular")]
        public string BasicStringStyle {
            get {
                return ((string)(this["BasicStringStyle"]));
            }
            set {
                this["BasicStringStyle"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Regular")]
        public string BasicCommentStyle {
            get {
                return ((string)(this["BasicCommentStyle"]));
            }
            set {
                this["BasicCommentStyle"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Regular")]
        public string BasicKeywordStyle {
            get {
                return ((string)(this["BasicKeywordStyle"]));
            }
            set {
                this["BasicKeywordStyle"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Regular")]
        public string BasicNumberStyle {
            get {
                return ((string)(this["BasicNumberStyle"]));
            }
            set {
                this["BasicNumberStyle"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Regular")]
        public string BasicHexNumberStyle {
            get {
                return ((string)(this["BasicHexNumberStyle"]));
            }
            set {
                this["BasicHexNumberStyle"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Black")]
        public global::System.Drawing.Color PageBackground {
            get {
                return ((global::System.Drawing.Color)(this["PageBackground"]));
            }
            set {
                this["PageBackground"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("White")]
        public global::System.Drawing.Color BasicLoopsColor {
            get {
                return ((global::System.Drawing.Color)(this["BasicLoopsColor"]));
            }
            set {
                this["BasicLoopsColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Regular")]
        public string BasicLoopsStyle {
            get {
                return ((string)(this["BasicLoopsStyle"]));
            }
            set {
                this["BasicLoopsStyle"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Regular")]
        public string BasicBranchesStyle {
            get {
                return ((string)(this["BasicBranchesStyle"]));
            }
            set {
                this["BasicBranchesStyle"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("White")]
        public global::System.Drawing.Color BasicBranchesColor {
            get {
                return ((global::System.Drawing.Color)(this["BasicBranchesColor"]));
            }
            set {
                this["BasicBranchesColor"] = value;
            }
        }
    }
}
