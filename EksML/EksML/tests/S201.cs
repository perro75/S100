//EksML - S100 application schema to csCode 1.6.2017 17:14:43

using System;
using System.ComponentModel;

using gml;


namespace S201 {


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
///no description available
///</summary>
public enum categoryOfLight { 
	///<summary>
	///no description available
	///</summary>
	[Description("directional function")]
	directional_function=1,
	///<summary>
	///no description available
	///</summary>
	[Description("leading light")]
	leading_light=2,
	///<summary>
	///no description available
	///</summary>
	[Description("aero light")]
	aero_light=3,
	///<summary>
	///no description available
	///</summary>
	[Description("air obstruction light")]
	air_obstruction_light=4,
	///<summary>
	///no description available
	///</summary>
	[Description("fog detector light")]
	fog_detector_light=5,
	///<summary>
	///no description available
	///</summary>
	[Description("flood light")]
	flood_light=6,
	///<summary>
	///no description available
	///</summary>
	[Description("strip light")]
	strip_light=7,
	///<summary>
	///no description available
	///</summary>
	[Description("subsidiary light")]
	subsidiary_light=8,
	///<summary>
	///no description available
	///</summary>
	[Description("spotlight")]
	spotlight=9,
	///<summary>
	///no description available
	///</summary>
	[Description("front")]
	front=10,
	///<summary>
	///no description available
	///</summary>
	[Description("rear")]
	rear=11,
	///<summary>
	///no description available
	///</summary>
	[Description("lower")]
	lower=12,
	///<summary>
	///no description available
	///</summary>
	[Description("upper")]
	upper=13,
	///<summary>
	///no description available
	///</summary>
	[Description("moiré effect")]
	moiré_effect=14,
	///<summary>
	///no description available
	///</summary>
	[Description("emergency")]
	emergency=15,
	///<summary>
	///no description available
	///</summary>
	[Description("bearing light")]
	bearing_light=16,
	///<summary>
	///no description available
	///</summary>
	[Description("horizontally disposed")]
	horizontally_disposed=17,
	///<summary>
	///no description available
	///</summary>
	[Description("vertically disposed")]
	vertically_disposed=18
}

///<summary>
///no description available
///</summary>
public enum colour { 
	///<summary>
	///no description available
	///</summary>
	[Description("white")]
	white=1,
	///<summary>
	///no description available
	///</summary>
	[Description("black")]
	black=2,
	///<summary>
	///no description available
	///</summary>
	[Description("red")]
	red=3,
	///<summary>
	///no description available
	///</summary>
	[Description("green")]
	green=4,
	///<summary>
	///no description available
	///</summary>
	[Description("blue")]
	blue=5,
	///<summary>
	///no description available
	///</summary>
	[Description("yellow")]
	yellow=6,
	///<summary>
	///no description available
	///</summary>
	[Description("grey")]
	grey=7,
	///<summary>
	///no description available
	///</summary>
	[Description("brown")]
	brown=8,
	///<summary>
	///no description available
	///</summary>
	[Description("amber")]
	amber=9,
	///<summary>
	///no description available
	///</summary>
	[Description("violet")]
	violet=10,
	///<summary>
	///no description available
	///</summary>
	[Description("orange")]
	orange=11,
	///<summary>
	///no description available
	///</summary>
	[Description("magenta")]
	magenta=12,
	///<summary>
	///no description available
	///</summary>
	[Description("pink")]
	pink=13
}

///<summary>
///no description available
///</summary>
public enum exhibitionConditionOfLight { 
	///<summary>
	///no description available
	///</summary>
	[Description("light shown without change of character")]
	light_shown_without_change_of_character=1,
	///<summary>
	///no description available
	///</summary>
	[Description("daytime light")]
	daytime_light=2,
	///<summary>
	///no description available
	///</summary>
	[Description("fog light")]
	fog_light=3,
	///<summary>
	///no description available
	///</summary>
	[Description("night light")]
	night_light=4
}

///<summary>
///no description available
///</summary>
public enum lightCharacteristic { 
	///<summary>
	///no description available
	///</summary>
	[Description("fixed")]
	_fixed=1,
	///<summary>
	///no description available
	///</summary>
	[Description("flashing")]
	flashing=2,
	///<summary>
	///no description available
	///</summary>
	[Description("long-flashing")]
	long_flashing=3,
	///<summary>
	///no description available
	///</summary>
	[Description("quick-flashing")]
	quick_flashing=4,
	///<summary>
	///no description available
	///</summary>
	[Description("very quick-flashing")]
	very_quick_flashing=5,
	///<summary>
	///no description available
	///</summary>
	[Description("ultra quick-flashing")]
	ultra_quick_flashing=6,
	///<summary>
	///no description available
	///</summary>
	[Description("isophased")]
	isophased=7,
	///<summary>
	///no description available
	///</summary>
	[Description("occulting")]
	occulting=8,
	///<summary>
	///no description available
	///</summary>
	[Description("interrupted quick-flashing")]
	interrupted_quick_flashing=9,
	///<summary>
	///no description available
	///</summary>
	[Description("interrupted very quick-flashing")]
	interrupted_very_quick_flashing=10,
	///<summary>
	///no description available
	///</summary>
	[Description("interrupted ultra quick-flashing")]
	interrupted_ultra_quick_flashing=11,
	///<summary>
	///no description available
	///</summary>
	[Description("morse")]
	morse=12,
	///<summary>
	///no description available
	///</summary>
	[Description("fixed/flash")]
	fixed_flash=13,
	///<summary>
	///no description available
	///</summary>
	[Description("flash/long-flash")]
	flash_long_flash=14,
	///<summary>
	///no description available
	///</summary>
	[Description("occulting/flash")]
	occulting_flash=15,
	///<summary>
	///no description available
	///</summary>
	[Description("fixed/long-flash")]
	fixed_long_flash=16,
	///<summary>
	///no description available
	///</summary>
	[Description("occulting alternating")]
	occulting_alternating=17,
	///<summary>
	///no description available
	///</summary>
	[Description("long-flash alternating")]
	long_flash_alternating=18,
	///<summary>
	///no description available
	///</summary>
	[Description("flash alternating")]
	flash_alternating=19,
	///<summary>
	///no description available
	///</summary>
	[Description("group alternating")]
	group_alternating=20,
	///<summary>
	///no description available
	///</summary>
	[Description("quick-flash plus long-flash")]
	quick_flash_plus_long_flash=21,
	///<summary>
	///no description available
	///</summary>
	[Description("very quick-flash plus long-flash")]
	very_quick_flash_plus_long_flash=22,
	///<summary>
	///no description available
	///</summary>
	[Description("ultra quick-flash plus long-flash")]
	ultra_quick_flash_plus_long_flash=23,
	///<summary>
	///no description available
	///</summary>
	[Description("alternating")]
	alternating=24,
	///<summary>
	///no description available
	///</summary>
	[Description("fixed and alternating flashing")]
	fixed_and_alternating_flashing=25
}

///<summary>
///no description available
///</summary>
public enum lightVisibility { 
	///<summary>
	///no description available
	///</summary>
	[Description("high intensity")]
	high_intensity=1,
	///<summary>
	///no description available
	///</summary>
	[Description("low intensity")]
	low_intensity=2,
	///<summary>
	///no description available
	///</summary>
	[Description("faint")]
	faint=3,
	///<summary>
	///no description available
	///</summary>
	[Description("intensified")]
	intensified=4,
	///<summary>
	///no description available
	///</summary>
	[Description("unintensified")]
	unintensified=5,
	///<summary>
	///no description available
	///</summary>
	[Description("visibility deliberately restricted")]
	visibility_deliberately_restricted=6,
	///<summary>
	///no description available
	///</summary>
	[Description("obscured")]
	obscured=7,
	///<summary>
	///no description available
	///</summary>
	[Description("partially obscured")]
	partially_obscured=8
}

///<summary>
///no description available
///</summary>
public enum marksNavigationalSystemOf { 
	///<summary>
	///no description available
	///</summary>
	[Description("IALA A")]
	IALA_A=1,
	///<summary>
	///no description available
	///</summary>
	[Description("IALA B")]
	IALA_B=2,
	///<summary>
	///no description available
	///</summary>
	[Description("no system")]
	no_system=3,
	///<summary>
	///no description available
	///</summary>
	[Description("other system")]
	other_system=4
}

///<summary>
///no description available
///</summary>
public enum status { 
	///<summary>
	///no description available
	///</summary>
	[Description("permanent")]
	permanent=1,
	///<summary>
	///no description available
	///</summary>
	[Description("occasional")]
	occasional=2,
	///<summary>
	///no description available
	///</summary>
	[Description("recommended")]
	recommended=3,
	///<summary>
	///no description available
	///</summary>
	[Description("not in use")]
	not_in_use=4,
	///<summary>
	///no description available
	///</summary>
	[Description("periodic/intermittent")]
	periodic_intermittent=5,
	///<summary>
	///no description available
	///</summary>
	[Description("reserved")]
	reserved=6,
	///<summary>
	///no description available
	///</summary>
	[Description("temporary")]
	temporary=7,
	///<summary>
	///no description available
	///</summary>
	[Description("private")]
	_private=8,
	///<summary>
	///no description available
	///</summary>
	[Description("mandatory")]
	mandatory=9,
	///<summary>
	///no description available
	///</summary>
	[Description("extinguished")]
	extinguished=10,
	///<summary>
	///no description available
	///</summary>
	[Description("illuminated")]
	illuminated=11,
	///<summary>
	///no description available
	///</summary>
	[Description("historic")]
	historic=12,
	///<summary>
	///no description available
	///</summary>
	[Description("public")]
	_public=13,
	///<summary>
	///no description available
	///</summary>
	[Description("synchronized")]
	synchronized=14,
	///<summary>
	///no description available
	///</summary>
	[Description("watched")]
	watched=15,
	///<summary>
	///no description available
	///</summary>
	[Description("un-watched")]
	un_watched=16,
	///<summary>
	///no description available
	///</summary>
	[Description("existence doubtful")]
	existence_doubtful=17
}

///<summary>
///no description available
///</summary>
public enum verticalDatum { 
	///<summary>
	///no description available
	///</summary>
	[Description("Mean low water springs")]
	Mean_low_water_springs=1,
	///<summary>
	///no description available
	///</summary>
	[Description("Mean lower low water springs")]
	Mean_lower_low_water_springs=2,
	///<summary>
	///no description available
	///</summary>
	[Description("Mean sea level")]
	Mean_sea_level=3,
	///<summary>
	///no description available
	///</summary>
	[Description("Lowest low water")]
	Lowest_low_water=4,
	///<summary>
	///no description available
	///</summary>
	[Description("Mean low water")]
	Mean_low_water=5,
	///<summary>
	///no description available
	///</summary>
	[Description("Lowest low water springs")]
	Lowest_low_water_springs=6,
	///<summary>
	///no description available
	///</summary>
	[Description("Approximate mean low water springs")]
	Approximate_mean_low_water_springs=7,
	///<summary>
	///no description available
	///</summary>
	[Description("Indian spring low water")]
	Indian_spring_low_water=8,
	///<summary>
	///no description available
	///</summary>
	[Description("Low water springs")]
	Low_water_springs=9,
	///<summary>
	///no description available
	///</summary>
	[Description("Approximate lowest astronomical tide")]
	Approximate_lowest_astronomical_tide=10,
	///<summary>
	///no description available
	///</summary>
	[Description("Nearly lowest low water")]
	Nearly_lowest_low_water=11,
	///<summary>
	///no description available
	///</summary>
	[Description("Mean lower low water")]
	Mean_lower_low_water=12,
	///<summary>
	///no description available
	///</summary>
	[Description("Low water")]
	Low_water=13,
	///<summary>
	///no description available
	///</summary>
	[Description("Approximate mean low water")]
	Approximate_mean_low_water=14,
	///<summary>
	///no description available
	///</summary>
	[Description("Approximate mean lower low water")]
	Approximate_mean_lower_low_water=15,
	///<summary>
	///no description available
	///</summary>
	[Description("Mean high water")]
	Mean_high_water=16,
	///<summary>
	///no description available
	///</summary>
	[Description("Mean high water springs")]
	Mean_high_water_springs=17,
	///<summary>
	///no description available
	///</summary>
	[Description("High water")]
	High_water=18,
	///<summary>
	///no description available
	///</summary>
	[Description("Approximate mean sea level")]
	Approximate_mean_sea_level=19,
	///<summary>
	///no description available
	///</summary>
	[Description("High water springs")]
	High_water_springs=20,
	///<summary>
	///no description available
	///</summary>
	[Description("Mean higher high water")]
	Mean_higher_high_water=21,
	///<summary>
	///no description available
	///</summary>
	[Description("Equinoctial spring low water")]
	Equinoctial_spring_low_water=22,
	///<summary>
	///no description available
	///</summary>
	[Description("Lowest astronomical tide")]
	Lowest_astronomical_tide=23,
	///<summary>
	///no description available
	///</summary>
	[Description("Local datum")]
	Local_datum=24,
	///<summary>
	///no description available
	///</summary>
	[Description("International Great Lakes Datum 1985")]
	International_Great_Lakes_Datum_1985=25,
	///<summary>
	///no description available
	///</summary>
	[Description("Mean water level")]
	Mean_water_level=26,
	///<summary>
	///no description available
	///</summary>
	[Description("Lower low water large tide")]
	Lower_low_water_large_tide=27,
	///<summary>
	///no description available
	///</summary>
	[Description("Higher high water large tide")]
	Higher_high_water_large_tide=28,
	///<summary>
	///no description available
	///</summary>
	[Description("Nearly highest high water")]
	Nearly_highest_high_water=29,
	///<summary>
	///no description available
	///</summary>
	[Description("Highest astronomical tide (HAT)")]
	Highest_astronomical_tide__HAT_=30
}

///<summary>
///no description available
///</summary>
public enum beaconShape { 
	///<summary>
	///no description available
	///</summary>
	[Description("stake, pole, perch, post")]
	stake__pole__perch__post=1,
	///<summary>
	///no description available
	///</summary>
	[Description("withy")]
	withy=2,
	///<summary>
	///no description available
	///</summary>
	[Description("beacon tower")]
	beacon_tower=3,
	///<summary>
	///no description available
	///</summary>
	[Description("lattice beacon")]
	lattice_beacon=4,
	///<summary>
	///no description available
	///</summary>
	[Description("pile beacon")]
	pile_beacon=5,
	///<summary>
	///no description available
	///</summary>
	[Description("cairn")]
	cairn=6,
	///<summary>
	///no description available
	///</summary>
	[Description("buoyant beacon")]
	buoyant_beacon=7
}

///<summary>
///no description available
///</summary>
public enum buoyShape { 
	///<summary>
	///no description available
	///</summary>
	[Description("conical (nun, ogival)")]
	conical__nun__ogival_=1,
	///<summary>
	///no description available
	///</summary>
	[Description("can (cylindrical)")]
	can__cylindrical_=2,
	///<summary>
	///no description available
	///</summary>
	[Description("spherical")]
	spherical=3,
	///<summary>
	///no description available
	///</summary>
	[Description("pillar")]
	pillar=4,
	///<summary>
	///no description available
	///</summary>
	[Description("spar (spindle)")]
	spar__spindle_=5,
	///<summary>
	///no description available
	///</summary>
	[Description("barrel (tun)")]
	barrel__tun_=6,
	///<summary>
	///no description available
	///</summary>
	[Description("super-buoy")]
	super_buoy=7,
	///<summary>
	///no description available
	///</summary>
	[Description("ice buoy")]
	ice_buoy=8
}

///<summary>
///no description available
///</summary>
public enum categoryOfCardinalMark { 
	///<summary>
	///no description available
	///</summary>
	[Description("north cardinal mark")]
	north_cardinal_mark=1,
	///<summary>
	///no description available
	///</summary>
	[Description("east cardinal mark")]
	east_cardinal_mark=2,
	///<summary>
	///no description available
	///</summary>
	[Description("south cardinal mark")]
	south_cardinal_mark=3,
	///<summary>
	///no description available
	///</summary>
	[Description("west cardinal mark")]
	west_cardinal_mark=4
}

///<summary>
///no description available
///</summary>
public enum categoryOfFogSignal { 
	///<summary>
	///no description available
	///</summary>
	[Description("explosive")]
	explosive=1,
	///<summary>
	///no description available
	///</summary>
	[Description("diaphone")]
	diaphone=2,
	///<summary>
	///no description available
	///</summary>
	[Description("siren")]
	siren=3,
	///<summary>
	///no description available
	///</summary>
	[Description("nautophone")]
	nautophone=4,
	///<summary>
	///no description available
	///</summary>
	[Description("reed")]
	reed=5,
	///<summary>
	///no description available
	///</summary>
	[Description("tyfon")]
	tyfon=6,
	///<summary>
	///no description available
	///</summary>
	[Description("bell")]
	bell=7,
	///<summary>
	///no description available
	///</summary>
	[Description("whistle")]
	whistle=8,
	///<summary>
	///no description available
	///</summary>
	[Description("gong")]
	gong=9,
	///<summary>
	///no description available
	///</summary>
	[Description("horn")]
	horn=10
}

///<summary>
///no description available
///</summary>
public enum signalGeneration { 
	///<summary>
	///no description available
	///</summary>
	[Description("automatically")]
	automatically=1,
	///<summary>
	///no description available
	///</summary>
	[Description("by wave action")]
	by_wave_action=2,
	///<summary>
	///no description available
	///</summary>
	[Description("by hand")]
	by_hand=3,
	///<summary>
	///no description available
	///</summary>
	[Description("by wind")]
	by_wind=4
}

///<summary>
///no description available
///</summary>
public enum categoryOfInstallationBuoy { 
	///<summary>
	///no description available
	///</summary>
	[Description("catenary anchor leg mooring (CALM)")]
	catenary_anchor_leg_mooring__CALM_=1,
	///<summary>
	///no description available
	///</summary>
	[Description("single buoy mooring (SBM or SPM)")]
	single_buoy_mooring__SBM_or_SPM_=2
}

///<summary>
///no description available
///</summary>
public enum colourPattern { 
	///<summary>
	///no description available
	///</summary>
	[Description("horizontal stripes")]
	horizontal_stripes=1,
	///<summary>
	///no description available
	///</summary>
	[Description("vertical stripes")]
	vertical_stripes=2,
	///<summary>
	///no description available
	///</summary>
	[Description("diagonal stripes")]
	diagonal_stripes=3,
	///<summary>
	///no description available
	///</summary>
	[Description("squared")]
	squared=4,
	///<summary>
	///no description available
	///</summary>
	[Description("stripes (direction unknown)")]
	stripes__direction_unknown_=5,
	///<summary>
	///no description available
	///</summary>
	[Description("border stripe")]
	border_stripe=6
}

///<summary>
///no description available
///</summary>
public enum categoryOfSpecialPurposeMark { 
	///<summary>
	///no description available
	///</summary>
	[Description("firing danger area mark")]
	firing_danger_area_mark=1,
	///<summary>
	///no description available
	///</summary>
	[Description("target mark")]
	target_mark=2,
	///<summary>
	///no description available
	///</summary>
	[Description("marker ship mark")]
	marker_ship_mark=3,
	///<summary>
	///no description available
	///</summary>
	[Description("degaussing range mark")]
	degaussing_range_mark=4,
	///<summary>
	///no description available
	///</summary>
	[Description("barge mark")]
	barge_mark=5,
	///<summary>
	///no description available
	///</summary>
	[Description("cable mark")]
	cable_mark=6,
	///<summary>
	///no description available
	///</summary>
	[Description("spoil ground mark")]
	spoil_ground_mark=7,
	///<summary>
	///no description available
	///</summary>
	[Description("outfall mark")]
	outfall_mark=8,
	///<summary>
	///no description available
	///</summary>
	[Description("ODAS (Ocean-Data-Acquisition-System)")]
	ODAS__Ocean_Data_Acquisition_System_=9,
	///<summary>
	///no description available
	///</summary>
	[Description("recording mark")]
	recording_mark=10,
	///<summary>
	///no description available
	///</summary>
	[Description("seaplane anchorage mark")]
	seaplane_anchorage_mark=11,
	///<summary>
	///no description available
	///</summary>
	[Description("recreation zone mark")]
	recreation_zone_mark=12,
	///<summary>
	///no description available
	///</summary>
	[Description("private mark")]
	private_mark=13,
	///<summary>
	///no description available
	///</summary>
	[Description("mooring mark")]
	mooring_mark=14,
	///<summary>
	///no description available
	///</summary>
	[Description("LANBY (Large Automatic Navigational Buoy)")]
	LANBY__Large_Automatic_Navigational_Buoy_=15,
	///<summary>
	///no description available
	///</summary>
	[Description("leading mark")]
	leading_mark=16,
	///<summary>
	///no description available
	///</summary>
	[Description("measured distance mark")]
	measured_distance_mark=17,
	///<summary>
	///no description available
	///</summary>
	[Description("notice mark")]
	notice_mark=18,
	///<summary>
	///no description available
	///</summary>
	[Description("TSS mark (Traffic Separation Scheme)")]
	TSS_mark__Traffic_Separation_Scheme_=19,
	///<summary>
	///no description available
	///</summary>
	[Description("anchoring prohibited mark")]
	anchoring_prohibited_mark=20,
	///<summary>
	///no description available
	///</summary>
	[Description("berthing prohibited mark")]
	berthing_prohibited_mark=21,
	///<summary>
	///no description available
	///</summary>
	[Description("overtaking prohibited mark")]
	overtaking_prohibited_mark=22,
	///<summary>
	///no description available
	///</summary>
	[Description("two-way traffic prohibited mark")]
	two_way_traffic_prohibited_mark=23,
	///<summary>
	///no description available
	///</summary>
	[Description("reduced wake mark")]
	reduced_wake_mark=24,
	///<summary>
	///no description available
	///</summary>
	[Description("speed limit mark")]
	speed_limit_mark=25,
	///<summary>
	///no description available
	///</summary>
	[Description("stop mark")]
	stop_mark=26,
	///<summary>
	///no description available
	///</summary>
	[Description("general warning mark")]
	general_warning_mark=27,
	///<summary>
	///no description available
	///</summary>
	[Description("sound ship's siren mark")]
	sound_ship_s_siren_mark=28,
	///<summary>
	///no description available
	///</summary>
	[Description("restricted vertical clearance mark")]
	restricted_vertical_clearance_mark=29,
	///<summary>
	///no description available
	///</summary>
	[Description("maximum vessel's draught mark")]
	maximum_vessel_s_draught_mark=30,
	///<summary>
	///no description available
	///</summary>
	[Description("restricted horizontal clearance mark")]
	restricted_horizontal_clearance_mark=31,
	///<summary>
	///no description available
	///</summary>
	[Description("strong current warning mark")]
	strong_current_warning_mark=32,
	///<summary>
	///no description available
	///</summary>
	[Description("berthing permitted mark")]
	berthing_permitted_mark=33,
	///<summary>
	///no description available
	///</summary>
	[Description("overhead power cable mark")]
	overhead_power_cable_mark=34,
	///<summary>
	///no description available
	///</summary>
	[Description("channel edge gradient mark")]
	channel_edge_gradient_mark=35,
	///<summary>
	///no description available
	///</summary>
	[Description("telephone mark")]
	telephone_mark=36,
	///<summary>
	///no description available
	///</summary>
	[Description("ferry crossing mark")]
	ferry_crossing_mark=37,
	///<summary>
	///no description available
	///</summary>
	[Description("pipeline mark")]
	pipeline_mark=38,
	///<summary>
	///no description available
	///</summary>
	[Description("anchorage mark")]
	anchorage_mark=39,
	///<summary>
	///no description available
	///</summary>
	[Description("clearing mark")]
	clearing_mark=40,
	///<summary>
	///no description available
	///</summary>
	[Description("control mark")]
	control_mark=41,
	///<summary>
	///no description available
	///</summary>
	[Description("diving mark")]
	diving_mark=42,
	///<summary>
	///no description available
	///</summary>
	[Description("refuge beacon")]
	refuge_beacon=43,
	///<summary>
	///no description available
	///</summary>
	[Description("foul ground mark")]
	foul_ground_mark=44,
	///<summary>
	///no description available
	///</summary>
	[Description("yachting mark")]
	yachting_mark=45,
	///<summary>
	///no description available
	///</summary>
	[Description("heliport mark")]
	heliport_mark=46,
	///<summary>
	///no description available
	///</summary>
	[Description("GPS mark")]
	GPS_mark=47,
	///<summary>
	///no description available
	///</summary>
	[Description("seaplane landing mark")]
	seaplane_landing_mark=48,
	///<summary>
	///no description available
	///</summary>
	[Description("entry prohibited mark")]
	entry_prohibited_mark=49,
	///<summary>
	///no description available
	///</summary>
	[Description("work in progress mark")]
	work_in_progress_mark=50,
	///<summary>
	///no description available
	///</summary>
	[Description("mark with unknown purpose")]
	mark_with_unknown_purpose=51,
	///<summary>
	///no description available
	///</summary>
	[Description("wellhead mark")]
	wellhead_mark=52,
	///<summary>
	///no description available
	///</summary>
	[Description("channel separation mark")]
	channel_separation_mark=53,
	///<summary>
	///no description available
	///</summary>
	[Description("marine farm mark")]
	marine_farm_mark=54,
	///<summary>
	///no description available
	///</summary>
	[Description("artificial reef mark")]
	artificial_reef_mark=55
}

///<summary>
///no description available
///</summary>
public enum natureOfConstruction { 
	///<summary>
	///no description available
	///</summary>
	[Description("masonry")]
	masonry=1,
	///<summary>
	///no description available
	///</summary>
	[Description("concreted")]
	concreted=2,
	///<summary>
	///no description available
	///</summary>
	[Description("loose boulders")]
	loose_boulders=3,
	///<summary>
	///no description available
	///</summary>
	[Description("hard surfaced")]
	hard_surfaced=4,
	///<summary>
	///no description available
	///</summary>
	[Description("unsurfaced")]
	unsurfaced=5,
	///<summary>
	///no description available
	///</summary>
	[Description("wooden")]
	wooden=6,
	///<summary>
	///no description available
	///</summary>
	[Description("metal")]
	metal=7,
	///<summary>
	///no description available
	///</summary>
	[Description("glass reinforced plastic (GRP)")]
	glass_reinforced_plastic__GRP_=8,
	///<summary>
	///no description available
	///</summary>
	[Description("painted")]
	painted=9
}

///<summary>
///no description available
///</summary>
public enum topmarkDaymarkShape { 
	///<summary>
	///no description available
	///</summary>
	[Description("cone, point up")]
	cone__point_up=1,
	///<summary>
	///no description available
	///</summary>
	[Description("cone, point down")]
	cone__point_down=2,
	///<summary>
	///no description available
	///</summary>
	[Description("sphere")]
	sphere=3,
	///<summary>
	///no description available
	///</summary>
	[Description("2 spheres")]
	_2_spheres=4,
	///<summary>
	///no description available
	///</summary>
	[Description("cylinder (can)")]
	cylinder__can_=5,
	///<summary>
	///no description available
	///</summary>
	[Description("board")]
	board=6,
	///<summary>
	///no description available
	///</summary>
	[Description("x-shape (St. Andrew's cross)")]
	x_shape__St__Andrew_s_cross_=7,
	///<summary>
	///no description available
	///</summary>
	[Description("upright cross (St George's cross)")]
	upright_cross__St_George_s_cross_=8,
	///<summary>
	///no description available
	///</summary>
	[Description("cube, point up")]
	cube__point_up=9,
	///<summary>
	///no description available
	///</summary>
	[Description("2 cones, point to point")]
	_2_cones__point_to_point=10,
	///<summary>
	///no description available
	///</summary>
	[Description("2 cones, base to base")]
	_2_cones__base_to_base=11,
	///<summary>
	///no description available
	///</summary>
	[Description("rhombus (diamond)")]
	rhombus__diamond_=12,
	///<summary>
	///no description available
	///</summary>
	[Description("2 cones (points upward)")]
	_2_cones__points_upward_=13,
	///<summary>
	///no description available
	///</summary>
	[Description("2 cones (points downward)")]
	_2_cones__points_downward_=14,
	///<summary>
	///no description available
	///</summary>
	[Description("besom, point up (broom or perch)")]
	besom__point_up__broom_or_perch_=15,
	///<summary>
	///no description available
	///</summary>
	[Description("besom, point down (broom or perch)")]
	besom__point_down__broom_or_perch_=16,
	///<summary>
	///no description available
	///</summary>
	[Description("flag")]
	flag=17,
	///<summary>
	///no description available
	///</summary>
	[Description("sphere over rhombus")]
	sphere_over_rhombus=18,
	///<summary>
	///no description available
	///</summary>
	[Description("square")]
	square=19,
	///<summary>
	///no description available
	///</summary>
	[Description("rectangle, horizontal")]
	rectangle__horizontal=20,
	///<summary>
	///no description available
	///</summary>
	[Description("rectangle, vertical")]
	rectangle__vertical=21,
	///<summary>
	///no description available
	///</summary>
	[Description("trapezium, up")]
	trapezium__up=22,
	///<summary>
	///no description available
	///</summary>
	[Description("trapezium, down")]
	trapezium__down=23,
	///<summary>
	///no description available
	///</summary>
	[Description("triangle, point up")]
	triangle__point_up=24,
	///<summary>
	///no description available
	///</summary>
	[Description("triangle, point down")]
	triangle__point_down=25,
	///<summary>
	///no description available
	///</summary>
	[Description("circle")]
	circle=26,
	///<summary>
	///no description available
	///</summary>
	[Description("two upright crosses (one over the other)")]
	two_upright_crosses__one_over_the_other_=27,
	///<summary>
	///no description available
	///</summary>
	[Description("T-shape")]
	T_shape=28,
	///<summary>
	///no description available
	///</summary>
	[Description("triangle pointing up over a circle")]
	triangle_pointing_up_over_a_circle=29,
	///<summary>
	///no description available
	///</summary>
	[Description("upright cross over a circle")]
	upright_cross_over_a_circle=30,
	///<summary>
	///no description available
	///</summary>
	[Description("rhombus over a circle")]
	rhombus_over_a_circle=31,
	///<summary>
	///no description available
	///</summary>
	[Description("circle over a triangle pointing up")]
	circle_over_a_triangle_pointing_up=32,
	///<summary>
	///no description available
	///</summary>
	[Description("other shape")]
	other_shape=33
}

///<summary>
///no description available
///</summary>
public enum radarConspicuous { 
	///<summary>
	///no description available
	///</summary>
	[Description("radar conspicuous")]
	radar_conspicuous=1,
	///<summary>
	///no description available
	///</summary>
	[Description("not radar conspicuous")]
	not_radar_conspicuous=2,
	///<summary>
	///no description available
	///</summary>
	[Description("radar conspicuous (has radar reflector)")]
	radar_conspicuous__has_radar_reflector_=3
}

///<summary>
///no description available
///</summary>
public enum visuallyConspicuous { 
	///<summary>
	///no description available
	///</summary>
	[Description("visually conspicuous")]
	visually_conspicuous=1,
	///<summary>
	///no description available
	///</summary>
	[Description("not visually conspicuous")]
	not_visually_conspicuous=2
}

///<summary>
///no description available
///</summary>
public enum categoryOfLateralMark { 
	///<summary>
	///no description available
	///</summary>
	[Description("port-hand lateral mark")]
	port_hand_lateral_mark=1,
	///<summary>
	///no description available
	///</summary>
	[Description("starboard-hand lateral mark")]
	starboard_hand_lateral_mark=2,
	///<summary>
	///no description available
	///</summary>
	[Description("preferred channel to starboard lateral mark")]
	preferred_channel_to_starboard_lateral_mark=3,
	///<summary>
	///no description available
	///</summary>
	[Description("preferred channel to port lateral mark")]
	preferred_channel_to_port_lateral_mark=4
}

///<summary>
///no description available
///</summary>
public enum categoryOfRadarTransponderBeacon { 
	///<summary>
	///no description available
	///</summary>
	[Description("ramark, radar beacon transmitting continuously")]
	ramark__radar_beacon_transmitting_continuously=1,
	///<summary>
	///no description available
	///</summary>
	[Description("racon, radar transponder beacon")]
	racon__radar_transponder_beacon=2,
	///<summary>
	///no description available
	///</summary>
	[Description("leading racon/radar transponder beacon")]
	leading_racon_radar_transponder_beacon=3
}

///<summary>
///no description available
///</summary>
public enum buildingShape { 
	///<summary>
	///no description available
	///</summary>
	[Description("high-rise building")]
	high_rise_building=1,
	///<summary>
	///no description available
	///</summary>
	[Description("pyramid")]
	pyramid=2,
	///<summary>
	///no description available
	///</summary>
	[Description("cylindrical")]
	cylindrical=3,
	///<summary>
	///no description available
	///</summary>
	[Description("spherical")]
	spherical=4,
	///<summary>
	///no description available
	///</summary>
	[Description("cubic")]
	cubic=5
}

///<summary>
///no description available
///</summary>
public enum IALA_categoryOfAggregation { 
	///<summary>
	///no description available
	///</summary>
	[Description("leading line")]
	leading_line=1,
	///<summary>
	///no description available
	///</summary>
	[Description("range system")]
	range_system=2
}

///<summary>
///no description available
///</summary>
public enum IALA_categoryOfAssociation { 
	///<summary>
	///no description available
	///</summary>
	[Description("channel markings")]
	channel_markings=1,
	///<summary>
	///no description available
	///</summary>
	[Description("danger markings")]
	danger_markings=2
}

///<summary>
///no description available
///</summary>
public enum categoryOfRecommendedTrack { 
	///<summary>
	///no description available
	///</summary>
	[Description("based on a system of fixed marks")]
	based_on_a_system_of_fixed_marks=1,
	///<summary>
	///no description available
	///</summary>
	[Description("not based on a system of fixed marks")]
	not_based_on_a_system_of_fixed_marks=2
}

///<summary>
///no description available
///</summary>
public enum qualityOfSoundingMeasurement { 
	///<summary>
	///no description available
	///</summary>
	[Description("depth known")]
	depth_known=1,
	///<summary>
	///no description available
	///</summary>
	[Description("depth unknown")]
	depth_unknown=2,
	///<summary>
	///no description available
	///</summary>
	[Description("doubtful sounding")]
	doubtful_sounding=3,
	///<summary>
	///no description available
	///</summary>
	[Description("unreliable sounding")]
	unreliable_sounding=4,
	///<summary>
	///no description available
	///</summary>
	[Description("no bottom found at value shown")]
	no_bottom_found_at_value_shown=5,
	///<summary>
	///no description available
	///</summary>
	[Description("least depth known")]
	least_depth_known=6,
	///<summary>
	///no description available
	///</summary>
	[Description("least depth unknown, safe clearance at value shown")]
	least_depth_unknown__safe_clearance_at_value_shown=7,
	///<summary>
	///no description available
	///</summary>
	[Description("value reported (not surveyed)")]
	value_reported__not_surveyed_=8,
	///<summary>
	///no description available
	///</summary>
	[Description("value reported (not confirmed)")]
	value_reported__not_confirmed_=9,
	///<summary>
	///no description available
	///</summary>
	[Description("maintained depth")]
	maintained_depth=10,
	///<summary>
	///no description available
	///</summary>
	[Description("not regularly maintained")]
	not_regularly_maintained=11
}

///<summary>
///no description available
///</summary>
public enum techniqueOfSoundingMeasurement { 
	///<summary>
	///no description available
	///</summary>
	[Description("found by echo-sounder")]
	found_by_echo_sounder=1,
	///<summary>
	///no description available
	///</summary>
	[Description("found by side scan sonar")]
	found_by_side_scan_sonar=2,
	///<summary>
	///no description available
	///</summary>
	[Description("found by multi-beam")]
	found_by_multi_beam=3,
	///<summary>
	///no description available
	///</summary>
	[Description("found by diver")]
	found_by_diver=4,
	///<summary>
	///no description available
	///</summary>
	[Description("found by lead-line")]
	found_by_lead_line=5,
	///<summary>
	///no description available
	///</summary>
	[Description("swept by wire-drag")]
	swept_by_wire_drag=6,
	///<summary>
	///no description available
	///</summary>
	[Description("found by laser")]
	found_by_laser=7,
	///<summary>
	///no description available
	///</summary>
	[Description("swept by vertical acoustic system")]
	swept_by_vertical_acoustic_system=8,
	///<summary>
	///no description available
	///</summary>
	[Description("found by electromagnetic sensor")]
	found_by_electromagnetic_sensor=9,
	///<summary>
	///no description available
	///</summary>
	[Description("photogrammetry")]
	photogrammetry=10,
	///<summary>
	///no description available
	///</summary>
	[Description("satellite imagery")]
	satellite_imagery=11,
	///<summary>
	///no description available
	///</summary>
	[Description("found by levelling")]
	found_by_levelling=12,
	///<summary>
	///no description available
	///</summary>
	[Description("swept by side-scan sonar")]
	swept_by_side_scan_sonar=13,
	///<summary>
	///no description available
	///</summary>
	[Description("computer generated")]
	computer_generated=14
}

///<summary>
///no description available
///</summary>
public enum trafficFlow { 
	///<summary>
	///no description available
	///</summary>
	[Description("inbound")]
	inbound=1,
	///<summary>
	///no description available
	///</summary>
	[Description("outbound")]
	outbound=2,
	///<summary>
	///no description available
	///</summary>
	[Description("one-way")]
	one_way=3,
	///<summary>
	///no description available
	///</summary>
	[Description("two-way")]
	two_way=4
}

///<summary>
///no description available
///</summary>
public enum categoryOfNavigationLine { 
	///<summary>
	///no description available
	///</summary>
	[Description("clearing line")]
	clearing_line=1,
	///<summary>
	///no description available
	///</summary>
	[Description("transit line")]
	transit_line=2,
	///<summary>
	///no description available
	///</summary>
	[Description("leading line bearing a recommended track")]
	leading_line_bearing_a_recommended_track=3
}

///<summary>
///no description available
///</summary>
public enum categoryOfPile { 
	///<summary>
	///no description available
	///</summary>
	[Description("stake")]
	stake=1,
	///<summary>
	///no description available
	///</summary>
	[Description("post")]
	post=2,
	///<summary>
	///no description available
	///</summary>
	[Description("tripodal")]
	tripodal=3
}

///<summary>
///no description available
///</summary>
public enum condition { 
	///<summary>
	///no description available
	///</summary>
	[Description("under construction")]
	under_construction=1,
	///<summary>
	///no description available
	///</summary>
	[Description("ruined")]
	ruined=2,
	///<summary>
	///no description available
	///</summary>
	[Description("under reclamation")]
	under_reclamation=3,
	///<summary>
	///no description available
	///</summary>
	[Description("wingless")]
	wingless=4,
	///<summary>
	///no description available
	///</summary>
	[Description("planned construction")]
	planned_construction=5
}

///<summary>
///no description available
///</summary>
public enum categoryOfSiloTank { 
	///<summary>
	///no description available
	///</summary>
	[Description("silo in general")]
	silo_in_general=1,
	///<summary>
	///no description available
	///</summary>
	[Description("tank in general")]
	tank_in_general=2,
	///<summary>
	///no description available
	///</summary>
	[Description("grain elevator")]
	grain_elevator=3,
	///<summary>
	///no description available
	///</summary>
	[Description("water tower")]
	water_tower=4
}

///<summary>
///no description available
///</summary>
public enum product { 
	///<summary>
	///no description available
	///</summary>
	[Description("oil")]
	oil=1,
	///<summary>
	///no description available
	///</summary>
	[Description("gas")]
	gas=2,
	///<summary>
	///no description available
	///</summary>
	[Description("water")]
	water=3,
	///<summary>
	///no description available
	///</summary>
	[Description("stone")]
	stone=4,
	///<summary>
	///no description available
	///</summary>
	[Description("coal")]
	coal=5,
	///<summary>
	///no description available
	///</summary>
	[Description("ore")]
	ore=6,
	///<summary>
	///no description available
	///</summary>
	[Description("chemicals")]
	chemicals=7,
	///<summary>
	///no description available
	///</summary>
	[Description("drinking water")]
	drinking_water=8,
	///<summary>
	///no description available
	///</summary>
	[Description("milk")]
	milk=9,
	///<summary>
	///no description available
	///</summary>
	[Description("bauxite")]
	bauxite=10,
	///<summary>
	///no description available
	///</summary>
	[Description("coke")]
	coke=11,
	///<summary>
	///no description available
	///</summary>
	[Description("iron ingots")]
	iron_ingots=12,
	///<summary>
	///no description available
	///</summary>
	[Description("salt")]
	salt=13,
	///<summary>
	///no description available
	///</summary>
	[Description("sand")]
	sand=14,
	///<summary>
	///no description available
	///</summary>
	[Description("timber")]
	timber=15,
	///<summary>
	///no description available
	///</summary>
	[Description("sawdust/wood chips")]
	sawdust_wood_chips=16,
	///<summary>
	///no description available
	///</summary>
	[Description("scrap metal")]
	scrap_metal=17,
	///<summary>
	///no description available
	///</summary>
	[Description("liquified natural gas (LNG)")]
	liquified_natural_gas__LNG_=18,
	///<summary>
	///no description available
	///</summary>
	[Description("liquified petroleum gas (LPG)")]
	liquified_petroleum_gas__LPG_=19,
	///<summary>
	///no description available
	///</summary>
	[Description("wine")]
	wine=20,
	///<summary>
	///no description available
	///</summary>
	[Description("cement")]
	cement=21,
	///<summary>
	///no description available
	///</summary>
	[Description("grain")]
	grain=22
}

///<summary>
///no description available
///</summary>
public enum categoryOfLandmark { 
	///<summary>
	///no description available
	///</summary>
	[Description("cairn")]
	cairn=1,
	///<summary>
	///no description available
	///</summary>
	[Description("cemetery")]
	cemetery=2,
	///<summary>
	///no description available
	///</summary>
	[Description("chimney")]
	chimney=3,
	///<summary>
	///no description available
	///</summary>
	[Description("dish aerial")]
	dish_aerial=4,
	///<summary>
	///no description available
	///</summary>
	[Description("flagstaff (flagpole)")]
	flagstaff__flagpole_=5,
	///<summary>
	///no description available
	///</summary>
	[Description("flare stack")]
	flare_stack=6,
	///<summary>
	///no description available
	///</summary>
	[Description("mast")]
	mast=7,
	///<summary>
	///no description available
	///</summary>
	[Description("windsock")]
	windsock=8,
	///<summary>
	///no description available
	///</summary>
	[Description("monument")]
	monument=9,
	///<summary>
	///no description available
	///</summary>
	[Description("column (pillar)")]
	column__pillar_=10,
	///<summary>
	///no description available
	///</summary>
	[Description("memorial plaque")]
	memorial_plaque=11,
	///<summary>
	///no description available
	///</summary>
	[Description("obelisk")]
	obelisk=12,
	///<summary>
	///no description available
	///</summary>
	[Description("statue")]
	statue=13,
	///<summary>
	///no description available
	///</summary>
	[Description("cross")]
	cross=14,
	///<summary>
	///no description available
	///</summary>
	[Description("dome")]
	dome=15,
	///<summary>
	///no description available
	///</summary>
	[Description("radar scanner")]
	radar_scanner=16,
	///<summary>
	///no description available
	///</summary>
	[Description("tower")]
	tower=17,
	///<summary>
	///no description available
	///</summary>
	[Description("windmill")]
	windmill=18,
	///<summary>
	///no description available
	///</summary>
	[Description("windmotor")]
	windmotor=19,
	///<summary>
	///no description available
	///</summary>
	[Description("spire/minaret")]
	spire_minaret=20,
	///<summary>
	///no description available
	///</summary>
	[Description("large rock or boulder on land")]
	large_rock_or_boulder_on_land=21
}

///<summary>
///no description available
///</summary>
public enum function { 
	///<summary>
	///no description available
	///</summary>
	[Description("harbour-master's office")]
	harbour_master_s_office=1,
	///<summary>
	///no description available
	///</summary>
	[Description("custom office")]
	custom_office=2,
	///<summary>
	///no description available
	///</summary>
	[Description("health office")]
	health_office=3,
	///<summary>
	///no description available
	///</summary>
	[Description("hospital")]
	hospital=4,
	///<summary>
	///no description available
	///</summary>
	[Description("post office")]
	post_office=5,
	///<summary>
	///no description available
	///</summary>
	[Description("hotel")]
	hotel=6,
	///<summary>
	///no description available
	///</summary>
	[Description("railway station")]
	railway_station=7,
	///<summary>
	///no description available
	///</summary>
	[Description("police station")]
	police_station=8,
	///<summary>
	///no description available
	///</summary>
	[Description("water-police station")]
	water_police_station=9,
	///<summary>
	///no description available
	///</summary>
	[Description("pilot office")]
	pilot_office=10,
	///<summary>
	///no description available
	///</summary>
	[Description("pilot lookout")]
	pilot_lookout=11,
	///<summary>
	///no description available
	///</summary>
	[Description("bank office")]
	bank_office=12,
	///<summary>
	///no description available
	///</summary>
	[Description("headquarters for district control")]
	headquarters_for_district_control=13,
	///<summary>
	///no description available
	///</summary>
	[Description("transit shed/warehouse")]
	transit_shed_warehouse=14,
	///<summary>
	///no description available
	///</summary>
	[Description("factory")]
	factory=15,
	///<summary>
	///no description available
	///</summary>
	[Description("power station")]
	power_station=16,
	///<summary>
	///no description available
	///</summary>
	[Description("administrative")]
	administrative=17,
	///<summary>
	///no description available
	///</summary>
	[Description("educational facility")]
	educational_facility=18,
	///<summary>
	///no description available
	///</summary>
	[Description("church")]
	church=19,
	///<summary>
	///no description available
	///</summary>
	[Description("chapel")]
	chapel=20,
	///<summary>
	///no description available
	///</summary>
	[Description("temple")]
	temple=21,
	///<summary>
	///no description available
	///</summary>
	[Description("pagoda")]
	pagoda=22,
	///<summary>
	///no description available
	///</summary>
	[Description("shinto shrine")]
	shinto_shrine=23,
	///<summary>
	///no description available
	///</summary>
	[Description("buddhist temple")]
	buddhist_temple=24,
	///<summary>
	///no description available
	///</summary>
	[Description("mosque")]
	mosque=25,
	///<summary>
	///no description available
	///</summary>
	[Description("marabout")]
	marabout=26,
	///<summary>
	///no description available
	///</summary>
	[Description("lookout")]
	lookout=27,
	///<summary>
	///no description available
	///</summary>
	[Description("communication")]
	communication=28,
	///<summary>
	///no description available
	///</summary>
	[Description("television")]
	television=29,
	///<summary>
	///no description available
	///</summary>
	[Description("radio")]
	radio=30,
	///<summary>
	///no description available
	///</summary>
	[Description("radar")]
	radar=31,
	///<summary>
	///no description available
	///</summary>
	[Description("light support")]
	light_support=32,
	///<summary>
	///no description available
	///</summary>
	[Description("microwave")]
	microwave=33,
	///<summary>
	///no description available
	///</summary>
	[Description("cooling")]
	cooling=34,
	///<summary>
	///no description available
	///</summary>
	[Description("observation")]
	observation=35,
	///<summary>
	///no description available
	///</summary>
	[Description("timeball")]
	timeball=36,
	///<summary>
	///no description available
	///</summary>
	[Description("clock")]
	clock=37,
	///<summary>
	///no description available
	///</summary>
	[Description("control")]
	control=38,
	///<summary>
	///no description available
	///</summary>
	[Description("airship mooring")]
	airship_mooring=39,
	///<summary>
	///no description available
	///</summary>
	[Description("stadium")]
	stadium=40,
	///<summary>
	///no description available
	///</summary>
	[Description("bus station")]
	bus_station=41
}

///<summary>
///no description available
///</summary>
public enum categoryOfOffshorePlatform { 
	///<summary>
	///no description available
	///</summary>
	[Description("oil derrick/rig")]
	oil_derrick_rig=1,
	///<summary>
	///no description available
	///</summary>
	[Description("production platform")]
	production_platform=2,
	///<summary>
	///no description available
	///</summary>
	[Description("observation/research platform")]
	observation_research_platform=3,
	///<summary>
	///no description available
	///</summary>
	[Description("articulated loading platform (ALP)")]
	articulated_loading_platform__ALP_=4,
	///<summary>
	///no description available
	///</summary>
	[Description("single anchor leg mooring (SALM)")]
	single_anchor_leg_mooring__SALM_=5,
	///<summary>
	///no description available
	///</summary>
	[Description("mooring tower")]
	mooring_tower=6,
	///<summary>
	///no description available
	///</summary>
	[Description("artificial island")]
	artificial_island=7,
	///<summary>
	///no description available
	///</summary>
	[Description("floating production, storage and off-loading vessel (FPSO)")]
	floating_production__storage_and_off_loading_vessel__FPSO_=8,
	///<summary>
	///no description available
	///</summary>
	[Description("accommodation platform")]
	accommodation_platform=9,
	///<summary>
	///no description available
	///</summary>
	[Description("navigation, communication and control buoy (NCCB)")]
	navigation__communication_and_control_buoy__NCCB_=10
}

///<summary>
///no description available
///</summary>
public enum qualityOfPosition { 
	///<summary>
	///no description available
	///</summary>
	[Description("surveyed")]
	surveyed=1,
	///<summary>
	///no description available
	///</summary>
	[Description("unsurveyed")]
	unsurveyed=2,
	///<summary>
	///no description available
	///</summary>
	[Description("inadequately surveyed")]
	inadequately_surveyed=3,
	///<summary>
	///no description available
	///</summary>
	[Description("approximate")]
	approximate=4,
	///<summary>
	///no description available
	///</summary>
	[Description("position doubtful")]
	position_doubtful=5,
	///<summary>
	///no description available
	///</summary>
	[Description("unreliable")]
	unreliable=6,
	///<summary>
	///no description available
	///</summary>
	[Description("reported (not surveyed)")]
	reported__not_surveyed_=7,
	///<summary>
	///no description available
	///</summary>
	[Description("reported (not confirmed)")]
	reported__not_confirmed_=8,
	///<summary>
	///no description available
	///</summary>
	[Description("estimated")]
	estimated=9,
	///<summary>
	///no description available
	///</summary>
	[Description("precisely known")]
	precisely_known=10,
	///<summary>
	///no description available
	///</summary>
	[Description("calculated")]
	calculated=11
}

///<summary>
///no description available
///</summary>
public enum IALA_aidAvailabilityCategory { 
	///<summary>
	///no description available
	///</summary>
	[Description("Category 1")]
	Category_1=1,
	///<summary>
	///no description available
	///</summary>
	[Description("Category 2")]
	Category_2=2,
	///<summary>
	///no description available
	///</summary>
	[Description("Category 3")]
	Category_3=3
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
///Generalized feature type which carry all the common attributes
///</summary>
public abstract class FeatureType : S100.AbstractFeatureType { 


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


