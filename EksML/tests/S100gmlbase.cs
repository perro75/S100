//EksML - S100 application schema to csCode 1.6.2017 17:14:42

using System;
using System.ComponentModel;

using gml;


namespace S100 {


///<summary>
///Type for agency codes (AGEN)
///</summary>

public struct AgencyCodeType {
		private string VALUE;
		public static implicit operator string( AgencyCodeType value ) {
		return value.VALUE;
	}
	
	public static implicit operator AgencyCodeType( string value ) {
		var _ReturnValue = new AgencyCodeType();
		_ReturnValue.VALUE = value;
		return _ReturnValue;
	}
}

///<summary>
///Type for identifier FIDN. Range [1, 2^32 - 2]
///</summary>

public struct IdentificationNumberType {
		private positiveInteger VALUE;
		public static implicit operator positiveInteger( IdentificationNumberType value ) {
		return value.VALUE;
	}
	
	public static implicit operator IdentificationNumberType( positiveInteger value ) {
		var _ReturnValue = new IdentificationNumberType();
		_ReturnValue.VALUE = value;
		return _ReturnValue;
	}
}

///<summary>
///type for identification subdivision (FIDS). Range [1, 2^16 - 2]
///</summary>

public struct IdentificationSubdivisionType {
		private positiveInteger VALUE;
		public static implicit operator positiveInteger( IdentificationSubdivisionType value ) {
		return value.VALUE;
	}
	
	public static implicit operator IdentificationSubdivisionType( positiveInteger value ) {
		var _ReturnValue = new IdentificationSubdivisionType();
		_ReturnValue.VALUE = value;
		return _ReturnValue;
	}
}

///<summary>
///no description available
///</summary>

public struct BearingType {
		private decimal VALUE;
		public static implicit operator decimal( BearingType value ) {
		return value.VALUE;
	}
	
	public static implicit operator BearingType( decimal value ) {
		var _ReturnValue = new BearingType();
		_ReturnValue.VALUE = value;
		return _ReturnValue;
	}
}

///<summary>
///no description available
///</summary>

public struct PlusOrMinus360Degrees {
		private decimal VALUE;
		public static implicit operator decimal( PlusOrMinus360Degrees value ) {
		return value.VALUE;
	}
	
