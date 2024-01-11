using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
namespace Vint_Anca_Service_Auto_V2.Models
{
    public class Mecanic
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Telefon { get; set; }

    }
}