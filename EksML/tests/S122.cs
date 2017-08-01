//EksML - S100 application schema to csCode 28.6.2017 11.32.59

using System;
using System.ComponentModel;

using gml;


namespace S122 {


///<summary>
///stub for ISO 639-3 language codes
///</summary>

public struct ISO639_3 {

	private string VALUE;
		
	public static implicit operator string( ISO639_3 value ) {
		return value.VALUE;
	}
	
	public static implicit operator ISO639_3( string value ) {
		var _ReturnValue = new ISO639_3();
		_ReturnValue.VALUE = value;
		return _ReturnValue;
	}
	
	public override string ToString()
		{
			return this.VALUE.ToString();
		}
}

///<summary>
///stub for ISO 639-2 language codes
///</summary>

public struct ISO639_2 {

	private string VALUE;
		
	public static implicit operator string( ISO639_2 value ) {
		return value.VALUE;
	}
	
	public static implicit operator ISO639_2( string value ) {
		var _ReturnValue = new ISO639_2();
		_ReturnValue.VALUE = value;
		return _ReturnValue;
	}
	
	public override string ToString()
		{
			return this.VALUE.ToString();
		}
}

///<summary>
///stub for ISO 3166 alpha2 country codes
///</summary>

public struct ISO3166_alpha2 {

	private string VALUE;
		
	public static implicit operator string( ISO3166_alpha2 value ) {
		return value.VALUE;
	}
	
	public static implicit operator ISO3166_alpha2( string value ) {
		var _ReturnValue = new ISO3166_alpha2();
		_ReturnValue.VALUE = value;
		return _ReturnValue;
	}
	
	public override string ToString()
		{
			return this.VALUE.ToString();
		}
}

///<summary>
///Type for value interval [0.0, 360.0]. Also limits value to 1 decimal place.
///</summary>

public struct Decimal0_0To360_0 {

	private decimal VALUE;
		
	public static implicit operator decimal( Decimal0_0To360_0 value ) {
		return value.VALUE;
	}
	
	public static implicit operator Decimal0_0To360_0( decimal value ) {
		var _ReturnValue = new Decimal0_0To360_0();
		_ReturnValue.VALUE = value;
		return _ReturnValue;
	}
	
	public override string ToString()
		{
			return this.VALUE.ToString();
		}
}

///<summary>
///Type for decimal values with minimum 0.0.
///</summary>

public struct NonNegativeDecimal {

	private decimal VALUE;
		
	public static implicit operator decimal( NonNegativeDecimal value ) {
		return value.VALUE;
	}
	
	public static implicit operator NonNegativeDecimal( decimal value ) {
		var _ReturnValue = new NonNegativeDecimal();
		_ReturnValue.VALUE = value;
		return _ReturnValue;
	}
	
	public override string ToString()
		{
			return this.VALUE.ToString();
		}
}

///<summary>
///Type for decimal values with minimum 0.0 and at most 1 decimal place
///</summary>

public struct NonNegativeDecimal_1 {

	private NonNegativeDecimal VALUE;
		
	public static implicit operator NonNegativeDecimal( NonNegativeDecimal_1 value ) {
		return value.VALUE;
	}
	
	public static implicit operator NonNegativeDecimal_1( NonNegativeDecimal value ) {
		var _ReturnValue = new NonNegativeDecimal_1();
		_ReturnValue.VALUE = value;
		return _ReturnValue;
	}
	
	public override string ToString()
		{
			return this.VALUE.ToString();
		}
}

///<summary>
///The number of lights of identical character that exist as a co-located group. Integer (minimum 2).
///</summary>

public struct multiplicityOfLightsType {

	private positiveInteger VALUE;
		
	public static implicit operator positiveInteger( multiplicityOfLightsType value ) {
		return value.VALUE;
	}
	
	public static implicit operator multiplicityOfLightsType( positiveInteger value ) {
		var _ReturnValue = new multiplicityOfLightsType();
		_ReturnValue.VALUE = value;
		return _ReturnValue;
	}
	
