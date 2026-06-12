using SAM.Geometry.Spatial;

namespace DiGi.SAM.Geometry.Spatial
{
    public static partial class Convert
    {
        /// <summary>
        /// Converts a <see cref="DiGi.Geometry.Spatial.Classes.Polygon3D"/> instance to a <see cref="Polygon3D"/> instance.
        /// </summary>
        /// <param name="polygon3D">The source polygon to convert.</param>
        /// <returns>A new <see cref="Polygon3D"/> instance if the conversion is successful; otherwise, <c>null</c>.</returns>
        public static Polygon3D ToSAM(this DiGi.Geometry.Spatial.Classes.Polygon3D polygon3D)
        {
            if (polygon3D == null)
            {
                return null;
            }

            Plane plane = polygon3D.Plane.ToSAM();
            if (plane == null)
            {
                return null;
            }

            return new Polygon3D(plane, polygon3D.GetPoints().ConvertAll(x => plane.Convert(x?.ToSAM())));
        }
    }
}