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
	public Ecs.Scheduler.Components.ElapsedSecComponent ElapsedSec { get { return (Ecs.Scheduler.Components.ElapsedSecComponent)GetComponent(SchedulerComponentsLookup.ElapsedSec); } }
	public bool HasElapsedSec { get { return HasComponent(SchedulerComponentsLookup.ElapsedSec); } }

	public void AddElapsedSec(float newValue)
	{
		var index = SchedulerComponentsLookup.ElapsedSec;
		var component = (Ecs.Scheduler.Components.ElapsedSecComponent)CreateComponent(index, typeof(Ecs.Scheduler.Components.ElapsedSecComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.Value = newValue;
		#endif
		AddComponent(index, component);
	}

	public void ReplaceElapsedSec(float newValue)
	{
		var index = SchedulerComponentsLookup.ElapsedSec;
		var component = (Ecs.Scheduler.Components.ElapsedSecComponent)CreateComponent(index, typeof(Ecs.Scheduler.Components.ElapsedSecComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.Value = newValue;
		#endif
		ReplaceComponent(index, component);
	}

	public void CopyElapsedSecTo(Ecs.Scheduler.Components.ElapsedSecComponent copyComponent)
	{
		var index = SchedulerComponentsLookup.ElapsedSec;
		var component = (Ecs.Scheduler.Components.ElapsedSecComponent)CreateComponent(index, typeof(Ecs.Scheduler.Components.ElapsedSecComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.Value = copyComponent.Value;
		#endif
		ReplaceComponent(index, component);
	}

	public void RemoveElapsedSec()
	{
		RemoveComponent(SchedulerComponentsLookup.ElapsedSec);
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
public partial class SchedulerEntity : IElapsedSecEntity { }

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
	static JCMG.EntitasRedux.IMatcher<SchedulerEntity> _matcherElapsedSec;

	public static JCMG.EntitasRedux.IMatcher<SchedulerEntity> ElapsedSec
	{
		get
		{
			if (_matcherElapsedSec == null)
			{
				var matcher = (JCMG.EntitasRedux.Matcher<SchedulerEntity>)JCMG.EntitasRedux.Matcher<SchedulerEntity>.AllOf(SchedulerComponentsLookup.ElapsedSec);
				matcher.ComponentNames = SchedulerComponentsLookup.ComponentNames;
				_matcherElapsedSec = matcher;
			}

			return _matcherElapsedSec;
		}
	}
}