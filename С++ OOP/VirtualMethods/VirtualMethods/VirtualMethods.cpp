#include <iostream>
#include <vector>
#include <time.h>
#include <stdlib.h>

using namespace std;

// abstract class
class Animal {
    string name;
    // VirtualTable* _ptr
public:

    void setName(string name) {
        this->name = name;
    }

    void printName() {
        cout << name << endl;
    }
    
     //Virtual Method
  /*   virtual void say() {
        cout << "Animal say ???" << endl;
    }*/

    // Pure Virtual Method
     virtual void say() = 0;

   /* virtual ~Animal() {
         cout << "Animal Destructor" << endl;
     };*/

    // Pure Virtual Destrcutor
    //virtual ~Animal() = 0 {};
};


class Cat : public Animal {
public:
  /*  void say() override  {

        cout << "Cat say meow" << endl;
    }*/

    void Kuss() {
        cout << "Kuss" << endl;
    }

    ~Cat() {
        cout << "Cat Destructor " << endl;
    }
};


class Lion final : public Cat {
public:
  /*  void say() {
        cout << "Kuss" << endl;
    }*/
};


class Dog : public Animal {
public:
    void say()   {
        cout << "Dog say woof" << endl;
    }

    void printName() {
        cout << "Sobaka" << endl;
    }

    ~Dog() {
        cout << "Dog Destructor " << endl;
    }

};

void print(int x) {
    cout << x;
}

void print(double x) {
    cout << x;
}


void printAnimalData(Animal* animal) {
    animal->say();
}

int main()
{
    //Animal* animal = new Animal();
    //cout << sizeof(*animal) << endl;
    //animal->setName("Teador");
    Cat* cat =  new Cat();
    //cout << sizeof(*cat) << endl;
    //cat->setName("Markiz");
    Dog* dog = new Dog();
    //cout << sizeof(*dog) << endl;
    //dog->setName("Muxtar");



    //animal->printName();
    //animal->say();
    //cout << endl;
    //cat->printName();
    //cat->say();
    //cout << endl;
    //dog->printName();
    //dog->say();


  //  Animal& animal1 = *cat;
    //Animal* animal2 = cat;


    vector<Animal*> animals;
    animals.push_back(dog);
    animals.push_back(cat);

    
    srand(time(NULL));
    animals[rand() % 2]->say();
   
    //for (auto animal : animals) {
    //    animal->printName();
    //    animal->say();
    //}


    //((Cat&)animal1).say();

    //print(3);
    //print(5.0);



    Cat* cat = new Cat();
    cat->setName("Markiz");
    cat->say();
    Dog* dog = new Dog();
    dog->setName("Muxtar");

   // delete cat;

    Animal* animal2 = cat;
    delete animal2;

}
