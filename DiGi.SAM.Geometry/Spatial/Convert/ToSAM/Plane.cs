using SAM.Geometry.Spatial;

namespace DiGi.SAM.Geometry.Spatial
{
    public static partial class Convert
    {
        /// <summary>
        /// Converts a <see cref="DiGi.Geometry.Spatial.Classes.Plane"/> to a <see cref="Plane"/>.
        /// </summary>
        /// <param name="plane">The source plane instance to convert.</param>
        /// <returns>A new <see cref="Plane"/> instance converted from the source, or null if the input is null.</returns>
        public static Plane ToSAM(this DiGi.Geometry.Spatial.Classes.Plane plane)
        {
            if (plane == null)
            {
                return null;
            }

            return new Plane(plane.Origin.ToSAM(), plane.AxisX.ToSAM(), plane.AxisY.ToSAM());
        }
    }
}