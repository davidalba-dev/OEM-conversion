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
/// See <see cref="BaseTechniciansTable"></see> for additional information.
/// </summary>
/// <remarks>
/// See <see cref="BaseTechniciansTable"></see> for additional information.
/// <para>
/// This class is implemented using the Singleton design pattern.
/// </para>
/// </remarks>
/// <seealso cref="BaseTechniciansTable"></seealso>
/// <seealso cref="BaseTechniciansSqlTable"></seealso>
/// <seealso cref="TechniciansSqlTable"></seealso>
/// <seealso cref="TechniciansDefinition"></seealso>
/// <seealso cref="TechniciansRecord"></seealso>
/// <seealso cref="BaseTechniciansRecord"></seealso>
[SerializableAttribute()]
public class TechniciansTable : BaseTechniciansTable, System.Runtime.Serialization.ISerializable, ISingleton
{

#region "ISerializable Members"

    /// <summary>
    /// Overridden to use the <see cref="TechniciansTable_SerializationHelper"></see> class 
    /// for deserialization of <see cref="TechniciansTable"></see> data.
    /// </summary>
    /// <remarks>
    /// Since the <see cref="TechniciansTable"></see> class is implemented using the Singleton design pattern, 
    /// this method must be overridden to prevent additional instances from being created during deserialization.
    /// </remarks>
    void System.Runtime.Serialization.ISerializable.GetObjectData(
        System.Runtime.Serialization.SerializationInfo info, 
        System.Runtime.Serialization.StreamingContext context)
    {
        info.SetType(typeof(TechniciansTable_SerializationHelper)); //No other values need to be added
    }

#region "Class TechniciansTable_SerializationHelper"

    [SerializableAttribute()]
    private class TechniciansTable_SerializationHelper: System.Runtime.Serialization.IObjectReference
    {
        //Method called after this object is deserialized
        public virtual object GetRealObject(System.Runtime.Serialization.StreamingContext context)
        {
            return TechniciansTable.Instance;
        }
    }

#endregion

#endregion

    /// <summary>
    /// References the only instance of the <see cref="TechniciansTable"></see> class.
    /// </summary>
    /// <remarks>
    /// Since the <see cref="TechniciansTable"></see> class is implemented using the Singleton design pattern, 
    /// this field is the only way to access an instance of the class.
    /// </remarks>
    public readonly static TechniciansTable Instance = new TechniciansTable();

    public TechniciansTable()
    {
    }


} // End class TechniciansTable

}
