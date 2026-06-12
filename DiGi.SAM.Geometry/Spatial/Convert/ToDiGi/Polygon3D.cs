using SAM.Geometry.Spatial;

namespace DiGi.SAM.Geometry.Spatial
{
    public static partial class Convert
    {
        /// <summary>
        /// Converts a <see cref="Polygon3D"/> instance to its corresponding DiGi geometry representation.
        /// </summary>
        /// <param name="polygon3D">The source polygon to convert.</param>
        /// <returns>A new <see cref="DiGi.Geometry.Spatial.Classes.Polygon3D"/> object, or null if the input is null or cannot be converted.</returns>
        public static DiGi.Geometry.Spatial.Classes.Polygon3D ToDiGi(this Polygon3D polygon3D)
        {
            if (polygon3D == null)
            {
                return null;
            }

            DiGi.Geometry.Spatial.Classes.Plane plane = polygon3D.GetPlane().ToDiGi();
            if (plane == null)
            {
                return null;
            }

            return new DiGi.Geometry.Spatial.Classes.Polygon3D(plane, polygon3D.GetPoints().ConvertAll(x => DiGi.Geometry.Spatial.Query.Convert(plane, x?.ToDiGi())));
        }
    }
}