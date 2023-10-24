#include <iostream>


using namespace std;


struct Date {
private:
    int year;
    int month;
    int day;
public:

    void SetDate(int day, int month, int year) {
        if (day > 0 && day <= 31) {
            this->day = day;
        }
        if (month > 0 && month <= 12) {
            this->month = month;
        }

        this->year = year;
    }

    void printDate() {
        cout << day << "." << month << "." << year ;
    }
};

struct Time {
private:
    int hour;
    int minute;
    int second;
public:
    void SetTime(int second, int minute, int hour) {
        if (second > 0 && second <= 60) {
            this->second = second;
        }
        if (minute > 0 && minute <= 60) {
            this->minute = minute;
        }
        if (hour > 0 && hour <= 24) {
            this->hour = hour;
        }
    }

    void printTime() {
        cout << hour << ":" << minute << ":" << second;
    }
};


struct DateTime {
private:
    Date date;
    Time time;
public:
    void SetDateTime(int day, int month, int year, int second, int minute, int hour) {
        date.SetDate(day, month, year);
        time.SetTime(second, minute, hour);
    }

    void PrintDateTime() {
        date.printDate();
        cout << " ";
        time.printTime();
    }

};



struct Car {
    const char* brend;
    const char* model;
    const char* color;
    float engine;
    Date madeDate;

    void printInfo() {
        cout << "Brend : " << brend << endl;
        cout << "Model : " << model << endl;
        cout << "Color : " << color << endl;
        cout << "Engine : " << engine << endl;
        cout << "Made Date : ";
        madeDate.printDate();
        cout << endl;
   }
};


struct ClassRoom {
    short num2;
    char  sym1, sym2, sym3;
    long double number;
    float num3;
    char sym4;
    int num1;
};


int main()
{
    /*Date today;
    today.SetDate(22, 10, 2023);

    Time now;
    now.SetTime(46, 34, 19);

    today.printDate();
    cout << " ";
    now.printTime();


    cout << endl << endl;


    Car myCar;

    myCar.brend = "Ford";
    myCar.model = "Raptor";
    myCar.color = "Grey";
    myCar.engine = 4.5;
    myCar.madeDate.SetDate(28, 5, 2021);


    myCar.printInfo();*/


    //DateTime now;

    //now.SetDateTime(22, 10, 2023, 34, 54, 19);
    //now.PrintDateTime();

    //int num = 10;
    //double num1 = 10.0;
    //cout << sizeof(num1);

    //ClassRoom room_2D;

    //cout <<endl << "room_2D : "<< sizeof(room_2D);

    Car *myCar = new Car;
    


    (*myCar).brend = "Ford";
    (*myCar).model = "Raptor";
    (*myCar).color = "Grey";
    (*myCar).engine = 4.5;
    (*myCar).madeDate.SetDate(28, 5, 2021);


    (*myCar).printInfo();
  
}




