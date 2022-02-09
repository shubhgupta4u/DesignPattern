using System;
using System.Data;
using System.Text.Json;
using System.Linq;
using System.Collections.Generic;

namespace DesignPattern.Demo.Entities.MasterData
{
    public class BrokerList : MasterDataList<Broker>
    {
        public BrokerList(IEnumerable<Broker> brokers):base(brokers,false)
        {

        }
        public BrokerList(DataTable table)
        {
            foreach (DataRow row in table.Rows)
            {
                Broker broker = new Broker();
                int id;
                if (int.TryParse(Convert.ToString(row["Id"]), out id))
                {
                    broker.Id = id;
                }
                broker.BkrCode = Convert.ToString(row["BkrCode"]);
                broker.Name = Convert.ToString(row["Name"]);
                broker.Description = Convert.ToString(row["Description"]);
                this.Add(broker);
            }
        }
        public static implicit operator MasterDataList<ICloneable>(BrokerList brokers) => new MasterDataList<ICloneable>(brokers, false);
        public static implicit operator BrokerList(MasterDataList<ICloneable> brokers) => new BrokerList(brokers.Cast<Broker>());
    }
    public class Broker: ICloneable
    {
        public int Id { get; set; }
        public string BkrCode { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public object Clone()
        {
            return this.MemberwiseClone();
        }
        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}