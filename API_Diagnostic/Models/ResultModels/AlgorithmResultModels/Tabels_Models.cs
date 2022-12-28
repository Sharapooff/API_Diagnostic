using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Tabels_Models //класс содержащий модели (классы) для формирования отчетов (PDF)
    {
        public class Tab_1_1
        {
            public string Date_Time { get; set; }
            public string PCM { get; set; }

            public string A1 { get; set; }
            public string A2 { get; set; }
            public string A3 { get; set; }
            public string A4 { get; set; }
            public string A5 { get; set; }
            public string A6 { get; set; }
            public string A7 { get; set; }
            public string A8 { get; set; }

            public string B1 { get; set; }
            public string B2 { get; set; }
            public string B3 { get; set; }
            public string B4 { get; set; }
            public string B5 { get; set; }
            public string B6 { get; set; }
            public string B7 { get; set; }
            public string B8 { get; set; }

            public string SMS { get; set; }
            public List<string> Coef { get; set; }


            public Tab_1_1()
            { }

            public Tab_1_1(string _Date_Time, string _PCM, string _A1, string _A2, string _A3, string _A4, string _A5, string _A6, string _A7, string _A8, string _B1, string _B2, string _B3, string _B4, string _B5, string _B6, string _B7, string _B8)
            {

                Date_Time = _Date_Time;
                PCM = _PCM;

                A1 = _A1;
                A2 = _A2;
                A3 = _A3;
                A4 = _A4;
                A5 = _A5;
                A6 = _A6;
                A7 = _A7;
                A8 = _A8;

                B1 = _B1;
                B2 = _B2;
                B3 = _B3;
                B4 = _B4;
                B5 = _B5;
                B6 = _B6;
                B7 = _B7;
                B8 = _B8;

                this.SMS = "";
            }

            public Tab_1_1(string _Date_Time, string SMS)
            {
                this.Date_Time = _Date_Time;
                this.SMS = SMS;
            }

            public Tab_1_1(string _PCM, List<string> Coef)
            {
                this.PCM = _PCM;
                this.Coef = Coef;
                this.SMS = "";
            }
        }
        public class Tab_1_2
        {
            public string Date_Time { get; set; }
            public string Message { get; set; }
            public string Temperature { get; set; }

            public Tab_1_2()
            { }

            public Tab_1_2(string _Date_Time, string _Message, string _Temperature)
            {
                Date_Time = _Date_Time;
                Message = _Message;
                Temperature = _Temperature;
            }

        }
        public class Tab_1_3
        {
            public string Date_Time { get; set; }            
            public string sms { get; set; }
            public string T_vod { get; set; }

            public Tab_1_3()
            { }

            public Tab_1_3(string _Date_Time, string _sms, string _T_vod)
            {
                Date_Time = _Date_Time;
                sms = _sms;
                T_vod = _T_vod;
            }
        }
        public class Tab_1_4
        {
            public string Date_Time { get; set; }
            public string sms { get; set; }
            public string meaning { get; set; }

            public Tab_1_4()
            { }

            public Tab_1_4(string _Date_Time, string _sms, string _meaning)
            {
                Date_Time = _Date_Time;
                sms = _sms;
                meaning = _meaning;
            }
        }
        public class Tab_1_5
        {
            public string Date_Time { get; set; }
            public string sms { get; set; }

            public Tab_1_5()
            { }

            public Tab_1_5(string _Date_Time, string _Sms)
            {
                Date_Time = _Date_Time;
                sms = _Sms;
            }
        }
        public class Tab_1_6
        {
            public List<Tab_1_6_1> Tab_1_6_1 { get; set; }
            public List<Tab_1_6_2> Tab_1_6_2 { get; set; }
            public List<Tab_1_6_3> Tab_1_6_3 { get; set; }
            public List<Tab_1_6_4> Tab_1_6_4 { get; set; }
            public Tab_1_6()
            {
                Tab_1_6_1 = new List<Tab_1_6_1>();
                Tab_1_6_2 = new List<Tab_1_6_2>();
                Tab_1_6_3 = new List<Tab_1_6_3>();
                Tab_1_6_4 = new List<Tab_1_6_4>();
            }

            public Tab_1_6(List<Tab_1_6_1> _t_1_6_1, List<Tab_1_6_2> _t_1_6_2, List<Tab_1_6_3> _t_1_6_3, List<Tab_1_6_4> _t_1_6_4)
            {
                Tab_1_6_1 = _t_1_6_1;
                Tab_1_6_2 = _t_1_6_2;
                Tab_1_6_3 = _t_1_6_3;
                Tab_1_6_4 = _t_1_6_4;
            }
        }
        public class Tab_1_6_1
        {
            public string Date_Time { get; set; }
            public string Pnadd { get; set; }
            public string sms { get; set; }

            public Tab_1_6_1()
            { }

            public Tab_1_6_1(string _Date_Time, string _Pnadd, string _sms)
            {
                Date_Time = _Date_Time;
                Pnadd = _Pnadd;
                sms = _sms;
            }

        }
        public class Tab_1_6_2
        {
            public string Date_Time { get; set; }
            public string PCM { get; set; }
            public string TLC { get; set; }
            public string sms { get; set; }

            public Tab_1_6_2()
            { }

            public Tab_1_6_2(string _Date_Time, string _PCM, string _TLC, string _sms)
            {
                Date_Time = _Date_Time;
                PCM = _PCM;
                TLC = _TLC;
                sms = _sms;
            }

        }
        public class Tab_1_6_3
        {
            public string Date_Time { get; set; }
            public string PCM { get; set; }
            public string TLC { get; set; }
            public string sms { get; set; }

            public Tab_1_6_3()
            { }

            public Tab_1_6_3(string _Date_Time, string _PCM, string _TLC, string _sms)
            {
                Date_Time = _Date_Time;
                PCM = _PCM;
                TLC = _TLC;
                sms = _sms;
            }

        }
        public class Tab_1_6_4
        {
            public string Date_Time { get; set; }
            public string sms { get; set; }

            public Tab_1_6_4()
            { }

            public Tab_1_6_4(string _Date_Time, string _sms)
            {
                Date_Time = _Date_Time;
                sms = _sms;
            }

        }

        public class Tab_1_7
        {
            public string Date_Time { get; set; }
            public string Temp { get; set; }
            public string K { get; set; }
            // public string E { get; set; }
            public string C { get; set; }
            public string C_ab { get; set; }

            public Tab_1_7()
            { }

            public Tab_1_7(string _Date_Time, string _Temp, string _K, string _C, string _C_ab)
            {
                Date_Time = _Date_Time;
                Temp = _Temp;
                K = _K;
                C = _C;
                C_ab = _C_ab;
                //E_proc = _E_proc;
            }
        }
        public class Tab_1_8
        {
            public string Date_Time { get; set; }
            public string Temp { get; set; }
            public string K { get; set; }
            // public string E { get; set; }
            public string C { get; set; }
            public string C_ab { get; set; }

            public Tab_1_8()
            { }

            public Tab_1_8(string _Date_Time, string _Temp, string _K, string _C, string _C_ab)
            {
                Date_Time = _Date_Time;
                Temp = _Temp;
                K = _K;
                C = _C;
                C_ab = _C_ab;
                //E_proc = _E_proc;
            }
        }

        public class Tab_2_1
        {
            public string Date_Time { get; set; }
            public string PCM { get; set; }
            public string Power { get; set; }
            public string Allowable_power { get; set; }
            public string Message { get; set; }

            public Tab_2_1()
            { }

            public Tab_2_1(string _Date_Time, string _PCM, string _Power, string _Allowable_power, string _Message)
            {
                Date_Time = _Date_Time;
                PCM = _PCM;
                Power = _Power;
                Allowable_power = _Allowable_power;
                Message = _Message;
            }

        }
        public class Tab_2_2
        {
            public string Date_Time { get; set; }
            public string PCM { get; set; }
            public string Oil_pressure { get; set; }
            public string Oil_pressure_drop { get; set; }
            public string Oil_temperature { get; set; }

            public Tab_2_2()
            { }

            public Tab_2_2(string _Date_Time, string _PCM, string _Oil_pressure, string _Oil_pressure_drop, string _Oil_temperature)
            {
                Date_Time = _Date_Time;
                PCM = _PCM;
                Oil_pressure = _Oil_pressure;
                Oil_pressure_drop = _Oil_pressure_drop;
                Oil_temperature = _Oil_temperature;
            }

        }
        public class Tab_2_3
        {
            public string Date_Time { get; set; }
            public string PCM { get; set; }

            public string A_sr { get; set; }
            public string A1 { get; set; }
            public string A1_d { get; set; }
            public string A2 { get; set; }
            public string A2_d { get; set; }
            public string A3 { get; set; }
            public string A3_d { get; set; }
            public string A4 { get; set; }
            public string A4_d { get; set; }
            public string A5 { get; set; }
            public string A5_d { get; set; }
            public string A6 { get; set; }
            public string A6_d { get; set; }
            public string A7 { get; set; }
            public string A7_d { get; set; }
            public string A8 { get; set; }
            public string A8_d { get; set; }

            public string B_sr { get; set; }
            public string B1 { get; set; }
            public string B1_d { get; set; }
            public string B2 { get; set; }
            public string B2_d { get; set; }
            public string B3 { get; set; }
            public string B3_d { get; set; }
            public string B4 { get; set; }
            public string B4_d { get; set; }
            public string B5 { get; set; }
            public string B5_d { get; set; }
            public string B6 { get; set; }
            public string B6_d { get; set; }
            public string B7 { get; set; }
            public string B7_d { get; set; }
            public string B8 { get; set; }
            public string B8_d { get; set; }

            public string Average { get; set; }

            public Tab_2_3()
            { }

            public Tab_2_3(string _Date_Time, string _PCM, string _A_sr, string _A1, string _A1_d, string _A2, string _A2_d, string _A3, string _A3_d, string _A4, string _A4_d, string _A5, string _A5_d, string _A6, string _A6_d, string _A7, string _A7_d, string _A8, string _A8_d, string _B_sr, string _B1, string _B1_d, string _B2, string _B2_d, string _B3, string _B3_d, string _B4, string _B4_d, string _B5, string _B5_d, string _B6, string _B6_d, string _B7, string _B7_d, string _B8, string _B8_d, string _Average)
            {
                Date_Time = _Date_Time;
                PCM = _PCM;

                A_sr = _A_sr;
                A1 = _A1;
                A1_d = _A1_d;
                A2 = _A2;
                A2_d = _A2_d;
                A3 = _A3;
                A3_d = _A3_d;
                A4 = _A4;
                A4_d = _A4_d;
                A5 = _A5;
                A5_d = _A5_d;
                A6 = _A6;
                A6_d = _A6_d;
                A7 = _A7;
                A7_d = _A7_d;
                A8 = _A8;
                A8_d = _A8_d;

                B_sr = _B_sr;
                B1 = _B1;
                B1_d = _B1_d;
                B2 = _B2;
                B2_d = _B2_d;
                B3 = _B3;
                B3_d = _B3_d;
                B4 = _B4;
                B4_d = _B4_d;
                B5 = _B5;
                B5_d = _B5_d;
                B6 = _B6;
                B6_d = _B6_d;
                B7 = _B7;
                B7_d = _B7_d;
                B8 = _B8;
                B8_d = _B8_d;

                Average = _Average;

            }

        }

        //////////////////////////////

        public class Tab_3_1
        {
            public List<Tab_3_1_1> Tab_3_1_1 { get; set; }
            public List<Tab_3_1_2> Tab_3_1_2 { get; set; }
            public Tab_3_1()
            {
                Tab_3_1_1 = new List<Tab_3_1_1>();
                Tab_3_1_2 = new List<Tab_3_1_2>();
            }

            public Tab_3_1(List<Tab_3_1_1> _t_3_1_1, List<Tab_3_1_2> _t_3_1_2)
            {
                Tab_3_1_1 = _t_3_1_1;
                Tab_3_1_2 = _t_3_1_2;
            }
        }
        public class Tab_3_1_1
        {
            public string Date_Time { get; set; }
            public string PCM { get; set; }
            public string Power { get; set; }
            public string d_T_water_out_diz { get; set; }
            public string d_T_water_cold_loop { get; set; }
            public string T_environment { get; set; }
            public string Period { get; set; }

            public Tab_3_1_1()
            { }

            public Tab_3_1_1(string _Date_Time, string _PCM, string _Power, string _d_T_water_out_diz, string _d_T_water_cold_loop, string _T_environment, string _Period)
            {
                Date_Time = _Date_Time;
                PCM = _PCM;
                Power = _Power;
                d_T_water_out_diz = _d_T_water_out_diz;
                d_T_water_cold_loop = _d_T_water_cold_loop;
                T_environment = _T_environment;
                Period = _Period;
            }

        }
        public class Tab_3_1_2
        {
            public string Date_Time { get; set; }
            public string PCM { get; set; }
            public string Power { get; set; }
            public string d_T_water_out_diz { get; set; }
            public string d_T_water_cold_loop { get; set; }
            public string T_environment { get; set; }
            public string Period { get; set; }

            public Tab_3_1_2()
            { }

            public Tab_3_1_2(string _Date_Time, string _PCM, string _Power, string _d_T_water_out_diz, string _d_T_water_cold_loop, string _T_environment, string _Period)
            {
                Date_Time = _Date_Time;
                PCM = _PCM;
                Power = _Power;
                d_T_water_out_diz = _d_T_water_out_diz;
                d_T_water_cold_loop = _d_T_water_cold_loop;
                T_environment = _T_environment;
                Period = _Period;
            }

        }


        //////////////////////////////

        public class Tab_4_1
        {
            public string Date_Time { get; set; }
            public string TNVD { get; set; }
            public string Diesel_speed { get; set; }

            public Tab_4_1()
            { }

            public Tab_4_1(string _Date_Time, string _TNVD, string _Diesel_speed)
            {
                Date_Time = _Date_Time;
                TNVD = _TNVD;
                Diesel_speed = _Diesel_speed;
            }

        }
        public class Tab_4_2
        {
            public string Date_Time { get; set; }
            public string PCM { get; set; }
            public string Fuel_consumption { get; set; }
            public string Diesel_power { get; set; }
            public string Time { get; set; }

            public Tab_4_2()
            { }

            public Tab_4_2(string _Date_Time, string _PCM, string _Fuel_consumption, string _Diesel_power, string _Time)
            {
                Date_Time = _Date_Time;
                PCM = _PCM;
                Fuel_consumption = _Fuel_consumption;
                Diesel_power = _Diesel_power;
                Time = _Time;
            }

        }

        public class Tab_5_1
        {
            public List<Tab_5_1_1> Tab_5_1_1 { get; set; }
            public List<Tab_5_1_2> Tab_5_1_2 { get; set; }
            public Tab_5_1()
            {
                Tab_5_1_1 = new List<Tab_5_1_1>();
                Tab_5_1_2 = new List<Tab_5_1_2>();
            }

            public Tab_5_1(List<Tab_5_1_1> _t_5_1_1, List<Tab_5_1_2> _t_5_1_2)
            {
                Tab_5_1_1 = _t_5_1_1;
                Tab_5_1_2 = _t_5_1_2;
            }
        }

        public class Tab_5_1_1
        {
            public string Date_Time { get; set; }
            public string PCM { get; set; }
            public string I1 { get; set; }
            public string I2 { get; set; }
            public string I3 { get; set; }
            public string I4 { get; set; }
            public string I5 { get; set; }
            public string I6 { get; set; }

            public Tab_5_1_1()
            { }

            public Tab_5_1_1(string _Date_Time, string _PCM, string _I1, string _I2, string _I3, string _I4, string _I5, string _I6)
            {
                Date_Time = _Date_Time;
                PCM = _PCM;
                I1 = _I1;
                I2 = _I2;
                I3 = _I3;
                I4 = _I4;
                I5 = _I5;
                I6 = _I6;
            }

        }
        public class Tab_5_1_2
        {
            public string Date_Time { get; set; }
            public string PCM { get; set; }
            public string U { get; set; }

            public Tab_5_1_2()
            { }

            public Tab_5_1_2(string _Date_Time, string _PCM, string _U)
            {
                Date_Time = _Date_Time;
                PCM = _PCM;
                U = _U;
            }

        }
        public class Tab_5_2
        {
            public string Date_Time { get; set; }
            public string PCM { get; set; }
            public string Accsel_1 { get; set; }
            public string Accsel_2 { get; set; }
            public string Accsel_3 { get; set; }
            public string Accsel_4 { get; set; }
            public string Accsel_5 { get; set; }
            public string Accsel_6 { get; set; }

            public Tab_5_2()
            { }

            public Tab_5_2(string _Date_Time, string _PCM, string _Accsel_1, string _Accsel_2, string _Accsel_3, string _Accsel_4, string _Accsel_5, string _Accsel_6)
            {
                Date_Time = _Date_Time;
                PCM = _PCM;
                Accsel_1 = _Accsel_1;
                Accsel_2 = _Accsel_2;
                Accsel_3 = _Accsel_3;
                Accsel_4 = _Accsel_4;
                Accsel_5 = _Accsel_5;
                Accsel_6 = _Accsel_6;
            }

        }

        public class Tab_5_3
        {
            public List<Tab_5_3_1> Tab_5_3_1 { get; set; }
            public List<Tab_5_3_2> Tab_5_3_2 { get; set; }
            public Tab_5_3()
            {
                Tab_5_3_1 = new List<Tab_5_3_1>();
                Tab_5_3_2 = new List<Tab_5_3_2>();
            }

            public Tab_5_3(List<Tab_5_3_1> _t_5_3_1, List<Tab_5_3_2> _t_5_3_2)
            {
                Tab_5_3_1 = _t_5_3_1;
                Tab_5_3_2 = _t_5_3_2;
            }
        }

        public class Tab_5_3_1
        {
            public string Date_Time { get; set; }
            public string Distribution { get; set; }

            public Tab_5_3_1()
            { }

            public Tab_5_3_1(string _Date_Time, string _Distribution)
            {
                Date_Time = _Date_Time;
                Distribution = _Distribution;
            }
        }
        public class Tab_5_3_2
        {
            public string Date_Time { get; set; }
            public string Distribution { get; set; }

            public Tab_5_3_2()
            { }

            public Tab_5_3_2(string _Date_Time, string _Distribution)
            {
                Date_Time = _Date_Time;
                Distribution = _Distribution;
            }
        }

        public class Tab_6_1
        {
            public string Date_Time { get; set; }
            public string Temp { get; set; }
            public string R { get; set; }
            public string E { get; set; }
            // public string C { get; set; }
            public string C_nom { get; set; }
            // public string E_proc { get; set; }

            public Tab_6_1()
            { }

            public Tab_6_1(string _Date_Time, string _R, string _C_nom, string _E, string _Temp)
            {
                Date_Time = _Date_Time;
                C_nom = _C_nom;
                R = _R;
                E = _E;
                Temp = _Temp;
            }
        }
                
        public class GroupSmsModel //модель для сгруппированных тревожных сообщений с датами их регистрации
        {
            public string Message { get; set; } //текст сообщения
            public string Mess_Type { get; set; }  //тип сообщения
            public int Mess_Count { get; set; } //количество повторений
            public List<DateTime> Mess_Dates { get; set; } //даты, когда сообщение фиксировалось

            public GroupSmsModel() //конструктор по умолчанию
            { }

            public GroupSmsModel(string _message, string _type, int _count, List<DateTime> _dates) //конструктор с параметрами
            {
                this.Message = _message; //устанавливаем значения полей в зависимости от параметров
                this.Mess_Type = _type;
                this.Mess_Count = _count;
                this.Mess_Dates = _dates;
            }
        }

    }
}