	public static implicit operator PlusOrMinus360Degrees( decimal value ) {
		var _ReturnValue = new PlusOrMinus360Degrees();
		_ReturnValue.VALUE = value;
		return _ReturnValue;
	}
}

///<summary>
///Topic categories in S-100 Edition 1.0.0 and gmxCodelists.xml from OGC ISO 19139 XML schemas - see MD_TopicCategoryCode. Alternatives to this enumeration: (1) Add the ISO 19139 schemas to this profile and use the codelist MD_TopicCategoryCode instead. (2) Ise numeric codes for literals instead of labels, e.g., "1" instead of "farming".
///</summary>
public enum MD_TopicCategoryCode { 
	///<summary>
	///rearing of animals and/or cultivation of plants. Examples: agriculture, irrigation, aquaculture, plantations, herding, pests and diseases affecting crops and livestock
	///</summary>
	[Description("farming")]
	farming=1,
	///<summary>
	///flora and/or fauna in natural environment. Examples: wildlife, vegetation, biological sciences, ecology, wilderness, sealife, wetlands, habitat
	///</summary>
	[Description("biota")]
	biota=2,
	///<summary>
	///legal land descriptions. Examples: political and administrative boundaries
	///</summary>
	[Description("boundaries")]
	boundaries=3,
	///<summary>
	///processes and phenomena of the atmosphere. Examples: cloud cover, weather, climate, atmospheric conditions, climate change, precipitation
	///</summary>
	[Description("climatologyMeteorologyAtmosphere")]
	climatologyMeteorologyAtmosphere=4,
	///<summary>
	///economic activities, conditions and employment. Examples: production, labour, revenue, commerce, industry, tourism and ecotourism, forestry, fisheries, commercial or subsistence hunting, exploration and exploitation of resources such as minerals, oil and gas
	///</summary>
	[Description("economy")]
	economy=5,
	///<summary>
	///height above or below sea level. Examples: altitude, bathymetry, digital elevation models, slope, derived products
	///</summary>
	[Description("elevation")]
	elevation=6,
	///<summary>
	///environmental resources, protection and conservation. Examples: environmental pollution, waste storage and treatment, environmental impact assessment, monitoring environmental risk, nature reserves, landscape
	///</summary>
	[Description("environment")]
	environment=7,
	///<summary>
	///information pertaining to earth sciences. Examples: geophysical features and processes, geology, minerals, sciences dealing with the composition, structure and origin of the earth s rocks, risks of earthquakes, volcanic activity, landslides, gravity information, soils, permafrost, hydrogeology, erosion
	///</summary>
	[Description("geoscientificInformation")]
	geoscientificInformation=8,
	///<summary>
	///health, health services, human ecology, and safety. Examples: disease and illness, factors affecting health, hygiene, substance abuse, mental and physical health, health services
	///</summary>
	[Description("health")]
	health=9,
	///<summary>
	///base maps. Examples: land cover, topographic maps, imagery, unclassified images, annotations
	///</summary>
	[Description("imageryBaseMapsEarthCover")]
	imageryBaseMapsEarthCover=10,
	///<summary>
	///military bases, structures, activities. Examples: barracks, training grounds, military transportation, information collection
	///</summary>
	[Description("intelligenceMilitary")]
	intelligenceMilitary=11,
	///<summary>
	///inland water features, drainage systems and their characteristics. Examples: rivers and glaciers, salt lakes, water utilization plans, dams, currents, floods, water quality, hydrographic charts
	///</summary>
	[Description("inlandWaters")]
	inlandWaters=12,
	///<summary>
	///positional information and services. Examples: addresses, geodetic networks, control points, postal zones and services, place names
	///</summary>
	[Description("location")]
	location=13,
	///<summary>
	///features and characteristics of salt water bodies (excluding inland waters). Examples: tides, tidal waves, coastal information, reefs
	///</summary>
	[Description("oceans")]
	oceans=14,
	///<summary>
	///information used for appropriate actions for future use of the land. Examples: land use maps, zoning maps, cadastral surveys, land ownership
	///</summary>
	[Description("planningCadastre")]
	planningCadastre=15,
	///<summary>
	///characteristics of society and cultures. Examples: settlements, anthropology, archaeology, education, traditional beliefs, manners and customs, demographic data, recreational areas and activities, social impact assessments, crime and justice, census information
	///</summary>
	[Description("society")]
	society=16,
	///<summary>
	///man-made construction. Examples: buildings, museums, churches, factories, housing, monuments, shops, towers
	///</summary>
	[Description("structure")]
	structure=17,
	///<summary>
	///means and aids for conveying persons and/or goods. Examples: roads, airports/airstrips, shipping routes, tunnels, nautical charts, vehicle or vessel location, aeronautical charts, railways
	///</summary>
	[Description("transportation")]
	transportation=18,
	///<summary>
	///energy, water and waste systems and communications infrastructure and services. Examples: hydroelectricity, geothermal, solar and nuclear sources of energy, water purification and distribution, sewage collection and disposal, electricity and gas distribution, data communication, telecommunication, radio, communication networks
	///</summary>
	[Description("utilitiesCommunication")]
	utilitiesCommunication=19
}

///<summary>
///Utility type for subset of ISO 639-1 alpha-2 language codes
///</summary>
public enum ISO_639_1 { 
	///<summary>
	///English
	///</summary>
	[Description("en")]
	en=1
}

///<summary>
///Utility type for ISO 639-3 codes
///</summary>
public enum ISO_639_3 { 
	///<summary>
	///no description available
	///</summary>
	[Description("eng")]
	eng=1
}

///<summary>
///Utility type for ISO 3166-1-alpha2 codes
///</summary>
public enum ISO_3166_1_alpha2 { 
	///<summary>
	///no description available
	///</summary>
	[Description("KR")]
	KR=1,
	///<summary>
	///no description available
	///</summary>
	[Description("US")]
	US=2,
	///<summary>
	///Jussland - Not ISO 3166, but needed for sample datasets
	///</summary>
	[Description("JS")]
	JS=3
}

///<summary>
///Complex type for feature object identifier combines agency, FIDN, FIDS
///</summary>
public class FeatureObjectIdentifier { 

	public AgencyCodeType agency;
	public IdentificationNumberType featureIdentificationNumber;
	public IdentificationSubdivisionType featureIdentificationSubdivision;

