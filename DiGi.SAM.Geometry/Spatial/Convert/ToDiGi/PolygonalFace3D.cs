using DiGi.Core;
using DiGi.SAM.Geometry.Planar;
using SAM.Geometry.Spatial;

namespace DiGi.SAM.Geometry.Spatial
{
    public static partial class Convert
    {
        public static DiGi.Geometry.Spatial.Classes.PolygonalFace3D ToDiGi(this Face3D face3D, double tolerance = Core.Constans.Tolerance.Distance)
        {
            Plane plane_SAM = face3D?.GetPlane();
            if (plane_SAM == null)
            {
                return null;
            }

            return new DiGi.Geometry.Spatial.Classes.PolygonalFace3D(plane_SAM.ToDiGi(), plane_SAM.Convert(face3D).ToDiGi());
        }
    }
}
