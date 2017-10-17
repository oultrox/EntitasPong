using Entitas;
using Entitas.CodeGenerator;

namespace Oultrox.EntitasPong.Entitas.Components.GameState
{
	/// <summary>
	/// Stores score
	/// </summary>
	[SingleEntity]
	public class ScoreComponent : IComponent
	{
		// ------------------ Serialized fields and properties
		public int whiteScore;
        public int blackScore;

	}
}