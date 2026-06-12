using SAM.Geometry.Spatial;

namespace DiGi.SAM.Geometry.Spatial
{
    public static partial class Convert
    {
        /// <summary>
        /// Converts a <see cref="Point3D"/> instance to a <see cref="DiGi.Geometry.Spatial.Classes.Point3D"/> instance.
        /// </summary>
        /// <param name="point3D">The source point to convert.</param>
        /// <returns>A new <see cref="DiGi.Geometry.Spatial.Classes.Point3D"/> instance, or null if the input is null.</returns>
        public static DiGi.Geometry.Spatial.Classes.Point3D ToDiGi(this Point3D point3D)
        {
            if (point3D == null)
            {
                return null;
            }

            return new DiGi.Geometry.Spatial.Classes.Point3D(point3D.X, point3D.Y, point3D.Z);
        }
    }
}