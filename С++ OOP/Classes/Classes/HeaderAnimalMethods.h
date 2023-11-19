#include "Animal.h"

#pragma once

void Animal::setLegCount(int legCount) {
	if (legCount >= 2 && legCount <= 4) {
		this->legCount = legCount;
	}
}

void Animal::calculateSpeed(int duration , int distant){
	this->speed = distant / duration;
}
