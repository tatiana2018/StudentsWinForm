using LinqToDB.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class student
    {
        [PrimaryKey, Identity]
        public int id { get; set; }
        public string nid { get; set; }
        public string name { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public byte[] image { get; set; }

    }
}
