using Entitas;
using Oultrox.Common.UnityEngineReplacement;

namespace Oultrox.EntitasPong.Entitas.Components.GameState
{
	/// <summary>
	/// Stores the screen bounds
	/// </summary>
	public class BoundsComponent : IComponent
	{
		// ------------------ Serialized fields and properties
		public Bounds bounds;		
	}
}