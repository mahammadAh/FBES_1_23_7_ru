#include <iostream>
#include <vector>

using namespace std;

class MusicPlayer {
public:
	//MusicPlayer() {
	//	cout << "MusicPlayer Default Constructor" << endl;
	//}

	MusicPlayer(string deviceName ) {
		cout << "On " << deviceName << " MusicPlayer  Constructor" << endl;
	}

	void playMusic() {
		cout << "..Music is Playing.." << endl;
	}

	void On() {
		cout << "..Player On.." << endl;
	}

	~MusicPlayer() {
		cout << "MusicPlayer Destructor" << endl;
	}
};

class GamePad {
public:
	//GamePad() {
	//	cout << "GamePad Default Constructor" << endl;
	//}

	GamePad(string deviceName) {
		cout << "On " << deviceName << " GamePad  Constructor" << endl;
	}
	void startGame() {
		cout << "..Game is Started.." << endl;
	}

	void On() {
		cout << "..GamePad On.." << endl;
	}

	~GamePad() {
		cout << "GamePad Destructor" << endl;
	}
};


class Laptop : public GamePad , public MusicPlayer{
public:
	//Laptop() {
	//	cout << "Laptop Default Constructor" << endl;
	//
	//}

	Laptop(string deviceName) : GamePad("DD78A"), MusicPlayer("HH34J") {
		cout << "On " << deviceName << " Laptop Constructor" << endl;
	}

	void textEditor() {
		cout << "..Text Editor.." << endl;
	}

	~Laptop() {
		cout << "Laptop Destructor" << endl;
	}

};



class Texture {
public:
	string name;
	Texture() {
		cout << "Texture Constructor" << endl;
	}
	void printName() {
		cout <<"Texture name -> "<< name << endl;
	 }
};

class Wood : public Texture {
public:
	string type;

	Wood() {
		cout << "Wood Constructor" << endl;
	}

	void printType() {
		cout << "Wood type -> " << type << endl;
	}
};


class Rock : public Texture {
public:
	int strong;
	Rock() {
		cout << "Rock Constructor" << endl;
	}


	void printStrong() {
		cout << "Rock strong -> " << strong << endl;
	}
};


class House : public Wood, public Rock {
public:
	int sqrt;
	int floorCount;

	House() {
		cout << "House Constructor" << endl;
	}

	void printInfo() {
		cout << "House sqrt -> " << sqrt << endl;
		cout << "House floorCount -> " << floorCount << endl;
	}
};


template <typename T>
class Describtion {
public:
	T age;
};


template <typename T>
class Humanoid : public Describtion<T>{
public:
	string name;
};



class Animal {
protected:
	string name;
public:

	Animal(string name) : name{ name } {};

	string getName() {
		return name;
	}

	virtual void say() {};
	
};


class Cat : public Animal {
public:
	Cat(string name) : Animal(name) {};

	void say() {
		cout << name << " say meow " << endl;
	}
};


class Dog : public Animal {
public:
	Dog(string name) : Animal(name) {};

	void say() {
		cout << name << " say woof " << endl;
	}
};

class Human {
public:
	string name;

	Human(string name) : name {name} {}

};


// Library //
void printPetName(Animal& pet) {
	cout << pet.getName() << endl;
	pet.say();
}

// Library //


int main()
{

	Cat cat("Jesika");
	Dog dog("Tobik");

	//cout << cat.getName() << endl;
	//cout << dog.getName() << endl;

	//cat.say();
	//dog.say();

	//Animal animal("Samuel");
	//cout << animal.getName() << endl;
	//animal.say();

	Human person("Cavid");

	Animal& animal1 = cat;

	Animal* animal2;
	animal2 = &dog;

	//animal1.say();
	//animal2->say();


	//vector<Animal*> pets;

	//pets.push_back(&cat);
	//pets.push_back(&dog);

	printPetName(cat);
	printPetName(dog);

	//Cat& cat = animal;

	/*
	//MusicPlayer player;
	////player.playMusic();

	////GamePad console;
	////console.startGame();

	////Laptop laptop;
	////laptop.playMusic();
	////laptop.startGame();
	////laptop.textEditor();
	////laptop.GamePad::On();
	////laptop.MusicPlayer::On();


	////Laptop laptop;

	////Laptop* laptop = new Laptop("HP::23BS11-10") ;

	////delete laptop;

	////House hunterHouse;
	////hunterHouse.Rock::name = "";
	////hunterHouse.Wood::name = "";
	////hunterHouse.Texture::name = "";

	///*Humanoid<int> human;
	//human.age = 10;

	//Humanoid<string> ascardian;
	//ascardian.age = "SDH";*/

}


