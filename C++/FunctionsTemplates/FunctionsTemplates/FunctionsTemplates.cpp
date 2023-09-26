#include <iostream>

using namespace std;

//void readFile(xmlFile file) {
	// Реализация 1
//}

//void readFile(jsonFile file) {
	// Реализация 2
//}

// Шаблонные функции 

int sqrNum1(int num) {
	return num * num;
}

template <typename T , typename S> T sqrNum2(T num1 , S num2) {
	T result;
	result = num1 * num2;
	return result; 
}


template <typename T>T sumArrElements(T arr[], int size) {
	T sum = 0;
	for (int i = 0; i < size; i++) {
		sum += arr[i];
	}
	return sum;
}

template <typename T>T sumArrElements(T arr[], double size) {
	T sum = 0;
	for (int i = 0; i < size; i++) {
		sum += arr[i];
	}
	return sum;
}


int main()
{
	cout << sqrNum1(4) << endl;
	
	cout << sqrNum2(5,6.1) << endl; // T - int S - double
	cout << sqrNum2(6.1,5) << endl; // T - double S - int

	cout << sqrNum2(6.7,3.4) << endl;

	cout << sqrNum2('A','C') << endl;

	cout << sqrNum2(true,false) << endl;

	int const sizeDouble = 5;
	double arrDouble[sizeDouble] = { 2.5,4.3,6.2,7.1,9.8 };
	cout << sumArrElements(arrDouble, sizeDouble) << endl;


	int const sizeInt = 5;
	double arrInt[sizeInt] = { 2,3,2,7,8 };
	cout << sumArrElements(arrInt, sizeInt) << endl;


}


