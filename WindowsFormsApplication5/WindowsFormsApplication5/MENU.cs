using System;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class MENU : Form
    {
        public MENU()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ASSIGNMENTS f = new ASSIGNMENTS(); //Создаем экземпляр формы ASSIGNMENTS
            this.Hide(); //Скрываем эту форму
            f.Show(this); //Показываем форму ASSIGNMENTS и указываем владельцем эту форму
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DEPARTMENT f = new DEPARTMENT(); //Создаем экземпляр формы DEPARTMENT
            this.Hide(); //Скрываем эту форму
            f.Show(this); //Показываем форму DEPARTMENT и указываем владельцем эту форму
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EMPLOYEE f = new EMPLOYEE(); //Создаем экземпляр формы EMPLOYEE
            this.Hide(); //Скрываем эту форму
            f.Show(this); //Показываем форму EMPLOYEE и указываем владельцем эту форму
        }       
    }
}
