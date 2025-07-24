using SAM.Geometry.Planar;

namespace DiGi.SAM.Geometry.Planar
{
    public static partial class Convert
    {
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
