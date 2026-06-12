using SAM.Geometry.Spatial;

namespace DiGi.SAM.Geometry.Spatial
{
    public static partial class Convert
    {
        /// <summary>
        /// Converts a <see cref="DiGi.Geometry.Spatial.Classes.Triangle3D"/> instance to a <see cref="Triangle3D"/> instance.
        /// </summary>
        /// <param name="triangle3D">The source triangle to convert.</param>
        /// <returns>A new <see cref="Triangle3D"/> instance converted from the source, or null if the source is null.</returns>
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