	protected InformationTypeType( gml.ID id) : base( id)
	{
	}

	protected InformationTypeType(): base()
	{}

}

///<summary>
///Acronym: LIGHTS Code: 75 Light LIGHTS 75 Definition: A luminous or lighted aid to navigation. (adapted from IHO Dictionary, S-32, 5th Edition, 2766) References: INT 1: IP 1-30.3, 40-65; M-4: 470-473.5; 475-475.7; 476-478,5; Remarks: A light may be fixed on a buoy, beacon, tower etc. These are separate objects. Distinction: beacon, cardinal; beacon, isolated danger; beacon, lateral; beacon, safe water; beacon special purpose/general; buoy, cardinal; buoy, installation; buoy, isolated danger; buoy, lateral; buoy, safe water; buoy, special purpose/general; light vessel; light float;
///</summary>
public class Light : Equipment { 

	public categoryOfLight[] categoryOfLight;
	public colour colour;
	public exhibitionConditionOfLight exhibitionConditionOfLight;
	public decimal height;
	public lightCharacteristic lightCharacteristic;
	public lightVisibility[] lightVisibility;
	public marksNavigationalSystemOf marksNavigationalSystemOf;
	public int multiplicityOfLights;
	public string objectNameInNationalLanguage;
	public string objectName;
	public decimal orientation;
	public int sectorLimitOne;
	public int sectorLimitTwo;
	public string signalGroup;
	public string signalPeriod;
	public string signalSequence;
	public status[] status;
	public decimal verticalAccuracy;
	public decimal valueOfNominalRange;
	public verticalDatum verticalDatum;
	public string IALA_typeOfLight;
	public string IALA_typeOfBattery;
	public decimal IALA_valueOfGeographicalRange;
	public decimal IALA_valueOfLuminousRange;

