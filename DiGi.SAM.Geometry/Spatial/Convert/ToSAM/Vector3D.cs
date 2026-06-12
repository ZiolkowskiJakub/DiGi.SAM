using SAM.Geometry.Spatial;

namespace DiGi.SAM.Geometry.Spatial
{
    public static partial class Convert
    {
        /// <summary>
        /// Converts a <see cref="DiGi.Geometry.Spatial.Classes.Vector3D"/> to a <see cref="Vector3D"/>.
        /// </summary>
        /// <param name="vector3D">The source vector to convert.</param>
        /// <returns>A new <see cref="Vector3D"/> instance containing the same coordinates, or null if the input is null.</returns>
        public static Vector3D ToSAM(this DiGi.Geometry.Spatial.Classes.Vector3D vector3D)
        {
            if (vector3D == null)
            {
                return null;
            }

            return new Vector3D(vector3D.X, vector3D.Y, vector3D.Z);
        }
    }
}