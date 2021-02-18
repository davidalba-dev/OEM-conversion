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
/// See <see cref="BaseMax_repairorderView"></see> for additional information.
/// </summary>
/// <remarks>
/// See <see cref="BaseMax_repairorderView"></see> for additional information.
/// <para>
/// This class is implemented using the Singleton design pattern.
/// </para>
/// </remarks>
/// <seealso cref="BaseMax_repairorderView"></seealso>
/// <seealso cref="BaseMax_repairorderSqlView"></seealso>
/// <seealso cref="Max_repairorderSqlView"></seealso>
/// <seealso cref="Max_repairorderDefinition"></seealso>
/// <seealso cref="Max_repairorderRecord"></seealso>
/// <seealso cref="BaseMax_repairorderRecord"></seealso>
[SerializableAttribute()]
public class Max_repairorderView : BaseMax_repairorderView, System.Runtime.Serialization.ISerializable, ISingleton
{

#region "ISerializable Members"

	/// <summary>
	/// Overridden to use the <see cref="Max_repairorderView_SerializationHelper"></see> class 
	/// for deserialization of <see cref="Max_repairorderView"></see> data.
	/// </summary>
	/// <remarks>
	/// Since the <see cref="Max_repairorderView"></see> class is implemented using the Singleton design pattern, 
	/// this method must be overridden to prevent additional instances from being created during deserialization.
	/// </remarks>
	void System.Runtime.Serialization.ISerializable.GetObjectData(
		System.Runtime.Serialization.SerializationInfo info, 
		System.Runtime.Serialization.StreamingContext context)
	{
		info.SetType(typeof(Max_repairorderView_SerializationHelper)); //No other values need to be added
	}

#region "Class Max_repairorderView_SerializationHelper"

	[SerializableAttribute()]
	private class Max_repairorderView_SerializationHelper: System.Runtime.Serialization.IObjectReference
	{
		//Method called after this object is deserialized
		public virtual object GetRealObject(System.Runtime.Serialization.StreamingContext context)
		{
			return Max_repairorderView.Instance;
		}
	}

#endregion

#endregion

	/// <summary>
	/// References the only instance of the <see cref="Max_repairorderView"></see> class.
	/// </summary>
	/// <remarks>
	/// Since the <see cref="Max_repairorderView"></see> class is implemented using the Singleton design pattern, 
	/// this field is the only way to access an instance of the class.
	/// </remarks>
	public readonly static Max_repairorderView Instance = new Max_repairorderView();

	public Max_repairorderView()
	{
	}
}

}
