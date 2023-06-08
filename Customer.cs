using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6
{
    public class Customer
    {
        private double taskTime;

        public Customer()
        {
            taskTime = Form1.Random.Next(500, 1000);
        }

        public void processTask()
        {
            taskTime -= 1;
        }

        public bool isTaskCompleted()
        {
            return taskTime <= 0;
        }
    }
}
