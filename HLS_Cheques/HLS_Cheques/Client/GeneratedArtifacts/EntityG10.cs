﻿

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LightSwitchApplication
{
    #region Entities
    
    /// <summary>
    /// No Modeled Description Available
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.0.0.0")]
    public sealed partial class Parametro : global::Microsoft.LightSwitch.Framework.Base.EntityObject<global::LightSwitchApplication.Parametro, global::LightSwitchApplication.Parametro.DetailsClass>
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new instance of the Parametro entity.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public Parametro()
            : this(null)
        {
        }
    
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public Parametro(global::Microsoft.LightSwitch.Framework.EntitySet<global::LightSwitchApplication.Parametro> entitySet)
            : base(entitySet)
        {
            global::LightSwitchApplication.Parametro.DetailsClass.Initialize(this);
        }
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Parametro_Created();
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Parametro_AllowSaveWithErrors(ref bool result);
    
        #endregion
    
        #region Private Properties
        
        /// <summary>
        /// Gets the Application object for this application.  The Application object provides access to active screens, methods to open screens and access to the current user.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private global::Microsoft.LightSwitch.IApplication<global::LightSwitchApplication.DataWorkspace> Application
        {
            get
            {
                return (global::Microsoft.LightSwitch.IApplication<global::LightSwitchApplication.DataWorkspace>)global::LightSwitchApplication.Application.Current;
            }
        }
        
        /// <summary>
        /// Gets the containing data workspace.  The data workspace provides access to all data sources in the application.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private global::LightSwitchApplication.DataWorkspace DataWorkspace
        {
            get
            {
                return (global::LightSwitchApplication.DataWorkspace)this.Details.EntitySet.Details.DataService.Details.DataWorkspace;
            }
        }
        
        #endregion
    
        #region Public Properties
    
        /// <summary>
        /// No Modeled Description Available
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public int Id
        {
            get
            {
                return global::LightSwitchApplication.Parametro.DetailsClass.GetValue(this, global::LightSwitchApplication.Parametro.DetailsClass.PropertySetProperties.Id);
            }
            set
            {
                global::LightSwitchApplication.Parametro.DetailsClass.SetValue(this, global::LightSwitchApplication.Parametro.DetailsClass.PropertySetProperties.Id, value);
            }
        }
        
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Id_IsReadOnly(ref bool result);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Id_Validate(global::Microsoft.LightSwitch.EntityValidationResultsBuilder results);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Id_Changed();

        /// <summary>
        /// No Modeled Description Available
        /// </summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public byte[] RowVersion
        {
            get
            {
                return global::LightSwitchApplication.Parametro.DetailsClass.GetValue(this, global::LightSwitchApplication.Parametro.DetailsClass.PropertySetProperties.RowVersion);
            }
            set
            {
                global::LightSwitchApplication.Parametro.DetailsClass.SetValue(this, global::LightSwitchApplication.Parametro.DetailsClass.PropertySetProperties.RowVersion, value);
            }
        }
        
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void RowVersion_IsReadOnly(ref bool result);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void RowVersion_Validate(global::Microsoft.LightSwitch.EntityValidationResultsBuilder results);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void RowVersion_Changed();

        /// <summary>
        /// No Modeled Description Available
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public string Categoria
        {
            get
            {
                return global::LightSwitchApplication.Parametro.DetailsClass.GetValue(this, global::LightSwitchApplication.Parametro.DetailsClass.PropertySetProperties.Categoria);
            }
            set
            {
                global::LightSwitchApplication.Parametro.DetailsClass.SetValue(this, global::LightSwitchApplication.Parametro.DetailsClass.PropertySetProperties.Categoria, value);
            }
        }
        
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Categoria_IsReadOnly(ref bool result);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Categoria_Validate(global::Microsoft.LightSwitch.EntityValidationResultsBuilder results);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Categoria_Changed();

        /// <summary>
        /// No Modeled Description Available
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public string Clave
        {
            get
            {
                return global::LightSwitchApplication.Parametro.DetailsClass.GetValue(this, global::LightSwitchApplication.Parametro.DetailsClass.PropertySetProperties.Clave);
            }
            set
            {
                global::LightSwitchApplication.Parametro.DetailsClass.SetValue(this, global::LightSwitchApplication.Parametro.DetailsClass.PropertySetProperties.Clave, value);
            }
        }
        
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Clave_IsReadOnly(ref bool result);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Clave_Validate(global::Microsoft.LightSwitch.EntityValidationResultsBuilder results);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Clave_Changed();

        /// <summary>
        /// No Modeled Description Available
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public string Valor
        {
            get
            {
                return global::LightSwitchApplication.Parametro.DetailsClass.GetValue(this, global::LightSwitchApplication.Parametro.DetailsClass.PropertySetProperties.Valor);
            }
            set
            {
                global::LightSwitchApplication.Parametro.DetailsClass.SetValue(this, global::LightSwitchApplication.Parametro.DetailsClass.PropertySetProperties.Valor, value);
            }
        }
        
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Valor_IsReadOnly(ref bool result);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Valor_Validate(global::Microsoft.LightSwitch.EntityValidationResultsBuilder results);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Valor_Changed();

        #endregion
    
        #region Details Class
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public sealed class DetailsClass : global::Microsoft.LightSwitch.Details.Framework.Base.EntityDetails<
                global::LightSwitchApplication.Parametro,
                global::LightSwitchApplication.Parametro.DetailsClass,
                global::LightSwitchApplication.Parametro.DetailsClass.IImplementation,
                global::LightSwitchApplication.Parametro.DetailsClass.PropertySet,
                global::Microsoft.LightSwitch.Details.Framework.EntityCommandSet<global::LightSwitchApplication.Parametro, global::LightSwitchApplication.Parametro.DetailsClass>,
                global::Microsoft.LightSwitch.Details.Framework.EntityMethodSet<global::LightSwitchApplication.Parametro, global::LightSwitchApplication.Parametro.DetailsClass>>
        {
    
            static DetailsClass()
            {
                var initializeEntry = global::LightSwitchApplication.Parametro.DetailsClass.PropertySetProperties.Id;
            }
    
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private static readonly global::Microsoft.LightSwitch.Details.Framework.Base.EntityDetails<global::LightSwitchApplication.Parametro, global::LightSwitchApplication.Parametro.DetailsClass>.Entry
                __ParametroEntry = new global::Microsoft.LightSwitch.Details.Framework.Base.EntityDetails<global::LightSwitchApplication.Parametro, global::LightSwitchApplication.Parametro.DetailsClass>.Entry(
                    global::LightSwitchApplication.Parametro.DetailsClass.__Parametro_CreateNew,
                    global::LightSwitchApplication.Parametro.DetailsClass.__Parametro_Created,
                    global::LightSwitchApplication.Parametro.DetailsClass.__Parametro_AllowSaveWithErrors);
            private static global::LightSwitchApplication.Parametro __Parametro_CreateNew(global::Microsoft.LightSwitch.Framework.EntitySet<global::LightSwitchApplication.Parametro> es)
            {
                return new global::LightSwitchApplication.Parametro(es);
            }
            private static void __Parametro_Created(global::LightSwitchApplication.Parametro e)
            {
                e.Parametro_Created();
            }
            private static bool __Parametro_AllowSaveWithErrors(global::LightSwitchApplication.Parametro e)
            {
                bool result = false;
                e.Parametro_AllowSaveWithErrors(ref result);
                return result;
            }
    
            public DetailsClass() : base()
            {
            }
    
            public new global::Microsoft.LightSwitch.Details.Framework.EntityCommandSet<global::LightSwitchApplication.Parametro, global::LightSwitchApplication.Parametro.DetailsClass> Commands
            {
                get
                {
                    return base.Commands;
                }
            }
    
            public new global::Microsoft.LightSwitch.Details.Framework.EntityMethodSet<global::LightSwitchApplication.Parametro, global::LightSwitchApplication.Parametro.DetailsClass> Methods
            {
                get
                {
                    return base.Methods;
                }
            }
    
            public new global::LightSwitchApplication.Parametro.DetailsClass.PropertySet Properties
            {
                get
                {
                    return base.Properties;
                }
            }
    
            [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
            [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.0.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public sealed class PropertySet : global::Microsoft.LightSwitch.Details.Framework.Base.EntityPropertySet<global::LightSwitchApplication.Parametro, global::LightSwitchApplication.Parametro.DetailsClass>
            {
    
                public PropertySet() : base()
                {
                }
    
                public global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Parametro, global::LightSwitchApplication.Parametro.DetailsClass, int> Id
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.Parametro.DetailsClass.PropertySetProperties.Id) as global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Parametro, global::LightSwitchApplication.Parametro.DetailsClass, int>;
                    }
                }
                
                public global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Parametro, global::LightSwitchApplication.Parametro.DetailsClass, byte[]> RowVersion
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.Parametro.DetailsClass.PropertySetProperties.RowVersion) as global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Parametro, global::LightSwitchApplication.Parametro.DetailsClass, byte[]>;
                    }
                }
                
                public global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Parametro, global::LightSwitchApplication.Parametro.DetailsClass, string> Categoria
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.Parametro.DetailsClass.PropertySetProperties.Categoria) as global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Parametro, global::LightSwitchApplication.Parametro.DetailsClass, string>;
                    }
                }
                
                public global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Parametro, global::LightSwitchApplication.Parametro.DetailsClass, string> Clave
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.Parametro.DetailsClass.PropertySetProperties.Clave) as global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Parametro, global::LightSwitchApplication.Parametro.DetailsClass, string>;
                    }
                }
                
                public global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Parametro, global::LightSwitchApplication.Parametro.DetailsClass, string> Valor
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.Parametro.DetailsClass.PropertySetProperties.Valor) as global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Parametro, global::LightSwitchApplication.Parametro.DetailsClass, string>;
                    }
                }
                
            }
    
            #pragma warning disable 109
            [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
            public interface IImplementation : global::Microsoft.LightSwitch.Internal.IEntityImplementation
            {
                new int Id { get; set; }
                new byte[] RowVersion { get; set; }
                new string Categoria { get; set; }
                new string Clave { get; set; }
                new string Valor { get; set; }
            }
            #pragma warning restore 109
    
            [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.0.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            internal class PropertySetProperties
            {
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Parametro, global::LightSwitchApplication.Parametro.DetailsClass, int>.Entry
                    Id = new global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Parametro, global::LightSwitchApplication.Parametro.DetailsClass, int>.Entry(
                        "Id",
                        global::LightSwitchApplication.Parametro.DetailsClass.PropertySetProperties._Id_Stub,
                        global::LightSwitchApplication.Parametro.DetailsClass.PropertySetProperties._Id_ComputeIsReadOnly,
                        global::LightSwitchApplication.Parametro.DetailsClass.PropertySetProperties._Id_Validate,
                        global::LightSwitchApplication.Parametro.DetailsClass.PropertySetProperties._Id_GetImplementationValue,
                        global::LightSwitchApplication.Parametro.DetailsClass.PropertySetProperties._Id_SetImplementationValue,
                        global::LightSwitchApplication.Parametro.DetailsClass.PropertySetProperties._Id_OnValueChanged);
                private static void _Id_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.Parametro.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Parametro, global::LightSwitchApplication.Parametro.DetailsClass, int>.Data> c, global::LightSwitchApplication.Parametro.DetailsClass d, object sf)
                {
                    c(d, ref d._Id, sf);
                }
                private static bool _Id_ComputeIsReadOnly(global::LightSwitchApplication.Parametro e)
                {
                    bool result = false;
                    e.Id_IsReadOnly(ref result);
                    return result;
                }
                private static void _Id_Validate(global::LightSwitchApplication.Parametro e, global::Microsoft.LightSwitch.EntityValidationResultsBuilder r)
                {
                    e.Id_Validate(r);
                }
                private static int _Id_GetImplementationValue(global::LightSwitchApplication.Parametro.DetailsClass d)
                {
                    return d.ImplementationEntity.Id;
                }
                private static void _Id_SetImplementationValue(global::LightSwitchApplication.Parametro.DetailsClass d, int v)
                {
                    d.ImplementationEntity.Id = v;
                }
                private static void _Id_OnValueChanged(global::LightSwitchApplication.Parametro e)
                {
                    e.Id_Changed();
                }
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Parametro, global::LightSwitchApplication.Parametro.DetailsClass, byte[]>.Entry
                    RowVersion = new global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Parametro, global::LightSwitchApplication.Parametro.DetailsClass, byte[]>.Entry(
                        "RowVersion",
                        global::LightSwitchApplication.Parametro.DetailsClass.PropertySetProperties._RowVersion_Stub,
                        global::LightSwitchApplication.Parametro.DetailsClass.PropertySetProperties._RowVersion_ComputeIsReadOnly,
                        global::LightSwitchApplication.Parametro.DetailsClass.PropertySetProperties._RowVersion_Validate,
                        global::LightSwitchApplication.Parametro.DetailsClass.PropertySetProperties._RowVersion_GetImplementationValue,
                        global::LightSwitchApplication.Parametro.DetailsClass.PropertySetProperties._RowVersion_SetImplementationValue,
                        global::LightSwitchApplication.Parametro.DetailsClass.PropertySetProperties._RowVersion_OnValueChanged);
                private static void _RowVersion_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.Parametro.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Parametro, global::LightSwitchApplication.Parametro.DetailsClass, byte[]>.Data> c, global::LightSwitchApplication.Parametro.DetailsClass d, object sf)
                {
                    c(d, ref d._RowVersion, sf);
                }
                private static bool _RowVersion_ComputeIsReadOnly(global::LightSwitchApplication.Parametro e)
                {
                    bool result = false;
                    e.RowVersion_IsReadOnly(ref result);
                    return result;
                }
                private static void _RowVersion_Validate(global::LightSwitchApplication.Parametro e, global::Microsoft.LightSwitch.EntityValidationResultsBuilder r)
                {
                    e.RowVersion_Validate(r);
                }
                private static byte[] _RowVersion_GetImplementationValue(global::LightSwitchApplication.Parametro.DetailsClass d)
                {
                    return d.ImplementationEntity.RowVersion;
                }
                private static void _RowVersion_SetImplementationValue(global::LightSwitchApplication.Parametro.DetailsClass d, byte[] v)
                {
                    d.ImplementationEntity.RowVersion = v;
                }
                private static void _RowVersion_OnValueChanged(global::LightSwitchApplication.Parametro e)
                {
                    e.RowVersion_Changed();
                }
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Parametro, global::LightSwitchApplication.Parametro.DetailsClass, string>.Entry
                    Categoria = new global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Parametro, global::LightSwitchApplication.Parametro.DetailsClass, string>.Entry(
                        "Categoria",
                        global::LightSwitchApplication.Parametro.DetailsClass.PropertySetProperties._Categoria_Stub,
                        global::LightSwitchApplication.Parametro.DetailsClass.PropertySetProperties._Categoria_ComputeIsReadOnly,
                        global::LightSwitchApplication.Parametro.DetailsClass.PropertySetProperties._Categoria_Validate,
                        global::LightSwitchApplication.Parametro.DetailsClass.PropertySetProperties._Categoria_GetImplementationValue,
                        global::LightSwitchApplication.Parametro.DetailsClass.PropertySetProperties._Categoria_SetImplementationValue,
                        global::LightSwitchApplication.Parametro.DetailsClass.PropertySetProperties._Categoria_OnValueChanged);
                private static void _Categoria_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.Parametro.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Parametro, global::LightSwitchApplication.Parametro.DetailsClass, string>.Data> c, global::LightSwitchApplication.Parametro.DetailsClass d, object sf)
                {
                    c(d, ref d._Categoria, sf);
                }
                private static bool _Categoria_ComputeIsReadOnly(global::LightSwitchApplication.Parametro e)
                {
                    bool result = false;
                    e.Categoria_IsReadOnly(ref result);
                    return result;
                }
                private static void _Categoria_Validate(global::LightSwitchApplication.Parametro e, global::Microsoft.LightSwitch.EntityValidationResultsBuilder r)
                {
                    e.Categoria_Validate(r);
                }
                private static string _Categoria_GetImplementationValue(global::LightSwitchApplication.Parametro.DetailsClass d)
                {
                    return d.ImplementationEntity.Categoria;
                }
                private static void _Categoria_SetImplementationValue(global::LightSwitchApplication.Parametro.DetailsClass d, string v)
                {
                    d.ImplementationEntity.Categoria = v;
                }
                private static void _Categoria_OnValueChanged(global::LightSwitchApplication.Parametro e)
                {
                    e.Categoria_Changed();
                }
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Parametro, global::LightSwitchApplication.Parametro.DetailsClass, string>.Entry
                    Clave = new global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Parametro, global::LightSwitchApplication.Parametro.DetailsClass, string>.Entry(
                        "Clave",
                        global::LightSwitchApplication.Parametro.DetailsClass.PropertySetProperties._Clave_Stub,
                        global::LightSwitchApplication.Parametro.DetailsClass.PropertySetProperties._Clave_ComputeIsReadOnly,
                        global::LightSwitchApplication.Parametro.DetailsClass.PropertySetProperties._Clave_Validate,
                        global::LightSwitchApplication.Parametro.DetailsClass.PropertySetProperties._Clave_GetImplementationValue,
                        global::LightSwitchApplication.Parametro.DetailsClass.PropertySetProperties._Clave_SetImplementationValue,
                        global::LightSwitchApplication.Parametro.DetailsClass.PropertySetProperties._Clave_OnValueChanged);
                private static void _Clave_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.Parametro.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Parametro, global::LightSwitchApplication.Parametro.DetailsClass, string>.Data> c, global::LightSwitchApplication.Parametro.DetailsClass d, object sf)
                {
                    c(d, ref d._Clave, sf);
                }
                private static bool _Clave_ComputeIsReadOnly(global::LightSwitchApplication.Parametro e)
                {
                    bool result = false;
                    e.Clave_IsReadOnly(ref result);
                    return result;
                }
                private static void _Clave_Validate(global::LightSwitchApplication.Parametro e, global::Microsoft.LightSwitch.EntityValidationResultsBuilder r)
                {
                    e.Clave_Validate(r);
                }
                private static string _Clave_GetImplementationValue(global::LightSwitchApplication.Parametro.DetailsClass d)
                {
                    return d.ImplementationEntity.Clave;
                }
                private static void _Clave_SetImplementationValue(global::LightSwitchApplication.Parametro.DetailsClass d, string v)
                {
                    d.ImplementationEntity.Clave = v;
                }
                private static void _Clave_OnValueChanged(global::LightSwitchApplication.Parametro e)
                {
                    e.Clave_Changed();
                }
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Parametro, global::LightSwitchApplication.Parametro.DetailsClass, string>.Entry
                    Valor = new global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Parametro, global::LightSwitchApplication.Parametro.DetailsClass, string>.Entry(
                        "Valor",
                        global::LightSwitchApplication.Parametro.DetailsClass.PropertySetProperties._Valor_Stub,
                        global::LightSwitchApplication.Parametro.DetailsClass.PropertySetProperties._Valor_ComputeIsReadOnly,
                        global::LightSwitchApplication.Parametro.DetailsClass.PropertySetProperties._Valor_Validate,
                        global::LightSwitchApplication.Parametro.DetailsClass.PropertySetProperties._Valor_GetImplementationValue,
                        global::LightSwitchApplication.Parametro.DetailsClass.PropertySetProperties._Valor_SetImplementationValue,
                        global::LightSwitchApplication.Parametro.DetailsClass.PropertySetProperties._Valor_OnValueChanged);
                private static void _Valor_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.Parametro.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Parametro, global::LightSwitchApplication.Parametro.DetailsClass, string>.Data> c, global::LightSwitchApplication.Parametro.DetailsClass d, object sf)
                {
                    c(d, ref d._Valor, sf);
                }
                private static bool _Valor_ComputeIsReadOnly(global::LightSwitchApplication.Parametro e)
                {
                    bool result = false;
                    e.Valor_IsReadOnly(ref result);
                    return result;
                }
                private static void _Valor_Validate(global::LightSwitchApplication.Parametro e, global::Microsoft.LightSwitch.EntityValidationResultsBuilder r)
                {
                    e.Valor_Validate(r);
                }
                private static string _Valor_GetImplementationValue(global::LightSwitchApplication.Parametro.DetailsClass d)
                {
                    return d.ImplementationEntity.Valor;
                }
                private static void _Valor_SetImplementationValue(global::LightSwitchApplication.Parametro.DetailsClass d, string v)
                {
                    d.ImplementationEntity.Valor = v;
                }
                private static void _Valor_OnValueChanged(global::LightSwitchApplication.Parametro e)
                {
                    e.Valor_Changed();
                }
    
            }
    
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Parametro, global::LightSwitchApplication.Parametro.DetailsClass, int>.Data _Id;
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Parametro, global::LightSwitchApplication.Parametro.DetailsClass, byte[]>.Data _RowVersion;
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Parametro, global::LightSwitchApplication.Parametro.DetailsClass, string>.Data _Categoria;
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Parametro, global::LightSwitchApplication.Parametro.DetailsClass, string>.Data _Clave;
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Parametro, global::LightSwitchApplication.Parametro.DetailsClass, string>.Data _Valor;
            
        }
    
        #endregion
    }
    
    #endregion
}
