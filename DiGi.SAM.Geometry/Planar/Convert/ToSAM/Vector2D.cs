using SAM.Geometry.Planar;

namespace DiGi.SAM.Geometry.Planar
{
    public static partial class Convert
    {
        public static Vector2D ToSAM(this DiGi.Geometry.Planar.Classes.Vector2D vector2D)
        {
            if (vector2D == null)
            {
                return null;
            }

            return new Vector2D(vector2D.X, vector2D.Y);
        }
    }
}