	public Light( colour colour, lightCharacteristic lightCharacteristic, PointPropertyType geometry, string idCode, gml.ID id) : base( geometry, idCode, id)
	{
		this.colour=colour;
		this.lightCharacteristic=lightCharacteristic;
	}

	protected Light(): base()
	{}

}

///<summary>
///no description available
///</summary>
public class BeaconCardinal : GenericBeacon { 

	public categoryOfCardinalMark categoryOfCardinalMark;

	public BeaconCardinal( categoryOfCardinalMark categoryOfCardinalMark, beaconShape beaconShape, colour[] colour, IALA_aidAvailabilityCategory IALA_aidAvailabilityCategory, string idCode, gml.ID id) : base( beaconShape, colour, IALA_aidAvailabilityCategory, idCode, id)
	{
		this.categoryOfCardinalMark=categoryOfCardinalMark;
	}

	protected BeaconCardinal(): base()
	{}

}

///<summary>
///no description available
///</summary>
public abstract class AidsToNavigation : FeatureType { 

	public string idCode;
	public S100_TruncatedDate dateEnd;
	public S100_TruncatedDate dateStart;
	public S100_TruncatedDate periodEnd;
	public S100_TruncatedDate periodStart;
	public string[] information;
	public string[] informationInNationalLanguage;
	public string textualDescriptionInNationalLanguage;
	public string textualDescription;
	public int scaleMinimum;
	public dateTime sourceDate;
	public string sourceIndication;
	public string pictorialRepresentation;
	public string IALA_inspectionFrequency;
	public string IALA_inspectionRequirements;
	public anyURI IALA_AtoNMaintenanceRecord;
	public S100_TruncatedDate IALA_installationDate;
	public ReferenceType[] peer;

