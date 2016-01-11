using System.Collections.ObjectModel;
using PokeForeverIHM.Class;
using Windows.UI.Xaml.Controls;

// Pour plus d'informations sur le modèle d'élément Page vierge, voir la page http://go.microsoft.com/fwlink/?LinkId=234238

namespace PokeForeverIHM.UsersControls
{
	/// <summary>
	/// Une page vide peut être utilisée seule ou constituer une page de destination au sein d'un frame.
	/// </summary>
	public sealed partial class PokeballManager : UserControl
	{
		private int ballToSwitchOut = -1;
		private int ballToSwitchIn = -1;
		private ObservableCollection<Ball> Balls = Ball.GetBalls();
		public PokeballManager()
		{
			this.InitializeComponent();
			DataContext = Balls;
		}

		private void PokeballListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			if (ballToSwitchIn == -1)
			{
				if (ballToSwitchOut == -1)
				{
					ballToSwitchOut = PokeballListView.SelectedIndex;
				}
				else
				{
					ballToSwitchIn = PokeballListView.SelectedIndex;

					Ball pokemonTempOut = Balls[ballToSwitchOut];
					Ball pokemonTempIn = Balls[ballToSwitchIn];

					Balls.Remove(pokemonTempOut);
					Balls.Remove(pokemonTempIn);

					if (ballToSwitchIn > ballToSwitchOut)
					{
						Balls.Insert(ballToSwitchOut, pokemonTempIn);
						Balls.Insert(ballToSwitchIn, pokemonTempOut);
					}
					else
					{
						Balls.Insert(ballToSwitchIn, pokemonTempOut);
						Balls.Insert(ballToSwitchOut, pokemonTempIn);
					}
					ballToSwitchIn = -1;
					ballToSwitchOut = -1;
				}
			}
		}
	}
}
