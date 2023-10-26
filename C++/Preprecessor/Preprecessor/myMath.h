#pragma once

struct myMathStruct {
public:
	double sum(double firstValue, double secondValue) {
		return (firstValue + secondValue);
	}

	double raznost(double firstValue, double secondValue) {
		return (firstValue - secondValue);
	}

	double proizdenie(double firstValue, double secondValue) {
		return (firstValue * secondValue);
	}

	double deleniye(double firstValue, double secondValue) {
		if (secondValue == 0) {
			return 0;
		}

		return (firstValue / secondValue);
	}

};