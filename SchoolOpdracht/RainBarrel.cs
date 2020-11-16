namespace SchoolOpdracht
{
	public class RainBarrel : Container
	{
		public RainBarrel(RainBarrelType type)
		{
			base.Capacity = (int)type;
			base.Content = 0;
		}
	}
}
