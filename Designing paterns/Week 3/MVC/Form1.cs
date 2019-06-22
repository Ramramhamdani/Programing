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
    public partial class Form1 : Form,IObserver
    {
        ITrainJourny TrainJourny;
        ITrainController TrainController;

        public Form1(ITrainJourny trainJourny,ITrainController trainController)
        {
            InitializeComponent();
            TrainController = trainController;
            TrainJourny = trainJourny;

            //Why I can't call the Update methode?
            Station station = TrainController.GetCurrent();
            lblDeparture.Text = station.departureTime.ToString();
            lblCurrent.Text = station.name;
            Station station2 = TrainController.GetNext();
            lblNext.Text = station2.name;
            lblArrival.Text = station2.arrivalTime.ToString();
        }
        void IObserver.UpdateScreen()
        {
            Station station = TrainController.GetCurrent();
            lblDeparture.Text = station.departureTime.ToString();
            lblCurrent.Text = station.name;
            Station station2 = TrainController.GetNext();
            lblNext.Text = station2.name;
            lblArrival.Text = station2.arrivalTime.ToString();
        }
    }
}
