using SAM.Geometry.Spatial;

namespace DiGi.SAM.Geometry.Spatial
{
    public static partial class Convert
    {
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
