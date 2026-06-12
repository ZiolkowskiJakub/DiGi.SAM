using SAM.Geometry.Planar;

namespace DiGi.SAM.Geometry.Planar
{
    public static partial class Convert
    {
        /// <summary>
        /// Converts a DiGi.Geometry.Planar.Classes.Vector2D instance to a SAM.Geometry.Planar.Vector2D instance.
        /// </summary>
        /// <param name="vector2D">The source vector to be converted.</param>
        /// <returns>A new Vector2D instance representing the same coordinates, or null if the input vector is null.</returns>
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