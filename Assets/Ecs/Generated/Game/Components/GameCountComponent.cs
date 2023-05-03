//------------------------------------------------------------------------------
// <auto-generated>
//		This code was generated by a tool (Genesis v2.3.2.0).
//
//
//		Changes to this file may cause incorrect behavior and will be lost if
//		the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity
{
	public Ecs.Game.Components.CountComponent Count { get { return (Ecs.Game.Components.CountComponent)GetComponent(GameComponentsLookup.Count); } }
	public bool HasCount { get { return HasComponent(GameComponentsLookup.Count); } }

	public void AddCount(int newValue)
	{
		var index = GameComponentsLookup.Count;
		var component = (Ecs.Game.Components.CountComponent)CreateComponent(index, typeof(Ecs.Game.Components.CountComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.Value = newValue;
		#endif
		AddComponent(index, component);
	}

	public void ReplaceCount(int newValue)
	{
		var index = GameComponentsLookup.Count;
		var component = (Ecs.Game.Components.CountComponent)CreateComponent(index, typeof(Ecs.Game.Components.CountComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.Value = newValue;
		#endif
		ReplaceComponent(index, component);
	}

	public void CopyCountTo(Ecs.Game.Components.CountComponent copyComponent)
	{
		var index = GameComponentsLookup.Count;
		var component = (Ecs.Game.Components.CountComponent)CreateComponent(index, typeof(Ecs.Game.Components.CountComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.Value = copyComponent.Value;
		#endif
		ReplaceComponent(index, component);
	}

	public void RemoveCount()
	{
		RemoveComponent(GameComponentsLookup.Count);
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
public partial class GameEntity : ICountEntity { }

//------------------------------------------------------------------------------
// <auto-generated>
//		This code was generated by a tool (Genesis v2.3.2.0).
//
//
//		Changes to this file may cause incorrect behavior and will be lost if
//		the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher
{
	static JCMG.EntitasRedux.IMatcher<GameEntity> _matcherCount;

	public static JCMG.EntitasRedux.IMatcher<GameEntity> Count
	{
		get
		{
			if (_matcherCount == null)
			{
				var matcher = (JCMG.EntitasRedux.Matcher<GameEntity>)JCMG.EntitasRedux.Matcher<GameEntity>.AllOf(GameComponentsLookup.Count);
				matcher.ComponentNames = GameComponentsLookup.ComponentNames;
				_matcherCount = matcher;
			}

			return _matcherCount;
		}
	}
}