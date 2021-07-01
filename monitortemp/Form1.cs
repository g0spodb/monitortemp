using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace monitortemp
{
    public partial class Form1 : Form
    {
        private List<string> result = new List<string>();
        int time=0;
        string textWriter = @"tempra.txt";
        public Form1()
        {
            InitializeComponent();
        }

        private void btstart_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(tbmax.Text))
            {
                String[] temp = tbtemp.Text.Split(' ');
                for (int i = 0; i < temp.Length; i++)
                {
                    if (Convert.ToInt32(temp[i]) < Convert.ToInt32(tbmin.Text))
                    {
                        result.Add($"Время:{dateTimePicker1.Value.AddMinutes(i * 10)}, Факт:{temp[i]}, Норма:{tbmin.Text}, Отклонение от нормы:{(Convert.ToInt32(temp[i]) - Convert.ToInt32(tbmin.Text))}");
                        time++;
                        using (StreamWriter sw = new StreamWriter(textWriter, true, System.Text.Encoding.Default))
                        {
                            sw.WriteLine($"Время:{dateTimePicker1.Value.AddMinutes(i * 10)}, Факт:{temp[i]}, Норма:{tbmin.Text}, Отклонение от нормы:{(Convert.ToInt32(temp[i]) - Convert.ToInt32(tbmin.Text))}");
                        }
                    }
                }
                MessageBox.Show("Порог масимально допустимой температуры превышен на " + TimeSpan.FromMinutes(time * 10) + " минут");
                tbotchetinfo.Text = ("Порог масимально допустимой температуры превышен на " + TimeSpan.FromMinutes(time * 10) + " минут");
                tbotchet.Text = string.Join(Environment.NewLine, result);
            }
            else if (String.IsNullOrEmpty(tbmin.Text))
            {
                String[] temp = tbtemp.Text.Split(' ');
                for (int i = 0; i < temp.Length; i++)
                {
                    if (Convert.ToInt32(temp[i]) > Convert.ToInt32(tbmax.Text))
                    {
                        result.Add($"Время: {dateTimePicker1.Value.AddMinutes(i * 10)}, Факт:{temp[i]}, Норма:{tbmax.Text}, Отклонение от нормы:{(Convert.ToInt32(temp[i]) - Convert.ToInt32(tbmax.Text))}");
                        time++;
                        using (StreamWriter sw = new StreamWriter(textWriter, true, System.Text.Encoding.Default))
                        {
                            sw.WriteLine($"Время: {dateTimePicker1.Value.AddMinutes(i * 10)}, Факт:{temp[i]}, Норма:{tbmax.Text}, Отклонение от нормы:{(Convert.ToInt32(temp[i]) - Convert.ToInt32(tbmax.Text))}");
                        }
                    }
                }
                MessageBox.Show("Порог масимально допустимой температуры превышен на " + TimeSpan.FromMinutes(time * 10) + " минут");
                tbotchetinfo.Text = ("Порог масимально допустимой температуры превышен на " + TimeSpan.FromMinutes(time * 10) + " минут");
                tbotchet.Text = string.Join(Environment.NewLine, result);
            }
            else
            {
                String[] temp = tbtemp.Text.Split(' ');
                for (int i = 0; i < temp.Length; i++)
                {
                    if (Convert.ToInt32(temp[i]) > Convert.ToInt32(tbmax.Text))
                    {
                        result.Add($"Время: {dateTimePicker1.Value.AddMinutes(i * 10)}, Факт:{temp[i]}, Норма:{tbmax.Text}, Отклонение от нормы:{(Convert.ToInt32(temp[i]) - Convert.ToInt32(tbmax.Text))}");
                        time++;
                        using (StreamWriter sw = new StreamWriter(textWriter, true, System.Text.Encoding.Default))
                        {
                            sw.WriteLine($"Время: {dateTimePicker1.Value.AddMinutes(i * 10)}, Факт:{temp[i]}, Норма:{tbmax.Text}, Отклонение от нормы:{(Convert.ToInt32(temp[i]) - Convert.ToInt32(tbmax.Text))}");
                        }
                    }
                    if (Convert.ToInt32(temp[i]) < Convert.ToInt32(tbmin.Text))
                    {
                        result.Add($"Время:{dateTimePicker1.Value.AddMinutes(i * 10)}, Факт:{temp[i]}, Норма:{tbmin.Text}, Отклонение от нормы:{(Convert.ToInt32(temp[i]) - Convert.ToInt32(tbmin.Text))}");
                        time++;
                        using (StreamWriter sw = new StreamWriter(textWriter, true, System.Text.Encoding.Default))
                        {
                            sw.WriteLine($"Время:{dateTimePicker1.Value.AddMinutes(i * 10)}, Факт:{temp[i]}, Норма:{tbmin.Text}, Отклонение от нормы:{(Convert.ToInt32(temp[i]) - Convert.ToInt32(tbmin.Text))}");
                        }
                    }
                }
                MessageBox.Show("Порог масимально допустимой температуры превышен на " + TimeSpan.FromMinutes(time * 10) + " минут");
                tbotchetinfo.Text = ("Порог масимально допустимой температуры превышен на " + TimeSpan.FromMinutes(time * 10) + " минут");
                tbotchet.Text = string.Join(Environment.NewLine, result);
            }
        }
    }
}
