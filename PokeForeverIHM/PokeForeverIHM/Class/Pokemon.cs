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
					return result;
				case Types.Dark:
					return result;
				case Types.Dragon:
					return result;
				case Types.Electric:
					return result;
				case Types.Fairy:
					return result;
				case Types.Fight:
					return result;
				case Types.Fire:
					return result;
				case Types.Flying:
					return result;
				case Types.Ghost:
					return result;
				case Types.Grass:
					return result;
				case Types.Ground:
					return result;
				case Types.Ice:
					return result;
				case Types.Normal:
					return result;
				case Types.Poison:
					return result;
				case Types.Psychic:
					return result;
				case Types.Rock:
					return result;
				case Types.Steel:
					return result;
				case Types.Water:
					return result;
				default:
					return result;
			}
		}

	}
}
