#include <iostream>

using namespace std;

int main()
{
 
    unsigned int val = 9;

    // << - побитовый сдвиг в лево

    cout <<"(val << 2) = "<< (val << 2) << endl;

    // 0100 => 1000
    
    // 00000000 00000000 00000000 00001001

    // << - побитовый сдвиг на право

    cout << "(val >> 1) = " << (val >> 1) << endl;

    // | - побитовый или 

    cout << "(val | 2) = " << (val | 2) << endl;

    // & - побитовое и

    val = 23;
    cout << "(val & 15) = " << (val & 15) << endl;

    // ~ - побитовая инверсия ( отрицание )

    cout << "(~val) = " << (~val) << endl;

    // ^ - XOR - побитовое исключение

    cout << "(val ^ 12) = " << (val ^ 12) << endl;




}


