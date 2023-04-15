using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_.models {
    public class Cat : Animal {

        // Constructor

        public Cat(string nickname, string gender, int age, int price, int energy, int mealquantity) : 
            base(nickname, gender, age, price, energy, mealquantity) { 
            
        }

        // Overrided Functions

        public override void Eat() {
            Console.WriteLine($"{Name} is eating.");
            Thread.Sleep(5000);
            if (Mealquantity % 5 == 0) {
                Age += 1;
            }
            Energy += 20;
            Mealquantity += 1;
            Price += 10;
        }
        public override void Sleep() {
            Console.WriteLine($"{Name} is sleeping.");
            Thread.Sleep(10000);
            Energy += 30;      
        }            
        public override void Play() {
            Console.WriteLine($"{Name} is playing.");
            Thread.Sleep(1000);
            if (Energy > 0) {
                Energy -= 2;
            }else Sleep();
        }
    }
}
