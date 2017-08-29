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
	/// Class holds a Complete date and a Complete time. 
	/// Class can read / write complete ISO8601 DateTimes.
	/// </summary>
	public class CompleteDateTime
	{
		CompleteDate date;
		CompleteTime time;
		
		/// <summary>
		/// Get current system date and time as an ISO 8601 UTC- time
		/// </summary>
		public static CompleteDateTime CurrentUtc
		{
			get
			{
				return new CompleteDateTime(DateTime.UtcNow.ToString("s") +"Z");
			}
		}
		
		/// <summary>
		/// Get current system date and time as an unspecified local ISO 8601 time
		/// </summary>
		public static CompleteDateTime CurrentLocal
		{
			get
			{
				return new CompleteDateTime(DateTime.Now.ToString("s"));
			}
		}
		
		/// <summary>
		/// Return the Date
		/// </summary>
		public CompleteDate Date {get{return this.date;}}
		
		/// <summary>
		/// Return the Time
		/// </summary>
		public CompleteTime Time{get{return this.time;}}
		
		/// <summary>
		/// Convert to DateTimeOffset 
		/// </summary>
		public DateTimeOffset ToDateTimeOffset 
		{ 
			get 
			{ 
				try
				{
					var offsetTimeSpan = new TimeSpan(time.OffsetHour * time.OffsetMultiplier, time.OffsetMinute * time.OffsetMultiplier, 0);
					return new DateTimeOffset(date.Year, date.Month, date.Day, time.Hour, time.Minute, time.Second, offsetTimeSpan);
				}
				catch (Exception e)
				{
					throw new TimeHandlerException("ISO8601_dateTime: " + e.Message);
				}
			}
		}
		
		/// <summary>
		/// Create by using date and time objects
		/// </summary>
		/// <param name="date"></param>
		/// <param name="time"></param>
		public CompleteDateTime(CompleteDate date, CompleteTime time)
		{
			this.date = date;
			this.time = time;
			this.validate();
		}
		
		/// <summary>
		/// Create by using a ISO 8601 complete string in Basic or Extended format
		/// </summary>
		/// <param name="ISO8601_string"></param>
		public CompleteDateTime(string ISO8601_string)
		{
			var parts = ISO8601_string.Split("T".ToCharArray());
			this.date = new CompleteDate(parts[0]);
			this.time = new CompleteTime(parts[1]);
			this.validate();
		}
		
		/// <summary>
		/// throws Exception if invalid
		/// </summary>
		private void validate()
		{
			var test = this.ToDateTimeOffset;
		}
		
		/// <summary>
		/// Get the ISO 8601 string
		/// </summary>
		public string ExtendedFormat {
			get { return this.date.ExtendedFormat + "T" + this.time.ExtendedFormat; }
		}
		
		/// <summary>
		/// Get the ISO 8601 string
		/// </summary>
		public string BasicFormat {
			get { return this.date.BasicFormat + "T" + this.time.BasicFormat; }
		}
	}
}