	protected AidsToNavigation( string idCode, gml.ID id) : base( id)
	{
		this.idCode=idCode;
	}

	protected AidsToNavigation(): base()
	{}

}

///<summary>
///Definition: A beacon is a prominent specially constructed object forming a conspicuous mark as a fixed aid to navigation or for use in hydrographic survey (IHO Dictionary, S-32, 5th Edition, 420). An isolated danger beacon is a beacon erected on an isolated danger of limited extent, which has navigable water all around it. (UKHO NP735, 5th Edition)
///</summary>
public class BeaconIsolatedDanger : GenericBeacon { 


	public BeaconIsolatedDanger( beaconShape beaconShape, colour[] colour, IALA_aidAvailabilityCategory IALA_aidAvailabilityCategory, string idCode, gml.ID id) : base( beaconShape, colour, IALA_aidAvailabilityCategory, idCode, id)
	{
	}

	protected BeaconIsolatedDanger(): base()
	{}

}

///<summary>
///Definition: A beacon is a prominent specially constructed object forming a conspicuous mark as a fixed aid to navigation or for use in hydrographic survey (IHO Dictionary, S-32, 5th Edition, 420). A lateral beacon is used to indicate the port or starboard hand side of the route to be followed. They are generally used for well defined channels and are used in conjunction with a conventional direction of buoyage. (UKHO NP 735, 5th Edition)
///</summary>
public class BeaconLateral : GenericBeacon { 

