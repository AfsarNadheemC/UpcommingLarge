namespace UpcommingLarge
{
    public class Program
    {
        static int [] list = { 3,5,2,6,1,4,2,6,3 } ;
        static int large = Int32.MaxValue;
        public static void Main(string[] args)
        {
            for (int i = 0;i<list.Count() ; i++){
                if (checkLarge(i) == large){
                    Console.WriteLine(list[i] + " -> ");
                }
                else{
                    Console.WriteLine(list[i] + " -> " + checkLarge(i));
                }
            }
        }

        public static int checkLarge (int index)
        {
            int max = large;
            for (int i = index+1; i < list.Count(); i++){
                if (list[i] < max && list[i] > list[index]) max = list[i];
            }
            return max;
        }
    }
}