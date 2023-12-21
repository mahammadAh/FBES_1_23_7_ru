#include <iostream>
#include <vector>
using namespace std;





class Person {
    string name;
    int age;
public:
    Person(string name , int age) : name{name},age{age}{}

    void printInfoToConsole() {
        cout << "Name : " << name << endl;
        cout << "Age : " << age << endl;
    }
};

class Car {

    class Engine {
    public:
        double l;
        int hp;
        int cylinderCount;
    };

    string brand;
    string number;
    Engine* engine;
    vector<Person*>* Passangers;
public:
    Car() {
        engine = new Engine();
        Passangers = new vector<Person*>();
    }

    void SetEngine(double l, int hp, int cylinderCount) {
        engine->l = l;
        engine->hp = hp;
        engine->cylinderCount = cylinderCount;
    }

    void SetNumber(string number) {
        this->number = number;
    }

    void SetBrand(string brand) {
        this->brand = brand;
    }

    void AddPassanger(Person* person) {
        Passangers->push_back(person);
    }

    ~Car() {
        delete engine;
        delete Passangers;
    }

};


int main()
{
    Car* mercedes = new Car();

    Person* Anvar = new Person("Anvar", 18);
    Person* Faxri = new Person("Faxri", 18);
    Person* Farman = new Person("Farman", 20);
    Person* Nazim = new Person("Nazim", 21);

    mercedes->AddPassanger(Anvar);
    mercedes->AddPassanger(Faxri);
    mercedes->AddPassanger(Farman);
    mercedes->AddPassanger(Nazim);

    // машина утиль = движок утиль 
    // машина утиль != пассажиры утиль -> пассажира = run
    delete mercedes;

    Anvar->printInfoToConsole();

    



}


