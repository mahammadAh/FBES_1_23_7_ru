#include <iostream>
#include <stdlib.h>
#include <time.h>
#include <conio.h>

using namespace std;
int userX = 0, userY = 0;
int const rows = 10, columns = 10;
char land[rows][columns];


void fillLand() {
    int randNum;
    for (int x = 0; x < rows; x++) {
        for (int y = 0; y < columns; y++) {
            randNum = rand() % 5;
            if (randNum == 3) {
                land[x][y] = 'O';
            }
            else {
                land[x][y] = '1';
            }
        }
    }
}

void printLand() {
    system("cls");
    for (int x = 0; x < rows; x++) {
        for (int y = 0; y < columns; y++) {
            if (x == userX && y == userY) {
                cout << char(254) << " ";
                continue;
            }
            if (land[x][y] == 'O' || land[x][y] == '1')
            {
                cout << "-" << " ";
            }
            else {
                cout << land[x][y] << " ";
            }
        }
        cout << endl;
    }
}

void changePlayerLocation() {
    enum keyboardCodes {
        W = 87,
        S = 83,
        A = 65,
        D = 68,
        Enter = 13
    };

    keyboardCodes clickedKey= W;

    while (clickedKey != Enter) {
        switch(_getch()) {
        case 87:
        case 119:
            clickedKey = W;
            break;
        case 83:
        case 115:
            clickedKey = S;
            break;
        case 65:
        case 97:
            clickedKey = A;
            break;
        case 68:
        case 100:
            clickedKey = D;
            break;
        case 13:
            clickedKey = Enter;
            break;
       }

        if (clickedKey == W) {
            if (userX > 0) {
                userX--;
            }
            else {
                userX = columns-1;
            }           
        }
        else if (clickedKey == S) {
            if (userX < columns-1) {
                userX++;
            }
            else {
                userX = 0;
            }
        }
        else if (clickedKey == A) {
            if (userY > 0) {
                userY--;
            }
            else {
                userY = rows-1;
            }
        }
        else if (clickedKey == D) {
            if (userY < rows -1) {
                userY++;
            }
            else {
                userY =0;
            }
        }
        printLand();
    }
}


void playGame() {
    int score = 0;
    while (true) {
        changePlayerLocation();
 
        if (land[userX][userY] == 'O') {
            system("cls");
            cout << "Game Over" << endl << "SCORE : " << score;
            break;
        }
        else if (land[userX][userY] == '1') {
            score++;
            land[userX][userY] = '+';
        }
      
        printLand();
        cout << "SCORE : " << score << endl << endl;

    }
}

int main()
{
     srand(time(NULL));
 

     fillLand();
     printLand();
     playGame();





}


