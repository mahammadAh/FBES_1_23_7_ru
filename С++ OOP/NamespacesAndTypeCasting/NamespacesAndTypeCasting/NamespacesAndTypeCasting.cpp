#include <iostream>
#include "HeaderFile.h"

//using namespace items;
//using namespace Dress;
//using namespace SetValueToOneOfTheAccountsOnCard;
//
//namespace setVal = SetValueToOneOfTheAccountsOnCard;


void printInt(const int* pVal) {
	//*pVal = 15;
	//int newVal = 15;
	//pVal = &newVal;
	
	int* newPVal = const_cast<int*>(pVal);
	*newPVal = 15;
	cout << *pVal <<endl;
}



class A {
public:
	int val1;
};


class B : public A {
public:
	int val2;
};

	
int main()
{
	//Table table1;

	//table1.heigth = 10;

	//items::Color table1Color = items::BLACK;

	//table1.color = table1Color;

	//setVal::Accounts account;

	//Skirt skirt1;

	//skirt1.size = 42;
	//
	//Dress::Color skirt1Color = Dress::GREEN;

	//skirt1.color = skirt1Color;



	//int intA = 10, intB;
	//double doubleA = 10.5, doubleB;

	//intB = doubleA; // 10.5
	//cout << intB << endl; // 10  ---> сужающее преоброзование 

	//doubleB = intA;
	//cout << doubleB << endl; //--> расширяющее (безопасное) преоброзование 

	//int intC = (int)doubleA; // явное преоброзование 


	//char sym = 's';
	//int val1 = 10;

	//cout << sym + val1<<endl;

	//int val2 = 15;
	//float fval3 = 10.5;
	//auto result1 = val2 + fval3;

	//cout << "result :" << result1 << " "<< typeid(result1).name() << endl;

	//int val4 = 5;
	//unsigned int unval1 = 8;
	//auto result2 = val4 - unval1;

	//cout << "result :" << result2 << " " << typeid(result2).name() << endl;


	//
	//unsigned int balance;
	//balance = 130;

	//int pay;

	//cout << "pay : ";
	//cin >> pay;

	//if (balance - pay < 0) {
	//	cout << "Error";
	//}
	//else {
	//	balance = balance - pay;
	//	cout << "Success"<<endl;
	//	cout << "New Balace : " << balance;
	//}

	//double doubleVal = 36.6;
	//int intVal ;


	//intVal = doubleVal;
	//intVal = (int)doubleVal;
	//intVal = static_cast<int>(doubleVal);
	//cout << intVal;

	//int val = 10;
	//printInt(&val);
	//cout << val << endl;

	//A objectA;  // Class A object
	//A *pObjectA = new A(); // Pointer to Class A
	//B objectB; // Class B object
 //   B *pObjectB = new B();// Pointer to Class B


	//pObjectA = dynamic_cast<A*>(pObjectB);
	//pObjectB = dynamic_cast<B*>(pObjectA);


	//int val = 10;
	//int* pVal = &val;
	//cout << pVal<<endl;


	//int value = reinterpret_cast<int>(pVal);
	//cout << value << endl;


	//string text = "Hello World";
	//long long longText = reinterpret_cast<long long>(&text);
	//cout << longText << endl;


	int* pVal = new int(10);

	float* fPval;

	fPval = reinterpret_cast<float*>(pVal);
	cout << *fPval << endl;

}

