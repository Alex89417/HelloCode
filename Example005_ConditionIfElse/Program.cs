﻿//Console.Write("Введите имя пользователя: ");
//string username = Console.ReadLine();
//if(username == "Оля")
//{
//    Console.WriteLine("Ура, эта же Оля");
//}
//else
//{
//    Console.Write("Привет, ");
//    Console.WriteLine(username);
//}

//Выводит в консоль так:
//Введите имя пользователя: Александр
//Привет, Александр

//Выводит в консоль так:
//Введите имя пользователя: Оля
//Ура, эта же Оля

//---------------------------------------------------

Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();
if(username.ToLower() == "оля")
{
    Console.WriteLine("Ура, эта же Оля!");
}
else
{
    Console.Write("Привет, " + username);

}

//Выводит в консоль так:
//Введите имя пользователя: Александр
//Привет, Александр

//Выводит в консоль так:
//Введите имя пользователя: Оля
//Ура, эта же Оля!

//---------------------------------------------------