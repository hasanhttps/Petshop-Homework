using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_.models {
    public abstract class Animal {

        // Private Variables

        private string nickname, gender;
        private int age, energy, price, mealquantity;

        // Constructor

        public Animal(string nickname, string gender, int age, int price, int energy, int mealquantity) { 
            Name = nickname;
            Gender = gender;
            Age = age;
            Price = price;
            Energy = energy;
            Mealquantity = mealquantity;
        } 

        // Properties

        public string Name { get { return nickname; } set {
                try{
                    if (value.Length >= 3) nickname = value;
                    else throw new Exception("Name can't be lower than 3 character!");
                }catch(Exception e) {
                    Console.WriteLine(e.Message);
                }
            } 
        }
        public string Gender { get { return gender; } set { gender = value; } }
        public int Age { get { return age; } set { age = value; } }
        public int Energy { get { return energy; } set { energy = value; } }
        public int Price { get { return price; } set { price = value; } }
        public int Mealquantity { get {  return mealquantity; } set {  mealquantity = value; } }


        // Abstract Functions

        public abstract void Eat();
        public abstract void Sleep();
        public abstract void Play();

        // ToString

        public override string ToString() {
            return $"Nickname : {Name}\nGender : {Gender}\nAge : {Age}\nPrice : {Price}\nEnergy : {Mealquantity}\n";
        }

    }
}
