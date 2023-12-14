#include <iostream>
#include <queue>

using namespace std;



template <typename T>
class Queue {
	T* arr;
	int size{ 0 };
public:
	void Push(const T& value) {
		size++;
		T* newArr = new T[size];

		for (int i = 0; i < size - 1; i++) {
			newArr[i] = arr[i];
		}
		newArr[size - 1]= value;
		delete[] arr;
		arr = newArr;
		newArr = nullptr;
	}

	bool Empty() {
		if (size <= 0) {
			return true;
		}
		return false;
	}

	void Pop() {
		if (this->Empty()) {
			throw exception("queue is empty");
		}

		size--;
		T* newArr = new T[size];

		for (int i = 1; i <= size; i++) {
			newArr[i-1] = arr[i];
		}

		delete[] arr;
		arr = newArr;
		newArr = nullptr;

	}

	T& Back() {
		if (this->Empty()) {
			throw exception("queue is empty");
		}
		return arr[size - 1];
	}

	T& Front() {
		if (this->Empty()) {
			throw exception("queue is empty");
		}
		return arr[0];
	}

	int Size() {
		return size;
	}

	~Queue() {
		delete[] arr;
	}
};


template <typename T>
class PriorityQueue {
	T* arr;
	int size{ 0 };
public:
	void Push(const T& value) {
		size++;
		T* newArr = new T[size];

		for (int i = 0; i < size - 1; i++) {
			newArr[i] = arr[i];
		}
		newArr[size - 1] = value;
		delete[] arr;
		arr = newArr;
		newArr = nullptr;
		sort();
	}

	void sort() {
		T buff ;
		for (int i = 0; i < size - 1; i++) {
			for (int j = 0; j < size - i - 1; j++) {
				if (arr[j + 1] > arr[j])
				{
					buff = arr[j + 1];
					arr[j + 1] = arr[j];
					arr[j] = buff;
				}
			}
		}
	}

	bool Empty() {
		if (size <= 0) {
			return true;
		}
		return false;
	}

	void Pop() {
		if (this->Empty()) {
			throw exception("queue is empty");
		}

		size--;
		T* newArr = new T[size];

		for (int i = 1; i <= size; i++) {
			newArr[i - 1] = arr[i];
		}

		delete[] arr;
		arr = newArr;
		newArr = nullptr;

	}

	T& Back() {
		if (this->Empty()) {
			throw exception("queue is empty");
		}
		return arr[size - 1];
	}

	T& Top() {
		if (this->Empty()) {
			throw exception("queue is empty");
		}
		return arr[0];
	}

	int Size() {
		return size;
	}

	~PriorityQueue() {
		delete[] arr;
	}
};



class Student {
	string name;
	int age;
public:
	Student() {

	}
	Student(string name, int age) : name{ name }, age{ age } {

	}

	string getName() {
		return name;
	}

	int getAge() {
		return age;
	}


	bool operator<(const Student& student) const {
		return this->age < student.age;
	}

	bool operator>(const Student& student) const {
		return this->age > student.age;
	}
};

struct myInt {
	int value;

	bool operator<(const myInt& myInt) const {
		return this->value > myInt.value;
	}

};


int main()
{
	//Queue<int> myQueue;

	//myQueue.Push(1);
	//myQueue.Push(3);
	//myQueue.Push(5);
	//myQueue.Push(7);
	//myQueue.Push(9);

	//int size = myQueue.Size();
	//for (int i = 0; i < size; i++) {
	//	cout << myQueue.Front() << " ";
	//	myQueue.Pop();
	//}

	//std::queue<int> orgQueue;

	//orgQueue.push(1);
	//orgQueue.push(3);
	//orgQueue.push(5);
	//orgQueue.push(7);
	//orgQueue.push(9);


	//int size = orgQueue.size();
	//for (int i = 0; i < size; i++) {
	//	cout << orgQueue.front() << " ";
	//	orgQueue.pop();
	//	
	//}

	//std::priority_queue<char> orgPriorQueue;
	//orgPriorQueue.push('s');
	//orgPriorQueue.push('l');
	//orgPriorQueue.push('a');
	//orgPriorQueue.push('c');
	//orgPriorQueue.push('d');


	//int size = orgPriorQueue.size();
	//for (int i = 0; i < size; i++) {
	//	cout << orgPriorQueue.top() << " ";
	//	orgPriorQueue.pop();
	//}


	//std::priority_queue<Student> orgPriorQueue;
	//Student student1("Elnur", 26);
	//orgPriorQueue.push(student1);
	//Student student2("Ayaz", 18);
	//orgPriorQueue.push(student2);
	//Student student3("Fuad", 26);
	//orgPriorQueue.push(student3);
	//Student student4("Ayxan", 15);
	//orgPriorQueue.push(student4);
	//Student student5("Farman", 20);
	//orgPriorQueue.push(student5);


	//int size = orgPriorQueue.size();

	//for (int i = 0; i < size; i++) {
	//	Student student = orgPriorQueue.top();
	//	cout << student.getName() << " ";
	//	cout << student.getAge()<< endl;
	//	orgPriorQueue.pop();
	//}


	PriorityQueue<Student> orgPriorQueue;
	Student student1("Elnur", 26);
	orgPriorQueue.Push(student1);
	Student student2("Ayaz", 18);
	orgPriorQueue.Push(student2);
	Student student3("Fuad", 26);
	orgPriorQueue.Push(student3);
	Student student4("Ayxan", 15);
	orgPriorQueue.Push(student4);
	Student student5("Farman", 20);
	orgPriorQueue.Push(student5);

	int size = orgPriorQueue.Size();

	for (int i = 0; i < size; i++) {
		Student student = orgPriorQueue.Top();
		cout << student.getName() << " ";
		cout << student.getAge() << endl;
		orgPriorQueue.Pop();
	}
}

