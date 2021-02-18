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
/// See <see cref="BaseContractor_skillsTable"></see> for additional information.
/// </summary>
/// <remarks>
/// See <see cref="BaseContractor_skillsTable"></see> for additional information.
/// <para>
/// This class is implemented using the Singleton design pattern.
/// </para>
/// </remarks>
/// <seealso cref="BaseContractor_skillsTable"></seealso>
/// <seealso cref="BaseContractor_skillsSqlTable"></seealso>
/// <seealso cref="Contractor_skillsSqlTable"></seealso>
/// <seealso cref="Contractor_skillsDefinition"></seealso>
/// <seealso cref="Contractor_skillsRecord"></seealso>
/// <seealso cref="BaseContractor_skillsRecord"></seealso>
[SerializableAttribute()]
public class Contractor_skillsTable : BaseContractor_skillsTable, System.Runtime.Serialization.ISerializable, ISingleton
{

#region "ISerializable Members"

    /// <summary>
    /// Overridden to use the <see cref="Contractor_skillsTable_SerializationHelper"></see> class 
    /// for deserialization of <see cref="Contractor_skillsTable"></see> data.
    /// </summary>
    /// <remarks>
    /// Since the <see cref="Contractor_skillsTable"></see> class is implemented using the Singleton design pattern, 
    /// this method must be overridden to prevent additional instances from being created during deserialization.
    /// </remarks>
    void System.Runtime.Serialization.ISerializable.GetObjectData(
        System.Runtime.Serialization.SerializationInfo info, 
        System.Runtime.Serialization.StreamingContext context)
    {
        info.SetType(typeof(Contractor_skillsTable_SerializationHelper)); //No other values need to be added
    }

#region "Class Contractor_skillsTable_SerializationHelper"

    [SerializableAttribute()]
    private class Contractor_skillsTable_SerializationHelper: System.Runtime.Serialization.IObjectReference
    {
        //Method called after this object is deserialized
        public virtual object GetRealObject(System.Runtime.Serialization.StreamingContext context)
        {
            return Contractor_skillsTable.Instance;
        }
    }

#endregion

#endregion

    /// <summary>
    /// References the only instance of the <see cref="Contractor_skillsTable"></see> class.
    /// </summary>
    /// <remarks>
    /// Since the <see cref="Contractor_skillsTable"></see> class is implemented using the Singleton design pattern, 
    /// this field is the only way to access an instance of the class.
    /// </remarks>
    public readonly static Contractor_skillsTable Instance = new Contractor_skillsTable();

    public Contractor_skillsTable()
    {
    }


} // End class Contractor_skillsTable

}
