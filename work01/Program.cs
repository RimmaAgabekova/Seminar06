// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите числа через пробел:");

string str = Console.ReadLine();
string[] temp = str.Split(new Char[] {' '});
int[] result = Array.ConvertAll(temp, int.Parse);

int GetNum(int[] result)

{   
    int sum = 0; 

    for(int i = 0; i < result.Length; i++)    
    {       
        if(result[i] > 0)
        sum ++;        
    }    
    return sum;   
}

Console.WriteLine("Количество чисел больше 0 -> " + GetNum(result));