using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using System.Net.Http;


namespace ElasticBot
{
    public partial class Form1 : Form
    {
        BackgroundWorker bw;
        OracleConnection connnection;
        public Form1()
        {
            InitializeComponent();

            this.bw = new BackgroundWorker();

        }
        
        private void ConnectToDBoButtton_Click(object sender, EventArgs e)
        {

            /* var text = InputConnectTextBox.Text;
                 ElasticBot bot = new ElasticBot();
                 bot.TestApiAsync();*/
         
            string oracleDbConnection = "Data Source=(DESCRIPTION="
                                                 + "(ADDRESS_LIST="
                                                         + "(ADDRESS="
                                                         + "(PROTOCOL=TCP)"
                                                         + "(HOST="++")"
                                                         + "(PORT=+""+)"
                                                         + ")"
                                                 + ")"
                                                 + "(CONNECT_DATA="
                                                         + "(SERVER=DEDICATED)"
                                                         + "(SERVICE_NAME="++")"
                                                 + ")"
                                          + ");"
 + "User Id="+s+";Password="+s+";";


         connnection = new OracleConnection(oracleDbConnection);


             try
             {
                 connnection.Open();

                 ExitFromBaseButton.Visible = true;
                 ExitFromBaseButton.Enabled = true;
                RequestSQLbutton.Enabled = true;
                RequestSQLbutton.Visible = true;
                ConnectToDBoButtton.Visible = false;
                
                 InputConnectTextBox.Text = "Подключено к Базе ";

             }

             catch (OracleException ex)
             {
                 if (connnection.State != ConnectionState.Open)
                 {

                     InputConnectTextBox.Text = "Ошибка подключения к Базе ";

                 }



                 InputConnectTextBox.Text = ex.Message;

             }

         }
         

         private void ExitFromBaseButton_Click(object sender, EventArgs e)
         {
             if (connnection.State == ConnectionState.Open)
             {
                 connnection.Close();
                 connnection.Dispose();
                 if (connnection.State != ConnectionState.Open)
                 {
                    RequestSQLbutton.Enabled = !true;
                    RequestSQLbutton.Visible = !true;
                    ExitFromBaseButton.Visible = !true;
                    ExitFromBaseButton.Enabled = !true;
                    ConnectToDBoButtton.Visible = !false;
                    InputConnectTextBox.Text = "Произошло отключение от Базы Данных ";
                 }
             }
         }

        private void RequestSQLbutton_Click(object sender, EventArgs e)
        {
            if(InputConnectTextBox.Text!="" && connnection.State == ConnectionState.Open)
            {
                using (OracleCommand command = new OracleCommand())
                {
                    command.Connection = connnection;
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "select * from ALL_TABLES";
                    //command.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    OracleDataReader reader = command.ExecuteReader();
                    try
                    {
                        dt.Load(reader);
                        dataGridView1.DataSource = dt;
                    }
                    catch
                    {
                        MessageBox.Show("Ошибка в чтении записей");
                    }
                }
               

            }
        }
        private void Init_My_Button()
        {
            Button back = new Button();
            back.Name = "backButton";
            back.Text = "Назад";
            back.Width = RequestSQLbutton.Width;
            back.Height = RequestSQLbutton.Height;
            back.Location = new Point(20, 432);
            back.DialogResult = DialogResult.OK;
            back.Click += new System.EventHandler(but_Back_Click);
            Controls.Add(back);
        }
        private void but_Back_Click(object sender, EventArgs e)
        {
            Controls.Remove((Button)sender);
            RequestSQLbutton_Click(sender, e);
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (InputConnectTextBox.Text != "" && connnection.State == ConnectionState.Open)
            {
                using (OracleCommand command = new OracleCommand())
                {
                    if (dataGridView1.SelectedCells.Count == 1 && dataGridView1.Columns[e.ColumnIndex].HeaderText.ToString()=="TABLE_NAME")
                    {
                        command.Connection = connnection;
                        command.CommandType = System.Data.CommandType.Text;
                        command.CommandText = "select * from " + dataGridView1.CurrentCell.Value.ToString() + "";
                        //command.ExecuteNonQuery();
                        DataTable dt = new DataTable();
                        try
                        {
                            OracleDataReader reader = command.ExecuteReader();
                      
                            dt.Load(reader);
                            dataGridView1.DataSource = dt;
                            Init_My_Button();
                            
                        }
                        catch
                        {
                            MessageBox.Show("Ошибка в чтении записей");
                            MessageBox.Show("Ошибка в чтении записей");
                        }
                    }
                }
            }
        }
    }
    class ElasticBot
    {
        private string key = ;
        public async void TestApiAsync()
        {
            var botClient = new Telegram.Bot.TelegramBotClient(key);
            var me = await botClient.GetMeAsync();
            MessageBox.Show($"Hello! My name is {me.FirstName}");
        }


    }
}


