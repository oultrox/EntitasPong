using UnityEngine;

namespace Oultrox.Common.Entitas.Utilities
{
    /// <summary>
    /// Convert between UnityEngine and UnityEngineReplacement namespace types
    /// </summary>
    public class UnityEngineReplacementUtility
    {
        // ------------------ Constants and statics

        // ------------------ Events

        // ------------------ Serialized fields and properties

        // ------------------ Non-serialized fields

        // ------------------ Methods
        public static UnityEngine.Vector3 Convert (Oultrox.Common.UnityEngineReplacement.Vector3 rVector3)
        {
            return new UnityEngine.Vector3(
                rVector3.x,
                rVector3.y,
                rVector3.z
            );

        }
        public static Oultrox.Common.UnityEngineReplacement.Vector3 Convert (UnityEngine.Vector3 uVector3)
        {
            return new Oultrox.Common.UnityEngineReplacement.Vector3(
                uVector3.x,
                uVector3.y,
                uVector3.z
            );

        }

        public static UnityEngine.Bounds Convert (Oultrox.Common.UnityEngineReplacement.Bounds rBounds)
        {
            return new UnityEngine.Bounds(
                Convert(rBounds.center),
                Convert(rBounds.size)
            );
        }
        public static Oultrox.Common.UnityEngineReplacement.Bounds Convert (UnityEngine.Bounds uBounds)
        {
            return new Oultrox.Common.UnityEngineReplacement.Bounds(
                Convert(uBounds.center),
                Convert(uBounds.size)
            );
        }


    }


}
