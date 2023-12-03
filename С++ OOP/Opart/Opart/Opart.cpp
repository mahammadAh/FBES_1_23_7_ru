#include <iostream>

using namespace std;


class Movie {
	char* name { nullptr };
	int year;
public:
	Movie(int year, char* name) : year{ year } {
		this->name = name;
	}

	//Movie(const Movie& movie) {
	//	this->year = movie.year;
	//	setName(movie.name,12);
	//}

	Movie() {

	}

	friend ostream& operator<<(ostream& output, Movie movie);

	void changeSymByIndex(int index, char sym) {
		name[index] = sym;
	}

	void setName(char* name,int size) {
		this->name = new char[size];
		for (int i = 0; i < size; i++) {
			this->name[i] = name[i];
		}

	}

	void setYaer(int year) {
		this->year = year;
	}


	 Movie& operator= (const Movie& movie) {
		year = movie.year;
		setName(movie.name,12);
		return *this;
	};
};

ostream& operator<<(ostream& output, Movie movie) {
	output << "Name : " << movie.name << endl;
	output << "Year : " << movie.year << endl;
	return output;
}


int main()
{
	char* name = new char[12]{'o', 'p', 'p', 'e', 'n', 'h', 'e', 'i', 'm', 'e', 'r', '\0'};

	Movie oppenheimer;
	oppenheimer.setYaer(2023);
	oppenheimer.setName(name,12);

	cout << oppenheimer;

	oppenheimer.changeSymByIndex(0, 'O');

	cout <<endl << oppenheimer;

	Movie copyOppenheimer = oppenheimer;

	cout << endl << copyOppenheimer;

	copyOppenheimer.setYaer(1999);


	cout <<endl << "original : " << endl <<oppenheimer;
	cout << endl << "copy : "  << endl << copyOppenheimer;


	copyOppenheimer.changeSymByIndex(0,'T');
	copyOppenheimer.changeSymByIndex(1, 'e');
	copyOppenheimer.changeSymByIndex(2, 'r');
	copyOppenheimer.changeSymByIndex(3, 'm');
	copyOppenheimer.changeSymByIndex(4, 'i');
	copyOppenheimer.changeSymByIndex(5, 'n');
	copyOppenheimer.changeSymByIndex(6, 'a');
	copyOppenheimer.changeSymByIndex(7, 't');
	copyOppenheimer.changeSymByIndex(8, 'o');
	copyOppenheimer.changeSymByIndex(9, 'r');
	copyOppenheimer.changeSymByIndex(10, ' ');
	copyOppenheimer.changeSymByIndex(11, ' ');


	cout << endl << "original : " << endl << oppenheimer;
	cout << endl << "copy : " << endl << copyOppenheimer;
}

