using SAM.Geometry.Spatial;

namespace DiGi.SAM.Geometry.Spatial
{
    public static partial class Convert
    {
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
