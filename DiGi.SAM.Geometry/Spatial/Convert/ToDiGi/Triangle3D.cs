using SAM.Geometry.Spatial;

namespace DiGi.SAM.Geometry.Spatial
{
    public static partial class Convert
    {
        /// <summary>
        /// Converts a SAM Triangle3D instance to a DiGi Geometry Spatial Triangle3D instance.
        /// </summary>
        /// <param name="triangle3D">The SAM Triangle3D object to convert.</param>
        /// <returns>A new DiGi.Geometry.Spatial.Classes.Triangle3D object, or null if the input is null.</returns>
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