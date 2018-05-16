using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Intro
{

    public partial class Form1 : Form
    {
        //extern public Data data1;
        Form2 form2 = new Form2();

        public delegate void BuyDelegate();//641, "sas");
        public event BuyDelegate pressedYes;
        

        public Form1()
        {
            InitializeComponent();
            Global.data1.dataMain();
            
            InitWeaponTable(dataGridView1,Global.data1.PistolsList);
            InitWeaponTable(dataGridView2, Global.data1.SmgsList);
            InitWeaponTable(dataGridView3, Global.data1.RiflesList);
            pressedYes += sas;
            form2.loggedIn += loggedInText;
            //System.Threading.Thread.Sleep(5000);
            /*while (Global.login1.isLoggedIn == false)
            {
                System.Threading.Thread.Sleep(5000);//Timer.Start()//SpinWait.SpinUntil()//label2.Text = "You logged in as {Global.login1.currentUser}."; Thread.Sleep - 
            }
            label2.Text = "You logged in as {Global.login1.currentUser}.";*/
            
        }

        public void loggedInText()
        {
            label2.Text = ("You logged in as "+Global.login1.currentUser+".");
            Account account1 = new Account();
            account1.accountMain();
            InitWeaponTable(dataGridView4, account1.ownedList);
            button1.Show();
        }

        public void InitWeaponTable(DataGridView targetGridView, List<string[]> targetList)
        {
            //Data data1 = new Data();
            //Global.data1.dataMain();
                            //List<string> raz = new List<string>();
            //string[] countries = { "Бразилия", "Аргентина", "Чили", "Уругвай", "Колумбия" };
            //raz.AddRange(countries);
            //listBox1.Items.AddRange(data1.PistolsList.ToArray());
            //listBox1.Items.Add(data1.LoginsList[1]);//(Convert.ChangeType(data1.LoginsList, typeof (object[])));



            var column1 = new DataGridViewColumn();
            column1.HeaderText = "ID"; //текст в шапке
            column1.Width = 100; //ширина колонки
            column1.ReadOnly = true; //значение в этой колонке нельзя править
            column1.Name = "id"; //текстовое имя колонки, его можно использовать вместо обращений по индексу
            column1.Frozen = true; //флаг, что данная колонка всегда отображается на своем месте
            column1.CellTemplate = new DataGridViewTextBoxCell(); //тип нашей колонки

            var column2 = new DataGridViewColumn();
            column2.HeaderText = "Name";
            column2.Name = "name";
            column2.CellTemplate = new DataGridViewTextBoxCell();

            var column3 = new DataGridViewColumn();
            column3.HeaderText = "Productioner";
            column3.Name = "whomadeit";
            column3.CellTemplate = new DataGridViewTextBoxCell();
            //column3.AutoSizeMode.

            var column4 = new DataGridViewColumn();
            column4.HeaderText = "Caliber";
            column4.Name = "caliber";
            column4.CellTemplate = new DataGridViewTextBoxCell();

            var column5 = new DataGridViewColumn();
            column5.HeaderText = "Country";
            column5.Name = "country";
            column5.CellTemplate = new DataGridViewTextBoxCell();

            var column6 = new DataGridViewColumn();
            column6.HeaderText = "Year";
            column6.Name = "year";
            column6.CellTemplate = new DataGridViewTextBoxCell();
            
            var column7 = new DataGridViewColumn();
            column7.HeaderText = "Price";
            column7.Name = "price";
            column7.CellTemplate = new DataGridViewTextBoxCell();

            //dataGridView1.CanSelect = false;

            targetGridView.Columns.Add(column1);
            targetGridView.Columns.Add(column2);
            targetGridView.Columns.Add(column3);
            targetGridView.Columns.Add(column4);
            targetGridView.Columns.Add(column5);
            targetGridView.Columns.Add(column6);
            targetGridView.Columns.Add(column7);

            targetGridView.AllowUserToAddRows = false; //запрешаем пользователю самому добавлять строки
            targetGridView.MultiSelect = false;

            for (int i = 0; i < targetList.Count; ++i)
                {
                //Добавляем строку, указывая значения колонок поочереди слева направо
                    targetGridView.Rows.Add(targetList[i]);
                }
            
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //LoginLogout login1 = new LoginLogout();
            /*if (Global.login1.idUser == -1) 
            { 
                label1.Text = "You not logged in, you can't buy things";
                return;
            }*/
            //label1.Text = "123123123123";
            //Data data1 = new Data();
            //Global.data1.dataMain();
            preBuy();
            

        }

       
        

        public void preBuy()
        {
            //int currentID = Convert.ToInt32((Convert.ToString(dataGridView1.SelectedRows[0]).Substring(24, (Convert.ToString(dataGridView1.SelectedRows[0])).Length - 26)), 10);
            //int price = Convert.ToInt32(Global.data1.PistolsList[currentID][6], 10);
            int c = tabControl1.SelectedIndex;
            int currentID=0;
            int price=0;
            switch (c)
            {
                case 1:
                    currentID = Convert.ToInt32((Convert.ToString(dataGridView1.SelectedRows[0]).Substring(24, (Convert.ToString(dataGridView1.SelectedRows[0])).Length - 26)), 10);
                    price = Convert.ToInt32(Global.data1.PistolsList[currentID][6], 10);
                    return;
                case 2:
                    currentID = Convert.ToInt32((Convert.ToString(dataGridView2.SelectedRows[0]).Substring(24, (Convert.ToString(dataGridView1.SelectedRows[0])).Length - 26)), 10);
                    price = Convert.ToInt32(Global.data1.SmgsList[currentID][6], 10);
                    return;
                case 3:
                    currentID = Convert.ToInt32((Convert.ToString(dataGridView3.SelectedRows[0]).Substring(24, (Convert.ToString(dataGridView1.SelectedRows[0])).Length - 26)), 10);
                    price = Convert.ToInt32(Global.data1.RiflesList[currentID][6], 10);
                    return;
                default:
                    break;
            }
            if (Convert.ToInt32(Global.data1.MoneysList[Global.login1.idUser]) - price >= 0)
            {
                button1.Hide();
                button3.Show();
                button4.Show();
                label1.Text = ("This will cost you " + (Global.data1.PistolsList[currentID][6]) + ". Proceed?");

                //string cat = "A";
                //string item = ";" + cat + currentID;
                //sas(price, item);
                //Global.data1.Buing(/*int*/Global.login1.idUser, /*string*/ item, price);
            }
            else
            {
                label1.Text = "You don't have enough money.";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            form2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           pressedYes();
        }

        void sas()//int price, string item)
        {
            int c = tabControl1.SelectedIndex;
            int currentID=1;
            int price=0;
            switch (c)
            {
                case 1:
                    currentID = Convert.ToInt32((Convert.ToString(dataGridView1.SelectedRows[0]).Substring(24, (Convert.ToString(dataGridView1.SelectedRows[0])).Length - 26)), 10);
                    price = Convert.ToInt32(Global.data1.PistolsList[currentID][6], 10);
                    break;
                case 2:
                    currentID = Convert.ToInt32((Convert.ToString(dataGridView2.SelectedRows[0]).Substring(24, (Convert.ToString(dataGridView1.SelectedRows[0])).Length - 26)), 10);
                    price = Convert.ToInt32(Global.data1.SmgsList[currentID][6], 10);
                    break;
                case 3:
                    currentID = Convert.ToInt32((Convert.ToString(dataGridView3.SelectedRows[0]).Substring(24, (Convert.ToString(dataGridView1.SelectedRows[0])).Length - 26)), 10);
                    price = Convert.ToInt32(Global.data1.RiflesList[currentID][6], 10);
                    break;

            }
                

            //string d = "dataGridView" + Convert.ToString(c);
            //var z = "dataGridView" + c;
            //DataGridView b = d as DataGridView;
            //z = new DataGridView.Name();

            //Type type = Type.GetType(z);
            

            //int newVar = (int)this.GetType().GetField("myVar").GetValue(this);

            //int currentID = Convert.ToInt32((Convert.ToString(dataGridView1.SelectedRows[0]).Substring(24, (Convert.ToString(dataGridView1.SelectedRows[0])).Length - 26)), 10);
            //int price = Convert.ToInt32(Global.data1.PistolsList[currentID][6], 10);
            string cat = "A";
            string item = ";" + cat + currentID;
            Global.data1.Buing(/*int*/Global.login1.idUser, /*string*/ item, price);
            label1.Text = "Done!";
            button1.Show();
            button3.Hide();
            button4.Hide();

            //int hui = preBuy.price;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.Show();
            button3.Hide();
            button4.Hide();
            label1.Text = "";
        }


    }
}
