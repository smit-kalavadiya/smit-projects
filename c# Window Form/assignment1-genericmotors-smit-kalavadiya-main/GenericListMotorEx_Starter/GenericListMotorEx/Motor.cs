using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericListMotorEx
{
    
    class Motor
    {
        private string des;
        private int motorID;
        private int rpm;
        private int voltage;
        private string status;

        public int RPM
        {
            get
            {
                return rpm;
            }
        }

        public int Voltage
        {
            get
            {
                return voltage;
            }
        }


        public string Des 
        {
            
            get {
                return des;
            }
        }

        public int MotorID
        {
            get {
                return motorID;
            }
        }

        public string Status
        {
            get
            {
                return status;
            }
        }

        public Motor(int MotorID,string des,int rpm, int voltage,string status)
        {
            this.des = des;
            this.motorID = MotorID;
            this.rpm = rpm;
            this.voltage = voltage;
            this.status = status;

        }
        
    }
}
