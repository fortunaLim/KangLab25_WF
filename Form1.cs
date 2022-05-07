using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace KangLab25_WF
{
    public partial class Form1 : Form
    {
        WATUTF8 watUTF8 = new WATUTF8();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)  //시리얼포트가 열려 있지 않으면
            {
                serialPort1.PortName = "COM1";  //COM1 포트 설정
                serialPort1.BaudRate = 115200;  //보레이트 설정
                serialPort1.DataBits = 8;
                serialPort1.StopBits = StopBits.One;
                serialPort1.Parity = Parity.None;
                serialPort1.DataReceived += new SerialDataReceivedEventHandler(serialPort1_DataReceived); //이것이 꼭 필요하다

                //serialPort1.Open();  //시리얼포트 열기

                SetOrderListView();

                TotalPrice.Text = price.ToString();
            }

        }


        private void SetOrderListView()
        {
            OrderListView.Columns.Add("NO", 100, HorizontalAlignment.Center);
            OrderListView.Columns.Add("품명", 400, HorizontalAlignment.Center);
            OrderListView.Columns.Add("단가", 180, HorizontalAlignment.Center);
            OrderListView.Columns.Add("수량", 180, HorizontalAlignment.Center);
            OrderListView.Columns.Add("가격", 180, HorizontalAlignment.Center);

            //이거 없애면 항목 이름 사라짐
            OrderListView.View = View.Details;

            OrderListView.FullRowSelect = true;
            OrderListView.GridLines = true;
            OrderListView.EndUpdate();
        }

        private void TotalPriceCal()
        {
            price = 0;
            if(OrderListView.Items.Count == 0)
            {
                price = 0;
                TotalPrice.Text = price.ToString();
                return;
            }
            for (int i = 0; i < OrderListView.Items.Count; i++)
            {
                price += int.Parse(OrderListView.Items[i].SubItems[4].Text);
            }
            TotalPrice.Text = price.ToString();
        }

        private void AddListView(MenuInfo info)
        {

            //int count = int.Parse(OrderListView.Items[index].SubItems[1].Text) + 1;
            //int price = int.Parse(OrderListView.Items[index].SubItems[2].Text);

            /*
            OrderListView.Items[0].SubItems[1].Text = "1";
            OrderListView.Items[0].SubItems[2].Text = "oreo";
            OrderListView.Items[0].SubItems[3].Text = "1개";
            OrderListView.Items[0].SubItems[4].Text = "2000원";

            
            ListViewItem item1 = new ListViewItem("item1", 0);
            // Place a check mark next to the item.
            item1.Checked = true;
            item1.SubItems.Add("1");
            item1.SubItems.Add("오레오");
            item1.SubItems.Add("1개");
            item1.SubItems.Add("2000원");
            */


            

            info.number++;

            p_Index++;

            ListViewItem listViewItem1 = new ListViewItem(new string[] { p_Index.ToString(), info.name, info.price.ToString(), info.number.ToString(), info.price.ToString() });
            this.OrderListView.Items.AddRange(new ListViewItem[] { listViewItem1 });

        }
        private bool is_item(MenuInfo info)
        {
            if(info == null) 
            {             
                MessageBox.Show("오류! 관리자에게 문의해주세요");
                return false;
            }
            
            return true;
        }

        private void BTN_PAY_Click(object sender, EventArgs e)
        {
            
            MenuInfo aa = Program.menuList.Find(x => x.name == "오레오");

            if (is_item(aa) == false)
                return;

            AddListView(aa);
            //TotalPriceCal();
        }


        private void BTN_CANCEL_Click(object sender, EventArgs e)
        {
            for (int i = 0; i != Program.menuList.Count; i++)
            {
                Program.menuList[i].number = 0;
            }
            
            OrderListView.Items.Clear();
            p_Index = 0;
            TotalPriceCal();
        }

        private void BTN_P_Click(object sender, EventArgs e)
        {
            if (OrderListView.SelectedItems.Count == 0)
                return;

            if (OrderListView.SelectedItems.Count != 0)
            {
                int SelectRow = OrderListView.SelectedItems[0].Index;
                int count = int.Parse(OrderListView.Items[SelectRow].SubItems[3].Text);
                int SinglePrice = Program.menuList.Find(x => x.name == OrderListView.Items[SelectRow].SubItems[1].Text).price;
                count++;
                OrderListView.Items[SelectRow].SubItems[3].Text = count.ToString();
                OrderListView.Items[SelectRow].SubItems[4].Text = ((float)(SinglePrice * count)).ToString();
            }
            TotalPriceCal();
        }

        private void BTN_M_Click(object sender, EventArgs e)
        {
            if (OrderListView.SelectedItems.Count == 0)
                return;

            if (OrderListView.SelectedItems.Count != 0)
            {
                int SelectRow = OrderListView.SelectedItems[0].Index;
                int count = int.Parse(OrderListView.Items[SelectRow].SubItems[3].Text);
                int SinglePrice = Program.menuList.Find(x => x.name == OrderListView.Items[SelectRow].SubItems[1].Text).price;
                count--;
                if (count != 0)
                {
                    OrderListView.Items[SelectRow].SubItems[3].Text = count.ToString();
                    OrderListView.Items[SelectRow].SubItems[4].Text = ((float)(SinglePrice * count)).ToString();
                }
                else
                {
                    OrderListView.Items.RemoveAt(SelectRow);
                }
            }
            TotalPriceCal();
        }

        private void BTN_X_Click(object sender, EventArgs e)
        {
            int SelectRow = OrderListView.SelectedItems[0].Index;
            OrderListView.Items.RemoveAt(SelectRow);
            int j = 1;
            for (int i = 0; i < OrderListView.Items.Count; i++, j++)
            {
                OrderListView.Items[i].SubItems[0].Text = j.ToString();
            }
            TotalPriceCal();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            this.Invoke(new EventHandler(MySerialReceived));
        }

        private void MySerialReceived(object s, EventArgs e)  //여기에서 수신 데이타를 사용자의 용도에 따라 처리한다.
        {
            try
            {
                int iRecSize = serialPort1.BytesToRead; // 수신된 데이터 갯수

                if (iRecSize != 0) // 수신된 데이터의 수가 0이 아닐때만 처리하자
                {
                    //          Console.Write("rx:" + iRecSize.ToString());

                    byte[] buff = new byte[iRecSize];
                    try
                    {
                        serialPort1.Read(buff, 0, iRecSize);

                        string strTemp = this.watUTF8.AddBytes(buff.ToList()).Replace("\r", "").Replace("\n", Environment.NewLine);
                        //textBox1.AppendText(strTemp);

                        /* MenuInfo a;
                         a = Program.menuList.Find(x => x.name == strTemp);
                         AddListView(a);*/
                    }
                    catch { }
                }
            }
            catch (System.Exception)
            {
            }
        }

        private void 상품설정ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 newform2 = new Form2();
            newform2.ShowDialog();
        }
    }

}