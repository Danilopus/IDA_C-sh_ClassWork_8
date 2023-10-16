// ClassWork template 1.2 // date: 29.09.2023

using IDA_C_sh_ClassWork_8;
using Service;
using System;
using System.Linq.Expressions;
using System.Text;


// ClassWork 08 : [C sharp: Delegates, Lambda, Events, AnonimousFunctions] 16.10.2023 --------------------------------

/* Динамические коллекции

 C#          C++
List        std::vector
LinkedList  std::list
Queue       std::queue
Stack       std::stack
Dictionary  std::map
SortedList  

*/



/* Generic - обобщенный параметризированный тип
 
public  bool F1 <T> (T t1, T t2) where T : IComparable<T>
    return t1.CompareTo(t2) > 0;

*/

namespace IDA_C_sh_ClassWork
{
    internal class Program
    {
        // Делегат - ссылка на метод
        delegate void Message();
        static Message message_obj_2 = Hello;        
        static void Hello() => Console.WriteLine("I love C# inside/outside methods");
        static public void Task_1()
        {
            Message message_obj = Hello;
            message_obj();
            message_obj_2();
        }

        //static Message lambda = () =>

        // Анонимная функция 
        delegate void Message2();       
        static Message2 mes = delegate ()
        {
            Console.WriteLine("Anonymous Method");
        };
        public static void Task_2()
        {
            mes();
        }

        // Событие
        delegate void Message_3(string msg);
        static event Message_3 Notify;
        //static Notify("notify through event");
        static void Output (string message) => Console.WriteLine(message); // Обработчик событий
        public static void Task_3()
        {
            Notify += Output;
            Notify("notify through event");
        }
        public static void Task_4()
        {
            People people_obj = new People();
            people_obj.Age = 33;
            people_obj.Age = 22;
        }
        public static void Task_5()
        {
            TrueVector<string> trueVector_str = new TrueVector<string>();
            
            
            trueVector_str.Add("Hello");
            trueVector_str.Add("World");
            trueVector_str.Add("Again");
            
            for (int i = 0; i < trueVector_str.Length(); i++)
            { Console.WriteLine(trueVector_str[i]); }

            trueVector_str.Pop();

            for (int i = 0; i < trueVector_str.Length(); i++)
            { Console.WriteLine(trueVector_str[i]); }

        }

        static void Main(string[] args)
        {
            //Task_1();
            //Task_2();
            //Task_3();    
            ///Task_4();
            Task_5();

            Console.ReadKey();
        }   

     
     

    } // class Programm
}// namespace

