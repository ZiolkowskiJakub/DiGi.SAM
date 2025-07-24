using SAM.Geometry.Spatial;

namespace DiGi.SAM.Geometry.Spatial
{
    public static partial class Convert
    {
        public static DiGi.Geometry.Spatial.Classes.Polygon3D ToDiGi(this Polygon3D polygon3D)
        {
            if (polygon3D == null)
            {
                return null;
            }

            DiGi.Geometry.Spatial.Classes.Plane plane = polygon3D.GetPlane().ToDiGi();
            if(plane == null)
            {
                return null;
            }

            return new DiGi.Geometry.Spatial.Classes.Polygon3D(plane, polygon3D.GetPoints().ConvertAll(x => DiGi.Geometry.Spatial.Query.Convert(plane, x?.ToDiGi())));
        }
    }
}
