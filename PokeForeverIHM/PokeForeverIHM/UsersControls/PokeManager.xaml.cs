using Windows.UI.Xaml.Controls;
using PokeForeverIHM.Class;
using System.Collections.ObjectModel;
using Windows.UI.Xaml.Controls.Primitives;
using System.Collections.Generic;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Media;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace PokeForeverIHM.UsersControls
{
	public sealed partial class PokeManager : UserControl
	{
		private ObservableCollection<Pokemon> pokemons = new ObservableCollection<Pokemon>();
		public PokeManager()
		{
			InitializeComponent();
			PopulateWithPokemons();
			DataContext = Pokemons;
		}

		public ObservableCollection<Pokemon> Pokemons
		{
			get
			{
				return pokemons;
			}

			set
			{
				pokemons = value;
			}
		}

		public void PopulateWithPokemons()
		{
			Pokemons.Add(new Pokemon("Brouhabam", 19, Types.Bug, "ms-appx:///Assets/250px-Brouhabam-RS.png"));
			Pokemons.Add(new Pokemon("Barbicha", 42, Types.Dark, "ms-appx:///Assets/250px-Barbicha-RS.png"));
			Pokemons.Add(new Pokemon("Camérupt", 68, Types.Dragon, "ms-appx:///Assets/250px-Camérupt-RS.png"));
			Pokemons.Add(new Pokemon("Groret", 98, Types.Normal, "ms-appx:///Assets/250px-Groret-RS.png"));
			Pokemons.Add(new Pokemon("Milobellus", 71, Types.Grass, "ms-appx:///Assets/250px-Milobellus-RS.png"));
			Pokemons.Add(new Pokemon("Morphéo", 56, Types.Ghost, "ms-appx:///Assets/250px-Morphéo-RS.png"));
			Pokemons.Add(new Pokemon("Pingoléon", 36, Types.Ice, "ms-appx:///Assets/250px-Pingoléon-DP.png"));
			Pokemons.Add(new Pokemon("Tortipouss", 25, Types.Grass, "ms-appx:///Assets/250px-Tortipouss-Pt.png"));
			Pokemons.Add(new Pokemon("Florizarre", 73, Types.Grass, "ms-appx:///Assets/773px-Florizarre-RFVF.png"));
		}

		private void PokeHub_Loaded(object sender, RoutedEventArgs e)
		{
			foreach (PivotHeaderItem phi in FindVisualChildren<PivotHeaderItem>(PokeHub))
			{
				phi.Height = 100;
			}
			//foreach (PivotItem pi in FindVisualChildren<PivotItem>(PokeHub))
			//{
			//	pi.Height = 0;
			//	pi.Width = 0;
			//	pi.Visibility = Visibility.Collapsed;
			//}
		}

		public static IEnumerable<T> FindVisualChildren<T>(DependencyObject depObj) where T : DependencyObject
		{
			if (depObj != null)
			{
				for (int i = 0; i < VisualTreeHelper.GetChildrenCount(depObj); i++)
				{
					DependencyObject child = VisualTreeHelper.GetChild(depObj, i);
					if (child != null && child is T)
					{
						yield return (T)child;
					}

					foreach (T childOfChild in FindVisualChildren<T>(child))
					{
						yield return childOfChild;
					}
				}
			}
		}

		private void PokeHub_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			int a = 0;
			a += 1;
		}
	}
}

