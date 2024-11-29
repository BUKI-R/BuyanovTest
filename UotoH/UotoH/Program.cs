using InspectorLib;
// ввыод изначального инспектора
Console.WriteLine($"Название автоинспекции: {FunctionInsp.GetCarInspection()}");
Console.WriteLine($"Главный инспектор: {FunctionInsp.GetInspector()}");
Console.WriteLine($"Список сотрудников: {string.Join(", ", FunctionInsp.GetWorkers())}");

// замена инспектора из существующего списка
Console.Write($"\r\nВыберите сотрудника из списка: ");
string OLDhumen = Console.ReadLine();
bool proverc = FunctionInsp.SetInspector(OLDhumen);
Console.WriteLine($"Изменение главного инспектора на {OLDhumen}: {proverc}");
Console.WriteLine($"Главный инспектор: {FunctionInsp.GetInspector()}");

// проверка генерация номера автомобиля
Console.Write($"\r\nВведите буквы для номера: ");
string newNumber = FunctionInsp.GenerateNumber(Console.ReadLine());
Console.WriteLine($"Сгенерированный госномер: {newNumber}");

// проверка добавление нового сотрудника
Console.Write($"\r\nВведите имя нового сотрудника: ");
string Newhumen = Console.ReadLine();
Console.WriteLine($"Добавление сотрудника {Newhumen}");
Console.WriteLine("Список сотрудников: " + string.Join(", ", FunctionInsp.GetWorkers()));
