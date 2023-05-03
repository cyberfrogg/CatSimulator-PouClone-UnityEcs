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
	static readonly Ecs.Common.Components.DestroyedComponent DestroyedComponent = new Ecs.Common.Components.DestroyedComponent();

	public bool IsDestroyed
	{
		get { return HasComponent(SchedulerComponentsLookup.Destroyed); }
		set
		{
			if (value != IsDestroyed)
			{
				var index = SchedulerComponentsLookup.Destroyed;
				if (value)
				{
					var componentPool = GetComponentPool(index);
					var component = componentPool.Count > 0
							? componentPool.Pop()
							: DestroyedComponent;

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
public partial class SchedulerEntity : IDestroyedEntity { }

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
	static JCMG.EntitasRedux.IMatcher<SchedulerEntity> _matcherDestroyed;

	public static JCMG.EntitasRedux.IMatcher<SchedulerEntity> Destroyed
	{
		get
		{
			if (_matcherDestroyed == null)
			{
				var matcher = (JCMG.EntitasRedux.Matcher<SchedulerEntity>)JCMG.EntitasRedux.Matcher<SchedulerEntity>.AllOf(SchedulerComponentsLookup.Destroyed);
				matcher.ComponentNames = SchedulerComponentsLookup.ComponentNames;
				_matcherDestroyed = matcher;
			}

			return _matcherDestroyed;
		}
	}
}
