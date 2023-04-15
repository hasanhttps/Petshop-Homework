using Animal_.models;

namespace Animal_ {
    internal class Program {
        static void Main() {
            PetShop petShop = new PetShop();
            while (true) {
                Console.Clear();
                Console.WriteLine(petShop);

                Console.Write("Please enter animal type (Cat, Bird, Fish, Dog) : ");
                string animalType = Console.ReadLine();
                dynamic animal = null;

                if (animalType == "Cat" || animalType == "Bird" || animalType == "Fish" || animalType == "Dog"){
                    Console.Write("Please enter animal nickname : ");
                    string nickname = Console.ReadLine();

                    if (animalType == "Cat") animal = petShop.ReturnByNickNameCat(nickname);
                    else if (animalType == "Bird") animal = petShop.ReturnByNickNameBird(nickname);
                    else if (animalType == "Fish") animal = petShop.ReturnByNickNameFish(nickname);
                    else if (animalType == "Dog") animal = petShop.ReturnByNickNameDog(nickname);
                }
                else {
                    Console.WriteLine("Please enter valid Animal type!");
                    Thread.Sleep(5000);
                    continue;
                }
                bool status = true;

                while (status){
                    Console.Clear();
                    Console.WriteLine(animal);
                    Console.Write("1) Eat\n2) Sleep\n3) Play\n4) Exit\n");
                    Console.Write("Please enter the choose : ");
                    int choose = Convert.ToInt32(Console.ReadLine());

                    if (choose == 1) {
                        animal!.Eat();
                    }
                    else if (choose == 2){
                        animal!.Sleep();
                    }
                    else if (choose == 3) {
                        animal!.Play();
                    }
                    else if (choose == 4) {
                        status = false;
                    }


                }
            }
        }
    }
}