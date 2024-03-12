//task 1 -- Verilmiş array-də tək ədədlərin sayını tapmaq və çap etmək.
//Məsələn: [1, 2, 3, 4, 5, 6, 7] => Tək ədədlərin sayı: 4

//int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
//int count = 0;
//foreach (var item in arr)
//{
//    if (item % 2 != 0)
//    {
//        count++;
//    }
//}
//Console.WriteLine($"Tek ededlerin sayı: {count}");


// Verilmiş array-də ən kiçik və ən böyük ədədlərin cəmini tapmaq. 
//Məsələn: [3, 8, 2, 10, 5] => Cəm: 12

//int[] arr = { 3, 8, 2, 10, 5 };
//int min = arr[0];
//int max = arr[0];
//int sum = 0;
//foreach (var item in arr)
//{
//    if (item < min)
//    {
//        min = item;
//    }
//    if (item > max)
//    {
//        max = item;
//    }
//}
//sum = min + max;
//Console.WriteLine($"Cem: {sum}");


// task 3 --  Verilmiş array-dəki ədədlərin ən böyük və ən kiçik fərqlərini tapmaq. 
//Məsələn: [5, 8, 15, 3, 7] => Fərq: 12

//int[] arr = { 5, 8, 15, 3, 7 };
//int min = arr[0];
//    int max = arr[0];
//int ferq = 0;
//foreach(var item in arr)
//{
//    if (item < min)
//    {
//        min = item;
//    }
//    if ( item > max)
//    {
//           max = item;
//    }
//    {

//    }
//}
//ferq = max - min;
//Console.WriteLine($"Ferq: {ferq}");

// task 4 -- Verilmiş array-dəki ədədlərin sırasını artan sıraya salmaq. 
//Məsələn: [3, 1, 5, 4, 2] => [1, 2, 3, 4, 5]
// ede bilmedim 








// task 5 -- Verilmiş array-dəki tək və cüt ədədlərin cəmini ayrı-ayrı tapmaq. 
//Məsələn: [1, 2, 3, 4, 5] => Tək ədədlərin cəmi: 9, Cüt ədədlərin
int[] arr = { 1, 2, 3, 4, 5 };
int cemcut = 0;
int cemtek = 0;
foreach (var item in arr)
{
    if (item % 2 == 0)
    {
        cemcut += item;
    }
    else
    {
        cemtek += item;
    }
}
Console.WriteLine($"Cemcut: {cemcut}, Cemtek: {cemtek}");
