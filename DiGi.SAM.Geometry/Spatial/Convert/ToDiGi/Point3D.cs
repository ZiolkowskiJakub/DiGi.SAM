using SAM.Geometry.Spatial;

namespace DiGi.SAM.Geometry.Spatial
{
    public static partial class Convert
    {
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
