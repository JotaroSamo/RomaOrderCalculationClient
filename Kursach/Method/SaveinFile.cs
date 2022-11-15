using Kursach.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Kursach.Method
{
    internal class SaveinFile
    {
        public  string Wrtite(string json)
        {
            Doc doc= JsonSerializer.Deserialize<Doc>(json);

            string[] text = new string[6] {"Стоимость грузоперевозки из города " + doc.CityFrom + " в город " + doc.CityTo + " c километражом в " + doc.km + " км состоит из нескольких пунктов:",
             "1. Зарплата водителю, которая расчитывается от километража-0,2 руб на километр. Это составит " + doc.ZP + " руб. ",
             "2.Надбавка за товар "+doc.Price+"руб"
             ,
             "3. Расход топлива в среднем 10 лиров на 100 километров при расстоянии в " + doc.km + " км и стоимости одного литра топлива 2,80 руб. Затраты на топливо составят: " + doc.SumToplivo + " руб.",
            "4. Процент логистической фирме от общей стоимости составляет 30% в денежном эквивалентте это " + doc.ProcentFirm + " руб.",
             "Таким образом общая сумма составляет " + doc.Sum + " руб."};  
   
            try
            {
                string path = @"C:\Полный отчёт"+ ".txt";

                
                using (StreamWriter writer = new StreamWriter(path, false))
                {

                    for (int i = 0; i < 6; i++)
                    {
                        writer.WriteLine(text[i]);
                    }
                   
                   
                    return path;
                }
               
            }
            catch (Exception e)
            {
                return "ERROR";
                Console.WriteLine(e.Message);
            }


        }
    }
}
