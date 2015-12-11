using System;
using System.Collections.Generic;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Media;

namespace PokeForeverIHM.Class
{
	public static class HelperFunctions
	{
		public static IEnumerable<T> FindVisualChildren<T>(DependencyObject depObj) where T : DependencyObject
		{
			if (depObj != null)
			{
				for (int i = 0; i < VisualTreeHelper.GetChildrenCount(depObj); i++)
				{
					DependencyObject child = VisualTreeHelper.GetChild(depObj, i);
					if (child != null && child is T)
					{
						yield return (T)child;
					}

					foreach (T childOfChild in FindVisualChildren<T>(child))
					{
						yield return childOfChild;
					}
				}
			}
		}

		public static SolidColorBrush GetColorFromHexa(string hexaColor)
		{
			byte A = Convert.ToByte(hexaColor.Substring(1, 2), 16);
			byte R = Convert.ToByte(hexaColor.Substring(3, 2), 16);
			byte G = Convert.ToByte(hexaColor.Substring(5, 2), 16);
			byte B = Convert.ToByte(hexaColor.Substring(7, 2), 16);
			SolidColorBrush scb = new SolidColorBrush(Color.FromArgb(A, R, G, B));
			return scb;
		}
	}
}
