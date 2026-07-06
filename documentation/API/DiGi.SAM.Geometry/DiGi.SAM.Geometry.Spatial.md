#### [DiGi\.SAM\.Geometry](index.md 'index')

## DiGi\.SAM\.Geometry\.Spatial Namespace
### Classes

<a name='DiGi.SAM.Geometry.Spatial.Convert'></a>

## Convert Class

```csharp
public static class Convert
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Convert
### Methods

<a name='DiGi.SAM.Geometry.Spatial.Convert.ToDiGi(thisSAM.Geometry.Spatial.Face3D)'></a>

## Convert\.ToDiGi\(this Face3D\) Method

Converts a [SAM\.Geometry\.Spatial\.Face3D](https://learn.microsoft.com/en-us/dotnet/api/sam.geometry.spatial.face3d 'SAM\.Geometry\.Spatial\.Face3D') instance to its corresponding [DiGi\.Geometry\.Spatial\.Classes\.PolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.polygonalface3d 'DiGi\.Geometry\.Spatial\.Classes\.PolygonalFace3D') representation\.

```csharp
public static DiGi.Geometry.Spatial.Classes.PolygonalFace3D ToDiGi(this SAM.Geometry.Spatial.Face3D face3D);
```
#### Parameters

<a name='DiGi.SAM.Geometry.Spatial.Convert.ToDiGi(thisSAM.Geometry.Spatial.Face3D).face3D'></a>

`face3D` [SAM\.Geometry\.Spatial\.Face3D](https://learn.microsoft.com/en-us/dotnet/api/sam.geometry.spatial.face3d 'SAM\.Geometry\.Spatial\.Face3D')

The [SAM\.Geometry\.Spatial\.Face3D](https://learn.microsoft.com/en-us/dotnet/api/sam.geometry.spatial.face3d 'SAM\.Geometry\.Spatial\.Face3D') instance to convert\.

#### Returns
[DiGi\.Geometry\.Spatial\.Classes\.PolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.polygonalface3d 'DiGi\.Geometry\.Spatial\.Classes\.PolygonalFace3D')  
A new [DiGi\.Geometry\.Spatial\.Classes\.PolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.polygonalface3d 'DiGi\.Geometry\.Spatial\.Classes\.PolygonalFace3D') instance, or `null` if the provided [face3D](DiGi.SAM.Geometry.Spatial.md#DiGi.SAM.Geometry.Spatial.Convert.ToDiGi(thisSAM.Geometry.Spatial.Face3D).face3D 'DiGi\.SAM\.Geometry\.Spatial\.Convert\.ToDiGi\(this SAM\.Geometry\.Spatial\.Face3D\)\.face3D') is null or cannot provide a valid plane\.

<a name='DiGi.SAM.Geometry.Spatial.Convert.ToDiGi(thisSAM.Geometry.Spatial.Plane)'></a>

## Convert\.ToDiGi\(this Plane\) Method

Converts a SAM Plane instance to its corresponding DiGi Plane representation\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Plane ToDiGi(this SAM.Geometry.Spatial.Plane plane);
```
#### Parameters

<a name='DiGi.SAM.Geometry.Spatial.Convert.ToDiGi(thisSAM.Geometry.Spatial.Plane).plane'></a>