	public override string ToString()
		{
			return this.VALUE.ToString();
		}
}

///<summary>
///Remarks: If item 7 is used, the nature of dangerous or hazardous cargoes can be amplified with category of dangerous or hazardous cargo.
///</summary>
public enum categoryOfCargoType { 
	///<summary>
	///Normally dry cargo which is transported to and from the vessel on conveyors or grabs
	///</summary>
	[Description("bulk")]
	bulk=1,
	///<summary>
	///One of a number of standard sized cargo carrying units, secured using standard corner attachments and bars
	///</summary>
	[Description("container")]
	container=2,
	///<summary>
	///Break bulk cargo normally loaded by crane
	///</summary>
	[Description("general")]
	general=3,
	///<summary>
	///Any cargo loaded by pipeline
	///</summary>
	[Description("liquid")]
	liquid=4,
	///<summary>
	///A fee paying traveller
	///</summary>
	[Description("passenger")]
	passenger=5,
	///<summary>
	///Live animals carried in bulk
	///</summary>
	[Description("livestock")]
	livestock=6,
	///<summary>
	///Dangerous or hazardous cargo as described by the IMO International Maritime Dangerous Goods code
	///</summary>
	[Description("dangerous or hazardous")]
	dangerous_or_hazardous=7
}

///<summary>
///no description available
///</summary>
public enum categoryOfTrafficControlServiceType { 
	///<summary>
	///A service implemented by a relevant authority primarily designed to improve safety and efficiency of traffic flow and the protection of the environment (International Hydrographic Dictionary, S32)
	///</summary>
	[Description("Vessel Traffic Service")]
	Vessel_Traffic_Service=1,
	///<summary>
	///A service provided for the control and operation of a place with terminal and transfer facilities for loading and discharging cargo or passengers (adapted from International Hydrographic Dictionary S32/ port)
	///</summary>
	[Description("Port Service")]
	Port_Service=2,
	///<summary>
	///A service established by a relevant authority consisting of one or more reporting points or lines at which ships are required to report their identity, course, speed and other data to the monitoring authority.
	///</summary>
	[Description("Ship Reporting Service")]
	Ship_Reporting_Service=3,
	///<summary>
	///A service consisting of a radio transmission to provide relevant information to the mariner, e.g. natural conditions, safety, traffic information
	///</summary>
	[Description("Broadcast Service")]
	Broadcast_Service=4
}

///<summary>
///This attribute expresses the level of insistence for or against an action or activity
///</summary>
public enum categoryOfRelationshipType { 
	///<summary>
	///use of facility, waterway or service is forbidden
	///</summary>
	[Description("prohibited")]
	prohibited=1,
	///<summary>
	///use of facility, waterway or service is not recommended
	///</summary>
	[Description("not recommended")]
	not_recommended=2,
	///<summary>
	///use of facility, waterway, or service is permitted but not required
	///</summary>
	[Description("permitted")]
	permitted=3,
	///<summary>
	///use of facility, waterway, or service is recommended
	///</summary>
	[Description("recommended")]
	recommended=4,
	///<summary>
	///use of facility, waterway, or service is required
	///</summary>
	[Description("required")]
	required=5,
	///<summary>
	///use of facility, waterway, or service is not required
	///</summary>
	[Description("not required")]
	not_required=6
}

///<summary>
///no description available
///</summary>
public enum vesselsCharacteristicsType { 
	///<summary>
	///The maximum length of the ship (L.O.A.). (http://en.wikipedia.org/wiki/Ship_measurements; 24 July 2010)
	///</summary>
	[Description("length overall")]
	length_overall=1,
	///<summary>
	///The ship's length measured at the waterline (L.W.L.). (http://en.wikipedia.org/wiki/Ship_measurements; 24 July 2010)
	///</summary>
	[Description("length at waterline")]
	length_at_waterline=2,
	///<summary>
	///The width or beam of the vessel. (Adapted from http://en.wikipedia.org/wiki/Ship_measurements; 24 July 2010)
	///</summary>
	[Description("breadth")]
	breadth=3,
	///<summary>
	///The depth of water necessary to float a vessel fully loaded. (http://en.wikipedia.org/wiki/Ship_measurements; 24 July 2010)
	///</summary>
	[Description("draught")]
	draught=4,
	///<summary>
	///The height of the highest point of a vessel's structure (e.g. radar aerial, funnel, cranes, masthead) above her waterline. (UKHO NP100/2009)
	///</summary>
	[Description("height")]
	height=5,
	///<summary>
	///A measurement of the weight of the vessel, usually used for warships. (Merchant ships are usually measured based on the volume of cargo space; see tonnage). Displacement is expressed either in long tons of 2,240 pounds or metric tonnes of 1,000 kg. Since the two units are very close in size (2,240 pounds = 1,016 kg and 1,000 kg = 2,205 pounds), it is common not to distinguish between them. To preserve secrecy, nations sometimes misstate a warship's displacement. (http://en.wikipedia.org/wiki/Ship_measurements; 24 July 2010)
	///</summary>
	[Description("displacement tonnage")]
	displacement_tonnage=6,
	///<summary>
	///The weight of the ship excluding cargo, fuel, ballast, stores, passengers, and crew, but with water in the boilers to steaming level. (http://en.wikipedia.org/wiki/Ship_measurements; 24 July 2010)
	///</summary>
	[Description("displacement tonnage, light")]
	displacement_tonnage__light=7,
	///<summary>
	///The weight of the ship including cargo, passengers, fuel, water, stores, dunnage and such other items necessary for use on a voyage, which brings the vessel down to her load draft. (http://en.wikipedia.org/wiki/Ship_measurements; 24 July 2010)
	///</summary>
	[Description("displacement tonnage, loaded")]
	displacement_tonnage__loaded=8,
	///<summary>
	///The difference between displacement, light and displacement, loaded. A measure of the ship's total carrying capacity. (http://en.wikipedia.org/wiki/Ship_measurements; 24 July 2010)
	///</summary>
	[Description("deadweight tonnage")]
	deadweight_tonnage=9,
	///<summary>
	///The entire internal cubic capacity of the ship expressed in tons of 100 cubic feet to the ton, except certain spaces with are exempted such as: peak and other tanks for water ballast, open forecastle bridge and poop, access of hatchways, certain light and air spaces, domes of skylights, condenser, anchor gear, steering gear, wheel house, galley and cabin for passengers. (http://en.wikipedia.org/wiki/Ship_measurements; 24 July 2010)
	///</summary>
	[Description("gross tonnage")]
	gross_tonnage=10,
	///<summary>
	///Obtained from the gross tonnage by deducting crew and navigating spaces and allowances for propulsion machinery.(http://en.wikipedia.org/wiki/Ship_measurements; 24 July 2010)
	///</summary>
	[Description("net tonnage")]
	net_tonnage=11,
	///<summary>
	///the Panama Canal/Universal Measurement System (PC/UMS) is based on net tonnage, modified for Panama Canal purposes. PC/UMS is based on a mathematical formula to calculate a vessel's total volume; a PC/UMS net ton is equivalent to 100 cubic feet of capacity. (Adapted from http://en.wikipedia.org/wiki/Tonnage 4 Oct 2010)
	///</summary>
	[Description("Panama Canal/Universal Measurement System net tonnage")]
	Panama_Canal_Universal_Measurement_System_net_tonnage=12,
	///<summary>
	///the Suez Canal Net Tonnage (SCNT) is derived with a number of modifications from the former net register tonnage of the Moorsom System and was established by the International Commission of Constantinople in its Protocol of 18 December 1873. It is still in use, as amended by the Rules of Navigation of the Suez Canal Authority, and is registered in the Suez Canal Tonnage Certificate. (Adapted from http://en.wikipedia.org/wiki/Tonnage 4 Oct 2010)
	///</summary>
	[Description("Suez Canal net tonnage")]
	Suez_Canal_net_tonnage=13
}

///<summary>
///Classification of ship reports based on IMO standard report formats.
///</summary>
public enum categoryOfShipReportType { 
	///<summary>
	///before or as near as possible to the time of departure from a port within a system or when entering the area covered by a system [for instance A, B, J, X etc]
	///</summary>
	[Description("sailing plan")]
	sailing_plan=1,
	///<summary>
	///when necessary to ensure effective operation of the system
	///</summary>
	[Description("position report")]
	position_report=2,
	///<summary>
	///when the ship’s position varies significantly from the position that would have been predicted from previous reports, when changing the reported route, or as decided by the master
	///</summary>
	[Description("deviation report")]
	deviation_report=3,
	///<summary>
	///on arrival at the destination or on leaving the area covered by the system
	///</summary>
	[Description("final report")]
	final_report=4,
	///<summary>
	///when an incident takes place involving the loss or likely loss overboard of packaged dangerous goods, including those in freight containers, portable tanks, road and rail vehicles and shipborne barges, into the sea
	///</summary>
	[Description("dangerous goods report")]
	dangerous_goods_report=5,
	///<summary>
	///when an incident takes place involving the discharge or probable discharge of oil (Annex I of MARPOL 73/78) or noxious liquid substances in bulk (Annex II of MARPOL 73/78)
	///</summary>
	[Description("harmful substances report")]
	harmful_substances_report=6,
	///<summary>
	///in the case of the loss or likely loss overboard of harmful substances in packaged form, including those in freight containers, portable tanks, road and rail vehicles and shipborne barges identified in the International Maritime Goods Code as marine pollutants (Annex III of MARPOL 73/78).
	///</summary>
	[Description("marine pollutants report")]
	marine_pollutants_report=7,
	///<summary>
	///any other report should be made in accordance with the system procedures as notified in accordance with paragraph 9 of the general principles
	///</summary>
	[Description("any other report")]
	any_other_report=8
}

///<summary>
///Classification of completeness of textual information in relation to the source.
///</summary>
public enum categoryOfTextType { 
	///<summary>
	///A statement summarizing the important points of a text.
	///</summary>
	[Description("abstract or summary")]
	abstract_or_summary=1,
	///<summary>
	///An excerpt or excerpts from a text.
	///</summary>
	[Description("extract")]
	extract=2,
	///<summary>
	///The whole text
	///</summary>
	[Description("full text")]
	full_text=3
}

///<summary>
///Remarks: The definition of COMPOP provides the relation between the value given in the model and the real ship's value.
///</summary>
public enum comparisonOperatorType { 
	///<summary>
	///The value of the left value is greater than that of the right.(http://en.wikipedia.org/wiki/Logical_connective)
	///</summary>
	[Description("greater than")]
	greater_than=1,
	///<summary>
	///The value of the left expression is greater than or equal to that of the right. (http://en.wikipedia.org/wiki/Logical_connective)
	///</summary>
	[Description("greater than or equal to")]
	greater_than_or_equal_to=2,
	///<summary>
	///The value of the left expression is less than that of the right. (http://en.wikipedia.org/wiki/Logical_connective)
	///</summary>
	[Description("less than")]
	less_than=3,
	///<summary>
	///The value of the left expression is less than or equal to that of the right. (http://en.wikipedia.org/wiki/Logical_connective)
	///</summary>
	[Description("less than or equal to")]
	less_than_or_equal_to=4,
	///<summary>
	///The two values are equivalent. (adapted http://en.wikipedia.org/wiki/Logical_connective)
	///</summary>
	[Description("equal to")]
	equal_to=5,
	///<summary>
	///The two values are not equivalent. (adapted http://en.wikipedia.org/wiki/Logical_connective)
	///</summary>
	[Description("not equal to")]
	not_equal_to=6
}

///<summary>
///no description available
///</summary>
public enum dayOfWeekType { 
	///<summary>
	///monday the day of the week before Tuesday and following Sunday
	///</summary>
	[Description("monday")]
	monday=1,
	///<summary>
	///the day of the week before Wednesday and following Monday
	///</summary>
	[Description("tuesday")]
	tuesday=2,
	///<summary>
	///wednesday the day of the week before Thursday and following Tuesday
	///</summary>
	[Description("wednesday")]
	wednesday=3,
	///<summary>
	///thursday the day of the week before Friday and following Wednesday
	///</summary>
	[Description("thursday")]
	thursday=4,
	///<summary>
	///friday the day of the week before Saturday and following Thursday
	///</summary>
	[Description("friday")]
	friday=5,
	///<summary>
	///saturday the day of the week before Sunday and following Friday (together with Sunday forming part of the weekend)
	///</summary>
	[Description("saturday")]
	saturday=6,
	///<summary>
	///sunday the day of the week before Monday and following Saturday (together with Saturday forms part of the weekend)
	///</summary>
	[Description("sunday")]
	sunday=7
}

///<summary>
///Indicates whether the minimum or maximum value should be used to describe a condition or in application processing
///</summary>
public enum operationType { 
	///<summary>
	///The numerically largest value computed from the applicable attributes or sub-attributes
	///</summary>
	[Description("largest value")]
	largest_value=1,
	///<summary>
	///The numerically smallest value computed from the applicable attributes or sub-attributes
	///</summary>
	[Description("smallest value")]
	smallest_value=2
}

///<summary>
///The jurisdiction applicable to an administrative area.
///</summary>
public enum jurisdictionType { 
	///<summary>
	///involving more than one country; covering more than one national area.
	///</summary>
	[Description("international")]
	international=1,
	///<summary>
	///an area administered or controlled by a single nation.
	///</summary>
	[Description("national")]
	national=2,
	///<summary>
	///an area smaller than the nation in which it lies.
	///</summary>
	[Description("national sub-division")]
	national_sub_division=3
}

///<summary>
///no description available
///</summary>
public enum logicalConnectivesType { 
	///<summary>
	///all the conditions described by the other attributes of the object, or sub-attributes of the same complex attribute, are true
	///</summary>
	[Description("logical conjunction")]
	logical_conjunction=1,
	///<summary>
	///at least one of the conditions described by the other attributes of the object, or sub-attributes of the same complex attributes, is true
	///</summary>
	[Description("logical disjunction ")]
	logical_disjunction_=2
}

///<summary>
///Definition required
///</summary>
public enum membershipType { 
	///<summary>
	///Vessels with these characteristics are included in the regulation/restriction/recommendation/nautical information.
	///</summary>
	[Description("included")]
	included=1,
	///<summary>
	///Vessels with these characteristics are excluded from the regulation/restriction/recommendation/nautical information.
	///</summary>
	[Description("excluded")]
	excluded=2
}

///<summary>
///no description available
///</summary>
public enum sourceTypeType { 
	///<summary>
	///treaty, convention, or international agreement; law or regulation issued by a national or other authority
	///</summary>
	[Description("law or regulation")]
	law_or_regulation=1,
	///<summary>
	///publication not having the force of law, issued by an international organisation or a national or local administration
	///</summary>
	[Description("official publication")]
	official_publication=2,
	///<summary>
	///Reported by mariner(s) and confirmed by another source
	///</summary>
	[Description("mariner report, confirmed")]
	mariner_report__confirmed=3,
	///<summary>
	///reported by mariner(s) but not confirmed
	///</summary>
	[Description("mariner report, not confirmed")]
	mariner_report__not_confirmed=4,
	///<summary>
	///shipping and other industry publication, including graphics, charts and web sites
	///</summary>
	[Description("industry publications and reports")]
	industry_publications_and_reports=5,
	///<summary>
	///information obtained from satellite images
	///</summary>
	[Description("remotely sensed images")]
	remotely_sensed_images=6,
	///<summary>
	///information obtained from photographs
	///</summary>
	[Description("photographs")]
	photographs=7,
	///<summary>
	///information obtained from products issued by Hydropgrahic Offices
	///</summary>
	[Description("products issued by HO services")]
	products_issued_by_HO_services=8,
	///<summary>
	///information obtained from news media
	///</summary>
	[Description("news media")]
	news_media=9,
	///<summary>
	///information obtained from the analysis of traffic data
	///</summary>
	[Description("traffic data")]
	traffic_data=10
}

///<summary>
///no description available
///</summary>
public enum vesselsCharacteristicsUnitType { 
	///<summary>
	///The metre (or meter) is the base unit of length in the International System of Units (SI). It is defined as the distance travelled by light in vacuum in 1/299,792,458 of a second.
	///</summary>
	[Description("metre")]
	metre=1,
	///<summary>
	///A foot (plural: feet) is a non-SI unit of length in a number of different systems including English units, Imperial units, and United States customary units. The most commonly used foot today is the international foot. There are three feet in a yard and 12 inches in a foot.
	///</summary>
	[Description("foot")]
	foot=2,
	///<summary>
	///The tonne or metric ton (U.S.), often redundantly referred to as a metric tonne, is a unit of mass equal to 1,000 kg (2,205 lb) or approximately the mass of one cubic metre of water at four degrees Celsius. It is sometimes abbreviated as mt in the United States, but this conflicts with other SI symbols. The tonne is not a unit in the International System of Units (SI), but is accepted for use with the SI. In SI units and prefixes, the tonne is a megagram (Mg). The Imperial and US customary units comparable to the tonne are both spelled ton in English, though they differ in mass. Pronunciation of tonne (the word used in the UK) and ton is usually identical, but is not too confusing unless accuracy is important as the tonne and UK long ton differ by only 1.6%.
	///</summary>
	[Description("metric ton")]
	metric_ton=3,
	///<summary>
	///Long ton (weight ton or imperial ton) is the name for the unit called the "ton" in the avoirdupois or Imperial system of measurements, as used in the United Kingdom and several other Commonwealth countries. It has been mostly replaced by the tonne, and in the United States by the short ton. One long ton is equal to 2,240 pounds (1,016 kg) or 35 cubic feet (0.9911 m3) of salt water with a density of 64 lb/ft³ (1.025 g/ml). It has some limited use in the United States, most commonly in measuring the displacement of ships, and was the unit prescribed for warships by the Washington Naval Treaty—for example battleships were limited to a mass of 35,000 long tons (36,000 t; 39,000 ST).
	///</summary>
	[Description("ton")]
	ton=4,
	///<summary>
	///The short ton is a unit of weight equal to 2,000 pounds (907.18474 kg). In the United States it is often called simply ton without distinguishing it from the metric ton (tonne, 1,000 kilograms) or the long ton (2,240 pounds / 1,016.0469088 kilograms); rather, the other two are specifically noted. There are, however, some U.S. applications for which unspecified tons normally means long tons (for example, Navy ships) or metric tons (world grain production figures). Both the long and short ton are defined as 20 hundredweights, but a hundredweight is 100 pounds (45.359237 kg) in the U.S. system (short or net hundredweight) and 112 pounds (50.80234544 kg) in the Imperial system (long or gross hundredweight).
	///</summary>
	[Description("short ton")]
	short_ton=5,
	///<summary>
	///Gross tonnage (GT) is a function of the volume of all ship's enclosed spaces (from keel to funnel) measured to the outside of the hull framing. There is a sliding scale factor. So GT is a kind of capacity-derived index that is used to rank a ship for purposes of determining manning, safety and other statutory requirements and is expressed simply as GT, which is a unitless entity, even though its derivation is tied to the cubic meter unit of volumetric capacity. Tonnage measurements are now governed by an IMO Convention (International Convention on Tonnage Measurement of Ships, 1969 (London-Rules)), which applies to all ships built after July 1982. In accordance with the Convention, the correct term to use now is GT, which is a function of the moulded volume of all enclosed spaces of the ship.
	///</summary>
	[Description("gross ton")]
	gross_ton=6,
	///<summary>
	///Net tonnage (NT) is based on a calculation of the volume of all cargo spaces of the ship. It indicates a vessel’s earning space and is a function of the moulded volume of all cargo spaces of the ship.
	///</summary>
	[Description("net ton")]
	net_ton=7,
	///<summary>
	///The Panama Canal/Universal Measurement System (PC/UMS) is based on net tonnage, modified for Panama Canal purposes. PC/UMS is based on a mathematical formula to calculate a vessel's total volume; a PC/UMS net ton is equivalent to 100 cubic feet of capacity.
	///</summary>
	[Description("Panama Canal/Universal Measurement System net tonnage")]
	Panama_Canal_Universal_Measurement_System_net_tonnage=8,
	///<summary>
	///The Suez Canal Net Tonnage (SCNT) is derived with a number of modifications from the former net register tonnage of the Moorsom System and was established by the International Commission of Constantinople in its Protocol of 18 December 1873. It is still in use, as amended by the Rules of Navigation of the Suez Canal Authority, and is registered in the Suez Canal Tonnage Certificate.
	///</summary>
	[Description("Suez Canal Net Tonnage")]
	Suez_Canal_Net_Tonnage=9,
	///<summary>
	///Can be used for net and gross tonnages, including Panama Canal/Universal Measurement System net tonnage and The Suez Canal Net Tonnage.
	///</summary>
	[Description("none")]
	none=10,
	///<summary>
	///cubic metres
	///</summary>
	[Description("cubic metres")]
	cubic_metres=11
}

///<summary>
///no description available
///</summary>
public enum timeReferenceType { 
	///<summary>
	///Coordinated Universal Time
	///</summary>
	[Description("UTC")]
	UTC=1,
	///<summary>
	///Local time
	///</summary>
	[Description("LT")]
	LT=2
}

///<summary>
///no description available
///</summary>
public enum CATFRPType { 
	///<summary>
	///the first choice channel or frequency to be used when calling a radio station
	///</summary>
	[Description("preferred calling")]
	preferred_calling=1,
	///<summary>
	///a channel or frequency to be used for calling a radio station when the preferred channel or frequency is busy or is suffering from interference
	///</summary>
	[Description("alternate calling")]
	alternate_calling=2,
	///<summary>
	///the first choice channel or frequency to be used when working with a radio station
	///</summary>
	[Description("preferred working")]
	preferred_working=3,
	///<summary>
	///a channel or frequency to be used for working with a radio station when the preferred working channel or frequency is busy or is suffering from interference
	///</summary>
	[Description("alternate working")]
	alternate_working=4
}

///<summary>
///Definition required
///</summary>
public enum categoryOfRestrictedAreaType { 
	///<summary>
	///A tract of land or water managed so as to preserve it's flora, fauna, physical features, etc.
	///</summary>
	[Description("nature reserve")]
	nature_reserve=1,
	///<summary>
	///A place where birds are bred and protected.
	///</summary>
	[Description("bird sanctuary")]
	bird_sanctuary=2,
	///<summary>
	///A place where wild animals or birds hunted for sport or food are kept undisturbed for private use.
	///</summary>
	[Description("game reserve")]
	game_reserve=3,
	///<summary>
	///A place where seals are protected.
	///</summary>
	[Description("seal sanctuary")]
	seal_sanctuary=4,
	///<summary>
	///An area around certain wrecks of historical importance to protect the wrecks from unauthorized interference by diving, salvage or deposition (including anchoring).
	///</summary>
	[Description("historic wreck area")]
	historic_wreck_area=5,
	///<summary>
	///an area where marine research takes place.
	///</summary>
	[Description("research area")]
	research_area=6,
	///<summary>
	///A place where fish are protected.
	///</summary>
	[Description("fish sanctuary")]
	fish_sanctuary=7,
	///<summary>
	///A tract of land or water managed so as to preserve the relation of plants and living creatures to each other and to their surroundings.
	///</summary>
	[Description("ecological reserve")]
	ecological_reserve=8,
	///<summary>
	///A generic term which may be used to describe a wide range of areas, considered sensitive for a variety of environmental reasons.
	///</summary>
	[Description("environmentally sensitive sea area")]
	environmentally_sensitive_sea_area=9,
	///<summary>
	///An area that needs special protection through action by IMO because of its significance for regional ecological, socio-economic or scientific reasons and because it may be vulnerable to damage by international shipping activities.
	///</summary>
	[Description("particularly sensitive sea area")]
	particularly_sensitive_sea_area=10,
	///<summary>
	///A place where coral is protected. (TSMAD 29)
	///</summary>
	[Description("coral sanctuary")]
	coral_sanctuary=11,
	///<summary>
	///An area within which recreational activities regularly take place and therefore vessel movement may be restricted. (Adapted from S-57 Edition 3.1, Appendix A – Chapter 2, Page 2.76, November 2000).
	///</summary>
	[Description("recreation area")]
	recreation_area=12
}

///<summary>
///Describes the type of schedule, e.g., opening, closure, etc.
///</summary>
public enum categoryOfScheduleType { 
	///<summary>
	///The service, office, is open, fully manned, and operating normally, or the area is accessible as usual.
	///</summary>
	[Description("normal operation")]
	normal_operation=1,
	///<summary>
	///The service, office, or area is closed.
	///</summary>
	[Description("closure")]
	closure=2,
	///<summary>
	///The service is available but not manned.
	///</summary>
	[Description("unmanned operation")]
	unmanned_operation=3
}

///<summary>
///Principal and intermediate compass points.
///</summary>
public enum cardinalDirectionType { 
	///<summary>
	///North
	///</summary>
	[Description("N")]
	N=1,
	///<summary>
	///Northnortheast
	///</summary>
	[Description("NNE")]
	NNE=2,
	///<summary>
	///Northeast
	///</summary>
	[Description("NE")]
	NE=3,
	///<summary>
	///Eastnortheast
	///</summary>
	[Description("ENE")]
	ENE=4,
	///<summary>
	///East
	///</summary>
	[Description("E")]
	E=5,
	///<summary>
	///Eastsoutheast
	///</summary>
	[Description("ESE")]
	ESE=6,
	///<summary>
	///Southeast
	///</summary>
	[Description("SE")]
	SE=7,
	///<summary>
	///Southsoutheast
	///</summary>
	[Description("SSE")]
	SSE=8,
	///<summary>
	///South
	///</summary>
	[Description("S")]
	S=9,
	///<summary>
	///Southsouthwest
	///</summary>
	[Description("SSW")]
	SSW=10,
	///<summary>
	///Southwest
	///</summary>
	[Description("SW")]
	SW=11,
	///<summary>
	///Westsouthwest
	///</summary>
	[Description("WSW")]
	WSW=12,
	///<summary>
	///West
	///</summary>
	[Description("W")]
	W=13,
	///<summary>
	///Westnorthwest
	///</summary>
	[Description("WNW")]
	WNW=14,
	///<summary>
	///Northwest
	///</summary>
	[Description("NW")]
	NW=15,
	///<summary>
	///Northnorthwest
	///</summary>
	[Description("NNW")]
	NNW=16
}

///<summary>
///Definition required. Remarks: The official legal statue of each kind of restricted area defines the kind of restriction(s), e.g. the restriction for ' a game preserve' may be 'entry prohibited', the restriction for an 'anchoring prohibition' is 'anchoring prohibited'. The complete information about the restriction(s), actually held in handbooks or other publications, may be encoded by an associated instance of the information type Supplementary Information (see clause X.X) attribute textual description. A short explanation may be given by the use of the complex attribute information.
///</summary>
public enum restrictionType { 
	///<summary>
	///An area within which anchoring is not permitted.
	///</summary>
	[Description("anchoring prohibited")]
	anchoring_prohibited=1,
	///<summary>
	///a specified area designated by appropriate authority, within which anchoring is restricted in accordance with certain specified conditions.
	///</summary>
	[Description("anchoring restricted")]
	anchoring_restricted=2,
	///<summary>
	///An area within which fishing is not permitted.
	///</summary>
	[Description("fishing prohibited")]
	fishing_prohibited=3,
	///<summary>
	///a specified area designated by appropriate authority, within which fishing is restricted in accordance with certain specified conditions.
	///</summary>
	[Description("fishing restricted")]
	fishing_restricted=4,
	///<summary>
	///An area within which trawling is not permitted.
	///</summary>
	[Description("trawling prohibited")]
	trawling_prohibited=5,
	///<summary>
	///a specified area designated by appropriate authority, within which trawling is restricted in accordance with certain specified conditions.
	///</summary>
	[Description("trawling restricted")]
	trawling_restricted=6,
	///<summary>
	///An area within which navigation and/or anchoring is prohibited.
	///</summary>
	[Description("entry prohibited")]
	entry_prohibited=7,
	///<summary>
	///a specified area designated by appropriate authority, within which navigation is restricted in accordance with certain specified conditions.
	///</summary>
	[Description("entry restricted")]
	entry_restricted=8,
	///<summary>
	///An area within which dredging is not permitted.
	///</summary>
	[Description("dredging prohibited")]
	dredging_prohibited=9,
	///<summary>
	///a specified area designated by appropriate authority, within which dredging is restricted in accordance with certain specified conditions.
	///</summary>
	[Description("dredging restricted")]
	dredging_restricted=10,
	///<summary>
	///An area within which diving is not permitted.
	///</summary>
	[Description("diving prohibited")]
	diving_prohibited=11,
	///<summary>
	///a specified area designated by appropriate authority, within which diving is restricted in accordance with certain specified conditions.
	///</summary>
	[Description("diving restricted")]
	diving_restricted=12,
	///<summary>
	///Mariners must adjust the speed of their vessels to reduce the wave or wash which may cause erosion or disturb moored vessels.
	///</summary>
	[Description("no wake")]
	no_wake=13,
	///<summary>
	///An IMO declared routeing measure comprising an area within defined limits in which either navigation is particularly hazardous or it is exceptionally important to avoid casualties and which should be avoided by all ships, or certain classes of ships.
	///</summary>
	[Description("area to be avoided")]
	area_to_be_avoided=14,
	///<summary>
	///The erection of permanent or temporary fixed structures or artificial islands is prohibited.
	///</summary>
	[Description("construction prohibited")]
	construction_prohibited=15,
	///<summary>
	///An area in which discharging or dumping is prohibited.
	///</summary>
	[Description("discharging prohibited")]
	discharging_prohibited=16,
	///<summary>
	///A specified area designated by appropriate authority, within which discharging or dumping is restricted in accordance with certain specified conditions.
	///</summary>
	[Description("discharging restricted")]
	discharging_restricted=17,
	///<summary>
	///An area in which industrial or mineral exploration and development are prohibited.
	///</summary>
	[Description("industrial or mineral exploration/development prohibited")]
	industrial_or_mineral_exploration_development_prohibited=18,
	///<summary>
	///A specified area designated by appropriate authority, within which industrial or mineral exploration and development is restricted in accordance with certain specified conditions.
	///</summary>
	[Description("industrial or mineral exploration/development restricted")]
	industrial_or_mineral_exploration_development_restricted=19,
	///<summary>
	///An area in which excavating a hole on the seabed with a drill is prohibited.
	///</summary>
	[Description("drilling prohibited")]
	drilling_prohibited=20,
	///<summary>
	///A specified area designated by appropriate authority, within which excavating a hole on the seabed with a drill is restricted in accordance with certain specified conditions.
	///</summary>
	[Description("drilling restricted")]
	drilling_restricted=21,
	///<summary>
	///An area in which the removal of historical artifacts is prohibited.
	///</summary>
	[Description("removal of historical artifacts prohibited")]
	removal_of_historical_artifacts_prohibited=22,
	///<summary>
	///An area in which cargo transhipment (lightering) is prohibited.
	///</summary>
	[Description("cargo transhipment (lightering) prohibited")]
	cargo_transhipment__lightering__prohibited=23,
	///<summary>
	///An area in which the dragging or anything along the seabed, e.g., bottom trawling, is prohibited.
	///</summary>
	[Description("dragging prohibited")]
	dragging_prohibited=24,
	///<summary>
	///An area in which a vessel is prohibited from stopping.
	///</summary>
	[Description("stopping prohibited")]
	stopping_prohibited=25,
	///<summary>
	///An area in which landing is prohibited.
	///</summary>
	[Description("landing prohibited")]
	landing_prohibited=26,
	///<summary>
	///An area in which speed is restricted.
	///</summary>
	[Description("speed restricted")]
	speed_restricted=27,
	///<summary>
	///An area in which swimming is prohibited.
	///</summary>
	[Description("swimming prohibited")]
	swimming_prohibited=28
}

///<summary>
///no description available
///</summary>
public enum categoryOfMarineProtectedAreaType { 
	///<summary>
	///Strict Nature Reserve: protected area managed mainly for science Area of land and/or sea possessing some outstanding or representative ecosystems, geological or physiological features and/or species, available primarily for scientific research and/or environmental monitoring. (International Union for Conservation of Nature and Natural Resources publication “Guidelines for Protected Area Management Categories”, IUCN, 1994)
	///</summary>
	[Description("Category Ia")]
	Category_Ia=1,
	///<summary>
	///Wilderness Area: protected area managed mainly for wilderness protection Large area of unmodified or slightly modified land, and/or sea retaining its natural character and influence, without permanent or significant habitation, which is protected and managed so as to preserve its natural condition. (International Union for Conservation of Nature and Natural Resources publication “Guidelines for Protected Area Management Categories”, IUCN, 1994)
	///</summary>
	[Description("Category Ib")]
	Category_Ib=2,
	///<summary>
	///National Park: protected area managed mainly for ecosystem protection and recreation Natural area of land and/or sea, designated to (a) protect the ecological integrity of one or more ecosystems for present and future generations, (b) exclude exploitation or occupation inimical to the purposes of designation of the area and (c) provide a foundation for spiritual, scientific, educational, recreational and visitor opportunities, all of which must be environmentally and culturally compatible. (International Union for Conservation of Nature and Natural Resources publication “Guidelines for Protected Area Management Categories”, IUCN, 1994)
	///</summary>
	[Description("Category II")]
	Category_II=3,
	///<summary>
	///Natural Monument: protected area managed mainly for conservation of specific natural features Area containing one, or more, specific natural or natural/cultural feature which is of outstanding or unique value because of its inherent rarity, representative or aesthetic qualities or cultural significance. (International Union for Conservation of Nature and Natural Resources publication “Guidelines for Protected Area Management Categories”, IUCN, 1994)
	///</summary>
	[Description("Category III")]
	Category_III=4,
	///<summary>
	///Habitat/Species Management Area: protected area managed mainly for conservation through management intervention Area of land and/or sea subject to active intervention for management purposes so as to ensure the maintenance of habitats and/or to meet the requirements of specific species. (International Union for Conservation of Nature and Natural Resources publication “Guidelines for Protected Area Management Categories”, IUCN, 1994)
	///</summary>
	[Description("Category IV")]
	Category_IV=5,
	///<summary>
	///Protected Landscape/Seascape: protected area managed mainly for landscape/seascape conservation and recreation Area of land, with coast and sea as appropriate, where the interaction of people and nature over time has produced an area of distinct character with significant aesthetic, ecological and/or cultural value, and often with high biological diversity. Safeguarding the integrity of this traditional interaction is vital to the protection, maintenance and evolution of such an area. (International Union for Conservation of Nature and Natural Resources publication “Guidelines for Protected Area Management Categories”, IUCN, 1994)
	///</summary>
	[Description("Category V")]
	Category_V=6,
	///<summary>
	///Managed Resource Protected Area: protected area managed mainly for the sustainable use of natural ecosystems Area containing predominantly unmodified natural systems, managed to ensure long term protection and maintenance of biological diversity, while providing at the same time a sustainable flow of natural products and services to meet community needs. (International Union for Conservation of Nature and Natural Resources publication “Guidelines for Protected Area Management Categories”, IUCN, 1994)
	///</summary>
	[Description("Category VI")]
	Category_VI=7
}

///<summary>
///Definition required
///</summary>
public enum statusType { 
	///<summary>
	///Intended to last or function indefinitely
	///</summary>
	[Description("permanent")]
	permanent=1,
	///<summary>
	///Acting on special occasions; happening irregularly
	///</summary>
	[Description("occasional")]
	occasional=2,
	///<summary>
	///Presented as worthy of confidence, acceptance, use, etc.
	///</summary>
	[Description("recommended")]
	recommended=3,
	///<summary>
	///Use has ceased, but the facility still exists intact; disused.
	///</summary>
	[Description("not in use")]
	not_in_use=4,
	///<summary>
	///Recurring at intervals
	///</summary>
	[Description("periodic/intermittent")]
	periodic_intermittent=5,
	///<summary>
	///Set apart for some specific use
	///</summary>
	[Description("reserved")]
	reserved=6,
	///<summary>
	///Meant to last only for a time
	///</summary>
	[Description("temporary")]
	temporary=7,
	///<summary>
	///Administered by an individual or corporation, rather than a State or a public body.
	///</summary>
	[Description("private")]
	_private=8,
	///<summary>
	///Compulsory; enforced.
	///</summary>
	[Description("mandatory")]
	mandatory=9,
	///<summary>
	///No longer lit
	///</summary>
	[Description("extinguished")]
	extinguished=10,
	///<summary>
	///Lit by floodlights, strip lights, etc.
	///</summary>
	[Description("illuminated")]
	illuminated=11,
	///<summary>
	///Famous in history; of historical interest
	///</summary>
	[Description("historic")]
	historic=12,
	///<summary>
	///Belonging to, available to, used or shared by, the community as a whole and not restricted to private use.
	///</summary>
	[Description("public")]
	_public=13,
	///<summary>
	///Occur at a time, coincide in point of time, be contemporary or simultaneous
	///</summary>
	[Description("synchronised")]
	synchronised=14,
	///<summary>
	///Looked at or observed over a period of time especially so as to be aware of any movement or change.
	///</summary>
	[Description("watched")]
	watched=15,
	///<summary>
	///Usually automatic in operation, without any permanently-stationed personnel to superintend it.
	///</summary>
	[Description("un-watched")]
	un_watched=16,
	///<summary>
	///A feature that has been reported but has not been definitely determined to exist.
	///</summary>
	[Description("existence doubtful")]
	existence_doubtful=17,
	///<summary>
	///Marked by buoys
	///</summary>
	[Description("buoyed")]
	buoyed=18
}

///<summary>
///no description available
///</summary>
public enum categoryOfDangerousOrHazardousCargoType { 
	///<summary>
	///Explosives, Division 1: substances and articles which have a mass explosion hazard
	///</summary>
	[Description("Class 1: Division 1.1")]
	Class_1__Division_1_1=1,
	///<summary>
	///Explosives, Division 2: substances and articles which have a projection hazard but not a mass explosion hazard
	///</summary>
	[Description("Class 1: Division 1.2")]
	Class_1__Division_1_2=2,
	///<summary>
	///Explosives, Division 3: substances and articles which have a fire hazard and either a minor blast hazard or a minor projection hazard or both, but not a mass explosion hazard
	///</summary>
	[Description("Class 1: Division 1.3")]
	Class_1__Division_1_3=3,
	///<summary>
	///Explosives, Division 4: substances and articles which present no significant hazard
	///</summary>
	[Description("Class 1: Division 1.4")]
	Class_1__Division_1_4=4,
	///<summary>
	///Explosives, Division 5: very insensitive substances which have a mass explosion hazard
	///</summary>
	[Description("Class 1: Division 1.5")]
	Class_1__Division_1_5=5,
	///<summary>
	///Explosives, Division 6: extremely insensitive articles which do not have a mass explosion hazard
	///</summary>
	[Description("Class 1: Division 1.6")]
	Class_1__Division_1_6=6,
	///<summary>
	///Gases, flammable gases
	///</summary>
	[Description("Class 2.1")]
	Class_2_1=7,
	///<summary>
	///Gases, non-flammable, non-toxic gases
	///</summary>
	[Description("Class 2.2")]
	Class_2_2=8,
	///<summary>
	///Gases, toxic gases
	///</summary>
	[Description("Class 2.3")]
	Class_2_3=9,
	///<summary>
	///flammable liquids
	///</summary>
	[Description("Class 3")]
	Class_3=10,
	///<summary>
	///flammable solids, self-reactive substances and desensitized explosives
	///</summary>
	[Description("Class 4.1")]
	Class_4_1=11,
	///<summary>
	///substances liable to spontaneous combustion
	///</summary>
	[Description("Class 4.2")]
	Class_4_2=12,
	///<summary>
	///substances which, in contact with water, emit flammable gases
	///</summary>
	[Description("Class 4.3")]
	Class_4_3=13,
	///<summary>
	///oxidizing substances
	///</summary>
	[Description("Class 5.1")]
	Class_5_1=14,
	///<summary>
	///organic peroxides
	///</summary>
	[Description("Class 5.2")]
	Class_5_2=15,
	///<summary>
	///toxic substances
	///</summary>
	[Description("Class 6.1")]
	Class_6_1=16,
	///<summary>
	///infectious substances
	///</summary>
	[Description("Class 6.2")]
	Class_6_2=17,
	///<summary>
	///Radioactive material
	///</summary>
	[Description("Class 7")]
	Class_7=18,
	///<summary>
	///Corrosive substances
	///</summary>
	[Description("Class 8")]
	Class_8=19,
	///<summary>
	///Miscellaneous dangerous substances and articles
	///</summary>
	[Description("Class 9")]
	Class_9=20,
	///<summary>
	///Harmful substances are those substances which are identified as marine pollutants in the International Maritime Dangerous Goods Code (IMDG Code). Packaged form is defined as the forms of containment specified for harmful substances in the IMDG Code. (MARPOL (73/78) Annex III)
	///</summary>
	[Description("Harmful Substances in packaged form")]
	Harmful_Substances_in_packaged_form=21
}

///<summary>
///The type of person, government agency or organisation granted powers of managing or controlling access to and/or activity in an area
///</summary>
public enum categoryOfAuthorityType { 
	///<summary>
	///The agency or establishment for collecting duties, tolls. (Merriam-Websters online Dictionary 23rd February 2006, amended).
	///</summary>
	[Description("customs")]
	customs=1,
	///<summary>
	///The administration to prevent or detect and prosecute violations of rules and regulations at international boundaries (adapted from Merriam-Websters online Dictionary 23rd February 2006).
	///</summary>
	[Description("border control")]
	border_control=2,
	///<summary>
	///The department of government, or civil force, charged with maintaining public order. (Adapted from OED)
	///</summary>
	[Description("police")]
	police=3,
	///<summary>
	///Person or corporation, owners of, or entrusted with or invested with the power of managing a port. May be called a Harbour Board, Port Trust, Port Commission, Harbour Commission, Marine Department (NP 100 8th Edition 14 Oct 2004)
	///</summary>
	[Description("port")]
	port=4,
	///<summary>
	///The authority controlling people entering a country.
	///</summary>
	[Description("immigration")]
	immigration=5,
	///<summary>
	///The authority with responsibility for checking the validity of the health declaration of a vessel and for declaring free pratique.
	///</summary>
	[Description("health")]
	health=6,
	///<summary>
	///Organisation keeping watch on shipping and coastal waters according to governmental law; normally the authority with reponsibility for search and rescue.
	///</summary>
	[Description("coast guard")]
	coast_guard=7,
	///<summary>
	///The authority with responsibility for preventing infection of the agriculture of a country and for the protection of the agricultural interests of a country.
	///</summary>
	[Description("agricultural")]
	agricultural=8,
	///<summary>
	///A military authority which provides control of access to or approval for transit through designated areas or airspace.
	///</summary>
	[Description("military")]
	military=9,
	///<summary>
	///A private or publicly owned company or commercial enterprise which exercises control of facilities, for example a callibration area.
	///</summary>
	[Description("private company")]
	private_company=10,
	///<summary>
	///A governmental or military force with jurisdiction in territorial waters. Examples could include Gendarmerie Maritime, Carabinierie, and Guardia Civil.
	///</summary>
	[Description("maritime police")]
	maritime_police=11,
	///<summary>
	///An authority with responsibility for the protection of the environment.
	///</summary>
	[Description("environmental")]
	environmental=12,
	///<summary>
	///An authority with responsibility for the control of fisheries.
	///</summary>
	[Description("fishery")]
	fishery=13,
	///<summary>
	///an authority with responsibility for the control and movement of money.
	///</summary>
	[Description("finance")]
	finance=14,
	///<summary>
	///A national or regional authority charged with administration of maritime affairs.
	///</summary>
	[Description("maritime")]
	maritime=15
}

///<summary>
///The locality of vessel registration or enrolment relative to the nationality of a port, territorial sea, administrative area, exclusive zone or other location.
///</summary>
public enum categoryOfVesselRegistryType { 
	///<summary>
	///The vessel is registered or enrolled under the same national flag as the port, harbour, territorial sea, exclusive economic zone, or administrative area in which the object that possesses this attribute applies or is located.
	///</summary>
	[Description("domestic")]
	domestic=1,
	///<summary>
	///The vessel is registered or enrolled under a national flag different from the port, harbour, territorial sea, exclusive economic zone, or other administrative area in which the object that possesses this attribute applies or is located.
	///</summary>
	[Description("foreign")]
	foreign=2
}

///<summary>
///Classification of vessels by function or use
///</summary>
public enum categoryOfVesselType { 
	///<summary>
	///a vessel designed to carry general cargo
	///</summary>
	[Description("general cargo vessel")]
	general_cargo_vessel=1,
	///<summary>
	///a vessel designed to carry ISO containers
	///</summary>
	[Description("container carrier")]
	container_carrier=2,
	///<summary>
	///a vessel designed to carry bulk liquid or gas, including LPG and LNG
	///</summary>
	[Description("tanker")]
	tanker=3,
	///<summary>
	///a vessel designed to carry bulk solid material
	///</summary>
	[Description("bulk carrier")]
	bulk_carrier=4,
	///<summary>
	///a vessel designed to carry passengers; often a cruise ship
	///</summary>
	[Description("passenger vessel")]
	passenger_vessel=5,
	///<summary>
	///a vessel designed to allow road vehicles to be driven on and off; often a ferry
	///</summary>
	[Description("roll-on roll-off")]
	roll_on_roll_off=6,
	///<summary>
	///a vessel designed to carry refrigerated cargo
	///</summary>
	[Description("refrigerated cargo vessel")]
	refrigerated_cargo_vessel=7,
	///<summary>
	///a vessel designed to catch or hunt fish
	///</summary>
	[Description("fishing vessel")]
	fishing_vessel=8,
	///<summary>
	///a vessel which provides a service such as a tug, anchor handler, survey or supply vessel
	///</summary>
	[Description("service")]
	service=9,
	///<summary>
	///a vessel designed for the conduct of military operations
	///</summary>
	[Description("warship")]
	warship=10,
	///<summary>
	///either a tug and tow, or any combination of a tug providing propulsion to barges or vessels secured ahead or alongside
	///</summary>
	[Description("towed or pushed composite unit")]
	towed_or_pushed_composite_unit=11,
	///<summary>
	///a combination of tug(s) and non-powered tow(s)
	///</summary>
	[Description("tug and tow")]
	tug_and_tow=12,
	///<summary>
	///A pleasure boat or watercraft, or an excursion vessel used for short cruises such as whale watching
	///</summary>
	[Description("light recreational")]
	light_recreational=13,
	///<summary>
	///An installation which is designed to float at all times and which is normally anchored in position when deployed in the offshore gas and oil industry.
	///</summary>
	[Description("semi-submersible offshore installation")]
	semi_submersible_offshore_installation=14,
	///<summary>
	///An exploration or project installation with legs which can be raised and lowered. The legs are raised when the installation is repositioned. When stationary the legs are lowered to the sea floor and the working platform is raised clear of the sea surface
	///</summary>
	[Description("jackup exploration or project installation")]
	jackup_exploration_or_project_installation=15,
	///<summary>
	///A vessel designed to carry large quantities of live animals.
	///</summary>
	[Description("livestock carrier")]
	livestock_carrier=16,
	///<summary>
	///A vessel used in fishing for pleasure or competition.
	///</summary>
	[Description("sport fishing")]
	sport_fishing=17
}

///<summary>
///online search interface for seeking out information about the resource (ISO 19115:2014).
///</summary>
public enum onlineFunctionType { 
	///<summary>
	///online instructions for transferring data from one storage device or system to another. (ISO 19115:2014)
	///</summary>
	[Description("download")]
	download=1,
	///<summary>
	///online information about the resource (ISO 19115:2014)
	///</summary>
	[Description("information")]
	information=2,
	///<summary>
	///online instructions for requesting the resource from the provider (ISO 19115:2014)
	///</summary>
	[Description("offlineAccess")]
	offlineAccess=3,
	///<summary>
	///online order process for obtaining the resource (ISO 19115:2014).
	///</summary>
	[Description("order")]
	order=4,
	///<summary>
	///online search interface for seeking out information about the resource (ISO 19115:2014).
	///</summary>
	[Description("search")]
	search=5,
	///<summary>
	///complete metadata provided (ISO 19115:2014).
	///</summary>
	[Description("completeMetadata")]
	completeMetadata=6,
	///<summary>
	///browse graphic provided (ISO 19115:2014).
	///</summary>
	[Description("browseGraphic")]
	browseGraphic=7,
	///<summary>
	///online resource upload capability provided (ISO 19115:2014).
	///</summary>
	[Description("upload")]
	upload=8,
	///<summary>
	///online email service provided (ISO 19115:2014)
	///</summary>
	[Description("emailService")]
	emailService=9,
	///<summary>
	///online browsing provided (ISO 19115:2014)
	///</summary>
	[Description("browsing")]
	browsing=10,
	///<summary>
	///online file access provided (ISO 19115:2014).
	///</summary>
	[Description("fileAccess")]
	fileAccess=11
}

///<summary>
///methods to communicate between involved parties over a distance
///</summary>
public enum telecommunicationServiceType { 
	///<summary>
	///The transfer or exchange of information by using sounds that are being made by mouth and throat when speaking
	///</summary>
	[Description("voice")]
	voice=1,
	///<summary>
	///a system of transmitting and reproducing graphic matter (as printing or still pictures) by means of signals sent over telephone lines
	///</summary>
	[Description("facsimile")]
	facsimile=2,
	///<summary>
	///Short Message Service, a form of text messaging communication on phones and mobile phones
	///</summary>
	[Description("sms")]
	sms=3,
	///<summary>
	///facts or information used usually to calculate, analyze, or plan something
	///</summary>
	[Description("data")]
	data=4,
	///<summary>
	///Streamed data is data that that is constantly received by and presented to an end-user while being delivered by a provider.
	///</summary>
	[Description("streamedData")]
	streamedData=5,
	///<summary>
	///a system of communication in which messages are sent over long distances by using a telephone system and are printed by using a special machine (called a teletypewriter)
	///</summary>
	[Description("telex")]
	telex=6,
	///<summary>
	///an apparatus, system, or process for communication at a distance by electric transmission over wire
	///</summary>
	[Description("telegraph")]
	telegraph=7,
	///<summary>
	///Messages and other data exchanged between individuals using computers in a network.
	///</summary>
	[Description("email")]
	email=8
}

///<summary>
///The action or activity of a vessel
///</summary>
public enum actionOrActivityType { 
	///<summary>
	///Carrying a qualified pilot as part of the vessel navigation team.
	///</summary>
	[Description("navigating with a pilot")]
	navigating_with_a_pilot=1,
	///<summary>
	///navigating a vessel into a port
	///</summary>
	[Description("entering port")]
	entering_port=2,
	///<summary>
	///Navigating a vessel out of a port.
	///</summary>
	[Description("leaving port")]
	leaving_port=3,
	///<summary>
	///Attaching a vessel to a wharf or jetty.
	///</summary>
	[Description("berthing")]
	berthing=4,
	///<summary>
	///Detaching a vessel from a wharf or jetty.
	///</summary>
	[Description("slipping")]
	slipping=5,
	///<summary>
	///Attaching a vessel to the seabed by means of an anchor and cable.
	///</summary>
	[Description("anchoring")]
	anchoring=6,
	///<summary>
	///Detaching a vessel from the seabed by recovering an anchor and cable.
	///</summary>
	[Description("weighing anchor")]
	weighing_anchor=7,
	///<summary>
	///Navigating a vessel along a route or through a narrow gap, such as under a bridge or through a lock.
	///</summary>
	[Description("transiting")]
	transiting=8,
	///<summary>
	///Navigating a vessel past another traveling broadly in the same direction.
	///</summary>
	[Description("overtaking")]
	overtaking=9,
	///<summary>
	///Providing details such as the name, location or intentions of a vessel
	///</summary>
	[Description("reporting")]
	reporting=10,
	///<summary>
	///Loading or unloading cargo
	///</summary>
	[Description("working cargo")]
	working_cargo=11,
	///<summary>
	///Placing crew or passengers on shore.
	///</summary>
	[Description("landing")]
	landing=12,
	///<summary>
	///Placing a swimmer with an air supply below the sea surface.
	///</summary>
	[Description("diving")]
	diving=13,
	///<summary>
	///Hunting or catching fish.
	///</summary>
	[Description("fishing")]
	fishing=14,
	///<summary>
	///Releasing anything into the sea; often ballast water; or spoil from dredging elsewhere.
	///</summary>
	[Description("discharging overboard")]
	discharging_overboard=15,
	///<summary>
	///Navigating a vessel past another traveling broadly in the opposite direction.
	///</summary>
	[Description("passing")]
	passing=16
}

///<summary>
///The principal subject matter of regulations, restrictions, recommendations or nautical information
///</summary>
public enum categoryOfRxNType { 
	///<summary>
	///Pertaining to navigation
	///</summary>
	[Description("navigation")]
	navigation=1,
	///<summary>
	///Pertaining to communications
	///</summary>
	[Description("communication")]
	communication=2,
	///<summary>
	///Pertaining to environmental protection
	///</summary>
	[Description("environmental protection")]
	environmental_protection=3,
	///<summary>
	///Pertaining to wildlife protection
	///</summary>
	[Description("wildlife protection")]
	wildlife_protection=4,
	///<summary>
	///Pertaining to security
	///</summary>
	[Description("security")]
	security=5,
	///<summary>
	///Pertaining to customs
	///</summary>
	[Description("customs")]
	customs=6,
	///<summary>
	///Pertaining to cargo operations
	///</summary>
	[Description("cargo operation")]
	cargo_operation=7,
	///<summary>
	///Pertaining to a place of safety or refuge
	///</summary>
	[Description("refuge")]
	refuge=8,
	///<summary>
	///Pertaining to natural resources or exploitation
	///</summary>
	[Description("natural resources or exploitation")]
	natural_resources_or_exploitation=9,
	///<summary>
	///Pertaining to a port
	///</summary>
	[Description("port")]
	port=10,
	///<summary>
	///Pertaining to finance
	///</summary>
	[Description("finance")]
	finance=11,
	///<summary>
	///Pertaining to agriculture
	///</summary>
	[Description("agriculture")]
	agriculture=12
}

///<summary>
///An assessment of the likelihood of change within an area since last survey.
///</summary>
public enum categoryOfTemporalVariationType { 
	///<summary>
	///NIPWG: No new hydrographic survey conducted after an event (e.g., hurricane, earthquake, volcanic eruption, landslide, etc.) which is considered likely to have resulted in significant change at the location. In GI Registry Definition: No new hydrographic survey conducted after an event (e.g. hurricane, earthquake, volcanic eruption, landslide, etc), which is considered likely to have changed the seafloor significantly.
	///</summary>
	[Description("extreme event")]
	extreme_event=1,
	///<summary>
	///NIPWG: Continuous or frequent change (e.g., river siltation, sand waves, seasonal storms, construction, etc.) GI Registry: Continuous or frequent change (e.g. river siltation, sand waves, seasonal storms, ice bergs, etc).
	///</summary>
	[Description("likely to change")]
	likely_to_change=2,
	///<summary>
	///GI Registry: Likely to change but significant shoaling no expected [Proposed draft 6/27/2014: Recommended that SNPWG not use this enumerate - ref. E.M. email 6/27/2014.]
	///</summary>
	[Description("likely to change but significant shoaling not expected")]
	likely_to_change_but_significant_shoaling_not_expected=3,
	///<summary>
	///NIPWG: Significant change at the location is not expected. GI Registry: Significant change to the seafloor is not expected.
	///</summary>
	[Description("unlikely to change")]
	unlikely_to_change=4,
	///<summary>
	///Temporal variation not assessed or cannot be determined
	///</summary>
	[Description("unassessed")]
	unassessed=5
}

///<summary>
///The categorisation of the assessment level of bathymetric data for an area.
///</summary>
public enum dataAssessmentType { 
	///<summary>
	///The quality of the bathymetric data has been assessed.
	///</summary>
	[Description("assessed")]
	assessed=1,
	///<summary>
	///The quality of oceanic bathymetric data has been assessed or is not required.
	///</summary>
	[Description("Oceanic")]
	Oceanic=2,
	///<summary>
	///The quality of the bathymetric data has yet to be assessed.
	///</summary>
	[Description("Unassessed")]
	Unassessed=3
}

///<summary>
///Definition required
///</summary>
public enum QUAPOSType { 
	///<summary>
	///The position(s) was(were) determined by the operation of making measurements for determining the relative position of points on, above, or beneath the earth's surface. Survey implies a regular, controlled, survey of any date.
	///</summary>
	[Description("surveyed")]
	surveyed=1,
	///<summary>
	///Survey data does not exist or is very poor
	///</summary>
	[Description("unsurveyed")]
	unsurveyed=2,
	///<summary>
	///Position data is of very poor quality
	///</summary>
	[Description("inadequately surveyed")]
	inadequately_surveyed=3,
	///<summary>
	///A position that is considered to be less than third-order accuracy, but is generally considered to be within 30.5 meters of its correct geographic location. Also, may apply to a feature whose position does not remain fixed.
	///</summary>
	[Description("approximate")]
	approximate=4,
	///<summary>
	///A feature whose position has been reported but which is considered to be doubtful
	///</summary>
	[Description("position doubtful")]
	position_doubtful=5,
	///<summary>
	///A feature's position obtained from questionable or unreliable data.
	///</summary>
	[Description("unreliable")]
	unreliable=6,
	///<summary>
	///A feature whose position has been reported and its position confirmed by some means other than a formal survey such as an independent report of the same feature.
	///</summary>
	[Description("reported (not surveyed)")]
	reported__not_surveyed_=7,
	///<summary>
	///A feature whose position has been reported and its position has not been confirmed.
	///</summary>
	[Description("reported (not confirmed")]
	reported__not_confirmed=8,
	///<summary>
	///The most probable position of a feature determined from incomplete data or data of questionable accuracy.
	///</summary>
	[Description("estimated")]
	estimated=9,
	///<summary>
	///A position that is of a known value, such as the position of an anchor berth or other defined feature.
	///</summary>
	[Description("precisely known")]
	precisely_known=10,
	///<summary>
	///A position that is computed from data.
	///</summary>
	[Description("calculated")]
	calculated=11
}

///<summary>
///The anchor point of a text string.
///</summary>
public enum textJustificationType { 
	///<summary>
	///The anchor point is at the start of the text string.
	///</summary>
	[Description("left")]
	left=1,
	///<summary>
	///The anchor point is at the centre of the text string.
	///</summary>
	[Description("centred")]
	centred=2,
	///<summary>
	///The anchor point is at the end of the text string.
	///</summary>
	[Description("right")]
	right=3
}

///<summary>
///The attribute from which a text string is derived. (S-122) Remark: S-122 does not include light features and therefore listed value '2: light characteristic' is omitted from the S-122 application schema.
///</summary>
public enum textTypeType { 
	///<summary>
	///Definition required
	///</summary>
	[Description("Feature name")]
	Feature_name=1
}

///<summary>
///built in date types from W3C XML schema, implementing S-100 truncated date
///</summary>
public class S100_TruncatedDate { 

