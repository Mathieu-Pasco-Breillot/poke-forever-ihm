using Windows.UI.Xaml.Media;

namespace PokeForeverIHM.Class
{
	public class Player
	{
		private static Player instance;
		private string name;
		ImageSource image;

		private Player() { }

		public static Player Instance
		{
			get
			{
				if (instance == null)
				{
					instance = new Player();
				}
				return instance;
			}
		}

		public string Name
		{
			get
			{
				return name;
			}

			set
			{
				name = value;
			}
		}

		public ImageSource GetImage
		{
			get
			{
				return image;
			}
		}
	}
}
