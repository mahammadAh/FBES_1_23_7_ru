#include<iostream>
using namespace std;

int mystrlen(const char* str)
{
	int count = 0;
	for (int i = 0;; i++)
	{
		if (str[i] != '\0')
		{
			count++;
		}
		else
		{
			return count;
		}
	}
}

char* mystrcpy(char* str1, const char* str2)
{
	for (int i = 0;; i++)
	{
		if (str2[i] != '\0')
		{
			str1[i] = str2[i];
		}
		else
		{
			str1[i] = '\0';
			return str1;
		}
	}
}





int main()
{

	/////////////////////////////////Task 2/////////////////////////////
	cout << "\nTask 2" << endl << endl;
	const char text[] = "How are you?";
	char* cText = new char[mystrlen(text)];
	cout << "String: " << text << endl;
	cout << "Copied text: " << mystrcpy(cText, text) << endl;
	cout << cText << endl;
	delete[] cText;
}