	public gDay gDay;
	public gMonth gMonth;
	public gYear gYear;
	public gMonthDay gMonthDay;
	public gYearMonth gYearMonth;
	public date date;

	public S100_TruncatedDate()
	{
	}

}

///<summary>
///no description available
///</summary>
public class PointOrSurface { 


	public PointOrSurface()
	{
	}

}

///<summary>
///no description available
///</summary>
public class CurveOrSurface { 


	public CurveOrSurface()
	{
	}

}

///<summary>
///no description available
///</summary>
public class PointCurveSurface { 


	public PointCurveSurface()
	{
	}

}

///<summary>
///no description available
///</summary>
public class PointOrCurve { 


	public PointOrCurve()
	{
	}

}

///<summary>
///no description available
///</summary>
public class GM_Point { 


	public GM_Point()
	{
	}

}

///<summary>
///no description available
///</summary>
public class GM_Curve { 


	public GM_Curve()
	{
	}

}

///<summary>
///no description available
///</summary>
public class GM_Surface { 


	public GM_Surface()
	{
	}

}

///<summary>
///Information about online sources from which a resource or data can be obtained (ISO 19115, adapted).
///</summary>
public class onlineResourceType { 

	public anyURI linkage;
	public string protocol;
	public string applicationProfile;
	public string nameOfResource;
	public string onlineDescription;
	public onlineFunctionType onlineFunction;
	public string protocolRequest;

