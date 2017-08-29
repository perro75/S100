//EksML - S100 application schema to csCode 1.6.2017 17:14:41

using System;
using System.ComponentModel;

using gml;


namespace gml {


///<summary>
///no description available
///</summary>
public enum AggregationType { 
	///<summary>
	///no description available
	///</summary>
	[Description("set")]
	set=1,
	///<summary>
	///no description available
	///</summary>
	[Description("bag")]
	bag=2,
	///<summary>
	///no description available
	///</summary>
	[Description("sequence")]
	sequence=3,
	///<summary>
	///no description available
	///</summary>
	[Description("array")]
	array=4,
	///<summary>
	///no description available
	///</summary>
	[Description("record")]
	record=5,
	///<summary>
	///no description available
	///</summary>
	[Description("table")]
	table=6
}

///<summary>
///gml:CurveInterpolationType is a list of codes that may be used to identify the interpolation mechanisms specified by an application schema.
///</summary>
public enum CurveInterpolationType { 
	///<summary>
	///no description available
	///</summary>
	[Description("linear")]
	linear=1,
	///<summary>
	///no description available
	///</summary>
	[Description("geodesic")]
	geodesic=2,
	///<summary>
	///no description available
	///</summary>
	[Description("circularArc3Points")]
	circularArc3Points=3,
	///<summary>
	///no description available
	///</summary>
	[Description("circularArcCenterPointWithRadius")]
	circularArcCenterPointWithRadius=4,
	///<summary>
	///no description available
	///</summary>
	[Description("circularArc2PointWithBulge")]
	circularArc2PointWithBulge=5,
	///<summary>
	///no description available
	///</summary>
	[Description("elliptical")]
	elliptical=6,
	///<summary>
	///no description available
	///</summary>
	[Description("clothoid")]
	clothoid=7,
	///<summary>
	///no description available
	///</summary>
	[Description("conic")]
	conic=8,
	///<summary>
	///no description available
	///</summary>
	[Description("polynomialSpline")]
	polynomialSpline=9,
	///<summary>
	///no description available
	///</summary>
	[Description("cubicSpline")]
	cubicSpline=10,
	///<summary>
	///no description available
	///</summary>
	[Description("rationalSpline")]
	rationalSpline=11
}

///<summary>
///gml:SurfaceInterpolationType is a list of codes that may be used to identify the interpolation mechanisms specified by an application schema.
///</summary>
public enum SurfaceInterpolationType { 
	///<summary>
	///no description available
	///</summary>
	[Description("none")]
	none=1,
	///<summary>
	///no description available
	///</summary>
	[Description("planar")]
	planar=2,
	///<summary>
	///no description available
	///</summary>
	[Description("spherical")]
	spherical=3,
	///<summary>
	///no description available
	///</summary>
	[Description("elliptical")]
	elliptical=4,
	///<summary>
	///no description available
	///</summary>
	[Description("conic")]
	conic=5,
	///<summary>
	///no description available
	///</summary>
	[Description("tin")]
	tin=6,
	///<summary>
	///no description available
	///</summary>
	[Description("parametricCurve")]
	parametricCurve=7,
	///<summary>
	///no description available
	///</summary>
	[Description("polynomialSpline")]
	polynomialSpline=8,
	///<summary>
	///no description available
	///</summary>
	[Description("rationalSpline")]
	rationalSpline=9,
	///<summary>
	///no description available
	///</summary>
	[Description("triangulatedSpline")]
	triangulatedSpline=10
}

///<summary>
///gml:SignType is a convenience type with values "+" (plus) and "-" (minus).
///</summary>
public enum SignType { 
	///<summary>
	///no description available
	///</summary>
	[Description("-")]
	minus=1,
	///<summary>
	///no description available
	///</summary>
	[Description("+")]
	plus=2
}

///<summary>
///gml:NilReasonType defines a content model that allows recording of an explanation for a void value or other exception. gml:NilReasonType is a union of the following enumerated values: - inapplicable there is no value - missing the correct value is not readily available to the sender of this data. Furthermore, a correct value may not exist - template the value will be available later - unknown the correct value is not known to, and not computable by, the sender of this data. However, a correct value probably exists - withheld the value is not divulged - other:text other brief explanation, where text is a string of two or more characters with no included spaces and - anyURI which should refer to a resource which describes the reason for the exception A particular community may choose to assign more detailed semantics to the standard values provided. Alternatively, the URI method enables a specific or more complete explanation for the absence of a value to be provided elsewhere and indicated by-reference in an instance document. gml:NilReasonType is used as a member of a union in a number of simple content types where it is necessary to permit a value from the NilReasonType union as an alternative to the primary type.
///</summary>
public struct NilReasonType { 
 	public gml.NilReasonEnumeration _NilReasonEnumeration;
	public anyURI _anyURI;

}

///<summary>
///no description available
///</summary>
public enum NilReasonEnumeration { 
	///<summary>
	///no description available
	///</summary>
	[Description("inapplicable")]
	inapplicable=1,
	///<summary>
	///no description available
	///</summary>
	[Description("missing")]
	missing=2,
	///<summary>
	///no description available
	///</summary>
	[Description("template")]
	template=3,
	///<summary>
	///no description available
	///</summary>
	[Description("unknown")]
	unknown=4,
	///<summary>
	///no description available
	///</summary>
	[Description("withheld")]
	withheld=5
}

///<summary>
///Extension to the respective XML Schema built-in simple type to allow a choice of either a value of the built-in simple type or a reason for a nil value.
///</summary>
public struct booleanOrNilReason { 
 	public gml.NilReasonEnumeration _NilReasonEnumeration;
	public boolean _boolean;

}

///<summary>
///Extension to the respective XML Schema built-in simple type to allow a choice of either a value of the built-in simple type or a reason for a nil value.
///</summary>
public struct doubleOrNilReason { 
 	public gml.NilReasonEnumeration _NilReasonEnumeration;
	public double _double;

}

///<summary>
///Extension to the respective XML Schema built-in simple type to allow a choice of either a value of the built-in simple type or a reason for a nil value.
///</summary>
public struct integerOrNilReason { 
 	public gml.NilReasonEnumeration _NilReasonEnumeration;
	public integer _integer;

}

///<summary>
///Extension to the respective XML Schema built-in simple type to allow a choice of either a value of the built-in simple type or a reason for a nil value.
///</summary>
public struct NameOrNilReason { 
 	public gml.NilReasonEnumeration _NilReasonEnumeration;
	public Name _Name;

}

///<summary>
///Extension to the respective XML Schema built-in simple type to allow a choice of either a value of the built-in simple type or a reason for a nil value.
///</summary>
public struct stringOrNilReason { 
 	public gml.NilReasonEnumeration _NilReasonEnumeration;
	public string _string;

}

///<summary>
///The simple type gml:UomIdentifer defines the syntax and value space of the unit of measure identifier.
///</summary>
public struct UomIdentifier { 
 	public gml.UomSymbol _UomSymbol;
	public gml.UomURI _UomURI;

}

///<summary>
///This type specifies a character string of length at least one, and restricted such that it must not contain any of the following characters: ":" (colon), " " (space), (newline), (carriage return), (tab). This allows values corresponding to familiar abbreviations, such as "kg", "m/s", etc. It is recommended that the symbol be an identifier for a unit of measure as specified in the "Unified Code of Units of Measure" (UCUM) (http://aurora.regenstrief.org/UCUM). This provides a set of symbols and a grammar for constructing identifiers for units of measure that are unique, and may be easily entered with a keyboard supporting the limited character set known as 7-bit ASCII. ISO 2955 formerly provided a specification with this scope, but was withdrawn in 2001. UCUM largely follows ISO 2955 with modifications to remove ambiguities and other problems.
///</summary>

public struct UomSymbol {
		private string VALUE;
		public static implicit operator string( UomSymbol value ) {
		return value.VALUE;
	}
	
