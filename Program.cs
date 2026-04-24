// See https://aka.ms/new-console-template for more information


using System.Xml.Linq;

Console.Write("vvod FIO:");

string? name1 = Console.ReadLine();

//Console.WriteLine($"1 Privet, {name1}");

////Console.WriteLine("2 Privet, {name1}");

////Console.WriteLine("3 Privet, name1");

//Console.WriteLine($"C# РУЛИТ, {name1} ");




/*
Console.Write("vvod FIO: МОЕ-ИМЯ");
string? nam = Console.ReadLine();
//Console.WriteLine($"Privet, {МОЕ ИМЯ}");
//Console.WriteLine($"C# РУЛИТ, {МОЕ ИМЯ} ");

//Console.WriteLine($"Privet, {nam}");
//Console.WriteLine($"C# РУЛИТ, {nam} ");
*/





Console.Write("Введите фамилию: ");
string? name2 = Console.ReadLine();



//Console.ForegroundColor = ConsoleColor.Green;
//Console.WriteLine($"1. Учимся, {name1} {name2} !!!");

//Console.ReadKey();



//Console.SetCursorPosition(5, 10);
//Console.ForegroundColor = ConsoleColor.Yellow;
//Console.BackgroundColor = ConsoleColor.DarkGray;

//Console.WriteLine($"2. Учимся, {name1} {name2} !!!");


Console.ReadKey();
Console.Clear();
Console.WindowHeight = 15;
Console.WindowWidth = 35;

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine($"3. Учимся, {name1} {name2} !!!");






/////////////////////


//Console.WriteLine("Hello, World!");
//int a = 10 / 5*2;
//Console.WriteLine(a);


//{
//    int aa = 33;
//    int bb = 600;
//    byte cc = (byte)(aa + bb);
//    Console.WriteLine(cc);

//}

// Console.WriteLine(0b101);

//int b = ~a;
//Console.WriteLine(b);

//b += 1;
//Console.WriteLine(b);

//#1
/*
using System;
using System.Net.WebSockets;

int x1 = 5;
    Console.WriteLine($"x1= {x1}");
*/
//#2
/*
string str1;
Console.WriteLine( "ваше имя?" );
str1=Console.ReadLine();
string str2 = "Привет " + str1;
Console.WriteLine(  str2);
*/
//#3
/*
var v1 = 'v';
v1 = 'w';
Console.WriteLine(  v1);
*/
//#4
/*
Console.WriteLine("Введите длину стороны квадрата:");
string str = Console.ReadLine();
int xx1 = Convert.ToInt32(str); // Первый вариант преобразования строки в число
int xx2 = Int32.Parse(str); // Второй вариант преобразования строки в число
var p1 = 4 * xx1;
Console.WriteLine( $"p1= {p1} p2={4*xx2} ");
*/
//#5
/*
Console.WriteLine(  "vvod xa, yb");
int xa= Convert.ToInt32(Console.ReadLine());
int yb = Convert.ToInt32(Console.ReadLine());
var c = (xa + yb) / 2;
Console.WriteLine( $"z= {xa} *{yb} ={z}");
*/