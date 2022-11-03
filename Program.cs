namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 5, 7, 12, 34, 54, 67, 89, 90 };
            Console.WriteLine("eded daxil edin");
            int eded = Convert.ToInt32(Console.ReadLine());
            int left = 0;
            int right = arr.Length-1 ;
            int mid = default(int);


            while(left <= right)
            {
                mid = (left+right)/2 ;
                if (arr[mid] == eded) 
                {
                    Console.WriteLine("eded " + mid + "-ci indexdedir");
                    break;
                }
                else if (arr[mid] >= eded)
                {
                    right = mid - 1;
                }
                else if (arr[mid] <= eded)
                {
                    left = mid + 1;
                }
                else
                {
                    Console.WriteLine("bele indexli eded yoxdur");
                }
            }
                        
        }
    }
}