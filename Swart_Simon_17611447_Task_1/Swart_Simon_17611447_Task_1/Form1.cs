using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Swart_Simon_17611447_Task_1
{
    public partial class Form1 : Form
    {

        Map m = new Map();
        GameEngine g = new GameEngine();
        Random rng = new Random();
        int random;

        public Form1()
        {
            InitializeComponent();
            txtMap.Text = m.createMap();
            lblTimer.Text = "Time: 0";
            random = rng.Next(5, 11);
            gameTime.Stop();
        }

        int count = 1;

        

        private void gameTime_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = "Time: " + count;
            m.spawnUnit();
            txtMap.Text = m.moveUnit();

            if(count % random == 0)
            {

            }

            count++;
        }

        private void btnStartTime_Click(object sender, EventArgs e)
        {
            gameTime.Start();
        }

        private void btnStopTime_Click(object sender, EventArgs e)
        {
            gameTime.Stop();
            lblTimer.Text = "Time: " + (count - 1) + " [PAUSED]";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            m.saveInfo();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
           txtMap.Text = m.loadInfo();
        }
    }
}
