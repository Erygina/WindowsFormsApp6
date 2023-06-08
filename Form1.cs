using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public static Random Random = new Random();
        private double _interval;//время до прихода след клиента, вывести на форму
        private Bank _bank;
        private int _lambda = 2;
        private int numberOfOperators;
        private int freeOps = 0;

        public Form1()
        {
            InitializeComponent();
            
            
        }

        private void generateInterval()
        {
            _interval = (-Math.Log(Random.NextDouble()) / _lambda) * 100;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            freeOps = 0;
            _interval -= 1;
            _bank.run();
            foreach(Operator op in _bank.Operators)
            {
                if (op.isFree())
                {
                    freeOps++;
                }
            }

            nextPersonTime.Text = Math.Round(_interval).ToString();//вывод таймера - надо красиво
            queueSize.Text = _bank.CustomersInQueue.Count.ToString();//вывод кол-ва клиентов в очереди
            readySize.Text = _bank.CustomersProcessed.ToString();//вывод кол-ва обслуженных клиентов
            freeOperators.Text = freeOps.ToString();//вывод кол-ва свободных операторов

            if(_interval <= 0)
            {
                _bank.addCustomerToQueue(new Customer());
                generateInterval();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            numberOfOperators = (int)operatorsNum.Value;
            _bank = new Bank(numberOfOperators);//10 - затычка, желательно задавать кол-во операторов на форме
            timer1.Start();
        }
    }
}
