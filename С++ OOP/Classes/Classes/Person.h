#include <string.h>

#pragma once

    class Person {
    private:
        int age;
        char* name;
    public:

        void setAge(int age) {
            this->age = age;
        }

        void setName(char* name) {
            this->name = name;
        }

        const char* getName()  {
            return name;
        }

        void setBirthDate(int year, int month, int day);

        int getAge() {
            return age;
        }
    };

