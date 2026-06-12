using SAM.Geometry.Planar;

namespace DiGi.SAM.Geometry.Planar
{
    public static partial class Convert
    {
        /// <summary>
        /// Converts a SAM Vector2D instance to a DiGi Vector2D instance.
        /// </summary>
        /// <param name="vector2D">The SAM Vector2D instance to convert.</param>
        /// <returns>A new DiGi Vector2D instance containing the same coordinates, or null if the input vector is null.</returns>
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