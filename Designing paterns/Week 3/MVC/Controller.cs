using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVC
{
    public partial class Controller : Form,ITrainController
    {
        TrainJourny TrainJourny;
        Form1 Screen1;
        public Controller()
        {
            InitializeComponent();
            TrainJourny = new TrainJourny();
            
        }
        

        public Station GetCurrent()
        {
            return TrainJourny.GetCurrentStation();
        }

        public Station GetNext()
        {
            return TrainJourny.GetNext();
        }

        public void Next()
        {
            TrainJourny.NextStation();
        }

        public void Previous()
        {
            TrainJourny.Previous();
        }

        public void ReturnJourny()
        {
            TrainJourny.ReturnJourny();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Next();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ReturnJourny();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            Previous();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Screen1==null)
            {
                Screen1 = new Form1(TrainJourny,this);

                TrainJourny.AddObserver(Screen1);
                Screen1.Show();
            }
            else
            {
                Screen1.Close();

                TrainJourny.RemoveObserver(Screen1);
                Screen1 = null;
            }
        }
    }
}
