#include <iostream>

using namespace std;

// ��������� - Pointer 


void changeNumber(int* pNum) {
    
    if (*pNum % 2 == 0) {
        *pNum *= 2;
    }
    else {
        *pNum *= 3;
    }
}

int main()
{
    //int val = 54; 

    //cout << "1. " << val << endl;

    //cout << "2. " << &val << endl;
    // 
    //int* pVal = &val;

    //cout << "3. " << pVal << endl;

    //int copyVal = val;
    //copyVal = 10;

    //*pVal = 10;

    //cout << "4. " << val << " " << copyVal << endl;

    // & - ���������� ������ �� ���������� ( ������ )
    // int* val - ��������� ��������� ������� ����� ������� � ���� ������
   //  *val - �������� ������ � �������� �� ������ ( ������������� )

    //int num = 7;
    //cout << endl<<endl<<endl<<"1. "<<num << endl;
    //changeNumber(&num);
    //cout << "2. " << num << endl;
    //changeNumber(&num);
    //cout << "3. " << num << endl;
    //changeNumber(&num);
    //cout << "4. " << num << endl;

    //int arr[5] = { 1,2,3,4,5 };
    //
    //cout << "arr - " << arr<<endl;

    //int* pArr = arr;

    //cout << pArr[1]<<endl;

    //cout << *(pArr + 2) << endl;

    //int* pVal1 = 0;  // �� ������� �������
    //int* pVal1 = NULL; // ������� �������
    int* pVal1; // ����� ������� �������
    cout << pVal1 << endl;
    int val1;
    pVal1 = &val1;

    cout << pVal1 << endl;

}


