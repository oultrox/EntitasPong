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
        public Oultrox.EntitasPong.Entitas.Components.GameState.ScoreComponent score { get { return (Oultrox.EntitasPong.Entitas.Components.GameState.ScoreComponent)GetComponent(ComponentIds.Score); } }

        public bool hasScore { get { return HasComponent(ComponentIds.Score); } }

        public Entity AddScore(int newWhiteScore, int newBlackScore) {
            var component = CreateComponent<Oultrox.EntitasPong.Entitas.Components.GameState.ScoreComponent>(ComponentIds.Score);
            component.whiteScore = newWhiteScore;
            component.blackScore = newBlackScore;
            return AddComponent(ComponentIds.Score, component);
        }

        public Entity ReplaceScore(int newWhiteScore, int newBlackScore) {
            var component = CreateComponent<Oultrox.EntitasPong.Entitas.Components.GameState.ScoreComponent>(ComponentIds.Score);
            component.whiteScore = newWhiteScore;
            component.blackScore = newBlackScore;
            ReplaceComponent(ComponentIds.Score, component);
            return this;
        }

        public Entity RemoveScore() {
            return RemoveComponent(ComponentIds.Score);
        }
    }

    public partial class Pool {
        public Entity scoreEntity { get { return GetGroup(Matcher.Score).GetSingleEntity(); } }

        public Oultrox.EntitasPong.Entitas.Components.GameState.ScoreComponent score { get { return scoreEntity.score; } }

        public bool hasScore { get { return scoreEntity != null; } }

        public Entity SetScore(int newWhiteScore, int newBlackScore) {
            if (hasScore) {
                throw new EntitasException("Could not set score!\n" + this + " already has an entity with Heizhu.EntitasPong.Entitas.Components.GameState.ScoreComponent!",
                    "You should check if the pool already has a scoreEntity before setting it or use pool.ReplaceScore().");
            }
            var entity = CreateEntity();
            entity.AddScore(newWhiteScore, newBlackScore);
            return entity;
        }

        public Entity ReplaceScore(int newWhiteScore, int newBlackScore) {
            var entity = scoreEntity;
            if (entity == null) {
                entity = SetScore(newWhiteScore, newBlackScore);
            } else {
                entity.ReplaceScore(newWhiteScore, newBlackScore);
            }

            return entity;
        }

        public void RemoveScore() {
            DestroyEntity(scoreEntity);
        }
    }

    public partial class Matcher {
        static IMatcher _matcherScore;

        public static IMatcher Score {
            get {
                if (_matcherScore == null) {
                    var matcher = (Matcher)Matcher.AllOf(ComponentIds.Score);
                    matcher.componentNames = ComponentIds.componentNames;
                    _matcherScore = matcher;
                }

                return _matcherScore;
            }
        }
    }
}
