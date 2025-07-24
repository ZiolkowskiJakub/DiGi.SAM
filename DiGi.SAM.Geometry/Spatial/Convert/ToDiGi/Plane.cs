using SAM.Geometry.Spatial;

namespace DiGi.SAM.Geometry.Spatial
{
    public static partial class Convert
    {
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
