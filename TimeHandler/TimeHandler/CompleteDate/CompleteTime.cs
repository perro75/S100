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
	/// Class for handling of  with read / write support for ISO8601- format.
	/// Complete menas that all parts are specified (hhmmss) including optional specifier fot UTC or offset
	/// </summary>
	public class CompleteTime
	{
		
		private int hour, minute, second, offsetHour, offsetMinute;
		private OffsetSign offsetSign;
		private string separator = ":";
		private TimeReference reference = TimeReference.undefined;
		
		private enum TimeReference
		{
			undefined,
			offset,
			UTC
		}
		
		/// <summary>
		/// The sign of the offset, if given
		/// </summary>
		public enum OffsetSign
		{
			/// <summary>
			/// The offset is positive
			/// </summary>
			positive,
			/// <summary>
			/// The offset is negative
			/// </summary>
			negative
		}
		
		/// <summary>
		/// True if the time is in UTC (encoded with Z)
		/// </summary>
		public bool IsUTC
		{
			get { return this.reference == TimeReference.UTC;}
		}
		
		/// <summary>
		/// True if the time has a specified offset
		/// </summary>
		public bool HasOffset
		{
			get { return this.reference == TimeReference.offset;}
		}
		
		/// <summary>
		/// The hour
		/// </summary>
		public int Hour { get {return this.hour;}}
		
		/// <summary>
		/// The minute
		/// </summary>
		public int Minute { get {return this.minute;}}
		
		/// <summary>
		/// The second
		/// </summary>
		public int Second { get {return this.second;}}
		
		/// <summary>
		/// The offset hour
		/// </summary>
		public int OffsetHour { get {return this.offsetHour;}}
		
		/// <summary>
		/// The offset minute
		/// </summary>
		public int OffsetMinute { get {return this.offsetMinute;}}
		
		/// <summary>
		/// The offset multiplier
		/// </summary>
		public int OffsetMultiplier{ get {return this.offsetSign == OffsetSign.positive ? 1 : -1;}}
						
		/// <summary>
		/// Create a new Local Time time with unspecified offset
		/// </summary>
		/// <param name="hour"></param>
		/// <param name="minute"></param>
		/// <param name="second"></param>
		public CompleteTime(int hour, int minute, int second)
		{
			this.init(hour, minute, second, false);
			this.validate();
		}
		
		/// <summary>
		/// Create a new time that is either an unspecified Local Time or UTC
		/// </summary>
		/// <param name="hour"></param>
		/// <param name="minute"></param>
		/// <param name="second"></param>
		/// <param name="isUtc"></param>
		public CompleteTime(int hour, int minute, int second, bool isUtc)
		{
			this.init(hour, minute, second, isUtc);
			this.validate();
		}
		
		private void init(int hour, int minute, int second, bool isUtc)
		{
			this.hour = hour;
			this.minute = minute;
			this.second = second;
			this.reference = isUtc ? TimeReference.UTC : TimeReference.undefined;
			this.validate();
		}
		
		/// <summary>
		/// Create a Local Time with a given offset to UTC
		/// </summary>
		/// <param name="hour"></param>
		/// <param name="minute"></param>
		/// <param name="second"></param>
		/// <param name="offsetHour"></param>
		/// <param name="offsetMinute"></param>
		/// <param name="offsetSign"></param>
		public CompleteTime(int hour, int minute, int second, int offsetHour, int offsetMinute, OffsetSign offsetSign)
		{
			this.hour = hour;
			this.minute = minute;
			this.second = second;
			
			this.offsetHour = offsetHour;
			this.offsetMinute = offsetMinute;
			this.offsetSign = offsetSign;
			
			this.reference = TimeReference.offset;
			
			this.validate();
		}
		
		/// <summary>
		/// Add offset to an unspecified local time
		/// </summary>
		/// <param name="offsetHour"></param>
		/// <param name="offsetMinute"></param>
		/// <param name="offsetSign"></param>
		public void addOffset(int offsetHour, int offsetMinute, OffsetSign offsetSign)
		{
			if (this.reference != TimeReference.undefined)
				throw new TimeHandlerException("Time offset can only be added to undefined local time!");
			
			this.offsetHour = offsetHour;
			this.offsetMinute = offsetMinute;
			this.offsetSign = offsetSign;
			
			this.reference = TimeReference.offset;
		}
		
		/// <summary>
		/// Create using ISO 8601- string
		/// </summary>
		/// <param name="ISO8601"></param>
		public CompleteTime(string ISO8601)
		{
			ISO8601 = ISO8601.Replace(separator, String.Empty);
			
			this.hour = Convert.ToInt32(ISO8601.Substring(0, 2));
			this.minute = Convert.ToInt32(ISO8601.Substring(2, 2));
			this.second = Convert.ToInt32(ISO8601.Substring(4, 2));
			
			if (ISO8601.Length > 6 && (ISO8601.Substring(6, 1).Equals("Z") || ISO8601.Substring(6, 1).Equals("z"))) {
				this.reference = TimeReference.UTC;
			} else if (ISO8601.Length > 6) {
				this.reference = TimeReference.offset;
				this.offsetSign = ISO8601.Substring(6, 1).Equals("+") ? OffsetSign.positive : OffsetSign.negative;
				this.offsetHour = Convert.ToInt32(ISO8601.Substring(7, 2));
				this.offsetMinute = Convert.ToInt32(ISO8601.Substring(9, 2));
			}
			
			this.validate();
		}
		
		private void validate()
		{
			var dto = new CompleteDateTime(new CompleteDate(1970,1,1), this).ToDateTimeOffset;
		}
		
		/// <summary>
		/// Output in Extended format string
		/// </summary>
		public string ExtendedFormat {
			get {
				string offset = "";
			
				switch (reference) {
					case TimeReference.UTC:
						offset = "Z";
						break;
					case TimeReference.offset:
						offset = (offsetSign == OffsetSign.positive ? "+" : "-") + offsetHour.ToString("00") + separator + offsetMinute.ToString("00");
						break;
				}
				
				return hour.ToString("00") + separator + minute.ToString("00") + separator + second.ToString("00") + offset;
			
			}
		}
		
		/// <summary>
		/// Output in Basic format string
		/// </summary>
		public string BasicFormat {
			get { return ExtendedFormat.Replace(separator, String.Empty); }
		}
		
	}
	
}