	public onlineResourceType( anyURI linkage)
	{
		this.linkage=linkage;
	}

	protected onlineResourceType(): base()
	{}

}

///<summary>
///no description available
///</summary>
public class graphicType { 

	public string[] pictorialRepresentation;
	public string pictureCaption;
	public date sourceDate;
	public string pictureInformation;
	public bearingInformationType bearingInformation;

	public graphicType( string[] pictorialRepresentation)
	{
		this.pictorialRepresentation=pictorialRepresentation;
	}

	protected graphicType(): base()
	{}

}

///<summary>
///An abstract superclass for the Quartet information types
///</summary>
public abstract class AbstractRXNType : InformationTypeType { 

	public categoryOfAuthorityType categoryOfAuthority;
	public textContentType[] textContent;
	public graphicType[] graphic;
	public rxnCodeType[] rxnCode;
	public ReferenceType[] appliesInLocation;
	public ReferenceType[] isApplicableTo;

	protected AbstractRXNType( gml.ID id) : base( id)
	{
	}

	protected AbstractRXNType(): base()
	{}

}

///<summary>
///Describes the relationship between vessel characteristics and: (i) the applicability of an associated information object or feature to the vessel; or, (ii) the use of a facility, place, or service by the vessel; or, (iii) passage of the vessel through an area.
///</summary>
public class ApplicabilityType : InformationTypeType { 

