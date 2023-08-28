using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using Oracle.DataAccess.Client;

namespace WindowsFormsApplication5
{
    public partial class diagram : Form
    {
        private static string beginDate, endDate; //Переменные для создания отчета за период
        /* 
         Set и Get методы для переменных 
        */

        public static string GetEndDate()
        {
            return endDate;
        }
        public static void SetBeginDate(string newDate)
        {
            beginDate = newDate;
        }
        public static string GetBeginDate()
        {
            return beginDate;
        }
        public static void SetEndDate(string newDate)
        {
            endDate = newDate;
        }
        public diagram()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Series["s1"].Points.Clear();
            DiagramPeriod f = new DiagramPeriod();
            f.ShowDialog(this);
            try
            {
                OracleConnection connection = new OracleConnection();
                connection.ConnectionString = Properties.Settings.Default.ConnectionString;
                connection.Open(); //Подключаемся к Базе Данных
                OracleCommand cmd = connection.CreateCommand(); //Создаем SQL команду
                chart1.Series["s1"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
                cmd.CommandText = "select COUNT(a.assingment_id) from ASSIGNMENTS a where a.date_of_issue between to_date('" + beginDate + "','dd.mm.yyyy') and to_date('" + endDate + "','dd.mm.yyyy') and a.deadline < a.execution_date"; //Добавляем текст команды. Отбираем элементы из таблицы в которых дата находиться между указаных границ
                if (Int32.Parse(cmd.ExecuteScalar().ToString()) > 0)
                {
                    chart1.Series["s1"].Points.AddXY("Выполнено с опозданием", Int32.Parse(cmd.ExecuteScalar().ToString()));
                }
                cmd.CommandText = "select COUNT(a.assingment_id) from ASSIGNMENTS a where a.date_of_issue between to_date('" + beginDate + "','dd.mm.yyyy') and to_date('" + endDate + "','dd.mm.yyyy') and a.deadline >= a.execution_date"; //Добавляем текст команды. Отбираем элементы из таблицы в которых дата находиться между указаных границ
                if (Int32.Parse(cmd.ExecuteScalar().ToString()) > 0)
                {
                    chart1.Series["s1"].Points.AddXY("Выполнено без опоздания", Int32.Parse(cmd.ExecuteScalar().ToString()));
                }
                cmd.CommandText = "select COUNT(a.assingment_id) from ASSIGNMENTS a where a.date_of_issue between to_date('" + beginDate + "','dd.mm.yyyy') and to_date('" + endDate + "','dd.mm.yyyy') and a.execution_date is null and a.deadline >= to_date('" + System.DateTime.Now.ToString("dd.MM.yyyy") + "','dd.mm.yyyy')"; //Добавляем текст команды. Отбираем элементы из таблицы в которых дата находиться между указаных границ
                if (Int32.Parse(cmd.ExecuteScalar().ToString()) > 0)
                {
                    chart1.Series["s1"].Points.AddXY("Предстоит выполнить", Int32.Parse(cmd.ExecuteScalar().ToString()));
                }
                cmd.CommandText = "select COUNT(a.assingment_id) from ASSIGNMENTS a where a.date_of_issue between to_date('" + beginDate + "','dd.mm.yyyy') and to_date('" + endDate + "','dd.mm.yyyy') and a.execution_date is null and a.deadline < to_date('" + System.DateTime.Now.ToString("dd.MM.yyyy") + "','dd.mm.yyyy')"; //Добавляем текст команды. Отбираем элементы из таблицы в которых дата находиться между указаных границ
                if (Int32.Parse(cmd.ExecuteScalar().ToString()) > 0)
                {
                    chart1.Series["s1"].Points.AddXY("Дедлайн просрочен", Int32.Parse(cmd.ExecuteScalar().ToString()));
                }
                chart1.Series["s1"].Label = "#PERCENT{0.00 %} (#VALY)";
                chart1.Series["s1"].LegendText = "#VALX";
                label1.Text = beginDate + " - " + endDate;
                connection.Close();  //Отключаемся от БД 
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error");
            }
        }
    }
}
