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
	/// Class forms a date range by using a start- and end-date.
	/// </summary>
	public class CompleteDateRange
	{
		private CompleteDate dateStart, dateEnd;
		
		/// <summary>
		/// Create date range by using start and end dates.
		/// </summary>
		/// <param name="dateStart"></param>
		/// <param name="dateEnd"></param>
		public CompleteDateRange(CompleteDate dateStart, CompleteDate dateEnd)
		{
			this.dateStart = dateStart;
			this.dateEnd = dateEnd;
		}
		
		/// <summary>
		/// The start date
		/// </summary>
		public CompleteDate DateStart
		{
			get
			{
				return this.dateStart;
			}
		}
		
		/// <summary>
		/// The end date
		/// </summary>
		public CompleteDate DateEnd
		{
			get
			{
				return this.dateEnd;
			}
		}
		
		/// <summary>
		///   x--------x
		/// x----x
		/// 
		///   x---------x
		/// 		x------x
		/// 
		///   x----------x
		///       x----x
		/// 
		///    x-----x
		/// x-----------x
		/// 
		/// 4 checks needed -> if any point is within the other ranges endpoints, an overlap occurs.
		/// </summary>
		/// <param name="range"></param>
		/// <returns></returns>
		public bool Overlaps(CompleteDateRange range)
		{
			//d1 start
			if (range.DateStart.Sortable <= this.DateStart.Sortable && this.DateStart.Sortable <= range.DateEnd.Sortable)
				return true;
			
			//d1 end
			if (range.DateStart.Sortable <= this.DateEnd.Sortable && this.DateEnd.Sortable <= range.DateEnd.Sortable)
				return true;
			
			//d2 start
			if (this.DateStart.Sortable <= range.DateStart.Sortable && range.DateStart.Sortable <= this.DateEnd.Sortable)
				return true;
			
			//d2 end
			if (this.DateStart.Sortable <= range.DateEnd.Sortable && range.DateEnd.Sortable <= this.DateEnd.Sortable)
				return true;
			
			return false;
		}
		
	}
}