class Program
{
    static void Main()
    {
        GenericArray<int> intArray = new GenericArray<int>(5);
        GenericArray<string> stringArray = new GenericArray<string>(3);
        GenericArray<double> doubleArray = new GenericArray<double>(4);

        intArray.AddItem(0, 8);
        intArray.AddItem(1, 16);
        intArray.AddItem(2, 32);

        stringArray.AddItem(0, "Обобщение");
        stringArray.AddItem(1, "Делегирование");
        stringArray.AddItem(2, "Наследование");

        doubleArray.AddItem(0, 8.233);
        doubleArray.AddItem(1, 1.56);
        doubleArray.AddItem(1, 76.09);

        Console.WriteLine("Элемент по индексу 1 в intArray: " + intArray.GetItem(1));
        Console.WriteLine("Элемент по индексу 0 в stringArray: " + stringArray.GetItem(0));
        Console.WriteLine("Элемент по индексу 0 в doubleArray: " + doubleArray.GetItem(0));

        Console.WriteLine("Длина intArray: " + intArray.GetLength());
        Console.WriteLine("Длина stringArray: " + stringArray.GetLength());
        Console.WriteLine("Длина doubleArray: " + doubleArray.GetLength());
    }
}