using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Imaging;

namespace PokeForeverIHM.Class
{
	public class Pokemon
	{
		string name;
		string description;
		short level = 1;
		Types type;
		Image image;

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

		public string Description
		{
			get
			{
				return description;
			}

			set
			{
				description = value;
			}
		}

		public short Level
		{
			get
			{
				return level;
			}

			set
			{
				level = value;
			}
		}

		public Types Type
		{
			get
			{
				return type;
			}

			set
			{
				type = value;
			}
		}

		public string Image
		{
			set
			{
				image.Source = new BitmapImage(new System.Uri(value));
			}
		}

		public Image GetImage()
		{
			return image;
		}

		public Pokemon(string name, short level, Types type, string imageURI, string description = "")
		{
			Name = name;
			Level = level;
			Type = type;
			Description = description;
			Image = imageURI;
		}
	}
}
