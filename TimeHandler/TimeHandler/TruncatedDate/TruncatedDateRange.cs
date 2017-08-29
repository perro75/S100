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
			
			CompleteDate completeStart, completeEnd;
			var count = 1;
			var completeRanges = new CompleteDateRange[count];
			
			switch (this.dateStart.TruncationType)
			{
				
				case 4:
				case 6:
				case 7:
					//only one period
					completeStart = dateStart.MakeCompleteUsing(new CompleteDate(yearStart, 1,1));
					completeEnd = dateEnd.MakeCompleteUsing(new CompleteDate(yearEnd, 12,31));
					//max range is start of first occurence and end of last
					completeRanges[0] = new CompleteDateRange(completeStart, completeEnd);
					return completeRanges[0].Overlaps(periodOfInterest) ? completeRanges : null;
					
				case 1:
				case 5:
					//one period each month ( month missing )
					//TODO Monthly period not implemented!
					throw new NotImplementedException("TruncatedDateRange.cs line 74");
					return null;
				case 2:
				case 3:
					//yearly period
					count = yearEnd-yearStart +1;
					completeRanges = new CompleteDateRange[count];
					
					for(var i = 0; i < count; i++)
					{
						completeStart = dateStart.MakeCompleteUsing(new CompleteDate(yearStart + i, 1,1));
						completeEnd = dateEnd.MakeCompleteUsing(new CompleteDate(yearStart + i, 12,31));
						completeRanges[i] = new CompleteDateRange(completeStart, completeEnd);
					}
					
					return completeRanges;
					
				
					
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
