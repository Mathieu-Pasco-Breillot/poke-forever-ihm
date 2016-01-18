using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using PokeForeverIHM.Class;
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
	/// <summary>
	/// Une page vide peut être utilisée seule ou constituer une page de destination au sein d'un frame.
	/// </summary>
	public sealed partial class ItemManager : UserControl
	{
		private int itemToSwitchOut = -1;
		private int itemToSwitchIn = -1;
		private ObservableCollection<Item> items= Item.Instance;
		public ItemManager()
		{
			this.InitializeComponent();
			DataContext = items;
		}

		private void ItemListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			if (itemToSwitchIn == -1)
			{
				if (itemToSwitchOut == -1)
				{
					itemToSwitchOut = ItemListView.SelectedIndex;
				}
				else
				{
					itemToSwitchIn = ItemListView.SelectedIndex;

					Item itemTempOut = items[itemToSwitchOut];
					Item itemTempIn = items[itemToSwitchIn];

					items.Remove(itemTempOut);
					items.Remove(itemTempIn);

					if (itemToSwitchIn > itemToSwitchOut)
					{
						items.Insert(itemToSwitchOut, itemTempIn);
						items.Insert(itemToSwitchIn, itemTempOut);
					}
					else
					{
						items.Insert(itemToSwitchIn, itemTempOut);
						items.Insert(itemToSwitchOut, itemTempIn);
					}
					itemToSwitchIn = -1;
					itemToSwitchOut = -1;
				}
			}
		}
	}
}
