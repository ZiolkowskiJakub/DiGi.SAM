using SAM.Geometry.Planar;
using System.Collections.Generic;

namespace DiGi.SAM.Geometry.Planar
{
    public static partial class Convert
    {
        /// <summary>
        /// Converts a <see cref="DiGi.Geometry.Planar.Classes.Polygon2D"/> instance to a <see cref="Polygon2D"/> instance.
        /// </summary>
        /// <param name="polygon2D">The source polygon to convert.</param>
        /// <returns>A new <see cref="Polygon2D"/> instance, or <c>null</c> if the input <paramref name="polygon2D"/> is null.</returns>
        public static Polygon2D ToSAM(this DiGi.Geometry.Planar.Classes.Polygon2D polygon2D)
        {
            List<Point2D> point2Ds = polygon2D?.GetPoints()?.ConvertAll(x => x.ToSAM());
            if (point2Ds == null)
            {
                return null;
            }

            return new Polygon2D(point2Ds);
        }
    }
}