#include <iostream>
#include <conio.h>

using namespace std;

void printArray(char*& string, int& size) {
	for (int i = 0; i < size; i++) {
		cout << string[i];
	}
}


void writeToArray(char*& string,int& size) {
	char sym = ' ';
	bool isDelete = false;
	char* newString = new char;
	while (true) {
		sym = _getch();
		if (sym == 13) {
			break;
		}
		else if (sym == 8) {
			isDelete = true;
		}

		if (!isDelete) {
			newString = new char[size + 1];
			for (int i = 0; i < size; i++) {
				newString[i] = string[i];
			}
			newString[size] = sym;
			size++;
		}
		else {
			newString = new char[size - 1];
			for (int i = 0; i < size-1; i++) {
				newString[i] = string[i];
			}
			size--;
			isDelete = false;
		}

		delete[] string;
		string = nullptr;
		string = newString;
		newString = nullptr;

		system("cls");
		printArray(string, size);


	}
}



int main()
{
	char* string = new char[0];
	int size = 0;
	writeToArray(string, size);



}


