using SAM.Geometry.Spatial;

namespace DiGi.SAM.Geometry.Spatial
{
    public static partial class Convert
    {
        /// <summary>
        /// Converts a DiGi Geometry Point3D instance to a SAM Geometry Point3D instance.
        /// </summary>
        /// <param name="point3D">The source point to be converted.</param>
        /// <returns>A new <see cref="Point3D"/> instance representing the same coordinates, or null if the input is null.</returns>
        public static Point3D ToSAM(this DiGi.Geometry.Spatial.Classes.Point3D point3D)
        {
            if (point3D == null)
            {
                return null;
            }

            return new Point3D(point3D.X, point3D.Y, point3D.Z);
        }
    }
}