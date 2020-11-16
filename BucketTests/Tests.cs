using SchoolOpdracht;
using Xunit;

namespace BucketTests
{
	public class Tests
	{
		[Fact]
		public void FullEvent()
		{
			// Arrange
			bool triggered = false;
			Bucket bucket = new Bucket();

			// Perform
			bucket.Full += (o, e) => { triggered = true; };
			bucket.Content = bucket.Capacity;

			// Validation
			Assert.True(triggered);
		}

		[Fact]
		public void FillBucketWithBucket()
		{
			// Arrange
			Bucket bucket1 = new Bucket();
			bucket1.Content = 5;
			Bucket bucket2 = new Bucket();
			bucket2.Content = 5;

			// Perform
			bucket1.Fill(bucket2);

			// Validation
			Assert.Equal(10, bucket1.Content);
		}

		[Fact]
		public void FillBucket()
		{
			// Arrange
			Bucket bucket1 = new Bucket();
			bucket1.Content = 5;

			// Perform
			bucket1.Fill(5);

			// Validation
			Assert.Equal(10, bucket1.Content);
		}

		[Fact]
		public void EmptyBucketNoArg()
		{
			// Arrange
			Bucket bucket1 = new Bucket();
			bucket1.Content = bucket1.Capacity;

			// Perform
			bucket1.Empty();

			// Validation
			Assert.Equal(0, bucket1.Content);
		}

		[Fact]
		public void EmptyBucketWithArg()
		{
			// Arrange
			Bucket bucket1 = new Bucket();
			bucket1.Content = bucket1.Capacity;

			// Perform
			bucket1.Empty(bucket1.Capacity);

			// Validation
			Assert.Equal(0, bucket1.Content);
		}
	}
}
