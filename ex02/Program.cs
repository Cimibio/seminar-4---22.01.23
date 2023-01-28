// поменять местами имена и фамилии
Console.Write("введите имена: ");
string s = Console.ReadLine()??"";
void PrintMasString(string[] arr)
{
    foreach (var item in arr)
        {
            Console.Write(item + " ");
        }
}
string[] names = s.Split(" "); //создаем массив с делителем "пробел"

PrintMasString(names);

for (int i = 0; i < names.Length/2; i++)
{
    string temp = names[i];
    names[i] = names[names.Length - 1 - i];
    names[names.Length - 1 - i] = temp; 
}

PrintMasString(names);