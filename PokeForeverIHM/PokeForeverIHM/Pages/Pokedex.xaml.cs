using PokeForeverIHM.Class;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// Pour plus d'informations sur le modèle d'élément Page vierge, voir la page http://go.microsoft.com/fwlink/?LinkId=234238

namespace PokeForeverIHM.Pages
{
	/// <summary>
	/// Une page vide peut être utilisée seule ou constituer une page de destination au sein d'un frame.
	/// </summary>
	public sealed partial class Pokedex : Page
	{
		private ObservableCollection<Pokemon> pokedexCollection;
		public Pokedex(ref ObservableCollection<Pokemon> PokemonCollection)
		{
			InitializeComponent();
			PokedexCollection = PokemonCollection;
			DataContext = PokemonCollection;
		}

		public ObservableCollection<Pokemon> PokedexCollection
		{
			get
			{
				return pokedexCollection;
			}

			set
			{
				pokedexCollection = value;
			}
		}
	}
}
