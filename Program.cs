namespace Assignment_7._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1, };

            

            for (int i = 0; i < myArray.Length-1; i++) 
            {
                int j = i + 1;
                int lowestNumber = myArray[i];
                int lowestIndex = i;
                while(j< myArray.Length) 
                {
                    if (myArray[j] < lowestNumber) 
                    {
                        lowestNumber = myArray[j];
                        lowestIndex = j;

                    }
                    j++;

                }
                if (myArray[i] > lowestNumber) 
                {
                   int temp = myArray[i];
                    myArray[i] = lowestNumber;
                    myArray[lowestIndex] = temp;


                }
               
               
                 
                
            }
            foreach (int num in myArray) 
            {
                Console.Write(num + " ");
            }
        }
    }
}
