using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace POS
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            PopulateDataGridView();

            
        }


        private void PopulateDataGridView()
        {

            string[] row0 = { "15848185181", "Product Name", "9"};
            string[] row1 = { "15848185181", "Product Name", "9" };
            string[] row2 = { "15848185181", "Product Name", "9" };
            string[] row3 = { "15848185181", "Product Name", "9"};
            string[] row4 =  { "15848185181", "Product Name", "9"};
            string[] row5 =  { "15848185181", "Product Name", "9"};
            string[] row6 =  { "15848185181", "Product Name", "9"};


            dataGridView1.ColumnCount = 3;

            dataGridView1.Columns[0].Name = "Barcode";
            dataGridView1.Columns[1].Name = "Name";
            dataGridView1.Columns[2].Name = "Amount";
             

            dataGridView1.Rows.Add(row0);
            dataGridView1.Rows.Add(row1);
            dataGridView1.Rows.Add(row2);
            dataGridView1.Rows.Add(row3);
            dataGridView1.Rows.Add(row4);
            dataGridView1.Rows.Add(row5);
            dataGridView1.Rows.Add(row6);

            
        }



    }
}
