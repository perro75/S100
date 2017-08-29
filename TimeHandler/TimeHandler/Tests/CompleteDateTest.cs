
using NUnit.Framework;

namespace TimeHandler
{
	[TestFixture]
	public class CompleteDateTest
	{
		private CompleteTime time;
		private CompleteDate date;
		private CompleteDateTime dateTime;
		
		
		[Test]
		public void create_time_object_from_int()
		{
			//create object (default is undefined local time)
			time = new CompleteTime(12, 00,00);
			//check output
			Assert.AreEqual("120000", time.BasicFormat);
			Assert.AreEqual("12:00:00", time.ExtendedFormat);
			
			//create UTC- object
			time = new CompleteTime(12, 00,00, true);
			//check output
			Assert.AreEqual("120000Z", time.BasicFormat);
			Assert.AreEqual("12:00:00Z", time.ExtendedFormat);
			
			//create offset local time object
			time = new CompleteTime(14, 30, 0, 3, 0, CompleteTime.OffsetSign.positive );
			//check output
			Assert.AreEqual("143000+0300", time.BasicFormat);
			Assert.AreEqual("14:30:00+03:00", time.ExtendedFormat);
			
			//create offset local time object
			time = new CompleteTime(14, 30, 0, 3, 0, CompleteTime.OffsetSign.negative );
			//check output
			Assert.AreEqual("143000-0300", time.BasicFormat);
			Assert.AreEqual("14:30:00-03:00", time.ExtendedFormat);
		}
		
		[Test]
		public void parse_complete_time_from_string()
		{
			//create from string, undefined local time
			time = new CompleteTime("12:07:01");
			//check output
			Assert.AreEqual("120701", time.BasicFormat);
			Assert.AreEqual("12:07:01", time.ExtendedFormat);
			
			//create from string, UTC small z
			time = new CompleteTime("12:07:01z");
			//check output
			Assert.AreEqual("120701Z", time.BasicFormat);
			Assert.AreEqual("12:07:01Z", time.ExtendedFormat);
						
			
			//create from string UTC capital Z
			time = new CompleteTime("12:07:01Z");
			//check output
			Assert.AreEqual("120701Z", time.BasicFormat);
			Assert.AreEqual("12:07:01Z", time.ExtendedFormat);
						
			//create from string, with offset
			time = new CompleteTime("143000+0300");
			//check output
			Assert.AreEqual("143000+0300", time.BasicFormat);
			Assert.AreEqual("14:30:00+03:00", time.ExtendedFormat);
			
			//create from string, with offset
			time = new CompleteTime("143000-0230");
			//check output
			Assert.AreEqual("143000-0230", time.BasicFormat);
			Assert.AreEqual("14:30:00-02:30", time.ExtendedFormat);
		}
		
		[Test]
		public void create_and_parse_date_object()
		{
			date = new CompleteDate(2017, 10, 18);
			Assert.AreEqual("2017-10-18", date.ExtendedFormat);
			Assert.AreEqual("20171018", date.BasicFormat);
			
			date = new CompleteDate("2017-01-01");
			Assert.AreEqual("2017-01-01", date.ExtendedFormat);
			Assert.AreEqual("20170101", date.BasicFormat);
		}
		
		[Test]
		public void create_and_parse_dateTime_object()
		{
			date = new CompleteDate("1975-10-18");
			time = new CompleteTime("12:30:00+03:00");
			dateTime = new CompleteDateTime(date, time);
			Assert.AreEqual("19751018T123000+0300", dateTime.BasicFormat);
			Assert.AreEqual("1975-10-18T12:30:00+03:00", dateTime.ExtendedFormat);
			
			dateTime = new CompleteDateTime("1975-10-18T12:30:00-03:00");
			Assert.AreEqual("19751018T123000-0300", dateTime.BasicFormat);
			Assert.AreEqual("1975-10-18T12:30:00-03:00", dateTime.ExtendedFormat);
		}
		
		[Test]
		[ExpectedException(typeof(TimeHandlerException))]
		public void test_exception_invalid_hour_in_time()
		{
			time = new CompleteTime("24:30:00Z");
		} 
		
		[Test]
		[ExpectedException(typeof(TimeHandlerException))]
		public void test_exception_invalid_day_in_date()
		{
			date = new CompleteDate(2017,10,-1);
		} 
		
		[Test]
		[ExpectedException(typeof(TimeHandlerException))]
		public void test_exception_invalid_minute_in_dateTime()
		{
			time = new CompleteTime("22:60:00Z");
			date = new CompleteDate(2017,10,18);
			dateTime = new CompleteDateTime(date, time);
		} 
		
		
		[Test]
		[ExpectedException(typeof(TimeHandlerException))]
		public void test_exception_invalid_day_in_month()
		{
			dateTime = new CompleteDateTime("1975-11-31T09:30:00Z");
		} 
		
