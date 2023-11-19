#include <iostream>
#include "Person.h"
#include "Animal.h"

using namespace std;

// Модификаторы доступа - private , public , protected

int main()
{
    Person EdwardNorton;

    char* edwardName = new char[4]{'E','d','i','\0'};
    EdwardNorton.setName(edwardName);

    const char* actorName = EdwardNorton.getName();
    actorName[2] = 'L';
    cout << "Actor Name : " << actorName <<endl;

    EdwardNorton.setBirthDate(1969, 8, 18);

    cout << EdwardNorton.getAge();

    //Animal cat;

    //

    //cat.setLegCount(4);
    //cat.calculateSpeed(20, 300);

    //cout << endl  << cat.getSpeed() << endl;

    

}





