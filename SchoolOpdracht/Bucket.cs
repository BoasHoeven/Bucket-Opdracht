namespace SchoolOpdracht
{
	public class Bucket : Container
	{
		public Bucket(int content = 0, int capacity = 12)
		{
			Capacity = capacity > 10 ? capacity : 10;
			Content = content;
		}

		public void Fill(Bucket bucket)
		{
			if (bucket.Content <= 0)
				return;

			Content += bucket.Content;
			bucket.Content -= bucket.Content;
		}
	}
}
