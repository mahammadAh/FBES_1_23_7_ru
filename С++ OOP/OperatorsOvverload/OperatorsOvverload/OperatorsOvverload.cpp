#include <iostream>

using namespace std;

class Point {
    int x{0};
    int y{0};
public:
    Point() {

    }

    Point(int x, int y) : x{ x }, y{ y } {

    }

    void setX(int x) {
        this->x = x;
    }

    int getX() {
        return x;
    }

    void setY(int y) {
        this->y = y;
    }

    int getY() {
        return y;
    }

    friend Point operator+(const Point& point1, const Point& point2);

    Point operator-(const Point& point) {
        return Point(this->x - point.x, this->y - point.y);
    }

    Point operator!() {
        return Point(0 - this->x, 0 - this->y);
    }

    Point operator++() {
        this->x++;
        this->y++;

        return Point(this->x,this->y);
    }

    Point operator++(int) {
        this->x++;
        this->y++;

        return Point((this->x-1), (this->y-1));
    }


    friend ostream& operator<<(ostream& _ostream, const Point& point);

    friend istream& operator>>(istream& _istream, Point& point);


};


ostream& operator<<(ostream& _ostream,const Point& point ) {
     _ostream<< "( " << point.x << "," << point.y << " )";
    return _ostream;
}

istream& operator>>(istream& _istream, Point& point) {
    _istream >> point.x;
    _istream >> point.y;
    return _istream;
}


//Point operator+ (Point& point1, Point& point2) {
//    return Point(point1.getX() + point2.getX(), C + point2.getY());
//}

Point operator+(const Point& point1, const Point& point2) {
    return Point(point1.x + point2.x, point1.y + point2.y);
}

//Point operator!(Point& point) {
//    return Point(0 - point.getX(), 0 - point.getX());
//}



void printPoint( Point& point, int num) {
    cout << num <<"\t( "<<point.getX() << "," << point.getY() << " )"<< endl;
}



int main()
{
    //int a = 5;
    //int b = 6;
    //int c;
    //c = a + b;

    //cout << c;


    Point point1(1, 1);
    Point point2(3, 3);

    Point point3(point1.getX() + point2.getX(), point1.getY() + point2.getY());

    cout << point1 << endl << point2 << endl << point3;

    Point point4 = point1 + point2;

    cout << point4 << endl;

    Point point5 = !point4;

    cout << point5 << endl;

    Point point6 = point2 - point1;

    cout << point6 << endl;
    Point point7 = !point6;

    cout << point7 << endl;

    Point point8 = ++point7;

    cout << point8<<endl;

    Point point9 = point8++;

    cout << point9 << endl;

    cout << point8 << endl;

    Point point10 = point9 - point6;


    
    cout << point10 << endl;

    cin >> point10;

    cout << point10 << endl;


    int a = 5;
    cout << a;
    cin >> a;

    // << >> 
    
}


