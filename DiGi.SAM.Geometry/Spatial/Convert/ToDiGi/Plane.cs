using SAM.Geometry.Spatial;

namespace DiGi.SAM.Geometry.Spatial
{
    public static partial class Convert
    {
        /// <summary>
        /// Converts a SAM Plane instance to its corresponding DiGi Plane representation.
        /// </summary>
        /// <param name="plane">The SAM Plane instance to convert.</param>
        /// <returns>A new DiGi.Geometry.Spatial.Classes.Plane instance, or null if the provided plane is null.</returns>
        public static DiGi.Geometry.Spatial.Classes.Plane ToDiGi(this Plane plane)
        {
            if (plane == null)
            {
                return null;
            }

            return new DiGi.Geometry.Spatial.Classes.Plane(plane.Origin.ToDiGi(), plane.AxisX.ToDiGi(), plane.AxisY.ToDiGi());
        }
    }
}