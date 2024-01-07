#include <iostream>
#include <format>

using namespace std;

enum Pol {
	Male,
	Female
};



class Person {
private:
	static int createdPerson;
public:
	int age;
	string name;
protected:
	Pol pol;
public:
	Person(int age, string name, Pol pol) : age{ age }, name{ name }, pol{pol} {
		cout << "Person Constructor "<<endl;
		createdPerson++;
	}


	string info() {
		string result = format("Name : {}\nAge : {}\nPol : {}", name, age,pol == Male ? "Male" : "Female");
		return result;
	}

	int getCreatedPersonCount() {
		return createdPerson;
	}

	~Person() {
		cout << "Person Destructor " << endl;
	}

};


int Person::createdPerson {0};

class Student : public Person {
private:
	//int age;
	//string name;
	//Pol pol;
	double avScore;
	int startYear;
public:
	Student(int age, string name, Pol pol, double avScore, int startYear) :
		avScore{ avScore }, startYear{ startYear },Person(age, name,pol) {

		cout << "Student Constructor "<<endl;
	}
	void setStudentInfo(int age, string name, Pol pol, double avScore, int startYear) {
		this->age = age;
		this->name = name;
		this->pol = pol;
		this->avScore = avScore;
		this->startYear = startYear;
	
	}

	~Student() {
		cout << "Student Destructor " << endl;
	}
};




class Teacher : public Person{
public:
	//int age;
	//string name;
	//Pol pol;
	double salary;
	int expirence;
};





int main()
{
	//Person* guest = new Person();

	//guest->age = 28;
	//guest->name = "Anar";

	//cout << guest->info() << "\n\n";



	//Student* Anvar = new Student();
	//Anvar->setStudentInfo(18, "Anvar", Male, 2022, 4.1);


	//cout << Anvar->info() << "\n\n";


	//Teacher* Ayxan = new Teacher();
	//Ayxan->age = 15;
	//Ayxan->expirence = 2;
	//Ayxan->name = "Ayxan";
	//Ayxan->salary = 150;

	//cout << Ayxan->info() << "\n\n";


	Student* David = new Student(18,"David",Male,4.1,2022);
	delete David;
}


