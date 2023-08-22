using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Project_A
{
    internal class Program
    {
        public struct Product
        {
            public string _productName { get; set; }
            public decimal _productPrice { get; set; }
            public DateTime _expireDate { get; set; }
            public int Run(DateTime expireDate)
            {
                TimeSpan interval = expireDate.Subtract(DateTime.Now);

                if (interval.Days < 180)
                {
                    return interval.Days;
                }
                else
                {
                    return 0;
                }
            }
        }
        static int GetStringLength(string str)
        {
            int length = 0;

            foreach (char c in str)
            {
                length++;
            }

            return length;
        }
        static int CountWords(string str)
        {
            string[] words = str.Split(new[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            return words.Length;
        }
        static char FindMostCommonCharacter(string str)
        {
            Dictionary<char, int> charCount = new Dictionary<char, int>();

            foreach (char c in str)
            {
                if (charCount.ContainsKey(c))
                {
                    charCount[c]++;
                }
                else
                {
                    charCount[c] = 1;
                }
            }

            KeyValuePair<char, int> mostCommon = charCount.OrderByDescending(kv => kv.Value).First();
            return mostCommon.Key;
        }
        static bool CheckCredentials(string enteredUsername, string enteredPassword, string validUsername, string validPassword)
        {
            return enteredUsername == validUsername && enteredPassword == validPassword;
        }
        static int CountSubstringOccurrences(string initialString, string substring)
        {
            int occurrences = 0;
            int index = 0;

            while ((index = initialString.IndexOf(substring, index)) != -1)
            {
                occurrences++;
                index += substring.Length;
            }

            return occurrences;
        }
        static int CountCharacterOccurrences(string str, char character)
        {
            int count = 0;

            foreach (char c in str)
            {
                if (c == character)
                {
                    count++;
                }
            }

            return count;
        }
        static string InsertSubstringBeforeFirstOccurrence(string original, string target, string substringToInsert)
        {
            int index = original.IndexOf(target);

            if (index != -1)
            {
                string modifiedString = original.Substring(0, index) +
                                        substringToInsert +
                                        original.Substring(index);

                return modifiedString;
            }

            return original; // Target substring not found, return original string as is
        }
        static void Main(string[] args)
        {
            //Console.OutputEncoding = Encoding.UTF8; // Set the console's encoding to UTF-8
            //Console.WriteLine("--------------------------------------------------------");
            //Console.WriteLine("ProductNumber:");

            //var n = Convert.ToInt32(Console.ReadLine());
            //var structProd = new Product();
            //Product[] products = new Product[n];
            //for (int i = 0; i < n; i++)
            //{
            //    products[i] = new Product();
            //    Console.WriteLine("ProductName:");
            //    products[i]._productName = Convert.ToString(Console.ReadLine());
            //    Console.WriteLine("ProductPrice:");
            //    products[i]._productPrice = Convert.ToDecimal(Console.ReadLine());
            //    Console.WriteLine("ExpiredDate:");
            //    DateTime expireDate;
            //    while (!DateTime.TryParseExact(Console.ReadLine(), "dd-MM-yyyy", null, System.Globalization.DateTimeStyles.None, out expireDate))
            //    {
            //        Console.WriteLine("Invalid date format. Please enter the date in dd-MM-yyyy format:");
            //    }
            //    products[i]._expireDate = expireDate;
            //}
            //foreach (var product in products)
            //{
            //    int run = structProd.Run(product._expireDate);
            //    if (run > 0 && run <= 30)
            //    {
            //        Console.WriteLine("Products with Expiry Dates: {0}", product._productName);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Products have not with Expiry Dates: {0}");
            //    }
            //}
            //foreach (var product in products)
            //{
            //    if (product._productName.Length > 10)
            //    {
            //        Console.WriteLine("Products > 10 character: {0}", product._productName);
            //    }    
            //}    

            //Console.WriteLine("--------------------------------------------------------");
            //Console.WriteLine("Kiểm tra xem ký tự vừa nhập có phải là chữ cái không, sau đó kiểm tra xem đó là chữ hoa hay chữ thường");
            //Console.Write("Enter a character: ");
            //char inputChar = Console.ReadKey().KeyChar;

            //if (char.IsLetter(inputChar))
            //{
            //    if (char.IsUpper(inputChar))
            //    {
            //        Console.WriteLine("\nYou entered an uppercase letter.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("\nYou entered a lowercase letter.");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("\nYou did not enter a letter.");
            //}

            //Console.WriteLine("--------------------------------------------------------");
            //Console.WriteLine("Nhập vào một chuỗi và một ký tự từ bàn phím, và in ra màn hình số lần xuất hiện của ký tự đó trong chuỗi");

            //Console.Write("Enter a string: ");
            //string inputString = Console.ReadLine();

            //Console.Write("Enter a character: ");
            //char inputChar = Console.ReadKey().KeyChar;

            //int occurrences = CountCharacterOccurrences(inputString, inputChar);

            //Console.WriteLine($"\nNumber of occurrences of '{inputChar}' in the string: {occurrences}");

            //Console.WriteLine("--------------------------------------------------------");
            //string vietnameseText1 = "Tìm độ dài của một chuỗi mà không sử dụng hàm trong thư viện";
            //Console.WriteLine(vietnameseText1);
            //int lenght = GetStringLength(vietnameseText1);
            //Console.WriteLine("Độ dài của chuỗi: " + lenght);

            //Console.WriteLine("--------------------------------------------------------");
            //string vietnameseText2 = "Đếm số từ có trong 1 chuỗi";
            //int wordCount = CountWords(vietnameseText2);
            //Console.WriteLine("Number of words: " + wordCount);

            //Console.WriteLine("--------------------------------------------------------");
            //string vietnameseText3 = "Nhập một chuỗi, sau đó tìm ký tự xuất hiện nhiều nhất trong chuỗi đó và in kết quả";
            //Console.WriteLine(vietnameseText3);
            //Console.Write("Enter a string: ");
            //string input = Console.ReadLine();

            //char mostCommonChar = FindMostCommonCharacter(input);

            //Console.WriteLine("Most common character: " + mostCommonChar);

            //Console.WriteLine("--------------------------------------------------------");
            //string vietnameseText4 = "Kiểm tra username và password và in ra thông báo rằng người dùng đã nhập đúng hay sai username và password";
            //Console.WriteLine(vietnameseText4);
            //string validUsername = "thienbk";
            //string validPassword = "0305";

            //Console.Write("Enter username: ");
            //string enteredUsername = Console.ReadLine();

            //Console.Write("Enter password: ");
            //string enteredPassword = Console.ReadLine();
            //if (CheckCredentials(enteredUsername, enteredPassword, validUsername, validPassword))
            //{
            //    Console.WriteLine("You entered the correct username and password.");
            //}
            //else
            //{
            //    Console.WriteLine("Incorrect username or password.");
            //}

            //Console.WriteLine("--------------------------------------------------------");
            //string vietnameseText5 = "Nhập hai chuỗi: một chuỗi ban đầu và một chuỗi con cần đếm. Sau đó đếm số lần xuất hiện của chuỗi con trong chuỗi ban đầu";
            //Console.WriteLine(vietnameseText5);
            //Console.Write("Enter the initial string: ");
            //string initialString = Console.ReadLine();

            //Console.Write("Enter the substring to count: ");
            //string substring = Console.ReadLine();

            //int occurrences = CountSubstringOccurrences(initialString, substring);

            //Console.WriteLine($"Number of occurrences of '{substring}' in the string: {occurrences}");

            //Console.WriteLine("--------------------------------------------------------");
            //Console.WriteLine("Chèn chuỗi con trước vị trí xuất hiện lần đầu của chuỗi con khác trong một chuỗi ban đầu");
            //string originalString = "Please This is a sample string. This is another occurrence.";

            //Console.WriteLine("Original String:");
            //Console.WriteLine(originalString);

            //string substringToInsert = "INSERTED ";

            //string modifiedString = InsertSubstringBeforeFirstOccurrence(originalString, "This", substringToInsert);

            //Console.WriteLine("\nModified String: " + modifiedString);

            //Console.WriteLine("--------------------------------------------------------");
            //Console.WriteLine("Tìm kiếm vị trí của chuỗi con trong chuỗi đã cho, rồi in kết quả trên màn hình");
            //string inputString = "This is a sample string for substring search.";
            //Console.WriteLine(inputString);
            //string targetSubstring = "substring";
            //Console.WriteLine(targetSubstring);
            //int position = inputString.IndexOf(targetSubstring);
            //if (position != -1)
            //{
            //    Console.WriteLine($"The position of '{targetSubstring}' in the string is: {position}");
            //}
            //else
            //{
            //    Console.WriteLine($"'{targetSubstring}' not found in the string.");
            //}

            //EmployeeManager manager = new EmployeeManager();
            //manager.AddEmployee("A", 28, 50000);
            //manager.AddEmployee("B", 32, 60000);
            //Console.WriteLine("Nhân Viên sau khi được thêm:");
            //manager.ShowEmployees();

            //manager.EditEmployee(0, "C", 29, 52000);
            //manager.CancelEmployee(1);

            //Console.WriteLine("Nhân viên sau khi được sửa và huỷ:");
            //manager.ShowEmployees();

           
            while (true)
            {
                Console.WriteLine("Select an option:");
                Console.WriteLine("1. Nhập giá trị cho danh sách học sinh");
                Console.WriteLine("2. Sắp xếp học sinh theo chiều tăng dần của điểm trung bình");
                Console.WriteLine("3. Tìm đối tượng học sinh có điểm toán cao nhất");
                Console.WriteLine("4. Hiển thị tất cả học sinh có tuổi lớn hơn 23");
                Console.WriteLine("5. Tìm tất cả sinh viên có họ (Hoàng)");
                Console.WriteLine("6. Hiển thị danh sách sinh viên có địa chỉ ở (Hà nộ)");
                Console.WriteLine("7. Exit");

                int option = int.Parse(Console.ReadLine());

                StudentManager studentManager = new StudentManager();
                if (option == 1)
                {
                    int n;
                    Console.WriteLine("Nhập số lượng học sinh: ");
                    n = int.Parse(Console.ReadLine());

                    for (int i = 0; i < n; i++)
                    {
                        Student students = new Student();

                        Console.WriteLine("student ID: ");
                        students.Id = int.Parse(Console.ReadLine());

                        Console.WriteLine("student name: ");
                        students.Name = Console.ReadLine();

                        Console.WriteLine("student age: ");
                        students.Age = int.Parse(Console.ReadLine());

                        Console.WriteLine("student address: ");
                        students.Address = Console.ReadLine();

                        Console.WriteLine("student gpa: ");
                        students.GPA = double.Parse(Console.ReadLine());

                        Console.WriteLine("student mathScore: ");
                        students.MathScore = double.Parse(Console.ReadLine());

                        studentManager.AddStudent(students);

                    }
                    studentManager.ShowStudent();
                }
                else if (option == 2)
                {
                    studentManager.SortByGPA();

                    Console.WriteLine("\nSắp xếp học sinh theo chiều tăng dần của điểm trung bình:");
                    studentManager.ShowStudent();
                }
                else if (option == 3)
                {
                    Student studentWithHighestMathScore = studentManager.FindStudentWithHighestMathScore();

                    if (studentWithHighestMathScore != null)
                    {
                        Console.WriteLine("Student with the highest math score:");
                        Console.WriteLine(studentWithHighestMathScore.MathScore);
                    }
                    else
                    {
                        Console.WriteLine("No students in the list.");
                    }
                }
                else if (option == 4)
                {
                    int targetAge = 23;

                    List<Student> studentsAboveAge = studentManager.GetStudentsAboveAge(targetAge);

                    Console.WriteLine($"Students above age {targetAge}:");
                    foreach (Student student in studentsAboveAge)
                    {
                        Console.WriteLine("Student ID: {0}, Name: {1}, Age: {2}, Address: {3}, GPA: {4}, MathScore: {5}", student.Id, student.Name, student.Age, student.Address, student.GPA, student.MathScore);
                    }
                }
                else if (option == 5)
                {
                    string firstName = "Hoang";
                    Console.WriteLine($"Students have FirstName ({firstName}):");
                    List<Student> studentFirstName = studentManager.FindStudentsFirstName(firstName);
                    if (studentFirstName.Count > 0)
                    {
                        foreach (Student student in studentFirstName)
                        {
                            Console.WriteLine("Student ID: {0}, Name: {1}", student.Id, student.Name);
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Students have not FirstName {firstName}:");
                    }
                }
                else if (option == 6)
                {
                    string address = "Ha noi";
                    Console.WriteLine($"The Address have Name ({address}):");
                    List<Student> studentAddressName = studentManager.FindAddressName(address);
                    if (studentAddressName.Count > 0)
                    {
                        foreach (Student student in studentAddressName)
                        {
                            Console.WriteLine("Address: {0}", student.Address);
                        }
                    }
                    else
                    {
                        Console.WriteLine($"The Address have not Name ({address}):");
                    }
                }
                else if (option == 7)
                {
                    break;
                }
                    Console.ReadKey();
            Console.ReadLine();
        }
    }
}
