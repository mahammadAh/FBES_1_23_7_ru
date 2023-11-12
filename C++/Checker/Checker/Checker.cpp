#include <iostream>
#include <time.h>
#include <stdlib.h>
#include <windows.h>
#include <conio.h>
using namespace std;

FILE* recordFile;
int const arrSize = 2;

struct Record {
	char* name = new char[20];
	int score;
};


void readFromFile(Record records[arrSize]) {
	fopen_s(&recordFile, "records.txt", "r");
	char name[20];
	int score;
	int i = 0;
	while (true) {
		fscanf_s(recordFile, "%s %i", name, sizeof(name), &score);
		strcpy_s(records[i].name,20, name);
		records[i].score = score;
		i++;
		if (i == arrSize) break;
	}

	fclose(recordFile);
}

void writeToFile(Record records[]) {
	fopen_s(&recordFile, "records.txt", "w");

	for (int i = 0; i < arrSize; i++) {
		fprintf_s(recordFile, "%s %i\n", records[i].name, records[i].score);
	}

	fclose(recordFile);

}



int main()
{

	Record records[arrSize];

	readFromFile(records);

	for (int i = 0; i < arrSize; i++) {
		cout << records[i].name << " : " << records[i].score << endl;
	}

	records[0].name = new char [20]{"player_11"};
	records[0].score = 10;

	records[1].name = new char [20] {"player_22"};
	records[1].score = 20;

	writeToFile(records);


}
