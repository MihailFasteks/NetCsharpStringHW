// See https://aka.ms/new-console-template for more information
//task3

//Console.WriteLine("Расшировать - 1, зашифровать -2 ");
//int chose = int.Parse(Console.ReadLine());
//Console.WriteLine("Input str");
//string str = Console.ReadLine().ToLower();

//string alphabet = "abcdefghijklmnopqrstuvwxyz";
//string newStr = "";
//if (chose == 1)
//{
//    for (int i = 0; i < str.Length; i++)
//    {
//        int index = alphabet.IndexOf(str[i]);
//        if (index != -1)
//        {
//            int newIndex = (index + 2) % alphabet.Length;
//            newStr += alphabet[newIndex];
//        }
//        else
//        {
//            newStr += str[i];
//        }

//    }
//    Console.WriteLine(newStr);
//}
//else if (chose == 2)
//{

//    for (int i = 0; i < str.Length; i++)
//    {
//        int index = alphabet.IndexOf(str[i]);
//        if (index != -1)
//        {
//            int newIndex = (index - 2 + alphabet.Length) % alphabet.Length;
//            newStr += alphabet[newIndex];
//        }
//        else
//        {
//            newStr += str[i];
//        }

//    }
//    Console.WriteLine(newStr);
//}
//else
//{
//    Console.WriteLine("Error!");
//}

//task5

//Console.WriteLine("Input");
//string str = Console.ReadLine().ToLower();
//str = str.Replace(" ", " ");
//string numstr = "";
//int res = 0;
//char op = '+';
//for (int i = 0; i < str.Length; i++)
//{
//    if (char.IsDigit(str[i]))
//    {
//        numstr += str[i];
//    }

//    if (str[i] == '+' || str[i] == '-' || i == str.Length - 1)
//    {

//        if (numstr != "")
//        {
//            int num = int.Parse(numstr);
//            numstr = "";
//            if (op == '+')
//            {
//                res += num;

//            }
//            else if (op == '-')
//            {
//                res -= num;

//            }
//            else
//            {
//                Console.WriteLine("Error!");
//            }
//            op = str[i];
//        }
//    }
//}
//Console.WriteLine($"Result: {res}");

//task6

//Console.WriteLine("Input text");
//string str = Console.ReadLine().ToLower();
//string newstr = "";
//for  (int i = 0; i < str.Length; i++)
//{
//    if (i==0 || (i>0 && str[i-1]=='.'))
//    {
//        newstr+= char.ToUpper(str[i]);
//    }
//    else
//    {
//        newstr += str[i];
//    }
    
//}
//Console.WriteLine(newstr);

//task7
Console.WriteLine("Input text");
string str = Console.ReadLine().ToLower();
string newstr = "";
Console.WriteLine("Input word");
string flag= Console.ReadLine().ToLower();

int index=str.IndexOf(flag);
string change = "";
for (int i = 0; i < flag.Length; i++)
{
    change += '*';
}
str = str.Replace(flag, change);

Console.WriteLine(str);
