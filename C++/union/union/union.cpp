#include <iostream>

using namespace std;

union myValues {
    int firstValue; // 4
    long secondValue; // 4
    short ThirdValue; // 2
};

int main()
{
    int firstValue; // 4
    long secondValue; // 4
    short ThirdValue; // 2

    myValues myValue;

    myValue.firstValue = 30;

    cout << " myValue.firstValue -> " << myValue.firstValue << endl;

    cout << "myValue size : " << sizeof(myValue) << endl;

    myValue.ThirdValue = 70;

    myValue.secondValue = 4000000;


    cout <<"myValue.secondValue -> " << myValue.secondValue << endl;

    cout << " myValue.firstValue -> " << myValue.firstValue << endl;

    cout << "myValue.ThirdValue -> " << myValue.ThirdValue << endl;


   
}

