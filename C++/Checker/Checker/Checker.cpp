#include <iostream>
#include <time.h>
#include <stdlib.h>
#include <windows.h>
#include <conio.h>
using namespace std;

FILE* recordFile;

struct Record {
	const char* name = "Player";
	int score = 0;
};


void readFromFile(Record records[10]) {
	fopen_s(&recordFile, "records.txt", "r");

	int i = 0;
	while (true) {
		fscanf_s(recordFile, "%s %i", records[i].name, records[i].score);
		i++;
		if (i == 10) break;
	}

	fclose(recordFile);
}

void writeToFile(Record records[]) {
	fopen_s(&recordFile, "records.txt", "w");

	for (int i = 0; i < 10; i++) {
		fprintf_s(recordFile, "%s %i\n", records[i].name, sizeof(records[i].name), records[i].score);
	}

	fclose(recordFile);

}



int main()
{

	Record records[10];

	readFromFile(records);

	for (int i = 0; i < 10; i++) {
		cout << records[i].name << " : " << records[i].score << endl;
	}



	writeToFile(records);


}
