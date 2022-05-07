
namespace KangLab25_WF
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MenuSettingView = new System.Windows.Forms.ListView();
            this.name_txtbox = new System.Windows.Forms.TextBox();
            this.name_label = new System.Windows.Forms.Label();
            this.change_btn = new System.Windows.Forms.Button();
            this.price_txtbox = new System.Windows.Forms.TextBox();
            this.discount_txtbox = new System.Windows.Forms.TextBox();
            this.price_label = new System.Windows.Forms.Label();
            this.discount_label = new System.Windows.Forms.Label();
            this.additem_btn = new System.Windows.Forms.Button();
            this.eraseitem_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MenuSettingView
            // 
            this.MenuSettingView.HideSelection = false;
            this.MenuSettingView.Location = new System.Drawing.Point(12, 12);
            this.MenuSettingView.MultiSelect = false;
            this.MenuSettingView.Name = "MenuSettingView";
            this.MenuSettingView.Size = new System.Drawing.Size(684, 379);
            this.MenuSettingView.TabIndex = 0;
            this.MenuSettingView.UseCompatibleStateImageBehavior = false;
            this.MenuSettingView.SelectedIndexChanged += new System.EventHandler(this.MenuSettingView_SelectedIndexChanged);
            // 
            // name_txtbox
            // 
            this.name_txtbox.Location = new System.Drawing.Point(731, 47);
            this.name_txtbox.Name = "name_txtbox";
            this.name_txtbox.Size = new System.Drawing.Size(131, 21);
            this.name_txtbox.TabIndex = 1;
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Location = new System.Drawing.Point(729, 23);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(29, 12);
            this.name_label.TabIndex = 2;
            this.name_label.Text = "품명";
            // 
            // change_btn
            // 
            this.change_btn.Location = new System.Drawing.Point(908, 262);
            this.change_btn.Name = "change_btn";
            this.change_btn.Size = new System.Drawing.Size(75, 23);
            this.change_btn.TabIndex = 3;
            this.change_btn.Text = "변경";
            this.change_btn.UseVisualStyleBackColor = true;
            this.change_btn.Click += new System.EventHandler(this.change_btn_Click);
            // 
            // price_txtbox
            // 
            this.price_txtbox.Location = new System.Drawing.Point(731, 165);
            this.price_txtbox.Name = "price_txtbox";
            this.price_txtbox.Size = new System.Drawing.Size(100, 21);
            this.price_txtbox.TabIndex = 4;
            // 
            // discount_txtbox
            // 
            this.discount_txtbox.Location = new System.Drawing.Point(731, 262);
            this.discount_txtbox.Name = "discount_txtbox";
            this.discount_txtbox.Size = new System.Drawing.Size(100, 21);
            this.discount_txtbox.TabIndex = 5;
            // 
            // price_label
            // 
            this.price_label.AutoSize = true;
            this.price_label.Location = new System.Drawing.Point(729, 131);
            this.price_label.Name = "price_label";
            this.price_label.Size = new System.Drawing.Size(29, 12);
            this.price_label.TabIndex = 6;
            this.price_label.Text = "가격";
            // 
            // discount_label
            // 
            this.discount_label.AutoSize = true;
            this.discount_label.Location = new System.Drawing.Point(729, 237);
            this.discount_label.Name = "discount_label";
            this.discount_label.Size = new System.Drawing.Size(29, 12);
            this.discount_label.TabIndex = 7;
            this.discount_label.Text = "할인";
            // 
            // additem_btn
            // 
            this.additem_btn.Location = new System.Drawing.Point(908, 322);
            this.additem_btn.Name = "additem_btn";
            this.additem_btn.Size = new System.Drawing.Size(75, 23);
            this.additem_btn.TabIndex = 8;
            this.additem_btn.Text = "추가";
            this.additem_btn.UseVisualStyleBackColor = true;
            this.additem_btn.Click += new System.EventHandler(this.additem_btn_Click);
            // 
            // eraseitem_btn
            // 
            this.eraseitem_btn.Location = new System.Drawing.Point(908, 367);
            this.eraseitem_btn.Name = "eraseitem_btn";
            this.eraseitem_btn.Size = new System.Drawing.Size(75, 23);
            this.eraseitem_btn.TabIndex = 9;
            this.eraseitem_btn.Text = "삭제";
            this.eraseitem_btn.UseVisualStyleBackColor = true;
            this.eraseitem_btn.Click += new System.EventHandler(this.eraseitem_btn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 545);
            this.Controls.Add(this.eraseitem_btn);
            this.Controls.Add(this.additem_btn);
            this.Controls.Add(this.discount_label);
            this.Controls.Add(this.price_label);
            this.Controls.Add(this.discount_txtbox);
            this.Controls.Add(this.price_txtbox);
            this.Controls.Add(this.change_btn);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.name_txtbox);
            this.Controls.Add(this.MenuSettingView);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView MenuSettingView;
        private System.Windows.Forms.TextBox name_txtbox;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Button change_btn;
        private System.Windows.Forms.TextBox price_txtbox;
        private System.Windows.Forms.TextBox discount_txtbox;
        private System.Windows.Forms.Label price_label;
        private System.Windows.Forms.Label discount_label;
        private System.Windows.Forms.Button additem_btn;

        public int AddRow = Program.menuList.Count;
        private System.Windows.Forms.Button eraseitem_btn;
    }
}