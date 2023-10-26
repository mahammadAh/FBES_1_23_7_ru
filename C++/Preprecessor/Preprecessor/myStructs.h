#pragma once


#include<iostream>
#include "myMath.h"

	using namespace std;


	struct Human {
	private:
		int age;
		char pol;
		const char* name;
	public:
		Human() {

		}
		Human(int age, char pol, const char* name) {
			this->age = age;
			this->pol = pol;
			this->name = name;
		}

		void ChangeName(const char* name) {
			this->name = name;
		}

		void ChangeAge(int age) {
			this->age = age;
		}

		void ChangePol(char pol) {
			this->pol = pol;
		}

		void printInfo() {
			cout << "Name : " << name << endl;
			cout << "Pol : " << pol << endl;
			cout << "Age : " << age << endl;
		}
	};
