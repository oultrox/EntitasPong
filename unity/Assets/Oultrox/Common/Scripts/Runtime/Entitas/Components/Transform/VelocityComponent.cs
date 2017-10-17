﻿using Entitas;
using Oultrox.Common.UnityEngineReplacement;

namespace Oultrox.Common.Entitas.Components.Transform
{
	/// <summary>
	/// Stores entities current velocity
	/// </summary>
	public class VelocityComponent : IComponent
	{
		// ------------------ Serialized fields and properties
		public Vector3 velocity;

	}
}