	public boolean ballast;
	public categoryOfCargoType[] categoryOfCargo;
	public categoryOfDangerousOrHazardousCargoType[] categoryOfDangerousOrHazardousCargo;
	public categoryOfVesselType categoryOfVessel;
	public categoryOfVesselRegistryType categoryOfVesselRegistry;
	public logicalConnectivesType logicalConnectives;
	public nonNegativeInteger thicknessOfIceCapability;
	public informationType[] information;
	public string vesselPerformance;
	public vesselsMeasurementsType[] vesselsMeasurements;
	public ReferenceType[] vslLocation;
	public ReferenceType[] theApplicableRxN;

	public ApplicabilityType( gml.ID id) : base( id)
	{
	}

	protected ApplicabilityType(): base()
	{}

}

///<summary>
///A person or organisation having political or administrative power and control. (Oxford Dictionary of English)
///</summary>
public class AuthorityType : InformationTypeType { 

	public categoryOfAuthorityType categoryOfAuthority;
	public textContentType textContent;
	public ReferenceType[] theContactDetails;
	public ReferenceType[] theServiceHours;
	public ReferenceType[] theShipReport;
	public ReferenceType[] theInformation;

	public AuthorityType( categoryOfAuthorityType categoryOfAuthority, gml.ID id) : base( id)
	{
		this.categoryOfAuthority=categoryOfAuthority;
	}

