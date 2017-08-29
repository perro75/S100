/*
 * Created by Stefan Engström 
 * Date: 25.8.2017
 * Time: 14:13
 *
 */
 
/*
	ISO 8601 only allows  non-reccuring periods (removing only les-significant parts of a date, as 20171018 -> 201710-- -> 2017----)
	The class S100_TruncatedDateAttributeType is intended for modelling date values with one or more of the more significant 
	components omitted. This allows partial dates to be used, e.g., for recurring periods.
	
	Components:
		YYYY       Year         integer between 0000 and 9999 
		MM          Month       integer between 01 – 12 (inclusive) 
		DD           Day        integer between 01 and 28, 29, 30, or 31 (inclusive), consistent with year and month values if these are specified 
		At   least   one   component   must   be   specified. 

    Each date is a period of time;
	
	Binary	Truncated	Recurrence	Start of period			End of period			Range
 	1. 		------18 	Each month	given day each month	-						Range of days any month
 	2. 		----10-- 	Each year  	first day given month	last day given month	Range of (full) months any year.
 	3. 		----1018 	Each year 	given day given month	-						Given range each year.
 	4. 		2017---- 	Only once 	first day given year	last day given year		One or several full years.
 	5. 		2017--18 	Each month	given day each month	-						Range of days any month withim the given years
	6. 		201710-- 	Only once	first day given month	last day given month	Range of full months within the given years
 	7. 		20171018    Only once 	given date only			-						Translates to one given time-range directly
 	
 	Of these, only 5,6,7 are allowable ISO 8601- dates.
 	
 	Pseudo, check if a date is within a period given by ONE Truncated date;
 	 A. If year is not defined, add year of the date to check against (only options 4,5,6,7 left)
 	 B. If month is not defined, add month of the date to check against (only options 6,7 left)
 	 C. If day is not defined, add day of the date to check against (only option 7 left)
 	 D. The truncated date is now a complete date. Check if the dates match.
 	
 	Pseudo, check if a date is within a period given by using TWO Truncated dates.
 	NOTE! It is assumed dates in a range must be similar ie. including the same specified and unspecified components.
	 A. Perform steps A-C above on each of the Truncated dates
	 B. The truncated dates are now complete dates. Check if the date to check falls BETWEEN these dates.
	 
	 Pseudo, make complete date ranges (=Array of ranges)
	 A. If only year or year and month are given (4, 6, 7), there will be only one continuous range.
	 	- if month is not given, these default to 1 and 12, otherwise min to max
		- if days are not given, these default to 1 and "last_day_in_given_month", otherwise min to max
 	 B. If month is given without year (2, 3), there will be one range each year.
 	 	- if days are not given, these default to 1 and "last_day_in_given_month", otherwise min to max
 	 C. If days are given without month, (option 1, 5) there will be one period each month
 	 	- Months will always default to 1 and 12
 	 	- If value of day is greater than "last_day_in_given_month", the largest possible value is used.
 */

using System;

namespace TimeHandler
{
	
	
	
	/// <summary>
	/// Description of TruncatedDate.
	/// </summary>
	public class TruncatedDate
	{
		private int? year, month, day;
		
		public int? Year { get {return this.year;}}
		public int? Month { get {return this.month;}}
		public int? Day { get {return this.day;}}
		
		/// <summary>
		/// Each parameter in truncated date can be null
		/// </summary>
		/// <param name="year"></param>
		/// <param name="month"></param>
		/// <param name="day"></param>
		public TruncatedDate(int? year, int? month, int? day)
		{
			this.year = year;
			this.month = month;
			this.day = day;
		}
		
		 
		/// <summary>
		/// Check whether the given date is within the period desribed by the truncated date
		/// </summary>
		/// <param name="date"></param>
		/// <returns></returns>
		public bool IsWithin(CompleteDate date)
		{
				
			return date.BasicFormat.Equals(this.MakeCompleteUsing(date).BasicFormat);
		}
		
		/// <summary>
		/// The truncated date is made into a complete date by adding the unspecified members from the given complete date.
		/// If the given date is within the period described by the Truncated date, the outcome of the operation will be the same date.
		/// </summary>
		/// <param name="date"></param>
		/// <returns>The same date as the input, if this falls within the period described by the Truncated date.</returns>
		public CompleteDate MakeCompleteUsing(CompleteDate date)
		{
			var y = (int) (Year ?? date.Year);
			var m= (int) (Month ?? date.Month);
			
			var last_day_in_month = DateTime.DaysInMonth(y,m); //make sure day is never more than days in the current month
			var dateDay = date.Day > last_day_in_month ? last_day_in_month : date.Day;
			
			var d= (int) (Day ?? dateDay);
			return new CompleteDate(y,m,d);
		}
		
		/// <summary>
		/// Get the complet representation of the start of the first period
		/// </summary>
		public CompleteDate FirstPeriodStart
		{
			get
			{
				return this.MakeCompleteUsing(new CompleteDate(0,1,1));
			}
		}
		
		/// <summary>
		/// Get the complet representation of the end of the last period
		/// </summary>
		public CompleteDate LastPeriodEnd
		{
			get
			{
				return this.MakeCompleteUsing(new CompleteDate(9999,12,31));
			}
		}
		
		/// <summary>
		/// The type of the Truncated date based on the components missing. The value is 1-7, calulated as id the  date components were 
		/// a 3-bit byte. (day = 1, month = 2, year = 4)
		/// </summary>
		public int TruncationType
		{
			get
			{
				return (Year == null ? 0 : 4) + (Month == null ? 0 : 2) + (Day == null ? 0 : 1);
			}
		}
		
		public string Explanation
		{
			get 
			{
				var yEx = this.year == null ? "any year" : "year " + year;
				var mEx = this.month == null ? " any month" : " month " + month;
				var dEx = this.day == null ? " any day" : " day " + day;
				return yEx + mEx + dEx;
			}
		}
	}
}
