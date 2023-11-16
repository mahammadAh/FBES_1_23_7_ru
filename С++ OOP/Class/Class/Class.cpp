#include <iostream>

using namespace std;

const int nameLength = 20;
const int marksCount = 5;


class Student {
private:
    char name[nameLength];
    int marks[marksCount];
public:
    void setStudentName(const char name[nameLength]) {
        if (name[0] >= 65 && name[0] <= 90) {
            strcpy_s(this->name, 20, name);
         }
        else {
            cout << "WARNING --- INCORRECT NAME FORMAT !!! --- WARNING "<< endl<<endl<<endl;
        }
    }

    void addStudentMarks(int marks[]) {
        for (int i = 0; i < marksCount; i++) {
            this->marks[i] = marks[i];
        }
    }


    void printStudentInfo() {
        cout << "Student Name : " << this->name << endl;
        cout << "Student Marks : ";

        for (int i = 0; i < marksCount; i++) {
            cout << this->marks[i] << " ";
        }
        cout << endl;
    }


    void averageStudentMarks() {
        cout << "Student Name : " << this->name << endl;

        float marksSumm = 0;

        for (int i = 0; i < marksCount; i++) {
            marksSumm += this->marks[i];
        }

        cout << "Student Average Mark : " << marksSumm / marksCount;

        cout << endl;
    }

};




class Teacher {
private:
    char name[nameLength];
    int workHours=0;
    float hourSallary=0;
public:
    void setTeacherName(const char name[nameLength]) {
        strcpy_s(this->name, 20, name);
    }

    void addWorkHours(int hours, bool add = false) {
        if (!add) {
            this->workHours += hours;
        }
        else  this->workHours = hours;
    }

    void addWorkHourSallary(int hourSallary, bool add = false) {
        if (!add) {
            this->hourSallary += hourSallary;
        }
        else this->hourSallary = hourSallary;
    }

    void printTeacherInfo() {
        cout << "Teacher Name : " << name << endl;
        cout << "Teacher Works Hours : " << workHours << endl;
        cout << "Teacher Hour Sallary : " << hourSallary << endl;
        cout << endl;
    }

    void printTeacherMonthlySallary() {
        cout << "Teacher Name :" << name << endl;
        cout << "Teacher Monthly Sallary :" << workHours * hourSallary << endl;
        cout << endl;
    }

};







int main()
{
    Student student1,student2;

    student1.setStudentName("elnur");
    int marks1[marksCount] = { 8,9,6,11,7 };

    student1.addStudentMarks(marks1);

    student2.setStudentName("Anvar");
    int marks2[marksCount] = { 7,12,12,8,9};
    student2.addStudentMarks(marks2);


    student1.printStudentInfo();
    cout << endl ;
    student2.printStudentInfo();

    cout << endl << endl;
    student1.averageStudentMarks();
    cout << endl ;
    student2.averageStudentMarks();
    cout << endl;

    Teacher teacher1,teacher2;

    teacher1.setTeacherName("Anar");
    teacher1.addWorkHours(160, false);
    teacher1.addWorkHourSallary( 12, false);
    teacher1.printTeacherInfo();
    teacher1.printTeacherMonthlySallary();

    cout << endl;

    teacher2.setTeacherName("Natiq");
    teacher2.addWorkHours(120, false);
    teacher2.addWorkHourSallary(15, false);
    teacher2.printTeacherInfo();
    teacher2.printTeacherMonthlySallary();


    setlocale(LC_ALL, "ru");

    cout << "Привет мир !" << endl;

     
}




