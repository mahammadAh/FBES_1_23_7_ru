#include <iostream>

using namespace std;


class Color {
    char* name{ nullptr };
    short R;
    short G;
    short B;
public:
    Color() {

    }
    Color(const char* name, short R, short G, short B) : R { R }, G{ G }, B{ B } {
        this->name = new char[strlen(name) + 1];
        strcpy_s(this->name, strlen(name)+1, name);
    }


    Color& operator= (const Color& color) {
        cout << "overloading = " << endl;
        if (this == &color) return *this;

        this->R = color.R;
        this->G = color.G;
        this->B = color.B;
        this->name = new char[sizeof(name) + 1];
        strcpy_s(this->name, sizeof(name) + 1, name);

        return *this;

    }

    char* getName() {
        return name;
    }
};

int main()
{
    Color green("green", 0, 255, 0);
    Color blue("blue", 0, 0, 255);

    cout << green.getName()<<endl;
    cout << blue.getName()<< endl;

    Color newColor = green;

    cout << newColor.getName() << endl;

    green.getName()[0] = 'G';

    cout << green.getName() << endl;

    cout << newColor.getName() << endl;
}


