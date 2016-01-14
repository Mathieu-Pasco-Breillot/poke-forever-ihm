using System.Collections.ObjectModel;
using PokeForeverIHM.Class;
using Windows.UI.Xaml.Controls;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace PokeForeverIHM.UsersControls
{
	/// <summary>
	/// Une page vide peut être utilisée seule ou constituer une page de destination au sein d'un frame.
	/// </summary>
	public sealed partial class StonesManager : UserControl
	{
		private int ballToSwitchOut = -1;
		private int ballToSwitchIn = -1;
		private ObservableCollection<Stone> stones = Stone.Stones;
		public StonesManager()
		{
			this.InitializeComponent();
			DataContext = stones;
		}

		private void StonesListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			if (ballToSwitchIn == -1)
			{
				if (ballToSwitchOut == -1)
				{
					ballToSwitchOut = StonesListView.SelectedIndex;
				}
				else
				{
					ballToSwitchIn = StonesListView.SelectedIndex;

					Stone pokemonTempOut = stones[ballToSwitchOut];
					Stone pokemonTempIn = stones[ballToSwitchIn];

					stones.Remove(pokemonTempOut);
					stones.Remove(pokemonTempIn);

					if (ballToSwitchIn > ballToSwitchOut)
					{
						stones.Insert(ballToSwitchOut, pokemonTempIn);
						stones.Insert(ballToSwitchIn, pokemonTempOut);
					}
					else
					{
						stones.Insert(ballToSwitchIn, pokemonTempOut);
						stones.Insert(ballToSwitchOut, pokemonTempIn);
					}
					ballToSwitchIn = -1;
					ballToSwitchOut = -1;
				}
			}
		}
	}
}
