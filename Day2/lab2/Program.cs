using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;

namespace lab2
{
    internal class Program

    {
        struct Employee
        {
            public int id;
            public string name;
            public int salary;
            public Employee(int id, string name, int salary)
            {
                this.id = id;
                this.name = name;
                this.salary = salary;
            }

        }


        static void Main(string[] args)
        {
            #region task1
            Console.WriteLine("Enter round percentages");
            /// students grades
            //fillarray + max + high
            static int fillGrades(int[] grades, out int high)
            {
                int sum = 0;
                int avg = 0;
                high = grades[0];
                for (int i = 0; i <= 3; i++)
                {

                    Console.WriteLine($"Enter Grade of subject {i + 1}");
                    grades[i] = int.Parse(Console.ReadLine());
                    sum += grades[i];
                    avg = sum / 4;

                    if (grades[i] > high)
                    {

                        high = grades[i];

                    }

                }
                return avg;

                //Console.WriteLine($" Sum of Grades = {sum} ");
                //Console.WriteLine($" avg= {avg}");
                //Console.WriteLine($" high= {high}");


            }

            /// display 

            static void displayGrades(int[] grades)
            {
                for (int i = 0; i < grades.Length; i++)
                {


                    Console.WriteLine($"grade {i + 1} = {grades[i]}");

                }
            }

            /// function 3 -- check passed or failed 
            static void success(int avg)
            {
                if (avg > 60)
                {

                    Console.WriteLine(" passed ");

                }
                else
                {

                    Console.WriteLine(" FAILED , TRY WITH PERCENTAGES GRADES");
                }


            }



            int[] grades = new int[4];

            int avg = fillGrades(grades, out int high);

            Console.WriteLine($" avg= {avg} ,  high= {high} ");

            displayGrades(grades);

            success(avg);


            #endregion

            #region task2
            //////////////////// task 2 / mul  2 matrix  /////// 
            /////




            int[,] matrix1 = new int[2, 2];
            int[,] matrix2 = new int[2, 2];
            ///// fill matrix

            static int[,] fillMAT(int[,] matrix)
            {
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        Console.WriteLine($"for matrix ({row + 1}, {col + 1})");
                        matrix[row, col] = int.Parse(Console.ReadLine());
                    }
                }
                return matrix;
            }
            // we can do fillMAT(matrix1); // it works ! :) 
             fillMAT(matrix1);
            fillMAT(matrix2);

            ////// display matrix
            /////
            static void displayMatrix(int[,] matrix)
            {

                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        Console.WriteLine($"matrix : row {row + 1}, col {col + 1} = {matrix[row, col]}");
                    }
                }
                return;
            }


            ///// mul ((Element-wise Multiplication)  Hadamard Product)

            static int[,] mulMatrix(int[,] matrix1, int[,] matrix2)
            {
                int[,] matrix = new int[2, 2];
                int j;
                for (int i = 0; i < matrix1.GetLength(0); i++)
                {
                    for (j = 0; j < matrix1.GetLength(1); j++)
                    {

                        matrix[i, j] = matrix1[i, j] * matrix2[i, j];

                        Console.WriteLine($"Mul matrix [{i},{j}] = {matrix[i, j]}");
                    }
                }
                return matrix;
            }
            Console.WriteLine("matrix1");
            displayMatrix(matrix1);
            Console.WriteLine("matrix2");
            displayMatrix(matrix2);
            Console.WriteLine("mulitple of both : ");

            int[,] mul = mulMatrix(matrix1, matrix2);

            #endregion

            #region task3
            // //// task3 : struct employee (3)
         


            // fill fun
             Employee[] employees = empArr();
            // empArr();
            // Display arr 
            displayEmployees(employees);


            #endregion







        }
        static void displayEmployees(Employee[] empArr)
        {
            Console.WriteLine("Employees List:");
            for (int i = 0; i < empArr.GetLength(0); i++)
            {
                Console.WriteLine($"ID: {empArr[i].id}, Name: {empArr[i].name}, Salary: {empArr[i].salary}");
            }

        }

        static Employee[] empArr()
        {
            Employee[] emp = new Employee[3];


            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Enter employee'data{i + 1}");

                Console.Write("ID: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Salary: ");
                int salary = int.Parse(Console.ReadLine());

                emp[i] = new Employee(id, name, salary);
            }

            return emp;

        }

    }
}
