using SAM.Geometry.Planar;

namespace DiGi.SAM.Geometry.Planar
{
    public static partial class Convert
    {
        /// <summary>
        /// Converts a <see cref="Point2D"/> instance to a <see cref="DiGi.Geometry.Planar.Classes.Point2D"/> instance.
        /// </summary>
        /// <param name="point2D">The source point to convert.</param>
        /// <returns>A new <see cref="DiGi.Geometry.Planar.Classes.Point2D"/> instance, or null if the input is null.</returns>
        public static DiGi.Geometry.Planar.Classes.Point2D ToDiGi(this Point2D point2D)
        {
            if (point2D == null)
            {
                return null;
            }

            return new DiGi.Geometry.Planar.Classes.Point2D(point2D.X, point2D.Y);
        }
    }
}