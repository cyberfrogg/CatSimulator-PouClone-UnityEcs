//------------------------------------------------------------------------------
// <auto-generated>
//		This code was generated by a tool (Genesis v2.3.2.0).
//
//
//		Changes to this file may cause incorrect behavior and will be lost if
//		the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed class GameEventSystems : Feature
{
	public GameEventSystems(Contexts contexts)
	{
		Add(new CatInteractionTypeAddedEventSystem(contexts)); // priority: 0
		Add(new CountAddedEventSystem(contexts)); // priority: 0
		Add(new CountRemovedEventSystem(contexts)); // priority: 0
		Add(new GameDestroyedAddedEventSystem(contexts)); // priority: 0
		Add(new LinkRemovedEventSystem(contexts)); // priority: 0
		Add(new MoodAddedEventSystem(contexts)); // priority: 0
		Add(new MoodTypeAddedEventSystem(contexts)); // priority: 0
		Add(new ObjectTypeAddedEventSystem(contexts)); // priority: 0
		Add(new PositionAddedEventSystem(contexts)); // priority: 0
		Add(new RotationAddedEventSystem(contexts)); // priority: 0
		Add(new VelocityAddedEventSystem(contexts)); // priority: 0
		Add(new LocalPositionAddedEventSystem(contexts)); // priority: 10
	}
}
