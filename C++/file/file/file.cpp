#include <iostream>
#include <conio.h>
using namespace std;



int main()
{
    FILE* myFile = nullptr;

    //fopen_s(&myFile, "data.txt", "a");

    //char sym;

    //while (true) {
    //    sym = _getch();
    //    cout << sym;
    //    if (sym == 13) {
    //        break;
    //    }
    //    fputc((int)sym, myFile);
    //}


    //fclose(myFile);


  /*  fopen_s(&myFile, "data.txt", "r");
    cout << endl;

    while (true) {
        int resultFGetch = fgetc(myFile);

        if (resultFGetch == -1) break;

        cout << (char)resultFGetch;
    }
    
    fclose(myFile);*/

    

    //int firstValue;


    //fscanf_s(myFile, "%i", &firstValue);

    //cout << "firstValue -> " << firstValue << endl;

    fopen_s(&myFile, "data.bin", "wb");
    int buff[5] = { 2832934,2131442,76894659,3254567,235465 };
    fwrite(buff, 4, 5, myFile);

    fclose(myFile);

    fopen_s(&myFile, "data.bin", "rb");

   // char buff[20];
   // fread(buff, 2, 20, myFile);
 
   // cout << buff;


  

    // feof , fflush , fgetc , fputc , fwrite , fread

}