	public categoryOfLateralMark categoryOfLateralMark;

	public BeaconLateral( categoryOfLateralMark categoryOfLateralMark, beaconShape beaconShape, colour[] colour, IALA_aidAvailabilityCategory IALA_aidAvailabilityCategory, string idCode, gml.ID id) : base( beaconShape, colour, IALA_aidAvailabilityCategory, idCode, id)
	{
		this.categoryOfLateralMark=categoryOfLateralMark;
	}

	protected BeaconLateral(): base()
	{}

}

///<summary>
///Definition: A safe water beacon is a prominent specially constructed object forming a conspicuous mark as a fixed aid to navigation or for use in hydrographic survey (IHO Dictionary, S-32, 5th Edition, 420). A safe water beacon may be used to indicate that there is navigable water around the mark. (UKHO NP735, 5th Edition)
///</summary>
public class BeaconSafeWater : GenericBeacon { 


	public BeaconSafeWater( beaconShape beaconShape, colour[] colour, IALA_aidAvailabilityCategory IALA_aidAvailabilityCategory, string idCode, gml.ID id) : base( beaconShape, colour, IALA_aidAvailabilityCategory, idCode, id)
	{
	}

	protected BeaconSafeWater(): base()
	{}

}

///<summary>
///Definition: A beacon is a prominent specially constructed object forming a conspicuous mark as a fixed aid to navigation or for use in hydrographic survey (IHO Dictionary, S-32, 5th Edition, 420). A special purpose beacon is primarily used to indicate an area or feature, the nature of which is apparent from reference to a chart, Sailing Directions or Notices to Mariners. (UKHO NP 735, 5th Edition) Beacon in general: A beacon whose appearance or purpose is not adequately known.
///</summary>
public class BeaconSpecialPurposeGeneral : GenericBeacon { 

