using System;

namespace PokeForeverIHM.EnumManager
{
	public enum DataConnectionResource : Int32
	{
		[StringValue("Server=myServer;Port=3306;Database=db_name;Uid=userName;Pwd=password")]
		GENERICMYSQL = 1,
		[StringValue("Server=127.0.0.1;Port=3306;Database=db_name;Uid=root;Pwd=''")]
		LOCALMYSQL = 2,
		[StringValue("http://localhost:63684/api/")]
		LOCALAPI = 3,
	}
}
