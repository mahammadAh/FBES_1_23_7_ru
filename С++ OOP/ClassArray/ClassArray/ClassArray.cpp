#include <iostream>
#include <stdio.h>
#include <stdarg.h>

using namespace std;


class Array {
	int* arr = nullptr;
	int length{ 0 };
public:
	Array() {

	}

	Array(int size, int n , ...) {
		length = size;
		int* newArr = new int[length];
		arr = newArr;
		newArr = nullptr;

		va_list factor;
		va_start(factor, n);
		arr[0] = n;
		for (int i = 1; i < length; i++) {
			arr[i] = va_arg(factor, int);
		}
	}

	void Add(int value) {
		int* newArr = new int[length+1];
		for (int i = 0; i < length; i++) {
			newArr[i] = arr[i];
		}
         newArr[length]= value;
		 delete[] arr;
		 arr = newArr;
		 newArr = nullptr;
		 length++;
	}

	void remove(int index) {
		int* newArr = new int[length - 1];
		for (int i = 0 , j= 0; i < length; i++) {
			if (i == index) {
				continue;
			}
			newArr[j] = arr[i];
			j++;
		}
		delete[] arr;
		arr = newArr;
		newArr = nullptr;
		length--;
	}

	int size() {
		return length;
	}

	int* array() {
		return arr;
	}

	~Array() {
		delete[] arr;
		arr = nullptr;
	}
};


int main()
{
	Array marks(5,8,7,8,9,7);

	marks.Add(11);

	marks.Add(66);


	for (int i = 0; i < marks.size(); i++) {
		cout << marks.array()[i] << " ";
	}
	cout << endl;

	marks.remove(3);


	for (int i = 0; i < marks.size(); i++) {
		cout << marks.array()[i] << " ";
	}
	cout << endl;
}


