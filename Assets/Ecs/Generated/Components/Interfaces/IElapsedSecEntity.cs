//------------------------------------------------------------------------------
// <auto-generated>
//		This code was generated by a tool (Genesis v2.3.2.0).
//
//
//		Changes to this file may cause incorrect behavior and will be lost if
//		the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial interface IElapsedSecEntity
{
	Ecs.Scheduler.Components.ElapsedSecComponent ElapsedSec { get; }
	bool HasElapsedSec { get; }

	void AddElapsedSec(float newValue);
	void ReplaceElapsedSec(float newValue);
	void RemoveElapsedSec();
}