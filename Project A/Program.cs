using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static Project_A.Program;

namespace Project_A
{
    public class Program
    {
        //public struct Product
        //{
        //    public string _productName { get; set; }
        //    public decimal _productPrice { get; set; }
        //    public DateTime _expireDate { get; set; }
        //    public int Run(DateTime expireDate)
        //    {
        //        TimeSpan interval = expireDate.Subtract(DateTime.Now);

        //        if (interval.Days < 180)
        //        {
        //            return interval.Days;
        //        }
        //        else
        //        {
        //            return 0;
        //        }
        //    }
        //}
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
            Console.OutputEncoding = Encoding.UTF8;
            // Set the console's encoding to UTF-8
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

            //while (true)
            //{
            //    Console.WriteLine("Select an option:");
            //    Console.WriteLine("1. Nhập giá trị cho danh sách học sinh");
            //    Console.WriteLine("2. Sắp xếp học sinh theo chiều tăng dần của điểm trung bình");
            //    Console.WriteLine("3. Tìm đối tượng học sinh có điểm toán cao nhất");
            //    Console.WriteLine("4. Hiển thị tất cả học sinh có tuổi lớn hơn 23");
            //    Console.WriteLine("5. Tìm tất cả sinh viên có họ (Hoàng)");
            //    Console.WriteLine("6. Hiển thị danh sách sinh viên có địa chỉ ở (Hà nộ)");
            //    Console.WriteLine("7. Exit");

            //    int option = int.Parse(Console.ReadLine());

            //    StudentManager studentManager = new StudentManager();
            //    if (option == 1)
            //    {
            //        Console.WriteLine("1. Nhập giá trị cho danh sách học sinh");
            //        int n;
            //        Console.WriteLine("Nhập số lượng học sinh: ");
            //        n = int.Parse(Console.ReadLine());

            //        for (int i = 0; i < n; i++)
            //        {
            //            Student students = new Student();

            //            Console.WriteLine("student ID " + i + ": ");
            //            students.Id = int.Parse(Console.ReadLine());

            //            Console.WriteLine("student name " + i + ": ");
            //            students.Name = Console.ReadLine();

            //            Console.WriteLine("student age " + i + ": ";
            //            students.Age = int.Parse(Console.ReadLine());

            //            Console.WriteLine("student address " + i + ": ");
            //            students.Address = Console.ReadLine();

            //            Console.WriteLine("student gpa " + i + ": ");
            //            students.GPA = double.Parse(Console.ReadLine());

            //            Console.WriteLine("student mathScore " + i + ": ");
            //            students.MathScore = double.Parse(Console.ReadLine());

            //            studentManager.AddStudent(students);

            //        }
            //        studentManager.ShowStudent();
            //    }
            //    else if (option == 2)
            //    {
            //        Console.WriteLine("2. Sắp xếp học sinh theo chiều tăng dần của điểm trung bình");
            //        studentManager.SortByGPA();

            //        Console.WriteLine("\nSắp xếp học sinh theo chiều tăng dần của điểm trung bình:");
            //        studentManager.ShowStudent();
            //    }
            //    else if (option == 3)
            //    {
            //        Console.WriteLine("3. Tìm đối tượng học sinh có điểm toán cao nhất");
            //        Student studentWithHighestMathScore = studentManager.FindStudentWithHighestMathScore();

            //        if (studentWithHighestMathScore != null)
            //        {
            //            Console.WriteLine("Student with the highest math score:");
            //            Console.WriteLine(studentWithHighestMathScore.MathScore);
            //        }
            //        else
            //        {
            //            Console.WriteLine("No students in the list.");
            //        }
            //    }
            //    else if (option == 4)
            //    {
            //        Console.WriteLine("4. Hiển thị tất cả học sinh có tuổi lớn hơn 23");
            //        int targetAge = 23;

            //        List<Student> studentsAboveAge = studentManager.GetStudentsAboveAge(targetAge);

