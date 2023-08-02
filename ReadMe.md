# Решение задачи(Объяснение)

## Ввод
Сначала просим ввести пользователя массив: 
Console.Write("Введите слова через пробел: ");

Потом сохраняем ввод в переменную words: 
string words = Console.ReadLine();

Дальше мы создаём массив arr и сохраняем в него words через метод GetArrFromString(): 
string[] arr = CreatArrFromString(words);

### Метод GetArrFromString()
Наш метод выглядет так: 
string[] CreatArrFromString(string string_arr){
    string[] arr = string_arr.Split(" ");
    return arr;
}

Этот метод берет на вход строчку string_arr.
Дальше метод создаёт массив string[] arr и сохраняет в него string_arr.Split(" ");.

#### Как работает строчка string_arr.Split(" ");
Строчка string_arr.Split(" "); разбивает переменную string_arr на части по символу " ".Например если переменная string_arr равна I write ReadMe file ,то строчка string_arr.Split(" "); вернёт строчки "I","write","ReadMe","file".

 #### Последняя строчка(return arr)

 Последняя строчка в нашем методе это: return arr.
 Благодаря этой строчке наш метод возращает массив arr.

