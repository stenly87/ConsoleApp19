// Коллекции и словари в c# 
//Коллекция List
//List<тип> имяПеременной = new List<тип>();
// массив
//тип[] имяПеременной = new тип[размер];
// примеры инициализации
List<string> strings = new List<string>();
List<string> strings1 = new(100);

strings1 = new(); // пересоздание коллекции
for(int i = 0; i < 10000000; i++)
    strings1.Add("1"); // элемент добавляется в конец
// коллекции.

int count = strings1.Capacity; // внутренний размер
// хранилища

count = strings1.Count;// кол-во элементов
Console.WriteLine(strings1[0]); // чтение ячейки
strings1[0] = "Строка";
strings1.Remove("1");// удаляет первый элемент, равный
// указанному значению/объекту
strings1.RemoveAt(1); // удаление элемента по индексу
strings1.RemoveAll(s => s == "1");// удаление всех
// ячеек, совпадающих с "1"

Console.WriteLine(strings1.Capacity);
Console.WriteLine(strings1.Count);
//strings1[1] = "asda"; ошибка! индекс не существует
strings1.AddRange(strings); // добавить множество элементов
// из массива или коллекции

strings1.Clear(); // очищает все ячейки

// словарь, ассоциативный массив
//Dictionary<тип ключа, тип значения> название = new();
Dictionary<string, string> dict1 = 
    new Dictionary<string, string>();

Dictionary<string, int> dict2 = new();
// тип ключа это тип данных, который будет использоваться
// для индексации значений в словаре
// каждому значению соотвествует одно конкретное уникальное
// значение ключа. Ключ в рамках одного словаря не повторяется

dict1.Add("ключ", "значение");
//dict1.Add("ключ", "значение1");// ошибка! ключ уже занят
dict1.Add("ключ1", "значение1");
Console.WriteLine(dict1["ключ1"]);
dict1["ключ1"] = "новое значение"; // для коллекции, чтобы 
// сделать такое действие придется сначала найти ячейку с нужным
// элементом. Т.е. в таком случае словарь работает намного быстрее
//Console.WriteLine(dict1["несуществующий ключ"]); // ошибка!!!!

dict2.Add("ключ", 100);
dict2.Add("123", 111);

foreach (var value in dict2.Values) // значения
{
    Console.WriteLine(value);
}

foreach (var value in dict2.Keys) // ключи
{
    Console.WriteLine(value);
}
