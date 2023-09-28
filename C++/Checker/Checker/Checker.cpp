#include <iostream>
#include <stdlib.h>
#include <time.h>
using namespace std;


int numPower(int num, int pow) {

    if (pow == 1) {
        return num;
    }

    return num * numPower(num, pow - 1);

}


void printStar(int count) {
    cout << "*";
    if (count == 1) {
        return;
    }

    printStar(count - 1);
}

int main()
{
    cout << numPower(4, 3)<<endl;
    printStar(6);
}