	public static implicit operator UomSymbol( string value ) {
		var _ReturnValue = new UomSymbol();
		_ReturnValue.VALUE = value;
		return _ReturnValue;
	}
}

///<summary>
///This type specifies a URI, restricted such that it must start with one of the following sequences: "#", "./", "../", or a string of characters followed by a ":". These patterns ensure that the most common URI forms are supported, including absolute and relative URIs and URIs that are simple fragment identifiers, but prohibits certain forms of relative URI that could be mistaken for unit of measure symbol . NOTE It is possible to re-write such a relative URI to conform to the restriction (e.g. "./m/s"). In an instance document, on elements of type gml:MeasureType the mandatory uom attribute shall carry a value corresponding to either - a conventional unit of measure symbol, - a link to a definition of a unit of measure that does not have a conventional symbol, or when it is desired to indicate a precise or variant definition.
///</summary>

public struct UomURI {
		private anyURI VALUE;
		public static implicit operator anyURI( UomURI value ) {
		return value.VALUE;
	}
	
	public static implicit operator UomURI( anyURI value ) {
		var _ReturnValue = new UomURI();
		_ReturnValue.VALUE = value;
		return _ReturnValue;
	}
}

///<summary>
///A type for a list of values of the respective simple type.
///</summary>

public struct doubleList {
		private double[] VALUE;
		public static implicit operator double[]( doubleList value ) {
		return value.VALUE;
	}
	
	public static implicit operator doubleList( double[] value ) {
		var _ReturnValue = new doubleList();
		_ReturnValue.VALUE = value;
		return _ReturnValue;
	}
}

///<summary>
///no description available
///</summary>
public abstract class AbstractGMLType { 

	public ID id;

	protected AbstractGMLType( ID id)
	{
		this.id=id;
	}

	protected AbstractGMLType(): base()
	{}

}

///<summary>
///no description available
///</summary>
public class AssociationRoleType { 

	public boolean owns;
	public NilReasonType nilReason;

	public AssociationRoleType( boolean owns, NilReasonType nilReason)
	{
		this.owns=owns;
		this.nilReason=nilReason;
	}

	protected AssociationRoleType(): base()
	{}

}

///<summary>
///gml:ReferenceType is intended to be used in application schemas directly, if a property element shall use a "by-reference only" encoding.
///</summary>
public class ReferenceType { 

	public boolean owns;
	public NilReasonType nilReason;

	public ReferenceType( boolean owns, NilReasonType nilReason)
	{
		this.owns=owns;
		this.nilReason=nilReason;
	}

	protected ReferenceType(): base()
	{}

}

///<summary>
///no description available
///</summary>
public class InlinePropertyType { 

	public boolean owns;

	public InlinePropertyType( boolean owns)
	{
		this.owns=owns;
	}

	protected InlinePropertyType(): base()
	{}

}

///<summary>
///To create a collection of GML Objects that are not all features, a property type shall be derived by extension from gml:AbstractMemberType. This abstract property type is intended to be used only in object types where software shall be able to identify that an instance of such an object type is to be interpreted as a collection of objects. By default, this abstract property type does not imply any ownership of the objects in the collection. The owns attribute of gml:OwnershipAttributeGroup may be used on a property element instance to assert ownership of an object in the collection. A collection shall not own an object already owned by another object.
///</summary>
public abstract class AbstractMemberType { 

	public boolean owns;

	protected AbstractMemberType( boolean owns)
	{
		this.owns=owns;
	}

	protected AbstractMemberType(): base()
	{}

}

///<summary>
///To associate metadata described by any XML Schema with a GML object, a property element shall be defined whose content model is derived by extension from gml:AbstractMetadataPropertyType. The value of such a property shall be metadata. The content model of such a property type, i.e. the metadata application schema shall be specified by the GML Application Schema. By default, this abstract property type does not imply any ownership of the metadata. The owns attribute of gml:OwnershipAttributeGroup may be used on a metadata property element instance to assert ownership of the metadata. If metadata following the conceptual model of ISO 19115 is to be encoded in a GML document, the corresponding Implementation Specification specified in ISO/TS 19139 shall be used to encode the metadata information.
///</summary>
public abstract class AbstractMetadataPropertyType { 

	public boolean owns;

	protected AbstractMetadataPropertyType( boolean owns)
	{
		this.owns=owns;
	}

	protected AbstractMetadataPropertyType(): base()
	{}

}

///<summary>
///The basic feature model is given by the gml:AbstractFeatureType. The content model for gml:AbstractFeatureType adds two specific properties suitable for geographic features to the content model defined in gml:AbstractGMLType. The value of the gml:boundedBy property describes an envelope that encloses the entire feature instance, and is primarily useful for supporting rapid searching for features that occur in a particular location. The value of the gml:location property describes the extent, position or relative location of the feature.
///</summary>
public abstract class AbstractFeatureType : AbstractGMLType { 


	protected AbstractFeatureType( ID id) : base( id)
	{
	}

	protected AbstractFeatureType(): base()
	{}

}

///<summary>
///no description available
///</summary>
public class FeaturePropertyType { 

	public boolean owns;
	public NilReasonType nilReason;

	public FeaturePropertyType( boolean owns, NilReasonType nilReason)
	{
		this.owns=owns;
		this.nilReason=nilReason;
	}

	protected FeaturePropertyType(): base()
	{}

}

///<summary>
///no description available
///</summary>
public class BoundingShapeType { 

	public NilReasonType nilReason;

	public BoundingShapeType( NilReasonType nilReason)
	{
		this.nilReason=nilReason;
	}

	protected BoundingShapeType(): base()
	{}

}

///<summary>
///To create a collection of GML features, a property type shall be derived by extension from gml:AbstractFeatureMemberType. By default, this abstract property type does not imply any ownership of the features in the collection. The owns attribute of gml:OwnershipAttributeGroup may be used on a property element instance to assert ownership of a feature in the collection. A collection shall not own a feature already owned by another object.
///</summary>
public abstract class AbstractFeatureMemberType { 

	public boolean owns;

	protected AbstractFeatureMemberType( boolean owns)
	{
		this.owns=owns;
	}

	protected AbstractFeatureMemberType(): base()
	{}

}

///<summary>
///no description available
///</summary>
public class EnvelopeType { 

