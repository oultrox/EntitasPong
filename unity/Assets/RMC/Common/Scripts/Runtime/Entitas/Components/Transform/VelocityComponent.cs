using Entitas;
using UnityEngine;

namespace RMC.Common.Entitas.Components.Transform
{
	/// <summary>
	/// Stores entities current velocity
	/// </summary>
	public class VelocityComponent : IComponent
	{
		// ------------------ Serialized fields and properties

        /// <summary>
        /// ENTITAS_HELP_REQUEST: 
        ///     Entitas examples use x,y,z properties separately, but I use a Vector3. Best practices for Entitas?
        /// </summary>
		public Vector3 velocity;

	}
}