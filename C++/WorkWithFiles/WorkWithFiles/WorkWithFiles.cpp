#include <iostream>

using namespace std;


void addDataToFile(FILE* file, bool isEnd = false) {
    fopen_s(&file, "C:\\Users\\ahmadov_m\\Desktop\\our folder\\data.txt", "a");

    if (isEnd) {
        fprintf_s(file, "%s", "$");
    }
    else {
        const int nameSize = 20;
        char name[nameSize];
        int age;
        cout << "Enter Student Name -> ";
        cin.ignore();
        cin.getline(name, nameSize);
        cout << "Enter Student Age -> ";
        cin >> age;
        fprintf_s(file, "%s %i\n", name, age);
    }

    fclose(file);
}


void readDataFromFile(FILE* file) {
 
    fopen_s(&file, "C:\\Users\\ahmadov_m\\Desktop\\our folder\\data.txt", "r");
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

}

int main()
{

    FILE* myFile =  nullptr;

   // fopen_s(&myFile,"C:\\Users\\ahmadov_m\\Desktop\\our folder\\data.txt", "r");
    
    //int value;

    //char text1[15];
    //char text2[15];


    //fscanf_s(myFile, "%i", &value);
    //cout << value;

 /*   fscanf_s(myFile, "%s %s", text1, sizeof(text1),text2, sizeof(text2));

    cout << text1 << endl;
    cout << text2 << endl;*/


    //char studentName[20];
    //int age ;

    //while (true) {
    //    fscanf_s(myFile, "%s %i", studentName, sizeof(studentName), &age);
    //    if (studentName[0] == '$' && studentName[1] == 'e' && studentName[2] == 'n' && studentName[3] == 'd') {
    //        break;
    //    }
    //    cout << "Name : " << studentName << "\t";
    //    cout << "Age : " << age << endl;
    //}

    //fclose(myFile);


  /*  fopen_s(&myFile,"C:\\Users\\ahmadov_m\\Desktop\\our folder\\data.txt", "w");

    const char* text = "hello";

    fprintf_s(myFile, "%s", text, sizeof(text));*/


    //const char* text = "step";

    //fprintf_s(myFile, "%s ", text, sizeof(text));



    int select;
    while (true) {
        cout << "1.Add Student\n 2.Exit" << endl;
        cin >> select;
        if (select == 1) {
            addDataToFile(myFile);
        }
        else {
            bool isEnd = true;
            addDataToFile(myFile, isEnd);
            break;
        };
    }


   readDataFromFile(myFile);




}


