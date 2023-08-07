//int[][] matrix = new int[3][];

//for (int i = 0; i < matrix.Length; i++)
//{
//    matrix[i] = new int[3]; // Create inner array
//    for (int j = 0; j < matrix[i].Length; j++)
//        matrix[i][j] = i * 3 + j;
//}
//for (int i = 0; i < matrix.Length; i++)
//{
//    for (int j = 0; j < matrix[i].Length; j++)
//        Console.WriteLine(matrix[i][j]);
//}//jagged array
//Console.WriteLine("Ölçüsü 5 olan massive reqemler daxil edin, daha sonra hemin massivi tersine ekrana çıxarın.");
//int[] numbers = new int[5];
//for (int i = 0; i < numbers.Length; i++)
//{
//    Console.Write($"Enter {i + 1} element:");
//    numbers[i] = Convert.ToInt32(Console.ReadLine());
//}
//for (int i = numbers.Length - 1; i >= 0; i--)
//{
//    Console.Write(numbers[i] + " ");
//}
//Console.WriteLine("------------------");
//Console.WriteLine("Ölçüsü 20 olan massiv yaradın, random reqemlerle doldurun, indeksi cüt olan reqemleri ekrana çıxarın");
//int[] numbers2 = new int[20];
//Random random = new Random();
//for (int i = 0; i < numbers2.Length; i++)
//{
//    numbers2[i] = Convert.ToInt32(random.Next());
//}
//for (int i = 0; i < numbers2.Length; i++)
//{
//    if (i % 2 == 0)
//    {
//        Console.Write(numbers2[i] + " ");
//    }
//}
//Console.WriteLine("----------------------------");
//Console.WriteLine("-20 ve 20 arasında random reqemlerden ibaret ölçüsü 10 olan massiv yaradın.Müsbet ededlerin ededi ortasını tapan program yazın");
//int[] numbers3 = new int[10];
//decimal average = 0;
//int count = 0;
//double sum = 0;
//for (int i = 0; i < numbers3.Length; i++)
//{
//    numbers3[i] = Convert.ToInt32(random.Next(-20, 20));
//}
//for (int i = 0; i < numbers3.Length; i++)
//{
//    Console.Write(numbers3[i] + " ");
//}
//Console.WriteLine();
//for (int i = 0; i < numbers3.Length; i++)
//{
//    if (numbers3[i] > 0)
//    {
//        sum += numbers3[i];
//        count++;
//    }
//}
//Console.WriteLine("Average:" + (sum / count));
//Console.WriteLine("----------------------------");

//Console.WriteLine("Ölçüsü 20 olan ve random reqemlerden ibaret massiv yaradın. Massivin maximum ve minimum elemtini tapan program yazın.");

//int[] numbers4 = new int[20];
//for (int i = 0; i < numbers4.Length; i++)
//{
//    numbers4[i] = Convert.ToInt32(random.Next(-10, 10));
//}
//for (int i = 0; i < numbers4.Length; i++)
//{
//    Console.Write(numbers4[i] + " ");
//}
//int max = numbers4[0];
//int min = numbers4[0];
//for (int i = 0; i < numbers4.Length; i++)
//{
//    if (numbers4[i] > max)
//    {
//        max = numbers4[i];
//    }
//    if (numbers4[i] < min)
//    {
//        min = numbers4[i];
//    }
//}
//Console.WriteLine();
//Console.Write("Max: " + max);
//Console.Write("Min: " + min);
//Console.WriteLine();
//Console.Write("Max: " + numbers4.Max());
//Console.Write("Min: " + numbers4.Min());
//Console.WriteLine("----------------------");
//Console.WriteLine("C# dilinde istifadeçiden her birinde 5 şagird olmaqla 2 qrupa bölünmüş 10 şagirdin qiymetlerini soruşan proqram yazın. Siz onları iki ölçülü massivde saxlamalı ve her bir qrup telebenin orta hesabını göstermelisiniz.");

