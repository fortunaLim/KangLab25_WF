using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KangLab25_WF
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            
            MenuSettingView.Columns.Add("품명", 200, HorizontalAlignment.Center);            
            MenuSettingView.Columns.Add("가격", 180, HorizontalAlignment.Center);
            MenuSettingView.Columns.Add("할인", 180, HorizontalAlignment.Center);

            //이거 없애면 항목 이름 사라짐
            MenuSettingView.View = View.Details;

            MenuSettingView.FullRowSelect = true;
            MenuSettingView.GridLines = true;


            MenuSettingView.EndUpdate();

            //int discount = 0;

            for (int i = 0; i != Program.menuList.Count; i++)
            {
                ListViewItem listViewItem1 = new ListViewItem(new string[] { Program.menuList[i].name, Program.menuList[i].price.ToString(), Program.menuList[i].discount.ToString()});
                this.MenuSettingView.Items.AddRange(new ListViewItem[] { listViewItem1 });
            }
            
        }


        private void change_btn_Click(object sender, EventArgs e)
        {
            if (MenuSettingView.SelectedItems.Count == 0)
                return;

            if (MenuSettingView.SelectedItems.Count != 0)
            {
                int SelectRow = MenuSettingView.SelectedItems[0].Index;
              
                //int SinglePrice = Program.menuList.Find(x => x.name == MenuSettingView.Items[SelectRow].SubItems[1].Text).price;

                Program.menuList[SelectRow].name = name_txtbox.Text;
                Program.menuList[SelectRow].price = int.Parse(price_txtbox.Text);
                Program.menuList[SelectRow].discount = int.Parse(discount_txtbox.Text);

                MenuSettingView.Items.Clear();
                for (int i = 0; i != Program.menuList.Count; i++)
                {
                    ListViewItem listViewItem1 = new ListViewItem(new string[] { Program.menuList[i].name, Program.menuList[i].price.ToString(), Program.menuList[i].discount.ToString()});
                    this.MenuSettingView.Items.AddRange(new ListViewItem[] { listViewItem1 });
                }
            }
        }

        private void MenuSettingView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MenuSettingView.SelectedItems.Count == 0)
                return;

            if (MenuSettingView.SelectedItems.Count != 0)
            {
                int SelectRow = MenuSettingView.SelectedItems[0].Index;
 
                name_txtbox.Text = Program.menuList[SelectRow].name;
                price_txtbox.Text = (Program.menuList[SelectRow].price).ToString();
                discount_txtbox.Text = (Program.menuList[SelectRow].discount).ToString();
            }
        }

        private void additem_btn_Click(object sender, EventArgs e)
        {            
            Program.menuList.Add(new MenuInfo{ name = name_txtbox.Text, price = int.Parse(price_txtbox.Text), discount = int.Parse(discount_txtbox.Text)});
            
            MenuSettingView.Items.Clear();
            for (int i = 0; i != Program.menuList.Count; i++)
            {
                ListViewItem listViewItem1 = new ListViewItem(new string[] { Program.menuList[i].name, Program.menuList[i].price.ToString(), Program.menuList[i].discount.ToString() });
                this.MenuSettingView.Items.AddRange(new ListViewItem[] { listViewItem1 });
            }      
        }

        private void eraseitem_btn_Click(object sender, EventArgs e)
        {
            int SelectRow = MenuSettingView.SelectedItems[0].Index;

            Program.menuList.RemoveAt(SelectRow);

            MenuSettingView.Items.Clear();
            for (int i = 0; i != Program.menuList.Count; i++)
            {
                ListViewItem listViewItem1 = new ListViewItem(new string[] { Program.menuList[i].name, Program.menuList[i].price.ToString(), Program.menuList[i].discount.ToString() });
                this.MenuSettingView.Items.AddRange(new ListViewItem[] { listViewItem1 });
            }
        }
    }
}
