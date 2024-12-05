using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Тумаков
{
    public class Building
    {
        private static int lastBuildingNumber = 0;
        private int buildingNumber; 
        private double height; 
        private int floors;
        private int apartments; 
        private int entrances; 

       
        public Building()
        {
            this.buildingNumber = GenerateBuildingNumber();
        }

        
        private static int GenerateBuildingNumber()
        {
            lastBuildingNumber++;
            return lastBuildingNumber; 
        }

        
        public void SetHeight(double height)
        {
            this.height = height;
        }

        
        public void SetFloors(int floors)
        {
            this.floors = floors;
        }

        
        public void SetApartments(int apartments)
        {
            this.apartments = apartments;
        }

        
        public void SetEntrances(int entrances)
        {
            this.entrances = entrances;
        }

        
        public double GetFloorHeight()
        {
            if (floors == 0) return 0;
            return height / floors;
        }

        public int GetApartmentsPerEntrance()
        {
            if (entrances == 0) return 0; 
            return apartments / entrances; 
        }

        
        public int GetApartmentsPerFloor()
        {
            if (floors == 0) return 0; 
            return apartments / floors; 
        }

        
        public void PrintBuildingDetails()
        {
            Console.WriteLine($"Уникальный номер здания: {buildingNumber}");
            Console.WriteLine($"Высота здания: {height} м");
            Console.WriteLine($"Этажность: {floors} этажей");
            Console.WriteLine($"Количество квартир: {apartments}");
            Console.WriteLine($"Количество подъездов: {entrances}");
            Console.WriteLine($"Высота этажа: {GetFloorHeight():F2} м");
            Console.WriteLine($"Количество квартир в подъезде: {GetApartmentsPerEntrance()}");
            Console.WriteLine($"Количество квартир на этаже: {GetApartmentsPerFloor()}");
        }

        internal void SetHeight(object height)
        {
            throw new NotImplementedException();
        }
    }
}
