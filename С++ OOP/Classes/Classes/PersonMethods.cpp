#include "Person.h"

#pragma once

int gbDay = 19;
int gbMonth = 11;
int gbYear = 2023;

void Person::setBirthDate(int year, int month, int day) {
    if (gbMonth > month || (gbMonth == month && gbDay >= day)) {
        age = gbYear - year;
    }
    else {
        age = (gbYear - year) - 1;
    }
}