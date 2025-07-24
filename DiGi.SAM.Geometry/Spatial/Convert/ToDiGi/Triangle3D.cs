using SAM.Geometry.Spatial;

namespace DiGi.SAM.Geometry.Spatial
{
    public static partial class Convert
    {
        public static DiGi.Geometry.Spatial.Classes.Triangle3D ToSAM(this Triangle3D triangle3D)
        {
            if (triangle3D == null)
            {
                return null;
            }

            return new DiGi.Geometry.Spatial.Classes.Triangle3D(triangle3D[0].ToDiGi(), triangle3D[1].ToDiGi(), triangle3D[2].ToDiGi());
        }
    }
}