	public anyURI srsName;
	public positiveInteger srsDimension;
	public DirectPositionType lowerCorner;
	public DirectPositionType upperCorner;

	public EnvelopeType( anyURI srsName, positiveInteger srsDimension, DirectPositionType lowerCorner, DirectPositionType upperCorner)
	{
		this.srsName=srsName;
		this.srsDimension=srsDimension;
		this.lowerCorner=lowerCorner;
		this.upperCorner=upperCorner;
	}

	protected EnvelopeType(): base()
	{}

}

///<summary>
///All geometry elements are derived directly or indirectly from this abstract supertype. A geometry element may have an identifying attribute (gml:id), one or more names (elements identifier and name) and a description (elements description and descriptionReference) . It may be associated with a spatial reference system (attribute group gml:SRSReferenceGroup). The following rules shall be adhered to: - Every geometry type shall derive from this abstract type. - Every geometry element (i.e. an element of a geometry type) shall be directly or indirectly in the substitution group of AbstractGeometry.
///</summary>
public abstract class AbstractGeometryType : AbstractGMLType { 

	public anyURI srsName;
	public positiveInteger srsDimension;

	protected AbstractGeometryType( anyURI srsName, positiveInteger srsDimension, ID id) : base( id)
	{
		this.srsName=srsName;
		this.srsDimension=srsDimension;
	}

	protected AbstractGeometryType(): base()
	{}

}

///<summary>
///Direct position instances hold the coordinates for a position within some coordinate reference system (CRS). Since direct positions, as data types, will often be included in larger objects (such as geometry elements) that have references to CRS, the srsName attribute will in general be missing, if this particular direct position is included in a larger element with such a reference to a CRS. In this case, the CRS is implicitly assumed to take on the value of the containing object's CRS. if no srsName attribute is given, the CRS shall be specified as part of the larger context this geometry element is part of, typically a geometric object like a point, curve, etc.
///</summary>
public class DirectPositionType { 

	public anyURI srsName;
	public positiveInteger srsDimension;

	public DirectPositionType( anyURI srsName, positiveInteger srsDimension)
	{
		this.srsName=srsName;
		this.srsDimension=srsDimension;
	}

	protected DirectPositionType(): base()
	{}

}

///<summary>
///posList instances (and other instances with the content model specified by DirectPositionListType) hold the coordinates for a sequence of direct positions within the same coordinate reference system (CRS). if no srsName attribute is given, the CRS shall be specified as part of the larger context this geometry element is part of, typically a geometric object like a point, curve, etc. The optional attribute count specifies the number of direct positions in the list. If the attribute count is present then the attribute srsDimension shall be present, too. The number of entries in the list is equal to the product of the dimensionality of the coordinate reference system (i.e. it is a derived value of the coordinate reference system definition) and the number of direct positions.
///</summary>
public class DirectPositionListType { 

	public positiveInteger count;
	public anyURI srsName;
	public positiveInteger srsDimension;

	public DirectPositionListType( positiveInteger count, anyURI srsName, positiveInteger srsDimension)
	{
		this.count=count;
		this.srsName=srsName;
		this.srsDimension=srsDimension;
	}

	protected DirectPositionListType(): base()
	{}

}

///<summary>
///gml:AbstractGeometricPrimitiveType is the abstract root type of the geometric primitives. A geometric primitive is a geometric object that is not decomposed further into other primitives in the system. All primitives are oriented in the direction implied by the sequence of their coordinate tuples.
///</summary>
public abstract class AbstractGeometricPrimitiveType : AbstractGeometryType { 


	protected AbstractGeometricPrimitiveType( anyURI srsName, positiveInteger srsDimension, ID id) : base( srsName, srsDimension, id)
	{
	}

	protected AbstractGeometricPrimitiveType(): base()
	{}

}

///<summary>
///A property that has a geometric primitive as its value domain may either be an appropriate geometry element encapsulated in an element of this type or an XLink reference to a remote geometry element (where remote includes geometry elements located elsewhere in the same document). Either the reference or the contained element shall be given, but neither both nor none.
///</summary>
public class GeometricPrimitivePropertyType { 

	public boolean owns;
	public NilReasonType nilReason;

	public GeometricPrimitivePropertyType( boolean owns, NilReasonType nilReason)
	{
		this.owns=owns;
		this.nilReason=nilReason;
	}

	protected GeometricPrimitivePropertyType(): base()
	{}

}

///<summary>
///S-100 XML supports two different ways to specify the direct positon of a point. 1. The "pos" element is of type DirectPositionType.
///</summary>
public class PointType : AbstractGeometricPrimitiveType { 


	public PointType( anyURI srsName, positiveInteger srsDimension, ID id) : base( srsName, srsDimension, id)
	{
	}

	protected PointType(): base()
	{}

}

///<summary>
///A property that has a point as its value domain may either be an appropriate geometry element encapsulated in an element of this type or an XLink reference to a remote geometry element (where remote includes geometry elements located elsewhere in the same document). Either the reference or the contained element shall be given, but neither both nor none.
///</summary>
public class PointPropertyType { 

	public NilReasonType nilReason;
	public boolean owns;

	public PointPropertyType( NilReasonType nilReason, boolean owns)
	{
		this.nilReason=nilReason;
		this.owns=owns;
	}

	protected PointPropertyType(): base()
	{}

}

///<summary>
///gml:AbstractCurveType is an abstraction of a curve to support the different levels of complexity. The curve may always be viewed as a geometric primitive, i.e. is continuous.
///</summary>
public abstract class AbstractCurveType : AbstractGeometricPrimitiveType { 


	protected AbstractCurveType( anyURI srsName, positiveInteger srsDimension, ID id) : base( srsName, srsDimension, id)
	{
	}

	protected AbstractCurveType(): base()
	{}

}

///<summary>
///A property that has a curve as its value domain may either be an appropriate geometry element encapsulated in an element of this type or an XLink reference to a remote geometry element (where remote includes geometry elements located elsewhere in the same document). Either the reference or the contained element shall be given, but neither both nor none.
///</summary>
public class CurvePropertyType { 

	public NilReasonType nilReason;
	public boolean owns;

	public CurvePropertyType( NilReasonType nilReason, boolean owns)
	{
		this.nilReason=nilReason;
		this.owns=owns;
	}

	protected CurvePropertyType(): base()
	{}

}

///<summary>
///no description available
///</summary>
public class LineStringType : AbstractCurveType { 


	public LineStringType( anyURI srsName, positiveInteger srsDimension, ID id) : base( srsName, srsDimension, id)
	{
	}

	protected LineStringType(): base()
	{}

}

///<summary>
///gml:AbstractSurfaceType is an abstraction of a surface to support the different levels of complexity. A surface is always a continuous region of a plane.
///</summary>
public abstract class AbstractSurfaceType : AbstractGeometricPrimitiveType { 


	protected AbstractSurfaceType( anyURI srsName, positiveInteger srsDimension, ID id) : base( srsName, srsDimension, id)
	{
	}