	public FeatureObjectIdentifier( AgencyCodeType agency, IdentificationNumberType featureIdentificationNumber, IdentificationSubdivisionType featureIdentificationSubdivision)
	{
		this.agency=agency;
		this.featureIdentificationNumber=featureIdentificationNumber;
		this.featureIdentificationSubdivision=featureIdentificationSubdivision;
	}

	protected FeatureObjectIdentifier(): base()
	{}

}

///<summary>
///S-100 Data Set Identification. The fields correspond to S-100 10a-5.1.2.1 fields. Attributes encodingSpecification and encodingSpecificationEdition are actually redundant here because in an XML schema the encoding specification and encoding specification edition are usually implicit in the namespace URI.
///</summary>
public class DataSetIdentificationType { 

	public string encodingSpecification;
	public string encodingSpecificationEdition;
	public string productIdentifier;
	public string productEdition;
	public string applicationProfile;
	public string datasetFileIdentifier;
	public string datasetTitle;
	public date datasetReferenceDate;
	public ISO_639_1 datasetLanguage;
	public string datasetAbstract;
	public MD_TopicCategoryCode[] datasetTopicCategory;

	public DataSetIdentificationType( string encodingSpecification, string encodingSpecificationEdition, string productIdentifier, string productEdition, string applicationProfile, string datasetFileIdentifier, string datasetTitle, date datasetReferenceDate, ISO_639_1 datasetLanguage, MD_TopicCategoryCode[] datasetTopicCategory)
	{
		this.encodingSpecification=encodingSpecification;
		this.encodingSpecificationEdition=encodingSpecificationEdition;
		this.productIdentifier=productIdentifier;
		this.productEdition=productEdition;
		this.applicationProfile=applicationProfile;
		this.datasetFileIdentifier=datasetFileIdentifier;
		this.datasetTitle=datasetTitle;
		this.datasetReferenceDate=datasetReferenceDate;
		this.datasetLanguage=datasetLanguage;
		this.datasetTopicCategory=datasetTopicCategory;
	}

	protected DataSetIdentificationType(): base()
	{}

}

///<summary>
///Data Set Structure information
///</summary>
public class DataSetStructureInformationType { 

	public double datasetCoordOriginX;
	public double datasetCoordOriginY;
	public double datasetCoordOriginZ;
	public positiveInteger coordMultFactorX;
	public positiveInteger coordMultFactorY;
	public positiveInteger coordMultFactorZ;
	public nonNegativeInteger nInfoRec;
	public nonNegativeInteger nPointRec;
	public nonNegativeInteger nMultiPointRec;
	public nonNegativeInteger nCurveRec;
	public nonNegativeInteger nCompositeCurveRec;
	public nonNegativeInteger nSurfaceRec;
	public nonNegativeInteger nFeatureRec;

	public DataSetStructureInformationType()
	{
	}

}

///<summary>
///Abstract type for attributes
///</summary>
public abstract class AbstractAttributeType : gml.AbstractGMLType { 


	protected AbstractAttributeType( gml.ID id) : base( id)
	{
	}

	protected AbstractAttributeType(): base()
	{}

}

///<summary>
///Abstract type for an S-100 information associations
///</summary>
public class InformationPropertyType : AbstractAttributeType { 


	public InformationPropertyType( gml.ID id) : base( id)
	{
	}

	protected InformationPropertyType(): base()
	{}

}

///<summary>
///Abstract type for the inverse association to an information association.
///</summary>
public class InverseInformationAssociationType : AbstractAttributeType { 


	public InverseInformationAssociationType( gml.ID id) : base( id)
	{
	}

	protected InverseInformationAssociationType(): base()
	{}

}

///<summary>
///Abstract type for an S-100 feature association
///</summary>
public class FeaturePropertyType : AbstractAttributeType { 


	public FeaturePropertyType( gml.ID id) : base( id)
	{
	}

	protected FeaturePropertyType(): base()
	{}

}

///<summary>
///Abstract type for an S-100 information type. This is the base type from which domain application schemas derive definitions for their individual information types. It provides for all information types in the data product's GML application schema to have properties for information associations and inverse information associations.
///</summary>
public class AbstractInformationType : gml.AbstractGMLType { 


