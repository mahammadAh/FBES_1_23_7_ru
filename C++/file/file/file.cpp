#include <iostream>

using namespace std;


void readDataFromFile(FILE* file) {

    fopen_s(&file, "data.txt", "r");
    char name[20];
    int age;
    while (true) {
        fscanf_s(file, "%s %i", name, sizeof(name), &age);
        if (name[0] == '$') {
            break;
        }
        cout << "Student Name : " << name << "\t\t";
        cout << "Student Age : " << age << endl;

    }
    fclose(file);

}

int main()
{
    FILE* myFile = nullptr;


    //fopen_s(&myFile, "data.txt", "r");

    //int firstValue;


    //fscanf_s(myFile, "%i", &firstValue);

    //cout << "firstValue -> " << firstValue << endl;


   readDataFromFile(myFile);
    int n;
    cin >> n;



  



}


