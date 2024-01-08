using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    internal class Program
    {
  
        static void Main(string[] args)
        {
            string fullName = "Иванов И.И.", email="123@mail.ru";
            int age=44;
            double progScores =40.4 , mathScores=66.5 , phyScores=39.12;

            Console.WriteLine("ФИО {0}, email {1}, Возраст {2},Баллы по программированию {3}, Баллы по математике {4}, Баллы по физике {5}",
                fullName, email, age, progScores, mathScores, phyScores);
            

            double amountScores;
            amountScores = progScores + mathScores + phyScores;
            double avergeScores;
            avergeScores= amountScores / 3;
            Console.WriteLine("Сумма балов {0}, Средний балл {1}",amountScores,avergeScores);
            Console.ReadKey ();

        }
    }
}
