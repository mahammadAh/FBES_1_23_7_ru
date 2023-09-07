#include <iostream>

using namespace std;

int main()
{
    char cell_1 = ' ', cell_2 = ' ', cell_3 = ' ',
         cell_4 = ' ', cell_5 = ' ', cell_6 = ' ', 
         cell_7 = ' ', cell_8 = ' ', cell_9 = ' ';

    bool isEnd = false;
    bool isPlayer = false;
    int cell_num;
    char currentSym = '0';

    srand(time(NULL));
    if (rand() % 2)
    {
        isPlayer = true;
        currentSym = 'X';
    }

    while (!isEnd)
    {
       
        cout << cell_1 << "|" << cell_2 << "|" << cell_3<<endl;
        cout << cell_4 << "|" << cell_5 << "|" << cell_6<<endl;
        cout << cell_7 << "|" << cell_8 << "|" << cell_9<<endl;
        cout << endl << endl;
        if (isPlayer) {
            cout << "Selecet Number ( 1 - 9 ) : ";
            cin >> cell_num;
        }
        else {
            cell_num = rand() % 10;
        }

            switch (cell_num)
            {
            case 1:
                if (cell_1 == ' ')
                {
                    cell_1 = currentSym;
                    isPlayer = !isPlayer;
                } else cout << "Try Again " << endl << endl << endl; 
                break;
            case 2:
                if (cell_2 == ' ')
                {
                    cell_2 = currentSym;
                    isPlayer = !isPlayer;
                }  else cout << "Try Again " << endl << endl << endl;
                break;
            case 3:
                if (cell_3 == ' ')
                {
                    cell_3 = currentSym;
                    isPlayer = !isPlayer;
                } else cout << "Try Again " << endl << endl << endl;
                break;
            case 4:
                if (cell_4 == ' ')
                {
                    cell_4 = currentSym;
                    isPlayer = !isPlayer;
                } else cout << "Try Again " << endl << endl << endl;
                break;
            case 5:
                if (cell_5 == ' ')
                {
                    cell_5 = currentSym;
                    isPlayer = !isPlayer;
                } else cout << "Try Again " << endl << endl << endl;
                break;
            case 6:
                if (cell_6 == ' ')
                {
                    cell_6 = currentSym;
                    isPlayer = !isPlayer;
                } else cout << "Try Again " << endl << endl << endl;
                break;
            case 7:
                if (cell_7 == ' ')
                {
                    cell_7 = currentSym;
                    isPlayer = !isPlayer;
                } else cout << "Try Again " << endl << endl << endl;
                break;
            case 8:
                if (cell_8 == ' ')
                {
                    cell_8 = currentSym;
                    isPlayer = !isPlayer;
                }  else cout << "Try Again " << endl << endl << endl;
                break;
            case 9:
                if (cell_9 == ' ')
                {
                    cell_9 = currentSym;
                    isPlayer = !isPlayer;
                } else cout << "Try Again " << endl << endl << endl;
                break;
            }

            isPlayer == true ? currentSym = 'X' : currentSym = '0';
        

        if (cell_1 == cell_2 && cell_2 == cell_3  && cell_1 != ' ' || cell_4 == cell_5 && cell_5 == cell_3 && cell_4 != ' ' || cell_7 == cell_8 && cell_8 == cell_9 && cell_7 != ' ' ||
            cell_1 == cell_4 && cell_4 == cell_7  && cell_1 != ' ' || cell_2 == cell_5 && cell_5 == cell_8 && cell_2 != ' ' || cell_3 == cell_6 && cell_6 == cell_9 && cell_3 != ' ' ||
            cell_1 == cell_5 && cell_5 == cell_9  && cell_1 != ' ' || cell_3 == cell_5 && cell_5 == cell_7 && cell_3 != ' ')
        {
            if (!isPlayer) {
                cout << "You WIN !" << endl;
            }
            else {
                cout << "You LOSE !" << endl;
            }
            isEnd = true;
        }
        else if (cell_1 != ' ' && cell_2 != ' ' && cell_3 != ' '
            && cell_4 != ' ' && cell_5 != ' ' && cell_6 != ' '
            && cell_7 != ' ' && cell_8 != ' ' && cell_9 != ' ')
        {
            cout << "DRAW";
            isEnd = true;
        }

    }

}


