#include <iostream>

using namespace std;


enum collection {
	Pen = '1',
	Door = 2,
	Table = '3',
};

int a = 4;

struct Person {
	int age;
};


void changeAge(Person &person) {
	person.age = 20;
}

int main()
{
	Person person;
	person.age = 25;
	changeAge(person);
	cout << person.age << endl;

}


