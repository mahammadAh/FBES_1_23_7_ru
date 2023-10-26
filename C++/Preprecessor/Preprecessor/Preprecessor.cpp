//#define myMax 100
//#define myMin 10
//
//
//
//#define myMessage "error message"

#include <iostream>
#include "myMath.h"
#include "myStructs.h"


using namespace std;

int main()
{
//#if 0
//	for (int i = myMin; i < myMax; i++) {
//		cout << i << endl;
//	}
//#endif
//
//	if (1) {
//		for (int i = myMin; i < myMax; i++) {
//			cout << i << endl;
//		}
//	}
//
//#undef myMin 
//
//		if (1) {
//		for (int i = myMin; i < myMax; i++) {
//			cout << i << endl;
//		}
//	}



	myMathStruct math;

	auto result = math.sum(1, 2);
	cout << result<<endl;

	 result = math.deleniye(10, 0);
	cout << result << endl;

	Human student(14, 'M', "Student");

	student.printInfo();


}

