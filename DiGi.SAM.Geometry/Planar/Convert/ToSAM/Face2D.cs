using SAM.Geometry.Planar;
using System.Collections.Generic;

namespace DiGi.SAM.Geometry.Planar
{
    public static partial class Convert
    {
        public static Face2D ToSAM(this DiGi.Geometry.Planar.Classes.PolygonalFace2D polygonalFace2D)
        {
            if (polygonalFace2D == null)
            {
                return null;
            }

            Polygon2D externalEdge_SAM = ToSAM(polygonalFace2D.ExternalEdge as DiGi.Geometry.Planar.Classes.Polygon2D);

            List<Polygon2D> internalEdges_SAM = null;

            List<DiGi.Geometry.Planar.Interfaces.IPolygonal2D> internalEdges = polygonalFace2D.InternalEdges;
            if(internalEdges != null || internalEdges.Count != 0)
            {
                internalEdges_SAM = new List<Polygon2D>();

                foreach(DiGi.Geometry.Planar.Interfaces.IPolygonal2D internalEdge in internalEdges)
                {
                    Polygon2D internalEdge_SAM = ToSAM(internalEdge as DiGi.Geometry.Planar.Classes.Polygon2D);
                    if(internalEdge_SAM == null)
                    {
                        continue;
                    }

                    internalEdges_SAM.Add(internalEdge_SAM);
                }
            }

            return Create.Face2D(externalEdge_SAM, internalEdges_SAM);
        }
    }
}
