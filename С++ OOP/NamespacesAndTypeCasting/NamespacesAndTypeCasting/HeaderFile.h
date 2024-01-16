#pragma once

using namespace std;

namespace items {


	namespace value {

		class Size {
			int size;

			void PrintSize() {
				cout << size;
			}
		};

		
	}
	
	enum Color {
		BLACK,
		WHITE
	};

	class Table {
	public:
		int legCount;
		Color color;
		double heigth;
	};

	class Desk {
	public:
		double width;
		double heigth;
	};

}


namespace Dress {
	enum Color {
		RED,
		GREEN,
		WHITE,
		YELLOW,
		BLACK
	};


	class Skirt {
	public:
		double size;
		Color color;
	};

	class trousers {
	public:
		double size;
		Color color;
	};


}



namespace SetValueToOneOfTheAccountsOnCard {

	class Accounts {
		int balance;
	};

}