	protected AbstractSurfaceType(): base()
	{}

}

///<summary>
///A property that has a surface as its value domain may either be an appropriate geometry element encapsulated in an element of this type or an XLink reference to a remote geometry element (where remote includes geometry elements located elsewhere in the same document). Either the reference or the contained element shall be given, but neither both nor none.
///</summary>
public class SurfacePropertyType { 

	public NilReasonType nilReason;
	public boolean owns;

	public SurfacePropertyType( NilReasonType nilReason, boolean owns)
	{
		this.nilReason=nilReason;
		this.owns=owns;
	}

	protected SurfacePropertyType(): base()
	{}

}

///<summary>
///no description available
///</summary>
public class PolygonType : AbstractSurfaceType { 


	public PolygonType( anyURI srsName, positiveInteger srsDimension, ID id) : base( srsName, srsDimension, id)
	{
	}

	protected PolygonType(): base()
	{}

}

///<summary>
///no description available
///</summary>
public abstract class AbstractRingType { 


	protected AbstractRingType()
	{
	}

}

///<summary>
///A property with the content model of gml:AbstractRingPropertyType encapsulates a ring to represent the surface boundary property of a surface.
///</summary>
public class AbstractRingPropertyType { 


	public AbstractRingPropertyType()
	{
	}

}

///<summary>
///S-100 XML supports two different ways to specify the control points of a linear ring. 1. A sequence of "pos" (DirectPositionType) or "pointProperty" (PointPropertyType) elements. "pos" elements are control points that are only part of this ring, "pointProperty" elements contain a point that may be referenced from other geometry elements or reference another point defined outside of this ring (reuse of existing points). 2. The "posList" element allows for a compact way to specifiy the coordinates of the control points, if all control points are in the same coordinate reference systems and belong to this ring only. The number of direct positions in the list must be at least four.
///</summary>
public class LinearRingType : AbstractRingType { 


	public LinearRingType() : base()
	{
	}

}

///<summary>
///A property with the content model of gml:LinearRingPropertyType encapsulates a linear ring to represent a component of a surface boundary.
///</summary>
public class LinearRingPropertyType { 


	public LinearRingPropertyType()
	{
	}

}

///<summary>
///no description available
///</summary>
public class CurveType : AbstractCurveType { 


	public CurveType( anyURI srsName, positiveInteger srsDimension, ID id) : base( srsName, srsDimension, id)
	{
	}

	protected CurveType(): base()
	{}

}

///<summary>
///no description available
///</summary>
public class OrientableCurveType : AbstractCurveType { 

	public SignType orientation;

	public OrientableCurveType( SignType orientation, anyURI srsName, positiveInteger srsDimension, ID id) : base( srsName, srsDimension, id)
	{
		this.orientation=orientation;
	}

	protected OrientableCurveType(): base()
	{}

}

///<summary>
///no description available
///</summary>
public abstract class AbstractCurveSegmentType { 

	public integer numDerivativesAtStart;
	public integer numDerivativesAtEnd;
	public integer numDerivativeInterior;

	protected AbstractCurveSegmentType( integer numDerivativesAtStart, integer numDerivativesAtEnd, integer numDerivativeInterior)
	{
		this.numDerivativesAtStart=numDerivativesAtStart;
		this.numDerivativesAtEnd=numDerivativesAtEnd;
		this.numDerivativeInterior=numDerivativeInterior;
	}

	protected AbstractCurveSegmentType(): base()
	{}

}

///<summary>
///gml:CurveSegmentArrayPropertyType is a container for an array of curve segments.
///</summary>
public class CurveSegmentArrayPropertyType { 


	public CurveSegmentArrayPropertyType()
	{
	}

}

///<summary>
///GML supports two different ways to specify the control points of a line string. 1. A sequence of "pos" (DirectPositionType) or "pointProperty" (PointPropertyType) elements. "pos" elements are control points that are only part of this curve, "pointProperty" elements contain a point that may be referenced from other geometry elements or reference another point defined outside of this curve (reuse of existing points). 2. The "posList" element allows for a compact way to specifiy the coordinates of the control points, if all control points are in the same coordinate reference systems and belong to this curve only. The number of direct positions in the list must be at least two.
///</summary>
public class LineStringSegmentType : AbstractCurveSegmentType { 

	public CurveInterpolationType interpolation;

	public LineStringSegmentType( CurveInterpolationType interpolation, integer numDerivativesAtStart, integer numDerivativesAtEnd, integer numDerivativeInterior) : base( numDerivativesAtStart, numDerivativesAtEnd, numDerivativeInterior)
	{
		this.interpolation=interpolation;
	}

	protected LineStringSegmentType(): base()
	{}

}

///<summary>
///no description available
///</summary>
public class GeodesicStringType : AbstractCurveSegmentType { 

	public CurveInterpolationType interpolation;

	public GeodesicStringType( CurveInterpolationType interpolation, integer numDerivativesAtStart, integer numDerivativesAtEnd, integer numDerivativeInterior) : base( numDerivativesAtStart, numDerivativesAtEnd, numDerivativeInterior)
	{
		this.interpolation=interpolation;
	}

	protected GeodesicStringType(): base()
	{}

}

///<summary>
///no description available
///</summary>
public class GeodesicType : GeodesicStringType { 


	public GeodesicType( CurveInterpolationType interpolation, integer numDerivativesAtStart, integer numDerivativesAtEnd, integer numDerivativeInterior) : base( interpolation, numDerivativesAtStart, numDerivativesAtEnd, numDerivativeInterior)
	{
	}

	protected GeodesicType(): base()
	{}

}

///<summary>
///no description available
///</summary>
public class SurfaceType : AbstractSurfaceType { 


	public SurfaceType( anyURI srsName, positiveInteger srsDimension, ID id) : base( srsName, srsDimension, id)
	{
	}

	protected SurfaceType(): base()
	{}

}

///<summary>
///gml:SurfacePatchArrayPropertyType is a container for a sequence of surface patches.
///</summary>
public class SurfacePatchArrayPropertyType { 


	public SurfacePatchArrayPropertyType()
	{
	}

}

///<summary>
///no description available
///</summary>
public abstract class AbstractSurfacePatchType { 


	protected AbstractSurfacePatchType()
	{
	}

}

///<summary>
///no description available
///</summary>
public class PolygonPatchType : AbstractSurfacePatchType { 

	public SurfaceInterpolationType interpolation;

	public PolygonPatchType( SurfaceInterpolationType interpolation) : base()
	{
		this.interpolation=interpolation;
	}

	protected PolygonPatchType(): base()
	{}

}

///<summary>
///no description available
///</summary>
public class RingType : AbstractRingType { 

	public AggregationType aggregationType;

	public RingType( AggregationType aggregationType) : base()
	{
		this.aggregationType=aggregationType;
	}

	protected RingType(): base()
	{}

}

///<summary>
///no description available
///</summary>
public class CompositeCurveType : AbstractCurveType { 

	public AggregationType aggregationType;

	public CompositeCurveType( AggregationType aggregationType, anyURI srsName, positiveInteger srsDimension, ID id) : base( srsName, srsDimension, id)
	{
		this.aggregationType=aggregationType;
	}

