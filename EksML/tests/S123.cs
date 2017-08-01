//EksML - S100 application schema to csCode 1.6.2017 17:14:42

using System;
using System.ComponentModel;

using gml;


namespace S123 {


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
}

///<summary>
///Minutes of an hour.
///</summary>

public struct minutesOfHourType {
		private duration VALUE;
		public static implicit operator duration( minutesOfHourType value ) {
		return value.VALUE;
	}
	
	public static implicit operator minutesOfHourType( duration value ) {
		var _ReturnValue = new minutesOfHourType();
		_ReturnValue.VALUE = value;
		return _ReturnValue;
	}
}

///<summary>
///Type for NAVTEX transmitter identification character
///</summary>

public struct txIdentCharType {
		private string VALUE;
		public static implicit operator string( txIdentCharType value ) {
		return value.VALUE;
	}
	
	public static implicit operator txIdentCharType( string value ) {
		var _ReturnValue = new txIdentCharType();
		_ReturnValue.VALUE = value;
		return _ReturnValue;
	}
}

///<summary>
///Classification of broadcast or communications based on public availability and commercial/non-commercial nature.
///</summary>
public enum categoryOfBroadcastCommunicationType { 
	///<summary>
	///A service operated with the intention of earning money
	///</summary>
	[Description("commercial")]
	commercial=1,
	///<summary>
	///A service without any financial interest
	///</summary>
	[Description("non-commercial")]
	non_commercial=2,
	///<summary>
	///A service available for the general community
	///</summary>
	[Description("public")]
	_public=3,
	///<summary>
	///A service available for limited and pre-defined customers
	///</summary>
	[Description("non-public")]
	non_public=4
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
///Classification of frequencies, VHF channels, telephone numbers, or other means of communication based on preference.
///</summary>
public enum categoryOfCommPrefType { 
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
///Classification of weather forecast and weather warning areas based on source of warnings and forecasts.
///</summary>
public enum categoryOfFrcstAndWarningAreaType { 
	///<summary>
	///The forecast and warning area defined by WMO
	///</summary>
	[Description("World Meteorological Organization (WMO)")]
	World_Meteorological_Organization__WMO_=1,
	///<summary>
	///The forecast and warning area defined by national authorities covering High Seas
	///</summary>
	[Description("National high seas")]
	National_high_seas=2,
	///<summary>
	///The forecast and warning area defined by national authorities covering offshore waters.
	///</summary>
	[Description("National offshore")]
	National_offshore=3,
	///<summary>
	///The forecast and warning area defined by national authorities covering coastal waters.
	///</summary>
	[Description("National coastal")]
	National_coastal=4,
	///<summary>
	///The forecast and warning area defined by national authorities covering inshore waters.
	///</summary>
	[Description("National inshore")]
	National_inshore=5,
	///<summary>
	///The forecast and warning area defined by national authorities covering local waters.
	///</summary>
	[Description("National local")]
	National_local=6,
	///<summary>
	///The ice forecast area defined by international or national authorities.
	///</summary>
	[Description("Ice")]
	Ice=7
}

///<summary>
///Classification of GMDSS areas based on availability of GMDSS services and GMDSS equipment requirements.
///</summary>
public enum categoryOfGMDSSAreaType { 
	///<summary>
	///Within range of VHF coast stations with continuous DSC alerting available (about 20 – 30 miles)
	///</summary>
	[Description("Area A1")]
	Area_A1=1,
	///<summary>
	///Beyond area A1, but within range of MF coastal stations with continuous DSC alerting available (about l00 miles)
	///</summary>
	[Description("Area A2")]
	Area_A2=2,
	///<summary>
	///Beyond the first two areas, but within coverage of geostationary maritime communication satellites (in practice this means Inmarsat). This covers the area between roughly 70 deg N and 70 deg S.
	///</summary>
	[Description("Area A3")]
	Area_A3=3,
	///<summary>
	///The remaining sea areas. The most important of these is the sea around the North Pole (the area around the South Pole is mostly land). Geostationary satellites, which are positioned above the equator, cannot reach this far.
	///</summary>
	[Description("Area A4")]
	Area_A4=4
}

///<summary>
///Classification of prominent cultural and natural features in the landscape. S-123 Note: Only landmarks of relevance to radiocommunications are encoded in S-123 datasets, e.g., radio masts used for marine broadcasts if their location needs to be shown
///</summary>
public enum categoryOfLandmarkType { 
	///<summary>
	///A parabolic aerial for the receipt and transmission of high frequency radio signals. (IHO Dictionary – S-32).
	///</summary>
	[Description("dish aerial")]
	dish_aerial=1,
	///<summary>
	///A relatively tall structure usually held vertical by guy lines. (S-57 Edition 3.1, Appendix A – Chapter 2, Page 2.45, November 2000).
	///</summary>
	[Description("mast")]
	mast=2,
	///<summary>
	///A relatively tall, narrow structure that may either stand alone or may form part of another structure. (Defence Geospatial Information Working Group; Feature Data Dictionary Register, 2010).
	///</summary>
	[Description("tower")]
	tower=3
}

///<summary>
///Classification of maritime broadcast based on the nature of information conveyed.
///</summary>
public enum categoryOfMaritimeBroadcastType { 
	///<summary>
	///message containing urgent information relevant to safe navigation broadcast to ships in accordance with the provisions of the International Convention for the Safety of Life at Sea, 1974, as amended
	///</summary>
	[Description("navigational warning")]
	navigational_warning=1,
	///<summary>
	///warning of adverse weather conditions
	///</summary>
	[Description("meteorological warning")]
	meteorological_warning=2,
	///<summary>
	///report of the ice situation and restrictions to shipping
	///</summary>
	[Description("ice report")]
	ice_report=3,
	///<summary>
	///broadcast message with information about an ongoing SAR operation
	///</summary>
	[Description("SAR information")]
	SAR_information=4,
	///<summary>
	///warning of possible attack by pirates
	///</summary>
	[Description("pirate attack warning")]
	pirate_attack_warning=5,
	///<summary>
	///broadcast message containing meteorological forecast
	///</summary>
	[Description("meteorological forecast")]
	meteorological_forecast=6,
	///<summary>
	///broadcast message about pilot service
	///</summary>
	[Description("pilot service message")]
	pilot_service_message=7,
	///<summary>
	///broadcast message about AIS information
	///</summary>
	[Description("AIS information")]
	AIS_information=8,
	///<summary>
	///broadcast message about the LORAN service
	///</summary>
	[Description("LORAN message")]
	LORAN_message=9,
	///<summary>
	///broadcast message about Satellite Navigation service
	///</summary>
	[Description("SATNAV message")]
	SATNAV_message=10,
	///<summary>
	///warning of winds of Beaufort force 8 or 9
	///</summary>
	[Description("gale warning")]
	gale_warning=11,
	///<summary>
	///warning of winds of Beaufort force 10 or over
	///</summary>
	[Description("storm warning")]
	storm_warning=12,
	///<summary>
	///warning of hurricanes in the North Atlantic and eastern North Pacific, typhoons in the Western Pacific, cyclones in the Indian Ocean and cyclones of similar nature in other regions
	///</summary>
	[Description("tropical revolving storm warning")]
	tropical_revolving_storm_warning=13,
	///<summary>
	///navigational warning or in-force bulletin promulgated as part of a numbered series by a NAVAREA coordinator (Maritime Safety Information Manual 2009)
	///</summary>
	[Description("NAVAREA warning")]
	NAVAREA_warning=14,
	///<summary>
	///navigational warning promulgated as part of a numbered series by a National coordinator (Maritime Safety Information Manual 2009)
	///</summary>
	[Description("coastal warning")]
	coastal_warning=15,
	///<summary>
	///warning which covers inshore waters, often within the limits of jurisdiction of a harbour or port authority (Maritime Safety Information Manual 2009)
	///</summary>
	[Description("local warning")]
	local_warning=16,
	///<summary>
	///warning of actual or expected low water level
	///</summary>
	[Description("low water level warning/negative tidal surge")]
	low_water_level_warning_negative_tidal_surge=17,
	///<summary>
	///warning of accretion of ice on ships
	///</summary>
	[Description("icing warning")]
	icing_warning=18,
	///<summary>
	///broadcasts about tsunamis, including watches, advisories, and other types of messages relating to tsunamis or potential tsunamis
	///</summary>
	[Description("tsunami broadcast")]
	tsunami_broadcast=19
}

///<summary>
///Categories of radiocommunications based on frequency band and radio traffic method.
///</summary>
public enum categoryOfRadioMethodsType { 
	///<summary>
	///Frequency in a frequency range between 30 and 300 kHz used for voice traffic
	///</summary>
	[Description("Low Frequency (LF) voice traffic")]
	Low_Frequency__LF__voice_traffic=1,
	///<summary>
	///Frequency in a frequency range between 300 and 3 000kHz used for voice traffic
	///</summary>
	[Description("Medium Frequency (MF) voice traffic")]
	Medium_Frequency__MF__voice_traffic=2,
	///<summary>
	///Frequency in a frequency range between 3 and 30 MHz used for voice traffic
	///</summary>
	[Description("High Frequency (HF) voice traffic")]
	High_Frequency__HF__voice_traffic=3,
	///<summary>
	///Frequency in a frequency range between 30 and 300 MHz used for voice traffic
	///</summary>
	[Description("Very High Frequency (VHF) voice traffic")]
	Very_High_Frequency__VHF__voice_traffic=4,
	///<summary>
	///High Frequency Narrow Band Direct Printing
	///</summary>
	[Description("High Frequency Narrow Band Direct Printing")]
	High_Frequency_Narrow_Band_Direct_Printing=5,
	///<summary>
	///Narrow-band direct-printing telegraphy system for transmission of maritime safety information.
	///</summary>
	[Description("NAVTEX")]
	NAVTEX=6,
	///<summary>
	///SafetyNET is an international automatic direct-printing satellite-based service for the promulgation of navigational and meteorological warnings, meteorological forecasts and other urgent safety-related messages - maritime safety information (MSI) - to ships.
	///</summary>
	[Description("SafetyNET")]
	SafetyNET=7,
	///<summary>
	///Narrow Band Direct Printing Telegraphy. A communications system consisting of teletypewriters connected to a telephonic network to send and receive wireless signals.
	///</summary>
	[Description("NBDP Telegraphy")]
	NBDP_Telegraphy=8,
	///<summary>
	///A method or device for transmitting documents, drawings, photographs, or the like, by means of radio or telephone for exact reproduction elsewhere.
	///</summary>
	[Description("facsimile")]
	facsimile=9,
	///<summary>
	///A Russian system transmitting navigational information, send by radio and containing information relevant to coastal waters of foreign countries and high seas.
	///</summary>
	[Description("NAVIP")]
	NAVIP=10,
	///<summary>
	///Frequency in a frequency range between 30 and 300 kHz used for digital traffic
	///</summary>
	[Description("Low Frequency (LF) digital traffic")]
	Low_Frequency__LF__digital_traffic=11,
	///<summary>
	///Frequency in a frequency range between 300 and 3000kHz used for digital traffic
	///</summary>
	[Description("Medium Frequency (MF) digital traffic")]
	Medium_Frequency__MF__digital_traffic=12,
	///<summary>
	///Frequency in a frequency range between 3 and 30 MHz used for digital traffic
	///</summary>
	[Description("High Frequency (HF) digital traffic")]
	High_Frequency__HF__digital_traffic=13,
	///<summary>
	///Frequency in a frequency range between 30 and 300 MHz used for digital traffic
	///</summary>
	[Description("Very High Frequency (VHF) digital traffic")]
	Very_High_Frequency__VHF__digital_traffic=14,
	///<summary>
	///Frequency in a frequency range between 30 and 300 kHz used for telegraph traffic
	///</summary>
	[Description("Low Frequency (LF) telegraph traffic")]
	Low_Frequency__LF__telegraph_traffic=15,
	///<summary>
	///Frequency in a frequency range between 300 and 3 000kHz used for telegraph traffic
	///</summary>
	[Description("Medium Frequency (MF) telegraph traffic")]
	Medium_Frequency__MF__telegraph_traffic=16,
	///<summary>
	///Frequency in a frequency range between 3 and 30 MHz used for telegraph traffic
	///</summary>
	[Description("High Frequency (HF) telegraph traffic")]
	High_Frequency__HF__telegraph_traffic=17,
	///<summary>
	///Frequency in a frequency range between 300 and 3000kHz used for Digital Selective Call traffic
	///</summary>
	[Description("Medium Frequency (MF) Digital Selective Call traffic")]
	Medium_Frequency__MF__Digital_Selective_Call_traffic=18,
	///<summary>
	///Frequency in a frequency range between 3 and 30 MHz used for Digital Selective Call traffic
	///</summary>
	[Description("High Frequency (HF) Digital Selective Call traffic")]
	High_Frequency__HF__Digital_Selective_Call_traffic=19,
	///<summary>
	///Frequency in a frequency range between 30 and 300 MHz used for Digital Selective Call traffic
	///</summary>
	[Description("Very High Frequency (VHF) Digital Selective Call traffic")]
	Very_High_Frequency__VHF__Digital_Selective_Call_traffic=20
}

///<summary>
///Classification of radio services offered by a radio station.
///</summary>
public enum categoryOfRadioStationType { 
	///<summary>
	///A radio station intended only to determine the direction of other stations by means of transmission from the latter.
	///</summary>
	[Description("radio direction-finding station")]
	radio_direction_finding_station=1,
	///<summary>
	///The Decca Navigator System is a high-accuracy, short to medium range radio navigation aid intended for coastal and landfall navigation.
	///</summary>
	[Description("Decca")]
	Decca=2,
	///<summary>
	///A low frequency electronic position fixing system using pulsed transmissions at 100 Khz.
	///</summary>
	[Description("Loran C")]
	Loran_C=3,
	///<summary>
	///A radiobeacon transmitting DGPS correction signals.
	///</summary>
	[Description("Differential GNSS")]
	Differential_GNSS=4,
	///<summary>
	///An electronic position fixing system used mainly by aircraft.
	///</summary>
	[Description("Toran")]
	Toran=5,
	///<summary>
	///A long-range radio navigational aid which operates within the VLF frequency band. The system comprises eight land based stations.
	///</summary>
	[Description("Omega")]
	Omega=6,
	///<summary>
	///A ranging position fixing system operating at 420-450MHz over a range of up to 400 Km.
	///</summary>
	[Description("Syledis")]
	Syledis=7,
	///<summary>
	///A low frequency electronic position fixing system using pulsed transmissions at 100 Khz.
	///</summary>
	[Description("Chaika")]
	Chaika=8,
	///<summary>
	///facsimile transmission (IHO HYDRO register, 2010-11-14)
	///</summary>
	[Description("facsimile transmission")]
	facsimile_transmission=9,
	///<summary>
	///The equipment needed at one station to carry on two way voice communication by radio waves only.
	///</summary>
	[Description("radio telephone station")]
	radio_telephone_station=10,
	///<summary>
	///Remark: Not defined in GI Registry (2017-04-20).
	///</summary>
	[Description("AIS base station")]
	AIS_base_station=11
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
///A specific role that describes a feature
///</summary>
public enum functionType { 
	///<summary>
	///Transmitting and/or receiving electronic communication signals. (Defence Geospatial Information Working Group; Feature Data Dictionary Register, 2010).
	///</summary>
	[Description("communication")]
	communication=1,
	///<summary>
	///Transmitting and/or receiving radio-frequency electromagnetic waves as a means of communication. (Defence Geospatial Information Working Group; Feature Data Dictionary Register, 2010).
	///</summary>
	[Description("radio")]
	radio=2,
	///<summary>
	///Broadcasting and receiving signals using microwaves. (S-57 Edition 3.1, Appendix A – Chapter 2, Page 2.133, November 2000).
	///</summary>
	[Description("microwave")]
	microwave=3,
	///<summary>
	///Used to control the flow of traffic within a specified range of an installation. (Defence Geospatial Information Working Group; Feature Data Dictionary Register, 2010).
	///</summary>
	[Description("control")]
	control=4,
	///<summary>
	///A unit responsible for promoting efficient organization of search and rescue services and for coordinating the conduct of search and rescue operations within a search and rescue region. (Defence Geospatial Information Working Group; Feature Data Dictionary Register, 2010).
	///</summary>
	[Description("sea rescue control")]
	sea_rescue_control=5
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
public enum transmissionRegularityType { 
	///<summary>
	///transmission is made continuously
	///</summary>
	[Description("continuous")]
	continuous=1,
	///<summary>
	///transmission is made regularly according to a schedule
	///</summary>
	[Description("regular")]
	regular=2,
	///<summary>
	///transmission is made when warning or information is received from another authority
	///</summary>
	[Description("on receipt")]
	on_receipt=3,
	///<summary>
	///transmission is made under specified conditions or when needed
	///</summary>
	[Description("as required")]
	as_required=4,
	///<summary>
	///transmission is made when requested by a user
	///</summary>
	[Description("on request")]
	on_request=5
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
	///The height of the highest point of a vessel's structure (e.g. radar aerial, funnel, cranes, masthead) above her waterline.(UKHO NP100/2009)
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
	///monday - the day of the week before Tuesday and following Sunday
	///</summary>
	[Description("monday")]
	monday=1,
	///<summary>
	///the day of the week before Wednesday and following Monday
	///</summary>
	[Description("tuesday")]
	tuesday=2,
	///<summary>
	///wednesday - the day of the week before Thursday and following Tuesday
	///</summary>
	[Description("wednesday")]
	wednesday=3,
	///<summary>
	///thursday - the day of the week before Friday and following Wednesday
	///</summary>
	[Description("thursday")]
	thursday=4,
	///<summary>
	///friday - the day of the week before Saturday and following Thursday
	///</summary>
	[Description("friday")]
	friday=5,
	///<summary>
	///saturday - the day of the week before Sunday and following Friday (together with Sunday forming part of the weekend)
	///</summary>
	[Description("saturday")]
	saturday=6,
	///<summary>
	///sunday - the day of the week before Monday and following Saturday (together with Saturday forms part of the weekend)
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
	///NIPWG: Significant change at the location is not expected.
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
	[Description("oceanic")]
	oceanic=2,
	///<summary>
	///The quality of the bathymetric data has yet to be assessed.
	///</summary>
	[Description("unassessed")]
	unassessed=3
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
///The attribute from which a text string is derived.
///</summary>
public enum textTypeType { 
	///<summary>
	///Definition required
	///</summary>
	[Description("feature name")]
	feature_name=1
}

///<summary>
///The likelihood that a vessel will experience the phenomenon described by a feature, or that the service described by the feature will be available.
///</summary>
public enum informationConfidenceType { 
	///<summary>
	///Virtually certain to be experienced by (or available to) an individual vessel; will be experienced by nearly all vessels. (FAA, adapted.)
	///</summary>
	[Description("virtuallyCertain")]
	virtuallyCertain=1,
	///<summary>
	///Frequently experienced by (or available to) an individual vessel; experienced by a majority of vessels. (FAA, adapted.)
	///</summary>
	[Description("highLikelihood")]
	highLikelihood=2,
	///<summary>
	///Occasionally experienced by (or available to) an individual vessel; experienced by (or available to) about half of all vessels. (FAA, adapted.)
	///</summary>
	[Description("mediumLikelihood")]
	mediumLikelihood=3,
	///<summary>
	///Unlikely, but sometimes (rarely) experienced by (or available to) an individual vessel; experienced by (or available to) a minority of vessels). (FAA, adapted.)
	///</summary>
	[Description("lowLikelihood")]
	lowLikelihood=4
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

