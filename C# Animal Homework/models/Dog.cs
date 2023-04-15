using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_.models {
    public class Dog : Animal {

        // Constructor

        public Dog(string nickname, string gender, int age, int price, int energy, int mealquantity) :
            base(nickname, gender, age, price, energy, mealquantity) {

        }

        // Functions

        public override void Eat() {
            Console.WriteLine($"{Name} is eating.");
            Thread.Sleep(5000);
            if (Mealquantity % 10 == 0) {
                Age += 1;
            }
            Energy += 30;
            Mealquantity += 1;
            Price += 15;
        }
        public override void Sleep() {
            Console.WriteLine($"{Name} is sleaping.");
            Thread.Sleep(10000);
            Energy += 50;      
        }            
        public override void Play() {
            Console.WriteLine($"{Name} is playing.");
            Thread.Sleep(1000);
            if (Energy > 0) {
                Energy -= 1;
            }else Sleep();
        }
    }
}
