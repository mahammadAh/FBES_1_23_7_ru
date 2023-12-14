#include <iostream>
#include <stack>

using namespace std;


template<typename T>
class iStack {
    T* arr;
    int size;
    int index{-1};
public:
    iStack() : size {100} {
        arr = new T[size];
    }

    iStack(int size) : size{ size } {
        arr = new T[size];
    }

    int isize() {
        return (index + 1);
    }

    void ipush(T value) {
        index++;
        arr[index] = value;
    }

    void ipop() {
        index--;
        //arr[index] = NULL;
    }

    T& itop() {
        T el = arr[index];
        return el;
    }

    bool iempty() {
        if (index<0) {
            return true;
        }
        else return false;
    }

    ~iStack() {
        delete[] arr;
    }
};


int main()
{
 /*   iStack<int> myStack(50);

    myStack.ipush(30);
    myStack.ipush(40);
    myStack.ipush(50);
    myStack.ipush(60);
    myStack.ipush(70);

    myStack.ipop();

    myStack.ipush(80);

    while (true) {
        if (myStack.iempty()) {
            break;
        }

        cout << myStack.itop() << " ";
         myStack.pop();
    }*/


    std::stack<int> orgStack;

   // cout << orgStack.size();

    orgStack.push(10);
    orgStack.push(20);
    orgStack.push(30);
    orgStack.push(40);
    orgStack.emplace(50);
    orgStack.pop();
    orgStack.push(60);
    orgStack.emplace(70);


    while (true) {
        if (orgStack.empty()) {
            break;
        }

        cout << orgStack.top() << " ";
        orgStack.pop();
    }

}

