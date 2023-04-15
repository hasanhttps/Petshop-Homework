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
            Energy += 20;
            Mealquantity += 1;
            Price += 10;
        }
        public override void Sleep() {
            Energy += 30;      
        }            
        public override void Play() {
            if (Energy > 0) {
                Energy -= 2;
            }else Sleep();
        }
    }
}
