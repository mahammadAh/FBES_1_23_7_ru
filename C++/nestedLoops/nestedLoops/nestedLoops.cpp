#include <iostream>

using namespace std;

int main()
{
	for (int j = 0; j < 15; j++) {
		for (int i = 0; i < 15; i++)
		{
			cout << "*";
		}
		cout << endl;
	}

	int loopI = 0;
	int loopJ = 0;
	int loopF = 0;

	for (int i = 0; i < 4000; i++)
	{
		for (int j = 0; j < 3000; j++)
		{
			for (int f = 0; f < 5000; f++)
			{
				loopF++;
			}
			loopJ++;
		}
		loopI++;
	}

	cout << "Loop F : " << loopF << endl;
	cout << "Loop J : " << loopJ << endl;
	cout << "Loop I : " << loopI << endl;
}