	protected AuthorityType(): base()
	{}

}

///<summary>
///Generalized feature type which carry all the common attributes
///</summary>
public abstract class FeatureType : S100.AbstractFeatureType { 

	public fixedDateRangeType fixedDateRange;
	public periodicDateRangeType[] periodicDateRange;
	public featureNameType[] featureName;
	public sourceIndicationType sourceIndication;
	public textContentType[] textContent;
	public ReferenceType[] permission;
	public ReferenceType[] provides;
	public ReferenceType[] theRxN;

	protected FeatureType( gml.ID id) : base( id)
	{
	}

	protected FeatureType(): base()
	{}

}

///<summary>
///Generalized information type which carry all the common attributes
///</summary>
public abstract class InformationTypeType : S100.AbstractInformationType { 

	public fixedDateRangeType fixedDateRange;
	public periodicDateRangeType[] periodicDateRange;
	public featureNameType[] featureName;
	public sourceIndicationType sourceIndication;
	public ReferenceType[] providesInformation;

	protected InformationTypeType( gml.ID id) : base( id)
	{
	}

	protected InformationTypeType(): base()
	{}

}

///<summary>
///Any area of the intertidal or sub tidal terrain, together with its overlying water and associated flora, fauna, historical and cultural features, which has been reserved by law or other effective means to protect part or all of the enclosed environment. (IUCN – The World Conservation Union. 1998. Resolution 17.38 of the 17th General Assembly of the IUCN. Gland, Switzerland and Cambridge, UK.)
///</summary>
public class MarineProtectedAreaType : FeatureType { 

	public categoryOfMarineProtectedAreaType categoryOfMarineProtectedArea;
	public categoryOfRestrictedAreaType[] categoryOfRestrictedArea;
	public jurisdictionType jurisdiction;
	public restrictionType[] restriction;
	public statusType[] status;
	public graphicType[] graphic;
	public ReferenceType[] responsibleAuthority;
	public CurveOrSurface[] geometry;

	public MarineProtectedAreaType( categoryOfMarineProtectedAreaType categoryOfMarineProtectedArea, jurisdictionType jurisdiction, gml.ID id) : base( id)
	{
		this.categoryOfMarineProtectedArea=categoryOfMarineProtectedArea;
		this.jurisdiction=jurisdiction;
	}

	protected MarineProtectedAreaType(): base()
	{}

}

///<summary>
///A service implemented by a relevant authority for shipping, e.g. traffic control, information, assistance.
///</summary>
public class TrafficControlServiceType : FeatureType { 

	public categoryOfTrafficControlServiceType categoryOfTrafficControlService;
	public ReferenceType[] reptForTrafficServ;
	public ReferenceType controlAuthority;
	public GM_Surface[] geometry;

	public TrafficControlServiceType( categoryOfTrafficControlServiceType categoryOfTrafficControlService, gml.ID id) : base( id)
	{
		this.categoryOfTrafficControlService=categoryOfTrafficControlService;
	}

	protected TrafficControlServiceType(): base()
	{}

}

///<summary>
///Nautical information about a related area or facility. Constraint: If Regulations.textContent is populated, there cannot be textualDescription or information attributes directly bound to the Regulations.. A similar constraint applies to the information types Recommendations, Restrictions, and NauticalInformation.
///</summary>
public class NauticalInformationType : AbstractRXNType { 


	public NauticalInformationType( gml.ID id) : base( id)
	{
	}

	protected NauticalInformationType(): base()
	{}

}

///<summary>
///Days when many services are not available. Often days of festivity or recreation when normal working hours are limited, esp. a national or religious festival, etc.
///</summary>
public class NonStandardWorkingDayType : InformationTypeType { 

	public S100_TruncatedDate[] fixedDate;
	public string[] variableDate;
	public informationType[] information;

	public NonStandardWorkingDayType( gml.ID id) : base( id)
	{
	}

	protected NonStandardWorkingDayType(): base()
	{}

}

///<summary>
///Association class for associations describing whether the subsets of vessels determined by the ship characteristics specified in APPLIC may (or must, etc.) transit, enter, or use a feature.
///</summary>
public class PermissionType : InformationTypeType { 

	public categoryOfRelationshipType categoryOfRelationship;
	public ReferenceType[] vslLocation;
	public ReferenceType[] permission;

	public PermissionType( categoryOfRelationshipType categoryOfRelationship, ReferenceType[] vslLocation, ReferenceType[] permission, gml.ID id) : base( id)
	{
		this.categoryOfRelationship=categoryOfRelationship;
		this.vslLocation=vslLocation;
		this.permission=permission;
	}

	protected PermissionType(): base()
	{}

}

///<summary>
///Association class specifying the relationship between the subset of vessels described by an APPLIC data object and a regulation (restriction, recommendation, or nautical information).
///</summary>
public class InclusionType : InformationTypeType { 

	public membershipType membership;
	public ReferenceType[] theApplicableRxN;
	public ReferenceType[] isApplicableTo;

	public InclusionType( membershipType membership, ReferenceType[] theApplicableRxN, ReferenceType[] isApplicableTo, gml.ID id) : base( id)
	{
		this.membership=membership;
		this.theApplicableRxN=theApplicableRxN;
		this.isApplicableTo=isApplicableTo;
	}

	protected InclusionType(): base()
	{}

}

///<summary>
///Recommendations for a related area or facility. Constraint: If Regulations.textContent is populated, there cannot be textualDescription or information attributes directly bound to the Regulations.. A similar constraint applies to the information types Recommendations, Restrictions, and NauticalInformation.
///</summary>
public class RecommendationsType : AbstractRXNType { 


	public RecommendationsType( gml.ID id) : base( id)
	{
	}

	protected RecommendationsType(): base()
	{}

}

///<summary>
///Regulations for a related area or facility. Constraint: If Regulations.textContent is populated, there cannot be textualDescription or information attributes directly bound to the Regulations.. A similar constraint applies to the information types Recommendations, Restrictions, and NauticalInformation.
///</summary>
public class RegulationsType : AbstractRXNType { 


	public RegulationsType( gml.ID id) : base( id)
	{
	}

	protected RegulationsType(): base()
	{}

}

///<summary>
///A specified area of land or water designated by an appropriate authority within which access or navigation is restricted in accordance with certain specified conditions. A navigational restricted area is an area where the restrictions have a direct impact on the navigation of a vessel in the area.
///</summary>
public class RestrictedAreaNavigationalType : FeatureType { 

	public categoryOfRestrictedAreaType[] categoryOfRestrictedArea;
	public restrictionType[] restriction;
	public statusType[] status;
	public GM_Surface[] geometry;

	public RestrictedAreaNavigationalType( restrictionType[] restriction, gml.ID id) : base( id)
	{
		this.restriction=restriction;
	}

	protected RestrictedAreaNavigationalType(): base()
	{}

}

///<summary>
///A specified area of land or water designated by an appropriate authority within which access or navigation is restricted in accordance with certain specified conditions. A regulatory restricted area is an area where the restrictions have no direct impact on the navigation of a vessel in the area, but impact on the activities that can take place within the area.
///</summary>
public class RestrictedAreaRegulatoryType : FeatureType { 

	public categoryOfRestrictedAreaType[] categoryOfRestrictedArea;
	public restrictionType[] restriction;
	public statusType[] status;
	public GM_Surface[] geometry;

