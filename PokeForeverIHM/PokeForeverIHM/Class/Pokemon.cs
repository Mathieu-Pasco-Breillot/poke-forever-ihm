using System;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;

namespace PokeForeverIHM.Class
{
	public class Pokemon
	{
		string name;
		string @abstract;
		short level = 1;
		Types type;
		ImageSource image, imageType;

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

		public string Abstract
		{
			get
			{
				return @abstract;
			}

			set
			{
				@abstract = value;
			}
		}

		public object Level
		{
			get
			{
				return Convert.ToString(level);
			}

			set
			{
				level = (short)value;
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

		public string SetImage
		{
			set
			{
				image = new BitmapImage(new Uri(value));
			}
		}

		public ImageSource GetImage
		{
			get
			{
				return image;
			}
		}

		public string SetImageType
		{
			set
			{
				imageType = new BitmapImage(new Uri(value));
			}
		}
		public ImageSource GetImageType
		{
			get
			{
				return imageType;
			}
		}

		public Pokemon(string name, short level, Types type, string imageURI, string @abstract = "")
		{
			Name = name;
			Level = level;
			Type = type;
			Abstract = @abstract;
			SetImage = imageURI;
			SetImageType = checkType(type);
		}

		private string checkType(Types type)
		{
			string result = "";
			switch (type)
			{
				case Types.Bug:
					return result = "ms-appx:///Assets/Types/bug.png";
				case Types.Dark:
					return result = "ms-appx:///Assets/Types/dark.png";
				case Types.Dragon:
					return result = "ms-appx:///Assets/Types/dragon.png";
				case Types.Electric:
					return result = "ms-appx:///Assets/Types/electric.png";
				case Types.Fairy:
					return result = "ms-appx:///Assets/Types/fairy.png";
				case Types.Fight:
					return result = "ms-appx:///Assets/Types/fight.png";
				case Types.Fire:
					return result = "ms-appx:///Assets/Types/fire.png";
				case Types.Flying:
					return result = "ms-appx:///Assets/Types/flying.png";
				case Types.Ghost:
					return result = "ms-appx:///Assets/Types/ghost.png";
				case Types.Grass:
					return result = "ms-appx:///Assets/Types/grass.png";
				case Types.Ground:
					return result = "ms-appx:///Assets/Types/ground.png";
				case Types.Ice:
					return result = "ms-appx:///Assets/Types/ice.png";
				case Types.Normal:
					return result = "ms-appx:///Assets/Types/normal.png";
				case Types.Poison:
					return result = "ms-appx:///Assets/Types/poison.png";
				case Types.Psychic:
					return result = "ms-appx:///Assets/Types/psychic.png";
				case Types.Rock:
					return result = "ms-appx:///Assets/Types/rock.png";
				case Types.Steel:
					return result = "ms-appx:///Assets/Types/steel.png";
				case Types.Water:
					return result = "ms-appx:///Assets/Types/water.png";
				default:
					return result;
			}
		}

	}
}
