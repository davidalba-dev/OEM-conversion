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
/// See <see cref="BaseCustomercontact_vendorTable"></see> for additional information.
/// </summary>
/// <remarks>
/// See <see cref="BaseCustomercontact_vendorTable"></see> for additional information.
/// <para>
/// This class is implemented using the Singleton design pattern.
/// </para>
/// </remarks>
/// <seealso cref="BaseCustomercontact_vendorTable"></seealso>
/// <seealso cref="BaseCustomercontact_vendorSqlTable"></seealso>
/// <seealso cref="Customercontact_vendorSqlTable"></seealso>
/// <seealso cref="Customercontact_vendorDefinition"></seealso>
/// <seealso cref="Customercontact_vendorRecord"></seealso>
/// <seealso cref="BaseCustomercontact_vendorRecord"></seealso>
[SerializableAttribute()]
public class Customercontact_vendorTable : BaseCustomercontact_vendorTable, System.Runtime.Serialization.ISerializable, ISingleton
{

#region "ISerializable Members"

    /// <summary>
    /// Overridden to use the <see cref="Customercontact_vendorTable_SerializationHelper"></see> class 
    /// for deserialization of <see cref="Customercontact_vendorTable"></see> data.
    /// </summary>
    /// <remarks>
    /// Since the <see cref="Customercontact_vendorTable"></see> class is implemented using the Singleton design pattern, 
    /// this method must be overridden to prevent additional instances from being created during deserialization.
    /// </remarks>
    void System.Runtime.Serialization.ISerializable.GetObjectData(
        System.Runtime.Serialization.SerializationInfo info, 
        System.Runtime.Serialization.StreamingContext context)
    {
        info.SetType(typeof(Customercontact_vendorTable_SerializationHelper)); //No other values need to be added
    }

#region "Class Customercontact_vendorTable_SerializationHelper"

    [SerializableAttribute()]
    private class Customercontact_vendorTable_SerializationHelper: System.Runtime.Serialization.IObjectReference
    {
        //Method called after this object is deserialized
        public virtual object GetRealObject(System.Runtime.Serialization.StreamingContext context)
        {
            return Customercontact_vendorTable.Instance;
        }
    }

#endregion

#endregion

    /// <summary>
    /// References the only instance of the <see cref="Customercontact_vendorTable"></see> class.
    /// </summary>
    /// <remarks>
    /// Since the <see cref="Customercontact_vendorTable"></see> class is implemented using the Singleton design pattern, 
    /// this field is the only way to access an instance of the class.
    /// </remarks>
    public readonly static Customercontact_vendorTable Instance = new Customercontact_vendorTable();

    public Customercontact_vendorTable()
    {
    }


} // End class Customercontact_vendorTable

}
