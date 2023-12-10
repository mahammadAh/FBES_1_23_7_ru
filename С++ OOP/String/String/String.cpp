#include <iostream>
#include <string>
#include <vector>

using namespace std;


template<typename T>
ostream& operator<<(ostream& output ,const vector<T>& _vector) {
    for (T el : _vector) {
        output << el << " ";
    }
    return output;
}


int main()
{
    //string str1 = "Hello";
    //string str2("World");

    //cout << str1<<endl;

    //string str3;

    //cin >> str3;

    //getline(cin, str3);

    //cout << str3;


    //string str1;  char ch1;
    //wstring wstr1; wchar_t wch1;
    //u16string u16str1; char16_t ch16t;
    //u32string u32str1; char32_t ch32t;

    // basic_string<string> str ;


    string text = R"&&(Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor
incididunt ut labore et dolore magna aliqua.Ut enim ad minim veniam, quis nostrud exercitation
ullamco laboris nisi ut aliquip ex ea commodo consequat.Duis aute irure dolor in reprehenderit
in voluptate velit esse cillum dolore eu fugiat nulla pariatur.Excepteur sint occaecat cupidatat
non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.)&&";


    //text.clear();
    
    //cout << text.size()<<endl;
    //cout << text.capacity() << endl;

    text.append(" Pariatur ");

    //cout << text.size() << endl;
    //cout << text.capacity() << endl;

 
    //string textCopy = text;

    //text.append("culpa.");
    //cout << textCopy << endl;



    //char* textCopy = new char[text.size()];
    //text._Copy_s(textCopy, text.size(), text.size());

    //cout << textCopy;

  /*  string textCopy = text;

    if (text.compare(textCopy)==0) {
        cout << "textCopy == text "<<endl ;
    }

    if (!text.empty()) {
        cout << "not empty";
    }

    text.begin();
    text.end();

    for (auto el = text.begin(); el != text.end(); el++) {
        cout << *el;
    }*/

    //cout << text.size() << endl;
    //cout << text.length() << endl;

    //vector<string> passNoArr = { "AZE123456","AZE2778394","UA8349935","LT999934D" };

    //for (string el : passNoArr) {
    //    if (el._Starts_with("AZE")) {
    //        cout << el << endl;
    //    };
    //}

    //string str1 = "STEP";
    //string str2 = "IT";

    //string str3 = str1 + " " + str2;

    //cout << str3 << endl;

    //string str4 = "HELLO";

    //str4 += " " + str3;

    //cout << str4;


    //string pinCode = "6738";

    //int pinCodeInt = stoi(pinCode);

    //cout << pinCodeInt << endl;

    //string textCopy = text;
    ////text.at(0) = 'l';

    //cout << text._Equal(textCopy)<<endl;

    //cout << (textCopy == text);


    vector<int> intArr = { 10,15,20,25 };

    //for (int el : intArr) {
    //    cout << el << " ";
    //}

    //cout << endl;

    //for (auto el = intArr.begin(); el != intArr.end(); el++) {
    //    cout << *el << " ";
    //}

    cout << intArr;

    //string text1;


}

