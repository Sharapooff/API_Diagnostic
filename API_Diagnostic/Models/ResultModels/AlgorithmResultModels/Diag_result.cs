using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Diag_result<T> //модель для данных результата диагностирования 
    {
        //информация о локомотиве

        public bool ERR { get; set; } //тип
        public string ERR_Message { get; set; }
        public bool presenceFlag { get; set; }

        public List<T> Table = new List<T>();//список объектов класса Т
            
    }

    public class Result
    {
        public bool ERR { get; set; }
        public string ERR_Message { get; set; } //серия
    }
}
