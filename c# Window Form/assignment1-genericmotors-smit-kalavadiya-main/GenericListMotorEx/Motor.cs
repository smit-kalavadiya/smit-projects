using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericListMotorEx
{
    class Motor
    {
        private string des;
        private string motorID;
        private int rpm;
        private int voltage;
        private string status;

        public string MotorId
        {
            get
            {
                return motorID;
            }
            set
            {
                if (int.TryParse(value, out int id) && id.ToString().Length == 5)
                {
                    motorID = value;
                }
                else
                {
                    throw new ConstraintException("MotorId must be 5 numeric characters in length.");
                }
            }
        }

        public string Des
        {
            get
            {
                return des;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ConstraintException("Description is required.");
                }
                else
                {
                    des = value;
                }
            }
        }

        public int Rpm
        {
            get
            {
                return rpm;
            }
            set
            {
                if (int.TryParse(value.ToString(), out int rpm) && rpm >= 10 && rpm <= 10000)
                {
                    this.rpm = value;
                }
                else
                {
                    throw new ConstraintException("Invalid input");
                }
            }
        }

        public string Status
        {
            get
            {
                return status;
            }
            set
            {
                status = value;
            }
        }
        public int Voltage
        {
            get
            {
                return voltage;
            }
            set
            {
                if (int.TryParse(value.ToString(), out int voltage) && voltage >= 1 && voltage <= 500)
                {
                    this.voltage = value;
                }
                else
                {
                    throw new ConstraintException("Invalid input");
                }

            }
        }
    }
}
