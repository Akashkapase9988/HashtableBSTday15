using System;

namespace HashandBSTday15
{
    class Program
    {
        static void Main()
        {


            //string s1;
            //Console.WriteLine("Enter the String : ");
            //s1 = Console.ReadLine();
            //uc1repetation.CountStringOccurrences(s1, "to");
            //Console.WriteLine("Hello World!");

            //#region
            //BinarySearchTree<int> binarySearch = new BinarySearchTree<int>(56);
            //binarySearch.Insert(56);
            //binarySearch.Insert(30);
            //binarySearch.Insert(70);
            //#endregion

            #region
            BinarySearch<int> binarySearch = new BinarySearch<int>(56);
            binarySearch.Insert(30);
            binarySearch.Insert(70);
            binarySearch.Insert(22);
            binarySearch.Insert(40);
            binarySearch.Insert(60);
            binarySearch.Insert(95);
            binarySearch.Insert(11);
            binarySearch.Insert(65);
            binarySearch.Insert(3);
            binarySearch.Insert(16);
            binarySearch.Insert(63);
            binarySearch.Insert(67);
            binarySearch.Display();
            #endregion

            //#region
            //BinarySearchtree<int> binarySearch = new BinarySearchtree<int>(56);
            //binarySearch.Insert(30);
            //binarySearch.Insert(70);
            //binarySearch.Insert(22);
            //binarySearch.Insert(40);
            //binarySearch.Insert(60);
            //binarySearch.Insert(95);
            //binarySearch.Insert(11);
            //binarySearch.Insert(65);
            //binarySearch.Insert(3);
            //binarySearch.Insert(16);
            //binarySearch.Insert(63);
            //binarySearch.Insert(67);
            ////bool result = binarySearch.IfExists(67, BinarySearchtre);
            //#endregion
        }
    }
}