	public AbstractInformationType( gml.ID id) : base( id)
	{
	}

	protected AbstractInformationType(): base()
	{}

}

///<summary>
///Abstract type for an S-100 feature. This is the base type from which domain application schemas derive definitions for their individual features. It derives from GML AbstractFeatureType. It provides for all information types in the data product's GML application schema to have feature identifiers and properties for feature associations, information associations and inverse information associations.
///</summary>
public class AbstractFeatureType : gml.AbstractFeatureType { 

	public FeatureObjectIdentifier featureObjectIdentifier;

	public AbstractFeatureType( gml.ID id) : base( id)
	{
	}

	protected AbstractFeatureType(): base()
	{}

}

///<summary>
///S-100 point type adds an information association to the GML spatial type Point
///</summary>
public class PointType : gml.PointType { 


	public PointType( gml.anyURI srsName, gml.positiveInteger srsDimension, gml.ID id) : base( srsName, srsDimension, id)
	{
	}

	protected PointType(): base()
	{}

}

///<summary>
///Point property using the S-100 point type.
///</summary>
public class PointPropertyType { 


	public PointPropertyType()
	{
	}

}

///<summary>
///S-100 multipoint type adds an information association to the GML spatial type MultiPoint
///</summary>
public class MultiPointType : gml.MultiPointType { 


	public MultiPointType( gml.AggregationType aggregationType, gml.anyURI srsName, gml.positiveInteger srsDimension, gml.ID id) : base( aggregationType, srsName, srsDimension, id)
	{
	}

	protected MultiPointType(): base()
	{}

}

///<summary>
///MultiPoint property using the S-100 multipoint type.
///</summary>
public class MultiPointPropertyType { 


	public MultiPointPropertyType()
	{
	}

}

///<summary>
///S-100 curve type adds an information association to the GML spatial type Curve
///</summary>
public class CurveType : gml.CurveType { 


	public CurveType( gml.anyURI srsName, gml.positiveInteger srsDimension, gml.ID id) : base( srsName, srsDimension, id)
	{
	}

	protected CurveType(): base()
	{}

}

///<summary>
///Curve property using the S-100 curve type.
///</summary>
public class CurvePropertyType { 


	public CurvePropertyType()
	{
	}

}

///<summary>
///S-100 composite curve type adds an information association to the GML spatial type CompositeCurve
///</summary>
public class CompositeCurveType : gml.CompositeCurveType { 


	public CompositeCurveType( gml.AggregationType aggregationType, gml.anyURI srsName, gml.positiveInteger srsDimension, gml.ID id) : base( aggregationType, srsName, srsDimension, id)
	{
	}

	protected CompositeCurveType(): base()
	{}

}

///<summary>
///Composite Curve property using the S-100 composite curve type.
///</summary>
public class CompositeCurvePropertyType { 


	public CompositeCurvePropertyType()
	{
	}

}

///<summary>
///Orientable Curve property using the S-100 orientable curve element.
///</summary>
public class OrientableCurvePropertyType { 


	public OrientableCurvePropertyType()
	{
	}

}

///<summary>
///S-100 surface type adds an information association to the GML spatial type Surface
///</summary>
public class SurfaceType : gml.SurfaceType { 


	public SurfaceType( gml.anyURI srsName, gml.positiveInteger srsDimension, gml.ID id) : base( srsName, srsDimension, id)
	{
	}

	protected SurfaceType(): base()
	{}

}

///<summary>
///Surface property using the S-100 surface type.
///</summary>
public class SurfacePropertyType { 


	public SurfacePropertyType()
	{
	}

}

///<summary>
///S-100 polygon type adds an information association to the GML spatial type Polygon
///</summary>
public class PolygonType : gml.PolygonType { 


	public PolygonType( gml.anyURI srsName, gml.positiveInteger srsDimension, gml.ID id) : base( srsName, srsDimension, id)
	{
	}

	protected PolygonType(): base()
	{}

}

///<summary>
///Polygon property using the S-100 polygon type.
///</summary>
public class PolygonPropertyType { 


	public PolygonPropertyType()
	{
	}

}

///<summary>
///Type for S-100 arc by center point geometry
///</summary>
public class S100_ArcByCenterPointType : gml.AbstractCurveSegmentType { 

