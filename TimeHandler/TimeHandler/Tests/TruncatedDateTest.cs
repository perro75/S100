
using System;
using NUnit.Framework;

namespace TimeHandler
{
	[TestFixture]
	public class TruncatedDateTest
	{
		TruncatedDate trd;
		//DateSpan dsp;
		
		[Test]
		public void test_create_truncated_dates()
		{
			trd = new TruncatedDate(2017,7,null);
			Assert.AreEqual("year 2017 month 7 any day", trd.Explanation);
			trd = new TruncatedDate(null,7,null);
			Assert.AreEqual("any year month 7 any day", trd.Explanation);
			trd = new TruncatedDate(null,null,4);
			Assert.AreEqual("any year any month day 4", trd.Explanation);
		}
		
		[Test]
		public void test_date_within_truncated()
		{
			trd = new TruncatedDate(null,7,null);
			Assert.True(trd.IsWithin(new CompleteDate(2017,7,21)));
			Assert.True(trd.IsWithin(new CompleteDate(2011,7,31)));
			Assert.False(trd.IsWithin(new CompleteDate(1901,6,21)));
			Assert.True(trd.IsWithin(new CompleteDate(2018,7,1)));
		}
		
		[Test]
		public void test_within_truncated_2()
		{
			trd = new TruncatedDate(2017,7,null);
			Assert.True(trd.IsWithin(new CompleteDate(2017,7,21)));
			Assert.False(trd.IsWithin(new CompleteDate(2011,7,31)));
			Assert.False(trd.IsWithin(new CompleteDate(1901,6,21)));
			Assert.False(trd.IsWithin(new CompleteDate(2018,7,1)));
		}
		
		[Test]
		public void test_within_truncated_3()
		{
			trd = new TruncatedDate(null,7,22);
			Assert.False(trd.IsWithin(new CompleteDate(2017,7,21)));
			Assert.False(trd.IsWithin(new CompleteDate(2011,7,31)));
			Assert.False(trd.IsWithin(new CompleteDate(1901,6,21)));
			Assert.True(trd.IsWithin(new CompleteDate(2018,7,22)));
		}
		
		[Test]
		public void test__truncated_type()
		{
			trd = new TruncatedDate(null,null,22);
			Assert.AreEqual(1, trd.TruncationType);
			
			trd = new TruncatedDate(null,7,null);
			Assert.AreEqual(2, trd.TruncationType);
			
			trd = new TruncatedDate(null,7,22);
			Assert.AreEqual(3, trd.TruncationType);
			
			trd = new TruncatedDate(2017,null,null);
			Assert.AreEqual(4, trd.TruncationType);
			
			trd = new TruncatedDate(2017,null,22);
			Assert.AreEqual(5, trd.TruncationType);

			trd = new TruncatedDate(2017,7,null);
			Assert.AreEqual(6, trd.TruncationType);
			
			trd = new TruncatedDate(2017,7,22);
			Assert.AreEqual(7, trd.TruncationType);
		}
		
		[Test]
		public void test_within_truncated_range_1()
		{
			//each year 07-22 .. 08-12
			var start = new TruncatedDate(null,7,22);
			var end = new TruncatedDate(null, 8,12);
			
			var trdRange = new TruncatedDateRange(start, end);
			
			Assert.True(trdRange.IsWithin(new CompleteDate(1730,7,22)));
			Assert.True(trdRange.IsWithin(new CompleteDate(1730,7,31)));
			Assert.True(trdRange.IsWithin(new CompleteDate(1730,8,12)));
			
			Assert.False(trdRange.IsWithin(new CompleteDate(1730,7,21)));
			Assert.False(trdRange.IsWithin(new CompleteDate(2017,7,21)));
		}
		
		[Test]
		public void test_within_truncated_range_2()
		{
			//each year 2017-07-22 .. 08-12
			var start = new TruncatedDate(2017, 7,null);
			var end = new TruncatedDate(2017, 8,null);
			
			var trdRange = new TruncatedDateRange(start, end);
			
			Assert.False(trdRange.IsWithin(new CompleteDate(2016,7,22)));
			Assert.True(trdRange.IsWithin(new CompleteDate(2017,7,1)));
			Assert.True(trdRange.IsWithin(new CompleteDate(2017,8,12)));
		}
		
		[Test]
		public void test_within_truncated_range_3()
		{
			var start = new TruncatedDate(2017, null,12);
			var end = new TruncatedDate(2017, null, 15);
			
			var trdRange = new TruncatedDateRange(start, end);
			
			Assert.False(trdRange.IsWithin(new CompleteDate(2017,7,16)));
			Assert.False(trdRange.IsWithin(new CompleteDate(2016,7,13)));
			Assert.True(trdRange.IsWithin(new CompleteDate(2017,7,15)));
			Assert.True(trdRange.IsWithin(new CompleteDate(2017,1,12)));
		}
	}
}
