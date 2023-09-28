#include <iostream>
#include<stdlib.h>
#include<time.h>
#include<conio.h>
using namespace std;

template <typename T> void printVal(T val) {
    T num = val / 2;
    cout << val << endl;
}

int getValInt() {
    return 1;
}

int main()
{
    //auto val = 1;

   // decltype(val) newVal;
   
   
    //char sym1 = getchar();
   // cout << "sym --> " << sym1 << endl;

     //char sym2 = _getch();
     //cout << "sym --> " << sym2 << endl;
     bool isEnd = false;

     while (!isEnd) {
         cout << "1.Select student"<<endl;
         cout << "2.Create student"<<endl;
         cout << "For Exit click --> E" << endl;

         char clickedSym = _getch();

         switch (clickedSym)
         {
         case '1':
             cout << "1.Elnur\n2.Ayaz\n3.Nazim"<<endl;
             break;
         case '2':
             cout << "Name :\nSurname\nAge" << endl;
             break;
         case 'E':
             isEnd = true;
             break;
         }
     }
    
}


