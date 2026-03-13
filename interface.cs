using System; 

// define the interface
public interface IAnimal{
    void makeSound();
}

// creating a class to implement the interface
public class Dog: IAnimal{
    public void makeSound() {
        Console.WriteLine("Woof!");
    }
}
public class Cat: IAnimal{
    public void makeSound() {
        Console.WriteLine("Meow!");
    }
}

public class Program{
    public static void makeAnimalSound(IAnimal animal){
        animal.makeSound();
    }
    
    public static void Main(){
        // create instances for dog and cat
        Dog d = new Dog();
        Cat c = new Cat();
        
        // pass the objects into the method
        makeAnimalSound(d);
        makeAnimalSound(c);
    }
}