using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_.models {
    public class Bird : Animal {

        // Constructor

        public Bird(string nickname, string gender, int age, int price, int energy, int mealquantity) :
            base(nickname, gender, age, price, energy, mealquantity)
        {

        }

        public override void Eat() {
            Energy += 20;
            Mealquantity += 1;
            Price += 2;
        }
        public override void Sleep() {
            Energy += 5;    
        }            
        public override void Play() {
            if (Energy > 0) {
                Energy -= 5;
            }else Sleep();
        }
    }
}
