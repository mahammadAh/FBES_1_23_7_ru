//#include <iostream>
//
//using namespace std;

// тип_возвращаемого_значения название_функции (параметры)
//{
// тело_функции
//}

//void printHelloStep()
//{
//    cout << "Hello Step";
//}
//
//
//void printNumber(int num) {
//    cout << num;
//}
//
//void printNumber(int start , int end) {
//    for (; start < end; start++) {
//        cout << start << " ";
//    }
//}
//
//void printSquareNumber(int num) {
//    num = num * num;
//    cout << num<<endl;
//}
//
//
//void printDarnagul() {
//    cout << "Darnagul" << endl;
//}
//
//void printChar(char sym) {
//    cout << sym << endl;
//}
//
//void printCity(char cityName[], int size) {
//  cityName[3] = 'I';
//}
//
//
//void printNum(int num) {
//    num = 19;
//}
//
//
//int calcNumbs(int num1, int num2)
//{
//    int sum = num1 + num2;
//    return sum;
//
//}
//
//void printNumbers() {
//    cout << 1 << endl;
//    cout << 2 << endl;
//    return;
//    cout << 3 << endl;
//}
//
//void printCountry(int num1, int num2, int num3);

//int main()
//{
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

   /* printCountry(1,2,3);*/

//
//    cout << "sd";
//
//
//
//
//}



//
//
//void printCountry(int num1,int num2, int num3) {
//    cout << "U.S.A" << endl;
//    cout << "U.S.A" << endl;
//    cout << "U.S.A" << endl;
//    cout << "U.S.A" << endl;
//    cout << "U.S.A" << endl;
//    cout << "U.S.A" << endl;
//    cout << "U.S.A" << endl;
//    cout << "U.S.A" << endl;
//    cout << "U.S.A" << endl;
//
//    cout << "U.S.A" << endl;
//    cout << "U.S.A" << endl;
//    cout << "U.S.A" << endl;
//    cout << "U.S.A" << endl;
//
//}




/////////////////////////////////////


#include <iostream>
#include <stdlib.h>
#include <time.h>

using namespace std;

int const size2 = 10;

void printArray(int arr[][size2], int size1, int size2) {
    for (int i = 0; i < size1; i++) {
        for (int j = 0; j < size2; j++) {
            cout << arr[i][j] << " ";
        }
        cout << endl;
    }

}

void fillArrayWithRandomNums(int arr[][size2],int size1 , int size2) {
    for (int i = 0; i < size1; i++) {
        for (int j = 0; j < size2; j++) {
            arr[i][j] = 10 + rand() % 40;
        }
    }
    
}

int num;

void  NumX3() {
    num = num * num * num;
    cout << num << endl;
}


int bigNum = 10000;


void studentCounter(char arr[],int size) {
    int static counter = 0;

    for (int i = 0; i < size; i++) {
        cout << counter << " ";
        counter++;
        if (counter == 15) {
            counter = 0;
        }
    }

  
}


int main() {
    //srand(time(NULL));
    //int const size1 = 5,size23 = 6;
    //int arr1[size1][size2];
    //int arr2[size1][size2];
    //int arr3[size1][size2];
    //fillArrayWithRandomNums(arr1,size1,size2);
    //printArray(arr1, size1, size2);
    //cout << endl;
    //fillArrayWithRandomNums(arr2, size1, size2);
    //printArray(arr2, size1, size2);
    //cout << endl;
    //fillArrayWithRandomNums(arr3, size1, size2);
    //printArray(arr3, size1, size2);

   /*  num = 10;
    NumX3();
    cout << num<<endl;*/

    //int bigNum = 4;

    //cout << bigNum<<endl;
    //cout <<::bigNum;

    const int size1 = 5,size2=7,size3=9;
    char group1[size1] = { 'A','C','N','D','Q' };
    char group2[size2] = { 'Q','S','Z','T','Y','L','K' };
    char group3[size3] = { 'O','P','I','U','Z','Q','W','J','M'};

    studentCounter(group1,size1);
    cout << endl;

    studentCounter(group2, size2);
    cout << endl;

    studentCounter(group3, size3);
    cout << endl;


    char sym = 64;
    int ostatok = 14;
    sym = sym + ostatok - 9;
    cout << sym;
}
