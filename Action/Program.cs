using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Salat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введте 1 число диапозона");   //узнаем диапозон калорий 
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введте 2 число диапозона");
            int b = Convert.ToInt32(Console.ReadLine());
            //---------------------------------------------------------------------------
            Springings li = new Springings();//запрос на присоединеня 
           IList<Springings> listL = li.GetIngredients();
            var q = from l in listL
                    join g in BIngredient.BIngredientList on l.BasekId equals g.Id
                    where ((l.Сalorie>=a)&&(l.Сalorie<=b))//поиск нужных эллементов в указаном дапозоне 
                    select new { ItemN = g.Name, Colorie = l.Сalorie, Price = l.Price };

            foreach (var item in q)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
           
            

            
        }
    }




























}
