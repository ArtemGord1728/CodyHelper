namespace CodyHelper
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_Info = new System.Windows.Forms.Button();
            this.button_Book = new System.Windows.Forms.Button();
            this.button_Start = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.button_Info);
            this.panel1.Controls.Add(this.button_Book);
            this.panel1.Controls.Add(this.button_Start);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(649, 512);
            this.panel1.TabIndex = 0;
            // 
            // button_Info
            // 
            this.button_Info.BackColor = System.Drawing.Color.Transparent;
            this.button_Info.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Info.BackgroundImage")));
            this.button_Info.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Info.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Info.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Info.Location = new System.Drawing.Point(78, 384);
            this.button_Info.Name = "button_Info";
            this.button_Info.Size = new System.Drawing.Size(93, 82);
            this.button_Info.TabIndex = 3;
            this.toolTip3.SetToolTip(this.button_Info, "О программе");
            this.button_Info.UseVisualStyleBackColor = false;
            this.button_Info.Click += new System.EventHandler(this.button_Info_Click);
            // 
            // button_Book
            // 
            this.button_Book.BackColor = System.Drawing.Color.Transparent;
            this.button_Book.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Book.BackgroundImage")));
            this.button_Book.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Book.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Book.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Book.Location = new System.Drawing.Point(501, 385);
            this.button_Book.Name = "button_Book";
            this.button_Book.Size = new System.Drawing.Size(93, 81);
            this.button_Book.TabIndex = 2;
            this.toolTip2.SetToolTip(this.button_Book, "Справочник");
            this.button_Book.UseVisualStyleBackColor = false;
            this.button_Book.Click += new System.EventHandler(this.button_Book_Click);
            // 
            // button_Start
            // 
            this.button_Start.BackColor = System.Drawing.Color.Transparent;
            this.button_Start.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Start.BackgroundImage")));
            this.button_Start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Start.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Start.Location = new System.Drawing.Point(284, 276);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(93, 82);
            this.button_Start.TabIndex = 1;
            this.toolTip1.SetToolTip(this.button_Start, "Начать работу");
            this.button_Start.UseVisualStyleBackColor = false;
            this.button_Start.Click += new System.EventHandler(this.button_Start_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(190, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 97);
            this.label1.TabIndex = 0;
            this.label1.Text = "Вас приветствует программа Cody Helper";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(648, 514);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CodyHelper";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Info;
        private System.Windows.Forms.Button button_Book;
        private System.Windows.Forms.Button button_Start;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

