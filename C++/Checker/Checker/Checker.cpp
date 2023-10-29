#include<iostream>
using namespace std;


struct snakeBodyPart {
	int x;
	int y;
};
int main()
{
	int snakeLength = 1;
	snakeBodyPart* snake = new snakeBodyPart[snakeLength];
	snake[0].x = 0;
	snake[0].y = 0;





	int map[10][10];

	for (int i = 0; i < 10; i++) {
		for (int j = 0; j < 10; j++) {
			map[i][j] = '0';
		}
	}


	for (int i = 0; i < 10; i++) {
		for (int j = 0; j < 10; j++) {
			
			for (int d = 0; d < snakeLength; d++) {
				if (snake[d].x == i && snake[d].y == j) {
					cout << "=";
				}
				else {
					cout << " ";
				}
			}
	
		}
		cout << endl;
	}


	snakeLength += 1;
	snakeBodyPart* newSnake = new snakeBodyPart[snakeLength];
	for (int i = 0; i < snakeLength-1; i++) {
		newSnake[i] = snake[i];
	}
	snake[snakeLength-1].x = 1;
	snake[snakeLength-1].y = 1;

	snake = newSnake;

	system("cls");

	for (int i = 0; i < 10; i++) {
		for (int j = 0; j < 10; j++) {

			for (int d = 0; d < snakeLength; d++) {
				if (snake[d].x == i && snake[d].y == j) {
					cout << "=";
				}
				else {
					cout << " ";
				}
			}

		}
		cout << endl;
	}
	
}

