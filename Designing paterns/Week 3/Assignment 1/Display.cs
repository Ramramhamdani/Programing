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
    public partial class Display : Form,IObserver
    {
        ITrainJourny trainJourny;
        public Display(ITrainJourny trainJourny)
        {
            InitializeComponent();

            this.trainJourny = trainJourny;
            //this.trainJourny.AddObserver(this);
        }

        public void Update(Station currentStation)
        {
            currentStation = trainJourny.GetCurrentStation();
            lblCurrent.Text = currentStation.name;
            lblDeparture.Text = (currentStation.departureTime).ToString();
            lblArrival.Text = (currentStation.arrivalTime).ToString();
            lblTrack.Text = currentStation.arrivalTrack;
            Station station = trainJourny.NextStation();
            lblNext.Text = station.name;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
