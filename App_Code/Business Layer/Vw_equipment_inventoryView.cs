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
/// See <see cref="BaseVw_equipment_inventoryView"></see> for additional information.
/// </summary>
/// <remarks>
/// See <see cref="BaseVw_equipment_inventoryView"></see> for additional information.
/// <para>
/// This class is implemented using the Singleton design pattern.
/// </para>
/// </remarks>
/// <seealso cref="BaseVw_equipment_inventoryView"></seealso>
/// <seealso cref="BaseVw_equipment_inventorySqlView"></seealso>
/// <seealso cref="Vw_equipment_inventorySqlView"></seealso>
/// <seealso cref="Vw_equipment_inventoryDefinition"></seealso>
/// <seealso cref="Vw_equipment_inventoryRecord"></seealso>
/// <seealso cref="BaseVw_equipment_inventoryRecord"></seealso>
[SerializableAttribute()]
public class Vw_equipment_inventoryView : BaseVw_equipment_inventoryView, System.Runtime.Serialization.ISerializable, ISingleton
{

#region "ISerializable Members"

	/// <summary>
	/// Overridden to use the <see cref="Vw_equipment_inventoryView_SerializationHelper"></see> class 
	/// for deserialization of <see cref="Vw_equipment_inventoryView"></see> data.
	/// </summary>
	/// <remarks>
	/// Since the <see cref="Vw_equipment_inventoryView"></see> class is implemented using the Singleton design pattern, 
	/// this method must be overridden to prevent additional instances from being created during deserialization.
	/// </remarks>
	void System.Runtime.Serialization.ISerializable.GetObjectData(
		System.Runtime.Serialization.SerializationInfo info, 
		System.Runtime.Serialization.StreamingContext context)
	{
		info.SetType(typeof(Vw_equipment_inventoryView_SerializationHelper)); //No other values need to be added
	}

#region "Class Vw_equipment_inventoryView_SerializationHelper"

	[SerializableAttribute()]
	private class Vw_equipment_inventoryView_SerializationHelper: System.Runtime.Serialization.IObjectReference
	{
		//Method called after this object is deserialized
		public virtual object GetRealObject(System.Runtime.Serialization.StreamingContext context)
		{
			return Vw_equipment_inventoryView.Instance;
		}
	}

#endregion

#endregion

	/// <summary>
	/// References the only instance of the <see cref="Vw_equipment_inventoryView"></see> class.
	/// </summary>
	/// <remarks>
	/// Since the <see cref="Vw_equipment_inventoryView"></see> class is implemented using the Singleton design pattern, 
	/// this field is the only way to access an instance of the class.
	/// </remarks>
	public readonly static Vw_equipment_inventoryView Instance = new Vw_equipment_inventoryView();

	public Vw_equipment_inventoryView()
	{
	}
}

}
