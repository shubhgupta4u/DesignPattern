using DesignPattern.Demo.Entities.MasterData;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace DesignPattern.Demo.Core.Creational.FactoryPattern
{
    internal class MasterDataFactory
    {
        public MasterDataList<ICloneable> GetMasterDataObject(DataTable table, string masterDataKey)
        {
            MasterDataList<ICloneable> obj = new MasterDataList<ICloneable>();
            if (masterDataKey == null)
            {
                return obj;
            }
            else if (masterDataKey.Equals("CEDANT"))
            {
                obj = new CedantList(table);
            }
            else if (masterDataKey.Equals("BROKER"))
            {
                obj = new BrokerList(table);
            }          
            return obj;
        }
    }
}
