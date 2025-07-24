using SAM.Geometry.Planar;
using System.Collections.Generic;

namespace DiGi.SAM.Geometry.Planar
{
    public static partial class Convert
    {
        public static DiGi.Geometry.Planar.Classes.Polygon2D ToDiGi(this Polygon2D polygon2D)
        {
            List<DiGi.Geometry.Planar.Classes.Point2D> point2Ds = polygon2D?.GetPoints()?.ConvertAll(x => x.ToDiGi());
            if(point2Ds == null)
            {
                return null;
            }

            return new DiGi.Geometry.Planar.Classes.Polygon2D(point2Ds);
        }
    }
}
