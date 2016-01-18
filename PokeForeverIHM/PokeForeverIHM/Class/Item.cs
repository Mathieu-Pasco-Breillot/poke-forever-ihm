using System;
using System.Collections.ObjectModel;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;

namespace PokeForeverIHM.Class
{
	public class Item
	{
		private string name;
		private ushort quantity, price;
		private ImageSource image;
		private static ObservableCollection<Item> instance;

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

		public static ObservableCollection<Item> Instance
		{
			get
			{
				if (instance == null)
				{
					instance = new ObservableCollection<Item>();
					instance.Add(new Item("Pokebike"));
					instance.Add(new Item("Pokeflute"));
					instance.Add(new Item("FishingRod"));
					instance.Add(new Item("Potion"));
					instance.Add(new Item("Antidote"));
				}
				return instance;
			}
		}

		public Item(string name)
		{
			SetImage = $"ms-appx:///Assets/Items/{name}.png";
			Quantity = 0;
		}
	}
}