	protected CompositeCurveType(): base()
	{}

}

///<summary>
///no description available
///</summary>
public abstract class AbstractGeometricAggregateType : AbstractGeometryType { 

	public AggregationType aggregationType;

	protected AbstractGeometricAggregateType( AggregationType aggregationType, anyURI srsName, positiveInteger srsDimension, ID id) : base( srsName, srsDimension, id)
	{
		this.aggregationType=aggregationType;
	}

	protected AbstractGeometricAggregateType(): base()
	{}

}

///<summary>
///no description available
///</summary>
public class MultiPointType : AbstractGeometricAggregateType { 


	public MultiPointType( AggregationType aggregationType, anyURI srsName, positiveInteger srsDimension, ID id) : base( aggregationType, srsName, srsDimension, id)
	{
	}

	protected MultiPointType(): base()
	{}

}

///<summary>
///gml:CodeType is a generalized type to be used for a term, keyword or name. It adds a XML attribute codeSpace to a term, where the value of the codeSpace attribute (if present) shall indicate a dictionary, thesaurus, classification scheme, authority, or pattern for the term.
///</summary>
public class CodeType { 

	public anyURI codeSpace;

	public CodeType( anyURI codeSpace)
	{
		this.codeSpace=codeSpace;
	}

	protected CodeType(): base()
	{}

}

///<summary>
///gml:CodeWithAuthorityType requires that the codeSpace attribute is provided in an instance.
///</summary>
public class CodeWithAuthorityType { 

	public anyURI codeSpace;

	public CodeWithAuthorityType( anyURI codeSpace)
	{
		this.codeSpace=codeSpace;
	}

	protected CodeWithAuthorityType(): base()
	{}

}

///<summary>
///gml:MeasureType supports recording an amount encoded as a value of XML Schema double, together with a units of measure indicated by an attribute uom, short for "units Of measure". The value of the uom attribute identifies a reference system for the amount, usually a ratio or interval scale.
///</summary>
public class MeasureType { 

	public UomIdentifier uom;

	public MeasureType( UomIdentifier uom)
	{
		this.uom=uom;
	}

	protected MeasureType(): base()
	{}

}

///<summary>
///This is a prototypical definition for a specific measure type defined as a vacuous extension (i.e. aliases) of gml:MeasureType. In this case, the content model supports the description of a length (or distance) quantity, with its units. The unit of measure referenced by uom shall be suitable for a length, such as metres or feet.
///</summary>
public class LengthType { 


	public LengthType()
	{
	}

}

///<summary>
///no description available
///</summary>
public class AngleType { 


	public AngleType()
	{
	}

}

///<summary>
///no description available
///</summary>
public class VolumeType { 


	public VolumeType()
	{
	}

}

///<summary>
//////<summary> ///(Type)no description available(Element)The abstract element gml:AbstractGML is "any GML object having identity". It acts as the head of an XML Schema substitution group, which may include any element which is a GML feature, or other object, with identity. This is used as a variable in content models in GML core and application schemas. It is effectively an abstract superclass for all GML objects. ///</summary>
///</summary>
public abstract class AbstractGML : AbstractGMLType { 


	protected AbstractGML( ID id) : base( id)
	{
	}

	protected AbstractGML(): base()
	{}

}

///<summary>
//////<summary> ///(Type)no description available(Element)Applying this pattern shall restrict the multiplicity of objects in a property element using this content model to exactly one. An instance of this type shall contain an element representing an object, or serve as a pointer to a remote object. Applying the pattern to define an application schema specific property type allows to restrict - the inline object to specified object types, - the encoding to "by-reference only" (see 7.2.3.7), - the encoding to "inline only" (see 7.2.3.8). ///</summary>
///</summary>
public abstract class abstractAssociationRole : AssociationRoleType { 


	protected abstractAssociationRole( boolean owns, NilReasonType nilReason) : base( owns, nilReason)
	{
	}

	protected abstractAssociationRole(): base()
	{}

}

///<summary>
//////<summary> ///(Type)gml:ReferenceType is intended to be used in application schemas directly, if a property element shall use a "by-reference only" encoding.(Element)gml:abstractReference may be used as the head of a subtitution group of more specific elements providing a value by-reference. ///</summary>
///</summary>
public abstract class abstractReference : ReferenceType { 


	protected abstractReference( boolean owns, NilReasonType nilReason) : base( owns, nilReason)
	{
	}

	protected abstractReference(): base()
	{}

}

///<summary>
//////<summary> ///(Type)no description available(Element)gml:abstractInlineProperty may be used as the head of a subtitution group of more specific elements providing a value inline. ///</summary>
///</summary>
public abstract class abstractInlineProperty : InlinePropertyType { 


	protected abstractInlineProperty( boolean owns) : base( owns)
	{
	}

	protected abstractInlineProperty(): base()
	{}

}
//reversePropertyName refers same name
//targetElement refers same name
//associationName refers same name
//defaultCodeSpace refers same name
//gmlProfileSchema refers same name

///<summary>
//////<summary> ///(Type)The basic feature model is given by the gml:AbstractFeatureType. The content model for gml:AbstractFeatureType adds two specific properties suitable for geographic features to the content model defined in gml:AbstractGMLType. The value of the gml:boundedBy property describes an envelope that encloses the entire feature instance, and is primarily useful for supporting rapid searching for features that occur in a particular location. The value of the gml:location property describes the extent, position or relative location of the feature.(Element)This abstract element serves as the head of a substitution group which may contain any elements whose content model is derived from gml:AbstractFeatureType. This may be used as a variable in the construction of content models. gml:AbstractFeature may be thought of as "anything that is a GML feature" and may be used to define variables or templates in which the value of a GML property is "any feature". This occurs in particular in a GML feature collection where the feature member properties contain one or multiple copies of gml:AbstractFeature respectively. ///</summary>
///</summary>
public abstract class AbstractFeature : AbstractFeatureType { 


	protected AbstractFeature( ID id) : base( id)
	{
	}

	protected AbstractFeature(): base()
	{}

}

///<summary>
//////<summary> ///(Type)no description available(Element)This property describes the minimum bounding box or rectangle that encloses the entire feature. ///</summary>
///</summary>
public class boundedBy : BoundingShapeType { 


	public boundedBy( NilReasonType nilReason) : base( nilReason)
	{
	}

	protected boundedBy(): base()
	{}

}

///<summary>
//////<summary> ///(Type)no description available(Element)Envelope defines an extent using a pair of positions defining opposite corners in arbitrary dimensions. The first direct position is the "lower corner" (a coordinate position consisting of all the minimal ordinates for each dimension for all points within the envelope), the second one the "upper corner" (a coordinate position consisting of all the maximal ordinates for each dimension for all points within the envelope). The use of the properties "coordinates" and "pos" has been deprecated. The explicitly named properties "lowerCorner" and "upperCorner" shall be used instead. ///</summary>
///</summary>
public class Envelope : EnvelopeType { 


