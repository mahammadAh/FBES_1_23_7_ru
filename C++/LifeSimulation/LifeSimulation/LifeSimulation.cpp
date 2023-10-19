#include <iostream>
#include <stdlib.h>
#include <time.h>
#include<chrono> 
#include<thread>


using namespace std;

struct Human {
    char* name;
    int age;
    int ilnessLevel;
    bool isAlive;
};


void fillHumanData(Human &human) {
    int nameSize = 5 + rand() % 5;
    human.name = new char[nameSize+1];

    for (int i = 0; i < nameSize; i++) {
        if (i == 0) {
            human.name[i] = 65 + rand() % 25;
        }
        else {
            human.name[i] = 97 + rand() % 25;
        }
    }
    human.name[nameSize] = '\0';

    human.age = 10 + rand() % 20;
    human.ilnessLevel = 0 + rand() % 10;
    human.isAlive;
}

void printPeopleData(Human people[], int peopleCount) {
    for (int i = 0; i < peopleCount; i++) {
        cout << "Name : " << people[i].name << endl;
        cout << "Age : " << people[i].age << endl;
        cout << "Ilness Level : " << people[i].ilnessLevel << endl;
        cout <<"is Alive : " << ( people[i].isAlive ? "Alive" : "DEAD" )<< endl;
        cout << endl << endl;
    }
   
    
}

void live(Human people[], int peopleCount) {
    for (int i = 0; i < peopleCount; i++) {
        if (people[i].isAlive) {
            people[i].age++;
            if ((rand() % 10) == 6) {
                people[i].ilnessLevel++;
            }
        }
    }
}

void CheckDead(Human people[], int peopleCount) {
    for (int i = 0; i < peopleCount; i++) {
        if (people[i].ilnessLevel ==10) {
            people[i].isAlive = false;
        }
    }
}

int main()
{
    srand(time(NULL));
    int const peopleCount = 5;
    Human people[peopleCount];


    for (int i = 0; i < peopleCount; i++) {
        fillHumanData(people[i]);
    }

    while (true) {
        live(people, peopleCount);
        std::this_thread::sleep_for(std::chrono::milliseconds(1000));
        system("cls");
        CheckDead(people, peopleCount);
        printPeopleData(people, peopleCount);
    }
   

}
