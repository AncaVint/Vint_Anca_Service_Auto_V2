using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
namespace Vint_Anca_Service_Auto_V2.Models
{
    public class Programare
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string NrInmatriculare { get; set; }
        public string Client { get; set; }
        public string DataOra { get; set; }
        public string Mecanic { get; set; }


    }
}