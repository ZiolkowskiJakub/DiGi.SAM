using SAM.Geometry.Spatial;

namespace DiGi.SAM.Geometry.Spatial
{
    public static partial class Convert
    {
        public static Polygon3D ToSAM(this DiGi.Geometry.Spatial.Classes.Polygon3D polygon3D)
        {
            if (polygon3D == null)
            {
                return null;
            }

            Plane plane = polygon3D.Plane.ToSAM();
            if(plane == null)
            {
                return null;
            }

            return new Polygon3D(plane, polygon3D.GetPoints().ConvertAll(x => plane.Convert(x?.ToSAM())));
        }
    }
}