	public S100_TruncatedDate( gDay gDay, gMonth gMonth, gYear gYear, gMonthDay gMonthDay, gYearMonth gYearMonth, date date)
	{
		this.gDay=gDay;
		this.gMonth=gMonth;
		this.gYear=gYear;
		this.gMonthDay=gMonthDay;
		this.gYearMonth=gYearMonth;
		this.date=date;
	}

	protected S100_TruncatedDate(): base()
	{}

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
///Detailed radiocommunications description with channels, frequencies, preferences and time schedules
///</summary>
public class radiocommunicationsType { 

	public categoryOfCommPrefType categoryOfCommPref;
	public categoryOfRadioMethodsType[] categoryOfRadioMethods;
	public categoryOfMaritimeBroadcastType[] categoryOfMaritimeBroadcast;
	public string[] communicationChannel;
	public string contactInstructions;
	public facsimileDrumSpeedType facsimileDrumSpeed;
	public frequencyPairType[] frequencyPair;
	public integer selectiveCallNumber;
	public integer[] signalFrequency;
	public timeOfObservationType timeOfObservation;
	public timesOfTransmissionType timesOfTransmission;
	public string transmissionContent;
	public tmIntervalsByDoW[] tmIntervalsByDoW;
	public transmissionRegularityType[] transmissionRegularity;

