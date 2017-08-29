/*
 * Created by Stefan Engström 
 * Date: 25.8.2017
 * Time: 14:14
 *
 */
using System;

namespace TimeHandler
{
	/// <summary>
	/// Class holds a date range described by two Truncated Dates. 
	/// </summary>
	public class TruncatedDateRange
	{
		
		private TruncatedDate dateStart, dateEnd;
		
		/// <summary>
		/// Create new range using start- and end dates
		/// </summary>
		/// <param name="dateStart"></param>
		/// <param name="dateEnd"></param>
		public TruncatedDateRange(TruncatedDate dateStart, TruncatedDate dateEnd)
		{
			this.dateStart = dateStart;
			this.dateEnd = dateEnd;
			if (dateStart.TruncationType != dateEnd.TruncationType)
				throw new TimeHandlerException("Truncated date range must contain dates of same type.");
		}
		
		/// <summary>
		/// Verbal explanation of the range
		/// </summary>
		public string Explanation
		{
			get
			{
				return dateStart.Explanation + " until " + dateEnd.Explanation;
			}
		}
		
		/// <summary>
		/// Convert to Complete date ranges. The complete date ranges might reoccur once, monthly or yearly.
		/// </summary>
		/// <param name="yearStart"></param>
		/// <param name="yearEnd"></param>
		/// <returns></returns>
		public CompleteDateRange[] ToCompleteDateRanges(int yearStart, int yearEnd)
		{
			var periodOfInterest = new CompleteDateRange(new CompleteDate(yearStart,1,1), new CompleteDate(yearEnd,12,31));
			
			CompleteDateRange maxRange;
			
			CompleteDate completeStart, completeEnd;
			 			
			switch (this.dateStart.TruncationType)
			{
				
				case 4:
				case 6:
				case 7:
					//only one period
					//TODO Add check whether single period is within given range of interest
					completeStart = dateStart.MakeCompleteUsing(new CompleteDate(yearStart, 1,1));
					completeEnd = dateEnd.MakeCompleteUsing(new CompleteDate(yearEnd, 12,31));
					//max range is start of first occurence and end of last
					maxRange = new CompleteDateRange(completeStart, completeEnd);
					return maxRange.Overlaps(periodOfInterest) ? new CompleteDateRange[]{maxRange} : null;
					
				case 1:
				case 5:
					//one period each month
					//TODO Add code for monthly period
					return null;
				case 2:
				case 3:
					//yearly period
					//TODO Add code for yearly period
					for(var i = yearStart; i < yearEnd; i++)
					{
						
					}
					
					return null;
					
				
					
			}
			
			return null;
		}
			
			
		/// <summary>
		/// Returns true if the given date is Within the DateSpan. 
		/// </summary>
		/// <param name="trd"></param>
		/// <returns></returns>
		public bool IsWithin(CompleteDate date)
		{
			var ds = dateStart.MakeCompleteUsing(date);
			var de = dateEnd.MakeCompleteUsing(date);
			//HACK String comparison of basic format
			if (String.Compare(ds.BasicFormat, date.BasicFormat) <= 0 && String.Compare(de.BasicFormat, date.BasicFormat) >= 0)
				return true;
			return false;
		}
	}
}
