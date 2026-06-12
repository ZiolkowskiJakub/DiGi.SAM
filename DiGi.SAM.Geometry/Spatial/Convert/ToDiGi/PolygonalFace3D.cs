using DiGi.Core;
using DiGi.SAM.Geometry.Planar;
using SAM.Geometry.Spatial;

namespace DiGi.SAM.Geometry.Spatial
{
    public static partial class Convert
    {
        /// <summary>
        /// Converts a <see cref="Face3D"/> instance to its corresponding <see cref="DiGi.Geometry.Spatial.Classes.PolygonalFace3D"/> representation.
        /// </summary>
        /// <param name="face3D">The <see cref="Face3D"/> instance to convert.</param>
        /// <returns>A new <see cref="DiGi.Geometry.Spatial.Classes.PolygonalFace3D"/> instance, or <c>null</c> if the provided <paramref name="face3D"/> is null or cannot provide a valid plane.</returns>
        public static DiGi.Geometry.Spatial.Classes.PolygonalFace3D ToDiGi(this Face3D face3D)
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