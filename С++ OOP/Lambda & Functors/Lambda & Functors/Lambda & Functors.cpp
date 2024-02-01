#include <iostream>
#include <algorithm>
#include <vector>
#include <iterator>
#include <functional>
#include <cassert>
#include <iomanip>
#include <iostream>
#include <string_view>
using namespace std;

bool isMoreThan(int x) {
	return x > 9 ;
}

bool isBetween10and15(int x) {
	return x > 10 && x < 15;
}

bool isBetween16and23(int x) {
	return x > 16 && x < 23;
}

bool isBetweenMinAndMax(int x, int min, int max) {
	return x > min && x < max;
}


class betweenFunctor {
public:
	int min; // 25
	int max; // 34

	betweenFunctor(int min , int max) {
		this->min = min;
		this->max = max;
	}

	bool operator()(int x) {
		return x > min && x < max;
	}

};

enum ItemColor {
	RED,
	YELLOW,
	BLACK,
	GREEN,
	BLUE,
	ORANGE,
	WHITE,
	PINK,
	BROWN,
	PURPLE,
	GRAY
};

class Item {
public:
	string name;
	double weigth;
	double price;
	ItemColor color;

	Item(string name, double weigth, double price, ItemColor color) :
		name{ name }, weigth{ weigth }, price{ price }, color{ color } {

	}

};


int main()
{
	//vector<int> numbers = { 1,15,21,13,17,18 };
	//bool checkResult = false;

	//checkResult = all_of(numbers.begin(), numbers.end(), isMoreThan);
	//cout << "Is more than 9 : " << boolalpha << checkResult << endl;

	//checkResult = any_of(numbers.begin(), numbers.end(), isBetween10and15);
	//cout << "Is between 10 and 15 : " << boolalpha << checkResult << endl;

	//checkResult = any_of(numbers.begin(), numbers.end(), isBetween16and23);
	//cout << "Is between 16 and 23: " << boolalpha << checkResult << endl;

	//checkResult = any_of(numbers.begin(), numbers.end(), betweenFunctor(25,34));
	//cout << "Is between min and max: " << boolalpha << checkResult << endl;

	//betweenFunctor isBetween15and19(15, 19);
	//cout << isBetween15and19(13) <<endl;


	//checkResult = any_of(numbers.begin(), numbers.end(), [](int x) {return x % 2 == 0; });
	//cout << "Is even number in collection : " << boolalpha << checkResult << endl;


	//int min, max;
	//min = 10;
	//max = 15;

	//checkResult = any_of(numbers.begin(), numbers.end(), [min,max](int x) {return x > min && x < max; });
	//cout << "Is between min and max: " << boolalpha << checkResult << endl;



	vector<Item> items;

	items.push_back(Item("Ball", 400, 25, WHITE));
	items.push_back(Item("Mouse", 150, 90, BLACK));
	items.push_back(Item("Pen", 67, 2, RED));
	items.push_back(Item("Laptop", 1200, 4300, GRAY));
	items.push_back(Item("Wallet", 110, 340, GREEN));
	items.push_back(Item("Monitor", 2000, 900, GRAY));


	bool isFound = false;
	for (auto item : items) {
		if (item.name == "Laptop") isFound = true;
	}
	cout << "Is found : " <<boolalpha << isFound << endl;


	isFound = false;
	auto searchLaptop = [](Item x) {return x.name == "Laptop"; };
	isFound = any_of(items.begin(), items.end(), searchLaptop);
	cout << "Is found : " << isFound << endl;

	//ItemColor itemColor = GRAY;
	std::boyer_moore_searcher<ItemColor>  searcher();
	 auto result = std::ranges::search(items.begin(), items.end(), searcher);


}