	public RestrictedAreaRegulatoryType( restrictionType[] restriction, gml.ID id) : base( id)
	{
		this.restriction=restriction;
	}

	protected RestrictedAreaRegulatoryType(): base()
	{}

}

///<summary>
///Restrictions for a related area or facility. Constraint: If Regulations.textContent is populated, there cannot be textualDescription or information attributes directly bound to the Regulations.. A similar constraint applies to the information types Recommendations, Restrictions, and NauticalInformation.
///</summary>
public class RestrictionsType : AbstractRXNType { 


	public RestrictionsType( gml.ID id) : base( id)
	{
	}

	protected RestrictionsType(): base()
	{}

}

///<summary>
///The time when a service is available and known exceptions.
///</summary>
public class ServiceHoursType : InformationTypeType { 

	public scheduleByDoWType[] scheduleByDoW;
	public informationType[] information;
	public ReferenceType[] partialWorkingDay;

	public ServiceHoursType( scheduleByDoWType[] scheduleByDoW, gml.ID id) : base( id)
	{
		this.scheduleByDoW=scheduleByDoW;
	}

	protected ServiceHoursType(): base()
	{}

}

///<summary>
///This describes how a ship should report to a maritime authority, including when to report, what to report and whether the format conforms to the IMO standard.
///</summary>
public class ShipReportType : InformationTypeType { 

	public categoryOfShipReportType[] categoryOfShipReport;
	public boolean imoFormatForReporting;
	public ReferenceType[] reportTo;
	public noticeTimeType[] noticeTime;
	public textContentType textContent;
	public ReferenceType[] mustBeFiledBy;

	public ShipReportType( categoryOfShipReportType[] categoryOfShipReport, boolean imoFormatForReporting, ReferenceType[] reportTo, noticeTimeType[] noticeTime, gml.ID id) : base( id)
	{
		this.categoryOfShipReport=categoryOfShipReport;
		this.imoFormatForReporting=imoFormatForReporting;
		this.reportTo=reportTo;
		this.noticeTime=noticeTime;
	}

	protected ShipReportType(): base()
	{}

}

///<summary>
///The complex attribute provides the name of an entity, defines the national language of the name, and provides the option to display the name at various system display settings.
///</summary>
public class featureNameType { 

	public boolean displayName;
	public ISO639_3 language;
	public string name;

	public featureNameType( string name)
	{
		this.name=name;
	}

	protected featureNameType(): base()
	{}

}

///<summary>
///Describes a single fixed period, as the date range between its sub-attributes. Remarks: Sub-attributes date end and date start must have the calendar year encoded using 4 digits for the calendar year (CCYY). Month (MM) and day (DD) are optional. (This definition merges the planned S-100 temporal model with the current S-101 DCEG definition of fixed date range.)
///</summary>
public class fixedDateRangeType { 

	public S100_TruncatedDate dateStart;
	public S100_TruncatedDate dateEnd;

	public fixedDateRangeType()
	{
	}

}

///<summary>
///A pair of frequencies for transmitting and receiving radio signals. The shore station transmits and receives on the frequencies indicated
///</summary>
public class frequencyPairType { 

	public string[] contactInstructions;
	public CATFRPType[] categoryOfChannelOrFrequencyPreference;
	public positiveInteger[] frequencyShoreStationTransmits;
	public positiveInteger[] frequencyShoreStationReceives;
	public textContentType[] textContent;

	public frequencyPairType()
	{
	}

}

///<summary>
///Describes the nature and timings of a daily schedule by days of the week.
///</summary>
public class scheduleByDoWType { 

	public categoryOfScheduleType categoryOfSchedule;
	public tmIntervalsByDoW[] tmIntervalsByDoW;

	public scheduleByDoWType( tmIntervalsByDoW[] tmIntervalsByDoW)
	{
		this.tmIntervalsByDoW=tmIntervalsByDoW;
	}

	protected scheduleByDoWType(): base()
	{}

}

///<summary>
///Time intervals by days of the week.
///</summary>
public class tmIntervalsByDoW { 

	public dayOfWeekType[] dayOfWeek;
	public boolean dayOfWeekIsRanges;
	public timeReferenceType timeReference;
	public time[] timeOfDayStart;
	public time[] timeOfDayEnd;

	public tmIntervalsByDoW( boolean dayOfWeekIsRanges, timeReferenceType timeReference)
	{
		this.dayOfWeekIsRanges=dayOfWeekIsRanges;
		this.timeReference=timeReference;
	}

	protected tmIntervalsByDoW(): base()
	{}

}

///<summary>
///no description available
///</summary>
public class noticeTimeType { 

	public decimal[] noticeTimeHours;
	public string noticeTimeText;
	public operationType operation;

	public noticeTimeType()
	{
	}

}

///<summary>
///This complex attribute describes the active period for a seasonal feature or information type.
///</summary>
public class periodicDateRangeType { 

	public S100_TruncatedDate dateStart;
	public S100_TruncatedDate dateEnd;

	public periodicDateRangeType( S100_TruncatedDate dateStart, S100_TruncatedDate dateEnd)
	{
		this.dateStart=dateStart;
		this.dateEnd=dateEnd;
	}

	protected periodicDateRangeType(): base()
	{}

}

///<summary>
///A summary of the impact of the most common types of regulation, restriction, recommendation and nautical information on a vessel.
///</summary>
public class rxnCodeType { 

	public categoryOfRxNType categoryOfRxN;
	public actionOrActivityType actionOrActivity;
	public string headline;

	public rxnCodeType()
	{
	}

}

///<summary>
///Content of featureName is source authority name
///</summary>
public class sourceIndicationType { 

	public categoryOfAuthorityType categoryOfAuthority;
	public string country;
	public featureNameType[] featureName;
	public S100_TruncatedDate reportedDate;
	public string source;
	public sourceTypeType sourceType;

	public sourceIndicationType()
	{
	}

}

///<summary>
///no description available
///</summary>
public class vesselsMeasurementsType { 

	public comparisonOperatorType comparisonOperator;
	public vesselsCharacteristicsType vesselsCharacteristics;
	public string vesselsCharacteristicsValue;
	public vesselsCharacteristicsUnitType vesselsCharacteristicsUnit;

	public vesselsMeasurementsType( comparisonOperatorType comparisonOperator, vesselsCharacteristicsType vesselsCharacteristics, string vesselsCharacteristicsValue, vesselsCharacteristicsUnitType vesselsCharacteristicsUnit)
	{
		this.comparisonOperator=comparisonOperator;
		this.vesselsCharacteristics=vesselsCharacteristics;
		this.vesselsCharacteristicsValue=vesselsCharacteristicsValue;
		this.vesselsCharacteristicsUnit=vesselsCharacteristicsUnit;
	}

	protected vesselsMeasurementsType(): base()
	{}

}

///<summary>
///Information on how to reach a person or organisation by postal, internet, telephone, telex and radio systems.
///</summary>
public class ContactDetailsType : InformationTypeType { 

	public string callName;
	public string callSign;
	public CATFRPType categoryOfChannelOrFrequencyPreference;
	public string[] communicationChannel;
	public contactAddressType[] contactAddress;
	public string contactInstructions;
	public frequencyPairType[] frequencyPair;
	public informationType[] information;
	public nonNegativeInteger mMSICode;
	public onlineResourceType[] onlineResource;
	public telecommunicationsType[] telecommunications;

	public ContactDetailsType( gml.ID id) : base( id)
	{
	}

	protected ContactDetailsType(): base()
	{}

}

///<summary>
///Direction or superscription of a letter, package, etc., specifying the name of the place to which it is directed, and optionally a contact person or organisation who should receive it. (Oxford English Dictionary, 2nd Ed., adapted).
///</summary>
public class contactAddressType { 

	public string[] deliveryPoint;
	public string cityName;
	public string administrativeDivision;
	public string country;
	public string postalCode;

	public contactAddressType()
	{
	}

}

///<summary>
///A means or channel of communication at a distance by electrical, electronic, or electromagnetic means such as telegraphy, telephony, or broadcasting
///</summary>
public class telecommunicationsType { 

	public string telecommunicationIdentifier;
	public string telcomCarrier;
	public string contactInstructions;
	public telecommunicationServiceType[] telecommunicationService;

	public telecommunicationsType( string telecommunicationIdentifier)
	{
		this.telecommunicationIdentifier=telecommunicationIdentifier;
	}

	protected telecommunicationsType(): base()
	{}

}

///<summary>
///Provides textual information that cannot be provided using other allowable attributes for the feature, in a defined language. The information may be provided as a string in sub-attribute text, or by encoding the file name of a single external text file that contains the text in sub-attribute file reference.
///</summary>
public class informationType { 

	public string fileLocator;
	public string fileReference;
	public string headline;
	public string language;
	public string text;

	public informationType()
	{
	}

}

///<summary>
///Remarks: - Exactly one of sub-attributes onlineResource or information must be completed in one instance of textContent. - Product specifications may restrict the use or content of onlineResource for security. For example, a product specification may forbid populating onlineResource. - Product specification authors must consider whether applications using the data product may be prevented from accessing off-system resources by security policies.
///</summary>
public class textContentType { 

	public categoryOfTextType categoryOfText;
	public informationType[] information;
	public onlineResourceType onlineResource;
	public sourceIndicationType sourceIndication;

	public textContentType()
	{
	}

}

///<summary>
///A bearing is the direction one object is from another object. At least one of the sub-attributes must be present.
///</summary>
public class bearingInformationType { 

	public cardinalDirectionType cardinalDirection;
	public string distance;
	public informationType[] information;
	public orientationType orientation;
	public decimal[] sectorBearing;

	public bearingInformationType()
	{
	}

}

///<summary>
///no description available
///</summary>
public class orientationType { 

	public string orientationUncertainty;
	public decimal orientationValue;

	public orientationType( decimal orientationValue)
	{
		this.orientationValue=orientationValue;
	}

	protected orientationType(): base()
	{}

}

///<summary>
///Generalized feature type which carry all the common attributes
///</summary>
public abstract class MetaFeatureType : S100.AbstractFeatureType { 


	protected MetaFeatureType( gml.ID id) : base( id)
	{
	}

	protected MetaFeatureType(): base()
	{}

}

///<summary>
///Definition required
///</summary>
public class horizontalPositionalUncertainty { 

	public decimal uncertaintyFixed;
	public decimal uncertaintyVariable;

	public horizontalPositionalUncertainty( decimal uncertaintyFixed)
	{
		this.uncertaintyFixed=uncertaintyFixed;
	}

	protected horizontalPositionalUncertainty(): base()
	{}

}

///<summary>
///The complex attribute describes the period of the hydrographic survey, as the time between its sub-attributes.
///</summary>
public class surveyDateRangeType { 

	public S100_TruncatedDate dateStart;
	public S100_TruncatedDate dateEnd;

	public surveyDateRangeType( S100_TruncatedDate dateStart, S100_TruncatedDate dateEnd)
	{
		this.dateStart=dateStart;
		this.dateEnd=dateEnd;
	}

	protected surveyDateRangeType(): base()
	{}

}

///<summary>
///Abstract feature type for data quality meta-features
///</summary>
public abstract class DataQualityType : MetaFeatureType { 

	public informationType[] information;

	protected DataQualityType( gml.ID id) : base( id)
	{
	}

	protected DataQualityType(): base()
	{}

}

///<summary>
///Abstract type for meta-feature which can describe temporal variation.
///</summary>
public abstract class QualityOfTemporalVariationType : DataQualityType { 

	public categoryOfTemporalVariationType categoryOfTemporalVariation;
	public dataAssessmentType dataAssessment;

	protected QualityOfTemporalVariationType( categoryOfTemporalVariationType categoryOfTemporalVariation, dataAssessmentType dataAssessment, gml.ID id) : base( id)
	{
		this.categoryOfTemporalVariation=categoryOfTemporalVariation;
		this.dataAssessment=dataAssessment;
	}

	protected QualityOfTemporalVariationType(): base()
	{}

}

///<summary>
///A geographical area that describes the coverage and extent of spatial types.
///</summary>
public class DataCoverageType : MetaFeatureType { 

	public positiveInteger maximumDisplayScale;
	public positiveInteger minimumDisplayScale;
	public SurfacePropertyType geometry;

	public DataCoverageType( positiveInteger maximumDisplayScale, positiveInteger minimumDisplayScale, SurfacePropertyType geometry, gml.ID id) : base( id)
	{
		this.maximumDisplayScale=maximumDisplayScale;
		this.minimumDisplayScale=minimumDisplayScale;
		this.geometry=geometry;
	}

