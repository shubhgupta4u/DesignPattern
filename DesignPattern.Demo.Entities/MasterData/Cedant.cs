using System;
using System.Collections.Generic;
using System.Data;
using System.Text.Json;
using System.Linq;

namespace DesignPattern.Demo.Entities.MasterData
{
    public class CedantList : MasterDataList<Cedant> 
    {
        public CedantList(IEnumerable<Cedant> cedants) : base(cedants, false)
        {

        }
        public CedantList(DataTable table)
        {
            foreach (DataRow row in table.Rows)
            {
                Cedant cedant = new Cedant();
                int id;
                if (int.TryParse(Convert.ToString(row["Id"]), out id))
                {
                    cedant.Id = id;
                }
                cedant.CedantCode = Convert.ToString(row["CedantCode"]);
                cedant.Name = Convert.ToString(row["Name"]);
                cedant.Description = Convert.ToString(row["Description"]);
                this.Add(cedant);
            }
        }
        public static implicit operator MasterDataList<ICloneable>(CedantList cedants) => new MasterDataList<ICloneable>(cedants, false);
        public static implicit operator CedantList(MasterDataList<ICloneable> cedants) => new CedantList(cedants.Cast<Cedant>());
    }
    public class Cedant : ICloneable
    {
        public int Id { get; set; }
        public string CedantCode { get; set; }
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
