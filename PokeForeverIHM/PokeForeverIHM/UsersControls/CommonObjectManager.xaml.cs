using System;
using System.Collections.Generic;
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

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace PokeForeverIHM.UsersControls
{
	public sealed partial class CommonObjectManager : UserControl
	{
		public CommonObjectManager()
		{
			this.InitializeComponent();
		}

		private void CommonObjectListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{

		}

		private void CommonObjectListView_DragItemsCompleted(ListViewBase sender, DragItemsCompletedEventArgs args)
		{

		}
	}
}
