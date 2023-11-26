#include <iostream>
#include <Windows.h>

using namespace std;


class Age {
	int minAge{0};
	int maxAge{20};
	int currentAge{0};
public:

	Age() {

	}

	Age(int minAge,int maxAge, int currentAge) 
		: minAge{ minAge }, maxAge{ maxAge }, currentAge{ currentAge } {
		
	}

	//Age(int minAge, int maxAge, int currentAge)
	//{
	//	this->minAge = minAge;
	//	this->maxAge = maxAge;
	//	this->currentAge = currentAge;
	//}

	void setMinAge(int age) {
		minAge = age;
	}

	int getMinAge() {
		return minAge;
	}

	void setMaxAge(int age) {
		maxAge = age;
	}

	int getMaxAge() {
		return maxAge;
	}

	void setCurrentAge(int age) {
		currentAge = age;
	}

	int getCurrentAge() {
		return currentAge;
	}

	bool LifeCircle() {
		currentAge++;
		if (currentAge == maxAge) {
			return false;
		}
		return true;
	}
};



class Person {
	char name[20];
	int age{0};
	int weight{0};
	int height{0};
	int IQ{0};
public:

	Person(const char* name, int age) {
		cout << "Constructor 1 " << endl;
		strcpy_s(this->name, 20, name);
		this->age = age;
	}

	Person(const char* name, int age, int weight , int height) 
		: Person (name, age) {
		cout << "Constructor 2 " << endl;
		this->weight = weight;
		this->height = height;
	}

	Person(const char* name, int age, int weight, int height, int IQ)
		: Person(name, age, weight, height) {
		cout << "Constructor 3 " << endl;
		this->IQ = IQ;
	}

	void printInfo() {
		cout << "Name : " << name << endl;
		cout << "Age : " << age << endl;
		cout << "Weight : " << weight << endl;
		cout << "Height : " << height << endl;
		cout << "IQ : " << IQ << endl;
		cout << endl;
	}
};

enum memoryType {
	HDD,
	SSD
};

class Computer {
	char brand[20];
	char model[20];
	int coreCount;
	int RAM;
	memoryType memory;
public:
	static int createdComputerCount;

	Computer(const char* brand, const char* model, int coreCount, int RAM, memoryType memory)
		: coreCount{ coreCount }, RAM{ RAM }, memory{ memory } {
		strcpy_s(this->brand, 20, brand);
		strcpy_s(this->model, 20, model);
		createdComputerCount++;
	}

	void printInftoConsole() {
		cout << createdComputerCount << endl;
		cout << " Brand : " << brand << endl;
		cout << " Model : " << model << endl;
		cout << " CoreCount : " << coreCount << endl;
		cout << " RAM : " << RAM << endl;
		cout << " memory : ";
		switch (memory) {
		case HDD:
			cout << "HDD";
			break;
		case SSD:
			cout << "SDD";
			break;
		}
		cout << endl<<endl;
	
	}

	static void printCreatedComputerCount() {
		cout << "Created Computer : " << createdComputerCount << endl;
	}
};


int Computer::createdComputerCount{0};


class Animal {
	char name[20];
public:
	static int createdAnimalCount;

	Animal(const char* name) {
		createdAnimalCount++;
		strcpy_s(this->name, 20, name);
	}

};

int Animal::createdAnimalCount{0};


int main()
{
	//int a = 10;
	//cout << "a : " << a << endl;

	//int b(10);
	//cout << "b : " << b << endl;

	//int c = { 10 }; // Унифицированная инициализация 
	//cout << "c : " << c << endl;


	Age catAge(0, 35, 9);

	//catAge.setMinAge(0);
	//catAge.setMaxAge(20);
	//catAge.setCurrentAge(7);


	//while (true) {
	//	bool isAlive = catAge.LifeCircle();

	//	if (!isAlive) {
	//		cout << "Rest In Peace ((" << endl;
	//		break;
	//	}
	//	else {
	//		cout << "Happy " << catAge.getCurrentAge() << " Birthday" << endl;
	//	}
	//	
	//	Sleep(100);
	//	
	//}
	


	//Person student9("Anvar", 18,80,182,70);

	//student9.printInfo();


	//Computer computer1("Lenovo", "ThinkPad", 12, 16, SSD);
	//cout << "Created Computer : " << Computer::createdComputerCount << endl;
	//computer1.printInftoConsole();
	//Computer computer2("Lenovo", "LEGION", 16, 16, SSD);
	//cout << "Created Computer : " << Computer::createdComputerCount << endl;
	//computer2.printInftoConsole();
	//Computer computer3("Apple", "Macbook Air", 8, 16, SSD);
	//cout << "Created Computer : " << Computer::createdComputerCount << endl;
	//computer3.printInftoConsole();
	//Computer computer4("MSI", "Stealth 15", 10, 16, SSD);
	//cout << "Created Computer : " << Computer::createdComputerCount << endl;
	//computer4.printInftoConsole();


	//cout << Computer::createdComputerCount;

	//Computer::createdComputerCount++;
	//Computer::createdComputerCount++;
	//Computer::createdComputerCount++;

	//Computer::printCreatedComputerCount();


	cout << "Created Animal on Earth (start) : " << Animal::createdAnimalCount << endl;
	Animal animal1("bakteries");
	Animal animal2("plankton");

	cout << "Created Animal on Earth(mezazoy) : " << Animal::createdAnimalCount << endl;
	Animal animal3("dinozavri");
	Animal animal4("obezyanki");

	cout << "Created Animal on Earth(poliolit) : " << Animal::createdAnimalCount << endl;
	Animal animal5("neandertalci");
	Animal animal6("mamonti");

	cout << "Created Animal on Earth(now) : " << Animal::createdAnimalCount << endl;
}