	public Envelope( anyURI srsName, positiveInteger srsDimension, DirectPositionType lowerCorner, DirectPositionType upperCorner) : base( srsName, srsDimension, lowerCorner, upperCorner)
	{
	}

	protected Envelope(): base()
	{}

}

///<summary>
//////<summary> ///(Type)All geometry elements are derived directly or indirectly from this abstract supertype. A geometry element may have an identifying attribute (gml:id), one or more names (elements identifier and name) and a description (elements description and descriptionReference) . It may be associated with a spatial reference system (attribute group gml:SRSReferenceGroup). The following rules shall be adhered to: - Every geometry type shall derive from this abstract type. - Every geometry element (i.e. an element of a geometry type) shall be directly or indirectly in the substitution group of AbstractGeometry.(Element)The AbstractGeometry element is the abstract head of the substitution group for all geometry elements of GML. This includes pre-defined and user-defined geometry elements. Any geometry element shall be a direct or indirect extension/restriction of AbstractGeometryType and shall be directly or indirectly in the substitution group of AbstractGeometry. ///</summary>
///</summary>
public abstract class AbstractGeometry : AbstractGeometryType { 


	protected AbstractGeometry( anyURI srsName, positiveInteger srsDimension, ID id) : base( srsName, srsDimension, id)
	{
	}

	protected AbstractGeometry(): base()
	{}

}

///<summary>
//////<summary> ///(Type)Direct position instances hold the coordinates for a position within some coordinate reference system (CRS). Since direct positions, as data types, will often be included in larger objects (such as geometry elements) that have references to CRS, the srsName attribute will in general be missing, if this particular direct position is included in a larger element with such a reference to a CRS. In this case, the CRS is implicitly assumed to take on the value of the containing object's CRS. if no srsName attribute is given, the CRS shall be specified as part of the larger context this geometry element is part of, typically a geometric object like a point, curve, etc.(Element) ///</summary>
///</summary>
public class pos : DirectPositionType { 


	public pos( anyURI srsName, positiveInteger srsDimension) : base( srsName, srsDimension)
	{
	}

	protected pos(): base()
	{}

}

///<summary>
//////<summary> ///(Type)posList instances (and other instances with the content model specified by DirectPositionListType) hold the coordinates for a sequence of direct positions within the same coordinate reference system (CRS). if no srsName attribute is given, the CRS shall be specified as part of the larger context this geometry element is part of, typically a geometric object like a point, curve, etc. The optional attribute count specifies the number of direct positions in the list. If the attribute count is present then the attribute srsDimension shall be present, too. The number of entries in the list is equal to the product of the dimensionality of the coordinate reference system (i.e. it is a derived value of the coordinate reference system definition) and the number of direct positions.(Element) ///</summary>
///</summary>
public class posList : DirectPositionListType { 


	public posList( positiveInteger count, anyURI srsName, positiveInteger srsDimension) : base( count, srsName, srsDimension)
	{
	}

	protected posList(): base()
	{}

}

///<summary>
//////<summary> ///(Type)gml:AbstractGeometricPrimitiveType is the abstract root type of the geometric primitives. A geometric primitive is a geometric object that is not decomposed further into other primitives in the system. All primitives are oriented in the direction implied by the sequence of their coordinate tuples.(Element)The AbstractGeometricPrimitive element is the abstract head of the substitution group for all (pre- and user-defined) geometric primitives. ///</summary>
///</summary>
public abstract class AbstractGeometricPrimitive : AbstractGeometricPrimitiveType { 


	protected AbstractGeometricPrimitive( anyURI srsName, positiveInteger srsDimension, ID id) : base( srsName, srsDimension, id)
	{
	}

	protected AbstractGeometricPrimitive(): base()
	{}

}

///<summary>
//////<summary> ///(Type)S-100 XML supports two different ways to specify the direct positon of a point. 1. The "pos" element is of type DirectPositionType.(Element)A Point is defined by a single coordinate tuple. The direct position of a point is specified by the pos element which is of type DirectPositionType. ///</summary>
///</summary>
public class Point : PointType { 


	public Point( anyURI srsName, positiveInteger srsDimension, ID id) : base( srsName, srsDimension, id)
	{
	}

	protected Point(): base()
	{}

}

///<summary>
//////<summary> ///(Type)A property that has a point as its value domain may either be an appropriate geometry element encapsulated in an element of this type or an XLink reference to a remote geometry element (where remote includes geometry elements located elsewhere in the same document). Either the reference or the contained element shall be given, but neither both nor none.(Element)This property element either references a point via the XLink-attributes or contains the point element. pointProperty is the predefined property which may be used by GML Application Schemas whenever a GML feature has a property with a value that is substitutable for Point. ///</summary>
///</summary>
public class pointProperty : PointPropertyType { 


	public pointProperty( NilReasonType nilReason, boolean owns) : base( nilReason, owns)
	{
	}

	protected pointProperty(): base()
	{}

}

///<summary>
//////<summary> ///(Type)gml:AbstractCurveType is an abstraction of a curve to support the different levels of complexity. The curve may always be viewed as a geometric primitive, i.e. is continuous.(Element)The AbstractCurve element is the abstract head of the substitution group for all (continuous) curve elements. ///</summary>
///</summary>
public abstract class AbstractCurve : AbstractCurveType { 


	protected AbstractCurve( anyURI srsName, positiveInteger srsDimension, ID id) : base( srsName, srsDimension, id)
	{
	}

	protected AbstractCurve(): base()
	{}

}

///<summary>
//////<summary> ///(Type)no description available(Element)A LineString is a special curve that consists of a single segment with linear interpolation. It is defined by two or more coordinate tuples, with linear interpolation between them. The number of direct positions in the list shall be at least two. ///</summary>
///</summary>
public class LineString : LineStringType { 


	public LineString( anyURI srsName, positiveInteger srsDimension, ID id) : base( srsName, srsDimension, id)
	{
	}

	protected LineString(): base()
	{}

}

///<summary>
//////<summary> ///(Type)gml:AbstractSurfaceType is an abstraction of a surface to support the different levels of complexity. A surface is always a continuous region of a plane.(Element)The AbstractSurface element is the abstract head of the substitution group for all (continuous) surface elements. ///</summary>
///</summary>
public abstract class AbstractSurface : AbstractSurfaceType { 


	protected AbstractSurface( anyURI srsName, positiveInteger srsDimension, ID id) : base( srsName, srsDimension, id)
	{
	}

	protected AbstractSurface(): base()
	{}

}

///<summary>
//////<summary> ///(Type)no description available(Element)A Polygon is a special surface that is defined by a single surface patch (see D.3.6). The boundary of this patch is coplanar and the polygon uses planar interpolation in its interior. The elements exterior and interior describe the surface boundary of the polygon. ///</summary>
///</summary>
public class Polygon : PolygonType { 


	public Polygon( anyURI srsName, positiveInteger srsDimension, ID id) : base( srsName, srsDimension, id)
	{
	}

