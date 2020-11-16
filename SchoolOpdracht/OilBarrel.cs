namespace SchoolOpdracht
{
	public class OilBarrel : Container
	{
		public OilBarrel()
		{
			base.Capacity = 159;
		}

		public OilBarrel(int content) : this()
		{
			base.Content = content;
		}
	}
}
