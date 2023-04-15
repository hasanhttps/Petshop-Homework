using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_.models {
    public class Bird : Animal {

        // Constructor

        public Bird(string nickname, string gender, int age, int price, int energy, int mealquantity) :
            base(nickname, gender, age, price, energy, mealquantity) {

        }

        // Functions

        public override void Eat() {
            Console.WriteLine($"{Name} is eating.");
            Thread.Sleep(5000);
            if (Mealquantity % 3 == 0) {
                Age += 1;
            }
            Energy += 20;
            Mealquantity += 1;
            Price += 2;
        }
        public override void Sleep() {
            Console.WriteLine($"{Name} is sleeping.");
            Thread.Sleep(10000);
            Energy += 5;    
        }            
        public override void Play() {
            Console.WriteLine($"{Name} is playing.");
            Thread.Sleep(1000);
            if (Energy > 0) {
                Energy -= 5;
            }else Sleep();
        }
    }
}
