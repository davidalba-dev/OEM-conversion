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
/// See <see cref="BaseRefurb_part_vendorTable"></see> for additional information.
/// </summary>
/// <remarks>
/// See <see cref="BaseRefurb_part_vendorTable"></see> for additional information.
/// <para>
/// This class is implemented using the Singleton design pattern.
/// </para>
/// </remarks>
/// <seealso cref="BaseRefurb_part_vendorTable"></seealso>
/// <seealso cref="BaseRefurb_part_vendorSqlTable"></seealso>
/// <seealso cref="Refurb_part_vendorSqlTable"></seealso>
/// <seealso cref="Refurb_part_vendorDefinition"></seealso>
/// <seealso cref="Refurb_part_vendorRecord"></seealso>
/// <seealso cref="BaseRefurb_part_vendorRecord"></seealso>
[SerializableAttribute()]
public class Refurb_part_vendorTable : BaseRefurb_part_vendorTable, System.Runtime.Serialization.ISerializable, ISingleton
{

#region "ISerializable Members"

    /// <summary>
    /// Overridden to use the <see cref="Refurb_part_vendorTable_SerializationHelper"></see> class 
    /// for deserialization of <see cref="Refurb_part_vendorTable"></see> data.
    /// </summary>
    /// <remarks>
    /// Since the <see cref="Refurb_part_vendorTable"></see> class is implemented using the Singleton design pattern, 
    /// this method must be overridden to prevent additional instances from being created during deserialization.
    /// </remarks>
    void System.Runtime.Serialization.ISerializable.GetObjectData(
        System.Runtime.Serialization.SerializationInfo info, 
        System.Runtime.Serialization.StreamingContext context)
    {
        info.SetType(typeof(Refurb_part_vendorTable_SerializationHelper)); //No other values need to be added
    }

#region "Class Refurb_part_vendorTable_SerializationHelper"

    [SerializableAttribute()]
    private class Refurb_part_vendorTable_SerializationHelper: System.Runtime.Serialization.IObjectReference
    {
        //Method called after this object is deserialized
        public virtual object GetRealObject(System.Runtime.Serialization.StreamingContext context)
        {
            return Refurb_part_vendorTable.Instance;
        }
    }

#endregion

#endregion

    /// <summary>
    /// References the only instance of the <see cref="Refurb_part_vendorTable"></see> class.
    /// </summary>
    /// <remarks>
    /// Since the <see cref="Refurb_part_vendorTable"></see> class is implemented using the Singleton design pattern, 
    /// this field is the only way to access an instance of the class.
    /// </remarks>
    public readonly static Refurb_part_vendorTable Instance = new Refurb_part_vendorTable();

    public Refurb_part_vendorTable()
    {
    }


} // End class Refurb_part_vendorTable

}