//int countofStudents = 5;
//float[,] students = new float[countofStudents, countofStudents];
//float sumOfGroup1 = 0, sumOfGroup2 = 0;
//for (int i = 0; i < 2; i++)
//{
//    for (int j = 0; j < countofStudents; j++)
//    {
//        Console.Write($"Enter {j + 1} element:");
//        students[i, j] = Convert.ToInt32(Console.ReadLine());
//    }
//}
//for (int i = 0; i < countofStudents; i++)
//{
//    sumOfGroup1 += students[0, i];
//}
//Console.Write("Average of first Group: " + sumOfGroup1 / countofStudents);
//Console.WriteLine();
//for (int i = 0; i < countofStudents; i++)
//{
//    sumOfGroup2 += students[1, i];
//}
//Console.Write("Average of second Group: " + sumOfGroup2 / countofStudents);
//Console.WriteLine();
//Console.WriteLine("// Bir massivi ikinci massive kopya eden program yazın.");
//int[] arr1 = new int[5];
//int[] arr2 = new int[5];

//Console.Write("How much do you want to copy?: ");
//int copiedcount = Convert.ToInt32(Console.ReadLine());
//for (int i = 0; i < copiedcount; i++)
//{
//    Console.Write($"Enter {i + 1} element:");
//    arr1[i] = Convert.ToInt32(Console.ReadLine());

//}
//for (int i = 0; i < copiedcount; i++)
//{
//    arr2[i] = arr1[i];
//}
//Console.WriteLine("First Array");
//for (int i = 0; i < copiedcount; i++)
//{
//    Console.Write(arr1[i] + " ");
//}
//Console.WriteLine("Copied Array");
//for (int i = 0; i < copiedcount; i++)
//{
//    Console.Write(arr2[i] + " ");
//}



//int[] numbers6 = new int[5];
//for (int i = 0; i < numbers6.Length; i++)
//{
//    Console.Write($"Enter {i+1} element: ");
//    numbers6[i] = Convert.ToInt32(Console.ReadLine());
//}
//int min = numbers6[0];
//int max = numbers6[0];
//for (int i = 0; i < numbers6.Length; i++)
//{
//    if (numbers6[i]<min)
//    {
//        min = numbers6[i];
//    }
//    if (numbers6[i]>max)
//    {
//        max = numbers6[i];
//    }
//}
//Console.Write("Min:"+min);
//Console.WriteLine();
//Console.Write("Max:"+max);
//Console.Write("Max:"+numbers6.Max());
//Console.WriteLine();
//Console.Write("Min:"+numbers6.Min());

//int[] numbers7 = new int[5];
//for (int i = 0; i < numbers7.Length; i++)
//{
//    Console.Write($"Enter {i + 1} element: ");
//    numbers7[i] = Convert.ToInt32(Console.ReadLine());

//}
//for (int i = numbers7.Length-1; i>=0; i--)
//{
//    Console.Write(numbers7[i]+" ");
//}
//Console.WriteLine();
//int sum = 0;
//int count = 0;
//for (int i = 0; i < numbers7.Length; i++)
//{
//    sum += numbers7[i];
//    count++;

//}
//Console.WriteLine("Sum:" + sum);
//Console.WriteLine("Average:" + sum/count);
Console.Write("Enter number of grades:");
int grade = Convert.ToInt32(Console.ReadLine());
string[][] matrix = new string[grade][];
for (int i = 0; i < grade; i++)
{
    Console.Write($"Enter the number of students for grade: {i + 1}: ");
    int studentCount = Convert.ToInt32(Console.ReadLine());
    matrix[i] = new string[studentCount]; // Create inner array
    for (int j = 0; j < matrix[i].Length; j++)
    {
        Console.Write($"Enter the name of student {j + 1} for grade {i+1}: ");
        matrix[i][j] = Console.ReadLine();
    }
}

for (int i = 0; i <=matrix[i].Length; i++)
{
    Console.WriteLine();
    Console.WriteLine($"Students in grade {i+1}:");

    for (int j = 0; j <matrix[i].Length; j++)
    {
        Console.WriteLine(matrix[i][j]);
    }
}




