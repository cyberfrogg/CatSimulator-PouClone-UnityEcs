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
	public MoodTypeAddedListenerComponent MoodTypeAddedListener { get { return (MoodTypeAddedListenerComponent)GetComponent(GameComponentsLookup.MoodTypeAddedListener); } }
	public bool HasMoodTypeAddedListener { get { return HasComponent(GameComponentsLookup.MoodTypeAddedListener); } }

	public void AddMoodTypeAddedListener(System.Collections.Generic.List<IMoodTypeAddedListener> newValue)
	{
		var index = GameComponentsLookup.MoodTypeAddedListener;
		var component = (MoodTypeAddedListenerComponent)CreateComponent(index, typeof(MoodTypeAddedListenerComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.value = newValue;
		#endif
		AddComponent(index, component);
	}

	public void ReplaceMoodTypeAddedListener(System.Collections.Generic.List<IMoodTypeAddedListener> newValue)
	{
		var index = GameComponentsLookup.MoodTypeAddedListener;
		var component = (MoodTypeAddedListenerComponent)CreateComponent(index, typeof(MoodTypeAddedListenerComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.value = newValue;
		#endif
		ReplaceComponent(index, component);
	}

	public void CopyMoodTypeAddedListenerTo(MoodTypeAddedListenerComponent copyComponent)
	{
		var index = GameComponentsLookup.MoodTypeAddedListener;
		var component = (MoodTypeAddedListenerComponent)CreateComponent(index, typeof(MoodTypeAddedListenerComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.value = copyComponent.value;
		#endif
		ReplaceComponent(index, component);
	}

	public void RemoveMoodTypeAddedListener()
	{
		RemoveComponent(GameComponentsLookup.MoodTypeAddedListener);
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
public partial class GameEntity : IMoodTypeAddedListenerEntity { }

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
	static JCMG.EntitasRedux.IMatcher<GameEntity> _matcherMoodTypeAddedListener;

	public static JCMG.EntitasRedux.IMatcher<GameEntity> MoodTypeAddedListener
	{
		get
		{
			if (_matcherMoodTypeAddedListener == null)
			{
				var matcher = (JCMG.EntitasRedux.Matcher<GameEntity>)JCMG.EntitasRedux.Matcher<GameEntity>.AllOf(GameComponentsLookup.MoodTypeAddedListener);
				matcher.ComponentNames = GameComponentsLookup.ComponentNames;
				_matcherMoodTypeAddedListener = matcher;
			}

			return _matcherMoodTypeAddedListener;
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
public partial class GameEntity
{
	public void AddMoodTypeAddedListener(IMoodTypeAddedListener value)
	{
		var listeners = HasMoodTypeAddedListener
			? MoodTypeAddedListener.value
			: new System.Collections.Generic.List<IMoodTypeAddedListener>();
		listeners.Add(value);
		ReplaceMoodTypeAddedListener(listeners);
	}

	public void RemoveMoodTypeAddedListener(IMoodTypeAddedListener value, bool removeComponentWhenEmpty = true)
	{
		var listeners = MoodTypeAddedListener.value;
		listeners.Remove(value);
		if (removeComponentWhenEmpty && listeners.Count == 0)
		{
			RemoveMoodTypeAddedListener();
		}
		else
		{
			ReplaceMoodTypeAddedListener(listeners);
		}
	}
}
