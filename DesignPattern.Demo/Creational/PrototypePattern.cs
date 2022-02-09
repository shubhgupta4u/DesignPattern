using DesignPattern.Demo.Core.Creational;
using DesignPattern.Demo.Entities.MasterData;
using System;
using System.Data;

namespace DesignPattern.Demo.Creational
{
    static class PrototypePattern
    {
        private const string BROKERKEY = "BROKER";
        private const string CEDANTKEY = "CEDANT";
        public static void RunDemo()
        {
            MasterDataCache.LoadMasterData(GetDummyMasterData());
            BrokerList brokers = MasterDataCache.GetMasterData(BROKERKEY);            
            foreach(Broker broker in brokers)
            {
                Console.WriteLine(broker);
            }

            CedantList cedants = MasterDataCache.GetMasterData(CEDANTKEY);
            foreach (Cedant cedant in cedants)
            {
                Console.WriteLine(cedant);
            }
        }

        private static DataSet GetDummyMasterData()
        {
            DataSet ds = new DataSet();
            ds.Tables.Add(GetDummyCedantMasterData());
            ds.Tables.Add(GetDummyBrokerMasterData());
            return ds;
        }
        private static DataTable GetDummyCedantMasterData()
        {
            DataTable table = new DataTable();
            table.TableName = CEDANTKEY;
            DataColumn col1 = new DataColumn("Id");
            DataColumn col2 = new DataColumn("Name");
            DataColumn col3 = new DataColumn("CedantCode");
            DataColumn col4 = new DataColumn("Description");
            table.Columns.Add(col1);
            table.Columns.Add(col2);
            table.Columns.Add(col3);
            table.Columns.Add(col4);
            DataRow row = table.NewRow();
            row["Id"] = 1;
            row["Name"] = "Swara Gupta";
            row["CedantCode"] = "SWG";
            row["Description"] = "SWG - Swara Gupta";
            table.Rows.Add(row);
            return table;
        }
        private static DataTable GetDummyBrokerMasterData()
        {
            DataTable table = new DataTable();
            table.TableName = BROKERKEY;
            DataColumn col1 = new DataColumn("Id");
            DataColumn col2 = new DataColumn("Name");
            DataColumn col3 = new DataColumn("BkrCode");
            DataColumn col4 = new DataColumn("Description");
            table.Columns.Add(col1);
            table.Columns.Add(col2);
            table.Columns.Add(col3);
            table.Columns.Add(col4);
            DataRow row = table.NewRow();
            row["Id"] = 1;
            row["Name"] = "Shubh Gupta";
            row["BkrCode"] = "SBG";
            row["Description"] = "SBG - Shubh Gupta";
            table.Rows.Add(row);
            return table;
        }
    }
}
