#include <iostream>
#include <string>
#include <iomanip>
#include <fstream>
#include <vector>


//#include <ostream>
using namespace std;


class Person {
public:
    string name;
    string surname;
    int age;
    double height;
    double weight;
    Person() {};
    Person(string name, string surname, int age, double height, double weight) :
        name {name} , surname {surname} , age {age} , height {height} , weight {weight} {}
   
   
};

ostream& operator << (ostream& out, Person& person)
{
    out << person.name << endl << person.surname << endl
        << person.age << endl << person.height << endl << person.weight;
    return out;
}

istream& operator >> (istream& input, Person& person)
{
    getline(input, person.name);
    getline(input, person.surname);
    input >> person.age;
    input.clear();
    input.ignore(32767, '\n');
    input >> person.height;
    input.clear();
    input.ignore(32767, '\n');
    input >> person.weight;
    input.clear();
    input.ignore(32767, '\n');
    return input;
}


int main()
{
    //ostream _cout();
    //string data = "Hello STEP IT";

    //int value;
    //cin >> value;  // "123abs" \n
    //cout << value<<endl;

    //cin.ignore(32767,'\n');
    //cin >> value;
    //cout << value << endl;

    //cin.ignore(32767, '\n');
    //cin >> value;
    //cout << value << endl;

    //string data;

    //cin >> data;
    //getline(cin,data);
    //cout << data <<endl;


    //bool checker = true;
    //cout.setf(ios::boolalpha);
    //cout << checker << endl;
    //checker = false;
    //cout << checker << endl;
    //cout.unsetf(ios::boolalpha);
    //checker = true;
    //cout << checker << endl;

 /*   cout.setf(ios::showpos);
    int value = -10;
    cout << value << endl;*/


    //bool checker = true;
    //cout << boolalpha << checker << endl;
    //out << checker << endl;
    //cout.fill('_');
    //for (int i = 0; i < 1000; i++)
    //{  
    //    cout << setw(10) << i; 
    //    if (i % 100 == 0) cout << endl;
    //    // "_________1"
    //    // "________12"
    //    // "_______123"

    //}

    //double pi = 3.14159265359;
    //cout <<fixed << setprecision(11) <<pi << endl;

    //int value;

    //cin >> value;
    //cout << value << endl;


    //cin >> value;
    //auto result = cin.fail();
    //if (result) {
    //    cin.ignore(32767, '\n');
    //}
    //cout << value << endl;

    //cin >> value;
    //cout << value << endl;

    // cout --> ostream;
    // fout(option) --> ofstream;
   // cout << "Hello world !" << endl;


    //ofstream fout("data.txt",ios::app);

    //fout << "HELLO STEP IT !"<<endl;

    //ifstream fin("data.txt");

    //string lineFromFile;
   // fin >> lineFromFile;
    //getline(fin, lineFromFile);
    //cout << lineFromFile;


    //Person student("Nazim", "Dovlatov", 21, 183, 77);
    //ofstream fout("student.txt", ios::trunc);
    //fout << student;




    //fout << student.name << "\n" <<  student.surname << "\n" << student.age << "\n" << student.height << "\n" << student.weight;*/


 /*   ifstream fin("student.txt");
    Person student;
    getline(fin, student.name);
    getline(fin, student.surname);
    fin >> student.age;
    fin >> student.height;
    fin >> student.weight;


    cout << student.name << endl << student.surname<<endl << student.age << endl << student.height << endl << student.weight;*/



    //Person studentForWrite("Nazim", "Dovlatov", 21, 183, 77);
    //ofstream fout("student.txt", ios::trunc);
    //fout << studentForWrite;
    //
    //Person readedStudent;
    //ifstream fin("student.txt");
    //fin >> readedStudent;
    //cout << readedStudent;


    vector<Person> people;
    Person Anvar("Anvar", "Sadiq", 18, 183, 80);
    Person Nazim("Nazim", "Dovlatov", 21, 183, 77);
    Person David("David", "Sladkov", 18, 185, 95);
    Person Alena("Alena", "Vishnevetskaya", 19, 164, 50);
    Person Fuad("Fuad", "Shukurzade", 26, 174, 79);


    people.push_back(Anvar);
    people.push_back(Nazim);
    people.push_back(David);
    people.push_back(Alena);
    people.push_back(Fuad);


    ofstream fout("people.txt", ios::trunc);
    for (int i = 0; i < people.size(); i++) {
        fout << people.at(i);
        if (i < people.size() - 1) fout <<endl;
    }

 /*   for (auto person : people) {
        fout << person;
    }*/

    ifstream fin("people.txt");


    vector<Person> readedPeople;
    while (!fin.eof()) {

        Person readedPerson;
        fin >> readedPerson;
        readedPeople.push_back(readedPerson);
       
    }

    for (auto person : readedPeople) {
        cout << person <<endl;
    }

    fin.close();

}