            //        Console.WriteLine($"Students above age {targetAge}:");
            //        foreach (Student student in studentsAboveAge)
            //        {
            //            Console.WriteLine("Student ID: {0}, Name: {1}, Age: {2}, Address: {3}, GPA: {4}, MathScore: {5}", student.Id, student.Name, student.Age, student.Address, student.GPA, student.MathScore);
            //        }
            //    }
            //    else if (option == 5)
            //    {
            //        Console.WriteLine("5. Tìm tất cả sinh viên có họ (Hoàng)");
            //        string firstName = "Hoang";
            //        Console.WriteLine($"Students have FirstName ({firstName}):");
            //        List<Student> studentFirstName = studentManager.FindStudentsFirstName(firstName);
            //        if (studentFirstName.Count > 0)
            //        {
            //            foreach (Student student in studentFirstName)
            //            {
            //                Console.WriteLine("Student ID: {0}, Name: {1}", student.Id, student.Name);
            //            }
            //        }
            //        else
            //        {
            //            Console.WriteLine($"Students have not FirstName {firstName}:");
            //        }
            //    }
            //    else if (option == 6)
            //    {
            //        Console.WriteLine("6. Hiển thị danh sách sinh viên có địa chỉ ở (Hà nộ)");
            //        string address = "Ha noi";
            //        Console.WriteLine($"The Address have Name ({address}):");
            //        List<Student> studentAddressName = studentManager.FindAddressName(address);
            //        if (studentAddressName.Count > 0)
            //        {
            //            foreach (Student student in studentAddressName)
            //            {
            //                Console.WriteLine("Address: {0}", student.Address);
            //            }
            //        }
            //        else
            //        {
            //            Console.WriteLine($"The Address have not Name ({address}):");
            //        }
            //    }
            //    else if (option == 7)
            //    {
            //        break;
            //    }

            //}
            //Student_P student = new Student_P();
            //student.SetName("John");
            //student.SetAge(20);

            //Teacher teacher = new Teacher();
            //teacher.SetName("Ms. Smith");
            //teacher.SetJob("Math Teacher");

            //Console.WriteLine("Student Information:");
            //student.ShowStudentInfo();

            //Console.WriteLine("\nTeacher Information:");
            //teacher.ShowTeacherInfo();

            //List<Book> books = new List<Book>();
            //int n;
            //Console.WriteLine("Enter Number Books: ");
            //n = int.Parse(Console.ReadLine());
            //for (int i = 1;i<n+1; i++)
            //{
            //    Book book = new Book();

            //    Console.WriteLine("Title " + i + ": ");
            //    book.Title = Console.ReadLine();

            //    Console.WriteLine("Author " + i + ": ");
            //    book.Author = Console.ReadLine();

            //    Console.WriteLine("Publisher " + i + ": ");
            //    book.Publisher = Console.ReadLine();

            //    Console.WriteLine("YearOfPublication " + i + ": ");
            //    book.YearOfPublication = int.Parse(Console.ReadLine());

            //    Console.WriteLine("ISBN " + i + ": ");
            //    book.ISBN = Console.ReadLine();
            //    books.Add(book);
            //}
            //foreach (var book in books)
            //{
            //    Console.WriteLine("PrintBookInfo: ");
            //    book.PrintBookInfo();
            //}

            //Console.WriteLine("Enter Number Garages: ");
            //List<Car> garage = new List<Car>();
            //int nCar = int.Parse(Console.ReadLine());
            //for(int i = 1; i<nCar+1; i++) 
            //{
            //    Car car = new Car();

            //    Console.WriteLine("VehicleName " + i + ": ");
            //    car.VehicleName = Console.ReadLine();

            //    Console.WriteLine("EngineNumber " + i + ": ");
            //    car.EngineNumber = Console.ReadLine();

            //    Console.WriteLine("Manufacturer " + i + ": ");
            //    car.Manufacturer = Console.ReadLine();

            //    Console.WriteLine("YearOfManufacture " + i + ": ");
            //    car.YearOfManufacture = int.Parse(Console.ReadLine());

            //    Console.WriteLine("Quantity " + i + ": ");
            //    car.Quantity = int.Parse(Console.ReadLine());
            //    garage.Add(car);
            //}
            //Console.WriteLine("Cars in the Garage:");
            //foreach (Car car in garage)
            //{
            //    car.PrintCarInfo();
            //    Console.WriteLine();
            //}
            //Console.WriteLine("Toyota Cars in the Garage:");
            //foreach (Car car in garage)
            //{
            //    if (car.Manufacturer.Equals("Toyota", StringComparison.OrdinalIgnoreCase))
            //    {
            //        Console.WriteLine(car.VehicleName);
            //    }
            //}

            //Console.WriteLine("Enter Number supermarketGoods: ");
            //List<Good> supermarketGoods = new List<Good>();
            //int nGoods = int.Parse(Console.ReadLine());
            //for (int i = 1; i<nGoods+1; i++)
            //{
            //    Good goods = new Good();
            //    Console.WriteLine("Code " + i + ": ");
            //    goods.Code = int.Parse(Console.ReadLine());

