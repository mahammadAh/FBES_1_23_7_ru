#include <iostream>

using namespace std;

int main()
{
 
    unsigned int val = 9;

    // << - ��������� ����� � ����

    cout <<"(val << 2) = "<< (val << 2) << endl;

    // 0100 => 1000
    
    // 00000000 00000000 00000000 00001001

    // << - ��������� ����� �� �����

    cout << "(val >> 1) = " << (val >> 1) << endl;

    // | - ��������� ��� 

    cout << "(val | 2) = " << (val | 2) << endl;

    // & - ��������� �

    val = 23;
    cout << "(val & 15) = " << (val & 15) << endl;

    // ~ - ��������� �������� ( ��������� )

    cout << "(~val) = " << (~val) << endl;

    // ^ - XOR - ��������� ����������

    cout << "(val ^ 12) = " << (val ^ 12) << endl;




}


