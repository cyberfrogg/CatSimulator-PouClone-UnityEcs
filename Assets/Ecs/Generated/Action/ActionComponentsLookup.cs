//------------------------------------------------------------------------------
// <auto-generated>
//		This code was generated by a tool (Genesis v2.3.2.0).
//
//
//		Changes to this file may cause incorrect behavior and will be lost if
//		the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using JCMG.EntitasRedux;

public static class ActionComponentsLookup
{
	public const int ActionDestroyedAddedListener = 0;
	public const int InteractWithCat = 1;
	public const int ResetCatInteraction = 2;
	public const int Destroyed = 3;

	public const int TotalComponents = 4;

	public static readonly string[] ComponentNames =
	{
		"ActionDestroyedAddedListener",
		"InteractWithCat",
		"ResetCatInteraction",
		"Destroyed"
	};

	public static readonly System.Type[] ComponentTypes =
	{
		typeof(ActionDestroyedAddedListenerComponent),
		typeof(Ecs.Action.Components.InteractWithCatComponent),
		typeof(Ecs.Action.Components.ResetCatInteractionComponent),
		typeof(Ecs.Common.Components.DestroyedComponent)
	};

	public static readonly Dictionary<Type, int> ComponentTypeToIndex = new Dictionary<Type, int>
	{
		{ typeof(ActionDestroyedAddedListenerComponent), 0 },
		{ typeof(Ecs.Action.Components.InteractWithCatComponent), 1 },
		{ typeof(Ecs.Action.Components.ResetCatInteractionComponent), 2 },
		{ typeof(Ecs.Common.Components.DestroyedComponent), 3 }
	};

	/// <summary>
	/// Returns a component index based on the passed <paramref name="component"/> type; where an index cannot be found
	/// -1 will be returned instead.
	/// </summary>
	/// <param name="component"></param>
	public static int GetComponentIndex(IComponent component)
	{
		return GetComponentIndex(component.GetType());
	}

	/// <summary>
	/// Returns a component index based on the passed <paramref name="componentType"/>; where an index cannot be found
	/// -1 will be returned instead.
	/// </summary>
	/// <param name="componentType"></param>
	public static int GetComponentIndex(Type componentType)
	{
		return ComponentTypeToIndex.TryGetValue(componentType, out var index) ? index : -1;
	}
}
