﻿// This is a "safe" class, meaning that it is created once 
// and never overwritten. Any custom code you add to this class 
// will be preserved when you regenerate your application.
//
// Typical customizations that may be done in this class include
//  - adding custom event handlers
//  - overriding base class methods

using System;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace OEMConversion.Business
{

/// <summary>
/// Provides access to the schema information and record data of a database table (or view).
/// See <see cref="BaseRepairorder_customerView"></see> for additional information.
/// </summary>
/// <remarks>
/// See <see cref="BaseRepairorder_customerView"></see> for additional information.
/// <para>
/// This class is implemented using the Singleton design pattern.
/// </para>
/// </remarks>
/// <seealso cref="BaseRepairorder_customerView"></seealso>
/// <seealso cref="BaseRepairorder_customerSqlView"></seealso>
/// <seealso cref="Repairorder_customerSqlView"></seealso>
/// <seealso cref="Repairorder_customerDefinition"></seealso>
/// <seealso cref="Repairorder_customerRecord"></seealso>
/// <seealso cref="BaseRepairorder_customerRecord"></seealso>
[SerializableAttribute()]
public class Repairorder_customerView : BaseRepairorder_customerView, System.Runtime.Serialization.ISerializable, ISingleton
{

#region "ISerializable Members"

    /// <summary>
    /// Overridden to use the <see cref="Repairorder_customerView_SerializationHelper"></see> class 
    /// for deserialization of <see cref="Repairorder_customerView"></see> data.
    /// </summary>
    /// <remarks>
    /// Since the <see cref="Repairorder_customerView"></see> class is implemented using the Singleton design pattern, 
    /// this method must be overridden to prevent additional instances from being created during deserialization.
    /// </remarks>
    void System.Runtime.Serialization.ISerializable.GetObjectData(
        System.Runtime.Serialization.SerializationInfo info, 
        System.Runtime.Serialization.StreamingContext context)
    {
        info.SetType(typeof(Repairorder_customerView_SerializationHelper)); //No other values need to be added
    }

#region "Class Repairorder_customerView_SerializationHelper"

    [SerializableAttribute()]
    private class Repairorder_customerView_SerializationHelper: System.Runtime.Serialization.IObjectReference
    {
        //Method called after this object is deserialized
        public virtual object GetRealObject(System.Runtime.Serialization.StreamingContext context)
        {
            return Repairorder_customerView.Instance;
        }
    }

#endregion

#endregion

    /// <summary>
    /// References the only instance of the <see cref="Repairorder_customerView"></see> class.
    /// </summary>
    /// <remarks>
    /// Since the <see cref="Repairorder_customerView"></see> class is implemented using the Singleton design pattern, 
    /// this field is the only way to access an instance of the class.
    /// </remarks>
    public readonly static Repairorder_customerView Instance = new Repairorder_customerView();

    public Repairorder_customerView()
    {
    }


} // End class Repairorder_customerView

}
