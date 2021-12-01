using System;

namespace Lab_13_copy
{
    class Program
    {
        static void Main(string[] args)
        {

            MultiBuilding multiBuilding = new MultiBuilding("Крыленко 19", 34, 67, 12, 6);
            multiBuilding.Print();
        }
    }
    class Building
    {
        public string Address { get; set; }
        public int Length { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public Building(string address, int length, int width, int height)
        {
            Address = address;
            Length = length;
            Width = width;
            Height = height;

        }
        public void Print()
        {
            Console.WriteLine("Адрес здания: {0}", Address);
            Console.WriteLine("Длина здания= {0}", Length);
            Console.WriteLine("Ширина здания= {0}", Width);
            Console.WriteLine("Высота здания= {0}", Height);
        }
    }
    sealed class MultiBuilding : Building
    {
        public int Floor { get; set; }
        public MultiBuilding(string address, int length, int width, int height, int floor)
                : base(address, length, width, height)
        {
            Floor = floor;
        }
        public void Print()
        {
            Building building = new Building("Крыленко 19", 34, 67, 12);
            building.Print();
            Console.WriteLine("Этажность здания: {0}", Floor);
        }
    }
}

