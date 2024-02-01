#include <iostream>
#include <string>

using namespace std;

class Person {
public:
	int* age;

	Person(int* age) {
		this->age = age;

	}

	// Move constructor
	Person(Person&& obj) {
		cout << "My Move Constructor" << endl;
		delete this->age;
		this->age = new int(*(obj.age));
		obj.age = nullptr;

	}

	// Deep copy
	Person(const Person& obj) {
		cout << "My Copy Constructor" << endl;
		this->age = new int(*(obj.age));
	}

	 Person& operator= (const Person& obj) {
		cout << "My overload copy = " << endl;
		this->age = new int(*(obj.age));
		return *this;
	}


	 Person& operator= (Person&& obj) {
		cout << "My overload move = " << endl;
		delete this->age;
		this->age = new int(*(obj.age));
		obj.age = nullptr;
		return *this;
	}

};


void getMemory() {
	int* val1 = new int(5);
}

int count = 0;

template <typename T>
class my_smart_ptr {
	T* _ptr;
	static int count;
public:

	my_smart_ptr(T* ptr) : _ptr(ptr) { count++; };

	~my_smart_ptr() {
		cout << "Destructor number = " << count << endl;
		delete _ptr;
	}
};

template <typename T>
int my_smart_ptr<T>::count = 0;



template <typename T>
my_smart_ptr<T> make_smart_ptr(T val) {
	my_smart_ptr<T> smart_ptr;
	return smart_ptr;
}


int main()
{
	//int* age = new int(18);
	//Person student(age, "Ayaz");

	//Person copyStudent = student;

	//*(student.age) = 20;
	//student.name = "Faxri";

	//cout << "**Student**" << endl;
	//cout << "Name : " << student.name << endl;
	//cout << "Age : " << *(student.age) << endl<<endl;

	//cout << "**Copy Student**" << endl;
	//cout << "Name : " << copyStudent.name << endl;
	//cout << "Age : " << *(copyStudent.age) << endl;


	//int* age = new int(18);
	//Person Anvar = Person(age);


	//cout << "**Student**" << endl;
    //cout << "Name : " << student.name << endl;
    //cout << "Age : " << *(student.age) << endl<<endl;

	/*cout << "**Anvar**" << endl;
	cout << "Age : " << *(Anvar.age) << endl << endl;*/


	//while (true) {
	//	//int* val1 = new int(5);
	//	unique_ptr<int> val1 = { make_unique<int>(5) };
	//	cout << val1 << endl;

	//}


	//unique_ptr<int> smrtValPtr1{ new int(10) };
	//auto smrtValPtr2 = make_unique<int>(15);
	//unique_ptr<int> smrtValPtr3 = make_unique<int>(20);

	//while (true) {
	//	my_smart_ptr<int> mySmrtValPtr1 {new int(10)};
	//	auto mySmrtValPtr2 = make_smart_ptr<int>(15);
	//	my_smart_ptr<int> mySmrtValPtr3 = make_smart_ptr<int>(20);
	//}

	while (true) {
		my_smart_ptr<Person> mySmrtValPtr1 {new Person(new int(10))};
		unique_ptr<Person> smrtValPtr1{ new Person(new int(20)) };
	}
}

