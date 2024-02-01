#include <iostream>

using namespace std;


class Gun {
    int power;
public:
    virtual void shot() = 0;
};


class Machinegun : public Gun {
    void shot() {
        cout << "T T T T T T T T" << endl;
    }
};

class Pistol : public Gun {
public:
    void shot() {
        cout << "Ptish Ptish Ptish" << endl;
    }
};



int main()
{
 
    Pistol makar;

    makar.shot();

    Gun* gun1;
    gun1 = &makar;

    gun1->shot();

    Machinegun pulemet;
    Gun* gun2;
    gun2 = &pulemet;
    gun2->shot();
}


