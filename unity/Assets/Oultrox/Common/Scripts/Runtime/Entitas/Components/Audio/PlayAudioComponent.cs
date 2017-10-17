﻿using Entitas;

namespace Oultrox.Common.Entitas.Components.Audio
{
	/// <summary>
    /// Sent like an event: Plays one sound, one time
	/// </summary>
	public class PlayAudioComponent : IComponent
	{
		// ------------------ Serialized fields and properties
		public string audioClipName;
        public float volume;

	}
}