`plane` [SAM\.Geometry\.Spatial\.Plane](https://learn.microsoft.com/en-us/dotnet/api/sam.geometry.spatial.plane 'SAM\.Geometry\.Spatial\.Plane')

The SAM Plane instance to convert\.

#### Returns
[DiGi\.Geometry\.Spatial\.Classes\.Plane](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')  
A new DiGi\.Geometry\.Spatial\.Classes\.Plane instance, or null if the provided plane is null\.

<a name='DiGi.SAM.Geometry.Spatial.Convert.ToDiGi(thisSAM.Geometry.Spatial.Point3D)'></a>

## Convert\.ToDiGi\(this Point3D\) Method

Converts a [SAM\.Geometry\.Spatial\.Point3D](https://learn.microsoft.com/en-us/dotnet/api/sam.geometry.spatial.point3d 'SAM\.Geometry\.Spatial\.Point3D') instance to a [DiGi\.Geometry\.Spatial\.Classes\.Point3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.point3d 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') instance\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Point3D ToDiGi(this SAM.Geometry.Spatial.Point3D point3D);
```
#### Parameters

<a name='DiGi.SAM.Geometry.Spatial.Convert.ToDiGi(thisSAM.Geometry.Spatial.Point3D).point3D'></a>

`point3D` [SAM\.Geometry\.Spatial\.Point3D](https://learn.microsoft.com/en-us/dotnet/api/sam.geometry.spatial.point3d 'SAM\.Geometry\.Spatial\.Point3D')

The source point to convert\.

#### Returns
[DiGi\.Geometry\.Spatial\.Classes\.Point3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.point3d 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')  
A new [DiGi\.Geometry\.Spatial\.Classes\.Point3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.point3d 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') instance, or null if the input is null\.

<a name='DiGi.SAM.Geometry.Spatial.Convert.ToDiGi(thisSAM.Geometry.Spatial.Polygon3D)'></a>

## Convert\.ToDiGi\(this Polygon3D\) Method

Converts a [SAM\.Geometry\.Spatial\.Polygon3D](https://learn.microsoft.com/en-us/dotnet/api/sam.geometry.spatial.polygon3d 'SAM\.Geometry\.Spatial\.Polygon3D') instance to its corresponding DiGi geometry representation\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Polygon3D ToDiGi(this SAM.Geometry.Spatial.Polygon3D polygon3D);
```
#### Parameters

<a name='DiGi.SAM.Geometry.Spatial.Convert.ToDiGi(thisSAM.Geometry.Spatial.Polygon3D).polygon3D'></a>

`polygon3D` [SAM\.Geometry\.Spatial\.Polygon3D](https://learn.microsoft.com/en-us/dotnet/api/sam.geometry.spatial.polygon3d 'SAM\.Geometry\.Spatial\.Polygon3D')

The source polygon to convert\.

#### Returns
[DiGi\.Geometry\.Spatial\.Classes\.Polygon3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.polygon3d 'DiGi\.Geometry\.Spatial\.Classes\.Polygon3D')  
A new [DiGi\.Geometry\.Spatial\.Classes\.Polygon3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.polygon3d 'DiGi\.Geometry\.Spatial\.Classes\.Polygon3D') object, or null if the input is null or cannot be converted\.

<a name='DiGi.SAM.Geometry.Spatial.Convert.ToDiGi(thisSAM.Geometry.Spatial.Vector3D)'></a>

## Convert\.ToDiGi\(this Vector3D\) Method

Converts a SAM Vector3D instance to a DiGi Geometry Spatial Vector3D instance\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Vector3D ToDiGi(this SAM.Geometry.Spatial.Vector3D vector3D);
```
#### Parameters

<a name='DiGi.SAM.Geometry.Spatial.Convert.ToDiGi(thisSAM.Geometry.Spatial.Vector3D).vector3D'></a>

`vector3D` [SAM\.Geometry\.Spatial\.Vector3D](https://learn.microsoft.com/en-us/dotnet/api/sam.geometry.spatial.vector3d 'SAM\.Geometry\.Spatial\.Vector3D')

The SAM Vector3D instance to convert\.

#### Returns
[DiGi\.Geometry\.Spatial\.Classes\.Vector3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.vector3d 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')  
A new DiGi Geometry Spatial Vector3D instance, or null if the input is null\.

<a name='DiGi.SAM.Geometry.Spatial.Convert.ToSAM(thisDiGi.Geometry.Spatial.Classes.Plane)'></a>

## Convert\.ToSAM\(this Plane\) Method

Converts a [DiGi\.Geometry\.Spatial\.Classes\.Plane](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') to a [SAM\.Geometry\.Spatial\.Plane](https://learn.microsoft.com/en-us/dotnet/api/sam.geometry.spatial.plane 'SAM\.Geometry\.Spatial\.Plane')\.

```csharp
public static SAM.Geometry.Spatial.Plane ToSAM(this DiGi.Geometry.Spatial.Classes.Plane plane);
```
#### Parameters

<a name='DiGi.SAM.Geometry.Spatial.Convert.ToSAM(thisDiGi.Geometry.Spatial.Classes.Plane).plane'></a>

`plane` [DiGi\.Geometry\.Spatial\.Classes\.Plane](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')

The source plane instance to convert\.

#### Returns
[SAM\.Geometry\.Spatial\.Plane](https://learn.microsoft.com/en-us/dotnet/api/sam.geometry.spatial.plane 'SAM\.Geometry\.Spatial\.Plane')  
A new [SAM\.Geometry\.Spatial\.Plane](https://learn.microsoft.com/en-us/dotnet/api/sam.geometry.spatial.plane 'SAM\.Geometry\.Spatial\.Plane') instance converted from the source, or null if the input is null\.

<a name='DiGi.SAM.Geometry.Spatial.Convert.ToSAM(thisDiGi.Geometry.Spatial.Classes.Point3D)'></a>

## Convert\.ToSAM\(this Point3D\) Method

Converts a DiGi Geometry Point3D instance to a SAM Geometry Point3D instance\.

```csharp
public static SAM.Geometry.Spatial.Point3D ToSAM(this DiGi.Geometry.Spatial.Classes.Point3D point3D);
```
#### Parameters

<a name='DiGi.SAM.Geometry.Spatial.Convert.ToSAM(thisDiGi.Geometry.Spatial.Classes.Point3D).point3D'></a>

`point3D` [DiGi\.Geometry\.Spatial\.Classes\.Point3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.point3d 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The source point to be converted\.

#### Returns
[SAM\.Geometry\.Spatial\.Point3D](https://learn.microsoft.com/en-us/dotnet/api/sam.geometry.spatial.point3d 'SAM\.Geometry\.Spatial\.Point3D')  
A new [SAM\.Geometry\.Spatial\.Point3D](https://learn.microsoft.com/en-us/dotnet/api/sam.geometry.spatial.point3d 'SAM\.Geometry\.Spatial\.Point3D') instance representing the same coordinates, or null if the input is null\.

<a name='DiGi.SAM.Geometry.Spatial.Convert.ToSAM(thisDiGi.Geometry.Spatial.Classes.Polygon3D)'></a>

## Convert\.ToSAM\(this Polygon3D\) Method

Converts a [DiGi\.Geometry\.Spatial\.Classes\.Polygon3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.polygon3d 'DiGi\.Geometry\.Spatial\.Classes\.Polygon3D') instance to a [SAM\.Geometry\.Spatial\.Polygon3D](https://learn.microsoft.com/en-us/dotnet/api/sam.geometry.spatial.polygon3d 'SAM\.Geometry\.Spatial\.Polygon3D') instance\.

```csharp
public static SAM.Geometry.Spatial.Polygon3D ToSAM(this DiGi.Geometry.Spatial.Classes.Polygon3D polygon3D);
```
#### Parameters

<a name='DiGi.SAM.Geometry.Spatial.Convert.ToSAM(thisDiGi.Geometry.Spatial.Classes.Polygon3D).polygon3D'></a>

`polygon3D` [DiGi\.Geometry\.Spatial\.Classes\.Polygon3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.polygon3d 'DiGi\.Geometry\.Spatial\.Classes\.Polygon3D')

The source polygon to convert\.

#### Returns
[SAM\.Geometry\.Spatial\.Polygon3D](https://learn.microsoft.com/en-us/dotnet/api/sam.geometry.spatial.polygon3d 'SAM\.Geometry\.Spatial\.Polygon3D')  
A new [SAM\.Geometry\.Spatial\.Polygon3D](https://learn.microsoft.com/en-us/dotnet/api/sam.geometry.spatial.polygon3d 'SAM\.Geometry\.Spatial\.Polygon3D') instance if the conversion is successful; otherwise, `null`\.

<a name='DiGi.SAM.Geometry.Spatial.Convert.ToSAM(thisDiGi.Geometry.Spatial.Classes.PolygonalFace3D)'></a>

## Convert\.ToSAM\(this PolygonalFace3D\) Method

Converts a [DiGi\.Geometry\.Spatial\.Classes\.PolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.polygonalface3d 'DiGi\.Geometry\.Spatial\.Classes\.PolygonalFace3D') to a [SAM\.Geometry\.Spatial\.Face3D](https://learn.microsoft.com/en-us/dotnet/api/sam.geometry.spatial.face3d 'SAM\.Geometry\.Spatial\.Face3D')\.

```csharp
public static SAM.Geometry.Spatial.Face3D ToSAM(this DiGi.Geometry.Spatial.Classes.PolygonalFace3D polygonalFace3D);
```
#### Parameters

<a name='DiGi.SAM.Geometry.Spatial.Convert.ToSAM(thisDiGi.Geometry.Spatial.Classes.PolygonalFace3D).polygonalFace3D'></a>

`polygonalFace3D` [DiGi\.Geometry\.Spatial\.Classes\.PolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.polygonalface3d 'DiGi\.Geometry\.Spatial\.Classes\.PolygonalFace3D')

The polygonal face 3D object to convert\.

#### Returns
[SAM\.Geometry\.Spatial\.Face3D](https://learn.microsoft.com/en-us/dotnet/api/sam.geometry.spatial.face3d 'SAM\.Geometry\.Spatial\.Face3D')  
A new [SAM\.Geometry\.Spatial\.Face3D](https://learn.microsoft.com/en-us/dotnet/api/sam.geometry.spatial.face3d 'SAM\.Geometry\.Spatial\.Face3D') instance, or null if the input is null or its plane cannot be converted\.

<a name='DiGi.SAM.Geometry.Spatial.Convert.ToSAM(thisDiGi.Geometry.Spatial.Classes.Triangle3D)'></a>

## Convert\.ToSAM\(this Triangle3D\) Method

Converts a [DiGi\.Geometry\.Spatial\.Classes\.Triangle3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.triangle3d 'DiGi\.Geometry\.Spatial\.Classes\.Triangle3D') instance to a [SAM\.Geometry\.Spatial\.Triangle3D](https://learn.microsoft.com/en-us/dotnet/api/sam.geometry.spatial.triangle3d 'SAM\.Geometry\.Spatial\.Triangle3D') instance\.

```csharp
public static SAM.Geometry.Spatial.Triangle3D ToSAM(this DiGi.Geometry.Spatial.Classes.Triangle3D triangle3D);
```
#### Parameters

<a name='DiGi.SAM.Geometry.Spatial.Convert.ToSAM(thisDiGi.Geometry.Spatial.Classes.Triangle3D).triangle3D'></a>

`triangle3D` [DiGi\.Geometry\.Spatial\.Classes\.Triangle3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.triangle3d 'DiGi\.Geometry\.Spatial\.Classes\.Triangle3D')

The source triangle to convert\.

#### Returns
[SAM\.Geometry\.Spatial\.Triangle3D](https://learn.microsoft.com/en-us/dotnet/api/sam.geometry.spatial.triangle3d 'SAM\.Geometry\.Spatial\.Triangle3D')  
A new [SAM\.Geometry\.Spatial\.Triangle3D](https://learn.microsoft.com/en-us/dotnet/api/sam.geometry.spatial.triangle3d 'SAM\.Geometry\.Spatial\.Triangle3D') instance converted from the source, or null if the source is null\.

<a name='DiGi.SAM.Geometry.Spatial.Convert.ToSAM(thisDiGi.Geometry.Spatial.Classes.Vector3D)'></a>

## Convert\.ToSAM\(this Vector3D\) Method

Converts a [DiGi\.Geometry\.Spatial\.Classes\.Vector3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.vector3d 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') to a [SAM\.Geometry\.Spatial\.Vector3D](https://learn.microsoft.com/en-us/dotnet/api/sam.geometry.spatial.vector3d 'SAM\.Geometry\.Spatial\.Vector3D')\.

```csharp
public static SAM.Geometry.Spatial.Vector3D ToSAM(this DiGi.Geometry.Spatial.Classes.Vector3D vector3D);
```
#### Parameters

<a name='DiGi.SAM.Geometry.Spatial.Convert.ToSAM(thisDiGi.Geometry.Spatial.Classes.Vector3D).vector3D'></a>

`vector3D` [DiGi\.Geometry\.Spatial\.Classes\.Vector3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.vector3d 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')

The source vector to convert\.

#### Returns
[SAM\.Geometry\.Spatial\.Vector3D](https://learn.microsoft.com/en-us/dotnet/api/sam.geometry.spatial.vector3d 'SAM\.Geometry\.Spatial\.Vector3D')  
A new [SAM\.Geometry\.Spatial\.Vector3D](https://learn.microsoft.com/en-us/dotnet/api/sam.geometry.spatial.vector3d 'SAM\.Geometry\.Spatial\.Vector3D') instance containing the same coordinates, or null if the input is null\.

<a name='DiGi.SAM.Geometry.Spatial.Convert.ToSAM(thisSAM.Geometry.Spatial.Triangle3D)'></a>

## Convert\.ToSAM\(this Triangle3D\) Method

Converts a SAM Triangle3D instance to a DiGi Geometry Spatial Triangle3D instance\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Triangle3D ToSAM(this SAM.Geometry.Spatial.Triangle3D triangle3D);
```
#### Parameters

<a name='DiGi.SAM.Geometry.Spatial.Convert.ToSAM(thisSAM.Geometry.Spatial.Triangle3D).triangle3D'></a>

`triangle3D` [SAM\.Geometry\.Spatial\.Triangle3D](https://learn.microsoft.com/en-us/dotnet/api/sam.geometry.spatial.triangle3d 'SAM\.Geometry\.Spatial\.Triangle3D')

The SAM Triangle3D object to convert\.

#### Returns
[DiGi\.Geometry\.Spatial\.Classes\.Triangle3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.triangle3d 'DiGi\.Geometry\.Spatial\.Classes\.Triangle3D')  
A new DiGi\.Geometry\.Spatial\.Classes\.Triangle3D object, or null if the input is null\.