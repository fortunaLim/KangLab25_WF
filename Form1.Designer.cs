
namespace KangLab25_WF
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.TotalPrice = new System.Windows.Forms.Label();
            this.BTN_X = new System.Windows.Forms.Button();
            this.BTN_M = new System.Windows.Forms.Button();
            this.BTN_P = new System.Windows.Forms.Button();
            this.OrderListView = new System.Windows.Forms.ListView();
            this.BTN_PAY = new System.Windows.Forms.Button();
            this.BTN_CANCEL = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.관리자ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.상품설정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.TotalPrice);
            this.panel1.Controls.Add(this.BTN_X);
            this.panel1.Controls.Add(this.BTN_M);
            this.panel1.Controls.Add(this.BTN_P);
            this.panel1.Controls.Add(this.OrderListView);
            this.panel1.Controls.Add(this.BTN_PAY);
            this.panel1.Controls.Add(this.BTN_CANCEL);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1920, 1080);
            this.panel1.TabIndex = 0;
            // 
            // TotalPrice
            // 
            this.TotalPrice.AutoSize = true;
            this.TotalPrice.BackColor = System.Drawing.Color.Transparent;
            this.TotalPrice.Font = new System.Drawing.Font("굴림", 35F);
            this.TotalPrice.Location = new System.Drawing.Point(1387, 507);
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.Size = new System.Drawing.Size(36, 47);
            this.TotalPrice.TabIndex = 7;
            this.TotalPrice.Text = " ";
            // 
            // BTN_X
            // 
            this.BTN_X.FlatAppearance.BorderSize = 0;
            this.BTN_X.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_X.Font = new System.Drawing.Font("굴림", 22F);
            this.BTN_X.Location = new System.Drawing.Point(1128, 661);
            this.BTN_X.Name = "BTN_X";
            this.BTN_X.Size = new System.Drawing.Size(75, 75);
            this.BTN_X.TabIndex = 6;
            this.BTN_X.Text = "X";
            this.BTN_X.UseVisualStyleBackColor = false;
            this.BTN_X.Click += new System.EventHandler(this.BTN_X_Click);
            // 
            // BTN_M
            // 
            this.BTN_M.FlatAppearance.BorderSize = 0;
            this.BTN_M.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_M.Font = new System.Drawing.Font("굴림", 25F);
            this.BTN_M.Location = new System.Drawing.Point(1128, 580);
            this.BTN_M.Name = "BTN_M";
            this.BTN_M.Size = new System.Drawing.Size(75, 75);
            this.BTN_M.TabIndex = 5;
            this.BTN_M.Text = "-";
            this.BTN_M.UseVisualStyleBackColor = false;
            this.BTN_M.Click += new System.EventHandler(this.BTN_M_Click);
            // 
            // BTN_P
            // 
            this.BTN_P.FlatAppearance.BorderSize = 0;
            this.BTN_P.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_P.Font = new System.Drawing.Font("굴림", 25F);
            this.BTN_P.Location = new System.Drawing.Point(1128, 498);
            this.BTN_P.Name = "BTN_P";
            this.BTN_P.Size = new System.Drawing.Size(75, 75);
            this.BTN_P.TabIndex = 4;
            this.BTN_P.Text = "+";
            this.BTN_P.UseVisualStyleBackColor = true;
            this.BTN_P.Click += new System.EventHandler(this.BTN_P_Click);
            // 
            // OrderListView
            // 
            this.OrderListView.Font = new System.Drawing.Font("굴림", 25F);
            this.OrderListView.HideSelection = false;
            this.OrderListView.Location = new System.Drawing.Point(72, 224);
            this.OrderListView.Name = "OrderListView";
            this.OrderListView.Size = new System.Drawing.Size(1052, 804);
            this.OrderListView.TabIndex = 3;
            this.OrderListView.UseCompatibleStateImageBehavior = false;
            // 
            // BTN_PAY
            // 
            this.BTN_PAY.BackColor = System.Drawing.Color.Transparent;
            this.BTN_PAY.FlatAppearance.BorderSize = 0;
            this.BTN_PAY.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BTN_PAY.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BTN_PAY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_PAY.ForeColor = System.Drawing.Color.Transparent;
            this.BTN_PAY.Location = new System.Drawing.Point(1264, 935);
            this.BTN_PAY.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTN_PAY.Name = "BTN_PAY";
            this.BTN_PAY.Size = new System.Drawing.Size(291, 94);
            this.BTN_PAY.TabIndex = 2;
            this.BTN_PAY.UseVisualStyleBackColor = false;
            this.BTN_PAY.Click += new System.EventHandler(this.BTN_PAY_Click);
            // 
            // BTN_CANCEL
            // 
            this.BTN_CANCEL.BackColor = System.Drawing.Color.Transparent;
            this.BTN_CANCEL.FlatAppearance.BorderSize = 0;
            this.BTN_CANCEL.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BTN_CANCEL.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BTN_CANCEL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_CANCEL.ForeColor = System.Drawing.Color.Transparent;
            this.BTN_CANCEL.Location = new System.Drawing.Point(1575, 934);
            this.BTN_CANCEL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTN_CANCEL.Name = "BTN_CANCEL";
            this.BTN_CANCEL.Size = new System.Drawing.Size(291, 94);
            this.BTN_CANCEL.TabIndex = 1;
            this.BTN_CANCEL.UseVisualStyleBackColor = false;
            this.BTN_CANCEL.Click += new System.EventHandler(this.BTN_CANCEL_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 115200;
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.관리자ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1920, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 관리자ToolStripMenuItem
            // 
            this.관리자ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.상품설정ToolStripMenuItem});
            this.관리자ToolStripMenuItem.Name = "관리자ToolStripMenuItem";
            this.관리자ToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.관리자ToolStripMenuItem.Text = "관리자";
            // 
            // 상품설정ToolStripMenuItem
            // 
            this.상품설정ToolStripMenuItem.Name = "상품설정ToolStripMenuItem";
            this.상품설정ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.상품설정ToolStripMenuItem.Text = "상품 설정";
            this.상품설정ToolStripMenuItem.Click += new System.EventHandler(this.상품설정ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button BTN_CANCEL;
        public System.Windows.Forms.Button BTN_PAY;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ListView OrderListView;
        private System.Windows.Forms.Button BTN_M;
        private System.Windows.Forms.Button BTN_P;
        private System.Windows.Forms.Button BTN_X;

        public int p_Index = 0;
        public int price = 0;
        private System.Windows.Forms.Label TotalPrice;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 관리자ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 상품설정ToolStripMenuItem;
    }
}