	protected Polygon(): base()
	{}

}

///<summary>
//////<summary> ///(Type)A property with the content model of gml:AbstractRingPropertyType encapsulates a ring to represent the surface boundary property of a surface.(Element)A boundary of a surface consists of a number of rings. In the normal 2D case, one of these rings is distinguished as being the exterior boundary. In a general manifold this is not always possible, in which case all boundaries shall be listed as interior boundaries, and the exterior will be empty. ///</summary>
///</summary>
public class exterior : AbstractRingPropertyType { 


	public exterior() : base()
	{
	}

}

///<summary>
//////<summary> ///(Type)A property with the content model of gml:AbstractRingPropertyType encapsulates a ring to represent the surface boundary property of a surface.(Element)A boundary of a surface consists of a number of rings. The "interior" rings separate the surface / surface patch from the area enclosed by the rings. ///</summary>
///</summary>
public class interior : AbstractRingPropertyType { 


	public interior() : base()
	{
	}

}

///<summary>
//////<summary> ///(Type)no description available(Element)An abstraction of a ring to support surface boundaries of different complexity. The AbstractRing element is the abstract head of the substituition group for all closed boundaries of a surface patch. ///</summary>
///</summary>
public abstract class AbstractRing : AbstractRingType { 


	protected AbstractRing() : base()
	{
	}

}

///<summary>
//////<summary> ///(Type)S-100 XML supports two different ways to specify the control points of a linear ring. 1. A sequence of "pos" (DirectPositionType) or "pointProperty" (PointPropertyType) elements. "pos" elements are control points that are only part of this ring, "pointProperty" elements contain a point that may be referenced from other geometry elements or reference another point defined outside of this ring (reuse of existing points). 2. The "posList" element allows for a compact way to specifiy the coordinates of the control points, if all control points are in the same coordinate reference systems and belong to this ring only. The number of direct positions in the list must be at least four.(Element)A LinearRing is defined by four or more coordinate tuples, with linear interpolation between them; the first and last coordinates shall be coincident. The number of direct positions in the list shall be at least four. ///</summary>
///</summary>
public class LinearRing : LinearRingType { 


	public LinearRing() : base()
	{
	}

}

///<summary>
//////<summary> ///(Type)no description available(Element)A curve is a 1-dimensional primitive. Curves are continuous, connected, and have a measurable length in terms of the coordinate system. A curve is composed of one or more curve segments. Each curve segment within a curve may be defined using a different interpolation method. The curve segments are connected to one another, with the end point of each segment except the last being the start point of the next segment in the segment list. The orientation of the curve is positive. The element segments encapsulates the segments of the curve. ///</summary>
///</summary>
public class Curve : CurveType { 


	public Curve( anyURI srsName, positiveInteger srsDimension, ID id) : base( srsName, srsDimension, id)
	{
	}

	protected Curve(): base()
	{}

}

///<summary>
//////<summary> ///(Type)A property that has a curve as its value domain may either be an appropriate geometry element encapsulated in an element of this type or an XLink reference to a remote geometry element (where remote includes geometry elements located elsewhere in the same document). Either the reference or the contained element shall be given, but neither both nor none.(Element)The property baseCurve references or contains the base curve, i.e. it either references the base curve via the XLink-attributes or contains the curve element. A curve element is any element which is substitutable for AbstractCurve. The base curve has positive orientation. ///</summary>
///</summary>
public class baseCurve : CurvePropertyType { 


	public baseCurve( NilReasonType nilReason, boolean owns) : base( nilReason, owns)
	{
	}

	protected baseCurve(): base()
	{}

}

///<summary>
//////<summary> ///(Type)no description available(Element)OrientableCurve consists of a curve and an orientation. If the orientation is "+", then the OrientableCurve is identical to the baseCurve. If the orientation is "-", then the OrientableCurve is related to another AbstractCurve with a parameterization that reverses the sense of the curve traversal. ///</summary>
///</summary>
public class OrientableCurve : OrientableCurveType { 


	public OrientableCurve( SignType orientation, anyURI srsName, positiveInteger srsDimension, ID id) : base( orientation, srsName, srsDimension, id)
	{
	}

	protected OrientableCurve(): base()
	{}

}

///<summary>
//////<summary> ///(Type)gml:CurveSegmentArrayPropertyType is a container for an array of curve segments.(Element)This property element contains a list of curve segments. The order of the elements is significant and shall be preserved when processing the array. ///</summary>
///</summary>
public class segments : CurveSegmentArrayPropertyType { 


	public segments() : base()
	{
	}

}

///<summary>
//////<summary> ///(Type)no description available(Element)A curve segment defines a homogeneous segment of a curve. The attributes numDerivativesAtStart, numDerivativesAtEnd and numDerivativesInterior specify the type of continuity as specified in ISO 19107:2003, 6.4.9.3. The AbstractCurveSegment element is the abstract head of the substituition group for all curve segment elements, i.e. continuous segments of the same interpolation mechanism. All curve segments shall have an attribute interpolation with type gml:CurveInterpolationType specifying the curve interpolation mechanism used for this segment. This mechanism uses the control points and control parameters to determine the position of this curve segment. ///</summary>
///</summary>
public abstract class AbstractCurveSegment : AbstractCurveSegmentType { 


	protected AbstractCurveSegment( integer numDerivativesAtStart, integer numDerivativesAtEnd, integer numDerivativeInterior) : base( numDerivativesAtStart, numDerivativesAtEnd, numDerivativeInterior)
	{
	}

	protected AbstractCurveSegment(): base()
	{}

}

///<summary>
//////<summary> ///(Type)GML supports two different ways to specify the control points of a line string. 1. A sequence of "pos" (DirectPositionType) or "pointProperty" (PointPropertyType) elements. "pos" elements are control points that are only part of this curve, "pointProperty" elements contain a point that may be referenced from other geometry elements or reference another point defined outside of this curve (reuse of existing points). 2. The "posList" element allows for a compact way to specifiy the coordinates of the control points, if all control points are in the same coordinate reference systems and belong to this curve only. The number of direct positions in the list must be at least two.(Element)A LineStringSegment is a curve segment that is defined by two or more control points including the start and end point, with linear interpolation between them. The content model follows the general pattern for the encoding of curve segments. ///</summary>
///</summary>
public class LineStringSegment : LineStringSegmentType { 


	public LineStringSegment( CurveInterpolationType interpolation, integer numDerivativesAtStart, integer numDerivativesAtEnd, integer numDerivativeInterior) : base( interpolation, numDerivativesAtStart, numDerivativesAtEnd, numDerivativeInterior)
	{
	}

	protected LineStringSegment(): base()
	{}

}

///<summary>
//////<summary> ///(Type)no description available(Element)A sequence of geodesic segments. The number of control points shall be at least two. interpolation is fixed as "geodesic". The content model follows the general pattern for the encoding of curve segments. ///</summary>
///</summary>
public class GeodesicString : GeodesicStringType { 


	public GeodesicString( CurveInterpolationType interpolation, integer numDerivativesAtStart, integer numDerivativesAtEnd, integer numDerivativeInterior) : base( interpolation, numDerivativesAtStart, numDerivativesAtEnd, numDerivativeInterior)
	{
	}

