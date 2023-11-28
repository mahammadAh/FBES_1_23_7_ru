#include <iostream>
#include <time.h>
#include <stdlib.h>

using namespace std;

class Weather {
    int temperature{10};
    float windSpeed{12};
    float humidity{23};
    const int pressure ;
public:
    Weather() : pressure{0} {

    }

    Weather(int temperature, float windSpeed, float humidity, int pressure) :
        temperature{ temperature }, windSpeed{ windSpeed }, humidity{ humidity }, pressure{ pressure } {
       
    }

    void setTemperature(int temperature) {
        this->temperature = temperature;
    }

    int getTemperature()  {
        temperature += 5;
        return temperature;
    }

    int getTemperature() const {
        //temperature += 5;
        return temperature;
    }


    void setWindSpeed(float windSpeed) {
        this->windSpeed = windSpeed;
    }

    float getWindSpeed() const {
        return windSpeed;
    }

    void setHumidity(float humidity) {
        this->humidity = humidity;
    }

    float getHumidity() const {
        return humidity;
    }

};



class Array {
    int size;
    int* pArr;
    int val;
public:
    explicit Array(int size)  {
        pArr = new int[size];
        this->size = size;
    }

    void addValueByIndex(int index , int value) {
        if (index < size) {
            pArr[index] = value;
        }
    }

    int getSize() const {
        return size;
    }

    int getByIndex(int index) const {
        return pArr[index];
    }
};


void printArrayData(const Array& arr) {
    for (int i = 0; i < arr.getSize(); i++) {
        cout << arr.getByIndex(i) << " ";
    }
}


int main()
{
    //Weather sunny(32, 5, 30,4);

    //cout << "Sunny" << endl;
    //cout << sunny.getTemperature() << endl;
    //cout << sunny.getWindSpeed() << endl;
    //cout << sunny.getHumidity() << endl;

    //int val = 4;

    //const int constVal = 5;

    //const Weather cloudy(15, 10, 50,10);

    //cout << "Cloudy" << endl;
    //cout << cloudy.getTemperature() << endl;
    //cout << cloudy.getWindSpeed() << endl;
    //cout << cloudy.getHumidity() << endl;

    
    Array arr(5);

    srand(time(NULL));

    for (int i = 0; i < arr.getSize(); i++) {
        arr.addValueByIndex(i, rand() % 10);
    }


    printArrayData(arr);

    cout << endl;

    

    printArrayData(3);

}

