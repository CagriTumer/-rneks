using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Örneks
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            //görev1 = yaşını hesaplayınız
            DateTime dt = dtpTarih.Value;
            //MessageBox.Show(dt.Year.ToString());
            //MessageBox.Show(dt.Month.ToString());
            TimeSpan gecenSure = DateTime.Now - dtpTarih.Value;
            //MessageBox.Show(Math.Ceiling(gecenSure.TotalDays).ToString());

            lblYas.Text = lblYas.Text + (DateTime.Now.Year - dt.Year).ToString();
            lblGun.Text = lblGun.Text + ((int)(gecenSure.TotalDays)).ToString() ;

            if (dt.Month==3 )
            {
                if (dt.Day>=21)
                {
                    lblBurc.Text = lblBurc.Text + " koc ";
                }
                
            }
            else if (dt.Month==4)
            {
                if (dt.Day<=20)
                {
                    lblBurc.Text = lblBurc.Text + " koc ";

                }
                else 
                {
                    lblBurc.Text = lblBurc.Text + " boğa ";
                }
            }
            else if (dt.Month==5)
            {
                if (dt.Day<=20)
                {
                    lblBurc.Text = lblBurc.Text + " boğa ";
                }
                else 
                {
                    lblBurc.Text = lblBurc.Text + " ikizler";
                }         
            }
            else if (dt.Month==6)
            {
                if (dt.Month<=21)
                {
                    lblBurc.Text = lblBurc.Text + " ikizler ";
                }
                else
                {
                    lblBurc.Text = lblBurc.Text + " yengeç";
                }
            }         
            
        }
    }
}