	public radiocommunicationsType()
	{
	}

}

///<summary>
///Description of the type and content of a communication or broadcast from a radio station. Remark: This complex attribute is not intended for detailed descriptions of a station's radio services. For detailed descriptions of radio service, use the attributes of the associated RadioServiceArea feature.
///</summary>
public class radioStationCommunicationDescriptionType { 

	public categoryOfMaritimeBroadcastType[] categoryOfMaritimeBroadcast;
	public string[] communicationChannel;
	public nonNegativeInteger[] signalFrequency;
	public string transmissionContent;

	public radioStationCommunicationDescriptionType()
	{
	}

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
	public ReferenceType[] providesInformation;
	public ReferenceType[] theRxN;
	public ReferenceType positions;

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
///A station at which a visual/radio/radar marine watch is kept either continuously or at certain times only.
///</summary>
public class CoastguardStationType : FeatureType { 

	public string[] communicationChannel;
	public boolean isMRCC;
	public statusType[] status;
	public ReferenceType[] controlAuthority;
	public ReferenceType[] theContactDetails;
	public ReferenceType theServiceHours;
	public PointOrSurface geometry;

	public CoastguardStationType( PointOrSurface geometry, gml.ID id) : base( id)
	{
		this.geometry=geometry;
	}

	protected CoastguardStationType(): base()
	{}

}

///<summary>
///An area defined for a global communications service based upon automated systems, both satellite based and terrestrial, to provide distress alerting and promulgation of maritime safety information for mariners. (Adapted IHO Dictionary, S-32, 5th Edition, 2048)
///</summary>
public class GMDSSAreaType : FeatureType { 

