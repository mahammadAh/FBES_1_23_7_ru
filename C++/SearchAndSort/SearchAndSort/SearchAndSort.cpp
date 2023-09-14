#include <iostream>

using namespace std;

int main()
{

    // Алгоритм линейного поиска - Lineary Search
    
    //const int size = 10;
    //int arr[size] = { 2,5,1,8,3,9,4,10,6,7 };
    //int seach = 7;
    //int interationCount = 0;
    //for (int i = 0; i < size; i++)
    //{
    //    interationCount++;
    //    if (arr[i] == seach)
    //    {
    //        cout << "index : " << i << endl;
    //        cout << "Iteration Count : " << interationCount << endl;
    //        break;
    //    }
    //    
    //}

    //Алгоримт бинарного поиска - Binary Search

    //const int size = 10;
    //int arr[size] = { 1,2,3,4,5,6,7,8,9,10 };
    //int seach = 7;
    //int interationCount = 0;
    //int left = 0;
    //int right = size;
    //int midIndex = 0;

    //while (left <= right)
    //{
    //    midIndex = left + (right - left) / 2;
    //    interationCount++;
    //    if (arr[midIndex] == seach)
    //    {
    //        cout << "Index : " << midIndex<<endl;
    //        break;
    //    }
    //    else if (arr[midIndex] < seach)
    //    {
    //        left = midIndex;
    //    }
    //    else
    //    {
    //        right = midIndex;
    //    }


    //}

    //cout << "Iteration Count : " << interationCount << endl;


   // Пузырьковая сортировка - Bubble Sort 


    //const int size = 5;
    //int arr[size] = { 4,3,9,1,5};
    //int buff = 0;
    //for (int i = 0; i < size-1; i++) {
    //    for (int j = 0; j < size-i-1; j++) {
    //        if (arr[j + 1] < arr[j])
    //        {
    //            buff = arr[j + 1];
    //            arr[j + 1] = arr[j];
    //            arr[j] = buff;
    //        }
    //    }
    //}


    //  Сортировка вставкой - Insertion Sort 

 /*   const int size = 8;
    int arr[size] = { 9,7,6,15,17,5,10,11};
    int currentElement = 0;


    for (int i = 1; i < size; i++)
    {
        currentElement = arr[i];
        int j = i-1;
        while (j >= 0 && currentElement < arr[j])
        {
            arr[j + 1] = arr[j];
            arr[j] = currentElement;
            j--;
        }
    }

    for (int i = 0; i < size; i++)
    {
        cout << arr[i] << " ";
    }*/


    // Сортировка Выборкой - Selection Sort 

    const int size = 8;
    int arr[size] = { 9,7,6,15,17,5,10,11 };

    for (int i = 0; i < size-1; i++)
    {
        int minIndex = i;
        for (int j = i+1; j < size; j++)
        {
            if (arr[j] < arr[minIndex])
            {
                minIndex = j;
            }
        }

        int buff = arr[i];
        arr[i] = arr[minIndex];
        arr[minIndex] = buff;
    }


    for (int i = 0; i < size; i++)
    {
        cout << arr[i] << " ";
    }
}