		[Test]
		public void test_dateTime_output()
		{
			var dateTimeUtc = new CompleteDateTime("1975-10-18T09:30:00Z");
			dateTime = new CompleteDateTime("1975-10-18T12:30:00+03:00");
			var dto = dateTime.ToDateTimeOffset;
			var utc = dateTimeUtc.ToDateTimeOffset;
			Assert.AreEqual(utc.ToUniversalTime(), dto.ToUniversalTime());
			
		}
		
		[Test]
		public void test_current()
		{
			dateTime = CompleteDateTime.CurrentUtc;
			Assert.AreEqual("Z", dateTime.ExtendedFormat.Substring(dateTime.ExtendedFormat.Length-1));
			
			dateTime = CompleteDateTime.CurrentLocal;
			Assert.AreNotEqual("Z", dateTime.ExtendedFormat.Substring(dateTime.ExtendedFormat.Length-1));
			
			dateTime.Time.addOffset(3,0,CompleteTime.OffsetSign.positive);
			Assert.AreEqual("+03:00", dateTime.ExtendedFormat.Substring(dateTime.ExtendedFormat.Length-6));
		}
		
		[Test]
		[ExpectedException(typeof(TimeHandlerException))]
		public void test_add_offset_to_UTC()
		{
			dateTime = CompleteDateTime.CurrentUtc;
			dateTime.Time.addOffset(3,0,CompleteTime.OffsetSign.positive);
		}
		
		[Test]
		[ExpectedException(typeof(TimeHandlerException))]
		public void test_change_existing_offset()
		{
			dateTime = CompleteDateTime.CurrentLocal;
			dateTime.Time.addOffset(3,0,CompleteTime.OffsetSign.positive);
			dateTime.Time.addOffset(2,0,CompleteTime.OffsetSign.positive);
		} 
		
		[Test]
		public void test_compare_ranges()
		{
			CompleteDateRange range_full_2015 = new CompleteDateRange(new CompleteDate(2015,1,1), new CompleteDate(2015,12,31));
			CompleteDateRange range_late_2015 = new CompleteDateRange(new CompleteDate(2015,12,30), new CompleteDate(2015,12,31));
			
			Assert.True(range_full_2015.Overlaps(range_late_2015));
		} 
		
		[Test]
		public void test_compare_ranges2()
		{
			CompleteDateRange range_full_2015 = new CompleteDateRange(new CompleteDate(2015,1,1), new CompleteDate(2015,12,31));
			CompleteDateRange range_late_2014 = new CompleteDateRange(new CompleteDate(2014,12,30), new CompleteDate(2014,12,31));
			
			Assert.False(range_full_2015.Overlaps(range_late_2014));
		} 
		
		[Test]
		public void test_complete_date_range_1()
		{
			var start = new TruncatedDate(2014, 10, null);
			var end = new TruncatedDate(2017, 11, null);
			
			var trdRange = new TruncatedDateRange(start, end);
			var comp = trdRange.ToCompleteDateRanges(2016, 2018);
			
			Assert.AreEqual(1, comp.Length);
			Assert.NotNull(comp);
			
			Assert.AreEqual("20141001", comp[0].DateStart.BasicFormat);
			Assert.AreEqual("20171130", comp[0].DateEnd.BasicFormat);
		}
		
		
		[Test]
		public void test_complete_date_range_2()
		{
			var start = new TruncatedDate(2014, 10, 28);
			var end = new TruncatedDate(2017, 11, 1);
			
			var trdRange = new TruncatedDateRange(start, end);
			var comp = trdRange.ToCompleteDateRanges(2016, 2018);
			
			Assert.AreEqual(1, comp.Length);
			Assert.NotNull(comp);
			
			Assert.AreEqual("20141028", comp[0].DateStart.BasicFormat);
			Assert.AreEqual("20171101", comp[0].DateEnd.BasicFormat);
		}
		
		[Test]
		public void test_complete_date_range_3()
		{
			var start = new TruncatedDate(2014, null, null);
			var end = new TruncatedDate(2017, null, null);
			
			var trdRange = new TruncatedDateRange(start, end);
			var comp = trdRange.ToCompleteDateRanges(2016, 2018);
			
			Assert.AreEqual(1, comp.Length);
			Assert.NotNull(comp);
			
			Assert.AreEqual("20140101", comp[0].DateStart.BasicFormat);
			Assert.AreEqual("20171231", comp[0].DateEnd.BasicFormat);
		}
		
		[Test]
		public void test_complete_date_range_4()
		{
			var start = new TruncatedDate(2014, null, null);
			var end = new TruncatedDate(2015, null, null);
			
			var trdRange = new TruncatedDateRange(start, end);
			var comp = trdRange.ToCompleteDateRanges(2016, 2018);
			//Not within given period of interest
			Assert.Null(comp);
			
		
		}
		
	}
}