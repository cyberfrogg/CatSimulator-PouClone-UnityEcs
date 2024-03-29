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
	public Ecs.Game.Components.MoodTypeComponent MoodType { get { return (Ecs.Game.Components.MoodTypeComponent)GetComponent(GameComponentsLookup.MoodType); } }
	public bool HasMoodType { get { return HasComponent(GameComponentsLookup.MoodType); } }

	public void AddMoodType(Game.Utils.EMood newValue)
	{
		var index = GameComponentsLookup.MoodType;
		var component = (Ecs.Game.Components.MoodTypeComponent)CreateComponent(index, typeof(Ecs.Game.Components.MoodTypeComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.Value = newValue;
		#endif
		AddComponent(index, component);
	}

	public void ReplaceMoodType(Game.Utils.EMood newValue)
	{
		var index = GameComponentsLookup.MoodType;
		var component = (Ecs.Game.Components.MoodTypeComponent)CreateComponent(index, typeof(Ecs.Game.Components.MoodTypeComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.Value = newValue;
		#endif
		ReplaceComponent(index, component);
	}

	public void CopyMoodTypeTo(Ecs.Game.Components.MoodTypeComponent copyComponent)
	{
		var index = GameComponentsLookup.MoodType;
		var component = (Ecs.Game.Components.MoodTypeComponent)CreateComponent(index, typeof(Ecs.Game.Components.MoodTypeComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.Value = copyComponent.Value;
		#endif
		ReplaceComponent(index, component);
	}

	public void RemoveMoodType()
	{
		RemoveComponent(GameComponentsLookup.MoodType);
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
public partial class GameEntity : IMoodTypeEntity { }

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
	static JCMG.EntitasRedux.IMatcher<GameEntity> _matcherMoodType;

	public static JCMG.EntitasRedux.IMatcher<GameEntity> MoodType
	{
		get
		{
			if (_matcherMoodType == null)
			{
				var matcher = (JCMG.EntitasRedux.Matcher<GameEntity>)JCMG.EntitasRedux.Matcher<GameEntity>.AllOf(GameComponentsLookup.MoodType);
				matcher.ComponentNames = GameComponentsLookup.ComponentNames;
				_matcherMoodType = matcher;
			}

			return _matcherMoodType;
		}
	}
}
