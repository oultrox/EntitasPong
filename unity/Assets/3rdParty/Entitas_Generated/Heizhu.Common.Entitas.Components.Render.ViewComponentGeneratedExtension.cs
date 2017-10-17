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
        public Oultrox.Common.Entitas.Components.Render.ViewComponent view { get { return (Oultrox.Common.Entitas.Components.Render.ViewComponent)GetComponent(ComponentIds.View); } }

        public bool hasView { get { return HasComponent(ComponentIds.View); } }

        public Entity AddView(object newGameObject, Oultrox.Common.UnityEngineReplacement.Bounds newBounds) {
            var component = CreateComponent<Oultrox.Common.Entitas.Components.Render.ViewComponent>(ComponentIds.View);
            component.gameObject = newGameObject;
            component.bounds = newBounds;
            return AddComponent(ComponentIds.View, component);
        }

        public Entity ReplaceView(object newGameObject, Oultrox.Common.UnityEngineReplacement.Bounds newBounds) {
            var component = CreateComponent<Oultrox.Common.Entitas.Components.Render.ViewComponent>(ComponentIds.View);
            component.gameObject = newGameObject;
            component.bounds = newBounds;
            ReplaceComponent(ComponentIds.View, component);
            return this;
        }

        public Entity RemoveView() {
            return RemoveComponent(ComponentIds.View);
        }
    }

    public partial class Matcher {
        static IMatcher _matcherView;

        public static IMatcher View {
            get {
                if (_matcherView == null) {
                    var matcher = (Matcher)Matcher.AllOf(ComponentIds.View);
                    matcher.componentNames = ComponentIds.componentNames;
                    _matcherView = matcher;
                }

                return _matcherView;
            }
        }
    }
}