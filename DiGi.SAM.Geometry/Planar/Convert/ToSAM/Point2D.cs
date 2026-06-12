using SAM.Geometry.Planar;

namespace DiGi.SAM.Geometry.Planar
{
    public static partial class Convert
    {
        /// <summary>
        /// Converts a DiGi Point2D instance to a SAM Point2D instance.
        /// </summary>
        /// <param name="point2D">The source point to convert.</param>
        /// <returns>A new SAM Point2D instance, or null if the input is null.</returns>
        public static Point2D ToSAM(this DiGi.Geometry.Planar.Classes.Point2D point2D)
        {
            if (point2D == null)
            {
                return null;
            }

            return new Point2D(point2D.X, point2D.Y);
        }
    }
}