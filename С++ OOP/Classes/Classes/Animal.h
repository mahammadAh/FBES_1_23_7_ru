#pragma once


// мутатор ( set - функции )

//  аксессоры , инспекторы ( get - функции ) 
 
class Animal {
	int legCount;
	int speed;
	int age;
public:

	void setLegCount(int legCount) {
		if (legCount < 0) {
			this->legCount = 0;
		}
		else {
			this->legCount = legCount;
		}
	}



	void calculateSpeed(int duration, int Distant);

	int getSpeed() {
		return speed;
	}
};

