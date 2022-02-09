using DesignPattern.Demo.Core.Creational.FactoryPattern;
using DesignPattern.Demo.Entities.MasterData;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace DesignPattern.Demo.Core.Creational
{
    public static class MasterDataCache
    {
        private static Dictionary<string, MasterDataList<ICloneable>> _masterData = null;

        public static MasterDataList<ICloneable> GetMasterData(String masterDataKey) 
        {
            if(_masterData == null)
            {
                throw new KeyNotFoundException("Master Data has not initialized");
            }
            else
            {
                MasterDataList<ICloneable> cachedMasterData = MasterDataCache._masterData.GetValueOrDefault(masterDataKey);
                return cachedMasterData.Clone();
            }            
        }

        public static void LoadMasterData(DataSet ds)
        {
            if(ds != null && ds.Tables.Count > 0)
            {
                MasterDataCache._masterData = new Dictionary<string, MasterDataList<ICloneable>>();
                MasterDataFactory factory = new MasterDataFactory();
                foreach (DataTable table in ds.Tables)
                {
                    MasterDataCache._masterData.Add(table.TableName, factory.GetMasterDataObject(table, table.TableName));
                }
            }
        }

        public static void AddOrUpdateMasterData(DataTable table, string masterDataKey)
        {
            if (table != null && table.Rows.Count > 0)
            {
                if (MasterDataCache._masterData == null)
                {
                    MasterDataCache._masterData = new Dictionary<string, MasterDataList<ICloneable>>();
                }
                MasterDataFactory factory = new MasterDataFactory();
                if (MasterDataCache._masterData.ContainsKey(masterDataKey))
                {
                    MasterDataCache._masterData[masterDataKey] = factory.GetMasterDataObject(table, masterDataKey);
                }
                else
                {
                    MasterDataCache._masterData.Add(masterDataKey, factory.GetMasterDataObject(table, masterDataKey));
                }
            }
        }
        public static void RemoveMasterData(string masterDataKey)
        {
            if (MasterDataCache._masterData != null && MasterDataCache._masterData.ContainsKey(masterDataKey))
            {
                MasterDataCache._masterData.Remove(masterDataKey);
            }
        }
        public static void RemoveAll()
        {
            if(MasterDataCache._masterData != null)
            {
                MasterDataCache._masterData.Clear();
            }
        }
    }
}
