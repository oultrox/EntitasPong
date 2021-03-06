//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGenerator.ComponentExtensionsGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace Entitas {
    public partial class Entity {
        static readonly Oultrox.EntitasPong.Entitas.Components.GameState.GameComponent gameComponent = new Oultrox.EntitasPong.Entitas.Components.GameState.GameComponent();

        public bool isGame {
            get { return HasComponent(ComponentIds.Game); }
            set {
                if (value != isGame) {
                    if (value) {
                        AddComponent(ComponentIds.Game, gameComponent);
                    } else {
                        RemoveComponent(ComponentIds.Game);
                    }
                }
            }
        }

        public Entity IsGame(bool value) {
            isGame = value;
            return this;
        }
    }

    public partial class Pool {
        public Entity gameEntity { get { return GetGroup(Matcher.Game).GetSingleEntity(); } }

        public bool isGame {
            get { return gameEntity != null; }
            set {
                var entity = gameEntity;
                if (value != (entity != null)) {
                    if (value) {
                        CreateEntity().isGame = true;
                    } else {
                        DestroyEntity(entity);
                    }
                }
            }
        }
    }

    public partial class Matcher {
        static IMatcher _matcherGame;

        public static IMatcher Game {
            get {
                if (_matcherGame == null) {
                    var matcher = (Matcher)Matcher.AllOf(ComponentIds.Game);
                    matcher.componentNames = ComponentIds.componentNames;
                    _matcherGame = matcher;
                }

                return _matcherGame;
            }
        }
    }
}
