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
/// See <see cref="BaseContractor_contact_rateTable"></see> for additional information.
/// </summary>
/// <remarks>
/// See <see cref="BaseContractor_contact_rateTable"></see> for additional information.
/// <para>
/// This class is implemented using the Singleton design pattern.
/// </para>
/// </remarks>
/// <seealso cref="BaseContractor_contact_rateTable"></seealso>
/// <seealso cref="BaseContractor_contact_rateSqlTable"></seealso>
/// <seealso cref="Contractor_contact_rateSqlTable"></seealso>
/// <seealso cref="Contractor_contact_rateDefinition"></seealso>
/// <seealso cref="Contractor_contact_rateRecord"></seealso>
/// <seealso cref="BaseContractor_contact_rateRecord"></seealso>
[SerializableAttribute()]
public class Contractor_contact_rateTable : BaseContractor_contact_rateTable, System.Runtime.Serialization.ISerializable, ISingleton
{

#region "ISerializable Members"

    /// <summary>
    /// Overridden to use the <see cref="Contractor_contact_rateTable_SerializationHelper"></see> class 
    /// for deserialization of <see cref="Contractor_contact_rateTable"></see> data.
    /// </summary>
    /// <remarks>
    /// Since the <see cref="Contractor_contact_rateTable"></see> class is implemented using the Singleton design pattern, 
    /// this method must be overridden to prevent additional instances from being created during deserialization.
    /// </remarks>
    void System.Runtime.Serialization.ISerializable.GetObjectData(
        System.Runtime.Serialization.SerializationInfo info, 
        System.Runtime.Serialization.StreamingContext context)
    {
        info.SetType(typeof(Contractor_contact_rateTable_SerializationHelper)); //No other values need to be added
    }

#region "Class Contractor_contact_rateTable_SerializationHelper"

    [SerializableAttribute()]
    private class Contractor_contact_rateTable_SerializationHelper: System.Runtime.Serialization.IObjectReference
    {
        //Method called after this object is deserialized
        public virtual object GetRealObject(System.Runtime.Serialization.StreamingContext context)
        {
            return Contractor_contact_rateTable.Instance;
        }
    }

#endregion

#endregion

    /// <summary>
    /// References the only instance of the <see cref="Contractor_contact_rateTable"></see> class.
    /// </summary>
    /// <remarks>
    /// Since the <see cref="Contractor_contact_rateTable"></see> class is implemented using the Singleton design pattern, 
    /// this field is the only way to access an instance of the class.
    /// </remarks>
    public readonly static Contractor_contact_rateTable Instance = new Contractor_contact_rateTable();

    public Contractor_contact_rateTable()
    {
    }


} // End class Contractor_contact_rateTable

}
