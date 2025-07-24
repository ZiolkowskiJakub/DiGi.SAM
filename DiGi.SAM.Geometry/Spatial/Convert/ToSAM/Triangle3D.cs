using SAM.Geometry.Spatial;

namespace DiGi.SAM.Geometry.Spatial
{
    public static partial class Convert
    {
        public static Triangle3D ToSAM(this DiGi.Geometry.Spatial.Classes.Triangle3D triangle3D)
        {
            if (triangle3D == null)
            {
                return null;
            }

            return new Triangle3D(triangle3D[0].ToSAM(), triangle3D[1].ToSAM(), triangle3D[2].ToSAM());
        }
    }
}