	public CurveInterpolationType interpolation;
	public LengthType radius;
	public BearingType startAngle;
	public PlusOrMinus360Degrees angularDistance;

	public S100_ArcByCenterPointType( CurveInterpolationType interpolation, LengthType radius, gml.integer numDerivativesAtStart, gml.integer numDerivativesAtEnd, gml.integer numDerivativeInterior) : base( numDerivativesAtStart, numDerivativesAtEnd, numDerivativeInterior)
	{
		this.interpolation=interpolation;
		this.radius=radius;
	}

	protected S100_ArcByCenterPointType(): base()
	{}

}

///<summary>
///no description available
///</summary>
public class S100_CircleByCenterPointType { 

	public LengthType radius;
	public BearingType startAngle;
	public no_type angularDistance;

	public S100_CircleByCenterPointType( LengthType radius, BearingType startAngle, no_type angularDistance)
	{
		this.radius=radius;
		this.startAngle=startAngle;
		this.angularDistance=angularDistance;
	}

	protected S100_CircleByCenterPointType(): base()
	{}

}

///<summary>
//////<summary> ///(Type)Abstract type for an S-100 information associations(Element) ///</summary>
///</summary>
public class informationAssociation : InformationPropertyType { 


	public informationAssociation( gml.ID id) : base( id)
	{
	}

	protected informationAssociation(): base()
	{}

}

///<summary>
//////<summary> ///(Type)Abstract type for the inverse association to an information association.(Element) ///</summary>
///</summary>
public class invInformationAssociation : InverseInformationAssociationType { 


	public invInformationAssociation( gml.ID id) : base( id)
	{
	}

	protected invInformationAssociation(): base()
	{}

}

///<summary>
//////<summary> ///(Type)Abstract type for an S-100 feature association(Element) ///</summary>
///</summary>
public class featureAssociation : FeaturePropertyType { 


	public featureAssociation( gml.ID id) : base( id)
	{
	}

	protected featureAssociation(): base()
	{}

}

///<summary>
//////<summary> ///(Type)Abstract type for an S-100 feature association(Element) ///</summary>
///</summary>
public class invFeatureAssociation : FeaturePropertyType { 


	public invFeatureAssociation( gml.ID id) : base( id)
	{
	}

	protected invFeatureAssociation(): base()
	{}

}

///<summary>
//////<summary> ///(Type)S-100 point type adds an information association to the GML spatial type Point(Element) ///</summary>
///</summary>
public class Point : PointType { 


	public Point( gml.anyURI srsName, gml.positiveInteger srsDimension, gml.ID id) : base( srsName, srsDimension, id)
	{
	}

	protected Point(): base()
	{}

}

///<summary>
//////<summary> ///(Type)Point property using the S-100 point type.(Element) ///</summary>
///</summary>
public class pointProperty : PointPropertyType { 


	public pointProperty() : base()
	{
	}

}

///<summary>
//////<summary> ///(Type)S-100 multipoint type adds an information association to the GML spatial type MultiPoint(Element) ///</summary>
///</summary>
public class MultiPoint : MultiPointType { 


	public MultiPoint( gml.AggregationType aggregationType, gml.anyURI srsName, gml.positiveInteger srsDimension, gml.ID id) : base( aggregationType, srsName, srsDimension, id)
	{
	}

	protected MultiPoint(): base()
	{}

}

///<summary>
//////<summary> ///(Type)MultiPoint property using the S-100 multipoint type.(Element) ///</summary>
///</summary>
public class multiPointProperty : MultiPointPropertyType { 


	public multiPointProperty() : base()
	{
	}

}

///<summary>
//////<summary> ///(Type)S-100 curve type adds an information association to the GML spatial type Curve(Element) ///</summary>
///</summary>
public class Curve : CurveType { 


	public Curve( gml.anyURI srsName, gml.positiveInteger srsDimension, gml.ID id) : base( srsName, srsDimension, id)
	{
	}

	protected Curve(): base()
	{}

}

///<summary>
//////<summary> ///(Type)Curve property using the S-100 curve type.(Element) ///</summary>
///</summary>
public class curveProperty : CurvePropertyType { 


	public curveProperty() : base()
	{
	}

}

///<summary>
//////<summary> ///(Type)S-100 composite curve type adds an information association to the GML spatial type CompositeCurve(Element) ///</summary>
///</summary>
public class CompositeCurve : CompositeCurveType { 