	public categoryOfGMDSSAreaType categoryOfGMDSSArea;
	public ReferenceType[] controlAuthority;
	public ReferenceType[] serviceProvider;
	public GM_Surface[] geometry;

	public GMDSSAreaType( categoryOfGMDSSAreaType categoryOfGMDSSArea, GM_Surface[] geometry, gml.ID id) : base( id)
	{
		this.categoryOfGMDSSArea=categoryOfGMDSSArea;
		this.geometry=geometry;
	}

	protected GMDSSAreaType(): base()
	{}

}

///<summary>
///The ocean region of the earth’s surface, within which a station can obtain line-of-sight communication, with an Inmarsat satellite.
///</summary>
public class InmarsatOceanRegionAreaType : FeatureType { 

	public ReferenceType[] controlAuthority;
	public GM_Surface[] geometry;

	public InmarsatOceanRegionAreaType( GM_Surface[] geometry, gml.ID id) : base( id)
	{
		this.geometry=geometry;
	}

	protected InmarsatOceanRegionAreaType(): base()
	{}

}

///<summary>
///Any prominent object on land which can be used in determining a location or a direction. (IHO Dictionary – S-32). S-123 Note: Only features relevant to radio communications are encoded e.g., radio towers or radio masts. If the feature can be encoded as a radio station at the same location, a coincident Landmark must not be encoded.
///</summary>
public class LandmarkType : FeatureType { 

