namespace Lab7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Welcome :) ");

            /// Try - catch - finally 
            
            try

            {
                int[] arr = { 1, 2, 3 };
                Console.WriteLine($" Arr [6] = {arr[6]}");

            } catch (Exception ex)
            {
                Console.WriteLine($"Messege {ex.Message}");
            }
            finally
            {
                Console.WriteLine("It's Done ");

            }

            ///// Generic class :) 


            Generic<string> name = new Generic<string>();
            name.value = "Generic Str";
            Console.WriteLine(name.value);

            Generic<int> g = new Generic<int>();
            g.value = 1000;

            // before generic concept
            #region
            //MyList list1 = new MyList(6, 2);
            //list1.Add("Str");// boxing
            //list1.Add(1002);
            //list1.Add("ddd");
            //int x = (int)list1.items[0];// unboxing
            //string str= (string)list1.items[0];// exception error why? :: real value isnt string 
            #endregion
            /// Generic !! fit any datatype to match the entered value ! :) lets try 
            MyList<int> list2 = new MyList<int>(5,6);
            MyList<string> str01 = new MyList<string>(1,2);
            MyList<string> str02 = new MyList<string>(1, 2);

            str01.Add("ah");
            str02.Add("Ni");

            string str1 = ("ah");
            string str2 = ("Ni");
            // Generic function 
            Console.WriteLine($"before swaping str1 {str1},str2{str2}");

            Helper.Swap<string>(ref str1, ref str2);
            Console.WriteLine($"After swaping str1 {str1},str2{str2}");

            Helper.Swap<MyList<string>>(ref str01, ref str02);
            Console.WriteLine($"before swaping str1 {str01},str2{str02}");
            Console.WriteLine($"After swaping str1 {str01},str2{str02}");



            /// interface 

            Book book1 = new Book("GoodDay", 365);
            book1.Read();
        }
    }
}
