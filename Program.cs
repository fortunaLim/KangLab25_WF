using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KangLab25_WF
{
    static class Program
    {
        //모든 메뉴 정보를 담은 리스트
        public static List<MenuInfo> menuList = new List<MenuInfo>()
        {
            new MenuInfo() { name = "오레오", price = 10000},
            new MenuInfo() { name = "꼬깔콘", price = 10000},
            new MenuInfo() { name = "펩시", price = 1500},
            new MenuInfo() { name = "코카콜라", price = 2000}

        };



        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

        }
    }
}