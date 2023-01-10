using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Models.Tabels_Models;

namespace Models
{
    public class Report_Diagnostic_Models //модель для данных результата диагностирования 
    {
        //информация о локомотиве
        public string Tipe { get; set; } //тип
        public string Seriya { get; set; } //серия
        public string Number { get; set; } //номер
        public string Section_Name { get; set; } //имя секции                                     
        public string StringData_start { get; set; }//поля периода диагностирования
        public string StringData_end { get; set; }
        //список алгоритмов
        public string Algorithms_list { get; set; }
        public string Report_PDF_file_path { get; set; } //имя файла отчета PDF, заполняется при создании отчета, иначе пустое
        public string Excel_report_path_6_1 { get; set; }
        public bool ERR { get; set; } //флаг наличия ошибки
        public string ERR_message { get; set; } //сообщение ошибки

        //динамические объекты
        public Diag_result<Tab_1_1> Table_1_1 = new Diag_result<Tab_1_1>();
        public Diag_result<Tab_1_2> Table_1_2 = new Diag_result<Tab_1_2>();
        public Diag_result<Tab_1_3> Table_1_3 = new Diag_result<Tab_1_3>();
        public Diag_result<Tab_1_4> Table_1_4 = new Diag_result<Tab_1_4>();
        public Diag_result<Tab_1_5> Table_1_5 = new Diag_result<Tab_1_5>();
        public Diag_result<Tab_1_6> Table_1_6 = new Diag_result<Tab_1_6>();
        public Diag_result<Tab_1_7> Table_1_7 = new Diag_result<Tab_1_7>();
        public Diag_result<Tab_1_8> Table_1_8 = new Diag_result<Tab_1_8>();

        public Diag_result<Tab_2_1> Table_2_1 = new Diag_result<Tab_2_1>();
        public Diag_result<Tab_2_2> Table_2_2 = new Diag_result<Tab_2_2>();
        public Diag_result<Tab_2_3> Table_2_3 = new Diag_result<Tab_2_3>();
        public Diag_result<Tab_3_1> Table_3_1 = new Diag_result<Tab_3_1>();
        public Diag_result<Tab_4_1> Table_4_1 = new Diag_result<Tab_4_1>();
        public Diag_result<Tab_4_2> Table_4_2 = new Diag_result<Tab_4_2>();
        public Diag_result<Tab_5_1> Table_5_1 = new Diag_result<Tab_5_1>();
        public Diag_result<Tab_5_2> Table_5_2 = new Diag_result<Tab_5_2>();
        public Diag_result<Tab_5_3> Table_5_3 = new Diag_result<Tab_5_3>();
        public Diag_result<Tab_6_1> Table_6_1 = new Diag_result<Tab_6_1>();

        public List<GroupSmsModel> AlarmMessege = new List<GroupSmsModel>();

    }
}
