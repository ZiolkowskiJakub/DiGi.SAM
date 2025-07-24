using SAM.Geometry.Spatial;

namespace DiGi.SAM.Geometry.Spatial
{
    public static partial class Convert
    {
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
