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

        public static int[] BubbleSort(int[] arrayPassed){
            var len = arrayPassed.Length;
            for(var i=1; i<len; i++){
                for(var j=0; j<len-i; j++){
                    if(arrayPassed[j] > arrayPassed[j + 1]){
                        SwapNumbers(ref arrayPassed[j], ref arrayPassed[j + 1]);
                    }
                }
            }
            return arrayPassed;
        }

        public static int[] InsertSorting(int[] arrayPassed){
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

        static int[] MergeSort(int[] ){

        }
    }
}