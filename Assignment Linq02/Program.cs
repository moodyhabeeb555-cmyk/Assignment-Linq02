// Assignment Linq 02


using static Assignment_Linq02.Customer;

using static Assignment_Linq02.Product;

using static Assignment_Linq02.Source;


// 1. Get top 3 most expensive products 

// Answer 01

//var top3Expensive = ProductList
//    .OrderByDescending(p => p.UnitPrice)
//    .Take(3);

//foreach (var item in top3Expensive)
//{
//    Console.WriteLine(item);
//}

// 2. show page 2 of products, with page size = 5 

// Answer 02

//var page2 = ProductList
//    .Skip(5)
//    .Take(5);

//foreach (var item in page2)
//{
//    Console.WriteLine(item);
//}


// 3. Take products from the list as long as Their UnitPrice is less than $25 (list is ordered by price). 

// Answer 03

//var cheapProducts = ProductList
//    .OrderBy(p => p.UnitPrice)
//    .TakeWhile(p => p.UnitPrice < 25);

//foreach (var item in cheapProducts)
//{
//    Console.WriteLine(item);
//}

// 4. Check if ALL products in the "Seafood" category are in stock 

// Answer 04

//bool allSeafoodInStock = ProductList
//    .Where(p => p.Category == "Seafood")
//    .All(p => p.UnitsInStock > 0);


//    Console.WriteLine(allSeafoodInStock);


// 5. Check if the ID list contains 9
// int[] ids = { 3, 9, 13, 18 };

// Answer 05

//int[] ids = { 3, 9, 13, 18 };
//bool containsNine = ids.Contains(9);

//Console.WriteLine(containsNine);


// 6.Group all products by Category and print each group with its product count. 

// Answer 06

//var categoryCounts = ProductList
//    .GroupBy(p => p.Category)
//    .Select(g => new { Category = g.Key, Count = g.Count() });

//foreach (var group in categoryCounts)
//{
//    Console.WriteLine($"{group.Category}: {group.Count}");
//}


// 7. Group products by Category and project only product names per group 

// Answer 07

//var categoryProductNames = ProductList
//    .GroupBy(p => p.Category)
//    .Select(g => new
//    {
//        Category = g.Key,
//        ProductNames = g.Select(p => p.ProductName)
//    });

//foreach (var item in categoryProductNames)
//{
//    Console.WriteLine(item);
//}


// 8. Find all categories that have MORE THAN 3 products 

// Answer 08

//var categoriesOver3 = ProductList
//    .GroupBy(p => p.Category)
//    .Where(g => g.Count() > 3)
//    .Select(g => g.Key);

//foreach (var item in categoriesOver3)
//{
//    Console.WriteLine(item);
//}


// 9. Using QUERY SYNTAX, group customers by Country, and for each group select { Country, Count, TotalOrderValue }. 

// Answer 09

//var customerStats =
//    from c in CustomerList
//    group c by c.Country into g
//    select new
//    {
//        Country = g.Key,
//        Count = g.Count(),
//        TotalOrderValue = g.SelectMany(c => c.Orders).Sum(o => o.Total)
//    };

//foreach (var item in customerStats)
//{
//    Console.WriteLine(item);
//}


// 10.Calculate the total number of units in stock across all products 

// Answer 10

//int totalUnits = ProductList.Sum(p => p.UnitsInStock);

//Console.WriteLine(totalUnits);


// 11. Find the CHEAPEST and MOST EXPENSIVE product prices 

// Answer 11

//decimal minPrice = ProductList.Min(p => p.UnitPrice);
//decimal maxPrice = ProductList.Max(p => p.UnitPrice);

//Console.WriteLine("Min Price is : " + minPrice);

//Console.WriteLine("Max Price is : " + maxPrice);


// 12. Get a distinct list of all product categories 

// Answer 12

//var categories = ProductList
//    .Select(p => p.Category)
//    .Distinct();

//foreach (var item in categories)
//{
//    Console.WriteLine(item);
//}


// 13. find product IDs that are in setA but NOT in setB 
// int[] setA = { 1, 3, 5, 7, 9, 11, 13 }; 
// int[] setB = { 3, 6, 9, 12, 15, 13 };

// Answer 13

//int[] setA = { 1, 3, 5, 7, 9, 11, 13 };
//int[] setB = { 3, 6, 9, 12, 15, 13 };

//var difference = setA.Except(setB);

//Console.WriteLine("The Differents in A is : " + difference);


// 14.Find countries that  appear in list1 but NOT in list2 (case-insensitive). 
// string[] list1 = { "Germany", "France", "UK", "Spain" };
// string[] list2 = { "france", "SPAIN", "Italy" };

// Answer 14

//string[] list1 = { "Germany", "France", "UK", "Spain" };
//string[] list2 = { "france", "SPAIN", "Italy" };

//var countryDiff = list1.Except(list2, StringComparer.OrdinalIgnoreCase);

//Console.WriteLine(countryDiff);


// 15.Build a Dictionary<int, Product> keyed by ProductID.Then retrieve and print the product with ID = 18.

// Answer 15

//var productDict = ProductList.ToDictionary(p => p.ProductID);

//Console.WriteLine(productDict[18].ProductName);


// 16. Get the first product whose price is greater than $50. 

// Answer 16

//var expensiveProduct = ProductList.First(p => p.UnitPrice > 50);

//Console.WriteLine(expensiveProduct);


// 17. Try to get the first product with a price > $500. it returns null instead of throwing.

//Answer 17

//var ExpensiveProduct = ProductList.FirstOrDefault(p => p.UnitPrice > 500);

//Console.WriteLine(ExpensiveProduct);


// 18. Generate a multiplication table row for 7 

// Answer 18

//var row7 = Enumerable.Range(1, 10).Select(i => 7 * i);

//Console.WriteLine(row7);


// 19. Generate even numbers between 1 and 30. 

// Answer 19

//var evenNumbers = Enumerable.Range(1, 30).Where(n => n % 2 == 0);

//Console.WriteLine(evenNumbers);


// 20. Concatenate the first 3 product names with the first 3 customer names into a single sequence.

// Answer 20

//var productNames = ProductList.Take(3).Select(p => p.ProductName);
//var companyNames = CustomerList.Take(3).Select(c => c.CustomerName);

//var Concatnated = productNames.Concat(companyNames);

//Console.WriteLine(Concatnated);


//21. Pair each product with a customer (by position) and produce a string "ProductName sold to CustomerName".

// Answer 21

//var paired = ProductList.Zip(CustomerList, (p, c) => $"{p.ProductName} sold to {c.CustomerName}");

//Console.WriteLine(paired);

