//------------------------------------------------------------------------------
// <auto-generated>
//		This code was generated by a tool (Genesis v2.3.2.0).
//
//
//		Changes to this file may cause incorrect behavior and will be lost if
//		the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameContext
{
	public GameEntity CatEntity { get { return GetGroup(GameMatcher.Cat).GetSingleEntity(); } }

	public bool IsCat
	{
		get { return CatEntity != null; }
		set
		{
			var entity = CatEntity;
			if (value != (entity != null))
			{
				if (value)
				{
					CreateEntity().IsCat = true;
				}
				else
				{
					entity.Destroy();
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
public partial class GameEntity
{
	static readonly Ecs.Game.Components.CatComponent CatComponent = new Ecs.Game.Components.CatComponent();

	public bool IsCat
	{
		get { return HasComponent(GameComponentsLookup.Cat); }
		set
		{
			if (value != IsCat)
			{
				var index = GameComponentsLookup.Cat;
				if (value)
				{
					var componentPool = GetComponentPool(index);
					var component = componentPool.Count > 0
							? componentPool.Pop()
							: CatComponent;

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
public partial class GameEntity : ICatEntity { }

//------------------------------------------------------------------------------
// <auto-generated>
//		This code was generated by a tool (Genesis v2.3.2.0).
//
//
//		Changes to this file may cause incorrect behavior and will be lost if
//		the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher
{
	static JCMG.EntitasRedux.IMatcher<GameEntity> _matcherCat;

	public static JCMG.EntitasRedux.IMatcher<GameEntity> Cat
	{
		get
		{
			if (_matcherCat == null)
			{
				var matcher = (JCMG.EntitasRedux.Matcher<GameEntity>)JCMG.EntitasRedux.Matcher<GameEntity>.AllOf(GameComponentsLookup.Cat);
				matcher.ComponentNames = GameComponentsLookup.ComponentNames;
				_matcherCat = matcher;
			}

			return _matcherCat;
		}
	}
}
