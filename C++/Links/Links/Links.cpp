#include <iostream>

using namespace std;


void swapptr(int* num1, int* num2) {
	int temp;
	temp = *num1;
	*num1 = *num2;
	*num2 = temp;
}

void swaplnk(int& num1, int& num2) {
	int temp;
	temp = num1;
	num1 = num2;
	num2 = temp;
}

int& changeElements(int arr[][10], int index) {
		return arr[1][index];
}

int main()
{
	// константный указатель - нельзя менять ссылку можно менять значение 
	//int val1 = 10;

	//int* pVal1 = nullptr;
	//
	//pVal1 = &val1;
	//cout << *pVal1<<endl;

	//int val2 = 60;

	//pVal1 = &val2;
	//cout << *pVal1 << endl;

	//int * const constPValue = &val1;
	//cout << *constPValue << endl;

	//constPValue = &val2;
	//cout << *constPValue << endl;

	//*constPValue = 43;
	//cout << *constPValue << endl;

	// указатель на константу 

	//int val1 = 15;

	//const int* constPValue1 = &val1;
	//cout << *constPValue1 << endl;

	//int val2 = 34;

	//constPValue1 = &val2;
	//cout << *constPValue1 << endl;

	//*constPValue1 = 56;


	// константный указатель на константу 
	//const int* const ccPvalue = &val1;
	//ccPvalue = &val2;
	//*ccPvalue = 44;



	// ссылки

	//char sym = 'V';

	//char* pSym = &sym;

	//cout << *pSym << endl;

	//char alhb = 'S';

	//pSym = &alhb;

	//cout << *pSym << endl;

	//int num = 1;

	//int& lNum = num;

	//lNum = 2;


	//cout << "lNum --> adress : " << &lNum <<" value : "<< lNum << endl;
	//cout << "num --> adress  : " << &num << " value : " << num << endl;
	//
	//int num1 = 5;
	//int num2 = 13;

	//swapptr(&num1, &num2);

	//cout << "num1 : " << num1 << endl;
	//cout << "num2 : " << num2 << endl;

	//swaplnk(num1, num2);
	//cout << endl;
	//cout << "num1 : " << num1 << endl;
	//cout << "num2 : " << num2 << endl;

	int arr[2][10];
	int num = 2;

	for (int i = 0; i < 10; i++) {
		arr[0][i] = num;
		changeElements(arr,i) = num;
	}

	for (int i = 0; i < 2; i++) {
		for (int j = 0; j < 10; j++) {
			cout << arr[i][j] << " ";
		}
		cout << endl;	
	}

}


