#include <iostream>
#include <stdlib.h>
#include <time.h>

using namespace std;

const int  arrSize = 5;
int studentAges [arrSize] = { 17,16,26,23,19 };

int getUserData(int index) {
	static int counter = 0;
	counter++;
	cout << "counter adress : " << &counter << endl;
	cout <<"counter : "<< counter << endl;
	if (index >= 0 && index < arrSize) {
		return studentAges[index];		
	}
	return 0;
}


int sum(int num1, int num2) {
	int sum = num1 + num2;
	cout << "sum adress : " << &sum << endl;
	return sum;
}

void dynamicArrFill(int size, int arr[]);
void dynamicArrPrint(int size, int arr[]);
void staticArr(int size, int arr[]);

int main()
{
	//int studentIndex = -1;
	//int result = -1;
	//while (true) {
	//	cout << "Enter Student Index : ";
	//	cin >> studentIndex;
	//    result = getUserData(studentIndex);
	//	if (result == 0) {
	//		cout << "Incorrect index" << endl;
	//	}
	//	else
	//	{
	//		cout << "Student Age : " << result << endl;
	//	}
 //  }

	//int num1 = 0, num2 = 0;

	//while (true) {
	//	cout << "Num1 : " << endl;
	//	cin >> num1;
	//	cout << "Num2 : " << endl;
	//	cin >> num2;
	//	cout << num1 << "+" << num2 << "=" << sum(num1, num2)<<endl;
	//}

	//int* pVal = new int;
	//cout <<"*pVal : " << *pVal << endl;
	//*pVal = 5;
 //   cout << "*pVal : " << *pVal << endl;
	//int* pNum = new int{ 19 };
	//cout << "*pNum : " << *pNum << endl;

	//cout << "before pVal : " << pVal << endl;
	//delete pVal;
	//pVal = nullptr;
	//cout << "after pVal : " << pVal << endl;

	//pVal = pNum;
	//cout << "*pVal : " << *pVal << endl;

	//int const size = 255125;
	//int arr[size];
	//staticArr(size, arr);

	//int* pSize = new int;
	//cout << " Enter arr size : ";
	//cin >> *pSize;
	//int* pArr = new int[*pSize];
	//cout << "pArr 1 - " << pArr << endl;
	//srand(time(NULL));
	//dynamicArrFill(*pSize, pArr);
	//dynamicArrPrint(*pSize, pArr);
	//delete[] pArr;
	//pArr = nullptr;
	//int* pMinArr = new int[5];
	//pArr = pMinArr;
	//cout << "pArr 1 - " << pArr << endl;


	int* pSize = new int{0};
	int* lastIndex = new int {0};
	int* oldArr = nullptr;
	int* newArr = nullptr;
	int num = 0;
	while (true) {
			cout << "Enter number : ";
			cin >> num;

			newArr = new int[*pSize + 1];

			for (int i = 0; i < *pSize; i++) {
				newArr[i] = oldArr[i];
			}

			newArr[*lastIndex] = num;
			(*lastIndex)++;
			(*pSize)++ ;
			delete[] oldArr;
			oldArr = nullptr;
			oldArr = newArr;
			newArr = nullptr;

			cout << endl;
			for (int i = 0; i < *pSize; i++) {
				cout << oldArr[i] << " ";
			}
			cout << endl;

		
	}


}


void dynamicArrFill(int size, int arr[]) {
	for (int i = 0; i < size; i++) {
		*(arr + i) = rand() % 100;
		//pArr[i] = rand() % 100;
	}

}

void dynamicArrPrint(int size, int arr[]) {
	for (int i = 0; i < size; i++) {
		cout << *(arr + i) << " ";
	}
}

void staticArr(int size, int arr[]) {
	for (int i = 0; i < size; i++) {
		arr[i] = rand() % 100;
	}

	for (int i = 0; i < size; i++) {
		cout << arr[i] << " ";
	}
}


