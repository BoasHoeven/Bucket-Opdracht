using System;

namespace SchoolOpdracht
{
	public abstract class Container
	{
		private int _content;

		public int Content
		{
			get
			{
				return _content;
			}
			set
			{
				if (value < 0)
					_content = 0;
				else
				{
					_content = value;
					if (_content >= Capacity)
						Full?.Invoke(this, null);
				}
			}
		}

		public int Capacity
		{ 
			get;
			protected set;
		}

		public void Fill(int amount)
		{
			this.Content += amount;
		}

		public void Empty()
		{
			this.Content = 0;
		}

		public void Empty(int amount)
		{
			this.Content -= amount;
		}

		// Events
		public event EventHandler<EventArgs> Full;
	}
}