            //    Console.WriteLine("GoodName " + i + ": ");
            //    goods.GoodName = Console.ReadLine();

            //    Console.WriteLine("Quantity " + i + ": ");
            //    goods.Quantity = int.Parse(Console.ReadLine());

            //    Console.WriteLine("UnitPrice " + i + ": ");
            //    goods.UnitPrice = decimal.Parse(Console.ReadLine());

            //    supermarketGoods.Add(goods);
            //}

            //Console.WriteLine("Goods in the Supermarket:");
            //foreach (Good good in supermarketGoods)
            //{
            //    good.PrintGoodInfo();
            //    Console.WriteLine();
            //}

            //Console.WriteLine("Goods with Quantity Less Than 5 for Import:");
            //foreach (Good good in supermarketGoods)
            //{
            //    if (good.Quantity < 5)
            //    {
            //        Console.WriteLine(good.GoodName);
            //    }
            //}

            //Console.WriteLine("Enter Number Bills: ");
            //List<Item> items = new List<Item>();
            //int nitems = int.Parse(Console.ReadLine());
            //for (int i = 1; i < nitems + 1; i++)
            //{
            //    Item item = new Item();
            //    Console.WriteLine("Code " + i + ": ");
            //    item.CommodityCode = int.Parse(Console.ReadLine());

            //    Console.WriteLine("GoodName " + i + ": ");
            //    item.GoodName = Console.ReadLine();

            //    Console.WriteLine("Quantity " + i + ": ");
            //    item.Quantity = int.Parse(Console.ReadLine());

            //    Console.WriteLine("UnitPrice " + i + ": ");
            //    item.UnitPrice = decimal.Parse(Console.ReadLine());

            //    items.Add(item);
            //}
            //Item item1 = new Item();
            //Console.WriteLine("Customer Purchase Invoice:");
            //item1.PrintBill();

            //Console.WriteLine("Nhập số lượng sinh viên");
            //int n= int.Parse(Console.ReadLine());
            //List<Student_1> studentManager = new List<Student_1>();
            //for (int i = 0; i < n; i++)
            //{
            //    Student_1 students = new Student_1();

            //    Console.WriteLine("Number " + i + ": ");
            //    students.Number = int.Parse(Console.ReadLine());

            //    Console.WriteLine("FullName " + i + ": ");
            //    students.FullName = Console.ReadLine();

            //    Console.WriteLine("StudentID " + i + ": ");
            //    students.StudentID = Console.ReadLine();

            //    Console.WriteLine("ComponentScore " + i + ": ");
            //    students.ComponentScore = int.Parse(Console.ReadLine());

            //    Console.WriteLine("ExamScore " + i + ": ");
            //    students.ExamScore = double.Parse(Console.ReadLine());

            //    Console.WriteLine("EndScore " + i + ": ");
            //    students.EndScore = double.Parse(Console.ReadLine());

            //    studentManager.Add(students);

            //}
            //Console.WriteLine("Students Needing Retake:");
            //foreach (Student_1 student in studentManager)
            //{
            //    if (student.RetakeScore())
            //    {
            //        student.PrintStudentInfo();
            //        Console.WriteLine();
            //    }
            //}

            //IProductManager productManager = new ProductManager();
            //IProductOrder productOrderManager = new ProductOrderManager();
            //while (true)
            //{
            //    Console.WriteLine("1. Nhập vào thông tin danh sách các sản phẩm");
            //    Console.WriteLine("2. Hiển thị danh sách sản phẩm");
            //    Console.WriteLine("3. Update thông tin sản phẩm với id sản phẩm nhập từ bàn phím");
            //    Console.WriteLine("4. Xóa sản phẩm với id sản phẩm nhập từ bàn phím");
            //    Console.WriteLine("5. Ghi danh sách sản phẩm xuống file text");
            //    Console.WriteLine("6. Thực hiện mua một sản phẩm (mua trên 5 sản phẩm sẽ được chiết khấu 5%) và hiển thị danh sách đơn hàng");
            //    Console.WriteLine("0. Thoát");
            //    Console.Write("Vui lòng chọn: ");
            //    int choice = int.Parse(Console.ReadLine());
            //    switch (choice)
            //    {
            //        case 1:
            //            Product newProduct = new Product();
            //            Console.Write("Enter Id: ");
            //            newProduct.Id = int.Parse(Console.ReadLine());
            //            Console.Write("Enter Product Name: ");
            //            newProduct.Name = Console.ReadLine();
            //            Console.Write("Enter Product Price: ");
            //            newProduct.Price = decimal.Parse(Console.ReadLine());
            //            Console.Write("Enter Product Quantity: ");
            //            newProduct.Quantity = int.Parse(Console.ReadLine());

