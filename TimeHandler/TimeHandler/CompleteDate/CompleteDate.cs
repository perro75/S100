/*
 * Created by Stefan Engström 
 * Date: 25.8.2017
 * Time: 14:13
 *
 */
using System;
namespace TimeHandler
{
	
	/// <summary>
	/// Class for handling of complete dates with read / write support for ISO8601- format.
	/// Complete menas that all parts are specified (YYMMDD)
	/// </summary>
	public class CompleteDate
	{
		
		private int year, month, day;
		private string separator = "-";
		
		/// <summary>
		/// The year
		/// </summary>
		public int Year { get {return this.year;}}
		
		/// <summary>
		/// The month
		/// </summary>
		public int Month { get {return this.month;}}
		
		/// <summary>
		/// The day
		/// </summary>
		public int Day { get {return this.day;}}
		
		/// <summary>
		/// Create new complete date
		/// </summary>
		/// <param name="year"></param>
		/// <param name="month"></param>
		/// <param name="day"></param>
		public CompleteDate(int year, int month, int day)
		{
			this.year = year;
			this.month = month;
			this.day = day;
			this.validate();
		}
		
		/// <summary>
		/// Create new complete date using ISO 8601 string
		/// </summary>
		/// <param name="ISO8601"></param>
		public CompleteDate(string ISO8601)
		{
			ISO8601 = ISO8601.Replace(separator, String.Empty);
			
			this.year = Convert.ToInt32(ISO8601.Substring(0, 4));
			this.month = Convert.ToInt32(ISO8601.Substring(4, 2));
			this.day = Convert.ToInt32(ISO8601.Substring(6, 2));
			this.validate();
		}
		
		private void validate()
		{
			try
			{
				var dt = new DateTime(year, month, day);
			}
			catch(Exception e)
			{
				throw new TimeHandlerException(e.Message);
			}
		}
		
		/// <summary>
		/// Output as Extended ISO 8601
		/// </summary>
		public string ExtendedFormat {
			get { return year.ToString("0000") + separator + month.ToString("00") + separator + day.ToString("00"); }
		}
		
		/// <summary>
		/// Output as Basic ISO 8601
		/// </summary>
		public string BasicFormat {
			get { return ExtendedFormat.Replace(separator, String.Empty); }
		}
		
		public int Sortable
		{
			get
			{
				return this.Year * 10000 + this.month * 100 + this.day;
			}
		}
	}
}
