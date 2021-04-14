/* CIS 605 Assignment 3, Program 5
 * Developed by Christopher Karnas
 * Date Created: September, 2020
 * Date Last Modified: 9/32/2020
 * Class name: Paint Job
 * Description: Estimate tool for the cost of a painting job
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKarnasProgram5
{
    class PaintJob
    {
        /* Method to calculate cost of painting
         * Parameters: Sq Footage painted, Gallon of Paint cost, Labor cost
         * Output: Estimate for paint job
        */
        public double CalculatePaintJob(int intSqFootage, double dblPaintCost)
        {
            // constants and variables

            const double dblLaborCost = 3.20;
            const int intSqFtPaintCover = 375;

            double dblPaintJob;

            // calculate paint job
            // paint cost = (square footage to be painted / 375) * cost of a gallon of paint
            // labor cost = square footage to be painted *3.20)

            dblPaintJob = ((intSqFootage / intSqFtPaintCover) * dblPaintCost) + (intSqFootage * dblLaborCost);

            return dblPaintJob;

        }


    }
}
