using System;
using Sort_Algorithm.algorithm;

namespace Sort_Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            // var algorithms = new Algorithms();
            Console.WriteLine("Enter the element of the array you want to sort: ");
            var arrayPassed = Console.ReadLine().Split(new[] {" ","", ",", ";"}, StringSplitOptions.RemoveEmptyEntries);
            var array = new int[arrayPassed.Length];
            for(var i=0; i < arrayPassed.Length; i++){
                array[i] = Convert.ToInt32(arrayPassed[i]);
            }
            while(true){
                Console.WriteLine("Please pick a number to sort the array you entered!");
                Console.WriteLine("1. Bubble Sort");
                Console.WriteLine("2. Insertion Sort");
                Console.WriteLine("3. Merge Sort");
                Console.WriteLine("4. Selection Sort");
                var Numberpassed = Convert.ToInt32(Console.ReadLine());

                if(Numberpassed == 1){
                    Console.WriteLine("1. Bubble Sort");
                    Console.WriteLine("Sorted Array: {0}", string.Join(",", Algorithms.BubbleSort(array)));
                } else if(Numberpassed == 2){
                    Console.WriteLine("2. InsertionSort");
                    Console.WriteLine("Sorted Array: {0}", string.Join(",", Algorithms.InsertionSorting(array)));
                }
                
            }
            // Console.WriteLine("Sorted Array: {0}", string.Join(",", BubbleSort(array)));
            // Console.ReadLine();
        }
    }
}