	public categoryOfSpecialPurposeMark[] categoryOfSpecialPurposeMark;

	public BeaconSpecialPurposeGeneral( categoryOfSpecialPurposeMark[] categoryOfSpecialPurposeMark, beaconShape beaconShape, colour[] colour, IALA_aidAvailabilityCategory IALA_aidAvailabilityCategory, string idCode, gml.ID id) : base( beaconShape, colour, IALA_aidAvailabilityCategory, idCode, id)
	{
		this.categoryOfSpecialPurposeMark=categoryOfSpecialPurposeMark;
	}

	protected BeaconSpecialPurposeGeneral(): base()
	{}

}

///<summary>
///If structure is unknown, a pile feature instance should be used and all co-located equipment should be associated to the pile.
///</summary>
public abstract class Equipment : AidsToNavigation { 

	public string[] IALA_remoteMonitoringSystem;
	public boolean IALA_remotelyMonitored;
	public ReferenceType parent;
	public PointPropertyType geometry;

	protected Equipment( PointPropertyType geometry, string idCode, gml.ID id) : base( idCode, id)
	{
		this.geometry=geometry;
	}

	protected Equipment(): base()
	{}

}

///<summary>
///no description available
///</summary>
public class BuoyCardinal : GenericBuoy { 

	public categoryOfCardinalMark categoryOfCardinalMark;

	public BuoyCardinal( categoryOfCardinalMark categoryOfCardinalMark, buoyShape buoyShape, colour[] colour, IALA_aidAvailabilityCategory IALA_aidAvailabilityCategory, string idCode, gml.ID id) : base( buoyShape, colour, IALA_aidAvailabilityCategory, idCode, id)
	{
		this.categoryOfCardinalMark=categoryOfCardinalMark;
	}

	protected BuoyCardinal(): base()
	{}

}

///<summary>
///no description available
///</summary>
public class BuoyInstallation : GenericBuoy { 

	public categoryOfInstallationBuoy categoryOfInstallationBuoy;

	public BuoyInstallation( categoryOfInstallationBuoy categoryOfInstallationBuoy, buoyShape buoyShape, colour[] colour, IALA_aidAvailabilityCategory IALA_aidAvailabilityCategory, string idCode, gml.ID id) : base( buoyShape, colour, IALA_aidAvailabilityCategory, idCode, id)
	{
		this.categoryOfInstallationBuoy=categoryOfInstallationBuoy;
	}

	protected BuoyInstallation(): base()
	{}

}

///<summary>
///no description available
///</summary>
public class BuoyIsolatedDanger : GenericBuoy { 


	public BuoyIsolatedDanger( buoyShape buoyShape, colour[] colour, IALA_aidAvailabilityCategory IALA_aidAvailabilityCategory, string idCode, gml.ID id) : base( buoyShape, colour, IALA_aidAvailabilityCategory, idCode, id)
	{
	}

	protected BuoyIsolatedDanger(): base()
	{}

}

///<summary>
///no description available
///</summary>
public class BuoyLateral : GenericBuoy { 

	public categoryOfLateralMark categoryOfLateralMark;

	public BuoyLateral( categoryOfLateralMark categoryOfLateralMark, buoyShape buoyShape, colour[] colour, IALA_aidAvailabilityCategory IALA_aidAvailabilityCategory, string idCode, gml.ID id) : base( buoyShape, colour, IALA_aidAvailabilityCategory, idCode, id)
	{
		this.categoryOfLateralMark=categoryOfLateralMark;
	}

	protected BuoyLateral(): base()
	{}

}

///<summary>
///no description available
///</summary>
public class BuoySafeWater : GenericBuoy { 


