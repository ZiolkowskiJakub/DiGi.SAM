using SAM.Geometry.Planar;

namespace DiGi.SAM.Geometry.Planar
{
    public static partial class Convert
    {
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
