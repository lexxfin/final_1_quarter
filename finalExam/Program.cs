Console.WriteLine("Введите массив строк разной длины, разделяя элементы через пробел: ");
string[] arr, result;
arr = Console.ReadLine().Split();
result = arr.Where(i => i.Length < 4).ToArray();
Console.WriteLine($"[{String.Join(", ", arr)}] -> [{String.Join(", ", result)}]");