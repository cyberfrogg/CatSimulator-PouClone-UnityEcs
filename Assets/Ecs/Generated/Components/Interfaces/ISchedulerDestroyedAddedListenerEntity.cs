//------------------------------------------------------------------------------
// <auto-generated>
//		This code was generated by a tool (Genesis v2.3.2.0).
//
//
//		Changes to this file may cause incorrect behavior and will be lost if
//		the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial interface ISchedulerDestroyedAddedListenerEntity
{
	SchedulerDestroyedAddedListenerComponent SchedulerDestroyedAddedListener { get; }
	bool HasSchedulerDestroyedAddedListener { get; }

	void AddSchedulerDestroyedAddedListener(System.Collections.Generic.List<ISchedulerDestroyedAddedListener> newValue);
	void ReplaceSchedulerDestroyedAddedListener(System.Collections.Generic.List<ISchedulerDestroyedAddedListener> newValue);
	void RemoveSchedulerDestroyedAddedListener();
}