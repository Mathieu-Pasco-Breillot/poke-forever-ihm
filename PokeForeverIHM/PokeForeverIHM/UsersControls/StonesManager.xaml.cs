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
		private int stoneToSwitchOut = -1;
		private int stoneToSwitchIn = -1;
		private ObservableCollection<Stone> stones = Stone.Instance;
		public StonesManager()
		{
			this.InitializeComponent();
			DataContext = stones;
		}

		private void StonesListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			if (stoneToSwitchIn == -1)
			{
				if (stoneToSwitchOut == -1)
				{
					stoneToSwitchOut = StonesListView.SelectedIndex;
				}
				else
				{
					stoneToSwitchIn = StonesListView.SelectedIndex;

					Stone stoneTempOut = stones[stoneToSwitchOut];
					Stone stoneTempIn = stones[stoneToSwitchIn];

					stones.Remove(stoneTempOut);
					stones.Remove(stoneTempIn);

					if (stoneToSwitchIn > stoneToSwitchOut)
					{
						stones.Insert(stoneToSwitchOut, stoneTempIn);
						stones.Insert(stoneToSwitchIn, stoneTempOut);
					}
					else
					{
						stones.Insert(stoneToSwitchIn, stoneTempOut);
						stones.Insert(stoneToSwitchOut, stoneTempIn);
					}
					stoneToSwitchIn = -1;
					stoneToSwitchOut = -1;
				}
			}
		}
	}
}
