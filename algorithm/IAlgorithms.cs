namespace Sort_Algorithm.algorithm
{
    public interface IAlgorithms
    {
        int[] BubbleSort(int[] arrayPassed);
        int[] InsertionSorting(int[] arrayPassed);
        int[] MergeSort(int[] arrayPassed);
        int[] SelectionSort(int[] array, int currentI = 0);
    }
}