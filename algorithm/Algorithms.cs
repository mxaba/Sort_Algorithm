using System;

namespace Sort_Algorithm.algorithm
{
    public class Algorithms
    {
        static void SwapNumbers(ref int numb , ref int numb2){
            var tempValue = numb;
            numb = numb2;
            numb2 = tempValue;
        }

        // method for finding the position of the minimum element of a subarray, starting at position n
        static int IndexOfMin(int[] array, int n){
            
            var results = n;
            for(var i =n; i < array.Length; i++){
                if(array[i] < array[results]){
                    results = i;
                }
            }

            return results;
        }

        // BubbleSort
        public static int[] BubbleSort(int[] arrayPassed)
        {
            for(int i = 1, j = 0; i < arrayPassed.Length; i++, j++)
            {
                    if(arrayPassed[j] > arrayPassed[j + 1])
                    {
                        SwapNumbers(ref arrayPassed[j], ref arrayPassed[j + 1]);
                    }
            }
            return arrayPassed;
        }
        
        // InsertSorting
        public static int[] InsertionSorting(int[] arrayPassed){
            for(var i=1; i < arrayPassed.Length; i++){
                var key = arrayPassed[i];
                var j = i;
                while((j > 1) && (arrayPassed[j - 1] > key)){
                    SwapNumbers(ref arrayPassed[j -1], ref arrayPassed[j]);
                    j--;
                }
                arrayPassed[j] = key;
            }
            return arrayPassed;
        }

        static void Merge(int[] array, int low, int middle, int high){
            var left = low;
            var right= middle + 1;
            var tempArray = new int[high - low + 1];
            var index = 0;

            while((left <= middle) && (right <= high)){
                if(array[left] < array[right]){
                    tempArray[index] = array[left];
                    left++;
                } else {
                    tempArray[index] = array[right];
                    right++;
                }
                index++;
            }

            for(var i = left; i <= middle; i++){
                tempArray[index] = array[i];
                index++;
            }

            for(var i = right; i <= high; i++){
                tempArray[index] = array[i];
                index++;
            }

            for(var i=0; i < tempArray.Length; i++){
                array[low + i] = tempArray[index]; 
            }
        }

        static int[] MergeSort(int[] array, int low, int high){ 
            if(low < high){
                var middle = (low + high) / 2;
                MergeSort(array, low, middle);
                MergeSort(array, middle + 1, high);
                Merge(array, low, middle, high);
            }
            return array;
        }

        // MergeSort
        public static int[] MergeSort(int[] arrayPassed){
            return MergeSort(arrayPassed, 0, arrayPassed.Length -1);
        }

        public static int[] SelectionSort(int[] array, int currentI = 0){
            if(currentI == array.Length)
                return array;
            
            var iIndexOfMin = IndexOfMin(array, currentI);

            if(iIndexOfMin != currentI){
                SwapNumbers(ref array[iIndexOfMin], ref array[currentI]);
            }

            return SelectionSort(array, currentI + 1);
        }
    }
}
