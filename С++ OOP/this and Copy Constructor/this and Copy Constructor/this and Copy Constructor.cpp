#include <iostream>

using namespace std;

class City {
    char name[20];
    float sqr;

public:
    City() : sqr(){

    }

    City(const char* name, float sqr) : sqr() {
        strcpy_s(this->name, 20, name);
    }

    City(const City& city) : sqr{ city.sqr } {
        strcpy_s(this->name, 20, city.name);
        cout << "Copy Constructor" << endl;
    }

    void setName(const char* name) {
        strcpy_s(this->name, 20, name);
    }

    void setSqr(float sqr) {
        this->sqr = sqr;
    }

   const char* getName() {
        return name;
    }

    float getSqr() {
        return sqr;
    }
};

int main()
{
    City AzerbaijanCapital("Baku", 2140); // char float

    City NigeriaCapital("Abudja", 1476); // char float

    City BanqladeshCapital("Dakka", 306); // char float



    City bestCapital{ AzerbaijanCapital };


    cout << " City Name : "<<bestCapital.getName() << endl;

    cout << " City Sqr : " << bestCapital.getSqr() << endl;

    
    
        
       


}


