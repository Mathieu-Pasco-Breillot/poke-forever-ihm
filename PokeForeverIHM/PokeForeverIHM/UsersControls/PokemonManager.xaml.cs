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
		private ObservableCollection<Pokemon> Pokemons = Pokemon.GetPokemons();
		public PokemonManager()
		{
			InitializeComponent();
			DataContext = Pokemons;
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

