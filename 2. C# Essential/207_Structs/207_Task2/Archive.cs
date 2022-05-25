using System;

namespace _207_Task2
{
    static class Archive
    {
        static Train[] trainInfo;

        //Train toMoscow = new Train("Moscow", "601", "23:35");
        //Train toVolgograd = new Train("Volgograd", "732", "06:30");
        //Train toAstana = new Train("Astana", "201", "12:05");
        //Train toVorkuta = new Train("Vorkuta", "465", "23:50");
        //Train toPrague = new Train("Prague", "205", "15:45");
        //Train toMakhachkala = new Train("Makhachkala", "505", "17:00");
        //Train toKiev = new Train("Kiev", "408", "12:00");
        //Train toTashkent = new Train("Tashkent", "789", "10:25");

        static Archive()
        {
            trainInfo = new Train[8];

            trainInfo[0] = new Train("Moscow", "1", "23:35");
            trainInfo[1] = new Train("Volgograd", "2", "06:30");
            trainInfo[2] = new Train("Astana", "3", "12:05");
            trainInfo[3] = new Train("Vorkuta", "4", "23:50");
            trainInfo[4] = new Train("Prague", "5", "15:45");
            trainInfo[5] = new Train("Makhachkala", "6", "17:00");
            trainInfo[6] = new Train("Kiev", "408", "7:00");
            trainInfo[7] = new Train("Tashkent", "8", "10:25");
        }

        static public string GetInfo(string trainNamber)
        {
            for(int i = 0; i < trainInfo.Length; i++)
            {
                if (trainInfo[i].TrainNumber == trainNamber)
                {
                    return string.Format("\n" + trainInfo[i].Destination + "\n" + trainInfo[i].TrainNumber + "\n" + trainInfo[i].SettingOffTime);
                }              
            }

            return string.Format("The number hasn't been found.");
        }
    }
}
