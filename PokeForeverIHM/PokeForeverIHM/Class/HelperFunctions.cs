using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
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

		[DllImport("user32.dll")]
		static extern IntPtr GetDC(IntPtr hwnd);

		[DllImport("user32.dll")]
		static extern int ReleaseDC(IntPtr hwnd, IntPtr hdc);

		[DllImport("gdi32.dll")]
		static extern uint GetPixel(IntPtr hdc, int nXPos, int nYPos);

		static public Color GetPixelColor(int x, int y)
		{
			IntPtr hdc = GetDC(IntPtr.Zero);
			uint pixel = GetPixel(hdc, x, y);
			ReleaseDC(IntPtr.Zero, hdc);
			byte R = Convert.ToByte((pixel & 0x000000FF));
			byte G = Convert.ToByte((pixel & 0x0000FF00) >> 8);
			byte B = Convert.ToByte((pixel & 0x00FF0000) >> 16);
			byte A = Convert.ToByte((pixel & 0xFF000000) >> 24);
			Color color = Color.FromArgb(A, R, G, B);
			return color;
		}
	}
}
