using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using Oracle.DataAccess.Client;

namespace WindowsFormsApplication5
{
    public partial class ASSIGN_report : Form
    {
        private static string date, beginDate, endDate; //Переменные для создания отчета за определенную дату или за период
        /* 
         Set и Get методы для переменных 
        */
        public static string GetDate() 
        {
            return date;
        }
        public static void SetDate(string newDate)
        {
            date = newDate;
        }
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

        public ASSIGN_report()
        {
            InitializeComponent();
            reportViewer1.ReportRefresh += new CancelEventHandler(reportViewer1_ReportRefresh); //Обработчик событий при нажатии на кнопку Refresh
        }

        void reportViewer1_ReportRefresh(object sender, CancelEventArgs e)
        {
            try
            {
                OracleConnection connection = new OracleConnection();
                connection.ConnectionString = Properties.Settings.Default.ConnectionString;
                connection.Open(); //Подключаемся к Базе Данных
                OracleCommand cmd = connection.CreateCommand(); //Создаем SQL команду
                cmd.CommandText = "select * from ASSIGNMENTS"; //Добавляем текст команды. Отбираем все элементы из таблицы
                DataTable dt = new DataTable(); //Создаем переменную таблицы
                OracleDataAdapter da = new OracleDataAdapter(cmd);
                da.Fill(dt); //Заполняем таблицу
                connection.Close();  //Отключаемся от БД
                this.reportViewer1.LocalReport.DataSources.Clear(); //Удаляем все элементы из reportViewer1
                this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", dt)); //Добавляем в reportViewer1 данные с таблицы dt
                this.reportViewer1.RefreshReport(); //Обновляем reportViewer1
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error");
            }
        }

       

        private void ASSIGN_report_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "DataSet1.ASSIGNMENTS". При необходимости она может быть перемещена или удалена.
            try
            {
                this.ASSIGNMENTSTableAdapter.Fill(this.DataSet1.ASSIGNMENTS);
                this.reportViewer1.RefreshReport();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OracleConnection connection = new OracleConnection();
                connection.ConnectionString = Properties.Settings.Default.ConnectionString;
                connection.Open(); //Подключаемся к Базе Данных
                OracleCommand cmd = connection.CreateCommand(); //Создаем SQL команду
                cmd.CommandText = "select * from ASSIGNMENTS a where a.date_of_issue = to_date('" + System.DateTime.Now.ToString("dd.MM.yyyy") + "','dd.mm.yyyy')"; //Добавляем текст команды. Отбираем элементы из таблицы в которых дата равна сегодняшней
                DataTable dt = new DataTable();
                OracleDataAdapter da = new OracleDataAdapter(cmd);
                da.Fill(dt); //Заполняем таблицу
                connection.Close();  //Отключаемся от БД
                this.reportViewer1.LocalReport.DataSources.Clear(); //Удаляем все элементы из reportViewer1
                this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", dt)); //Добавляем в reportViewer1 данные с таблицы dt
                this.reportViewer1.RefreshReport(); //Обновляем reportViewer1
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AssignmentsDate f = new AssignmentsDate();
            f.ShowDialog(this);
            try
            {
                OracleConnection connection = new OracleConnection();
                connection.ConnectionString = Properties.Settings.Default.ConnectionString;
                connection.Open(); //Подключаемся к Базе Данных
                OracleCommand cmd = connection.CreateCommand(); //Создаем SQL команду
                cmd.CommandText = "select * from ASSIGNMENTS a where a.date_of_issue = to_date('" + date + "','dd.mm.yyyy')"; //Добавляем текст команды. Отбираем элементы из таблицы в которых дата равна указаной
                DataTable dt = new DataTable();
                OracleDataAdapter da = new OracleDataAdapter(cmd);
                da.Fill(dt); //Заполняем таблицу
                connection.Close();  //Отключаемся от БД
                this.reportViewer1.LocalReport.DataSources.Clear(); //Удаляем все элементы из reportViewer1
                this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", dt)); //Добавляем в reportViewer1 данные с таблицы dt
                this.reportViewer1.RefreshReport(); //Обновляем reportViewer1
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            AssignmentsPeriod f = new AssignmentsPeriod();
            f.ShowDialog(this);
            try
            {
                OracleConnection connection = new OracleConnection();
                connection.ConnectionString = Properties.Settings.Default.ConnectionString;
                connection.Open(); //Подключаемся к Базе Данных
                OracleCommand cmd = connection.CreateCommand(); //Создаем SQL команду
                cmd.CommandText = "select * from ASSIGNMENTS a where a.date_of_issue between to_date('" + beginDate + "','dd.mm.yyyy') and to_date('" + endDate + "','dd.mm.yyyy')"; //Добавляем текст команды. Отбираем элементы из таблицы в которых дата находиться между указаных границ
                DataTable dt = new DataTable();
                OracleDataAdapter da = new OracleDataAdapter(cmd);
                da.Fill(dt); //Заполняем таблицу
                connection.Close();  //Отключаемся от БД
                this.reportViewer1.LocalReport.DataSources.Clear(); //Удаляем все элементы из reportViewer1
                this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", dt)); //Добавляем в reportViewer1 данные с таблицы dt
                this.reportViewer1.RefreshReport(); //Обновляем reportViewer1
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
            OracleConnection connection = new OracleConnection();
            connection.ConnectionString = Properties.Settings.Default.ConnectionString;
            connection.Open(); //Подключаемся к Базе Данных
            OracleCommand cmd = connection.CreateCommand(); //Создаем SQL команду
            cmd.CommandText = "select * from ASSIGNMENTS a where a.deadline < to_date('" + System.DateTime.Now.AddDays(7).ToString("dd.MM.yyyy") + "','dd.mm.yyyy') and a.deadline >= to_date('" + System.DateTime.Now.ToString("dd.MM.yyyy") + "','dd.mm.yyyy')"; //Добавляем текст команды. Отбираем элементы из таблицы в которых дедлайн находиться в пределах 7 дней от сегодняшней даты
            DataTable dt = new DataTable();
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            da.Fill(dt); //Заполняем таблицу
            connection.Close();  //Отключаемся от БД
            this.reportViewer1.LocalReport.DataSources.Clear(); //Удаляем все элементы из reportViewer1
            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", dt)); //Добавляем в reportViewer1 данные с таблицы dt
            this.reportViewer1.RefreshReport(); //Обновляем reportViewer1
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error");
            }
        }
    }
}
