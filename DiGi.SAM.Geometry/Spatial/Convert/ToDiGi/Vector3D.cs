using SAM.Geometry.Spatial;

namespace DiGi.SAM.Geometry.Spatial
{
    public static partial class Convert
    {
        /// <summary>
        /// Converts a SAM Vector3D instance to a DiGi Geometry Spatial Vector3D instance.
        /// </summary>
        /// <param name="vector3D">The SAM Vector3D instance to convert.</param>
        /// <returns>A new DiGi Geometry Spatial Vector3D instance, or null if the input is null.</returns>
        public static DiGi.Geometry.Spatial.Classes.Vector3D ToDiGi(this Vector3D vector3D)
        {
            if (vector3D == null)
            {
                return null;
            }

            return new DiGi.Geometry.Spatial.Classes.Vector3D(vector3D.X, vector3D.Y, vector3D.Z);
        }
    }
}