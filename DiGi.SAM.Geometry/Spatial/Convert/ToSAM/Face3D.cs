using DiGi.Geometry.Planar.Classes;
using SAM.Geometry.Spatial;

namespace DiGi.SAM.Geometry.Spatial
{
    public static partial class Convert
    {
        /// <summary>
        /// Converts a <see cref="DiGi.Geometry.Spatial.Classes.PolygonalFace3D"/> to a <see cref="Face3D"/>.
        /// </summary>
        /// <param name="polygonalFace3D">The polygonal face 3D object to convert.</param>
        /// <returns>A new <see cref="Face3D"/> instance, or null if the input is null or its plane cannot be converted.</returns>
        public static Face3D ToSAM(this DiGi.Geometry.Spatial.Classes.PolygonalFace3D polygonalFace3D)
        {
            if (polygonalFace3D == null)
            {
                return null;
            }

            Plane plane = polygonalFace3D.Plane.ToSAM();
            if (plane == null)
            {
                return null;
            }

            return new Face3D(plane, Planar.Convert.ToSAM(polygonalFace3D.Geometry2D as PolygonalFace2D));
        }
    }
}