using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Customers_Simulation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Simulate(object sender, EventArgs e)
        {
            G_Panel.Enabled = true;
            Prepare();
        }

        private int Prepare()
        {
            int Customers_Num = (new Random().Next()) % (int)(WH_NBox.Value * Aph_NBox.Value);
            Out_Box.Text = "Number of Cutomers today: " + Customers_Num.ToString();
            Out_Box.Text += "\r\n______________________________";
            if (Customers_Num == 0) {
                WW_Box.Text = ((int)(WH_NBox.Value)*60).ToString()+"minutes";
                CW_Box.Text = "0 minutes";
                OT_Box.Text = "0 minutes";
                return 0;
            }
            return Run_Program(Customers_Num);
        }

        private int Run_Program(int C_Num)
        {
            int CloseTime = 0;
            int WW = 0, CW = 0;
            int ServiceTime =(int) ST_NBox.Value;
            MzQueue Customers = new MzQueue(C_Num);
            Worker [] Workers =new Worker[(int)WN_NBox.Value];
            for (int i = 0; i < (int)WN_NBox.Value; ++i)
            {
                Workers[i] = new Worker();
            }
            //if (!Workers[0].isBusy()) Console.Write("Hi"); // Debug
            int old = -1;
            while (!(Customers.isFull()))
            {
                //Clock Remove Loop
                int num = (new Random().Next())%((int)(WH_NBox.Value * 60));
                if (num != old)
                {
                    Customers.Enqueue(num);
                    old = num;
                }
            }
            /* getting a random numbers then sorting them 
             * gives higher probability to get different numbers
             * than getting a random numbers which is just larger than the previous one
             */
            Customers.sort();
            for(int i=0;!(Customers.isEmpty());i++){
                int Arrival = Customers.Dequeue();
                Out_Box.Text +="\r\nCustomer number #"+(i+1);
                Out_Box.Text += "\r\nArrived after " + Arrival+" minutes.";
                int Wi=i%(int)WN_NBox.Value;
                if ((!Workers[Wi].isBusy(Arrival)) && Arrival == Workers[Wi].Finished)
                {
                    Out_Box.Text += "\r\nHasn't Waited";
                    Workers[Wi].Work(Arrival, ServiceTime);
                }
                else if ((!Workers[Wi].isBusy(Arrival)) && Arrival > Workers[Wi].Finished)
                {
                    WW += (Arrival - Workers[Wi].Finished);
                    Out_Box.Text += "\r\nHasn't Waited";
                    Workers[Wi].Work(Arrival, ServiceTime);
                }
                else
                {
                    CW += (Workers[Wi].Finished - Arrival);
                    Out_Box.Text += "\r\nWaited for " + (Workers[Wi].Finished - Arrival) + " minutes";
                    Workers[Wi].Work(Workers[Wi].Finished, ServiceTime);
                }
                Out_Box.Text += "\r\n---------------------------------------------";
                CloseTime=Workers[Wi].Finished;
            }
            if (CloseTime > (WH_NBox.Value * 60)) OT_Box.Text = (CloseTime - (WH_NBox.Value * 60)).ToString() + " minutes";
            else
            {
                OT_Box.Text = "0 minutes";
                WW += (((int)WH_NBox.Value * 60) - CloseTime)*((int)WN_NBox.Value);
            }
            WW_Box.Text = (WW/(int)WN_NBox.Value).ToString()+" minutes";
            CW_Box.Text = (CW/C_Num).ToString() + " minutes";
            return (CW/C_Num);
        }

        private void Graph(object sender, EventArgs e)
        {
            int []Days= new int[(int)(Days_NBox.Value)];
            for (int i = 0; i < (int)Days_NBox.Value;++i)
            {

                Days[i] = Prepare();
            }
            Chart G_Chart = new Chart();
            G_Chart.Visible = true;
            G_Chart.Chart_Load(Days);
        }
    }
}
