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

        public override void Eat() {
            Energy += 30;
            Mealquantity += 1;
            Price += 15;
        }
        public override void Sleep() {
            Energy += 50;      
        }            
        public override void Play() {
            if (Energy > 0) {
                Energy -= 1;
            }else Sleep();
        }
    }
}
