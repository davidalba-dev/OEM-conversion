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
/// See <see cref="BaseSite_inventory_pm_pmiTable"></see> for additional information.
/// </summary>
/// <remarks>
/// See <see cref="BaseSite_inventory_pm_pmiTable"></see> for additional information.
/// <para>
/// This class is implemented using the Singleton design pattern.
/// </para>
/// </remarks>
/// <seealso cref="BaseSite_inventory_pm_pmiTable"></seealso>
/// <seealso cref="BaseSite_inventory_pm_pmiSqlTable"></seealso>
/// <seealso cref="Site_inventory_pm_pmiSqlTable"></seealso>
/// <seealso cref="Site_inventory_pm_pmiDefinition"></seealso>
/// <seealso cref="Site_inventory_pm_pmiRecord"></seealso>
/// <seealso cref="BaseSite_inventory_pm_pmiRecord"></seealso>
[SerializableAttribute()]
public class Site_inventory_pm_pmiTable : BaseSite_inventory_pm_pmiTable, System.Runtime.Serialization.ISerializable, ISingleton
{

#region "ISerializable Members"

    /// <summary>
    /// Overridden to use the <see cref="Site_inventory_pm_pmiTable_SerializationHelper"></see> class 
    /// for deserialization of <see cref="Site_inventory_pm_pmiTable"></see> data.
    /// </summary>
    /// <remarks>
    /// Since the <see cref="Site_inventory_pm_pmiTable"></see> class is implemented using the Singleton design pattern, 
    /// this method must be overridden to prevent additional instances from being created during deserialization.
    /// </remarks>
    void System.Runtime.Serialization.ISerializable.GetObjectData(
        System.Runtime.Serialization.SerializationInfo info, 
        System.Runtime.Serialization.StreamingContext context)
    {
        info.SetType(typeof(Site_inventory_pm_pmiTable_SerializationHelper)); //No other values need to be added
    }

#region "Class Site_inventory_pm_pmiTable_SerializationHelper"

    [SerializableAttribute()]
    private class Site_inventory_pm_pmiTable_SerializationHelper: System.Runtime.Serialization.IObjectReference
    {
        //Method called after this object is deserialized
        public virtual object GetRealObject(System.Runtime.Serialization.StreamingContext context)
        {
            return Site_inventory_pm_pmiTable.Instance;
        }
    }

#endregion

#endregion

    /// <summary>
    /// References the only instance of the <see cref="Site_inventory_pm_pmiTable"></see> class.
    /// </summary>
    /// <remarks>
    /// Since the <see cref="Site_inventory_pm_pmiTable"></see> class is implemented using the Singleton design pattern, 
    /// this field is the only way to access an instance of the class.
    /// </remarks>
    public readonly static Site_inventory_pm_pmiTable Instance = new Site_inventory_pm_pmiTable();

    public Site_inventory_pm_pmiTable()
    {
    }


} // End class Site_inventory_pm_pmiTable

}
