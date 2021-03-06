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
        public Oultrox.EntitasPong.Entitas.Components.GameState.TimeComponent time { get { return (Oultrox.EntitasPong.Entitas.Components.GameState.TimeComponent)GetComponent(ComponentIds.Time); } }

        public bool hasTime { get { return HasComponent(ComponentIds.Time); } }

        public Entity AddTime(float newTimeSinceGameStartUnpaused, float newTimeSinceGameStartTotal, bool newIsPaused) {
            var component = CreateComponent<Oultrox.EntitasPong.Entitas.Components.GameState.TimeComponent>(ComponentIds.Time);
            component.timeSinceGameStartUnpaused = newTimeSinceGameStartUnpaused;
            component.timeSinceGameStartTotal = newTimeSinceGameStartTotal;
            component.isPaused = newIsPaused;
            return AddComponent(ComponentIds.Time, component);
        }

        public Entity ReplaceTime(float newTimeSinceGameStartUnpaused, float newTimeSinceGameStartTotal, bool newIsPaused) {
            var component = CreateComponent<Oultrox.EntitasPong.Entitas.Components.GameState.TimeComponent>(ComponentIds.Time);
            component.timeSinceGameStartUnpaused = newTimeSinceGameStartUnpaused;
            component.timeSinceGameStartTotal = newTimeSinceGameStartTotal;
            component.isPaused = newIsPaused;
            ReplaceComponent(ComponentIds.Time, component);
            return this;
        }

        public Entity RemoveTime() {
            return RemoveComponent(ComponentIds.Time);
        }
    }

    public partial class Pool {
        public Entity timeEntity { get { return GetGroup(Matcher.Time).GetSingleEntity(); } }

        public Oultrox.EntitasPong.Entitas.Components.GameState.TimeComponent time { get { return timeEntity.time; } }

        public bool hasTime { get { return timeEntity != null; } }

        public Entity SetTime(float newTimeSinceGameStartUnpaused, float newTimeSinceGameStartTotal, bool newIsPaused) {
            if (hasTime) {
                throw new EntitasException("Could not set time!\n" + this + " already has an entity with Heizhu.EntitasPong.Entitas.Components.GameState.TimeComponent!",
                    "You should check if the pool already has a timeEntity before setting it or use pool.ReplaceTime().");
            }
            var entity = CreateEntity();
            entity.AddTime(newTimeSinceGameStartUnpaused, newTimeSinceGameStartTotal, newIsPaused);
            return entity;
        }

        public Entity ReplaceTime(float newTimeSinceGameStartUnpaused, float newTimeSinceGameStartTotal, bool newIsPaused) {
            var entity = timeEntity;
            if (entity == null) {
                entity = SetTime(newTimeSinceGameStartUnpaused, newTimeSinceGameStartTotal, newIsPaused);
            } else {
                entity.ReplaceTime(newTimeSinceGameStartUnpaused, newTimeSinceGameStartTotal, newIsPaused);
            }

            return entity;
        }

        public void RemoveTime() {
            DestroyEntity(timeEntity);
        }
    }

    public partial class Matcher {
        static IMatcher _matcherTime;

        public static IMatcher Time {
            get {
                if (_matcherTime == null) {
                    var matcher = (Matcher)Matcher.AllOf(ComponentIds.Time);
                    matcher.componentNames = ComponentIds.componentNames;
                    _matcherTime = matcher;
                }

                return _matcherTime;
            }
        }
    }
}
