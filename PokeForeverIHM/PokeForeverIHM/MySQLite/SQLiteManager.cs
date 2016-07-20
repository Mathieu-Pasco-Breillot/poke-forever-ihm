using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite.Net;
using Windows.Storage;
using Windows.UI.Xaml;

namespace PokeForeverIHM.MySQLite
{
	class SQLiteManager<T> : SQLiteConnection where T : class
	{
		public SQLiteManager() : base(new SQLite.Net.Platform.WinRT.SQLitePlatformWinRT(), ApplicationData.Current.LocalFolder.Path + "\\SQLiteDB")
		{
			try
			{
				this.CreateTable<T>();
			}
			catch (Exception)
			{
				this.MigrateTable<T>();
			}
		}
	}
}
