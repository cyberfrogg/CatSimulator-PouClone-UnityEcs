//------------------------------------------------------------------------------
// <auto-generated>
//		This code was generated by a tool (Genesis v2.3.2.0).
//
//
//		Changes to this file may cause incorrect behavior and will be lost if
//		the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial interface IMoodTypeAddedListenerEntity
{
	MoodTypeAddedListenerComponent MoodTypeAddedListener { get; }
	bool HasMoodTypeAddedListener { get; }

	void AddMoodTypeAddedListener(System.Collections.Generic.List<IMoodTypeAddedListener> newValue);
	void ReplaceMoodTypeAddedListener(System.Collections.Generic.List<IMoodTypeAddedListener> newValue);
	void RemoveMoodTypeAddedListener();
}
