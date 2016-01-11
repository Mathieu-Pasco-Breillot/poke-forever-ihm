using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using PokeForeverIHM.Class;
using Windows.ApplicationModel.Core;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

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

		private void PokeListview_SelectionChangedMerged(object sender, SelectionChangedEventArgs e)
		{
			PokeListview_SelectionChanged(sender, e);
			ChangeActivePokemons();
		}

		private void ChangeActivePokemons()
		{
			int counterLVI = 0;
			foreach (StackPanel stp in HelperFunctions.FindVisualChildren<StackPanel>(PokeListView))
			{
				//StackPanel stp = dt.ToString();
				if (counterLVI > 0 && counterLVI <= 6)
				{
					stp.Background = HelperFunctions.GetColorFromHexa("#7FE07C29");
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

