using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bubblesort
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        int n = 10, min = 0, max = 20;

        /// <summary>
        /// implement bubblesort
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            int[] a = csort.generate_ints(n, min, max);
            for (int i = 0; i < a.Length; i++) Listbox1.Items.Add(a[i]);
            a = csort.bubblesort(a);
            for (int i = 0; i < a.Length; i++) Listbox2.Items.Add(a[i]);
        }

        

       
    }
}
