//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.225
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CodeBuilder.Framework.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resource() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("CodeBuilder.Framework.Properties.Resource", typeof(Resource).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ConfigurationSection {0} load failure.
        /// </summary>
        internal static string ConfigurationSectionLoadFailure {
            get {
                return ResourceManager.GetString("ConfigurationSectionLoadFailure", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Load configuration failure.
        /// </summary>
        internal static string LoadConfigurationFailure {
            get {
                return ResourceManager.GetString("LoadConfigurationFailure", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Not Found {0} {1} Data Type Item.
        /// </summary>
        internal static string NotFoundDataTypeItem {
            get {
                return ResourceManager.GetString("NotFoundDataTypeItem", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Not Found {0} To {1} Data Type Mapping.
        /// </summary>
        internal static string NotFoundDataTypeMapping {
            get {
                return ResourceManager.GetString("NotFoundDataTypeMapping", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The powerdesigner physical data model(pdm) not specify DBMS..
        /// </summary>
        internal static string NotFoundPdmDBMSExceptionMessage {
            get {
                return ResourceManager.GetString("NotFoundPdmDBMSExceptionMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sorry!CodeBuilder not support this database..
        /// </summary>
        internal static string NotSupportDatabaseExceptionMessage {
            get {
                return ResourceManager.GetString("NotSupportDatabaseExceptionMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Save configuration failure.
        /// </summary>
        internal static string SaveConfigurationFailure {
            get {
                return ResourceManager.GetString("SaveConfigurationFailure", resourceCulture);
            }
        }
    }
}
