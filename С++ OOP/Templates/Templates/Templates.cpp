#include <iostream>
#include <string.h>
#include <string>
#include <stdio.h>
#include <vector>
#include <initializer_list>

using namespace std;




template <typename T> void sort(T arr[], int size) {
	cout << "Obshiy shablonniy metod" << endl;
    for (int i = 0; i < size; i++) {
        T min = arr[i];
        int position = i;
        for (int j = i; j < size; j++) {
            if (min > arr[j]) {
                min = arr[j];
                position = j;
            }
        }
        T temp = arr[i];
        arr[i] = min;
        arr[position] = temp;

    }
}



template<> void sort<int>(int arr[], int size) {
	cout << "Castniy shablonniy metod" << endl;
}




template <typename T> void print(T arr[], int size) {
    for (int i = 0; i < size; i++) {
        cout << arr[i] << " ";
    }
    cout << endl;
}


class Fraction {
    int c;
    int z;
public:
    Fraction(int c, int z) : c{ c }, z{ z } {
    }

    void setC(int c) {
        this->c = c;
    }

    int getC() {
        return c;
    }

    void setZ(int z) {
        this->z = z;
    }

    int getZ() {
        return z;
    }
};


template <typename T>
class Array {
	T* arr = nullptr;
	int length{ 0 };
public:
	Array() {};


	Array(const initializer_list<T>& list ) {
		length = list.size();
		T* newArr = new T[length];
		arr = newArr;
		newArr = nullptr;
		int j = 0;

		for (auto i = list.begin(); i != list.end(); i++,j++) {
			arr[j] = *i;

		}
	}



	void Add(T value) {
		T* newArr = new T[length + 1];
		for (int i = 0; i < length; i++) {
			newArr[i] = arr[i];
		}
		newArr[length] = value;
		delete[] arr;
		arr = newArr;
		newArr = nullptr;
		length++;
	}







	void remove(int index) {
		T* newArr = new T[length - 1];
		for (int i = 0, j = 0; i < length; i++) {
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

	T* array() {
		return arr;
	}

	~Array() {
		delete[] arr;
		arr = nullptr;
	}
};


template <>
class Array<char> {

};


int main()
{
	/*   double intDouble[10] = { 1.9,6.5,3.0,4.8,3.4,10.7,5.6,1.90,1.1,1.0 };

	   int  intArr[10] = { 19,65,3,48,34,107,56,190,11,10 };


	  print(intArr, 10);
	   sort(intArr,10);
	  print(intArr, 10);

	  cout << endl << endl << endl;

	  print(intDouble, 10);
	  sort(intDouble, 10);
	  print(intDouble, 10);



	  Fraction* drobArr[4] = {new Fraction(5, 10) ,new Fraction(5,10),new Fraction(5,10) ,new Fraction(5,10) };


	  print(drobArr, 10);
	  sort(drobArr, 10);
	  print(drobArr, 10);*/

	  /*  string stringArr[6] = { "Fuad","Elnur", "Ayaz","David","Faxri","Ayxan"};

		print(stringArr, 10);
		sort(stringArr, 10);
		print(stringArr, 10);*/

		//string str = "Hello World";
		//cout << str << endl;

		//str = "Fuad = Break";

		//cout << str << endl;

		//string str1;

		//cin >> str1;

		//cout << str1;

		//getline(cin,str1);

		//cout << str1;

	   /* string str2 = "STEP IT ACADEMY";

		cout << str2;

		char sym1 = str2[0];

		cout << endl << sym1;*/


		//Array<double> marks(5.1, 8.3, 7.5, 8.8, 9.1, 7.3);

		//marks.Add(1.1);

		//marks.Add(6.6);


		//for (int i = 0; i < marks.size(); i++) {
		//	cout << marks.array()[i] << " ";
		//}
		//cout << endl;

		//marks.remove(3);


		//for (int i = 0; i < marks.size(); i++) {
		//	cout << marks.array()[i] << " ";
		//}
		//cout << endl;


	//Array<short> marks(4, 22,33,44,55);

	//marks.Add(66);

	//for (int i = 0; i < marks.size(); i++) {
	//	cout << marks.array()[i] << " ";
	//}
    //cout << endl;



	//double intDouble[10] = { 1.9,6.5,3.0,4.8,3.4,10.7,5.6,1.90,1.1,1.0 };

	//int  intArr[10] = { 19,65,3,48,34,107,56,190,11,10 };

	//sort(intDouble, 10);
	//sort(intArr, 10);


	Array<double> marks {3.5,4.5};

	for (int i = 0; i < marks.size(); i++) {
		cout << marks.array()[i] << " ";
	}
	cout << endl;

}






