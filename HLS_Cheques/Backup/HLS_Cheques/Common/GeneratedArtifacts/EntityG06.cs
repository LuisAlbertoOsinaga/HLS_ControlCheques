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
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
    public sealed partial class Banco : global::Microsoft.LightSwitch.Framework.Base.EntityObject<global::LightSwitchApplication.Banco, global::LightSwitchApplication.Banco.DetailsClass>
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new instance of the Banco entity.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public Banco()
            : this(null)
        {
        }
    
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public Banco(global::Microsoft.LightSwitch.Framework.EntitySet<global::LightSwitchApplication.Banco> entitySet)
            : base(entitySet)
        {
            global::LightSwitchApplication.Banco.DetailsClass.Initialize(this);
        }
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Banco_Created();
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Banco_AllowSaveWithErrors(ref bool result);
    
        #endregion
    
        #region Private Properties
        
        /// <summary>
        /// Gets the Application object for this application.  The Application object provides access to active screens, methods to open screens and access to the current user.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private global::Microsoft.LightSwitch.IApplication<global::LightSwitchApplication.DataWorkspace> Application
        {
            get
            {
                return global::LightSwitchApplication.Application.Current;
            }
        }
        
        /// <summary>
        /// Gets the containing data workspace.  The data workspace provides access to all data sources in the application.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
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
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public int Id
        {
            get
            {
                return global::LightSwitchApplication.Banco.DetailsClass.GetValue(this, global::LightSwitchApplication.Banco.DetailsClass.PropertySetProperties.Id);
            }
            set
            {
                global::LightSwitchApplication.Banco.DetailsClass.SetValue(this, global::LightSwitchApplication.Banco.DetailsClass.PropertySetProperties.Id, value);
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
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public byte[] RowVersion
        {
            get
            {
                return global::LightSwitchApplication.Banco.DetailsClass.GetValue(this, global::LightSwitchApplication.Banco.DetailsClass.PropertySetProperties.RowVersion);
            }
            set
            {
                global::LightSwitchApplication.Banco.DetailsClass.SetValue(this, global::LightSwitchApplication.Banco.DetailsClass.PropertySetProperties.RowVersion, value);
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
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public string Sigla
        {
            get
            {
                return global::LightSwitchApplication.Banco.DetailsClass.GetValue(this, global::LightSwitchApplication.Banco.DetailsClass.PropertySetProperties.Sigla);
            }
            set
            {
                global::LightSwitchApplication.Banco.DetailsClass.SetValue(this, global::LightSwitchApplication.Banco.DetailsClass.PropertySetProperties.Sigla, value);
            }
        }
        
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Sigla_IsReadOnly(ref bool result);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Sigla_Validate(global::Microsoft.LightSwitch.EntityValidationResultsBuilder results);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Sigla_Changed();

        /// <summary>
        /// No Modeled Description Available
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public string Nombre
        {
            get
            {
                return global::LightSwitchApplication.Banco.DetailsClass.GetValue(this, global::LightSwitchApplication.Banco.DetailsClass.PropertySetProperties.Nombre);
            }
            set
            {
                global::LightSwitchApplication.Banco.DetailsClass.SetValue(this, global::LightSwitchApplication.Banco.DetailsClass.PropertySetProperties.Nombre, value);
            }
        }
        
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Nombre_IsReadOnly(ref bool result);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Nombre_Validate(global::Microsoft.LightSwitch.EntityValidationResultsBuilder results);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Nombre_Changed();

        /// <summary>
        /// No Modeled Description Available
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Microsoft.LightSwitch.Framework.EntityCollection<global::LightSwitchApplication.CuentaBanco> CuentaBancos
        {
            get
            {
                return global::LightSwitchApplication.Banco.DetailsClass.GetValue(this, global::LightSwitchApplication.Banco.DetailsClass.PropertySetProperties.CuentaBancos);
            }
        }
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public Microsoft.LightSwitch.IDataServiceQueryable<global::LightSwitchApplication.CuentaBanco> CuentaBancosQuery
        {
            get
            {
                return global::LightSwitchApplication.Banco.DetailsClass.GetQuery(this, global::LightSwitchApplication.Banco.DetailsClass.PropertySetProperties.CuentaBancos);
            }
        }

        #endregion
    
        #region Details Class
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public sealed class DetailsClass : global::Microsoft.LightSwitch.Details.Framework.Base.EntityDetails<
                global::LightSwitchApplication.Banco,
                global::LightSwitchApplication.Banco.DetailsClass,
                global::LightSwitchApplication.Banco.DetailsClass.IImplementation,
                global::LightSwitchApplication.Banco.DetailsClass.PropertySet,
                global::Microsoft.LightSwitch.Details.Framework.EntityCommandSet<global::LightSwitchApplication.Banco, global::LightSwitchApplication.Banco.DetailsClass>,
                global::Microsoft.LightSwitch.Details.Framework.EntityMethodSet<global::LightSwitchApplication.Banco, global::LightSwitchApplication.Banco.DetailsClass>>
        {
    
            static DetailsClass()
            {
                var initializeEntry = global::LightSwitchApplication.Banco.DetailsClass.PropertySetProperties.Id;
            }
    
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private static readonly global::Microsoft.LightSwitch.Details.Framework.Base.EntityDetails<global::LightSwitchApplication.Banco, global::LightSwitchApplication.Banco.DetailsClass>.Entry
                __BancoEntry = new global::Microsoft.LightSwitch.Details.Framework.Base.EntityDetails<global::LightSwitchApplication.Banco, global::LightSwitchApplication.Banco.DetailsClass>.Entry(
                    global::LightSwitchApplication.Banco.DetailsClass.__Banco_CreateNew,
                    global::LightSwitchApplication.Banco.DetailsClass.__Banco_Created,
                    global::LightSwitchApplication.Banco.DetailsClass.__Banco_AllowSaveWithErrors);
            private static global::LightSwitchApplication.Banco __Banco_CreateNew(global::Microsoft.LightSwitch.Framework.EntitySet<global::LightSwitchApplication.Banco> es)
            {
                return new global::LightSwitchApplication.Banco(es);
            }
            private static void __Banco_Created(global::LightSwitchApplication.Banco e)
            {
                e.Banco_Created();
            }
            private static bool __Banco_AllowSaveWithErrors(global::LightSwitchApplication.Banco e)
            {
                bool result = false;
                e.Banco_AllowSaveWithErrors(ref result);
                return result;
            }
    
            public DetailsClass() : base()
            {
            }
    
            public new global::Microsoft.LightSwitch.Details.Framework.EntityCommandSet<global::LightSwitchApplication.Banco, global::LightSwitchApplication.Banco.DetailsClass> Commands
            {
                get
                {
                    return base.Commands;
                }
            }
    
            public new global::Microsoft.LightSwitch.Details.Framework.EntityMethodSet<global::LightSwitchApplication.Banco, global::LightSwitchApplication.Banco.DetailsClass> Methods
            {
                get
                {
                    return base.Methods;
                }
            }
    
            public new global::LightSwitchApplication.Banco.DetailsClass.PropertySet Properties
            {
                get
                {
                    return base.Properties;
                }
            }
    
            [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
            [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public sealed class PropertySet : global::Microsoft.LightSwitch.Details.Framework.Base.EntityPropertySet<global::LightSwitchApplication.Banco, global::LightSwitchApplication.Banco.DetailsClass>
            {
    
                public PropertySet() : base()
                {
                }
    
                public global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Banco, global::LightSwitchApplication.Banco.DetailsClass, int> Id
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.Banco.DetailsClass.PropertySetProperties.Id) as global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Banco, global::LightSwitchApplication.Banco.DetailsClass, int>;
                    }
                }
                
                public global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Banco, global::LightSwitchApplication.Banco.DetailsClass, byte[]> RowVersion
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.Banco.DetailsClass.PropertySetProperties.RowVersion) as global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Banco, global::LightSwitchApplication.Banco.DetailsClass, byte[]>;
                    }
                }
                
                public global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Banco, global::LightSwitchApplication.Banco.DetailsClass, string> Sigla
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.Banco.DetailsClass.PropertySetProperties.Sigla) as global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Banco, global::LightSwitchApplication.Banco.DetailsClass, string>;
                    }
                }
                
                public global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Banco, global::LightSwitchApplication.Banco.DetailsClass, string> Nombre
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.Banco.DetailsClass.PropertySetProperties.Nombre) as global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Banco, global::LightSwitchApplication.Banco.DetailsClass, string>;
                    }
                }
                
                public global::Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty<global::LightSwitchApplication.Banco, global::LightSwitchApplication.Banco.DetailsClass, global::LightSwitchApplication.CuentaBanco> CuentaBancos
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.Banco.DetailsClass.PropertySetProperties.CuentaBancos) as global::Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty<global::LightSwitchApplication.Banco, global::LightSwitchApplication.Banco.DetailsClass, global::LightSwitchApplication.CuentaBanco>;
                    }
                }
                
            }
    
            #pragma warning disable 109
            [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
            public interface IImplementation : global::Microsoft.LightSwitch.Internal.IEntityImplementation
            {
                new int Id { get; set; }
                new byte[] RowVersion { get; set; }
                new string Sigla { get; set; }
                new string Nombre { get; set; }
                new global::System.Collections.IEnumerable CuentaBancos { get; }
            }
            #pragma warning restore 109
    
            [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            internal class PropertySetProperties
            {
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Banco, global::LightSwitchApplication.Banco.DetailsClass, int>.Entry
                    Id = new global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Banco, global::LightSwitchApplication.Banco.DetailsClass, int>.Entry(
                        "Id",
                        global::LightSwitchApplication.Banco.DetailsClass.PropertySetProperties._Id_Stub,
                        global::LightSwitchApplication.Banco.DetailsClass.PropertySetProperties._Id_ComputeIsReadOnly,
                        global::LightSwitchApplication.Banco.DetailsClass.PropertySetProperties._Id_Validate,
                        global::LightSwitchApplication.Banco.DetailsClass.PropertySetProperties._Id_GetImplementationValue,
                        global::LightSwitchApplication.Banco.DetailsClass.PropertySetProperties._Id_SetImplementationValue,
                        global::LightSwitchApplication.Banco.DetailsClass.PropertySetProperties._Id_OnValueChanged);
                private static void _Id_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.Banco.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Banco, global::LightSwitchApplication.Banco.DetailsClass, int>.Data> c, global::LightSwitchApplication.Banco.DetailsClass d, object sf)
                {
                    c(d, ref d._Id, sf);
                }
                private static bool _Id_ComputeIsReadOnly(global::LightSwitchApplication.Banco e)
                {
                    bool result = false;
                    e.Id_IsReadOnly(ref result);
                    return result;
                }
                private static void _Id_Validate(global::LightSwitchApplication.Banco e, global::Microsoft.LightSwitch.EntityValidationResultsBuilder r)
                {
                    e.Id_Validate(r);
                }
                private static int _Id_GetImplementationValue(global::LightSwitchApplication.Banco.DetailsClass d)
                {
                    return d.ImplementationEntity.Id;
                }
                private static void _Id_SetImplementationValue(global::LightSwitchApplication.Banco.DetailsClass d, int v)
                {
                    d.ImplementationEntity.Id = v;
                }
                private static void _Id_OnValueChanged(global::LightSwitchApplication.Banco e)
                {
                    e.Id_Changed();
                }
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Banco, global::LightSwitchApplication.Banco.DetailsClass, byte[]>.Entry
                    RowVersion = new global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Banco, global::LightSwitchApplication.Banco.DetailsClass, byte[]>.Entry(
                        "RowVersion",
                        global::LightSwitchApplication.Banco.DetailsClass.PropertySetProperties._RowVersion_Stub,
                        global::LightSwitchApplication.Banco.DetailsClass.PropertySetProperties._RowVersion_ComputeIsReadOnly,
                        global::LightSwitchApplication.Banco.DetailsClass.PropertySetProperties._RowVersion_Validate,
                        global::LightSwitchApplication.Banco.DetailsClass.PropertySetProperties._RowVersion_GetImplementationValue,
                        global::LightSwitchApplication.Banco.DetailsClass.PropertySetProperties._RowVersion_SetImplementationValue,
                        global::LightSwitchApplication.Banco.DetailsClass.PropertySetProperties._RowVersion_OnValueChanged);
                private static void _RowVersion_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.Banco.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Banco, global::LightSwitchApplication.Banco.DetailsClass, byte[]>.Data> c, global::LightSwitchApplication.Banco.DetailsClass d, object sf)
                {
                    c(d, ref d._RowVersion, sf);
                }
                private static bool _RowVersion_ComputeIsReadOnly(global::LightSwitchApplication.Banco e)
                {
                    bool result = false;
                    e.RowVersion_IsReadOnly(ref result);
                    return result;
                }
                private static void _RowVersion_Validate(global::LightSwitchApplication.Banco e, global::Microsoft.LightSwitch.EntityValidationResultsBuilder r)
                {
                    e.RowVersion_Validate(r);
                }
                private static byte[] _RowVersion_GetImplementationValue(global::LightSwitchApplication.Banco.DetailsClass d)
                {
                    return d.ImplementationEntity.RowVersion;
                }
                private static void _RowVersion_SetImplementationValue(global::LightSwitchApplication.Banco.DetailsClass d, byte[] v)
                {
                    d.ImplementationEntity.RowVersion = v;
                }
                private static void _RowVersion_OnValueChanged(global::LightSwitchApplication.Banco e)
                {
                    e.RowVersion_Changed();
                }
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Banco, global::LightSwitchApplication.Banco.DetailsClass, string>.Entry
                    Sigla = new global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Banco, global::LightSwitchApplication.Banco.DetailsClass, string>.Entry(
                        "Sigla",
                        global::LightSwitchApplication.Banco.DetailsClass.PropertySetProperties._Sigla_Stub,
                        global::LightSwitchApplication.Banco.DetailsClass.PropertySetProperties._Sigla_ComputeIsReadOnly,
                        global::LightSwitchApplication.Banco.DetailsClass.PropertySetProperties._Sigla_Validate,
                        global::LightSwitchApplication.Banco.DetailsClass.PropertySetProperties._Sigla_GetImplementationValue,
                        global::LightSwitchApplication.Banco.DetailsClass.PropertySetProperties._Sigla_SetImplementationValue,
                        global::LightSwitchApplication.Banco.DetailsClass.PropertySetProperties._Sigla_OnValueChanged);
                private static void _Sigla_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.Banco.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Banco, global::LightSwitchApplication.Banco.DetailsClass, string>.Data> c, global::LightSwitchApplication.Banco.DetailsClass d, object sf)
                {
                    c(d, ref d._Sigla, sf);
                }
                private static bool _Sigla_ComputeIsReadOnly(global::LightSwitchApplication.Banco e)
                {
                    bool result = false;
                    e.Sigla_IsReadOnly(ref result);
                    return result;
                }
                private static void _Sigla_Validate(global::LightSwitchApplication.Banco e, global::Microsoft.LightSwitch.EntityValidationResultsBuilder r)
                {
                    e.Sigla_Validate(r);
                }
                private static string _Sigla_GetImplementationValue(global::LightSwitchApplication.Banco.DetailsClass d)
                {
                    return d.ImplementationEntity.Sigla;
                }
                private static void _Sigla_SetImplementationValue(global::LightSwitchApplication.Banco.DetailsClass d, string v)
                {
                    d.ImplementationEntity.Sigla = v;
                }
                private static void _Sigla_OnValueChanged(global::LightSwitchApplication.Banco e)
                {
                    e.Sigla_Changed();
                }
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Banco, global::LightSwitchApplication.Banco.DetailsClass, string>.Entry
                    Nombre = new global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Banco, global::LightSwitchApplication.Banco.DetailsClass, string>.Entry(
                        "Nombre",
                        global::LightSwitchApplication.Banco.DetailsClass.PropertySetProperties._Nombre_Stub,
                        global::LightSwitchApplication.Banco.DetailsClass.PropertySetProperties._Nombre_ComputeIsReadOnly,
                        global::LightSwitchApplication.Banco.DetailsClass.PropertySetProperties._Nombre_Validate,
                        global::LightSwitchApplication.Banco.DetailsClass.PropertySetProperties._Nombre_GetImplementationValue,
                        global::LightSwitchApplication.Banco.DetailsClass.PropertySetProperties._Nombre_SetImplementationValue,
                        global::LightSwitchApplication.Banco.DetailsClass.PropertySetProperties._Nombre_OnValueChanged);
                private static void _Nombre_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.Banco.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Banco, global::LightSwitchApplication.Banco.DetailsClass, string>.Data> c, global::LightSwitchApplication.Banco.DetailsClass d, object sf)
                {
                    c(d, ref d._Nombre, sf);
                }
                private static bool _Nombre_ComputeIsReadOnly(global::LightSwitchApplication.Banco e)
                {
                    bool result = false;
                    e.Nombre_IsReadOnly(ref result);
                    return result;
                }
                private static void _Nombre_Validate(global::LightSwitchApplication.Banco e, global::Microsoft.LightSwitch.EntityValidationResultsBuilder r)
                {
                    e.Nombre_Validate(r);
                }
                private static string _Nombre_GetImplementationValue(global::LightSwitchApplication.Banco.DetailsClass d)
                {
                    return d.ImplementationEntity.Nombre;
                }
                private static void _Nombre_SetImplementationValue(global::LightSwitchApplication.Banco.DetailsClass d, string v)
                {
                    d.ImplementationEntity.Nombre = v;
                }
                private static void _Nombre_OnValueChanged(global::LightSwitchApplication.Banco e)
                {
                    e.Nombre_Changed();
                }
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty<global::LightSwitchApplication.Banco, global::LightSwitchApplication.Banco.DetailsClass, global::LightSwitchApplication.CuentaBanco>.Entry
                    CuentaBancos = new global::Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty<global::LightSwitchApplication.Banco, global::LightSwitchApplication.Banco.DetailsClass, global::LightSwitchApplication.CuentaBanco>.Entry(
                        "CuentaBancos",
                        global::LightSwitchApplication.Banco.DetailsClass.PropertySetProperties._CuentaBancos_Stub,
                        global::LightSwitchApplication.Banco.DetailsClass.PropertySetProperties._CuentaBancos_GetReferencedEntities,
                        global::LightSwitchApplication.Banco.DetailsClass.PropertySetProperties._CuentaBancos_GetEntityCollection);
                private static void _CuentaBancos_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.Banco.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty<global::LightSwitchApplication.Banco, global::LightSwitchApplication.Banco.DetailsClass, global::LightSwitchApplication.CuentaBanco>.Data> c, global::LightSwitchApplication.Banco.DetailsClass d, object sf)
                {
                    c(d, ref d._CuentaBancos, sf);
                }
                private static global::System.Collections.Generic.IEnumerable<global::LightSwitchApplication.CuentaBanco> _CuentaBancos_GetReferencedEntities(global::LightSwitchApplication.Banco.DetailsClass d)
                {
                    return d.GetReferencedEntities<global::LightSwitchApplication.CuentaBanco, global::LightSwitchApplication.CuentaBanco.DetailsClass>(global::LightSwitchApplication.Banco.DetailsClass.PropertySetProperties.CuentaBancos, ref d._CuentaBancos);
                }
                private static global::System.Collections.IEnumerable _CuentaBancos_GetEntityCollection(global::LightSwitchApplication.Banco.DetailsClass d)
                {
                    return d.ImplementationEntity.CuentaBancos;
                }
    
            }
    
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Banco, global::LightSwitchApplication.Banco.DetailsClass, int>.Data _Id;
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Banco, global::LightSwitchApplication.Banco.DetailsClass, byte[]>.Data _RowVersion;
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Banco, global::LightSwitchApplication.Banco.DetailsClass, string>.Data _Sigla;
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Banco, global::LightSwitchApplication.Banco.DetailsClass, string>.Data _Nombre;
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty<global::LightSwitchApplication.Banco, global::LightSwitchApplication.Banco.DetailsClass, global::LightSwitchApplication.CuentaBanco>.Data _CuentaBancos;
            
        }
    
        #endregion
    }
    
    #endregion
}
