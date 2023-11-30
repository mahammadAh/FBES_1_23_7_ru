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
};


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

    printPoint(point1,1);
    printPoint(point2,2);
    printPoint(point3,3);

    Point point4 = point1 + point2;

    printPoint(point4,4);

    Point point5 = !point4;

    printPoint(point5,5);

    Point point6 = point2 - point1;

    printPoint(point6,6);

    Point point7 = !point6;

    printPoint(point7, 7);

    Point point8 = ++point7;

    printPoint(point8, 8);

    Point point9 = point8++;

    printPoint(point9, 9);

    printPoint(point8, 8);

    Point point10 = point9 - point6;
    
}