            //            productManager.ProductInsert(newProduct);
            //            break;
            //        case 2:
            //            productManager.ShowProductList();
            //            break;
            //        case 3:
            //            Console.Write("Enter Product ID to Update: ");
            //            int idToUpdate = int.Parse(Console.ReadLine());

            //            Product productToUpdate = productManager.GetProductById(idToUpdate);
            //            if (productToUpdate != null)
            //            {
            //                Console.Write("Enter Updated Product Name: ");
            //                string updatedName = Console.ReadLine();
            //                Console.Write("Enter Updated Product Price: ");
            //                decimal updatedPrice = decimal.Parse(Console.ReadLine());
            //                Console.Write("Enter Updated Product Quantity: ");
            //                int updatedQuantity = int.Parse(Console.ReadLine());

            //                Product updatedProduct = new Product { Id = productToUpdate.Id, Name = updatedName, Price = updatedPrice, Quantity = updatedQuantity };
            //                productManager.ProductUpdate(idToUpdate, updatedProduct);
            //            }
            //            else
            //            {
            //                Console.WriteLine("Product not found.");
            //            }
            //            break;

            //        case 4:
            //            Console.Write("Enter Product ID to Delete: ");
            //            int idToDelete = int.Parse(Console.ReadLine());
            //            productManager.ProductDelete(idToDelete);
            //            break;

            //        case 5:
            //            Console.Write("Enter File Name to Save: ");
            //            string fileName = Console.ReadLine();
            //            productManager.SaveToFile(fileName);
            //            break;

            //        case 6:
            //            Console.Write("Enter Product Code to Place Order: ");
            //            int productCode = int.Parse(Console.ReadLine());
            //            Product product = productManager.GetProductById(productCode);
            //            if (product != null)
            //            {
            //                Console.Write("Enter Quantity: ");
            //                int orderQuantity = int.Parse(Console.ReadLine());
            //                decimal totalAmount = orderQuantity >= 5 ? product.Price * orderQuantity * 0.95M : product.Price * orderQuantity;

            //                ProductOrder order = new ProductOrder
            //                {
            //                    ProductCode = productCode,
            //                    Quantity = orderQuantity,
            //                    Money = totalAmount
            //                };

            //                productOrderManager.PlaceProductOrder(order);
            //                productOrderManager.ShowOrderList();
            //            }
            //            else
            //            {
            //                Console.WriteLine("Product not found.");
            //            }
            //            break;
            //        case 0: return;
            //        default:
            //            Console.WriteLine("Chọn chưa đúng");
            //            break;
            //    }
            //}

            //Console.Write("Nhập Số Lượng Hành Khách: ");
            //int n = int.Parse(Console.ReadLine());

            //List<Hanhkhach> passengers = new List<Hanhkhach>();
            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine($"Nhập Thông Tin Hành Khách {i + 1}");
            //    Hanhkhach passenger = new Hanhkhach();
            //    passenger.Enter_HK();
            //    passengers.Add(passenger);
            //    Console.WriteLine();
            //}

            //Console.WriteLine("Danh Sách Hành KHách:");
            //foreach (Hanhkhach passenger in passengers)
            //{
            //    passenger.Print_HK();
            //    Console.WriteLine($"Tổng tiền: {passenger.TongTien():C}");
            //    Console.WriteLine();
            //}

            //passengers.Sort((p1, p2) => p2.TongTien().CompareTo(p1.TongTien()));

            //Console.WriteLine("Sắp Xếp Danh Sách Hành Khách (Giảm Dần Của Tổng Tiền):");
            //foreach (Hanhkhach passenger in passengers)
            //{
            //    passenger.Print_HK();
            //    Console.WriteLine($"Tổng Số Tiền: {passenger.TongTien():C}");
            //    Console.WriteLine();
            //}

