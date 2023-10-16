namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Arrayde elementin sayini gosterin. 
            //int[] myArray = { 12,0, 21, 12, 21, 10, 12, 21,0,0,0 };
            //int counter = 0;
            //int lasNumber = 0;


            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    for (int a = 0; a < myArray.Length; a++)
            //    {
            //        if (myArray[i] > myArray[a])
            //        {
            //            lasNumber = myArray[i];
            //            myArray[i] = myArray[a];
            //            myArray[a] = lasNumber;

            //        }
            //    }
            //}


            //for (int saveIndex = 0; saveIndex < myArray.Length; saveIndex++)
            //{
            //    counter = 0;
            //    for (int i = saveIndex; i < myArray.Length; i++)
            //    {
            //        if (myArray[i] == myArray[saveIndex])
            //        {
            //            counter++;
            //            saveIndex = i;
            //        }                        
            //    }
            //    Console.WriteLine($"{myArray[saveIndex]} => {counter}");
            //}
            #endregion

            #region Console app
            Console.Write("Enter Array Length : ");
            int myArrayLength = Convert.ToInt32(Console.ReadLine());

            int[] userArray = new int[myArrayLength];
            int index = 0;            
            string control = string.Empty;
            do 
            {
                Console.Clear();

                Console.Write("Add Item (Y/y/Yes/yes): ");
                control = Console.ReadLine();

                if (control == "y" || control == "Y" || control == "Yes" || control == "yes")
                {
                    Console.Write("Add Item to Array : ");
                    userArray[index++] = Convert.ToInt32(Console.ReadLine());
                }
                else
                    break;                   

            } while (userArray.Length > index);
            #endregion
        }
    }
}