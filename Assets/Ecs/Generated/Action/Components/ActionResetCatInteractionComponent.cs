//------------------------------------------------------------------------------
// <auto-generated>
//		This code was generated by a tool (Genesis v2.3.2.0).
//
//
//		Changes to this file may cause incorrect behavior and will be lost if
//		the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class ActionEntity
{
	static readonly Ecs.Action.Components.ResetCatInteractionComponent ResetCatInteractionComponent = new Ecs.Action.Components.ResetCatInteractionComponent();

	public bool IsResetCatInteraction
	{
		get { return HasComponent(ActionComponentsLookup.ResetCatInteraction); }
		set
		{
			if (value != IsResetCatInteraction)
			{
				var index = ActionComponentsLookup.ResetCatInteraction;
				if (value)
				{
					var componentPool = GetComponentPool(index);
					var component = componentPool.Count > 0
							? componentPool.Pop()
							: ResetCatInteractionComponent;

					AddComponent(index, component);
				}
				else
				{
					RemoveComponent(index);
				}
			}
		}
	}
}

//------------------------------------------------------------------------------
// <auto-generated>
//		This code was generated by a tool (Genesis v2.3.2.0).
//
//
//		Changes to this file may cause incorrect behavior and will be lost if
//		the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class ActionEntity : IResetCatInteractionEntity { }

//------------------------------------------------------------------------------
// <auto-generated>
//		This code was generated by a tool (Genesis v2.3.2.0).
//
//
//		Changes to this file may cause incorrect behavior and will be lost if
//		the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class ActionMatcher
{
	static JCMG.EntitasRedux.IMatcher<ActionEntity> _matcherResetCatInteraction;

	public static JCMG.EntitasRedux.IMatcher<ActionEntity> ResetCatInteraction
	{
		get
		{
			if (_matcherResetCatInteraction == null)
			{
				var matcher = (JCMG.EntitasRedux.Matcher<ActionEntity>)JCMG.EntitasRedux.Matcher<ActionEntity>.AllOf(ActionComponentsLookup.ResetCatInteraction);
				matcher.ComponentNames = ActionComponentsLookup.ComponentNames;
				_matcherResetCatInteraction = matcher;
			}

			return _matcherResetCatInteraction;
		}
	}
}
