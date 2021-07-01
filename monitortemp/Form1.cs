using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace monitortemp
{
    public partial class Form1 : Form
    {
        private List<string> result = new List<string>();
        int time=0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btstart_Click(object sender, EventArgs e)
        {
            //string temp = tbtemp.Split;
            String[] temp = tbtemp.Text.Split(' ');
            for(int i = 0; i< temp.Length;i++)
            {
                if (Convert.ToInt32(temp[i]) > Convert.ToInt32(tbmax.Text))
                {
                    result.Add($"Минут:{i * 10}, Факт:{temp[i]}, Норма:{tbmax.Text}, Отклонение от нормы:{(Convert.ToInt32(temp[i]) - Convert.ToInt32(tbmax.Text))}");
                    time++;
                }
                if (Convert.ToInt32(temp[i]) < Convert.ToInt32(tbmin.Text))
                {
                    result.Add($"Минут:{i * 10}, Факт:{temp[i]}, Норма:{tbmin.Text}, Отклонение от нормы:{(Convert.ToInt32(temp[i]) - Convert.ToInt32(tbmin.Text))}");
                    time++;
                }
            }
            tbotchetinfo.Text = ("Порог масимально допустимой температуры превышен на " + TimeSpan.FromMinutes(time*10) + " минут");
            tbotchet.Text = string.Join(Environment.NewLine, result);
        }
    }
}
