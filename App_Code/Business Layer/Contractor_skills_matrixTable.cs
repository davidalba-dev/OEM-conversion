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
/// See <see cref="BaseContractor_skills_matrixTable"></see> for additional information.
/// </summary>
/// <remarks>
/// See <see cref="BaseContractor_skills_matrixTable"></see> for additional information.
/// <para>
/// This class is implemented using the Singleton design pattern.
/// </para>
/// </remarks>
/// <seealso cref="BaseContractor_skills_matrixTable"></seealso>
/// <seealso cref="BaseContractor_skills_matrixSqlTable"></seealso>
/// <seealso cref="Contractor_skills_matrixSqlTable"></seealso>
/// <seealso cref="Contractor_skills_matrixDefinition"></seealso>
/// <seealso cref="Contractor_skills_matrixRecord"></seealso>
/// <seealso cref="BaseContractor_skills_matrixRecord"></seealso>
[SerializableAttribute()]
public class Contractor_skills_matrixTable : BaseContractor_skills_matrixTable, System.Runtime.Serialization.ISerializable, ISingleton
{

#region "ISerializable Members"

    /// <summary>
    /// Overridden to use the <see cref="Contractor_skills_matrixTable_SerializationHelper"></see> class 
    /// for deserialization of <see cref="Contractor_skills_matrixTable"></see> data.
    /// </summary>
    /// <remarks>
    /// Since the <see cref="Contractor_skills_matrixTable"></see> class is implemented using the Singleton design pattern, 
    /// this method must be overridden to prevent additional instances from being created during deserialization.
    /// </remarks>
    void System.Runtime.Serialization.ISerializable.GetObjectData(
        System.Runtime.Serialization.SerializationInfo info, 
        System.Runtime.Serialization.StreamingContext context)
    {
        info.SetType(typeof(Contractor_skills_matrixTable_SerializationHelper)); //No other values need to be added
    }

#region "Class Contractor_skills_matrixTable_SerializationHelper"

    [SerializableAttribute()]
    private class Contractor_skills_matrixTable_SerializationHelper: System.Runtime.Serialization.IObjectReference
    {
        //Method called after this object is deserialized
        public virtual object GetRealObject(System.Runtime.Serialization.StreamingContext context)
        {
            return Contractor_skills_matrixTable.Instance;
        }
    }

#endregion

#endregion

    /// <summary>
    /// References the only instance of the <see cref="Contractor_skills_matrixTable"></see> class.
    /// </summary>
    /// <remarks>
    /// Since the <see cref="Contractor_skills_matrixTable"></see> class is implemented using the Singleton design pattern, 
    /// this field is the only way to access an instance of the class.
    /// </remarks>
    public readonly static Contractor_skills_matrixTable Instance = new Contractor_skills_matrixTable();

    public Contractor_skills_matrixTable()
    {
    }


} // End class Contractor_skills_matrixTable

}