	protected DataCoverageType(): base()
	{}

}

///<summary>
///An area within which a uniform assessment of the quality of the non-bathymetric data exists. (Adapted from S-57 Edition 3.1, Appendix A – Chapter 1, Page 1.208, November 2000).
///</summary>
public class QualityOfNonBathymetricDataType : QualityOfTemporalVariationType { 

	public string[] horizontalDistanceUncertainty;
	public horizontalPositionalUncertainty horizontalPositionalUncertainty;
	public string directionUncertainty;
	public sourceIndicationType sourceIndication;
	public surveyDateRangeType surveyDateRange;
	public SurfacePropertyType[] geometry;

	public QualityOfNonBathymetricDataType( SurfacePropertyType[] geometry, categoryOfTemporalVariationType categoryOfTemporalVariation, dataAssessmentType dataAssessment, gml.ID id) : base( categoryOfTemporalVariation, dataAssessment, id)
	{
		this.geometry=geometry;
	}

	protected QualityOfNonBathymetricDataType(): base()
	{}

}

///<summary>
///no description available
///</summary>
public class SpatialQuality : InformationTypeType { 

	public categoryOfTemporalVariationType categoryOfTemporalVariation;
	public horizontalPositionalUncertainty horizontalPositionalUncertainty;
	public QUAPOSType qualityOfHorizontalMeasurement;

	public SpatialQuality( gml.ID id) : base( id)
	{
	}

	protected SpatialQuality(): base()
	{}

}

///<summary>
///Definition required
///</summary>
public class SpatialQualityPoints : SpatialQuality { 


	public SpatialQualityPoints( gml.ID id) : base( id)
	{
	}

	protected SpatialQualityPoints(): base()
	{}

}

///<summary>
///The Text Placement feature is used in association with the FeatureName attribute or a light description to optimise text positioning in ECDIS.
///</summary>
public class TextPlacement { 

	public decimal flipBearing;
	public integer scaleMinimum;
	public textJustificationType textJustification;
	public string text;
	public textTypeType textType;
	public GM_Point[] geometry;

	public TextPlacement( textJustificationType textJustification, GM_Point[] geometry)
	{
		this.textJustification=textJustification;
		this.geometry=geometry;
	}

	protected TextPlacement(): base()
	{}

}

///<summary>
///Dataset element for MPA dataset as "GML document"
///</summary>
public class DatasetType : gml.AbstractFeatureType { 

	public DataSetIdentificationType DatasetIdentificationInformation;
	public DataSetStructureInformationType DatasetStructureInformation;
	public IMemberType[] imember;
	public MemberType[] member;

	public DatasetType( gml.ID id) : base( id)
	{
	}

	protected DatasetType(): base()
	{}

}

///<summary>
///dataset member
///</summary>
public class MemberType : gml.AbstractFeatureMemberType { 


	public MemberType( gml.boolean owns) : base( owns)
	{
	}

	protected MemberType(): base()
	{}

}

///<summary>
///dataset member S-100 infotmation types
///</summary>
public class IMemberType : gml.AbstractFeatureMemberType { 


	public IMemberType( gml.boolean owns) : base( owns)
	{
	}

	protected IMemberType(): base()
	{}

}

///<summary>
///no description available
///</summary>
public class GenericFeatureType : S100.AbstractFeatureType { 


	public GenericFeatureType( gml.ID id) : base( id)
	{
	}

	protected GenericFeatureType(): base()
	{}

}

///<summary>
//////<summary> ///(Type)Describes the relationship between vessel characteristics and: (i) the applicability of an associated information object or feature to the vessel; or, (ii) the use of a facility, place, or service by the vessel; or, (iii) passage of the vessel through an area. (Element) ///</summary>
///</summary>
public class Applicability : ApplicabilityType { 


	public Applicability( gml.ID id) : base( id)
	{
	}

	protected Applicability(): base()
	{}

}

///<summary>
//////<summary> ///(Type)A person or organisation having political or administrative power and control. (Oxford Dictionary of English) (Element) ///</summary>
///</summary>
public class Authority : AuthorityType { 


	public Authority( categoryOfAuthorityType categoryOfAuthority, gml.ID id) : base( categoryOfAuthority, id)
	{
	}

	protected Authority(): base()
	{}

}
//FeatureType refers same name

///<summary>
//////<summary> ///(Type)Generalized information type which carry all the common attributes(Element) ///</summary>
///</summary>
public abstract class InformationType : InformationTypeType { 


	protected InformationType( gml.ID id) : base( id)
	{
	}

	protected InformationType(): base()
	{}

}

///<summary>
//////<summary> ///(Type)Any area of the intertidal or sub tidal terrain, together with its overlying water and associated flora, fauna, historical and cultural features, which has been reserved by law or other effective means to protect part or all of the enclosed environment. (IUCN – The World Conservation Union. 1998. Resolution 17.38 of the 17th General Assembly of the IUCN. Gland, Switzerland and Cambridge, UK.) (Element) ///</summary>
///</summary>
public class MarineProtectedArea : MarineProtectedAreaType { 


	public MarineProtectedArea( categoryOfMarineProtectedAreaType categoryOfMarineProtectedArea, jurisdictionType jurisdiction, gml.ID id) : base( categoryOfMarineProtectedArea, jurisdiction, id)
	{
	}

	protected MarineProtectedArea(): base()
	{}

}

///<summary>
//////<summary> ///(Type)A service implemented by a relevant authority for shipping, e.g. traffic control, information, assistance.(Element) ///</summary>
///</summary>
public class TrafficControlService : TrafficControlServiceType { 


	public TrafficControlService( categoryOfTrafficControlServiceType categoryOfTrafficControlService, gml.ID id) : base( categoryOfTrafficControlService, id)
	{
	}

	protected TrafficControlService(): base()
	{}

}

///<summary>
//////<summary> ///(Type)Nautical information about a related area or facility. Constraint: If Regulations.textContent is populated, there cannot be textualDescription or information attributes directly bound to the Regulations.. A similar constraint applies to the information types Recommendations, Restrictions, and NauticalInformation.(Element) ///</summary>
///</summary>
public class NauticalInformation : NauticalInformationType { 


	public NauticalInformation( gml.ID id) : base( id)
	{
	}

	protected NauticalInformation(): base()
	{}

}

///<summary>
//////<summary> ///(Type)Days when many services are not available. Often days of festivity or recreation when normal working hours are limited, esp. a national or religious festival, etc. (Element) ///</summary>
///</summary>
public class NonStandardWorkingDay : NonStandardWorkingDayType { 


	public NonStandardWorkingDay( gml.ID id) : base( id)
	{
	}

	protected NonStandardWorkingDay(): base()
	{}

}
//PermissionType refers same name
//InclusionType refers same name

///<summary>
//////<summary> ///(Type)Recommendations for a related area or facility. Constraint: If Regulations.textContent is populated, there cannot be textualDescription or information attributes directly bound to the Regulations.. A similar constraint applies to the information types Recommendations, Restrictions, and NauticalInformation.(Element) ///</summary>
///</summary>
public class Recommendations : RecommendationsType { 


	public Recommendations( gml.ID id) : base( id)
	{
	}

	protected Recommendations(): base()
	{}

}

///<summary>
//////<summary> ///(Type)Regulations for a related area or facility. Constraint: If Regulations.textContent is populated, there cannot be textualDescription or information attributes directly bound to the Regulations.. A similar constraint applies to the information types Recommendations, Restrictions, and NauticalInformation. (Element) ///</summary>
///</summary>
public class Regulations : RegulationsType { 


	public Regulations( gml.ID id) : base( id)
	{
	}

	protected Regulations(): base()
	{}

}

///<summary>
//////<summary> ///(Type)A specified area of land or water designated by an appropriate authority within which access or navigation is restricted in accordance with certain specified conditions. A navigational restricted area is an area where the restrictions have a direct impact on the navigation of a vessel in the area.(Element) ///</summary>
///</summary>
public class RestrictedAreaNavigational : RestrictedAreaNavigationalType { 


	public RestrictedAreaNavigational( restrictionType[] restriction, gml.ID id) : base( restriction, id)
	{
	}

	protected RestrictedAreaNavigational(): base()
	{}

}

///<summary>
//////<summary> ///(Type)A specified area of land or water designated by an appropriate authority within which access or navigation is restricted in accordance with certain specified conditions. A regulatory restricted area is an area where the restrictions have no direct impact on the navigation of a vessel in the area, but impact on the activities that can take place within the area.(Element) ///</summary>
///</summary>
public class RestrictedAreaRegulatory : RestrictedAreaRegulatoryType { 


	public RestrictedAreaRegulatory( restrictionType[] restriction, gml.ID id) : base( restriction, id)
	{
	}

	protected RestrictedAreaRegulatory(): base()
	{}

}

///<summary>
//////<summary> ///(Type)Restrictions for a related area or facility. Constraint: If Regulations.textContent is populated, there cannot be textualDescription or information attributes directly bound to the Regulations.. A similar constraint applies to the information types Recommendations, Restrictions, and NauticalInformation.(Element) ///</summary>
///</summary>
public class Restrictions : RestrictionsType { 


	public Restrictions( gml.ID id) : base( id)
	{
	}

	protected Restrictions(): base()
	{}

}

///<summary>
//////<summary> ///(Type)The time when a service is available and known exceptions. (Element) ///</summary>
///</summary>
public class ServiceHours : ServiceHoursType { 


	public ServiceHours( scheduleByDoWType[] scheduleByDoW, gml.ID id) : base( scheduleByDoW, id)
	{
	}

	protected ServiceHours(): base()
	{}

}

///<summary>
//////<summary> ///(Type)This describes how a ship should report to a maritime authority, including when to report, what to report and whether the format conforms to the IMO standard. (Element) ///</summary>
///</summary>
public class ShipReport : ShipReportType { 


	public ShipReport( categoryOfShipReportType[] categoryOfShipReport, boolean imoFormatForReporting, ReferenceType[] reportTo, noticeTimeType[] noticeTime, gml.ID id) : base( categoryOfShipReport, imoFormatForReporting, reportTo, noticeTime, id)
	{
	}

	protected ShipReport(): base()
	{}

}

///<summary>
//////<summary> ///(Type)Information on how to reach a person or organisation by postal, internet, telephone, telex and radio systems. (Element) ///</summary>
///</summary>
public class ContactDetails : ContactDetailsType { 


	public ContactDetails( gml.ID id) : base( id)
	{
	}

	protected ContactDetails(): base()
	{}

}
//MetaFeatureType refers same name

///<summary>
//////<summary> ///(Type)Abstract feature type for data quality meta-features(Element) ///</summary>
///</summary>
public abstract class DataQuality : DataQualityType { 


	protected DataQuality( gml.ID id) : base( id)
	{
	}

	protected DataQuality(): base()
	{}

}
//QualityOfTemporalVariationType refers same name

///<summary>
//////<summary> ///(Type)A geographical area that describes the coverage and extent of spatial types.(Element) ///</summary>
///</summary>
public class DataCoverage : DataCoverageType { 


	public DataCoverage( positiveInteger maximumDisplayScale, positiveInteger minimumDisplayScale, SurfacePropertyType geometry, gml.ID id) : base( maximumDisplayScale, minimumDisplayScale, geometry, id)
	{
	}

	protected DataCoverage(): base()
	{}

}

///<summary>
//////<summary> ///(Type)An area within which a uniform assessment of the quality of the non-bathymetric data exists. (Adapted from S-57 Edition 3.1, Appendix A – Chapter 1, Page 1.208, November 2000).(Element) ///</summary>
///</summary>
public class QualityOfNonBathymetricData : QualityOfNonBathymetricDataType { 


	public QualityOfNonBathymetricData( SurfacePropertyType[] geometry, categoryOfTemporalVariationType categoryOfTemporalVariation, dataAssessmentType dataAssessment, gml.ID id) : base( geometry, categoryOfTemporalVariation, dataAssessment, id)
	{
	}

	protected QualityOfNonBathymetricData(): base()
	{}

}
//SpatialQuality refers same name
//SpatialQualityPoints refers same name
//TextPlacement refers same name

///<summary>
//////<summary> ///(Type)Dataset element for MPA dataset as "GML document"(Element) ///</summary>
///</summary>
public class DataSet : DatasetType { 


	public DataSet( gml.ID id) : base( id)
	{
	}

	protected DataSet(): base()
	{}

}

}

