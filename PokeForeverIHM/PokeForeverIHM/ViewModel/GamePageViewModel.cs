using Windows.UI.Xaml;

namespace PokeForeverIHM.ViewModel
{
	internal class GamePageViewModel
	{
		private GamePage myView;

		public GamePageViewModel(GamePage myView)
		{
			this.myView = myView;
			myView.myUCMenuButton.Tapped += MenuButton_Tapped;
			myView.myUCGridMap.Tapped += Map_Tapped;	
		}

		private void MenuButton_Tapped(object sender, Windows.UI.Xaml.Input.TappedRoutedEventArgs e)
		{
			myView.myUCMenuPanel.Visibility = Visibility.Visible;
		}

		private void Map_Tapped(object sender, Windows.UI.Xaml.Input.TappedRoutedEventArgs e)
		{
			myView.myUCMenuPanel.Visibility = Visibility.Collapsed;
		}
	}
}