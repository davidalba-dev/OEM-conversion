// This is a "safe" class, meaning that it is created once 
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
/// See <see cref="BaseProcurement_manufacturerTable"></see> for additional information.
/// </summary>
/// <remarks>
/// See <see cref="BaseProcurement_manufacturerTable"></see> for additional information.
/// <para>
/// This class is implemented using the Singleton design pattern.
/// </para>
/// </remarks>
/// <seealso cref="BaseProcurement_manufacturerTable"></seealso>
/// <seealso cref="BaseProcurement_manufacturerSqlTable"></seealso>
/// <seealso cref="Procurement_manufacturerSqlTable"></seealso>
/// <seealso cref="Procurement_manufacturerDefinition"></seealso>
/// <seealso cref="Procurement_manufacturerRecord"></seealso>
/// <seealso cref="BaseProcurement_manufacturerRecord"></seealso>
[SerializableAttribute()]
public class Procurement_manufacturerTable : BaseProcurement_manufacturerTable, System.Runtime.Serialization.ISerializable, ISingleton
{

#region "ISerializable Members"

    /// <summary>
    /// Overridden to use the <see cref="Procurement_manufacturerTable_SerializationHelper"></see> class 
    /// for deserialization of <see cref="Procurement_manufacturerTable"></see> data.
    /// </summary>
    /// <remarks>
    /// Since the <see cref="Procurement_manufacturerTable"></see> class is implemented using the Singleton design pattern, 
    /// this method must be overridden to prevent additional instances from being created during deserialization.
    /// </remarks>
    void System.Runtime.Serialization.ISerializable.GetObjectData(
        System.Runtime.Serialization.SerializationInfo info, 
        System.Runtime.Serialization.StreamingContext context)
    {
        info.SetType(typeof(Procurement_manufacturerTable_SerializationHelper)); //No other values need to be added
    }

#region "Class Procurement_manufacturerTable_SerializationHelper"

    [SerializableAttribute()]
    private class Procurement_manufacturerTable_SerializationHelper: System.Runtime.Serialization.IObjectReference
    {
        //Method called after this object is deserialized
        public virtual object GetRealObject(System.Runtime.Serialization.StreamingContext context)
        {
            return Procurement_manufacturerTable.Instance;
        }
    }

#endregion

#endregion

    /// <summary>
    /// References the only instance of the <see cref="Procurement_manufacturerTable"></see> class.
    /// </summary>
    /// <remarks>
    /// Since the <see cref="Procurement_manufacturerTable"></see> class is implemented using the Singleton design pattern, 
    /// this field is the only way to access an instance of the class.
    /// </remarks>
    public readonly static Procurement_manufacturerTable Instance = new Procurement_manufacturerTable();

    public Procurement_manufacturerTable()
    {
    }


} // End class Procurement_manufacturerTable

}
