#include <iostream>
#include <set>
#include <map>
#include <tuple>
#include <unordered_map>
#include <unordered_set>
#include <iterator>
#include <algorithm>
using namespace std;

// STL ---> Standart Template Library


// Containers
// vector (2)
// list
// queue
// deque
// stack
// string (1)
// array  ---> lineynie 
// set 
// map (3)

// Iterator
//iterator
//reverse_iteartor
//const_iterator

// Algoritms



tuple<int, string> foo() {
	return { 5,"step" };
}


bool checkValue(int val) {
	return val > 10;
}

bool my_all_of(vector<int>::iterator begin, vector<int>::iterator end, bool(*Predicat)(int)) {
	for (auto iter = begin; iter != end; iter++) {
		if(!Predicat(*iter)) return Predicat(*iter);
	}
	return true;
}

bool isEven(int val) {
	return val % 2 == 0;
}

bool check2value(int val1,int val2) {
	return val1 > val2 ;
}


class MyIterator {
	const int* pVal = NULL;
public:
	MyIterator(const int* pVal) : pVal{pVal}{};

	int* operator++() 
	{ 
		pVal++; 
	};

	const int& operator*()
	{
		return *pVal;
	}

	ostream& operator<<(ostream& out) {
		out << *this->pVal;
		return out;
	}

	bool operator!=(const MyIterator& rhs) const
	{
		return pVal != rhs.pVal;
	}
	bool operator==(const MyIterator& rhs) const
	{
		return pVal == rhs.pVal;
	}

};

class MyArray {
	vector<MyIterator*> arr ;
public:
	void Add(const int& val) {
		arr.push_back(new MyIterator(&val));
	}


	MyIterator* begin() {
		return arr.at(0);
	}

	MyIterator* end() {
		 return arr.at(arr.size() - 1);
	}

};



int main()
{

	//set<int> set = { 83,73,89,11,65,73,101 };

	//for (auto el : set) {
	//	cout << el << " ";
	//}
	//cout << endl;
	//unordered_set<int> unordered_set = { 83,73,89,11,65,73,101 };

	//for (auto el : unordered_set) {
	//	cout << el << " ";
	//}

	//cout << endl << endl << endl;



	//map<int, string> map = { { 25,"Elnur"},{7, "Alyona" }, {1, "Farman" } };

	//for (auto el : map) {
	//	cout << "Key : " << el.first << endl; 
	//	cout << "Value : " << el.second << endl<<endl;
	//}

	//cout <<"<---------------------------------->"<<endl;
	//unordered_map<int, string> unordered_map = { { 25,"Elnur"},{7, "Alyona" }, {1, "Farman" } };

	//for (auto el : unordered_map) {
	//	cout << "Key : " << el.first << endl;
	//	cout << "Value : " << el.second << endl << endl;
	//}


	//tuple<string, double, int,int> tuple = { "hello",12.5, 101, 34 };

	//cout << get<0>(tuple) << endl;

 //   auto result = foo();
	//cout << get<0>(result) << endl;
	//cout << get<1>(result) << endl;


 //   vector<int> vector = { 83,34,132,657,23,56 };

	//for (int i = 0; i < vector.size(); i++) {
	//	cout << vector[i] << " ";
	//}
	//cout << endl;
	//for (auto el : vector) {
	//	cout << el << " ";
	//}
	//cout << endl;
	//for (auto i = vector.begin(); i != vector.end(); i++) { // 0 - 6
	//	cout << *i << " ";
	//}

	//cout << endl << endl;
	// set<int> _set = { 83,73,89,11,65,73,101 }; // size = 6
	// for (auto i = _set.begin(); i != _set.end(); i++) { // 0 - 6

	//	 cout << *i << " ";
	// }


	// cout << endl;
	//for (set<int>::iterator i = _set.begin(); i != _set.end(); i++) { // 0 - 6

	//	cout << *i << " ";
	//}


	//cout << endl;
	//for (set<int>::reverse_iterator i = _set.rbegin(); i != _set.rend(); i++) { // 0 - 6
	//	cout << *i << " ";
	//}

	//cout << endl;
	//for (set<int>::const_iterator i = _set.cbegin(); i != _set.cend(); i++) { // 0 - 6
 // 
	//	cout << *i << " ";
	//}


	//vector<int> _vector = { 12,15,1,22,34,17,11,26 };

	//bool state = true;

	//for (auto el : _vector) {
	//	/*if (el < 10)
	//	{
	//		state = false;
	//		break;
	//	}*/

	//	state = checkValue(el);
	//	if (state == false) break;
	//}

	//cout << std::boolalpha <<state << endl;


	//state = all_of(_vector.begin(), _vector.end(), checkValue);
	//cout << std::boolalpha << state << endl;


	/*vector<int> vectorForMyAlgo = {8,24,35,8,60 };
	bool checkMyAlgoState = true;
	checkMyAlgoState = my_all_of(vectorForMyAlgo.begin(), vectorForMyAlgo.end(), isEven);
	cout << std::boolalpha << checkMyAlgoState << endl;
	checkMyAlgoState = my_all_of(vectorForMyAlgo.begin(), vectorForMyAlgo.end(), checkValue);
	cout << std::boolalpha << checkMyAlgoState << endl;

	long long EvenCount;
	EvenCount= count(vectorForMyAlgo.begin(), vectorForMyAlgo.end(), 8);
	cout << EvenCount  << endl;*/


   MyArray* arr = new MyArray();
   arr->Add(10);
   arr->Add(3);
   arr->Add(17);
   arr->Add(8);

   for (MyIterator* iter = arr->begin(); iter != arr->end(); iter++) {
	   cout << iter << endl << arr->end() << endl <<boolalpha << (iter != arr->end())<<endl<<endl;
   }

}


