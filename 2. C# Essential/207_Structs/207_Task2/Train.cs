using System;

namespace _207_Task2
{
    struct Train
    {
        string destination, trainNumber, settingOffTime;
        
        public Train(string destination, string trainNumber, string settingOffTime)
        {
            this.destination = destination;
            this.trainNumber = trainNumber;
            this.settingOffTime = settingOffTime;
        } 

        public string Destination
        {
            get
            {
                return destination;
            }
        } 
        
        public string TrainNumber
        {
            get
            {
                return trainNumber;
            }
        } 
        
        public string SettingOffTime
        {
            get
            {
                return settingOffTime;
            }
        }


    }
}
