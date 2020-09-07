using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;


namespace Winform_SQL_DB_Project_B
{
	class Class_DM
	{
		public bool retValue = false;
		public string dbIp = "192.168.0.67";
		public string dbName = "XE";
		public string dbId = "hr";
		public string dbPw = "1234";
		public DataSet ds = new DataSet();

		public string Connect_Oracle()
		{
			try
			{
				OracleConnection pgOraConn = new OracleConnection(
					$"Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST={dbIp})(PORT=1521)))" +
					$"(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME={dbName})));User ID={dbId};Password={dbPw};Connection Timeout=30;");
				pgOraConn.Open();
				OracleCommand pgOraCmd = new OracleCommand("SELECT * FROM USER_TABLES", pgOraConn);
				OracleDataAdapter oda = new OracleDataAdapter(pgOraCmd);
				DataSet ds_temp = new DataSet();

				oda.Fill(ds_temp);
				pgOraConn.Close();

				ds = ds_temp;

				retValue = true;
				return "성공";
			}
			catch (Exception ae)
			{
				retValue = false;
				Console.WriteLine(ae);
				return "실패";
			}
		}
		public void Cmd_Oracle(string cmd)
		{
			try
			{
				OracleConnection pgOraConn = new OracleConnection(
					$"Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST={dbIp})(PORT=1521)))" +
					$"(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME={dbName})));User ID={dbId};Password={dbPw};Connection Timeout=30;");
				pgOraConn.Open();
				OracleCommand pgOraCmd = new OracleCommand(cmd, pgOraConn);
				OracleDataAdapter oda = new OracleDataAdapter(pgOraCmd);
				DataSet ds_temp = new DataSet();

				oda.Fill(ds_temp);
				pgOraConn.Close();

				ds = ds_temp;

				retValue = true;
			}
			catch (Exception e)
			{
				retValue = false;
				Console.WriteLine(e);
			}
		}
		public string Connect_Oracle(string treeName)
		{
			try
			{
				OracleConnection pgOraConn = new OracleConnection(
					$"Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST={dbIp})(PORT=1521)))" +
					$"(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME={dbName})));User ID={dbId};Password={dbPw};Connection Timeout=30;");
				pgOraConn.Open();
				OracleCommand pgOraCmd = new OracleCommand("SELECT * FROM " + treeName, pgOraConn);
				OracleDataAdapter oda = new OracleDataAdapter(pgOraCmd);
				DataSet ds_temp = new DataSet();

				oda.Fill(ds_temp);
				pgOraConn.Close();

				ds = ds_temp;

				retValue = true;
				return "성공";
			}
			catch (Exception ae)
			{
				retValue = false;
				Console.WriteLine(ae);
				return "실패";
			}
		}
		public void Tree_Oracle(string treeName)
		{
			Connect_Oracle(treeName);
		}
	}
}