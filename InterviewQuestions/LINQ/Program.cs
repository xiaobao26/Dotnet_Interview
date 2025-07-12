namespace LINQ;
public class Student
{
    public int StuId;
    public string StuName;
    public int GrPoint;
}

public class Item_mast
{
    public int ItemId;
    public string ItemDes;
}

public class Purchase
{
    public int InvNo;
    public int ItemId;
    public int PurQty;
}

public class Program
{
    public static void Main(string[] args)
    {
        #region Question1: The numbers which produce the remainder 0 after divided by 2 are?

        var q1 = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        var res = q1.Where(x => x % 2 == 0);
        foreach (var i in res)
        {
            // Console.WriteLine(i);
        }
        #endregion

        #region Question2: Find the +ve numbers from a list of numbers using two where conditions in LINQ Query.

        var q2 = new int[] { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };
        var res2 = q2.Where(x => x > 0 && x < 12);
        
        foreach (var i in res2)
        {
            // Console.WriteLine(i);
        }

        #endregion

        #region Question3:  Find the number of an array and the square of each number.

        var q3 = new int[] { 3, 9, 2, 8, 6, 5 };
        var res3 = q3.Where(x => x * x > 20).Select(x => new { Number = x, SqrNo = x * x});
        foreach (var i in res3)
        {
            // Console.WriteLine(i);
        }

        #endregion

        #region Question4: Display the number and frequency of a given number from an array.

        var q4 = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };
        var res4 = q4.GroupBy(x => x).Select(g => new {Number = g.Key, Freq = g.Count()});

        foreach (var i in res4)
        {
            // Console.WriteLine(i);
        }
        #endregion

        #region Queestion5: Display the characters and frequency of each character in a given

        // Console.Write("Please enter the characters: ");
        // var input = Console.ReadLine();
        // var res5 = input.GroupBy(c => c).Select(g => new { Character = g.Key, Freq = g.Count() });

        // foreach (var i in res5)
        // {
            // Console.WriteLine(i);
        // }
        #endregion

        #region Question6: Display numbers, multiplication of numbers with frequency and the frequency of a number in an array.

        var q6 = new int[] { 5, 1, 9, 2, 3, 7, 4, 5, 6, 8, 7, 6, 3, 4, 5, 2 };
        var res6 = q6.GroupBy(x => x)
            .Select(g => new { Number = g.Key, multiplication = g.Key * g.Count(), Freq = g.Count() });
        foreach (var i in res6)
        {
            // Console.WriteLine(i);
        }
        #endregion
        
        #region Question7:The city starting with A and ending with M

        var ans7 = new string[] {"ROME","LONDON","NAIROBI","CALIFORNIA","ZURICH","NEW DELHI","AMSTERDAM","ABU DHABI","PARIS" };
        var res7 = ans7.Where(x => x[0] == 'A' &&  x[^1] == 'M');
        foreach (var i in res7)
        {
            // Console.WriteLine(i);
        }
        #endregion

        #region Question8: Display numbers greater than 80.

        var ans8 = new int[] { 55, 200, 740, 76, 230, 482, 95 };
        var res8 = ans8.Where(x => x > 80);
        foreach (var i in res8)
        {
            // Console.WriteLine(i);
        }

        #endregion

        #region Question9: Accept list members through the keyboard and display them more than a specific value.
        // Console.Write("Please enter a list of numbers: ");
        // var ans9 = Console.ReadLine();
        // var listOfStringNumbers = ans9.Split(' ');
        //
        // Console.WriteLine("please enter a number you want to compared with: ");
        // var stringNumber = Console.ReadLine();
        // if (Int32.TryParse(stringNumber, out int intNumber))
        // {
        //     var res9 = listOfStringNumbers.Where(x => Int32.TryParse(x, out int nb) && nb > intNumber);
        //     foreach (var i in res9)
        //     {
        //         Console.WriteLine(i);
        //     }
        // }
        #endregion

        #region Question10: Display the top n-th records.

        var ans10 = new int[] {5,7,12,13,24,31,45,6,2,1 };
        var res10 = ans10.OrderByDescending(x => x).Take(3);
        foreach (var i in res10)
        {
            // Console.WriteLine(i);
        }

        #endregion

        #region Question11: Find uppercase words in a string.

        var ans11 = "this IS a STRING";
        var res11 = ans11.Split(' ')
            .Where(x => string.Equals(x, x.ToUpper(), StringComparison.Ordinal));

        foreach (var i in res11)
        {
            // Console.WriteLine(i);
        }

        #endregion

        #region Question12: Convert a string array to a string.

