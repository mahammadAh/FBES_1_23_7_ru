#include <iostream>
#include <time.h>
#include <stdlib.h>

using namespace std;



class Box {
	int width;
	int length;
	int height;
public:
	Box (){
	}

	Box(int width, int length, int height) :
		width{ width }, length{ length }, height{ height } {

	}

	int getWidth(){
		return width;
	}

	int getLength() {
		return length;
	}

	int getHeight() {
		return height;
	}
};


class  Anbar {
	Box* boxes{ nullptr };
	int count{ 0 };
public:
	void Add(Box* box) {
		Box* newBoxes = new Box[count + 1];

		if (boxes != nullptr) {
			for (int i = 0; i < count; i++) {
				newBoxes[i] = boxes[i];
			}
		}

		newBoxes[count] = *box;
		delete[] boxes;
		boxes = newBoxes;
		newBoxes = nullptr;
		count++;
	}

	int getCount() {
		return count;
	}

	 Box& getBoxByIndex(int index) {
		return boxes[index];
	}

};


class PrintDataToConlose {
public:
	void printAnbar(Anbar anbar) {
		for (int i = 0; i < anbar.getCount(); i++) {
			cout << "Box : " << i + 1 << endl;
			cout << "Height --> " << anbar.getBoxByIndex(i).getHeight() << endl;
			cout << "Length --> " << anbar.getBoxByIndex(i).getLength() << endl;
			cout << "Width --> " << anbar.getBoxByIndex(i).getWidth() << endl;
			cout << endl;
		}
	}
};

class File {
	FILE* file;
public:


	void WriteAnbarToFile(Anbar* anbar) {
		fopen_s(&file, "anbar.txt", "w");
		for (int i = 0; i < anbar->getCount(); i++) {
			int h = anbar->getBoxByIndex(i).getHeight();
			int w = anbar->getBoxByIndex(i).getWidth();
			int l = anbar->getBoxByIndex(i).getLength();
			fprintf(file, "%d %d %d\n", h, w, l);
		}
		fclose(file);
	}

	void ReadAnbarFromFile(Anbar* anbar) {
		fopen_s(&file, "anbar.txt", "r");
	
		while (!feof(file)) {
			int h=0, w=0, l=0;
			fscanf_s(file, "%d %d %d\n", &h, &w, &l);
			anbar->Add(new Box(w, l, h));
		}
		fclose(file);
	}
};

int main()
{
	Anbar No13;

	File workWithFile;
	workWithFile.ReadAnbarFromFile(&No13);

	srand(time(NULL));
	for (int i = 0; i < 4; i++) {
		No13.Add(new Box(rand()%50, rand() % 50, rand() % 50));
	}


	PrintDataToConlose console;

	console.printAnbar(No13);

	workWithFile.WriteAnbarToFile(&No13);



}

