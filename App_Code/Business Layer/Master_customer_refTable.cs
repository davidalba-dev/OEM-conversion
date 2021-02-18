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
/// See <see cref="BaseMaster_customer_refTable"></see> for additional information.
/// </summary>
/// <remarks>
/// See <see cref="BaseMaster_customer_refTable"></see> for additional information.
/// <para>
/// This class is implemented using the Singleton design pattern.
/// </para>
/// </remarks>
/// <seealso cref="BaseMaster_customer_refTable"></seealso>
/// <seealso cref="BaseMaster_customer_refSqlTable"></seealso>
/// <seealso cref="Master_customer_refSqlTable"></seealso>
/// <seealso cref="Master_customer_refDefinition"></seealso>
/// <seealso cref="Master_customer_refRecord"></seealso>
/// <seealso cref="BaseMaster_customer_refRecord"></seealso>
[SerializableAttribute()]
public class Master_customer_refTable : BaseMaster_customer_refTable, System.Runtime.Serialization.ISerializable, ISingleton
{

#region "ISerializable Members"

    /// <summary>
    /// Overridden to use the <see cref="Master_customer_refTable_SerializationHelper"></see> class 
    /// for deserialization of <see cref="Master_customer_refTable"></see> data.
    /// </summary>
    /// <remarks>
    /// Since the <see cref="Master_customer_refTable"></see> class is implemented using the Singleton design pattern, 
    /// this method must be overridden to prevent additional instances from being created during deserialization.
    /// </remarks>
    void System.Runtime.Serialization.ISerializable.GetObjectData(
        System.Runtime.Serialization.SerializationInfo info, 
        System.Runtime.Serialization.StreamingContext context)
    {
        info.SetType(typeof(Master_customer_refTable_SerializationHelper)); //No other values need to be added
    }

#region "Class Master_customer_refTable_SerializationHelper"

    [SerializableAttribute()]
    private class Master_customer_refTable_SerializationHelper: System.Runtime.Serialization.IObjectReference
    {
        //Method called after this object is deserialized
        public virtual object GetRealObject(System.Runtime.Serialization.StreamingContext context)
        {
            return Master_customer_refTable.Instance;
        }
    }

#endregion

#endregion

    /// <summary>
    /// References the only instance of the <see cref="Master_customer_refTable"></see> class.
    /// </summary>
    /// <remarks>
    /// Since the <see cref="Master_customer_refTable"></see> class is implemented using the Singleton design pattern, 
    /// this field is the only way to access an instance of the class.
    /// </remarks>
    public readonly static Master_customer_refTable Instance = new Master_customer_refTable();

    public Master_customer_refTable()
    {
    }


} // End class Master_customer_refTable

}
