#include <iostream>
#include <conio.h>


using namespace std;


void changeNumber(int num) {
    num = num * 3;
}

void reverse(int arr[], int size) {
    for (int i = 0; i < size/2; i++) {
        int temp = arr[i];
        arr[i] = arr[size - i - 1];
        arr[size - i - 1] = temp;
    }
}

void printArray(int* arr, int size) {
    for (int i = 0; i < size; i++) {
        cout << arr[i] << " ";
    }
}


void printArray(char*& string) {
	for (int i = 0; ; i++) {
		if (string[i] == '\0') {
			break;
		}
		cout << string[i];
	}
}

void writeToArray(char*& string) {
	int size = 1;
	char sym = ' ';
	bool isDelete = false;
	bool isBreak = false;
	char* newString = new char;
	while (true) {
		sym = _getch();
		if (sym == 13) {

			isBreak = true;
		}
		else if (sym == 8) {
			isDelete = true;
		}

		if (!isDelete) {

			newString = new char[size + 1];

			for (int i = 0; i < size-1; i++) {
				newString[i] = string[i];
			}
			if (!isBreak) {
				newString[size-1] = sym;
				newString[size] = '\0';
			}
			size++;

		}
		else {
			newString = new char[size - 1];
			for (int i = 0; i < size-2; i++) {
				newString[i] = string[i];
			}
			newString[size - 2] = '\0';
			size--;
			isDelete = false;
		}

		delete[] string;
		string = nullptr;
		string = newString;
		newString = nullptr;

		system("cls");

		printArray(string);
        if (isBreak) break;

	}
}


void myGetLine(char*& pointer, int size, char stopper = 13) {
	char* buff = new char[size];

	
	int i = 0;
	while (true) {
		char sym = _getch();
		if (sym == stopper) {
			buff[i] = '\0';
			pointer = buff;
			buff = nullptr;
			break;
		}
		if (i > size) {
			continue;
		}
		buff[i] = sym;
		cout << sym;
		i++;
	}

}
int main()
{
 //   int num = 5;
 //   cout << "num : " << num << endl;
 //   changeNumber(num);
 //   cout << "num : " << num<<endl;


 //   int const size = 5;
 //   int arr[size] = { 1,2,3,4,5 };
 //   cout << "before : ";
 //   printArray(arr, size);
 //   reverse(arr, size);
 //   cout <<endl<< "after  : ";
 //   printArray(arr, size);


	//char* write = new char;
	//write = nullptr;
	//cout << endl;
	//writeToArray(write);


	//char arr[] = "hello world";

	//cout << arr << endl;

	//const char* message;
	//message = "hello world";

	//char* string = new char;
	//writeToArray(string);
	//printArray(string);


	//char text[255];

	//gets(text);

	//char* text = new char;
	//cin.getline(text, 255);
	//cout << text;

	//char text[] = "hello";
	//int size;
	//size = strlen(text);
	//cout << size;

	//char* myText = new char;
	//myGetLine(myText, 10);
	//cout <<endl<< myText;
    

	//char* newString = new char;
	//cin.getline(newString, 30);
	//cout << newString;



	char text1[255] = "Hello";
	char text2[] = " C++";
	char text3[] = " i love you";

	

	cout << "len text 1 : " << strlen(text1) << endl;
	cout << "len text 2 : " << strlen(text2) << endl;

	char cpyText2[(4+1)];
	cout << "cpyText2 before : " << cpyText2 << endl;
	strcpy_s(cpyText2, text2);
	cout << "cpyText2 after : " << cpyText2 << endl;

	strcat_s(text1, text2);
	strcat_s(text1,text3);
	cout << text1<<endl;


	// text1 =  Hello C++ i love you\0\0\0\0\0\0
	auto result = strchr(text1, 'i');
	cout << result << endl;
	
}










