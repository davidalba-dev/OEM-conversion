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
/// See <see cref="BaseCustomer_payTable"></see> for additional information.
/// </summary>
/// <remarks>
/// See <see cref="BaseCustomer_payTable"></see> for additional information.
/// <para>
/// This class is implemented using the Singleton design pattern.
/// </para>
/// </remarks>
/// <seealso cref="BaseCustomer_payTable"></seealso>
/// <seealso cref="BaseCustomer_paySqlTable"></seealso>
/// <seealso cref="Customer_paySqlTable"></seealso>
/// <seealso cref="Customer_payDefinition"></seealso>
/// <seealso cref="Customer_payRecord"></seealso>
/// <seealso cref="BaseCustomer_payRecord"></seealso>
[SerializableAttribute()]
public class Customer_payTable : BaseCustomer_payTable, System.Runtime.Serialization.ISerializable, ISingleton
{

#region "ISerializable Members"

    /// <summary>
    /// Overridden to use the <see cref="Customer_payTable_SerializationHelper"></see> class 
    /// for deserialization of <see cref="Customer_payTable"></see> data.
    /// </summary>
    /// <remarks>
    /// Since the <see cref="Customer_payTable"></see> class is implemented using the Singleton design pattern, 
    /// this method must be overridden to prevent additional instances from being created during deserialization.
    /// </remarks>
    void System.Runtime.Serialization.ISerializable.GetObjectData(
        System.Runtime.Serialization.SerializationInfo info, 
        System.Runtime.Serialization.StreamingContext context)
    {
        info.SetType(typeof(Customer_payTable_SerializationHelper)); //No other values need to be added
    }

#region "Class Customer_payTable_SerializationHelper"

    [SerializableAttribute()]
    private class Customer_payTable_SerializationHelper: System.Runtime.Serialization.IObjectReference
    {
        //Method called after this object is deserialized
        public virtual object GetRealObject(System.Runtime.Serialization.StreamingContext context)
        {
            return Customer_payTable.Instance;
        }
    }

#endregion

#endregion

    /// <summary>
    /// References the only instance of the <see cref="Customer_payTable"></see> class.
    /// </summary>
    /// <remarks>
    /// Since the <see cref="Customer_payTable"></see> class is implemented using the Singleton design pattern, 
    /// this field is the only way to access an instance of the class.
    /// </remarks>
    public readonly static Customer_payTable Instance = new Customer_payTable();

    public Customer_payTable()
    {
    }


} // End class Customer_payTable

}
