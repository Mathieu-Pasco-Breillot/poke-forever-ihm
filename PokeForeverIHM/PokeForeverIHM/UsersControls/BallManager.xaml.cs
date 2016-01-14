using System.Collections.ObjectModel;
using PokeForeverIHM.Class;
using Windows.UI.Xaml.Controls;

// Pour plus d'informations sur le modèle d'élément Page vierge, voir la page http://go.microsoft.com/fwlink/?LinkId=234238

namespace PokeForeverIHM.UsersControls
{
	/// <summary>
	/// Une page vide peut être utilisée seule ou constituer une page de destination au sein d'un frame.
	/// </summary>
	public sealed partial class BallManager : UserControl
	{
		private int ballToSwitchOut = -1;
		private int ballToSwitchIn = -1;
		private ObservableCollection<Ball> balls = Ball.Balls;
		public BallManager()
		{
			this.InitializeComponent();
			DataContext = balls;
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

					Ball pokemonTempOut = balls[ballToSwitchOut];
					Ball pokemonTempIn = balls[ballToSwitchIn];

					balls.Remove(pokemonTempOut);
					balls.Remove(pokemonTempIn);

					if (ballToSwitchIn > ballToSwitchOut)
					{
						balls.Insert(ballToSwitchOut, pokemonTempIn);
						balls.Insert(ballToSwitchIn, pokemonTempOut);
					}
					else
					{
						balls.Insert(ballToSwitchIn, pokemonTempOut);
						balls.Insert(ballToSwitchOut, pokemonTempIn);
					}
					ballToSwitchIn = -1;
					ballToSwitchOut = -1;
				}
			}
		}
	}
}
