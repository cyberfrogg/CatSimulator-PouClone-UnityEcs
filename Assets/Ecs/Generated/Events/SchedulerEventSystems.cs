//------------------------------------------------------------------------------
// <auto-generated>
//		This code was generated by a tool (Genesis v2.3.2.0).
//
//
//		Changes to this file may cause incorrect behavior and will be lost if
//		the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed class SchedulerEventSystems : Feature
{
	public SchedulerEventSystems(Contexts contexts)
	{
		Add(new SchedulerDestroyedAddedEventSystem(contexts)); // priority: 0
	}
}
