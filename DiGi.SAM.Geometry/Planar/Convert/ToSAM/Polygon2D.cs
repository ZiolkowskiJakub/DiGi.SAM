using SAM.Geometry.Planar;
using System.Collections.Generic;

namespace DiGi.SAM.Geometry.Planar
{
    public static partial class Convert
    {
        /// <summary>
        /// Converts a <see cref="Polygon2D"/> instance to its corresponding <see cref="DiGi.Geometry.Planar.Classes.Polygon2D"/> representation.
        /// </summary>
        /// <param name="polygon2D">The source polygon to be converted.</param>
        /// <returns>A new <see cref="DiGi.Geometry.Planar.Classes.Polygon2D"/> instance if the input is valid; otherwise, null.</returns>
        public static DiGi.Geometry.Planar.Classes.Polygon2D ToDiGi(this Polygon2D polygon2D)
        {
            List<DiGi.Geometry.Planar.Classes.Point2D> point2Ds = polygon2D?.GetPoints()?.ConvertAll(x => x.ToDiGi());
            if (point2Ds == null)
            {
                return null;
            }

            return new DiGi.Geometry.Planar.Classes.Polygon2D(point2Ds);
        }
    }
}