	public BuoySafeWater( buoyShape buoyShape, colour[] colour, IALA_aidAvailabilityCategory IALA_aidAvailabilityCategory, string idCode, gml.ID id) : base( buoyShape, colour, IALA_aidAvailabilityCategory, idCode, id)
	{
	}

	protected BuoySafeWater(): base()
	{}

}

///<summary>
///Definition: A buoy is a floating object moored to the bottom in a particular place, as an aid to navigation or for other specific purposes. (IHO Dictionary, S-32, 5th Edition, 565). A special purpose buoy is primarily used to indicate an area or feature, the nature of which is apparent from reference to a chart, Sailing Directions or Notices to Mariners. (UKHO NP 735, 5th Edition) Buoy in general: A buoy whose appearance or purpose is not adequately known.
///</summary>
public class BuoySpecialPurposeGeneral : GenericBuoy { 

	public categoryOfSpecialPurposeMark[] categoryOfSpecialPurposeMark;

	public BuoySpecialPurposeGeneral( categoryOfSpecialPurposeMark[] categoryOfSpecialPurposeMark, buoyShape buoyShape, colour[] colour, IALA_aidAvailabilityCategory IALA_aidAvailabilityCategory, string idCode, gml.ID id) : base( buoyShape, colour, IALA_aidAvailabilityCategory, idCode, id)
	{
		this.categoryOfSpecialPurposeMark=categoryOfSpecialPurposeMark;
	}

	protected BuoySpecialPurposeGeneral(): base()
	{}

}

///<summary>
///To simplify things, Daymark can only be equipment in this model. If Daymark is in navigable water, it should be associated with a pile or another appropriate structure feature instance.
///</summary>
public class Daymark : Equipment { 

	public categoryOfSpecialPurposeMark categoryOfSpecialPurposeMark;
	public colour[] colour;
	public colourPattern[] colourPattern;
	public decimal elevation;
	public decimal height;
	public natureOfConstruction[] natureOfConstruction;
	public string objectNameInNationalLanguage;
	public string objectName;
	public status[] status;
	public topmarkDaymarkShape topmarkDaymarkShape;
	public decimal verticalAccuracy;
	public verticalDatum verticalDatum;
	public decimal verticalLength;

	public Daymark( colour[] colour, topmarkDaymarkShape topmarkDaymarkShape, PointPropertyType geometry, string idCode, gml.ID id) : base( geometry, idCode, id)
	{
		this.colour=colour;
		this.topmarkDaymarkShape=topmarkDaymarkShape;
	}

	protected Daymark(): base()
	{}

}

///<summary>
///no description available
///</summary>
public class FogSignal : Equipment { 

	public categoryOfFogSignal categoryOfFogSignal;
	public int signalFrequency;
	public signalGeneration signalGeneration;
	public string signalGroup;
	public decimal signalPeriod;
	public string signalSequence;
	public status[] status;
	public decimal valueOfMaximumRange;
	public decimal IALA_signalOutput;
	public string IALA_typeOfBattery;

	public FogSignal( categoryOfFogSignal categoryOfFogSignal, PointPropertyType geometry, string idCode, gml.ID id) : base( geometry, idCode, id)
	{
		this.categoryOfFogSignal=categoryOfFogSignal;
	}

	protected FogSignal(): base()
	{}

}

///<summary>
///no description available
///</summary>
public class Landmark : StructureObject { 

	public categoryOfLandmark[] categoryOfLandmark;
	public colour[] colour;
	public colourPattern[] colourPattern;
	public condition condition;
	public radarConspicuous radarConspicuous;
	public visuallyConspicuous visuallyConspicuous;
	public decimal elevation;
	public function[] function;
	public decimal height;
	public natureOfConstruction[] natureOfConstruction;
	public string objectNameInNationalLanguage;
	public string objectName;
	public status[] status;
	public decimal verticalAccuracy;
	public verticalDatum verticalDatum;
	public decimal verticalLength;
	public boolean IALA_mannedStructure;
	public PointCurveSurfacePropertyType geometry;

	public Landmark( categoryOfLandmark[] categoryOfLandmark, visuallyConspicuous visuallyConspicuous, PointCurveSurfacePropertyType geometry, IALA_aidAvailabilityCategory IALA_aidAvailabilityCategory, string idCode, gml.ID id) : base( IALA_aidAvailabilityCategory, idCode, id)
	{
		this.categoryOfLandmark=categoryOfLandmark;
		this.visuallyConspicuous=visuallyConspicuous;
		this.geometry=geometry;
	}

	protected Landmark(): base()
	{}

}

///<summary>
///no description available
///</summary>
public class LightFloat : StructureObject { 

	public colour[] colour;
	public colourPattern[] colourPattern;
	public radarConspicuous radarConspicuous;
	public visuallyConspicuous visuallyConspicuous;
	public decimal horizontalAccuracy;
	public decimal horizontalLength;
	public decimal horizontalWidth;
	public natureOfConstruction[] natureOfConstruction;
	public string objectNameInNationalLanguage;
	public string objectName;
	public status[] status;
	public decimal verticalAccuracy;
	public decimal verticalLength;
	public boolean IALA_mannedStructure;
	public PointPropertyType geometry;

	public LightFloat( colour[] colour, IALA_aidAvailabilityCategory IALA_aidAvailabilityCategory, string idCode, gml.ID id) : base( IALA_aidAvailabilityCategory, idCode, id)
	{
		this.colour=colour;
	}

	protected LightFloat(): base()
	{}

}

///<summary>
///Definition: A distinctively marked vessel anchored or moored at a charted point, to serve as an aid to navigation. By night, it displays a characteristic light(s) and is usually equipped with other devices, such as fog signal, submarine sound signal, and radio-beacon, to assist navigation. Also called light ship. (IHO Dictionary, S-32, 5th Edition, 2828,2829)
///</summary>
public class LightVessel : StructureObject { 

	public colour[] colour;
	public colourPattern[] colourPattern;
	public radarConspicuous radarConspicuous;
	public visuallyConspicuous visuallyConspicuous;
	public decimal horizontalAccuracy;
	public decimal horizontalLength;
	public decimal horizontalWidth;
	public natureOfConstruction[] natureOfConstruction;
	public string objectNameInNationalLanguage;
	public string objectName;
	public status[] status;
	public decimal verticalAccuracy;
	public decimal verticalLength;
	public boolean IALA_mannedStructure;
	public PointPropertyType geometry;

	public LightVessel( colour[] colour, IALA_aidAvailabilityCategory IALA_aidAvailabilityCategory, string idCode, gml.ID id) : base( IALA_aidAvailabilityCategory, idCode, id)
	{
		this.colour=colour;
	}

	protected LightVessel(): base()
	{}

}

///<summary>
///no description available
///</summary>
public class NavigationLine : AidsToNavigation { 

	public categoryOfNavigationLine categoryOfNavigationLine;
	public decimal orientation;
	public status[] status;
	public ReferenceType[] navigableTrack;
	public CurvePropertyType geometry;

	public NavigationLine( categoryOfNavigationLine categoryOfNavigationLine, decimal orientation, CurvePropertyType geometry, string idCode, gml.ID id) : base( idCode, id)
	{
		this.categoryOfNavigationLine=categoryOfNavigationLine;
		this.orientation=orientation;
		this.geometry=geometry;
	}

	protected NavigationLine(): base()
	{}

}

///<summary>
///Definition: A permanent offshore structure, either fixed or floating, used in the production of oil or natural gas. (IHO Dictionary, S-32, 5th Edition, 3895)
///</summary>
public class OffshorePlatform : StructureObject { 

	public categoryOfOffshorePlatform[] categoryOfOffshorePlatform;
	public colour[] colour;
	public colourPattern[] colourPattern;
	public condition condition;
	public radarConspicuous radarConspicuous;
	public visuallyConspicuous visuallyConspicuous;
	public decimal height;
	public natureOfConstruction[] natureOfConstruction;
	public string objectNameInNationalLanguage;
	public product[] product;
	public string objectName;
	public status[] status;
	public decimal verticalAccuracy;
	public verticalDatum verticalDatum;
	public decimal verticalLength;
	public boolean IALA_mannedStructure;
	public PointOrSurfacePropertyType geometry;

	public OffshorePlatform( PointOrSurfacePropertyType geometry, IALA_aidAvailabilityCategory IALA_aidAvailabilityCategory, string idCode, gml.ID id) : base( IALA_aidAvailabilityCategory, idCode, id)
	{
		this.geometry=geometry;
	}

	protected OffshorePlatform(): base()
	{}

}

///<summary>
///Definition: A long heavy timber or section of steel, wood, concrete, etc.. forced into the earth which may serve as a support, as for a pier, or a free standing pole within a marine environment. (Adapted from IHO Dictionary, S-32, 5th Edition, 3840)
///</summary>
public class Pile : StructureObject { 

	public categoryOfPile categoryOfPile;
	public colour[] colour;
	public colourPattern[] colourPattern;
	public condition condition;
	public visuallyConspicuous visuallyConspicuous;
	public decimal height;
	public decimal verticalAccuracy;
	public verticalDatum verticalDatum;
	public decimal verticalLength;
	public PointPropertyType geometry;

	public Pile( IALA_aidAvailabilityCategory IALA_aidAvailabilityCategory, string idCode, gml.ID id) : base( IALA_aidAvailabilityCategory, idCode, id)
	{
	}

	protected Pile(): base()
	{}

}

///<summary>
///Definition: A device capable of, or intended for, reflecting radar signals. (IHO Dictionary, S-32, 5th Edition, 4147) A radar reflector is usually a >tetrahedron or pentagonal corner reflector (...) to facilitate reflection towards the sender. (International Maritime Dictionary, 2nd Ed.)
///</summary>
public class RadarReflector : Equipment { 

	public decimal height;
	public status[] status;
	public decimal verticalAccuracy;
	public verticalDatum verticalDatum;

	public RadarReflector( PointPropertyType geometry, string idCode, gml.ID id) : base( geometry, idCode, id)
	{
	}

	protected RadarReflector(): base()
	{}

}

///<summary>
///Definition: A transponder beacon transmitting a coded signal on radar frequency, permitting an interrogating craft to determine the bearing and range of the transponder. Also called racon. (IHO Dictionary, S-32, 5th Edition, 4137)
///</summary>
public class RadarTransponderBeacon : Equipment { 

