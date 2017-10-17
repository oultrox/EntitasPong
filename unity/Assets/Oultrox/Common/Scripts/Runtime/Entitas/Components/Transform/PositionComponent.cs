using Entitas;
using Oultrox.Common.UnityEngineReplacement;

namespace Oultrox.Common.Entitas.Components.Transform
{
	/// <summary>
	/// Stores entity's current position
	/// </summary>
	public class PositionComponent : IComponent
	{
		// ------------------ Serialized fields and properties
		public Vector3 position;
	}
}