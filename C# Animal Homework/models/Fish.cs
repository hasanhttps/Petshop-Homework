using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_.models {
    public class Fish : Animal {

        // Constructor

        public Fish(string nickname, string gender, int age, int price, int energy, int mealquantity) :
            base(nickname, gender, age, price, energy, mealquantity)
        {

        }

        public override void Eat() {
            Energy += 10;
            Mealquantity += 1;
            Price += 5;
        }
        public override void Sleep() {
            Energy += 10;      
        }            
        public override void Play() {
            if (Energy > 0) {
                Energy -= 3;
            }else Sleep();
        }
    }
}
