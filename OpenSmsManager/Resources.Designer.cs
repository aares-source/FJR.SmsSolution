﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OpenSmsManager {
    using System;
    
    
    /// <summary>
    ///   Clase de recurso fuertemente tipado, para buscar cadenas traducidas, etc.
    /// </summary>
    // StronglyTypedResourceBuilder generó automáticamente esta clase
    // a través de una herramienta como ResGen o Visual Studio.
    // Para agregar o quitar un miembro, edite el archivo .ResX y, a continuación, vuelva a ejecutar ResGen
    // con la opción /str o recompile su proyecto de VS.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Devuelve la instancia de ResourceManager almacenada en caché utilizada por esta clase.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("OpenSmsManager.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Reemplaza la propiedad CurrentUICulture del subproceso actual para todas las
        ///   búsquedas de recursos mediante esta clase de recurso fuertemente tipado.
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
        ///   Busca una cadena traducida similar a Failed to connect to device.
        /// </summary>
        internal static string FailedToConnectToDevice {
            get {
                return ResourceManager.GetString("FailedToConnectToDevice", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Failed to list messages.
        /// </summary>
        internal static string FailedToListMessages {
            get {
                return ResourceManager.GetString("FailedToListMessages", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Failed to open connection to device.
        /// </summary>
        internal static string FailedToOpenConnectionToDevice {
            get {
                return ResourceManager.GetString("FailedToOpenConnectionToDevice", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Listing messages....
        /// </summary>
        internal static string ListingMessages {
            get {
                return ResourceManager.GetString("ListingMessages", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Message Sent!.
        /// </summary>
        internal static string MessageSent {
            get {
                return ResourceManager.GetString("MessageSent", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Opening COM to connect to device....
        /// </summary>
        internal static string OpeningComToConnectToDevice {
            get {
                return ResourceManager.GetString("OpeningComToConnectToDevice", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Opening COM port.
        /// </summary>
        internal static string OpeningDevice {
            get {
                return ResourceManager.GetString("OpeningDevice", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Sending message....
        /// </summary>
        internal static string SendingMessage {
            get {
                return ResourceManager.GetString("SendingMessage", resourceCulture);
            }
        }
    }
}
