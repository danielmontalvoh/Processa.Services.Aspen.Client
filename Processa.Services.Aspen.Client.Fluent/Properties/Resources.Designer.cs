﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Processa.Services.Aspen.Client.Fluent.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Settings.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Processa.Services.Aspen.Client.Fluent.Properties.Settings", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to Cannot be inside the range {0} to {1}..
        /// </summary>
        internal static string ArgumentInOfRangeMessageFormat {
            get {
                return ResourceManager.GetString("ArgumentInOfRangeMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot be an invalid value..
        /// </summary>
        internal static string ArgumentInvalidMessage {
            get {
                return ResourceManager.GetString("ArgumentInvalidMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot be outside the range {0} to {1}..
        /// </summary>
        internal static string ArgumentOutOfRangeMessageFormat {
            get {
                return ResourceManager.GetString("ArgumentOutOfRangeMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot be an empty collection..
        /// </summary>
        internal static string EmptyCollectionMessage {
            get {
                return ResourceManager.GetString("EmptyCollectionMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot be an empty Guid..
        /// </summary>
        internal static string EmptyGuidMessage {
            get {
                return ResourceManager.GetString("EmptyGuidMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot be an empty string..
        /// </summary>
        internal static string EmptyStringMessage {
            get {
                return ResourceManager.GetString("EmptyStringMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot be a value outside the specified enum range..
        /// </summary>
        internal static string EnumIsNotDefinedMessage {
            get {
                return ResourceManager.GetString("EnumIsNotDefinedMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to General Exception..
        /// </summary>
        internal static string GeneralExceptionMessage {
            get {
                return ResourceManager.GetString("GeneralExceptionMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot contain a null item in the collection..
        /// </summary>
        internal static string NullItemCollectionMessage {
            get {
                return ResourceManager.GetString("NullItemCollectionMessage", resourceCulture);
            }
        }
    }
}