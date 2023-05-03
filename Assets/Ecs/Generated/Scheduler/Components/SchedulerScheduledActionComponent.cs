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
	public Ecs.Scheduler.Components.ScheduledActionComponent ScheduledAction { get { return (Ecs.Scheduler.Components.ScheduledActionComponent)GetComponent(SchedulerComponentsLookup.ScheduledAction); } }
	public bool HasScheduledAction { get { return HasComponent(SchedulerComponentsLookup.ScheduledAction); } }

	public void AddScheduledAction(System.Action newValue)
	{
		var index = SchedulerComponentsLookup.ScheduledAction;
		var component = (Ecs.Scheduler.Components.ScheduledActionComponent)CreateComponent(index, typeof(Ecs.Scheduler.Components.ScheduledActionComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.Value = newValue;
		#endif
		AddComponent(index, component);
	}

	public void ReplaceScheduledAction(System.Action newValue)
	{
		var index = SchedulerComponentsLookup.ScheduledAction;
		var component = (Ecs.Scheduler.Components.ScheduledActionComponent)CreateComponent(index, typeof(Ecs.Scheduler.Components.ScheduledActionComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.Value = newValue;
		#endif
		ReplaceComponent(index, component);
	}

	public void CopyScheduledActionTo(Ecs.Scheduler.Components.ScheduledActionComponent copyComponent)
	{
		var index = SchedulerComponentsLookup.ScheduledAction;
		var component = (Ecs.Scheduler.Components.ScheduledActionComponent)CreateComponent(index, typeof(Ecs.Scheduler.Components.ScheduledActionComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.Value = (System.Action)copyComponent.Value.Clone();
		#endif
		ReplaceComponent(index, component);
	}

	public void RemoveScheduledAction()
	{
		RemoveComponent(SchedulerComponentsLookup.ScheduledAction);
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
public partial class SchedulerEntity : IScheduledActionEntity { }

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
	static JCMG.EntitasRedux.IMatcher<SchedulerEntity> _matcherScheduledAction;

	public static JCMG.EntitasRedux.IMatcher<SchedulerEntity> ScheduledAction
	{
		get
		{
			if (_matcherScheduledAction == null)
			{
				var matcher = (JCMG.EntitasRedux.Matcher<SchedulerEntity>)JCMG.EntitasRedux.Matcher<SchedulerEntity>.AllOf(SchedulerComponentsLookup.ScheduledAction);
				matcher.ComponentNames = SchedulerComponentsLookup.ComponentNames;
				_matcherScheduledAction = matcher;
			}

			return _matcherScheduledAction;
		}
	}
}
