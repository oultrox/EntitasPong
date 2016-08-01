using Entitas;

namespace RMC.EntitasPong.Entitas.Components.GameState
{
	/// <summary>
	/// Stores the screen bounds
	/// </summary>
	public class BoundsComponent : IComponent
	{
		// ------------------ Serialized fields and properties
		public UnityEngine.Bounds bounds;		
	}
}