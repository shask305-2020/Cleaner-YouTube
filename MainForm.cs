using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Химчистка
{
    public partial class MainForm : Form
    {
        //Изменили конструктор создания формы (добавили строковую переменную)
        public MainForm(string data)
        {
            InitializeComponent();
            userName.Text = data;   //Присвоим объекту Label (где у нас будет имя пользователя) значение,
        }                           //полученное в предыдущем окне

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Order_info order_Info = new Order_info();
            order_Info.Show();
        }
    }
}
