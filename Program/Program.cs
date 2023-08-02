Console.Write("Введите слова через пробел: ");
string words = Console.ReadLine();
string[] arr = CreatArrFromString(words);
PrintAns(array: arr);

string[] CreatArrFromString(string string_arr){
    string[] arr = string_arr.Split(" ");
    return arr;
}

void PrintAns(string[] array){
    for(int i = 0;i < array.Length;i++){
        if(array[i].Length <= 3){
            Console.Write($"{array[i]} ");
        }
    }
}