	public CompositeCurve( gml.AggregationType aggregationType, gml.anyURI srsName, gml.positiveInteger srsDimension, gml.ID id) : base( aggregationType, srsName, srsDimension, id)
	{
	}

	protected CompositeCurve(): base()
	{}

}

///<summary>
//////<summary> ///(Type)Composite Curve property using the S-100 composite curve type.(Element) ///</summary>
///</summary>
public class compositeCurveProperty : CompositeCurvePropertyType { 


	public compositeCurveProperty() : base()
	{
	}

}
//OrientableCurve refers same name

///<summary>
//////<summary> ///(Type)Orientable Curve property using the S-100 orientable curve element.(Element) ///</summary>
///</summary>
public class orientableCurveProperty : OrientableCurvePropertyType { 


	public orientableCurveProperty() : base()
	{
	}

}

///<summary>
//////<summary> ///(Type)S-100 surface type adds an information association to the GML spatial type Surface(Element) ///</summary>
///</summary>
public class Surface : SurfaceType { 


	public Surface( gml.anyURI srsName, gml.positiveInteger srsDimension, gml.ID id) : base( srsName, srsDimension, id)
	{
	}

	protected Surface(): base()
	{}

}

///<summary>
//////<summary> ///(Type)Surface property using the S-100 surface type.(Element) ///</summary>
///</summary>
public class surfaceProperty : SurfacePropertyType { 


	public surfaceProperty() : base()
	{
	}

}

///<summary>
//////<summary> ///(Type)S-100 polygon type adds an information association to the GML spatial type Polygon(Element)S100 version of polygon type ///</summary>
///</summary>
public class Polygon : PolygonType { 


	public Polygon( gml.anyURI srsName, gml.positiveInteger srsDimension, gml.ID id) : base( srsName, srsDimension, id)
	{
	}

	protected Polygon(): base()
	{}

}

///<summary>
//////<summary> ///(Type)Polygon property using the S-100 polygon type.(Element) ///</summary>
///</summary>
public class polygonProperty : PolygonPropertyType { 


	public polygonProperty() : base()
	{
	}

}

///<summary>
//////<summary> ///(Type)Type for S-100 arc by center point geometry(Element)This variant of the arc requires that the points on the arc shall be computed instead of storing the coordinates directly. The single control point is the center point of the arc. The other parameters are the radius, the bearing at start, and the angle from the start to the end relative to the center of the arc. This representation can be used only in 2D. The element radius specifies the radius of the arc. The element startAngle specifies the bearing of the arc at the start. The element angularDistance specifies the difference in bearing from the start to the end. The sign of angularDistance specifies the direction of the arc, positive values mean the direction is clockwise from start to end looking down from a point vertically above the center of the arc. Drawing starts at a bearing of 0.0 from the ray pointing due north from the center. If the center is at a pole the reference direction follows the prime meridian starting from the pole. The interpolation is fixed as "circularArcCenterPointWithRadius". Since this type always describes a single arc, the GML attribute "numArc" is not used. ///</summary>
///</summary>
public class S100_ArcByCenterPoint : S100_ArcByCenterPointType { 


	public S100_ArcByCenterPoint( CurveInterpolationType interpolation, LengthType radius, gml.integer numDerivativesAtStart, gml.integer numDerivativesAtEnd, gml.integer numDerivativeInterior) : base( interpolation, radius, numDerivativesAtStart, numDerivativesAtEnd, numDerivativeInterior)
	{
	}

	protected S100_ArcByCenterPoint(): base()
	{}

}

///<summary>
//////<summary> ///(Type)no description available(Element)An S100_CircleByCenterPoint is an S100_ArcByCenterPoint with angular distance +/- 360.0 degrees to form a full circle. Angular distance is assumed to be +360.0 degrees if it is missing. The interpolation is fixed as "circularArcCenterPointWithRadius". This representation can be used only in 2D. ///</summary>
///</summary>
public class S100_CircleByCenterPoint : S100_CircleByCenterPointType { 


	public S100_CircleByCenterPoint( LengthType radius, BearingType startAngle, no_type angularDistance) : base( radius, startAngle, angularDistance)
	{
	}

	protected S100_CircleByCenterPoint(): base()
	{}

}

}