            //IEmployeeManager_1 employeeManager = new EmployeeManager_1();
            //while (true)
            //{
            //    Console.WriteLine("1. Thêm nhân viên");
            //    Console.WriteLine("2. Cập nhật thông tin nhân viên bởi ID");
            //    Console.WriteLine("3. Xóa nhân viên bởi ID");
            //    Console.WriteLine("4. Tìm kiếm nhân viên theo tên");
            //    Console.WriteLine("5. Thoát");
            //    Console.Write("Vui lòng chọn: ");
            //    int choice = int.Parse(Console.ReadLine());
            //    switch (choice)
            //    {
            //        case 1:
            //            Console.Write("Nhập Tên Nhân Viên: ");
            //            string Ten = Console.ReadLine();
            //            Console.Write("Nhập Giới Tính: ");
            //            string GioiTinh = Console.ReadLine();
            //            Console.Write("Nhập Tuổi: ");
            //            int Tuoi = int.Parse(Console.ReadLine());
            //            Console.Write("Nhập Lương Căn Bản: ");
            //            decimal LuongCanBan = decimal.Parse(Console.ReadLine());
            //            Console.Write("Nhập Phụ Cấp: ");
            //            decimal PhuCap = decimal.Parse(Console.ReadLine());

            //            Employee_1 newEmployee = new Employee_1
            //            {
            //                Id = employeeManager.GenerateRandomId(),
            //                Ten = Ten,
            //                GioiTinh = GioiTinh,
            //                Tuoi = Tuoi,
            //                LuongCanBan = LuongCanBan,
            //                PhuCap = PhuCap
            //            };

            //            employeeManager.AddEmployee(newEmployee);
            //            employeeManager.ShowEmployeeList();
            //            break;
            //        case 2:
            //            Console.Write("Cập nhật thông tin nhân viên bởi ID: ");
            //            string idToUpdate = Console.ReadLine();

            //            Employee_1 employeeToUpdate = employeeManager.GetEmployeeById(idToUpdate);
            //            if (employeeToUpdate != null)
            //            {
            //                Console.Write("Nhập Tên Nhân Viên: ");
            //                string updatedName = Console.ReadLine();
            //                Console.Write("Nhập Giới Tính: ");
            //                string updateGender = Console.ReadLine();
            //                Console.Write("Nhập Tuổi: ");
            //                int updateAge = int.Parse(Console.ReadLine());

            //                Employee_1 updatedEmployee = new Employee_1 { Id = employeeToUpdate.Id, Ten = updatedName, GioiTinh = updateGender, Tuoi = updateAge };
            //                employeeManager.UpdateEmployee(idToUpdate, updatedEmployee);

            //                List<Employee_1> employees = new List<Employee_1>();
            //                foreach (Employee_1 emp in employees)
            //                {
            //                    Console.WriteLine($"ID: {emp.Id}, Tên: {emp.Ten}, GioiTinh: {emp.GioiTinh}, Tuổi: {emp.Tuoi}");
            //                }
            //            }
            //            else
            //            {
            //                Console.WriteLine("Không Tìm Thấy Nhân Viên Này");
            //            }
            //            break;
            //        case 3:
            //            Console.Write("Xóa nhân viên bởi ID: ");
            //            string idToDelete = Console.ReadLine();
            //            employeeManager.DeleteEmployee(idToDelete);
            //            break;
            //        case 4:
            //            Console.Write("Tìm kiếm nhân viên theo tên: ");
            //            string searchName = Console.ReadLine();

            //            List<Employee_1> searchResults = employeeManager.SearchEmployeesByName(searchName);
            //            if (searchResults.Count > 0)
            //            {
            //                foreach (Employee_1 emp in searchResults)
            //                {
            //                    Console.WriteLine($"Id: {emp.Id}, Tên: {emp.Ten}, Tổng Lương: {emp.TongLuong:C}");
            //                }
            //            }
            //            else
            //            {
            //                Console.WriteLine("Không Tìm Thấy");
            //            }
            //            break;
            //        default:
            //            Console.WriteLine("Chọn Chưa Đúng");
            //            break;
            //    }
            //    Console.ReadKey();
            //}
            Console.Write("Nhập Số Lượng Khách Hàng: ");
            int n = int.Parse(Console.ReadLine());

            List<KhachHang> customers = new List<KhachHang>();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Nhập Thông Tin KH thứ  {i + 1}:");
                KhachHang customer = new KhachHang();
                customer.Enter();
                customers.Add(customer);
            }

            Console.WriteLine("\n-----------Danh Sách KH-----------:");
            foreach (KhachHang customer in customers)
            {
                customer.Print();
                Console.WriteLine();
            }

            customers.Sort((c1, c2) => c2.TongTien().CompareTo(c1.TongTien()));

            Console.WriteLine("\n-----------Danh Sách KH Theo Tổng Giao Dịch Giảm Dần-----------:");
            foreach (KhachHang customer in customers)
            {
                customer.Print();
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
