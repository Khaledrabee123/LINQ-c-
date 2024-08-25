using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;
using L2O___D09;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static L2O___D09.ListGenerators;
namespace linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region LINQ - Restriction Operators

            //   1.Find all products that are out of stock.

            //var lst = ProductList.Where(p => p.UnitsInStock == 0);
            //foreach (var unit in lst)
            //{
            //    Console.WriteLine(unit);
            //}

            // 2. Find all products that are in stock and cost more than 3.00 per unit.

            //var lst2 = ProductList.Where(predicate => predicate.UnitPrice>3);
            //foreach (var item in lst2)
            //{
            //    Console.WriteLine(item);
            //}


            //3.Returns digits whose name is shorter than their value.

            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var lst = Arr.Select((name, index) => new { Name = name, Index = index }).Where(i => i.Name.Length < i.Index);
            //foreach (var i in lst)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion

            #region  LINQ - Element Operators
            // 1-  Get first Product out of Stock 

            //var first= ProductList.FirstOrDefault(p=>p.UnitsInStock==0);
            //Console.WriteLine(first);


            //  2- Return the first product whose Price > 1000, unless there is no match, in which case null is returned.

            //var first= ProductList.FirstOrDefault(p=>p.UnitPrice>1000);
            //Console.WriteLine(first?.ProductName?? "returned null");

            //3.Retrieve the second number greater than 5

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var second = Arr.Where(i => i > 5).Skip(1).FirstOrDefault();
            //Console.WriteLine(second);


            #endregion

            #region LINQ - Set Operators

            //1. Find the unique Category names from Product List
            // var lst = ProductList.Select(x => x.Category).Distinct();
            //foreach (var item in lst)
            //{
            //    Console.WriteLine(item);
            //}

            //2. Produce a Sequence containing the unique first letter from both product and customer names.
            //var lst = ProductList.Select(x => x.ProductName[0]).Concat(CustomerList.Select(C => C.CompanyName[0])).Distinct()
            //    .ToList();
            //foreach (var x in lst)
            //{
            //    Console.WriteLine(x);
            //}

            //3. Create one sequence that contains the common first letter from both product and customer names.
            //var lst = ProductList.Select(x => x.ProductName[0]).Union(CustomerList.Select(C => C.CompanyName[0])).Distinct();
            //foreach (var x in lst)
            //{
            //    Console.WriteLine(x);
            //}

            //4. Create one sequence that contains the first letters of product names that are not also first letters of customer names.
            //List<char> lstC = CustomerList.Select(x => x.CompanyName[0]).ToList();
            //var lst = from e in ProductList
            //          where !lstC.Contains(e.ProductName[0])
            //          select e.ProductName[0];

            //foreach (var c in lst)
            //{
            //    Console.WriteLine(c);
            //}

            //5. Create one sequence that contains the last Three Characters in each names of all customers and products, including any duplicates
            //List<char> lst = ProductList.Select(x => x.ProductName[^3]).Concat(CustomerList.Select(C => C.CompanyName[^3])).ToList();
            //for (int i = 0; i < lst.Count; i++)
            //{
            //    if (i % 4 == 0)
            //    {
            //        Console.WriteLine ();
            //    }
            //    else
            //    {
            //        Console.Write(lst[i]);
            //    }
            //}






            #endregion

            #region LINQ - Aggregate Operators


            // 1.Uses Count to get the number of odd numbers in the array
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //int cnt = Arr.Count(x => x % 2 == 1);
            //Console.WriteLine(cnt);


            // 2. Return a list of customers and how many orders each has.
            //var lst = from e in CustomerList
            //select new {cust = e, custo = e.Orders.Count()};
            //foreach (var e in lst)
            //{
            //    Console.WriteLine(e.custo);
            //    Console.WriteLine(e.cust);
            //}

            //3. Return a list of categories and how many products each has 

            //var lst = from e in ProductList
            //          group e by e.Category
            //          into g
            //          select new { name = g.Key, cnt = g.Count() };

            //foreach (var e in lst)
            //{
            //    Console.WriteLine(e.name);
            //    Console.WriteLine(e.cnt);


            //}

            //4.Get the total of the numbers in an array.

            //   int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var lst = Arr.Sum(x => x);
            //Console.WriteLine(lst);

            // 5.Get the total units in stock for each product category
            //var lst = from e in ProductList
            //          group e by e.Category
            //          into g     
            //          select new { name = g.Key, cnt = g.Count(x=>x.UnitsInStock>0 )};

            //foreach (var e in lst)
            //{
            //   Console.WriteLine(e.name);
            //   Console.WriteLine(e.cnt);
            //}

            // 6.Get the cheapest price among each category's products

            //var lst = from e in ProductList
            //         group e by e.Category
            //          into g     
            //         select new { name = g.Key, min = g.Min(x=>x.UnitPrice)};
            //foreach (var e in lst)
            //{
            //   Console.WriteLine(e.name);
            //   Console.WriteLine(e.min);
            //}

            //7. Get the average price of each category's products.
            //var lst = from e in ProductList
            //          group e by e.Category
            //          into g
            //          select new { name = g.Key, avg = g.Average(x=>x.UnitPrice) };
            //foreach (var e in lst)
            //{
            //    Console.WriteLine(e.name);
            //    Console.WriteLine(e.avg);
            //}






            #endregion

            #region LINQ - Ordering Operators
            //  1.Sort a list of products by name

            //var lst = from e in ProductList 
            //          orderby e.ProductName
            //          select e;
            // foreach (var item in lst)
            // {
            //     Console.WriteLine(item);
            // }

            //2. Uses a custom comparer to do a case-insensitive sort of the words in an array.

            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var lst = from e in Arr
            //          orderby e
            //          select e;
            //foreach (var s in lst)
            //{
            //    Console.WriteLine(s);
            //}


            //3. Sort a list of products by units in stock from highest to lowest.

            //var lst = from p in ProductList 
            //          orderby p.UnitPrice descending
            //          select p;

            //foreach (var item in lst)
            //{
            //    Console.WriteLine(item.ToString());
            //}

            // 4.Sort a list of digits, first by length of their name, and then alphabetically by the name itself.
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var lst = from e in Arr
            //          orderby e.Length, e
            //          select e;
            //foreach (var item in lst)
            //{s
            //    Console.WriteLine(item);
            //}

            //6. Sort a list of products, first by category, and then by unit price, from highest to lowest.
            //var lst = ProductList.Select(x => x).OrderBy(x=>x.Category).ThenByDescending(x=>x.UnitPrice);
            //foreach (var item in lst)
            //{
            //    Console.WriteLine(item);
            //}

            //7. Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array.
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var lst = from e in Arr
            //          where e[1] == 'i'
            //          select e;
            //foreach (var e in lst)
            //{
            //    Console.WriteLine(e);
            //}


            #endregion

            #region LINQ - Partitioning Operators

            //1. Get the first 3 orders from customers in Washington

            //var lst = from e in CustomerList
            //          select new {cust = e, ord = e.Orders[..Math.Min(e.Orders.Length,3)] };


            //foreach (var item in lst)
            //{
            //    Console.WriteLine(item.cust);
            //    foreach (var item1 in item.ord)
            //    {
            //        Console.WriteLine(item1);
            //    }
            //}

            //3. Return elements starting from the beginning of the array until a number is hit that is less than its position in the array.
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var lst = numbers.Select((n , Index )=> new {index= Index, N=n}).Where(i => i.index > i.N).Select(i=>i.N);
            //foreach (var item in lst)
            //{
            //    Console.WriteLine(item);
            //}
            //4. Get the elements of the array starting from the first element divisible by 3.
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var lst = numbers.ToList();
            //var l = lst.FindIndex(x => x % 3==0);
            //var ans = lst[l..];
            //foreach (var item in ans)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region LINQ - Projection Operators
            //1. Return a sequence of just the names of a list of products.

            //var lst =ProductList.Select(x => x.ProductName).Distinct();
            //foreach (var item in lst)
            //{
            //    Console.WriteLine(item);
            //}

            //2. Produce a sequence of the uppercase and lowercase versions of each word in the original array (Anonymous Types).
            //string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };
            //var lst  =from e in
            //              words
            //              select new {lowe =  e.ToLower(), upper = e.ToUpper() };
            //foreach (var word in lst)
            //{
            //    Console.WriteLine(word);
            //}

            //3. Produce a sequence containing some properties of Products, including UnitPrice which is renamed to Price in the resulting type.
            //var lst = from p in ProductList
            //          select new { price = p.UnitPrice, name = p.ProductName, instock = p.UnitsInStock };
            //foreach (var item in lst)
            //{
            //    Console.WriteLine(item);
            //}

            //4. Determine if the value of ints in an array match their position in the array.
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            // var lst = Arr.Select((e, index )=> new { num =e , index = index }).Select((num) => new{ num.num ,x= num.num==num.index});
            //foreach (var e in lst)
            //{
            //    Console.WriteLine(e);
            //}

            //5. Returns all pairs of numbers from both arrays such that the number from numbersA is less than the number from numbersB.
            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };
            //var lst = new List<Tuple<int,int>>();
            //for (int i = 0; i < numbersA.Length; i++)
            //{
            //    for (int j = 0; j < numbersB.Length; j++)
            //    {
            //        if (numbersA[i] < numbersB[j])
            //        {
            //            Tuple<int, int> x = new(numbersA[i], numbersB[j]);
            //            lst.Add(x);


            //        }
            //    }
            //}
            //    foreach (var item in lst)
            //    {
            //        Console.Write(item.Item1 +"  ");
            //        Console.WriteLine(item.Item2 );
            //    }

            //6. Select all orders where the order total is less than 500.00.

            //var lst = from e in CustomerList
            //          where  e.Orders.Sum(o => o.Total)<500
            //          select e.Orders;
            //foreach (var o in lst)
            //{
            //    foreach (var item in o)
            //    {
            //        Console.WriteLine(item);
            //    }
            //    Console.WriteLine("==========");
            //}

            //7. Select all orders where the order was made in 1998 or later.
            //DateTime dateTime = new DateTime(1998, 1,1);
            //var lst = from e in CustomerList
            //          where e.Orders.Count(x => x.OrderDate > dateTime)>0
            //          select e.Orders;
            //foreach (var o in lst)
            //{
            //    foreach (var item in o)
            //    {
            //        Console.WriteLine(item.OrderDate.ToString());
            //    }
            //    Console.WriteLine("==========");
            //}

            #endregion

            #region LINQ - Quantifiers
            //1. Return a grouped a list of products only for categories that have at least one product that is out of stock.
            //var lst = from e in ProductList
            //         group e by e.Category
            //         into g
            //         from x in g
            //         where x.UnitsInStock == 0
            //         select g;


            //foreach (var o in lst)
            //{
            //   foreach (var x in o)
            //    {
            //       Console.WriteLine(x);
            //    }    
            //}

            //2. Return a grouped a list of products only for categories that have all of their products in stock
            // var lst = ProductList.GroupBy(e => e.Category).Where(e => e.All(x=>x.UnitsInStock>0));


            // foreach (var o in lst)
            // {
            //     foreach (var x in o)
            //     {
            //         Console.WriteLine(x);
            //     }
            //Console.WriteLine();
            // }

            #endregion

            #region LINQ - Grouping Operators

            //1. Use group by to partition a list of numbers by their remainder when divided by 5
            //var number = Enumerable.Range(0, 20);

            //var lst = number.GroupBy(x => x%5).ToList();
            //foreach (var x in lst)
            //{
            //    Console.WriteLine(x.Key); ;
            //    foreach (var y in x)
            //    {
            //        Console.Write(y +  " ");
            //    }
            //    Console.WriteLine();

            //}





            #endregion



        }
    }
}
