using SAM.Geometry.Planar;

namespace DiGi.SAM.Geometry.Planar
{
    public static partial class Convert
    {
        public static DiGi.Geometry.Planar.Classes.Vector2D ToDiGi(this Vector2D vector2D)
        {
            if (vector2D == null)
            {
                return null;
            }

            return new DiGi.Geometry.Planar.Classes.Vector2D(vector2D.X, vector2D.Y);
        }
    }
}
