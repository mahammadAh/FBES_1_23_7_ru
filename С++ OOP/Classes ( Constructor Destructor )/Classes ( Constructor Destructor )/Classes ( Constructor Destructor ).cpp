#include <iostream>

using namespace std;

enum MarketType {
    PRODUCTS = 1,
    CONSTRUCTIONS = 2,
    CLOTHERS = 3,
    TOYS = 4
};

enum WorkPosition {
    CASHIER = 1,
    MANAGER = 2,
    SECURITY = 3,
    CONSULTANT = 4
};


struct Time {
private:
    int hour, minutes;
public:

    Time() {

    }

    Time(int hour, int minutes) {
        this->hour = hour;
        this->minutes = minutes;
    }

    void setTime(int hour, int minutes) {
        this->hour = hour;
        this->minutes = minutes;
    }

    int getHour() {
        return hour;
    }

    int getMinutes() {
        return minutes;
    }
};

class Employee {
    char name[20];
    int salary;
    WorkPosition position;
public:

    Employee() {

    }


    Employee(const char* name , int salary , WorkPosition position) {
        strcpy_s(this->name, sizeof(this->name), name);
        this->salary = salary;
        this->position = position;

    }

    void setName(const char* name) {
        strcpy_s(this->name, sizeof(this->name), name);
    }

    const char* getName() {
        return name;
    }

    void setSalary(int salary) {
        this->salary = salary;
    }

    int getSalary() {
        return salary;
    }


    void setWorkPosition(WorkPosition position) {
        this->position = position;
    }

    WorkPosition getWorkPosition() {
        return position;
    }


};


class Market {
    char name[20];
    char address[100];
    float sqr;
    MarketType type;
    Time open;
    Time close;
    int employeeCount = 0;
    Employee* employees  = new Employee[employeeCount];

public:

    Market() {
        
    }

    Market(const char* name, const char* address, float sqr, MarketType type,
           int OpeningHour, int OpeningMinutes, int ClosingHour, int ClosingMinutes) {

        strcpy_s(this->name, sizeof(this->name), name);
        strcpy_s(this->address, sizeof(this->address), address);
        this->sqr = sqr;
        this->type = type;
        this->open.setTime(OpeningHour, OpeningMinutes);
        this->close.setTime(ClosingHour, ClosingMinutes);

        
    }

    void setName(const char* name) {
        strcpy_s(this->name, sizeof(this->name), name);
    }

    const char* getName() {
        return name;
    }

    void setAddress(const char* address) {
        strcpy_s(this->address, sizeof(this->address), address);
    }

    const char* getAddress() {
        return address;
    }

    void setSqr(float sqr) {
        this->sqr = sqr;
    }

    float getSqr() {
        return sqr;
    }

    void setMarketType(MarketType type) {
        this->type = type;
    }

    MarketType getMarketType() {
        return type;
    }

    void setOpeningTime(int hour , int minutes) {
        this->open.setTime(hour, minutes);
    }

    Time getOpeningTime() {
        return open;
    }

    void setClosingTime(int hour, int minutes) {
        this->close.setTime(hour, minutes);
    }

    Time getClosingTime() {
        return close;
    }

    void addEmployee(Employee employee);

    Employee getEnmployeeByIndex(int index) {
        return this->employees[index];
    }

    int getEmployeeCount(){
        return employeeCount;
    }

    ~Market() {
        employeeCount = 0;
        delete[] employees;
    }
    
};


void Market::addEmployee(Employee employee) {
    employeeCount++;

    Employee* newEmployees = new Employee[employeeCount];

    for (int i = 0; i < employeeCount - 1; i++) {
        newEmployees[i] = this->employees[i];
    }

    newEmployees[employeeCount - 1] = employee;

    delete[] employees;
    employees = newEmployees;
    newEmployees = nullptr;
}



class PrintToConsole {
public:
    void printMarket(Market& market);

};

void PrintToConsole::printMarket(Market& market) {
    cout << "Name : " << market.getName() << endl;
    cout << "Address : " << market.getAddress() << endl;
    cout << "sqr : " << market.getSqr() << endl;
    
    cout << "Type : ";
    switch (market.getMarketType()) {
    case 1:
        cout << "products";
        break;
    case 2:
        cout << "construction";
        break;
    case 3:
        cout << "clothers";
        break;
    case 4:
        cout << "toys";
        break;
    }
    cout << endl;

    
    cout << "Openning : " << market.getOpeningTime().getHour() << " : " << market.getOpeningTime().getMinutes() << endl;
    cout << "Cloussing : " << market.getClosingTime().getHour() << " : " << market.getClosingTime().getMinutes() << endl;

    cout << "Employees : " << endl;
    int employeesCount = market.getEmployeeCount();
    for (int i = 0; i < employeesCount; i++) {
        cout << "\t(" << (i + 1) << ")"<<endl;
        cout << "\t Name : " << market.getEnmployeeByIndex(i).getName() << endl;
        cout << "\t Salary : " << market.getEnmployeeByIndex(i).getSalary() << endl;
        cout << "\t Position : ";
        switch (market.getEnmployeeByIndex(i).getWorkPosition()) {
        case CASHIER:
            cout << "cashier";
            break;
        case MANAGER:
            cout << "manager";
            break;
        case SECURITY:
            cout << "security";
            break;
        case CONSULTANT:
            cout << "consultant";
            break;

        }
        cout << endl;
    }
   cout << endl;
}


int main()
{
    Market BravoYasamal("bravo", "231-233 Abbas Mirza Sharifzade kucesi, Baki 1122", 150, PRODUCTS,9,0,23,0);


    BravoYasamal.addEmployee(Employee("Natiq", 200, CONSULTANT));

    BravoYasamal.addEmployee(Employee("Kamran", 1200, MANAGER));

    BravoYasamal.addEmployee(Employee("Aysel", 450, CASHIER));
    
    
    Market BazarstoreDernegul("bazarstore", "Acami Naxcıvani", 225, PRODUCTS,8,0,22,0);


    BazarstoreDernegul.addEmployee(Employee("Tofiq", 550, CASHIER));

    BazarstoreDernegul.addEmployee(Employee("Sabina", 800, MANAGER));

    BazarstoreDernegul.addEmployee(Employee("Asif", 330, SECURITY));


    Market Santral("santral", "13 Hüseyn Cavid Prospekti", 890, CONSTRUCTIONS,10,0,19,0);



    Santral.addEmployee(Employee("Nazim", 620, MANAGER));

    Santral.addEmployee(Employee("David", 150, SECURITY));

    Santral.addEmployee(Employee("Farman", 240, CONSULTANT));





    PrintToConsole console;

    console.printMarket(BravoYasamal);
    console.printMarket(BazarstoreDernegul);
    console.printMarket(Santral);

    
    Market* oba = new Market("oba", "mikrarayon", 50, PRODUCTS, 9, 30, 23, 30);
    oba->addEmployee(Employee("Sevinc", 150, CASHIER));
    oba->addEmployee(Employee("Aynur", 100, CONSULTANT));

    delete oba;
    
}



