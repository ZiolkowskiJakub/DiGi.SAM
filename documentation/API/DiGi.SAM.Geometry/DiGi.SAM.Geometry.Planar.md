#### [DiGi\.SAM\.Geometry](DiGi.SAM.Geometry.Overview.md 'DiGi\.SAM\.Geometry\.Overview')

## DiGi\.SAM\.Geometry\.Planar Namespace
### Classes

<a name='DiGi.SAM.Geometry.Planar.Convert'></a>

## Convert Class

```csharp
public static class Convert
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Convert
### Methods

<a name='DiGi.SAM.Geometry.Planar.Convert.ToDiGi(thisSAM.Geometry.Planar.Face2D,double)'></a>

## Convert\.ToDiGi\(this Face2D, double\) Method

Converts a [SAM\.Geometry\.Planar\.Face2D](https://learn.microsoft.com/en-us/dotnet/api/sam.geometry.planar.face2d 'SAM\.Geometry\.Planar\.Face2D') instance to a [DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.polygonalface2d 'DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D')\.

```csharp
public static DiGi.Geometry.Planar.Classes.PolygonalFace2D ToDiGi(this SAM.Geometry.Planar.Face2D face2D, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.SAM.Geometry.Planar.Convert.ToDiGi(thisSAM.Geometry.Planar.Face2D,double).face2D'></a>

`face2D` [SAM\.Geometry\.Planar\.Face2D](https://learn.microsoft.com/en-us/dotnet/api/sam.geometry.planar.face2d 'SAM\.Geometry\.Planar\.Face2D')

The source face to convert\.

<a name='DiGi.SAM.Geometry.Planar.Convert.ToDiGi(thisSAM.Geometry.Planar.Face2D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance used for the conversion process\.

#### Returns
[DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.polygonalface2d 'DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D')  
The converted [DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.polygonalface2d 'DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D') instance, or `null` if the input [face2D](DiGi.SAM.Geometry.Planar.md#DiGi.SAM.Geometry.Planar.Convert.ToDiGi(thisSAM.Geometry.Planar.Face2D,double).face2D 'DiGi\.SAM\.Geometry\.Planar\.Convert\.ToDiGi\(this SAM\.Geometry\.Planar\.Face2D, double\)\.face2D') is null\.

<a name='DiGi.SAM.Geometry.Planar.Convert.ToDiGi(thisSAM.Geometry.Planar.Point2D)'></a>

## Convert\.ToDiGi\(this Point2D\) Method

Converts a [SAM\.Geometry\.Planar\.Point2D](https://learn.microsoft.com/en-us/dotnet/api/sam.geometry.planar.point2d 'SAM\.Geometry\.Planar\.Point2D') instance to a [DiGi\.Geometry\.Planar\.Classes\.Point2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.point2d 'DiGi\.Geometry\.Planar\.Classes\.Point2D') instance\.

```csharp
public static DiGi.Geometry.Planar.Classes.Point2D ToDiGi(this SAM.Geometry.Planar.Point2D point2D);
```
#### Parameters

<a name='DiGi.SAM.Geometry.Planar.Convert.ToDiGi(thisSAM.Geometry.Planar.Point2D).point2D'></a>

`point2D` [SAM\.Geometry\.Planar\.Point2D](https://learn.microsoft.com/en-us/dotnet/api/sam.geometry.planar.point2d 'SAM\.Geometry\.Planar\.Point2D')

The source point to convert\.

#### Returns
[DiGi\.Geometry\.Planar\.Classes\.Point2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.point2d 'DiGi\.Geometry\.Planar\.Classes\.Point2D')  
A new [DiGi\.Geometry\.Planar\.Classes\.Point2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.point2d 'DiGi\.Geometry\.Planar\.Classes\.Point2D') instance, or null if the input is null\.

<a name='DiGi.SAM.Geometry.Planar.Convert.ToDiGi(thisSAM.Geometry.Planar.Polygon2D)'></a>

## Convert\.ToDiGi\(this Polygon2D\) Method

Converts a [SAM\.Geometry\.Planar\.Polygon2D](https://learn.microsoft.com/en-us/dotnet/api/sam.geometry.planar.polygon2d 'SAM\.Geometry\.Planar\.Polygon2D') instance to its corresponding [DiGi\.Geometry\.Planar\.Classes\.Polygon2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.polygon2d 'DiGi\.Geometry\.Planar\.Classes\.Polygon2D') representation\.

```csharp
public static DiGi.Geometry.Planar.Classes.Polygon2D ToDiGi(this SAM.Geometry.Planar.Polygon2D polygon2D);
```
#### Parameters

<a name='DiGi.SAM.Geometry.Planar.Convert.ToDiGi(thisSAM.Geometry.Planar.Polygon2D).polygon2D'></a>

`polygon2D` [SAM\.Geometry\.Planar\.Polygon2D](https://learn.microsoft.com/en-us/dotnet/api/sam.geometry.planar.polygon2d 'SAM\.Geometry\.Planar\.Polygon2D')

The source polygon to be converted\.

#### Returns
[DiGi\.Geometry\.Planar\.Classes\.Polygon2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.polygon2d 'DiGi\.Geometry\.Planar\.Classes\.Polygon2D')  
A new [DiGi\.Geometry\.Planar\.Classes\.Polygon2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.polygon2d 'DiGi\.Geometry\.Planar\.Classes\.Polygon2D') instance if the input is valid; otherwise, null\.

<a name='DiGi.SAM.Geometry.Planar.Convert.ToDiGi(thisSAM.Geometry.Planar.Vector2D)'></a>

## Convert\.ToDiGi\(this Vector2D\) Method

Converts a SAM Vector2D instance to a DiGi Vector2D instance\.

```csharp
public static DiGi.Geometry.Planar.Classes.Vector2D ToDiGi(this SAM.Geometry.Planar.Vector2D vector2D);
```
#### Parameters

<a name='DiGi.SAM.Geometry.Planar.Convert.ToDiGi(thisSAM.Geometry.Planar.Vector2D).vector2D'></a>

`vector2D` [SAM\.Geometry\.Planar\.Vector2D](https://learn.microsoft.com/en-us/dotnet/api/sam.geometry.planar.vector2d 'SAM\.Geometry\.Planar\.Vector2D')

The SAM Vector2D instance to convert\.

#### Returns
[DiGi\.Geometry\.Planar\.Classes\.Vector2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.vector2d 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')  
A new DiGi Vector2D instance containing the same coordinates, or null if the input vector is null\.

<a name='DiGi.SAM.Geometry.Planar.Convert.ToSAM(thisDiGi.Geometry.Planar.Classes.Point2D)'></a>

## Convert\.ToSAM\(this Point2D\) Method

Converts a DiGi Point2D instance to a SAM Point2D instance\.

```csharp
public static SAM.Geometry.Planar.Point2D ToSAM(this DiGi.Geometry.Planar.Classes.Point2D point2D);
```
#### Parameters

<a name='DiGi.SAM.Geometry.Planar.Convert.ToSAM(thisDiGi.Geometry.Planar.Classes.Point2D).point2D'></a>

`point2D` [DiGi\.Geometry\.Planar\.Classes\.Point2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.point2d 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The source point to convert\.

#### Returns
[SAM\.Geometry\.Planar\.Point2D](https://learn.microsoft.com/en-us/dotnet/api/sam.geometry.planar.point2d 'SAM\.Geometry\.Planar\.Point2D')  
A new SAM Point2D instance, or null if the input is null\.

<a name='DiGi.SAM.Geometry.Planar.Convert.ToSAM(thisDiGi.Geometry.Planar.Classes.Polygon2D)'></a>

## Convert\.ToSAM\(this Polygon2D\) Method

Converts a [DiGi\.Geometry\.Planar\.Classes\.Polygon2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.polygon2d 'DiGi\.Geometry\.Planar\.Classes\.Polygon2D') instance to a [SAM\.Geometry\.Planar\.Polygon2D](https://learn.microsoft.com/en-us/dotnet/api/sam.geometry.planar.polygon2d 'SAM\.Geometry\.Planar\.Polygon2D') instance\.

```csharp
public static SAM.Geometry.Planar.Polygon2D ToSAM(this DiGi.Geometry.Planar.Classes.Polygon2D polygon2D);
```
#### Parameters

<a name='DiGi.SAM.Geometry.Planar.Convert.ToSAM(thisDiGi.Geometry.Planar.Classes.Polygon2D).polygon2D'></a>

`polygon2D` [DiGi\.Geometry\.Planar\.Classes\.Polygon2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.polygon2d 'DiGi\.Geometry\.Planar\.Classes\.Polygon2D')

The source polygon to convert\.

#### Returns
[SAM\.Geometry\.Planar\.Polygon2D](https://learn.microsoft.com/en-us/dotnet/api/sam.geometry.planar.polygon2d 'SAM\.Geometry\.Planar\.Polygon2D')  
A new [SAM\.Geometry\.Planar\.Polygon2D](https://learn.microsoft.com/en-us/dotnet/api/sam.geometry.planar.polygon2d 'SAM\.Geometry\.Planar\.Polygon2D') instance, or `null` if the input [polygon2D](DiGi.SAM.Geometry.Planar.md#DiGi.SAM.Geometry.Planar.Convert.ToSAM(thisDiGi.Geometry.Planar.Classes.Polygon2D).polygon2D 'DiGi\.SAM\.Geometry\.Planar\.Convert\.ToSAM\(this DiGi\.Geometry\.Planar\.Classes\.Polygon2D\)\.polygon2D') is null\.

<a name='DiGi.SAM.Geometry.Planar.Convert.ToSAM(thisDiGi.Geometry.Planar.Classes.PolygonalFace2D)'></a>

## Convert\.ToSAM\(this PolygonalFace2D\) Method

Converts a [DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.polygonalface2d 'DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D') instance to a [SAM\.Geometry\.Planar\.Face2D](https://learn.microsoft.com/en-us/dotnet/api/sam.geometry.planar.face2d 'SAM\.Geometry\.Planar\.Face2D') instance\.

```csharp
public static SAM.Geometry.Planar.Face2D ToSAM(this DiGi.Geometry.Planar.Classes.PolygonalFace2D polygonalFace2D);
```
#### Parameters

<a name='DiGi.SAM.Geometry.Planar.Convert.ToSAM(thisDiGi.Geometry.Planar.Classes.PolygonalFace2D).polygonalFace2D'></a>

`polygonalFace2D` [DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.polygonalface2d 'DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D')

The source polygonal face 2D object to be converted\.

#### Returns
[SAM\.Geometry\.Planar\.Face2D](https://learn.microsoft.com/en-us/dotnet/api/sam.geometry.planar.face2d 'SAM\.Geometry\.Planar\.Face2D')  
The converted [SAM\.Geometry\.Planar\.Face2D](https://learn.microsoft.com/en-us/dotnet/api/sam.geometry.planar.face2d 'SAM\.Geometry\.Planar\.Face2D') object, or null if the input [polygonalFace2D](DiGi.SAM.Geometry.Planar.md#DiGi.SAM.Geometry.Planar.Convert.ToSAM(thisDiGi.Geometry.Planar.Classes.PolygonalFace2D).polygonalFace2D 'DiGi\.SAM\.Geometry\.Planar\.Convert\.ToSAM\(this DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D\)\.polygonalFace2D') is null\.

<a name='DiGi.SAM.Geometry.Planar.Convert.ToSAM(thisDiGi.Geometry.Planar.Classes.Vector2D)'></a>

## Convert\.ToSAM\(this Vector2D\) Method

Converts a DiGi\.Geometry\.Planar\.Classes\.Vector2D instance to a SAM\.Geometry\.Planar\.Vector2D instance\.

```csharp
public static SAM.Geometry.Planar.Vector2D ToSAM(this DiGi.Geometry.Planar.Classes.Vector2D vector2D);
```
#### Parameters

<a name='DiGi.SAM.Geometry.Planar.Convert.ToSAM(thisDiGi.Geometry.Planar.Classes.Vector2D).vector2D'></a>

`vector2D` [DiGi\.Geometry\.Planar\.Classes\.Vector2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.vector2d 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')

The source vector to be converted\.

#### Returns
[SAM\.Geometry\.Planar\.Vector2D](https://learn.microsoft.com/en-us/dotnet/api/sam.geometry.planar.vector2d 'SAM\.Geometry\.Planar\.Vector2D')  
A new Vector2D instance representing the same coordinates, or null if the input vector is null\.