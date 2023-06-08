using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6
{
    public class Operator
    {
        private Customer _customer;
        private Bank _bank;

        public Operator(Bank bank)
        {
            _customer = null;
            _bank = bank;
        }

        public void setCustomer(Customer customer)
        {
            _customer = customer;
        }

        public bool isFree()
        {
            return _customer == null;
        }

        public void processTask()
        {
            if (_customer != null)
            {
                _customer.processTask();
                checkIsTaskCompleted();
            }
        }

        public void checkIsTaskCompleted()
        {
            if (_customer.isTaskCompleted())
            {
                _customer = null;
                _bank.CompleteTask();
            }
        }
    }
}
