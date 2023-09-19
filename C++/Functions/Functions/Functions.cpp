#include <iostream>

using namespace std;

// тип_возвращаемого_значения название_функции (параметры)
//{
// тело_функции
//}

void printHelloStep()
{
    cout << "Hello Step";
}


void printNumber(int num) {
    cout << num;
}

void printNumber(int start , int end) {
    for (; start < end; start++) {
        cout << start << " ";
    }
}

void printSquareNumber(int num) {
    num = num * num;
    cout << num<<endl;
}


void printDarnagul() {
    cout << "Darnagul" << endl;
}

void printChar(char sym) {
    cout << sym << endl;
}

void printCity(char cityName[], int size) {
  cityName[3] = 'I';
}


void printNum(int num) {
    num = 19;
}


int calcNumbs(int num1, int num2)
{
    int sum = num1 + num2;
    return sum;

}

void printNumbers() {
    cout << 1 << endl;
    cout << 2 << endl;
    return;
    cout << 3 << endl;
}

void printCountry(int num1, int num2, int num3);

int main()
{
    //printHelloStep();
    //printNumber(5);
    //printNumber(6, 14);
    /*int num = 5;
   // printSquareNumber(num);
    // << num; */
    //cout << "Start"<<endl;
    //printDarnagul();
    //cout << "End";
    //printChar('s');

    //int const size = 4;
    //char cityName[size] = { 'B','A','K','U' };
    //printCity(cityName, size);
    //cout << cityName[3]<<endl;

    //int num = 5;
    //printNum(num);
    //cout << num;

    //int result;
    //result = calcNumbs(5, 8); 
    //cout << result;


    //printNumbers();

    printCountry(1,2,3);

}


void printCountry(int num1,int num2, int num3) {
    cout << "U.S.A" << endl;
    cout << "U.S.A" << endl;
    cout << "U.S.A" << endl;
    cout << "U.S.A" << endl;
    cout << "U.S.A" << endl;
    cout << "U.S.A" << endl;
    cout << "U.S.A" << endl;
    cout << "U.S.A" << endl;
    cout << "U.S.A" << endl;

    cout << "U.S.A" << endl;
    cout << "U.S.A" << endl;
    cout << "U.S.A" << endl;
    cout << "U.S.A" << endl;

}


