﻿//namespace day8ConsoleApp
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            //var shapes = new List<Shape>
//            //{
//            //    new Square(),
//            //    new Heart(),
//            //    new Circle()
//            //};
//            //foreach (var shape in shapes)
//            //{
//            //    shape.Draw();
//            //}
//            Heart heart = new Heart();
//            heart.Draw();
//            Shape shape = heart;
//            shape.Draw();
//        }
//    }
//}

using System;

class SampleCollection<T>
{
    // Declare an array to store the data elements.
    private T[] arr = new T[100];
    int nextIndex = 0;

    // Define the indexer to allow client code to use [] notation.
    public T this[int i] => arr[i];

    public void Add(T value)
    {
        if (nextIndex >= arr.Length)
            throw new IndexOutOfRangeException($"The collection can hold only {arr.Length} elements.");
        arr[nextIndex++] = value;
    }
}

class Program
{
    static void Main()
    {
        var stringCollection = new SampleCollection<string>();
        stringCollection.Add("Hello, World");
        System.Console.WriteLine(stringCollection[0]);
    }
}
// The example displays the following output:
//       Hello, World.
