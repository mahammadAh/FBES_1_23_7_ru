#include <iostream>

using namespace std;


struct Animal {
    int legCount;
    int eyesCount;
    float weight;
    const char* color;
    int age;
    int* arr = new int[10];

    Animal() {
        cout << "constructor" << endl;
    }

    Animal(int legCount, int eyesCount, float weight, const char* color, int age) {
        this->legCount = legCount;
        this->eyesCount = eyesCount;
        this->weight = weight;
        this->color = color;
        this->age = age;
    }

    void setAnimalData(int legCount, int eyesCount, float weight, const char* color, int age) {
        this->legCount = legCount;
        this->eyesCount = eyesCount;
        this->weight = weight;
        this->color = color;
        this->age = age;
    }

    void Info() {
        cout << "Leg Count : " << legCount << endl;
            cout << "Eyes Count: " << eyesCount << endl;
            cout << "Weight: " << weight << endl;
            cout << "Color: " << color << endl;
            cout << "Age : " << age << endl;
    }

    ~Animal() {
        delete[] arr;
        cout << "~destructor" << endl;
    }
};



struct DbConnect {
private:
    const char* dbLink;

public:

    DbConnect(const char* dbLink) {
        this->dbLink = dbLink;
    }

    //void SetDbLink(const char* dbLink) {
    //        this->dbLink = dbLink;
    //    }

    void GetUserData(int userId) {

        cout << "...Connection with DB " << dbLink << "..."<<endl << endl;
        switch (userId) {
        case 1:
            cout << "Name : Elnur" << endl;
            cout << "Surname : Aliyev" << endl;
            cout << "Age : 27" << endl;
            break;
        case 2:
            cout << "Name : Nazim" << endl;
            cout << "Surname : Dovlatov" << endl;
            cout << "Age : 20" << endl;
            break;
        case 3:
            cout << "Name : Javad" << endl;
            cout << "Surname : Orucov" << endl;
            cout << "Age : 18" << endl;
            break;
        }
    }
};


int main()
{

    //Animal* cat = new Animal(4, 2, 7, "grey", 3);
    //cat->Info();

    //cat->legCount=4;
    //cat->eyesCount = 2;
    //cat->weight = 7;
    //cat->age = 3;
    //cat->color = "grey";

    //DbConnect* postgreSQL = new DbConnect("https:://10.123.231.254/schema/users");
   
    //
    //postgreSQL->GetUserData(2);



    Animal* dog = new Animal();

    dog->setAnimalData(4, 2, 15, "white", 11);

    dog->Info();

    delete dog;
}

