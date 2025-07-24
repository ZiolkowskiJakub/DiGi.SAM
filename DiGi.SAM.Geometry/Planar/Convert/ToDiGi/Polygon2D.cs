using SAM.Geometry.Planar;
using System.Collections.Generic;

namespace DiGi.SAM.Geometry.Planar
{
    public static partial class Convert
    {
        public static Polygon2D ToSAM(this DiGi.Geometry.Planar.Classes.Polygon2D polygon2D)
        {
            List<Point2D> point2Ds = polygon2D?.GetPoints()?.ConvertAll(x => x.ToSAM());
            if(point2Ds == null)
            {
                return null;
            }

            return new Polygon2D(point2Ds);
        }
    }
}
