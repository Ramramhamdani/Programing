using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_1
{
    public partial class Controller : Form,IObserver
    {
        ITrainJourny trainJourny;
        ITrainController trainController;

        public Controller()
        {
            InitializeComponent();
            Controller controller = new Controller(trainController, trainJourny);
        }

        public Controller(ITrainController trainController, ITrainJourny trainJourny)
        {
            InitializeComponent();
            this.trainJourny = trainJourny;
            this.trainController = trainController;

            //this.trainJourny.AddObserver(this);
        }

        public void Update(Station CurrentStation)
        {
            
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            Display display = new Display(trainJourny);
            display.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            trainController.Next();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            trainController.Previous();
        }

        private void Controller_Load(object sender, EventArgs e)
        {

        }
    }
}
