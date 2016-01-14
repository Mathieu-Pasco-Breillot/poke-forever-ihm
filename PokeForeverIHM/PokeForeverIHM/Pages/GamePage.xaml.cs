using PokeForeverIHM.UsersControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
using PokeForeverIHM.Class;

namespace PokeForeverIHM
{
	public sealed partial class GamePage : Page
	{
		private const double deltaDisplacement = 10D;
		TranslateTransform MenuPanelTranslate = new TranslateTransform();
		Player player = Player.Instance;
		private bool isLeftFoot = false;

		public GamePage()
		{
			InitializeComponent();
			Character.DataContext = player;
			Window.Current.Content.KeyDown += Arrow_KeyDown;
			TabIndex = 2;
			for (int i = 0; i < 48; i++)
			{
				GridMap.ColumnDefinitions.Add(new ColumnDefinition());
			}
			for (int i = 0; i < 27; i++)
			{
				GridMap.RowDefinitions.Add(new RowDefinition());
			}
			Character.Source = player.ImageStopDown;
		}

		private void MenuButton_Click(object sender, Windows.UI.Xaml.Input.TappedRoutedEventArgs e)
		{
			menuPanel.Visibility = Visibility.Visible;
		}

		private void Map_Tapped(object sender, Windows.UI.Xaml.Input.TappedRoutedEventArgs e)
		{
			menuPanel.Visibility = Visibility.Collapsed;
		}

		private void ChangeAssets(object sender)
		{
			// Used to close the menu panel
			menuPanel.Visibility = Visibility.Collapsed;
			// Cast the sender to a DirectionalCross to retrieve its name
			DirectionalCross btn = (DirectionalCross)sender;
			switch (btn.Name)
			{
				case "ButtonMoveTop":
					MoveUp();
					break;
				case "ButtonMoveBottom":
					MoveDown();
					break;
				case "ButtonMoveLeft":
					MoveLeft();
					break;
				case "ButtonMoveRight":
					MoveRight();
					break;
			}
		}

		private void DirectionalCross_Holding(object sender, Windows.UI.Xaml.Input.HoldingRoutedEventArgs e)
		{
			ChangeAssets(sender);
		}

		private void Arrow_KeyDown(object sender, Windows.UI.Xaml.Input.KeyRoutedEventArgs e)
		{
			Task.Delay(10).Wait();
			switch (e.Key)
			{
				case Windows.System.VirtualKey.Up:
					MoveUp();
					break;
				case Windows.System.VirtualKey.Down:
					MoveDown();
					break;
				case Windows.System.VirtualKey.Left:
					MoveLeft();
					break;
				case Windows.System.VirtualKey.Right:
					MoveRight();
					break;
			}
		}

		private void MoveUp()
		{
			Thickness displacementUp = new Thickness(Character.Margin.Left, Character.Margin.Top - deltaDisplacement, Character.Margin.Right, Character.Margin.Bottom);
			if (isLeftFoot)
			{
				Character.Source = player.ImageMoveUpRightFoot;
				isLeftFoot = false;
			}
			else
			{
				Character.Source = player.ImageMoveUpLeftFoot;
				isLeftFoot = true;
			}
			Character.Margin = displacementUp;
		}

		private void MoveDown()
		{
			Thickness displacementDown = new Thickness(Character.Margin.Left, Character.Margin.Top + deltaDisplacement, Character.Margin.Right, Character.Margin.Bottom);
			if (isLeftFoot)
			{
				Character.Source = player.ImageMoveDownRightFoot;
				isLeftFoot = false;
			}
			else
			{
				Character.Source = player.ImageMoveDownLeftFoot;
				isLeftFoot = true;
			}
			Character.Margin = displacementDown;
		}

		private void MoveLeft()
		{
			Thickness displacementLeft = new Thickness(Character.Margin.Left - deltaDisplacement, Character.Margin.Top, Character.Margin.Right, Character.Margin.Bottom);
			if (isLeftFoot)
			{
				Character.Source = player.ImageMoveLeftRightFoot;
				isLeftFoot = false;
			}
			else
			{
				Character.Source = player.ImageMoveLeftLeftFoot;
				isLeftFoot = true;
			}
			Character.Margin = displacementLeft;
		}

		private void MoveRight()
		{
			Thickness displacementRight = new Thickness(Character.Margin.Left + deltaDisplacement, Character.Margin.Top, Character.Margin.Right, Character.Margin.Bottom);
			if (isLeftFoot)
			{
				Character.Source = player.ImageMoveRightRightFoot;
				isLeftFoot = false;
			}
			else
			{
				Character.Source = player.ImageMoveRightLeftFoot;
				isLeftFoot = true;
			}
			Character.Margin = displacementRight;
		}

		private void DirectionalCross_PointerPressed(object sender, Windows.UI.Xaml.Input.PointerRoutedEventArgs e)
		{
			ChangeAssets(sender);
		}
	}
}
