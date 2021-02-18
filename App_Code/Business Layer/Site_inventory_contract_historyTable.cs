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
/// See <see cref="BaseSite_inventory_contract_historyTable"></see> for additional information.
/// </summary>
/// <remarks>
/// See <see cref="BaseSite_inventory_contract_historyTable"></see> for additional information.
/// <para>
/// This class is implemented using the Singleton design pattern.
/// </para>
/// </remarks>
/// <seealso cref="BaseSite_inventory_contract_historyTable"></seealso>
/// <seealso cref="BaseSite_inventory_contract_historySqlTable"></seealso>
/// <seealso cref="Site_inventory_contract_historySqlTable"></seealso>
/// <seealso cref="Site_inventory_contract_historyDefinition"></seealso>
/// <seealso cref="Site_inventory_contract_historyRecord"></seealso>
/// <seealso cref="BaseSite_inventory_contract_historyRecord"></seealso>
[SerializableAttribute()]
public class Site_inventory_contract_historyTable : BaseSite_inventory_contract_historyTable, System.Runtime.Serialization.ISerializable, ISingleton
{

#region "ISerializable Members"

    /// <summary>
    /// Overridden to use the <see cref="Site_inventory_contract_historyTable_SerializationHelper"></see> class 
    /// for deserialization of <see cref="Site_inventory_contract_historyTable"></see> data.
    /// </summary>
    /// <remarks>
    /// Since the <see cref="Site_inventory_contract_historyTable"></see> class is implemented using the Singleton design pattern, 
    /// this method must be overridden to prevent additional instances from being created during deserialization.
    /// </remarks>
    void System.Runtime.Serialization.ISerializable.GetObjectData(
        System.Runtime.Serialization.SerializationInfo info, 
        System.Runtime.Serialization.StreamingContext context)
    {
        info.SetType(typeof(Site_inventory_contract_historyTable_SerializationHelper)); //No other values need to be added
    }

#region "Class Site_inventory_contract_historyTable_SerializationHelper"

    [SerializableAttribute()]
    private class Site_inventory_contract_historyTable_SerializationHelper: System.Runtime.Serialization.IObjectReference
    {
        //Method called after this object is deserialized
        public virtual object GetRealObject(System.Runtime.Serialization.StreamingContext context)
        {
            return Site_inventory_contract_historyTable.Instance;
        }
    }

#endregion

#endregion

    /// <summary>
    /// References the only instance of the <see cref="Site_inventory_contract_historyTable"></see> class.
    /// </summary>
    /// <remarks>
    /// Since the <see cref="Site_inventory_contract_historyTable"></see> class is implemented using the Singleton design pattern, 
    /// this field is the only way to access an instance of the class.
    /// </remarks>
    public readonly static Site_inventory_contract_historyTable Instance = new Site_inventory_contract_historyTable();

    public Site_inventory_contract_historyTable()
    {
    }


} // End class Site_inventory_contract_historyTable

}