	protected GeodesicString(): base()
	{}

}

///<summary>
//////<summary> ///(Type)no description available(Element) ///</summary>
///</summary>
public class Geodesic : GeodesicType { 


	public Geodesic( CurveInterpolationType interpolation, integer numDerivativesAtStart, integer numDerivativesAtEnd, integer numDerivativeInterior) : base( interpolation, numDerivativesAtStart, numDerivativesAtEnd, numDerivativeInterior)
	{
	}

	protected Geodesic(): base()
	{}

}

///<summary>
//////<summary> ///(Type)no description available(Element)A Surface is a 2-dimensional primitive and is composed of one or more surface patches as specified in ISO 19107:2003, 6.3.17.1. The surface patches are connected to one another. patches encapsulates the patches of the surface. ///</summary>
///</summary>
public class Surface : SurfaceType { 


	public Surface( anyURI srsName, positiveInteger srsDimension, ID id) : base( srsName, srsDimension, id)
	{
	}

	protected Surface(): base()
	{}

}

///<summary>
//////<summary> ///(Type)gml:SurfacePatchArrayPropertyType is a container for a sequence of surface patches.(Element)The patches property element contains the sequence of surface patches. The order of the elements is significant and shall be preserved when processing the array. ///</summary>
///</summary>
public class patches : SurfacePatchArrayPropertyType { 


	public patches() : base()
	{
	}

}

///<summary>
//////<summary> ///(Type)no description available(Element)A surface patch defines a homogenuous portion of a surface. The AbstractSurfacePatch element is the abstract head of the substituition group for all surface patch elements describing a continuous portion of a surface. All surface patches shall have an attribute interpolation (declared in the types derived from gml:AbstractSurfacePatchType) specifying the interpolation mechanism used for the patch using gml:SurfaceInterpolationType. ///</summary>
///</summary>
public abstract class AbstractSurfacePatch : AbstractSurfacePatchType { 


	protected AbstractSurfacePatch() : base()
	{
	}

}

///<summary>
//////<summary> ///(Type)no description available(Element)A gml:PolygonPatch is a surface patch that is defined by a set of boundary curves and an underlying surface to which these curves adhere. The curves shall be coplanar and the polygon uses planar interpolation in its interior. interpolation is fixed to "planar", i.e. an interpolation shall return points on a single plane. The boundary of the patch shall be contained within that plane. ///</summary>
///</summary>
public class PolygonPatch : PolygonPatchType { 


	public PolygonPatch( SurfaceInterpolationType interpolation) : base( interpolation)
	{
	}

	protected PolygonPatch(): base()
	{}

}

///<summary>
//////<summary> ///(Type)no description available(Element)A ring is used to represent a single connected component of a surface boundary as specified in ISO 19107:2003, 6.3.6. Every gml:curveMember references or contains one curve, i.e. any element which is substitutable for gml:AbstractCurve. In the context of a ring, the curves describe the boundary of the surface. The sequence of curves shall be contiguous and connected in a cycle. If provided, the aggregationType attribute shall have the value "sequence". ///</summary>
///</summary>
public class Ring : RingType { 


	public Ring( AggregationType aggregationType) : base( aggregationType)
	{
	}

	protected Ring(): base()
	{}

}

///<summary>
//////<summary> ///(Type)A property that has a curve as its value domain may either be an appropriate geometry element encapsulated in an element of this type or an XLink reference to a remote geometry element (where remote includes geometry elements located elsewhere in the same document). Either the reference or the contained element shall be given, but neither both nor none.(Element) ///</summary>
///</summary>
public class curveMember : CurvePropertyType { 


	public curveMember( NilReasonType nilReason, boolean owns) : base( nilReason, owns)
	{
	}

	protected curveMember(): base()
	{}

}

///<summary>
//////<summary> ///(Type)no description available(Element)A gml:CompositeCurve is represented by a sequence of (orientable) curves such that each curve in the sequence terminates at the start point of the subsequent curve in the list. curveMember references or contains inline one curve in the composite curve. The curves are contiguous, the collection of curves is ordered. Therefore, if provided, the aggregationType attribute shall have the value "sequence". ///</summary>
///</summary>
public class CompositeCurve : CompositeCurveType { 


	public CompositeCurve( AggregationType aggregationType, anyURI srsName, positiveInteger srsDimension, ID id) : base( aggregationType, srsName, srsDimension, id)
	{
	}

	protected CompositeCurve(): base()
	{}

}

///<summary>
//////<summary> ///(Type)no description available(Element)gml:AbstractGeometricAggregate is the abstract head of the substitution group for all geometric aggregates. ///</summary>
///</summary>
public abstract class AbstractGeometricAggregate : AbstractGeometricAggregateType { 


	protected AbstractGeometricAggregate( AggregationType aggregationType, anyURI srsName, positiveInteger srsDimension, ID id) : base( aggregationType, srsName, srsDimension, id)
	{
	}

	protected AbstractGeometricAggregate(): base()
	{}

}

///<summary>
//////<summary> ///(Type)no description available(Element)A gml:MultiPoint consists of one or more gml:Points. The members of the geometric aggregate may be specified either using the "standard" property (gml:pointMember) or the array property (gml:pointMembers). It is also valid to use both the "standard" and the array properties in the same collection. ///</summary>
///</summary>
public class MultiPoint : MultiPointType { 


	public MultiPoint( AggregationType aggregationType, anyURI srsName, positiveInteger srsDimension, ID id) : base( aggregationType, srsName, srsDimension, id)
	{
	}

	protected MultiPoint(): base()
	{}

}

///<summary>
//////<summary> ///(Type)A property that has a point as its value domain may either be an appropriate geometry element encapsulated in an element of this type or an XLink reference to a remote geometry element (where remote includes geometry elements located elsewhere in the same document). Either the reference or the contained element shall be given, but neither both nor none.(Element)This property element either references a Point via the XLink-attributes or contains the Point element. ///</summary>
///</summary>
public class pointMember : PointPropertyType { 


	public pointMember( NilReasonType nilReason, boolean owns) : base( nilReason, owns)
	{
	}

	protected pointMember(): base()
	{}

}
//AbstractValue refers same name
//AbstractScalarValue refers same name

///<summary>
//////<summary> ///(Type)gml:MeasureType supports recording an amount encoded as a value of XML Schema double, together with a units of measure indicated by an attribute uom, short for "units Of measure". The value of the uom attribute identifies a reference system for the amount, usually a ratio or interval scale.(Element)The value of a physical quantity, together with its unit. ///</summary>
///</summary>
public class measure : MeasureType { 


	public measure( UomIdentifier uom) : base( uom)
	{
	}

	protected measure(): base()
	{}

}

///<summary>
///(Type)(Element)This element has no type defined, and is therefore implicitly (according to the rules of W3C XML Schema) an XML Schema anyType. It is used as the head of an XML Schema substitution group which unifies complex content and certain simple content elements used for datatypes in GML, including the gml:AbstractGML substitution group.
///</summary>
public abstract class AbstractObject {
}
///<summary>
///(Type)(Element)
///</summary>
public class Boolean {
}
}

