//------------------------------------------------------------------------------
// <auto-generated>
//		This code was generated by a tool (Genesis v2.3.2.0).
//
//
//		Changes to this file may cause incorrect behavior and will be lost if
//		the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class SchedulerEntity
{
	public Ecs.Game.Components.UidComponent Uid { get { return (Ecs.Game.Components.UidComponent)GetComponent(SchedulerComponentsLookup.Uid); } }
	public bool HasUid { get { return HasComponent(SchedulerComponentsLookup.Uid); } }

	public void AddUid(Ecs.Managers.Uid newValue)
	{
		var index = SchedulerComponentsLookup.Uid;
		var component = (Ecs.Game.Components.UidComponent)CreateComponent(index, typeof(Ecs.Game.Components.UidComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.Value = newValue;
		#endif
		AddComponent(index, component);
	}

	public void ReplaceUid(Ecs.Managers.Uid newValue)
	{
		var index = SchedulerComponentsLookup.Uid;
		var component = (Ecs.Game.Components.UidComponent)CreateComponent(index, typeof(Ecs.Game.Components.UidComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.Value = newValue;
		#endif
		ReplaceComponent(index, component);
	}

	public void CopyUidTo(Ecs.Game.Components.UidComponent copyComponent)
	{
		var index = SchedulerComponentsLookup.Uid;
		var component = (Ecs.Game.Components.UidComponent)CreateComponent(index, typeof(Ecs.Game.Components.UidComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.Value = copyComponent.Value;
		#endif
		ReplaceComponent(index, component);
	}

	public void RemoveUid()
	{
		RemoveComponent(SchedulerComponentsLookup.Uid);
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
public partial class SchedulerEntity : IUidEntity { }

//------------------------------------------------------------------------------
// <auto-generated>
//		This code was generated by a tool (Genesis v2.3.2.0).
//
//
//		Changes to this file may cause incorrect behavior and will be lost if
//		the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class SchedulerMatcher
{
	static JCMG.EntitasRedux.IMatcher<SchedulerEntity> _matcherUid;

	public static JCMG.EntitasRedux.IMatcher<SchedulerEntity> Uid
	{
		get
		{
			if (_matcherUid == null)
			{
				var matcher = (JCMG.EntitasRedux.Matcher<SchedulerEntity>)JCMG.EntitasRedux.Matcher<SchedulerEntity>.AllOf(SchedulerComponentsLookup.Uid);
				matcher.ComponentNames = SchedulerComponentsLookup.ComponentNames;
				_matcherUid = matcher;
			}

			return _matcherUid;
		}
	}
}