	public categoryOfRadarTransponderBeacon categoryOfRadarTransponderBeacon;
	public string objectNameInNationalLanguage;
	public string objectName;
	public string radarWaveLength;
	public int sectorLimitOne;
	public int sectorLimitTwo;
	public string signalGroup;
	public string signalSequence;
	public status[] status;
	public decimal valueOfNominalRange;
	public string IALA_typeOfBattery;

	public RadarTransponderBeacon( categoryOfRadarTransponderBeacon categoryOfRadarTransponderBeacon, PointPropertyType geometry, string idCode, gml.ID id) : base( geometry, idCode, id)
	{
		this.categoryOfRadarTransponderBeacon=categoryOfRadarTransponderBeacon;
	}

	protected RadarTransponderBeacon(): base()
	{}

}

///<summary>
///Definition: A track recommended to all or only certain vessels. (IHO Dictionary, S-32, 5th Edition, 5576)
///</summary>
public class RecommendedTrack : AidsToNavigation { 

	public categoryOfRecommendedTrack categoryOfRecommendedTrack;
	public decimal depthRangeMinimumValue;
	public decimal depthRangeMaximumValue;
	public string objectNameInNationalLanguage;
	public string objectName;
	public decimal orientation;
	public qualityOfSoundingMeasurement[] qualityOfSoundingMeasurement;
	public decimal soundingAccuracy;
	public status[] status;
	public techniqueOfSoundingMeasurement[] techniqueOfSoundingMeasurement;
	public trafficFlow trafficFlow;
	public verticalDatum verticalDatum;
	public ReferenceType[] navigationLine;
	public CurvePropertyType geometry;

	public RecommendedTrack( decimal orientation, CurvePropertyType geometry, string idCode, gml.ID id) : base( idCode, id)
	{
		this.orientation=orientation;
		this.geometry=geometry;
	}

	protected RecommendedTrack(): base()
	{}

}

///<summary>
///Definition: A means of distinguishing unlighted marks at night. Retro-reflective material is secured to the mark in a particular pattern to reflect back light. (Adapted from the UKHO NP735, 5th Edition).
///</summary>
public class RetroReflector : Equipment { 

	public colour[] colour;
	public colourPattern[] colourPattern;
	public decimal height;
	public marksNavigationalSystemOf marksNavigationalSystemOf;
	public status[] status;
	public decimal verticalAccuracy;
	public verticalDatum verticalDatum;

	public RetroReflector( PointPropertyType geometry, string idCode, gml.ID id) : base( geometry, idCode, id)
	{
	}

	protected RetroReflector(): base()
	{}

}

///<summary>
///Definition: An enclosed container, used for storage (Digital Geographic Information Working Group, Oct.87)
///</summary>
public class SiloTank : StructureObject { 

	public buildingShape buildingShape;
	public categoryOfSiloTank categoryOfSiloTank;
	public colour[] colour;
	public colourPattern[] colourPattern;
	public condition condition;
	public radarConspicuous radarConspicuous;
	public visuallyConspicuous visuallyConspicuous;
	public decimal elevation;
	public decimal height;
	public natureOfConstruction[] natureOfConstruction;
	public string objectNameInNationalLanguage;
	public string objectName;
	public product product;
	public status[] status;
	public decimal verticalAccuracy;
	public verticalDatum verticalDatum;
	public decimal verticalLength;
	public PointOrSurfacePropertyType geometry;

	public SiloTank( IALA_aidAvailabilityCategory IALA_aidAvailabilityCategory, string idCode, gml.ID id) : base( IALA_aidAvailabilityCategory, idCode, id)
	{
	}

	protected SiloTank(): base()
	{}

}

///<summary>
///Definition: A characteristic shape secured at the top of a buoy or beacon to aid in its identification. (IHO Dictionary, S-32, 5th Edition, 5548)
///</summary>
public class Topmark : Equipment { 

	public colour[] colour;
	public colourPattern[] colourPattern;
	public decimal height;
	public marksNavigationalSystemOf marksNavigationalSystemOf;
	public status[] status;
	public topmarkDaymarkShape topmarkDaymarkShape;
	public decimal verticalAccuracy;
	public verticalDatum verticalDatum;
	public decimal verticalLength;

	public Topmark( topmarkDaymarkShape topmarkDaymarkShape, PointPropertyType geometry, string idCode, gml.ID id) : base( geometry, idCode, id)
	{
		this.topmarkDaymarkShape=topmarkDaymarkShape;
	}

	protected Topmark(): base()
	{}

}

///<summary>
///no description available
///</summary>
public abstract class StructureObject : AidsToNavigation { 

	public IALA_aidAvailabilityCategory IALA_aidAvailabilityCategory;
	public contactAddress contactAddress;
	public ReferenceType[] child;

	protected StructureObject( IALA_aidAvailabilityCategory IALA_aidAvailabilityCategory, string idCode, gml.ID id) : base( idCode, id)
	{
		this.IALA_aidAvailabilityCategory=IALA_aidAvailabilityCategory;
	}

	protected StructureObject(): base()
	{}

}

///<summary>
///content of categoryOfAggregation should be put in information attribute when converting to S-57.
///</summary>
public class Aggregation : FeatureType { 

	public IALA_categoryOfAggregation IALA_categoryOfAggregation;
	public ReferenceType[] peer;

	public Aggregation( IALA_categoryOfAggregation IALA_categoryOfAggregation, gml.ID id) : base( id)
	{
		this.IALA_categoryOfAggregation=IALA_categoryOfAggregation;
	}

	protected Aggregation(): base()
	{}

}

///<summary>
///content of categoryOfAssociation should be put in information attribute when converting to S-57.
///</summary>
public class Association : FeatureType { 

	public IALA_categoryOfAssociation IALA_categoryOfAssociation;
	public ReferenceType[] peer;

	public Association( IALA_categoryOfAssociation IALA_categoryOfAssociation, gml.ID id) : base( id)
	{
		this.IALA_categoryOfAssociation=IALA_categoryOfAssociation;
	}

	protected Association(): base()
	{}

}

///<summary>
///no description available
///</summary>
public abstract class GenericBeacon : StructureObject { 

	public beaconShape beaconShape;
	public colour[] colour;
	public colourPattern[] colourPattern;
	public string condition;
	public radarConspicuous radarConspicuous;
	public visuallyConspicuous visuallyConspicuous;
	public decimal elevation;
	public decimal height;
	public marksNavigationalSystemOf marksNavigationalSystemOf;
	public natureOfConstruction[] natureOfConstruction;
	public decimal verticalLength;
	public decimal verticalAccuracy;
	public string objectNameInNationalLanguage;
	public string objectName;
	public status[] status;
	public PointPropertyType geometry;

	protected GenericBeacon( beaconShape beaconShape, colour[] colour, IALA_aidAvailabilityCategory IALA_aidAvailabilityCategory, string idCode, gml.ID id) : base( IALA_aidAvailabilityCategory, idCode, id)
	{
		this.beaconShape=beaconShape;
		this.colour=colour;
	}

	protected GenericBeacon(): base()
	{}

}

///<summary>
///no description available
///</summary>
public class SpatialUncertainty : InformationTypeType { 

	public qualityOfPosition qualityOfPosition;
	public decimal positionalAccuracy;

	public SpatialUncertainty( gml.ID id) : base( id)
	{
	}

	protected SpatialUncertainty(): base()
	{}

}

///<summary>
///no description available
///</summary>
public class IALA_EnvironmentObservationEquipment : Equipment { 

	public status[] status;
	public decimal height;
	public string[] IALA_typeOfEnvironmentObservationEquipment;
	public string IALA_typeOfBattery;

	public IALA_EnvironmentObservationEquipment( string[] IALA_typeOfEnvironmentObservationEquipment, PointPropertyType geometry, string idCode, gml.ID id) : base( geometry, idCode, id)
	{
		this.IALA_typeOfEnvironmentObservationEquipment=IALA_typeOfEnvironmentObservationEquipment;
	}

	protected IALA_EnvironmentObservationEquipment(): base()
	{}

}

///<summary>
///no description available
///</summary>
public abstract class GenericBuoy : StructureObject { 

	public buoyShape buoyShape;
	public colour[] colour;
	public colourPattern[] colourPattern;
	public radarConspicuous radarConspicious;
	public marksNavigationalSystemOf marksNavigationalSystemOf;
	public natureOfConstruction[] natureOfconstuction;
	public string objectNameInNationalLanguage;
	public string objectName;
	public status[] status;
	public decimal verticalAccuracy;
	public decimal verticalLength;
	public string IALA_typeOfBuoy;
	public PointPropertyType geometry;

	protected GenericBuoy( buoyShape buoyShape, colour[] colour, IALA_aidAvailabilityCategory IALA_aidAvailabilityCategory, string idCode, gml.ID id) : base( IALA_aidAvailabilityCategory, idCode, id)
	{
		this.buoyShape=buoyShape;
		this.colour=colour;
	}

	protected GenericBuoy(): base()
	{}

}

///<summary>
///no description available
///</summary>
public class contactAddress { 

	public string[] deliveryPoint;
	public string cityName;
	public string administrativeDivision;
	public string country;
	public string postalCode;

	public contactAddress()
	{
	}

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
///dataset member S-100 information types
///</summary>
public class IMemberType : gml.AbstractFeatureMemberType { 


	public IMemberType( gml.boolean owns) : base( owns)
	{
	}

	protected IMemberType(): base()
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
//Light refers same name
//BeaconCardinal refers same name
//AidsToNavigation refers same name
//BeaconIsolatedDanger refers same name
//BeaconLateral refers same name
//BeaconSafeWater refers same name
//BeaconSpecialPurposeGeneral refers same name
//Equipment refers same name
//BuoyCardinal refers same name
//BuoyInstallation refers same name
//BuoyIsolatedDanger refers same name
//BuoyLateral refers same name
//BuoySafeWater refers same name
//BuoySpecialPurposeGeneral refers same name
//Daymark refers same name
//FogSignal refers same name
//Landmark refers same name
//LightFloat refers same name
//LightVessel refers same name
//NavigationLine refers same name
//OffshorePlatform refers same name
//Pile refers same name
//RadarReflector refers same name
//RadarTransponderBeacon refers same name
//RecommendedTrack refers same name
//RetroReflector refers same name
//SiloTank refers same name
//Topmark refers same name
//StructureObject refers same name
//Aggregation refers same name
//Association refers same name
//GenericBeacon refers same name
//SpatialUncertainty refers same name
//IALA_EnvironmentObservationEquipment refers same name
//GenericBuoy refers same name

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