        var ans12 = new string[] { "cat", "dog", "rat" };
        var res12 = string.Join(",", ans12);
        // Console.WriteLine(res12);
        #endregion

        #region Question13: Find 3-th maximum grade point achieved by the students from the list of students.
        
        var ans13 = new List<Student>
        {
            new Student { StuId = 1, StuName = " Joseph ", GrPoint = 800 },
            new Student { StuId = 2, StuName = " XXB ", GrPoint = 800 },
            new Student { StuId = 3, StuName = " HHF ", GrPoint = 700 },
            new Student { StuId = 4, StuName = " CCD ", GrPoint = 600 },
            new Student { StuId = 5, StuName = " JJO ", GrPoint = 500 },
            new Student{ StuId = 6, StuName = " PXP ", GrPoint = 900 },
            new Student { StuId = 7, StuName = " ABC ", GrPoint = 500 },
            new Student { StuId = 8, StuName = " CBC ", GrPoint = 200 },
        };

        var res13 = ans13.OrderByDescending(x => x.GrPoint).Take(3);
        foreach (var i in res13)
        {
            // Console.WriteLine($"{i.StuId} {i.StuName} {i.GrPoint}");
        }

        #endregion

        #region Question14: Count file extensions and group it using LINQ.

        var ans14 = new string[] {  "aaa.frx"," bbb.TXT", "xyz.dbf","abc.pdf",
                                "aaaa.PDF","xyz.frt", "abc.xml", "ccc.txt", "zzz.txt"};

        var res14 = ans14
            .Select(x => x.Trim().ToLower())
            .Select(x => Path.GetExtension(x!))
            .GroupBy(x => x)
            .Select(g => new { FileExtension = g.Key, Numbers = g.Count() });
        foreach (var i in res14)
        {
            // Console.WriteLine(i);
        }

        #endregion

        #region Question15: Removing the item 'p' from the array

        var ans15 = new char[] { 'm', 'n', 'o', 'p', 'q' };
        var res15 = ans15.Where(x => x != 'p');
        foreach (var c in res15)
        {
            // Console.WriteLine(c);
        }
        #endregion

        #region Question16: Removing the item with specific index from the array
        var ans16 = new char[] { 'm', 'n', 'o', 'p', 'q' };
        var res16 = ans16.Where((item, index) => index != 3);
        foreach (var i in res16)
        {
            // Console.WriteLine(i);
        }
        #endregion

        #region Question17: Remove a range of items from a list by passing the start index and number of elements to remove.
        int startIndex = 1;
        int count      = 2;
        
        var ans17 = new char[] { 'm', 'n', 'o', 'p', 'q' };
        var res17 = ans17.Where((item, index) => index < startIndex || index >= startIndex + count);
        foreach (var i in res17)
        {
            // Console.WriteLine(i);
        }

        #endregion

        #region Question18: Generate an Inner Join between two data sets.
        // Creating a list of Item_mast objects with ItemId and ItemDes properties
        List<Item_mast> itemlist = new List<Item_mast>
        {  
            new Item_mast { ItemId = 1, ItemDes = "Biscuit  " }, 
            new Item_mast { ItemId = 2, ItemDes = "Chocolate" }, 
            new Item_mast { ItemId = 3, ItemDes = "Butter   " },  
            new Item_mast { ItemId = 4, ItemDes = "Brade    " },  
            new Item_mast { ItemId = 5, ItemDes = "Honey    " }  
        }; 
        
        // Creating a list of Purchase objects with InvNo, ItemId, and PurQty properties
        List<Purchase> purchlist = new List<Purchase>
        {  
            new Purchase { InvNo=100, ItemId = 3,  PurQty = 800 }, 
            new Purchase { InvNo=101, ItemId = 2,  PurQty = 650 }, 
            new Purchase { InvNo=102, ItemId = 3,  PurQty = 900 },  
            new Purchase { InvNo=103, ItemId = 4,  PurQty = 700 },
            new Purchase { InvNo=104, ItemId = 3,  PurQty = 900 },  
            new Purchase { InvNo=105, ItemId = 4,  PurQty = 650 },  		
            new Purchase { InvNo=106, ItemId = 1,  PurQty = 458 }  
        };

        var res18 = purchlist.Join(
            itemlist,
            purchase => purchase.ItemId,
            item => item.ItemId,
            (purchase, item) => new
            {
                item.ItemId,
                item.ItemDes,
                purchase.PurQty
            }
        );
        foreach (var i in res18)
        {
            // Console.WriteLine(i);
        }

        #endregion
        
    }
}