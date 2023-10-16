using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace odev16_1504
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnkomtol_Click(object sender, EventArgs e)
        {

        }

        private void btnkontol_Click(object sender, EventArgs e)
        {
            string secme;
            bool CEVAP1, CEVAP2;
            secme = lsuzunluk.ToString();
            CEVAP1 = raresim.Checked;
            CEVAP2 = ravıdoyo.Checked;
            if (CEVAP1 == true && (secme == "MP4" || secme == "MOV"))
            {
                MessageBox.Show("cevabınız doğru");
            }
            if (CEVAP1 == false && (secme == "MP4" || secme == "MOV"))
            {
                MessageBox.Show("cevabınız yanlış");
            }
            if(CEVAP2 == true && (secme == "jpg" || secme == "png"))
            {
                MessageBox.Show("cevabınız doğru");
            }
            if (CEVAP2 == false && (secme == "jpg" || secme == "png"))
            {
                MessageBox.Show("cevabınız yanlış");
            }                                                