	public categoryOfLandmarkType[] categoryOfLandmark;
	public functionType[] function;
	public statusType[] status;
	public PointOrSurface geometry;

	public LandmarkType( categoryOfLandmarkType[] categoryOfLandmark, PointOrSurface geometry, gml.ID id) : base( id)
	{
		this.categoryOfLandmark=categoryOfLandmark;
		this.geometry=geometry;
	}

	protected LandmarkType(): base()
	{}

}

///<summary>
///The geographic areas in which various governments are responsible for navigation and weather warnings.
///</summary>
public class NavigationalMeteorologicalAreaType : FeatureType { 

	public statusType status;
	public ReferenceType[] serviceProvider;
	public ReferenceType[] controlAuthority;
	public GM_Surface[] geometry;

	public NavigationalMeteorologicalAreaType( GM_Surface[] geometry, gml.ID id) : base( id)
	{
		this.geometry=geometry;
	}

	protected NavigationalMeteorologicalAreaType(): base()
	{}

}

///<summary>
///The geographic areas in which radio stations are responsible for broadcast navigation and weather warnings.
///</summary>
public class NavtexStationAreaType : FeatureType { 

	public txIdentCharType txIdentChar;
	public restrictionType restriction;
	public statusType status;
	public ReferenceType[] serviceProvider;
	public ReferenceType[] controlAuthority;
	public GM_Surface[] geometry;

