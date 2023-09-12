#include <iostream>
#include <stdlib.h>
#include <time.h>

using namespace std;

int main()
{
	const int size = 10;
	int arr[size];

	srand(time(NULL));

	//for (int i = 0; i < size; i++)
	//{
	//	arr[i] = rand()%25;
	//}

	for (int i = 0; i < size; i++)
	{
		arr[i] = 25 + rand()%35;  // min + rand()%(max-min) for range 
	}
	  


	for (int i = 0; i < size; i++)
	{
		cout << arr[i] << " ";
	}



}


