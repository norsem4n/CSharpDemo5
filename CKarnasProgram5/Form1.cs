using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CKarnasProgram5
{
    public partial class Form1 : Form
    {
        
        //declare a class-level variable

            PaintJob aPaintJob;

        public Form1()
        {
            InitializeComponent();
        }

        // Click event that calculates the estimate

        private void btnEstimate_Click(object sender, EventArgs e)
        {
            //declare variables

            int intSqFootage;
            double dblPaintCost, dblPaintJob;

            //instantiate a new Paintjob Object

            aPaintJob = new PaintJob();

            //convert datatypes 

            intSqFootage = Convert.ToInt32(nudSqFtPaint.Text);
            dblPaintCost = Convert.ToDouble(nudPaintCost.Text);

            //call the CalculatePaintJob method

            dblPaintJob = aPaintJob.CalculatePaintJob(intSqFootage, dblPaintCost);

            //display the result in a messagebox

            MessageBox.Show(dblPaintJob.ToString("C"),"Estimated Cost",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }

        // Click event that closes the form

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Click event that resets the inputs 

        private void btnReset_Click(object sender, EventArgs e)
        {
            nudSqFtPaint.Value = 0;
            nudPaintCost.Value = 0;
        }

    }
}
