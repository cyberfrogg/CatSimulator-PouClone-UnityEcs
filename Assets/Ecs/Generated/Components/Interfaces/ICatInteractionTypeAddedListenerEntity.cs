//------------------------------------------------------------------------------
// <auto-generated>
//		This code was generated by a tool (Genesis v2.3.2.0).
//
//
//		Changes to this file may cause incorrect behavior and will be lost if
//		the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial interface ICatInteractionTypeAddedListenerEntity
{
	CatInteractionTypeAddedListenerComponent CatInteractionTypeAddedListener { get; }
	bool HasCatInteractionTypeAddedListener { get; }

	void AddCatInteractionTypeAddedListener(System.Collections.Generic.List<ICatInteractionTypeAddedListener> newValue);
	void ReplaceCatInteractionTypeAddedListener(System.Collections.Generic.List<ICatInteractionTypeAddedListener> newValue);
	void RemoveCatInteractionTypeAddedListener();
}
