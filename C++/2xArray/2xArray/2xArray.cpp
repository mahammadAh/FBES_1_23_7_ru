#include <iostream>
#include <stdlib.h>
#include <time.h>

using namespace std;

int main()
{
    //const int size1 = 4;
    //const int size2 = 6;

    //int arr[size1][size2];

    //srand(time(NULL));
    //
    //for (int i = 0; i < size1; i++) {
    //    for (int j = 0; j < size2; j++) {
    //        arr[i][j] = 10 + rand() % 90;
    //    }
    //}



    //cout << "arr  --> " << arr << endl<<endl;

    //for (int i = 0; i < size1; i++) {
    //    cout << "arr["<<i<<"] --> "<<arr[i] << " ";
    //    for (int j = 0; j < size2; j++) {
    //        cout <<arr[i][j]<<" ";
    //    }
    //    cout << endl;
    //}

 /*   srand(time(NULL));
    int const rows = 10;
    int const columns = 10;
    char land[rows][columns];
    int randNum;
    int score = 0;

    for (int x = 0; x < rows; x++) {
        for (int y = 0; y < columns; y++) {
            randNum = rand() % 5;
            if (randNum == 3) {
                land[x][y] ='O';
            }
            else {
                land[x][y] = '1';
            }
        }
    }

    for (int x = 0; x < rows; x++) {
        for (int y = 0; y < columns; y++) {
            if (land[x][y] == 'O' || land[x][y] == '1')
            {
                cout <<"-"<<" ";
            }
            else {
                cout << land[x][y] << " ";
            }
        }
        cout << endl;
    }




    while (true) {
        int userX, userY;
        cout << "X --> ";
        cin >> userX;
        cout << "Y --> ";
        cin >> userY;
        if (land[userX][userY] == 'O') {
            system("cls");
            cout << "Game Over" << endl << "SCORE : " << score;
            break;
        }
        else if (land[userX][userY] == '1') {
            score++;
            land[userX][userY] = '+';
        }
        system("cls");
        for (int x = 0; x < rows; x++) {
            for (int y = 0; y < columns; y++) {
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
        cout << "SCORE : " << score << endl << endl;

    }*/

    int max = INT_MIN;
    cout << max;
    
}

