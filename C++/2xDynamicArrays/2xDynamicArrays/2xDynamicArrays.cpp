#include <iostream>
#include <stdlib.h>
#include <time.h>

using namespace std;

void fillArray(int arr[][4], int size1, int size2) {
	for (int i = 0; i < size1; i++) {
		for (int j = 0; j < size2; j++) {
			arr[i][j] = 50 - rand() % 100;
		}
	}

}


void printArray(int arr[][4], int size1, int size2) {
	for (int i = 0; i < size1; i++) {
		for (int j = 0; j < size2; j++) {
			cout << arr[i][j] << "\t";
		}
		cout << endl;
	}

}

void fillDynamicArray(int**& arr,int arrSize[], int size) {
	for (int i = 0; i < size; i++) {
		for (int j = 0; j < arrSize[i]; j++) {
			arr[i][j] =  rand() % 100;
		}
	}
}

void printDynamicArray(int**& arr, int arrSize[],int size) {
	for (int i = 0; i < size; i++) {
		cout << "size --> " << arrSize[i] << " : ";
		for (int j = 0; j < arrSize[i]; j++) {
			cout << arr[i][j] << " ";
		}
		cout << endl;
	}
}


int main()
{
	srand(time(NULL));
	//
	//int const size1 = 5;
	//int const size2 = 4;

	//int arr[size1][size2];

	//fillArray(arr, size1, size2);
	//printArray(arr, size1, size2);

	int size = 1+rand()%5;
	int* arrSize = new int[size]; // arr1 - pointer

	int** arr = new int* [size]; // arr2 - pointer to pointer



	

	for (int i = 0; i < size; i++) {
		int newSize = 1 + rand() % 25;
		arr[i] = new int[newSize];
		arrSize[i] = newSize;
	}

	fillDynamicArray(arr, arrSize,size);
	printDynamicArray(arr, arrSize, size);
	cout << endl << endl << endl;

	int* newArr = new int[5] {1, 2, 3, 4, 5};
	arrSize[0] = 5;
	arr[0] = newArr;

	printDynamicArray(arr, arrSize, size);

}