	public NavtexStationAreaType( txIdentCharType txIdentChar, GM_Surface[] geometry, gml.ID id) : base( id)
	{
		this.txIdentChar=txIdentChar;
		this.geometry=geometry;
	}

	protected NavtexStationAreaType(): base()
	{}

}

///<summary>
///The area where a radio service can be obtained and the characteristics of the radio transmission. Remarks: The objects RDOSTA; RADSTA are used to encode the point of transmission of the signal.
///</summary>
public class RadioServiceAreaType : FeatureType { 

	public string callSign;
	public categoryOfBroadcastCommunicationType categoryOfBroadcastCommunication;
	public string languageInformation;
	public radiocommunicationsType[] radiocommunications;
	public statusType status;
	public timeReferenceType timeReference;
	public NonNegativeDecimal_1 transmissionPower;
	public txIdentCharType txIdentChar;
	public boolean txTrafficList;
	public ReferenceType theServiceHours;
	public ReferenceType[] serviceProvider;
	public ReferenceType[] theContactDetails;
	public ReferenceType[] controlAuthority;
	public PointOrSurface[] geometry;

	public RadioServiceAreaType( categoryOfBroadcastCommunicationType categoryOfBroadcastCommunication, gml.ID id) : base( id)
	{
		this.categoryOfBroadcastCommunication=categoryOfBroadcastCommunication;
	}

	protected RadioServiceAreaType(): base()
	{}

}

///<summary>
///A place equipped to transmit radio waves.
///</summary>
public class RadioStationType : FeatureType { 

	public string callSign;
	public categoryOfRadioStationType categoryOfRadioStation;
	public NonNegativeDecimal estimatedRangeOfTransmission;
	public orientationType orientation;
	public radioStationCommunicationDescriptionType[] radioStationCommunicationDescription;
	public radiocommunicationsType[] radiocommunications;
	public statusType status;
	public ReferenceType theServiceHours;
	public ReferenceType[] serviceArea;
	public ReferenceType[] theContactDetails;
	public ReferenceType[] controlAuthority;
	public GM_Point geometry;

	public RadioStationType( GM_Point geometry, gml.ID id) : base( id)
	{
		this.geometry=geometry;
	}

	protected RadioStationType(): base()
	{}

}

///<summary>
///An area for which weather forecasts and warnings are provided for specified periods.
///</summary>
public class WeatherForecastWarningAreaType : FeatureType { 

	public categoryOfFrcstAndWarningAreaType categoryOfFrcstAndWarningArea;
	public string nationality;
	public statusType status;
	public ReferenceType[] serviceProvider;
	public ReferenceType[] controlAuthority;
	public GM_Surface[] geometry;

	public WeatherForecastWarningAreaType( categoryOfFrcstAndWarningAreaType categoryOfFrcstAndWarningArea, GM_Surface[] geometry, gml.ID id) : base( id)
	{
		this.categoryOfFrcstAndWarningArea=categoryOfFrcstAndWarningArea;
		this.geometry=geometry;
	}

	protected WeatherForecastWarningAreaType(): base()
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
///Recommendations for a related area or facility.
///</summary>
public class RecommendationsType : AbstractRXNType { 


	public RecommendationsType( gml.ID id) : base( id)
	{
	}

	protected RecommendationsType(): base()
	{}

}

///<summary>
///Regulations for a related area or facility.
///</summary>
public class RegulationsType : AbstractRXNType { 


	public RegulationsType( gml.ID id) : base( id)
	{
	}

	protected RegulationsType(): base()
	{}

}

///<summary>
///Restrictions for a related area or facility.
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
///Describes a single fixed period, as the date range between its sub-attributes.
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

	public positiveInteger frequencyShoreStationTransmits;
	public positiveInteger frequencyShoreStationReceives;

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
	public string[] communicationChannel;
	public contactAddressType[] contactAddress;
	public frequencyPairType[] frequencyPair;
	public string contactInstructions;
	public informationType[] information;
	public int mMSICode;
	public onlineResourceType[] onlineResource;
	public telecommunicationsType[] telecommunications;
	public radiocommunicationsType[] radiocommunications;
	public ReferenceType[] theAuthority;

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
	public categoryOfCommPrefType categoryOfCommPref;
	public scheduleByDoWType scheduleByDoW;

	public telecommunicationsType( string telecommunicationIdentifier)
	{
		this.telecommunicationIdentifier=telecommunicationIdentifier;
	}

	protected telecommunicationsType(): base()
	{}

}

///<summary>
///The time in the day when a weather or ice observation is made, expressed in UTC or local time. The time of observation normally amplifies the time of transmission of radio-facsimile weather maps or ice charts.
///</summary>
public class timeOfObservationType { 

