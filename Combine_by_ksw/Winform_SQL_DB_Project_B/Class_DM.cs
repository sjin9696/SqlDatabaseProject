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

		public int Make_Index(string tree) // 허선용 -> 곽상우
		{
			try
			{
				OracleConnection pgOraConn = new OracleConnection(
					$"Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST={dbIp})(PORT=1521)))" +
					$"(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME={dbName})));User ID={dbId};Password={dbPw};Connection Timeout=30;");
				pgOraConn.Open();

				string Cmd_Temp = "";

				if (tree == "table")
				{
					Cmd_Temp = "select table_name from user_tables";
				}
				else if (tree == "proseger")
				{
					Cmd_Temp = "SELECT object_name FROM user_objects WHERE object_type = 'PROCEDURE'";
				}
				else if (tree == "sequence")
				{
					Cmd_Temp = "SELECT sequence_name FROM USER_SEQUENCES";
				}
				else
				{
					Console.WriteLine("Class_DM.Make_Index(잘못된 입력)");
				}

				OracleCommand pgOraCmd = new OracleCommand(Cmd_Temp, pgOraConn);
				OracleDataAdapter oda = new OracleDataAdapter(pgOraCmd);
				DataSet ds_Index = new DataSet();

				oda.Fill(ds_Index);
				ds = ds_Index;
				int idx = ds_Index.Tables[0].Rows.Count;

				pgOraConn.Close();

				return idx;
			}
			catch (Exception e)
			{
				retValue = false;
				Console.WriteLine(e);

				return 0;
			}
		}

		public string Connect_Oracle() // 허선용
		{
			try
			{
				OracleConnection pgOraConn = new OracleConnection(
					$"Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST={dbIp})(PORT=1521)))" +
					$"(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME={dbName})));User ID={dbId};Password={dbPw};Connection Timeout=30;");
				pgOraConn.Open();
				pgOraConn.Close();

				retValue = true;
				return "오라클 연결성공";
			}
			catch (Exception e)
			{
				retValue = false;
				Console.WriteLine(e);
				return "오라클 연결실패";
			}
		}
		public string Tree_Oracle(string treeName, string NodeParent) // 이수민 -> 곽상우
		{
			Connect_Oracle(treeName, NodeParent);
            if (NodeParent == "테이블")
            {
				return null;
            }
            else if (NodeParent == "프로시저")
            {
				string notice = null;
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
					notice += ds.Tables[0].Rows[i][3].ToString() + Environment.NewLine;
				}
				return notice;
			}
            else if (NodeParent == "시퀀스")
            {
				string notice = null;
				for (int i = 0; i < 8; i++)
				{
					notice += ds.Tables[0].Rows[0][i].ToString() + Environment.NewLine;
				}
				return notice;
			}
			else
            {
                Console.WriteLine("Class_DM.Tree_Oracle(treeName, NodeParent) => 잘못된입력");
				return null;
			}
		}

		public void Connect_Oracle(string treeName, string NodeParent) // 이수민 -> 허선용 -> 곽상우
		{
			try
			{
				OracleConnection pgOraConn = new OracleConnection(
					$"Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST={dbIp})(PORT=1521)))" +
					$"(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME={dbName})));User ID={dbId};Password={dbPw};Connection Timeout=30;");
				pgOraConn.Open();

				string Cmd_Temp = "";

				if (NodeParent == "테이블")
                {
					Cmd_Temp = "SELECT * FROM " + treeName;
				}
				else if (NodeParent == "프로시저")
				{
					Cmd_Temp = "SELECT * FROM user_source WHERE name=upper('" + treeName + "')";
				}
				else if (NodeParent == "시퀀스")
				{
					Cmd_Temp = "SELECT * FROM USER_SEQUENCES WHERE SEQUENCE_NAME = '" + treeName + "'";
				}
                else
                {
                    Console.WriteLine("Class_DM.Connect_Oracle(treeName, NodeParent) => 잘못된입력");
                }
				OracleCommand pgOraCmd = new OracleCommand(Cmd_Temp, pgOraConn);
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
		
		public void Cmd_Oracle(string cmd) // 곽상우
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
	}
}