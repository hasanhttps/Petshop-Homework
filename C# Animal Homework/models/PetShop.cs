using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_.models {
    public class PetShop {
        public List<Cat> cats = new List<Cat>();
        public List<Dog> dogs = new List<Dog>();
        public List<Bird> birds = new List<Bird>();
        public List<Fish> fishes = new List<Fish>();

        public PetShop() { 
            Cat cat1 = new Cat("Tom", "Male", 1, 20, 10, 1);
            Cat cat2 = new Cat("Luna", "Female", 2, 30, 20, 10);
            Dog dog1 = new Dog("Tom", "Male", 1, 20, 10, 1);
            Dog dog2 = new Dog("Luna", "Female", 2, 30, 20, 10);
            Bird bird1 = new Bird("Tom", "Male", 1, 20, 10, 1);
            Bird bird2 = new Bird("Luna", "Female", 2, 30, 20, 10);
            Fish fish1 = new Fish("Tom", "Male", 1, 20, 10, 1);
            Fish fish2 = new Fish("Luna", "Female", 2, 30, 20, 10);

            cats.Add(cat1);
            cats.Add(cat2);
            dogs.Add(dog1);
            dogs.Add(dog2);
            birds.Add(bird1);
            birds.Add(bird2);
            fishes.Add(fish1); 
            fishes.Add(fish2);

        }

        public void RemoveByNickNameCats(string nickName) {
            foreach (var item in cats) {
                if (item.Name == nickName) cats.Remove(item);
            }
        }

        public void RemoveByNickNameDogs(string nickName) {
            foreach (var item in dogs) {
                if (item.Name == nickName) dogs.Remove(item);
            }
        }

        public void RemoveByNickNameBirds(string nickName) {
            foreach (var item in birds) {
                if (item.Name == nickName) birds.Remove(item);
            }
        }

        public void RemoveByNickNameFishes(string nickName) {
            foreach (var item in fishes) {
                if (item.Name == nickName) fishes.Remove(item);
            }
        }

        public void show() {
            Console.WriteLine("Cats\n");
            foreach (var item in cats) {
                Console.WriteLine(item);
            }
            Console.WriteLine("Dogs\n");
            foreach (var item in dogs) {
                Console.WriteLine(item);
            }
            Console.WriteLine("Birds\n");
            foreach (var item in birds) {
                Console.WriteLine(item);
            }
            Console.WriteLine("Fishes\n");
            foreach (var item in fishes) {
                Console.WriteLine(item);
            }
        }

        // ToString

        public override string ToString() {
            string retString = "PetShop\n\n";

            retString += "\nCats\n\n";
            foreach (var item in cats) {
                retString += item.Name + "\n";
            }

            retString += "\nDogs\n\n";
            foreach (var item in dogs) {
                retString += item.Name + "\n";
            }

            retString += "\nBirds\n\n"; ;
            foreach (var item in birds) {
                retString += item.Name + "\n";
            }

            retString += "\nFishes\n\n";
            foreach (var item in fishes) {
                retString += item.Name + "\n";
            }

            return retString;
        }

    }
}
