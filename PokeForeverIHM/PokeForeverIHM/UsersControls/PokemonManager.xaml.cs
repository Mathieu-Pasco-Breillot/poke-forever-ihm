using Windows.UI.Xaml.Controls;
using PokeForeverIHM.Class;
using System.Collections.ObjectModel;
using Windows.UI.Xaml.Controls.Primitives;
using System.Collections.Generic;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Media;
using Windows.UI;
using System;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace PokeForeverIHM.UsersControls
{
	public sealed partial class PokemonManager : UserControl
	{
		private int pokemonToSwitchOut = -1;
		private int pokemonToSwitchIn = -1;
		private static ObservableCollection<Pokemon> pokemons = new ObservableCollection<Pokemon>();
		public static ObservableCollection<Pokemon> Pokemons
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
		public PokemonManager()
		{
			InitializeComponent();
			PopulateWithPokemons();
			DataContext = Pokemons;
		}

		public void PopulateWithPokemons()
		{
			Pokemons.Add(new Pokemon("Brouhabam", 19, Types.Bug, "ms-appx:///Assets/250px-Brouhabam-RS.png", "Brouhabam communique avec les autres en émettant un sifflement qui provient des tubes de son corps. Ce Pokémon n'élève la voix que pendant les combats."));
			Pokemons.Add(new Pokemon("Barbicha", 42, Types.Dark, "ms-appx:///Assets/250px-Barbicha-RS.png", "Lorsque Barbicha se déchaîne, il déclenche des secousses sismiques dans un rayon de plus 5 km autour de lui. Ce Pokémon a le pouvoir de prédire les véritables tremblements de terre."));
			Pokemons.Add(new Pokemon("Camérupt", 68, Types.Dragon, "ms-appx:///Assets/250px-Camérupt-RS.png", "Le corps de Camérupt renferme un volcan. Du magma à 10 000 degrés coule dans ses veines. De temps à temps, les bosses sur le dos de ce Pokémon entrent en éruption et crachent le magma surchauffé"));
			Pokemons.Add(new Pokemon("Groret", 98, Types.Normal, "ms-appx:///Assets/250px-Groret-RS.png", "Groret utilise les perles noires sur son corps pour exercer ses formidables pouvoirs. Quand il est en action, il entame une étrange danse. Les perles noires de ce Pokémon ont une valeur inestimables."));
			Pokemons.Add(new Pokemon("Milobellus", 71, Types.Grass, "ms-appx:///Assets/250px-Milobellus-RS.png", "Milobellus vit au fond des grands lacs. Lorsque le corps de ce Pokémon devient rose vif, il libère une pulsation d'énergie, capable d'apaiser les esprits agités."));
			Pokemons.Add(new Pokemon("Morphéo", 56, Types.Ghost, "ms-appx:///Assets/250px-Morphéo-RS.png", "Les variations de température ou d'humidité affectent sa structure cellulaire et son apparence."));
			Pokemons.Add(new Pokemon("Pingoléon", 36, Types.Ice, "ms-appx:///Assets/250px-Pingoléon-DP.png", "Les trois cornes de son bec sont le symbole de sa force. Celles du chef sont plus grosses que les autres."));
			Pokemons.Add(new Pokemon("Tortipouss", 25, Types.Grass, "ms-appx:///Assets/250px-Tortipouss-Pt.png", "La coquille sur son dos est faite de terre. Plus il est en bonne santé, plus elle est humide."));
			Pokemons.Add(new Pokemon("Florizarre", 73, Types.Grass, "ms-appx:///Assets/773px-Florizarre-RFVF.png", "Le parfum de sa fleur se fait plus pénétrant les lendemains de pluie. Cela appâte les autres Pokémon."));
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

		private SolidColorBrush GetColorFromHexa(string hexaColor)
		{
			byte A = Convert.ToByte(hexaColor.Substring(1, 2), 16);
			byte R = Convert.ToByte(hexaColor.Substring(3, 2), 16);
			byte G = Convert.ToByte(hexaColor.Substring(5, 2), 16);
			byte B = Convert.ToByte(hexaColor.Substring(7, 2), 16);
			SolidColorBrush scb = new SolidColorBrush(Color.FromArgb(A, R, G, B));
			return scb;
		}

		private void PokeListview_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			if (pokemonToSwitchIn == -1)
			{
				if (pokemonToSwitchOut == -1)
				{
					pokemonToSwitchOut = PokeListView.SelectedIndex;
				}
				else
				{
					pokemonToSwitchIn = PokeListView.SelectedIndex;

					Pokemon pokemonTempOut = Pokemons[pokemonToSwitchOut];
					Pokemon pokemonTempIn = Pokemons[pokemonToSwitchIn];

					Pokemons.Remove(pokemonTempOut);
					Pokemons.Remove(pokemonTempIn);

					if (pokemonToSwitchIn > pokemonToSwitchOut)
					{
						Pokemons.Insert(pokemonToSwitchOut, pokemonTempIn);
						Pokemons.Insert(pokemonToSwitchIn, pokemonTempOut);
					}
					else
					{
						Pokemons.Insert(pokemonToSwitchIn, pokemonTempOut);
						Pokemons.Insert(pokemonToSwitchOut, pokemonTempIn);
					}

					pokemonToSwitchIn = -1;
					pokemonToSwitchOut = -1;
				}
			}
		}

		private void ChangeActivePokemons()
		{
			int counterLVI = 0;
			foreach (StackPanel stp in FindVisualChildren<StackPanel>(PokeListView))
			{
				//StackPanel stp = dt.ToString();
				if (counterLVI > 0  && counterLVI <= 6)
				{
					stp.Background = GetColorFromHexa("#7FE07C29");
				}
				else
				{
					stp.Background = new SolidColorBrush(Colors.Black);
				}
				counterLVI++;
			}
		}

		private void PokeManager_Loaded(object sender, RoutedEventArgs e)
		{
			ChangeActivePokemons();
		}

		private void PokeListView_DragItemsCompleted(ListViewBase sender, DragItemsCompletedEventArgs args)
		{
			ChangeActivePokemons();
		}
	}
}

