using System;
using System.Collections.Generic;
using System.Text;

namespace Salat
{
   public  class BIngredient
    {
        public string Name { get; set; }
        //public string Сalorie { get; set; }
        public int Id { get; set; }
        // public double Price { get; set; }

        public static IList<BIngredient> BIngredientList = new List<BIngredient>()
        {
            new BIngredient(){ Name = "Морковка", Id = 1 },
            new BIngredient(){ Name = "Капуста", Id = 2 },
            new BIngredient(){ Name = "Огурец", Id = 3 },
            new BIngredient(){ Name = "Помдор", Id = 4 },
            new BIngredient(){ Name = "Перец", Id = 5 },
            new BIngredient(){ Name = "Брокколи", Id = 6 },
            new BIngredient(){ Name = "Баклажан", Id = 7 },
            new BIngredient(){ Name = "Бурак", Id = 8 },
            new BIngredient(){ Name = "Лук", Id = 9 },
            new BIngredient(){ Name = "Кабочки", Id = 10 },
            new BIngredient(){ Name = "Чеснок", Id = 11 },
            new BIngredient(){ Name = "Тыква", Id = 12 }
        };

        
    }
}
