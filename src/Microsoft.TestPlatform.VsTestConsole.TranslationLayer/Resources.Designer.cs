﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.TestPlatform.VsTestConsole.TranslationLayer {
    using System;
    using System.Reflection;
    
    
    /// <summary>
    ///    A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        internal Resources() {
        }
        
        /// <summary>
        ///    Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.TestPlatform.VsTestConsole.TranslationLayer.Resources", typeof(Resources).GetTypeInfo().Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///    Overrides the current thread's CurrentUICulture property for all
        ///    resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The active Tests Discovery was aborted..
        /// </summary>
        public static string AbortedTestsDiscovery {
            get {
                return ResourceManager.GetString("AbortedTestsDiscovery", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The active Tests Run was aborted..
        /// </summary>
        public static string AbortedTestsRun {
            get {
                return ResourceManager.GetString("AbortedTestsRun", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Failed to receive message from vstest.console process.
        /// </summary>
        public static string FailedToReceiveMessage {
            get {
                return ResourceManager.GetString("FailedToReceiveMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to vstest.console process exited abnormally.
        /// </summary>
        public static string VsTestProcessExitedAbnormally {
            get {
                return ResourceManager.GetString("VsTestProcessExitedAbnormally", resourceCulture);
            }
        }
    }
}