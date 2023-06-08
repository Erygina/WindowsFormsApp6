using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6
{
    public class Bank
    {
        public List<Operator> Operators = new List<Operator>();//все операторы в банке, желательно задавать их кол-во в форме
        public List<Customer> CustomersInQueue = new List<Customer>();//очередь из клиентов, вывести кол-во на форму
        public int CustomersProcessed = 0;//сколько клиентов обслужено, вывести на форму

        public Bank(int operatorsQuantity)
        {
            for (int i = 0; i < operatorsQuantity; i++)
            {
                Operators.Add(new Operator(this));
            }
        }

        public void addCustomerToQueue(Customer customer)
        {
            CustomersInQueue.Add(customer);
        }

        public void run()
        {
            foreach (Operator op in Operators)
            {
                if (op.isFree())
                {
                    if (CustomersInQueue.Count > 0)
                    {
                        Customer customer = CustomersInQueue[0];
                        CustomersInQueue.Remove(customer);
                        op.setCustomer(customer);
                    }
                }
                else
                {
                    op.processTask();
                }
            }
        }

        public void CompleteTask()
        {
            CustomersProcessed++;
        }
    }
}
