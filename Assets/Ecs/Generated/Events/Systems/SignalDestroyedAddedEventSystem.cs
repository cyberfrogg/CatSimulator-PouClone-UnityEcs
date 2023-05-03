//------------------------------------------------------------------------------
// <auto-generated>
//		This code was generated by a tool (Genesis v2.3.2.0).
//
//
//		Changes to this file may cause incorrect behavior and will be lost if
//		the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed class SignalDestroyedAddedEventSystem : JCMG.EntitasRedux.ReactiveSystem<SignalEntity>
{
	readonly System.Collections.Generic.List<ISignalDestroyedAddedListener> _listenerBuffer;

	public SignalDestroyedAddedEventSystem(Contexts contexts) : base(contexts.Signal)
	{
		_listenerBuffer = new System.Collections.Generic.List<ISignalDestroyedAddedListener>();
	}

	protected override JCMG.EntitasRedux.ICollector<SignalEntity> GetTrigger(JCMG.EntitasRedux.IContext<SignalEntity> context)
	{
		return JCMG.EntitasRedux.CollectorContextExtension.CreateCollector(
			context,
			JCMG.EntitasRedux.TriggerOnEventMatcherExtension.Added(SignalMatcher.Destroyed)
		);
	}

	protected override bool Filter(SignalEntity entity)
	{
		return entity.IsDestroyed && entity.HasSignalDestroyedAddedListener;
	}

	protected override void Execute(System.Collections.Generic.List<SignalEntity> entities)
	{
		foreach (var e in entities)
		{
			
			_listenerBuffer.Clear();
			_listenerBuffer.AddRange(e.SignalDestroyedAddedListener.value);
			foreach (var listener in _listenerBuffer)
			{
				listener.OnDestroyedAdded(e);
			}
		}
	}
}