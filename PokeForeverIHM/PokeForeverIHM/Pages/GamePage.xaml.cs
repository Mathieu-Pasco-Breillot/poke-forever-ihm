using PokeForeverIHM.UsersControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

namespace PokeForeverIHM
{
	public sealed partial class GamePage : Page
	{
        TranslateTransform MenuPanelTranslate = new TranslateTransform();

		public GamePage()
		{
			InitializeComponent();
		}
        
        private void MenuButton_Click(object sender, Windows.UI.Xaml.Input.TappedRoutedEventArgs e)
        {
            menuPanel.Visibility = Visibility.Visible;
            menuPanel.Focus(FocusState.Pointer);
            FocusState fs = menuPanel.FocusState;
            
        }

        private void menuPanel_LostFocus(object sender, RoutedEventArgs e)
        {
            FocusState fs = menuPanel.FocusState;
            menuPanel.Visibility = Visibility.Collapsed;
            if (menuPanel.FocusState.Equals(1))
            {
                menuPanel.Focus(FocusState.Unfocused);
            }
        }
    }
}
