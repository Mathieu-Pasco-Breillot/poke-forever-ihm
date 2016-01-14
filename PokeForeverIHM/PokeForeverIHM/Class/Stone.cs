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
		private static ObservableCollection<Stone> stones;

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

		public static ObservableCollection<Stone> Stones
		{
			get
			{
				if (stones == null)
				{
					stones = new ObservableCollection<Stone>();
					stones.Add(new Stone("DawnStone"));
					stones.Add(new Stone("DuskStone"));
					stones.Add(new Stone("EverStone"));
					stones.Add(new Stone("FireStone"));
					stones.Add(new Stone("LeafStone"));
					stones.Add(new Stone("MoonStone"));
					stones.Add(new Stone("ShinyStone"));
					stones.Add(new Stone("SunStone"));
					stones.Add(new Stone("ThunderStone"));
					stones.Add(new Stone("WaterStone"));
				}
				return stones;
			}

			set
			{
				stones = value;
			}
		}

		public Stone(string name)
		{
			SetImage = $"ms-appx:///Assets/Stones/{name}.png";
			Quantity = 0;
		}

	}
}
