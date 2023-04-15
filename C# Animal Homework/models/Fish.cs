using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_.models {
    public class Fish : Animal {

        // Constructor

        public Fish(string nickname, string gender, int age, int price, int energy, int mealquantity) :
            base(nickname, gender, age, price, energy, mealquantity) {

        }

        // Functions

        public override void Eat() {
            Console.WriteLine($"{Name} is eating.");
            Thread.Sleep(5000);
            if (Mealquantity % 2 == 0) {
                Age += 1;
            }
            Energy += 10;
            Mealquantity += 1;
            Price += 5;
        }
        public override void Sleep() {
            Console.WriteLine($"{Name} is sleeping.");
            Thread.Sleep(10000);
            Energy += 10;      
        }            
        public override void Play() {
            Console.WriteLine($"{Name} is playing.");
            Thread.Sleep(1000);
            if (Energy > 0) {
                Energy -= 3;
            }else Sleep();
        }
    }
}