	public time observationTime;
	public timeReferenceType timeReference;

	public timeOfObservationType( time observationTime, timeReferenceType timeReference)
	{
		this.observationTime=observationTime;
		this.timeReference=timeReference;
	}

	protected timeOfObservationType(): base()
	{}

}

///<summary>
///One or more times in the day when the radio station starts a routine transmission, normally expressed in UTC or local time.
///</summary>
public class timesOfTransmissionType { 

	public nonNegativeInteger minutePastEvenHours;
	public nonNegativeInteger minutePastEveryHour;
	public nonNegativeInteger minutePastOddHours;
	public timeReferenceType timeReference;
	public time[] transmissionTime;

	public timesOfTransmissionType()
	{
	}

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
///A bearing is the direction one object is from another object.
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
///The drum speed and index of co-operation of a facsimile machine.
///</summary>
public class facsimileDrumSpeedType { 

	public integer drumSpeed;
	public integer indexOfCooperation;

	public facsimileDrumSpeedType( integer drumSpeed, integer indexOfCooperation)
	{
		this.drumSpeed=drumSpeed;
		this.indexOfCooperation=indexOfCooperation;
	}

	protected facsimileDrumSpeedType(): base()
	{}

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
///Aggregation of areas where forecasts and warnings broadcasted for a Weather forecast and warning area may be available with differing levels of reliability.
///</summary>
public class ForecastAreaAggregateType : FuzzyAreaAggregateType { 


	public ForecastAreaAggregateType( ReferenceType[] consistsOf, gml.ID id) : base( consistsOf, id)
	{
	}

	protected ForecastAreaAggregateType(): base()
	{}

}

///<summary>
///Aggregation of a geographic feature describing a service or phenomenon with zones of different confidence about the availability of the service, occurrence of the phenomenon, or applicability of the information described by the geographic feature.
///</summary>
public abstract class FuzzyAreaAggregateType : FeatureType { 

	public ReferenceType[] consistsOf;

	protected FuzzyAreaAggregateType( ReferenceType[] consistsOf, gml.ID id) : base( id)
	{
		this.consistsOf=consistsOf;
	}

	protected FuzzyAreaAggregateType(): base()
	{}

}

///<summary>
///A region in which the perception of a phenomenon or the availability of a service is known only to a specified level of confidence.
///</summary>
public class IndeterminateZoneType : FeatureType { 

	public informationConfidenceType informationConfidence;
	public GM_Surface geometry;

	public IndeterminateZoneType( informationConfidenceType informationConfidence, GM_Surface geometry, gml.ID id) : base( id)
	{
		this.informationConfidence=informationConfidence;
		this.geometry=geometry;
	}

	protected IndeterminateZoneType(): base()
	{}

}

///<summary>
///Aggregation of areas where radio services from a single radio service are available to different levels of reliability
///</summary>
public class RadioServiceAreaAggregateType : FuzzyAreaAggregateType { 


	public RadioServiceAreaAggregateType( ReferenceType[] consistsOf, gml.ID id) : base( consistsOf, id)
	{
	}

	protected RadioServiceAreaAggregateType(): base()
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
//////<summary> ///(Type)A station at which a visual/radio/radar marine watch is kept either continuously or at certain times only.(Element) ///</summary>
///</summary>
public class CoastguardStation : CoastguardStationType { 


	public CoastguardStation( PointOrSurface geometry, gml.ID id) : base( geometry, id)
	{
	}

	protected CoastguardStation(): base()
	{}

}

///<summary>
//////<summary> ///(Type)An area defined for a global communications service based upon automated systems, both satellite based and terrestrial, to provide distress alerting and promulgation of maritime safety information for mariners. (Adapted IHO Dictionary, S-32, 5th Edition, 2048) (Element) ///</summary>
///</summary>
public class GMDSSArea : GMDSSAreaType { 


	public GMDSSArea( categoryOfGMDSSAreaType categoryOfGMDSSArea, GM_Surface[] geometry, gml.ID id) : base( categoryOfGMDSSArea, geometry, id)
	{
	}

	protected GMDSSArea(): base()
	{}

}

///<summary>
//////<summary> ///(Type)The ocean region of the earth’s surface, within which a station can obtain line-of-sight communication, with an Inmarsat satellite.(Element) ///</summary>
///</summary>
public class InmarsatOceanRegionArea : InmarsatOceanRegionAreaType { 


	public InmarsatOceanRegionArea( GM_Surface[] geometry, gml.ID id) : base( geometry, id)
	{
	}

	protected InmarsatOceanRegionArea(): base()
	{}

}

///<summary>
//////<summary> ///(Type)Any prominent object on land which can be used in determining a location or a direction. (IHO Dictionary – S-32). S-123 Note: Only features relevant to radio communications are encoded e.g., radio towers or radio masts. If the feature can be encoded as a radio station at the same location, a coincident Landmark must not be encoded.(Element) ///</summary>
///</summary>
public class Landmark : LandmarkType { 


	public Landmark( categoryOfLandmarkType[] categoryOfLandmark, PointOrSurface geometry, gml.ID id) : base( categoryOfLandmark, geometry, id)
	{
	}

