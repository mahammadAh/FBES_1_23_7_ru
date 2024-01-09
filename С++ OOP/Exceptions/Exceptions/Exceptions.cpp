#include <iostream>
#include <vector>
#include <format>
using namespace std;


//int arr[] = { 10,3,0,15,7 };

vector<int> _vector{10, 3, 0, 15, 7};


int getNumb(int index) {
    return _vector.at(index);
}

int divide(int x, int y) {
    if (y != 0) {
        return x / y;
    }
    else {
        throw invalid_argument("Divide Zero Error !");
    }

}



class login_exception : public exception {
    string desctription;
public:
    login_exception(char const* const message) : exception (message) {}

    void SetDescrption(string desctription) {
        this->desctription = desctription;
    }

    string GetDescrption() {
        return desctription;
    }

    char const* what() const override {
        cout << exception::what() << endl;
        cout << desctription << endl;
        return nullptr;
    }
};


void signIn(string login, string pass) { 
    if (login.size() <= 5 || login.size() >= 20) {
        login_exception ex("Incorrect Login Size");
        ex.SetDescrption(std::format("Login size must be between 5 and 20 symbols : Your login size is {} symbols",login.size()));
        throw ex;
    }

    if (login.find('!') != string::npos) {
        login_exception ex("Incorrect symbol '!'");
        ex.SetDescrption("Login can not has symbol '!' in context");
        throw ex;
    }


}


int main()
{
   /* try {
        int num1 = getNumb(3);
        cout << "First num : " << num1 << endl;
        int num2 = getNumb(2);
        cout << "Second num : " << num2 <<endl;
        cout << divide(num1, num2) << endl;
    }
    catch (invalid_argument& invArgEx) {
        cout << invArgEx.what() << endl;
    }
    catch (out_of_range& outEx) {
        cout << outEx.what();
    }
   catch (exception ex) {
        cout << ex.what() << endl;
    }*/



    try {
        signIn("stepItACADEMYc++PythonCsharp1234567", "12345");
    }
    catch (login_exception& ex) {
        ex.what();
        // log file -> ex.GetDescription();
        //cout << ex.GetDescrption() << endl;
    }
  
}

