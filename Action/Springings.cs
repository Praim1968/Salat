using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Salat
{
    public class Springings//салат 1
    {

        public int Id { get; set; }
        public int BasekId { get; set; }
        public int Сalorie { get; set; }
        public double Price { get; set; }
        //!!!Добовленя эллеметов в колекцию
        IList<Springings> LIngredientList;

        public IList<Springings> GetIngredients()
        {
            LIngredientList = new List<Springings>()
        {
            new Springings(){  Id = 1, BasekId = 1,Сalorie = 10, Price = 1.2 },//Морковка
            new Springings(){  Id = 2, BasekId = 2,Сalorie = 17, Price = 1.4 },//Капуста
            new Springings(){  Id = 3, BasekId = 3,Сalorie = 13, Price = 1.2 },//Огорец
            new Springings(){  Id = 4, BasekId = 4,Сalorie = 16, Price = 1.2 },//Помидор
            new Springings(){  Id = 5, BasekId = 7,Сalorie = 35, Price = 1.2 },//Баклажан
            new Springings(){  Id = 6, BasekId = 9,Сalorie = 5, Price = 1.2 }//Лук
        };
            return LIngredientList;
        }
        void Order(int colorie)
        {
            var q = from ig in LIngredientList
                    where ig.Сalorie == colorie
                    select ig;

        }
    }
    



}

