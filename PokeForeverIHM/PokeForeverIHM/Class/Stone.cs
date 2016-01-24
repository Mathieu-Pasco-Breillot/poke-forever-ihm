using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;

namespace PokeForeverIHM.Class
{
	public class Stone
	{
		private string name;
		private ushort quantity, price;
		private ImageSource image;
		private List<PokemonType> types = new List<PokemonType>();
		private static ObservableCollection<Stone> instance;

		public ushort Quantity
		{
			get
			{
				return quantity;
			}

			set
			{
				quantity = value;
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

		public static ObservableCollection<Stone> Instance
		{
			get
			{
				if (instance == null)
				{
					instance = new ObservableCollection<Stone>();
					instance.Add(new Stone("DawnStone"));
					instance.Add(new Stone("DuskStone"));
					instance.Add(new Stone("EverStone"));
					instance.Add(new Stone("FireStone"));
					instance.Add(new Stone("LeafStone"));
					instance.Add(new Stone("MoonStone"));
					instance.Add(new Stone("ShinyStone"));
					instance.Add(new Stone("SunStone"));
					instance.Add(new Stone("ThunderStone"));
					instance.Add(new Stone("WaterStone"));
				}
				return instance;
			}
		}

		public Stone(string name, ushort quantity = 0)
		{
			SetImage = $"ms-appx:///Assets/Stones/{name}.png";
			Quantity = quantity;
		}

	}
}
