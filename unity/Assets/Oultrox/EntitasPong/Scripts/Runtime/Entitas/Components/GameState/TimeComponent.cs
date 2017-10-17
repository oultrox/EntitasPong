using Entitas;
using Entitas.CodeGenerator;

namespace Oultrox.EntitasPong.Entitas.Components.GameState
{
	/// <summary>
	/// Centralizes pause functionality and time data
	/// </summary>
	[SingleEntity]
	public class TimeComponent : IComponent
	{
		// ------------------ Serialized fields and properties
        public float timeSinceGameStartUnpaused = 0;
        public float timeSinceGameStartTotal = 0;
        public bool isPaused = false;

	}
}