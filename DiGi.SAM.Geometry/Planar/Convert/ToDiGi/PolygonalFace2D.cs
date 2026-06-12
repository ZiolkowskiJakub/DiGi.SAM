using DiGi.Geometry.Planar.Interfaces;
using SAM.Geometry.Planar;
using System.Collections.Generic;

namespace DiGi.SAM.Geometry.Planar
{
    public static partial class Convert
    {
        /// <summary>
        /// Converts a <see cref="Face2D"/> instance to a <see cref="DiGi.Geometry.Planar.Classes.PolygonalFace2D"/>.
        /// </summary>
        /// <param name="face2D">The source face to convert.</param>
        /// <param name="tolerance">The distance tolerance used for the conversion process.</param>
        /// <returns>The converted <see cref="DiGi.Geometry.Planar.Classes.PolygonalFace2D"/> instance, or <c>null</c> if the input <paramref name="face2D"/> is null.</returns>
        public static DiGi.Geometry.Planar.Classes.PolygonalFace2D ToDiGi(this Face2D face2D, double tolerance = Core.Constants.Tolerance.Distance)
        {
            if (face2D == null)
            {
                return null;
            }

            DiGi.Geometry.Planar.Classes.Polygon2D externalEdge = ToDiGi(face2D.ExternalEdge2D as Polygon2D);

            List<IPolygonal2D> internalEdges = null;

            List<IClosed2D> internalEdges_SAM = face2D.InternalEdge2Ds;
            if (internalEdges_SAM != null || internalEdges_SAM.Count != 0)
            {
                internalEdges = [];

                foreach (IClosed2D internalEdge_SAM in internalEdges_SAM)
                {
                    DiGi.Geometry.Planar.Classes.Polygon2D internalEdge = ToDiGi(internalEdge_SAM as Polygon2D);
                    if (internalEdge == null)
                    {
                        continue;
                    }

                    internalEdges.Add(internalEdge);
                }
            }

            return DiGi.Geometry.Planar.Create.PolygonalFace2D(externalEdge, internalEdges, tolerance);
        }
    }
}