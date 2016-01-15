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
using Windows.UI.Xaml.Input;
using Windows.System;

namespace PokeForeverIHM
{
	public sealed partial class GamePage : Page
	{
		private const double deltaDisplacement = 20D;
		TranslateTransform MenuPanelTranslate = new TranslateTransform();
		Player player = Player.Instance;
		private bool isLeftFoot = false;
		private VirtualKey lastArrowKeyTriggered;

		public GamePage()
		{
			InitializeComponent();
			Character.DataContext = player;
			Window.Current.Content.KeyDown += Arrow_KeyDown;
			Window.Current.Content.KeyUp += Arrow_KeyUp;
			//for (int i = 0; i < 48; i++)
			//{
			//	GridMap.ColumnDefinitions.Add(new ColumnDefinition());
			//}
			//for (int i = 0; i < 27; i++)
			//{
			//	GridMap.RowDefinitions.Add(new RowDefinition());
			//}
			Character.Source = player.ImageStopDown;
		}

		private void MenuButton_Tapped(object sender, Windows.UI.Xaml.Input.TappedRoutedEventArgs e)
		{
			menuPanel.Visibility = Visibility.Visible;
		}

		private void Map_Tapped(object sender, Windows.UI.Xaml.Input.TappedRoutedEventArgs e)
		{
			menuPanel.Visibility = Visibility.Collapsed;
		}

		#region KeyboardMoves
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

		private void Arrow_KeyUp(object sender, KeyRoutedEventArgs e)
		{
			switch (lastArrowKeyTriggered)
			{
				case VirtualKey.Up:
					Character.Source = player.ImageStopUp;
					break;
				case VirtualKey.Down:
					Character.Source = player.ImageStopDown;
					break;
				case VirtualKey.Left:
					Character.Source = player.ImageStopLeft;
					break;
				case VirtualKey.Right:
					Character.Source = player.ImageStopRight;
					break;
			}
		}

		private void Arrow_KeyDown(object sender, Windows.UI.Xaml.Input.KeyRoutedEventArgs e)
		{
			Task.Delay(10).Wait();
			switch (e.Key)
			{
				case VirtualKey.GamepadLeftThumbstickUp:
				case VirtualKey.Up:
					MoveUp();
					lastArrowKeyTriggered = VirtualKey.Up;
					break;
				case VirtualKey.GamepadLeftThumbstickDown:
				case VirtualKey.Down:
					MoveDown();
					lastArrowKeyTriggered = VirtualKey.Down;
					break;
				case VirtualKey.GamepadLeftThumbstickLeft:
				case VirtualKey.Left:
					MoveLeft();
					lastArrowKeyTriggered = VirtualKey.Left;
					break;
				case VirtualKey.GamepadLeftThumbstickRight:
				case VirtualKey.Right:
					MoveRight();
					lastArrowKeyTriggered = VirtualKey.Right;
					break;
			}
		}

		private void MoveUp()
		{
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
			if (GridMap.Margin.Top < -1500)
			{
				GridMap.Margin = new Thickness(GridMap.Margin.Left, GridMap.Margin.Top + deltaDisplacement, GridMap.Margin.Right, GridMap.Margin.Bottom - deltaDisplacement);
			}
			else
			{
				if (Character.Margin.Top > -(Window.Current.Bounds.Height / 2) + Character.Height + 24)
				{
					Character.Margin = new Thickness(Character.Margin.Left, Character.Margin.Top - deltaDisplacement, Character.Margin.Right, Character.Margin.Bottom + deltaDisplacement); 
				}
			}
		}

		private void MoveDown()
		{
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
			if (GridMap.Margin.Bottom < -1580D)
			{
				GridMap.Margin = new Thickness(GridMap.Margin.Left, GridMap.Margin.Top - deltaDisplacement, GridMap.Margin.Right, GridMap.Margin.Bottom + deltaDisplacement);
			}
			else
			{
				if (Character.Margin.Bottom > -(Window.Current.Bounds.Height / 2) + Character.Height + 24)
				{
					Character.Margin = new Thickness(Character.Margin.Left, Character.Margin.Top + deltaDisplacement, Character.Margin.Right, Character.Margin.Bottom - deltaDisplacement);
				}
			}
		}

		private void MoveLeft()
		{
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
			if (GridMap.Margin.Left < -2880D)
			{
				GridMap.Margin = new Thickness(GridMap.Margin.Left + deltaDisplacement, GridMap.Margin.Top, GridMap.Margin.Right - deltaDisplacement, GridMap.Margin.Bottom);
			}
			else
			{
				if (Character.Margin.Left > -(Window.Current.Bounds.Width / 2) + (Character.Width / 2))
				{
					Character.Margin = new Thickness(Character.Margin.Left - deltaDisplacement, Character.Margin.Top, Character.Margin.Right + deltaDisplacement, Character.Margin.Bottom);
				}
			}
		}

		private void MoveRight()
		{
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
			if (GridMap.Margin.Right < -2880D)
			{
				GridMap.Margin = new Thickness(GridMap.Margin.Left - deltaDisplacement, GridMap.Margin.Top, GridMap.Margin.Right + deltaDisplacement, GridMap.Margin.Bottom);
			}
			else
			{
				if (Character.Margin.Right > -(Window.Current.Bounds.Width / 2) + (Character.Width / 2))
				{
					Character.Margin = new Thickness(Character.Margin.Left + deltaDisplacement, Character.Margin.Top, Character.Margin.Right - deltaDisplacement, Character.Margin.Bottom);
				}
			}
		}
		#endregion

		#region FingerMoves
		private void DirectionalCross_Holding(object sender, Windows.UI.Xaml.Input.HoldingRoutedEventArgs e)
		{
			ChangeAssets(sender);
		}
		#endregion

		#region MouseMoves
		private void DirectionalCross_PointerPressed(object sender, Windows.UI.Xaml.Input.PointerRoutedEventArgs e)
		{
			ChangeAssets(sender);
		}
		#endregion
	}
}
