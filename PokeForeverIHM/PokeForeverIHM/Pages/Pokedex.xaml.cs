using PokeForeverIHM.Class;
using System.Collections.ObjectModel;
using Windows.UI.Xaml.Controls;

// Pour plus d'informations sur le modèle d'élément Page vierge, voir la page http://go.microsoft.com/fwlink/?LinkId=234238

namespace PokeForeverIHM.Pages
{
	/// <summary>
	/// Une page vide peut être utilisée seule ou constituer une page de destination au sein d'un frame.
	/// </summary>
	public sealed partial class Pokedex : Page
	{
		private ObservableCollection<Pokemon> pokedexCollection = Pokemon.Instance;
		public Pokedex()
		{
			InitializeComponent();
			DataContext = pokedexCollection;
		}
	}
}
