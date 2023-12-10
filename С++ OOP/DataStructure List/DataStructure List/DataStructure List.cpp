#include <iostream>
#include <list>
#include <time.h>
#include <stdlib.h>

using namespace std;


template <typename T>
class Node {
public:
	T value;
	Node* nextNode;
	Node(const T& value) : value{value}, nextNode{ nullptr }{}
};


template<typename T>
class List {
public:
	Node<T>* headNode;

	List() : headNode{ nullptr } {}

	void addFront(const T& value) {
		Node<T>* newNode = new Node<T>(value);
		newNode->nextNode = this->headNode;
		this->headNode = newNode;
		newNode = nullptr;
	}

	void addBack(const T& value) {
		Node<T>* newNode = new Node<T>(value);

		Node<T>* currentNode = this->headNode;

		if (this->headNode == nullptr) {
			this->headNode = newNode;
		}
		else {
			while (true) {
				if (currentNode != nullptr) {
					if (currentNode->nextNode != nullptr) {
						currentNode = currentNode->nextNode;
					}
					else break;
				}
				else break;
			}
			currentNode->nextNode = newNode;
		}
	}

	void remove() {
		if (this->headNode != nullptr) {
			Node<T>* oldNode = this->headNode;
			this->headNode = oldNode->nextNode;
			delete oldNode;
		}
	}


	Node<T>* find(const T& value) {
		for (Node<T>* node = this->headNode; node->nextNode != nullptr; node = node->nextNode) {
			if (node->value == value) {
				return node;
			}
		}
		return nullptr;
	}

	Node<T>* findPrev(const T& value) {
		for (Node<T>* node = this->headNode; node->nextNode != nullptr; node = node->nextNode) {
			if (node->nextNode->value == value) {
				return node;
			}
		}
		return nullptr;
	}
	
	Node<T>* addAfter(const T& value, Node<T>* prevNode) {
		Node<T>* newNode = new Node<T>(value);
		newNode->nextNode = prevNode->nextNode;
		prevNode->nextNode = newNode;
		newNode = nullptr;
		return prevNode->nextNode ;
	}

	void removeAfter(Node<T>* prevNode) {
		Node<T>* nextNode = prevNode->nextNode;
		prevNode->nextNode = nextNode->nextNode;
		delete nextNode;
	}

	void clear() {
		
		while (true) {
			if (this->headNode != nullptr) {
				remove();
			}
			else break;
		}
	}

	~List() {
		this->clear();
	}

};



int main()
{
	List<int> myList;

	srand(time(NULL));

	//for (int i = 0; i < (5 + rand() % 10); i++) {
	//	spisok.add(1+rand()%100);
	//}

	myList.addFront(10);
	myList.addFront(20);
	myList.addFront(30);
	myList.addFront(40);
	myList.addFront(50);
	myList.addBack(60);


	Node<int>* prevNode = myList.find(40);
	

	prevNode = myList.addAfter(45, prevNode);
	prevNode = myList.addAfter(46, prevNode);
	prevNode = myList.addAfter(47, prevNode);


	Node<int>* nodeForDelete = myList.find(46);
	myList.removeAfter(nodeForDelete);


	Node<int>* findPrevNode = myList.findPrev(50);

	cout <<"prev node value : "<< findPrevNode->value << endl;

	//myList.remove();
	//myList.remove();
	//myList.remove();
	//myList.remove();
	//myList.remove();
	//myList.remove();

	//myList.clear();

	auto currentNode = myList.headNode;
	while (true) {
		if (currentNode != nullptr) {
			cout <<"value : "<< currentNode->value << endl;
			//cout <<"address : " << currentNode << endl;
			if (currentNode->nextNode != nullptr) {
				currentNode = currentNode->nextNode;
			}
			else {
				break;
			}
		}
		else {
			break;
		}

	}
	//cout << endl;
	//cout << "find result address : "  << myList.find(40);
	//cout << endl;



	std::list<int> originalList;
	originalList.push_front(10);
	originalList.push_front(20);
	originalList.push_front(30);
	originalList.push_front(40);
	originalList.push_front(50);

	for (auto el = originalList.begin(); el != originalList.end(); el++) {
		cout << *el << " ";
	}



}


