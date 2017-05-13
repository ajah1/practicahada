using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace ClassLibrary.CAD
{
	public class CADcarrito
	{
		const string s = "data source=.\\SQLEXPRESS;Integrated"
				   + "Security = SSPI; AttachDBFilename =| DataDirectory |\\Database1.mdf;"
				   + "User Instance = true";
		
		SqlConnection conn = new SqlConnection(s);

		public CADcarrito()
		{
		}

	}
}
