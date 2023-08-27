#include <iostream>

using namespace std;

int main()
{
    //cout << "1.Rooms\n2.Empty Rooms\n3.Guest\n4.Staff\n5.Exit"<<endl;
    //int choose;
    //cout << "Your choose : ";
    //cin >> choose;

    //if (choose == 1)
    //{
    //    cout << "All Rooms" << endl;
    //}
    //else if (choose == 2)
    //{
    //    cout << "All Empty Rooms" << endl;
    //}
    //else if (choose == 3)
    //{
    //    cout << "All our Guests" << endl;
    //}
    //else if (choose == 4)
    //{
    //    cout << "Our Staff" << endl;
    //}
    //else if (choose == 5)
    //{
    //    cout << "App closed" << endl;
    //}


    // switch

    //cout << "1.Rooms\n2.Empty Rooms\n3.Guest\n4.Staff\n5.Exit"<<endl;
    //int choose;
    //cout << "Your choose : ";
    //cin >> choose;

    //switch (choose)
    //{
    // case 1:
    //     cout << "All Rooms" << endl;
    //     break;
    // case 2:
    //     cout << "All Empty Rooms" << endl;
    //     break;
    // case 3:
    //     cout << "All our Guests" << endl; 
    //     break;
    // case 4:
    //     cout << "Our Staff" << endl;
    //     break;
    // case 5:
    //     cout << "App closed" << endl;
    //}  


    //char mark;
    //cout << "Set Mark : ";
    //cin >> mark;

    //switch (mark)
    //{
    //case 'a':
    //case 'A':
    //    cout << "90-100" << endl;
    //    break;
    //case 'b':
    //case 'B':
    //    cout << "80-90" << endl;
    //    break;
    //case 'c':
    //case 'C':
    //    cout << "70-80" << endl;
    //    break;
    //case 'd':
    //case 'D':
    //    cout << "60-70" << endl;
    //    break;
    //case 'e':
    //case 'E':
    //    cout << "50-60" << endl;
    //    break;
    //default:
    //    cout << "0-50" << endl;

   //}

    //enum Month {
    //    January = 1,
    //    February,
    //    March,
    //    April,
    //    May,
    //    June,
    //    July,
    //    August,
    //    September,
    //    October,
    //    November,
    //    December

    //};


    //cout << "Set a month number : ";
    //int monthNum;
    //cin >> monthNum;

    //switch (monthNum)
    //{
    //case January:
    //case February:
    //case December:
    //    cout << "Winter" << endl;
    //    break;
    //case March:
    //case April:
    //case May:
    //    cout << "Spring" << endl;
    //    break;
    //case June:
    //case July:
    //case August:
    //    cout << "Summer" << endl;
    //    break;
    //case September:
    //case October:
    //case November:
    //    cout << "Autumn" << endl;
    //}


    enum CountryCode {
        Afghanistan = 93,
        Azerbaijan = 994,
        Burundi = 257,
        Djibouti = 253,
        Ethiopia = 251,
        Liechtenstein = 41
    };

    int numberCode;
    cout << "Set Number Code : ";
    cin >> numberCode;

    switch (numberCode)
    {
    case Afghanistan:
        cout << "1 saniye - 27 qepik";
        break;
    case Azerbaijan:
        cout << "1 saniye - 1 qepik";
        break;
    case Burundi:
        cout << "1 saniye - 2 qepik";
        break;
    case Djibouti:
        cout << "1 saniye - 4 qepik";
        break;
    case Ethiopia:
        cout << "1 saniye - 8 qepik";
        break;
    case Liechtenstein:
        cout << "1 saniye - 45 qepik";
        break;
    }

}
