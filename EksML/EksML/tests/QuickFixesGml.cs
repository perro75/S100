//EksML - S100 application schema to csCode 28.6.2017 15.37.02

using System;
using System.ComponentModel;

using gml;


namespace gml {


///<summary>
///
///</summary>

public struct nonNegativeInteger {

	private int VALUE;
		
	public static implicit operator int( nonNegativeInteger value ) {
		return value.VALUE;
	}
	
	public static implicit operator nonNegativeInteger( int value ) {
		var _ReturnValue = new nonNegativeInteger();
		_ReturnValue.VALUE = value;
		return _ReturnValue;
	}
	
	public override string ToString()
	{
		return this.VALUE.ToString();
	}
	
}

///<summary>
///
///</summary>

public struct positiveInteger {

	private int VALUE;
		
	public static implicit operator int( positiveInteger value ) {
		return value.VALUE;
	}
	
	public static implicit operator positiveInteger( int value ) {
		var _ReturnValue = new positiveInteger();
		_ReturnValue.VALUE = value;
		return _ReturnValue;
	}
	
	public override string ToString()
	{
		return this.VALUE.ToString();
	}
	
}

///<summary>
///
///</summary>

public struct integer {

	private int VALUE;
		
	public static implicit operator int( integer value ) {
		return value.VALUE;
	}
	
	public static implicit operator integer( int value ) {
		var _ReturnValue = new integer();
		_ReturnValue.VALUE = value;
		return _ReturnValue;
	}
	
	public override string ToString()
	{
		return this.VALUE.ToString();
	}
	
}

///<summary>
///
///</summary>

public struct duration {

	private int VALUE;
		
	public static implicit operator int( duration value ) {
		return value.VALUE;
	}
	
	public static implicit operator duration( int value ) {
		var _ReturnValue = new duration();
		_ReturnValue.VALUE = value;
		return _ReturnValue;
	}
	
	public override string ToString()
	{
		return this.VALUE.ToString();
	}
	
}

///<summary>
///
///</summary>

public struct gDay {

	private string VALUE;
		
	public static implicit operator string( gDay value ) {
		return value.VALUE;
	}
	
	public static implicit operator gDay( string value ) {
		var _ReturnValue = new gDay();
		_ReturnValue.VALUE = value;
		return _ReturnValue;
	}
	
	public override string ToString()
	{
		return this.VALUE.ToString();
	}
	
}

///<summary>
///
///</summary>

public struct gMonth {

	private string VALUE;
		
	public static implicit operator string( gMonth value ) {
		return value.VALUE;
	}
	
	public static implicit operator gMonth( string value ) {
		var _ReturnValue = new gMonth();
		_ReturnValue.VALUE = value;
		return _ReturnValue;
	}
	
	public override string ToString()
	{
		return this.VALUE.ToString();
	}
	
}

///<summary>
///
///</summary>

public struct gMonthDay {

	private string VALUE;
		
	public static implicit operator string( gMonthDay value ) {
		return value.VALUE;
	}
	
	public static implicit operator gMonthDay( string value ) {
		var _ReturnValue = new gMonthDay();
		_ReturnValue.VALUE = value;
		return _ReturnValue;
	}
	
	public override string ToString()
	{
		return this.VALUE.ToString();
	}
	
}

///<summary>
///
///</summary>

public struct gYear {

	private string VALUE;
		
	public static implicit operator string( gYear value ) {
		return value.VALUE;
	}
	
	public static implicit operator gYear( string value ) {
		var _ReturnValue = new gYear();
		_ReturnValue.VALUE = value;
		return _ReturnValue;
	}
	
	public override string ToString()
	{
		return this.VALUE.ToString();
	}
	
}

///<summary>
///
///</summary>

public struct gYearMonth {

	private string VALUE;
		
	public static implicit operator string( gYearMonth value ) {
		return value.VALUE;
	}
	
	public static implicit operator gYearMonth( string value ) {
		var _ReturnValue = new gYearMonth();
		_ReturnValue.VALUE = value;
		return _ReturnValue;
	}
	
	public override string ToString()
	{
		return this.VALUE.ToString();
	}
	
}

///<summary>
///
///</summary>

public struct anyURI {

	private string VALUE;
		
	public static implicit operator string( anyURI value ) {
		return value.VALUE;
	}
	
	public static implicit operator anyURI( string value ) {
		var _ReturnValue = new anyURI();
		_ReturnValue.VALUE = value;
		return _ReturnValue;
	}
	
	public override string ToString()
	{
		return this.VALUE.ToString();
	}
	
}

///<summary>
///
///</summary>

public struct Name {

	private string VALUE;
		
	public static implicit operator string( Name value ) {
		return value.VALUE;
	}
	
	public static implicit operator Name( string value ) {
		var _ReturnValue = new Name();
		_ReturnValue.VALUE = value;
		return _ReturnValue;
	}
	
	public override string ToString()
	{
		return this.VALUE.ToString();
	}
	
}

///<summary>
///
///</summary>

public struct ID {

	private string VALUE;
		
	public static implicit operator string( ID value ) {
		return value.VALUE;
	}
	
	public static implicit operator ID( string value ) {
		var _ReturnValue = new ID();
		_ReturnValue.VALUE = value;
		return _ReturnValue;
	}
	
	public override string ToString()
	{
		return this.VALUE.ToString();
	}
	
}

///<summary>
///
///</summary>

public struct date {

	private DateTime VALUE;
		
	public static implicit operator DateTime( date value ) {
		return value.VALUE;
	}
	
	public static implicit operator date( DateTime value ) {
		var _ReturnValue = new date();
		_ReturnValue.VALUE = value;
		return _ReturnValue;
	}
	
	public override string ToString()
	{
		return this.VALUE.ToString();
	}
	
	
	public string ToString(string format)
	{
		return this.VALUE.ToString(format);
	}
}

///<summary>
///
///</summary>

public struct dateTime {

	private DateTime VALUE;
		
	public static implicit operator DateTime( dateTime value ) {
		return value.VALUE;
	}
	
	public static implicit operator dateTime( DateTime value ) {
		var _ReturnValue = new dateTime();
		_ReturnValue.VALUE = value;
		return _ReturnValue;
	}
	
	public override string ToString()
	{
		return this.VALUE.ToString();
	}
	
	
	public string ToString(string format)
	{
		return this.VALUE.ToString(format);
	}
}

///<summary>
///
///</summary>

public struct boolean {

	private bool VALUE;
		
	public static implicit operator bool( boolean value ) {
		return value.VALUE;
	}
	
	public static implicit operator boolean( bool value ) {
		var _ReturnValue = new boolean();
		_ReturnValue.VALUE = value;
		return _ReturnValue;
	}
	
	public override string ToString()
	{
		return this.VALUE.ToString();
	}
	
}

///<summary>
///
///</summary>

public struct time {

	private TimeSpan VALUE;
		
	public static implicit operator TimeSpan( time value ) {
		return value.VALUE;
	}
	
	public static implicit operator time( TimeSpan value ) {
		var _ReturnValue = new time();
		_ReturnValue.VALUE = value;
		return _ReturnValue;
	}
	
	public override string ToString()
	{
		return this.VALUE.ToString();
	}
	
}
}

