#include <iostream>

using namespace std;

struct Student
{
    char* name;
    private:int age;
    public:char pol;
    int course;
    char stream;
    int groupNumber;

    void SayName() {
        cout << "My name is " << name << endl;
    }

    void SetAge(int studentAge) {
        if (studentAge >= 16 && studentAge <= 25) {
            age = studentAge;         
        }
        else {
            cout << "Incorrect Age" << endl;
        }
    }
   
    int GetAge() {
        return age;
    }

   
};



//struct Dog {
//    char* name;
//    char* poroda;
//    int age;
//    bool isCrazy;
//    
//    void Info() {
//        cout << "Name : " << name << endl;
//        cout << "Poroda : " << poroda << endl;
//        cout << "Age : " << age << endl;
//        if (isCrazy) {
//            cout << "Crazy dog"<< endl;
//        }        
//    }
//
//
//};




void PrintStudentData(Student student) {
    cout << "Name : " << student.name << endl;
    cout << "Age : " << student.GetAge() << endl;
    cout << "Pol : " << student.pol << endl;
    //cout << "Course : " << student.course << endl;
    cout << "Stream : " << student.stream << endl;
    cout << "GroupNumber : " << student.groupNumber << endl;
    cout << endl << endl;
}


int main()
{
    Student Farman;
    
    Farman.SetAge(22);
   
    Farman.groupNumber = 212;
    Farman.name = new char[7]{ 'F','a','r','m','a','n','\0'};
    Farman.pol = 'M';
    Farman.stream = 'R';

    Farman.SayName();

    Student Narmina;

    Narmina.SetAge(20);
    Narmina.course = 2;
    Narmina.groupNumber = 222;
    Narmina.name = new char[8] { 'N', 'a', 'r', 'm', 'i', 'n','a','\0'};
    Narmina.pol = 'F';
    Narmina.stream = 'R';


    PrintStudentData(Farman);
    PrintStudentData(Narmina);


    //Dog Sparky;
    //Sparky.name = new char[7] { 'S', 'p', 'a', 'r', 'k', 'y', '\0'};
    //Sparky.poroda = new char[9] { 'R', 'e', 't', 'r', 'i', 'v','e','r', '\0'};
    //Sparky.age = 7;
    //Sparky.isCrazy = true;


    //Sparky.Info();

  
}


