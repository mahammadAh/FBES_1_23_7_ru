#define SQR(X) ((X) * (X))
#define CUBE(X) ((X) * (X) * (X))
#include <iostream>

using namespace std;


//inline void numberManipulation(int num1, int num2) {
//    if (num1 > num2) {
//        num1 = num1 * num1;
//        cout << num1;
//    }
//    else if (num2 > num1)
//    {
//        num2 = num2 * num2;
//        cout << num2;
//    }
//    else {
//        cout << num1 * num2;
//    }
//}


long arraySum(int size, int arr[]) {
    cout << "1 overload" << endl;
    int sum = 0;
    for (int i = 0; i < size; i++)
    {
        sum += arr[i];
    }

    return sum;
}

long arraySum(int size, long arr[]) {
    cout << "2 overload" << endl;
    int sum = 0;
    for (int i = 0; i < size; i++)
    {
        sum += arr[i];
    }

    return sum;
}

long arraySum(int size, long arr[],int num ) {
    cout << "3 overload" << endl;
    int sum = 0;
    for (int i = 0; i < size; i++)
    {
        sum += arr[i]*num;
    }

    return sum;
}

int main()
{
    //numberManipulation(7, 18);
    //cout << endl;
    //numberManipulation(12, 8);
    //cout << endl;
    //numberManipulation(11, 11);



    // Раскрытие макроса -- Деректива предпроцессора 
    //int t = 5;
    //cout << SQR(t + 2); // ((t + 2) *( t + 2)) = > ((7)*(7)) => 49
    //cout << endl;
    //cout << CUBE(t + 3 + 3); // ((t + 3 + 3) * (t + 3 + 3) * (t + 3 + 3)) => ((11)*(11)*(11))=> 1331
    int const size = 10;
    int arr[size] = { 5,6,3,7,1,3,5,12,2,8};
    long arr1[size] = { 223,45,2345,234,687,98,23,6,68,157 };
    int result;
    result = arraySum(size, arr);
    cout << result<<endl;
    result = arraySum(size, arr1);
    cout << result << endl;
    result = arraySum(size, arr1,5);
    cout << result << endl;



}