	protected Landmark(): base()
	{}

}

///<summary>
//////<summary> ///(Type)The geographic areas in which various governments are responsible for navigation and weather warnings.(Element) ///</summary>
///</summary>
public class NavigationalMeteorologicalArea : NavigationalMeteorologicalAreaType { 


	public NavigationalMeteorologicalArea( GM_Surface[] geometry, gml.ID id) : base( geometry, id)
	{
	}

	protected NavigationalMeteorologicalArea(): base()
	{}

}

///<summary>
//////<summary> ///(Type)The geographic areas in which radio stations are responsible for broadcast navigation and weather warnings.(Element) ///</summary>
///</summary>
public class NavtexStationArea : NavtexStationAreaType { 


	public NavtexStationArea( txIdentCharType txIdentChar, GM_Surface[] geometry, gml.ID id) : base( txIdentChar, geometry, id)
	{
	}

	protected NavtexStationArea(): base()
	{}

}

///<summary>
//////<summary> ///(Type)The area where a radio service can be obtained and the characteristics of the radio transmission. Remarks: The objects RDOSTA; RADSTA are used to encode the point of transmission of the signal. (Element) ///</summary>
///</summary>
public class RadioServiceArea : RadioServiceAreaType { 


	public RadioServiceArea( categoryOfBroadcastCommunicationType categoryOfBroadcastCommunication, gml.ID id) : base( categoryOfBroadcastCommunication, id)
	{
	}

	protected RadioServiceArea(): base()
	{}

}

///<summary>
//////<summary> ///(Type)A place equipped to transmit radio waves.(Element) ///</summary>
///</summary>
public class RadioStation : RadioStationType { 


	public RadioStation( GM_Point geometry, gml.ID id) : base( geometry, id)
	{
	}

	protected RadioStation(): base()
	{}

}

///<summary>
//////<summary> ///(Type)An area for which weather forecasts and warnings are provided for specified periods.(Element) ///</summary>
///</summary>
public class WeatherForecastWarningArea : WeatherForecastWarningAreaType { 


	public WeatherForecastWarningArea( categoryOfFrcstAndWarningAreaType categoryOfFrcstAndWarningArea, GM_Surface[] geometry, gml.ID id) : base( categoryOfFrcstAndWarningArea, geometry, id)
	{
	}

	protected WeatherForecastWarningArea(): base()
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
//////<summary> ///(Type)Recommendations for a related area or facility.(Element) ///</summary>
///</summary>
public class Recommendations : RecommendationsType { 


	public Recommendations( gml.ID id) : base( id)
	{
	}

	protected Recommendations(): base()
	{}

}

///<summary>
//////<summary> ///(Type)Regulations for a related area or facility.(Element) ///</summary>
///</summary>
public class Regulations : RegulationsType { 


	public Regulations( gml.ID id) : base( id)
	{
	}

	protected Regulations(): base()
	{}

}

///<summary>
//////<summary> ///(Type)Restrictions for a related area or facility.(Element) ///</summary>
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
//////<summary> ///(Type)Information on how to reach a person or organisation by postal, internet, telephone, telex and radio systems.(Element) ///</summary>
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
//////<summary> ///(Type)Aggregation of areas where forecasts and warnings broadcasted for a Weather forecast and warning area may be available with differing levels of reliability.(Element) ///</summary>
///</summary>
public class ForecastAreaAggregate : ForecastAreaAggregateType { 


	public ForecastAreaAggregate( ReferenceType[] consistsOf, gml.ID id) : base( consistsOf, id)
	{
	}

	protected ForecastAreaAggregate(): base()
	{}

}

///<summary>
//////<summary> ///(Type)Aggregation of a geographic feature describing a service or phenomenon with zones of different confidence about the availability of the service, occurrence of the phenomenon, or applicability of the information described by the geographic feature.(Element) ///</summary>
///</summary>
public abstract class FuzzyAreaAggregate : FuzzyAreaAggregateType { 


	protected FuzzyAreaAggregate( ReferenceType[] consistsOf, gml.ID id) : base( consistsOf, id)
	{
	}

	protected FuzzyAreaAggregate(): base()
	{}

}

///<summary>
//////<summary> ///(Type)A region in which the perception of a phenomenon or the availability of a service is known only to a specified level of confidence.(Element) ///</summary>
///</summary>
public class IndeterminateZone : IndeterminateZoneType { 


	public IndeterminateZone( informationConfidenceType informationConfidence, GM_Surface geometry, gml.ID id) : base( informationConfidence, geometry, id)
	{
	}

	protected IndeterminateZone(): base()
	{}

}

///<summary>
//////<summary> ///(Type)Aggregation of areas where radio services from a single radio service are available to different levels of reliability(Element) ///</summary>
///</summary>
public class RadioServiceAreaAggregate : RadioServiceAreaAggregateType { 


	public RadioServiceAreaAggregate( ReferenceType[] consistsOf, gml.ID id) : base( consistsOf, id)
	{
	}

	protected RadioServiceAreaAggregate(): base()
	{}

}

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

