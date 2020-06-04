namespace main_title_editor
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
            this.childNameTextBox = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.backgroundTextBox = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.aTextBox = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.bTextBox = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.cTextBox = new System.Windows.Forms.TextBox();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.newChildNameTextBox = new System.Windows.Forms.TextBox();
            this.dTextBox = new System.Windows.Forms.TextBox();
            this.textBox23 = new System.Windows.Forms.TextBox();
            this.textBox24 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.openTab = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.newBackgroundTextBox = new System.Windows.Forms.TextBox();
            this.newATextBox = new System.Windows.Forms.TextBox();
            this.newBTextBox = new System.Windows.Forms.TextBox();
            this.newCTextBox = new System.Windows.Forms.TextBox();
            this.newDTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // childNameTextBox
            // 
            this.childNameTextBox.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.childNameTextBox.Location = new System.Drawing.Point(96, 41);
            this.childNameTextBox.Name = "childNameTextBox";
            this.childNameTextBox.ReadOnly = true;
            this.childNameTextBox.Size = new System.Drawing.Size(100, 21);
            this.childNameTextBox.TabIndex = 8;
            this.childNameTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.CausesValidation = false;
            this.textBox3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox3.Location = new System.Drawing.Point(15, 44);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(75, 14);
            this.textBox3.TabIndex = 2;
            this.textBox3.TabStop = false;
            this.textBox3.Text = "ChildName:";
            this.textBox3.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.CausesValidation = false;
            this.textBox4.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox4.Location = new System.Drawing.Point(202, 44);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(12, 14);
            this.textBox4.TabIndex = 2;
            this.textBox4.TabStop = false;
            this.textBox4.Text = "→";
            this.textBox4.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // backgroundTextBox
            // 
            this.backgroundTextBox.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.backgroundTextBox.Location = new System.Drawing.Point(96, 68);
            this.backgroundTextBox.Name = "backgroundTextBox";
            this.backgroundTextBox.ReadOnly = true;
            this.backgroundTextBox.Size = new System.Drawing.Size(100, 21);
            this.backgroundTextBox.TabIndex = 9;
            this.backgroundTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox7
            // 
            this.textBox7.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.CausesValidation = false;
            this.textBox7.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox7.Location = new System.Drawing.Point(15, 71);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(75, 14);
            this.textBox7.TabIndex = 2;
            this.textBox7.TabStop = false;
            this.textBox7.Text = "Background:";
            this.textBox7.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox8
            // 
            this.textBox8.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.CausesValidation = false;
            this.textBox8.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox8.Location = new System.Drawing.Point(202, 71);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(12, 14);
            this.textBox8.TabIndex = 2;
            this.textBox8.TabStop = false;
            this.textBox8.Text = "→";
            this.textBox8.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // aTextBox
            // 
            this.aTextBox.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.aTextBox.Location = new System.Drawing.Point(96, 95);
            this.aTextBox.Name = "aTextBox";
            this.aTextBox.ReadOnly = true;
            this.aTextBox.Size = new System.Drawing.Size(100, 21);
            this.aTextBox.TabIndex = 10;
            this.aTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox11
            // 
            this.textBox11.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.textBox11.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox11.CausesValidation = false;
            this.textBox11.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox11.Location = new System.Drawing.Point(15, 98);
            this.textBox11.Name = "textBox11";
            this.textBox11.ReadOnly = true;
            this.textBox11.Size = new System.Drawing.Size(75, 14);
            this.textBox11.TabIndex = 2;
            this.textBox11.TabStop = false;
            this.textBox11.Text = "x-position:";
            this.textBox11.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox12
            // 
            this.textBox12.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.textBox12.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox12.CausesValidation = false;
            this.textBox12.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox12.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox12.Location = new System.Drawing.Point(202, 98);
            this.textBox12.Name = "textBox12";
            this.textBox12.ReadOnly = true;
            this.textBox12.Size = new System.Drawing.Size(12, 14);
            this.textBox12.TabIndex = 2;
            this.textBox12.TabStop = false;
            this.textBox12.Text = "→";
            this.textBox12.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // bTextBox
            // 
            this.bTextBox.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.bTextBox.Location = new System.Drawing.Point(96, 122);
            this.bTextBox.Name = "bTextBox";
            this.bTextBox.ReadOnly = true;
            this.bTextBox.Size = new System.Drawing.Size(100, 21);
            this.bTextBox.TabIndex = 11;
            this.bTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox15
            // 
            this.textBox15.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.textBox15.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox15.CausesValidation = false;
            this.textBox15.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox15.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox15.Location = new System.Drawing.Point(15, 125);
            this.textBox15.Name = "textBox15";
            this.textBox15.ReadOnly = true;
            this.textBox15.Size = new System.Drawing.Size(75, 14);
            this.textBox15.TabIndex = 2;
            this.textBox15.TabStop = false;
            this.textBox15.Text = "y-position:";
            this.textBox15.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox16
            // 
            this.textBox16.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.textBox16.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox16.CausesValidation = false;
            this.textBox16.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox16.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox16.Location = new System.Drawing.Point(202, 125);
            this.textBox16.Name = "textBox16";
            this.textBox16.ReadOnly = true;
            this.textBox16.Size = new System.Drawing.Size(12, 14);
            this.textBox16.TabIndex = 2;
            this.textBox16.TabStop = false;
            this.textBox16.Text = "→";
            this.textBox16.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // cTextBox
            // 
            this.cTextBox.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.cTextBox.Location = new System.Drawing.Point(96, 149);
            this.cTextBox.Name = "cTextBox";
            this.cTextBox.ReadOnly = true;
            this.cTextBox.Size = new System.Drawing.Size(100, 21);
            this.cTextBox.TabIndex = 12;
            this.cTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox19
            // 
            this.textBox19.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.textBox19.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox19.CausesValidation = false;
            this.textBox19.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox19.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox19.Location = new System.Drawing.Point(15, 152);
            this.textBox19.Name = "textBox19";
            this.textBox19.ReadOnly = true;
            this.textBox19.Size = new System.Drawing.Size(75, 14);
            this.textBox19.TabIndex = 2;
            this.textBox19.TabStop = false;
            this.textBox19.Text = "x-Scale:";
            this.textBox19.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox20
            // 
            this.textBox20.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.textBox20.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox20.CausesValidation = false;
            this.textBox20.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox20.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox20.Location = new System.Drawing.Point(202, 152);
            this.textBox20.Name = "textBox20";
            this.textBox20.ReadOnly = true;
            this.textBox20.Size = new System.Drawing.Size(12, 14);
            this.textBox20.TabIndex = 2;
            this.textBox20.TabStop = false;
            this.textBox20.Text = "→";
            this.textBox20.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // newChildNameTextBox
            // 
            this.newChildNameTextBox.Location = new System.Drawing.Point(220, 41);
            this.newChildNameTextBox.MaxLength = 8;
            this.newChildNameTextBox.Name = "newChildNameTextBox";
            this.newChildNameTextBox.Size = new System.Drawing.Size(100, 21);
            this.newChildNameTextBox.TabIndex = 1;
            this.newChildNameTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dTextBox
            // 
            this.dTextBox.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dTextBox.Location = new System.Drawing.Point(96, 176);
            this.dTextBox.Name = "dTextBox";
            this.dTextBox.ReadOnly = true;
            this.dTextBox.Size = new System.Drawing.Size(100, 21);
            this.dTextBox.TabIndex = 13;
            this.dTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox23
            // 
            this.textBox23.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.textBox23.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox23.CausesValidation = false;
            this.textBox23.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox23.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox23.Location = new System.Drawing.Point(15, 179);
            this.textBox23.Name = "textBox23";
            this.textBox23.ReadOnly = true;
            this.textBox23.Size = new System.Drawing.Size(75, 14);
            this.textBox23.TabIndex = 2;
            this.textBox23.TabStop = false;
            this.textBox23.Text = "y-Scale:";
            this.textBox23.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox24
            // 
            this.textBox24.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.textBox24.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox24.CausesValidation = false;
            this.textBox24.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox24.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox24.Location = new System.Drawing.Point(202, 179);
            this.textBox24.Name = "textBox24";
            this.textBox24.ReadOnly = true;
            this.textBox24.Size = new System.Drawing.Size(12, 14);
            this.textBox24.TabIndex = 2;
            this.textBox24.TabStop = false;
            this.textBox24.Text = "→";
            this.textBox24.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(245, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Apply";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openTab
            // 
            this.openTab.CheckOnClick = true;
            this.openTab.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileToolStripMenu,
            this.exitToolStripMenuItem});
            this.openTab.Name = "openTab";
            this.openTab.Size = new System.Drawing.Size(48, 20);
            this.openTab.Text = "Open";
            this.openTab.Click += new System.EventHandler(this.openTab_Click);
            // 
            // openFileToolStripMenu
            // 
            this.openFileToolStripMenu.Name = "openFileToolStripMenu";
            this.openFileToolStripMenu.Size = new System.Drawing.Size(163, 22);
            this.openFileToolStripMenu.Text = "Open .mvd file...";
            this.openFileToolStripMenu.Click += new System.EventHandler(this.openFileToolStripMenu_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openTab});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(336, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // newBackgroundTextBox
            // 
            this.newBackgroundTextBox.Location = new System.Drawing.Point(220, 68);
            this.newBackgroundTextBox.MaxLength = 32;
            this.newBackgroundTextBox.Name = "newBackgroundTextBox";
            this.newBackgroundTextBox.Size = new System.Drawing.Size(100, 21);
            this.newBackgroundTextBox.TabIndex = 2;
            this.newBackgroundTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // newATextBox
            // 
            this.newATextBox.Location = new System.Drawing.Point(220, 95);
            this.newATextBox.Name = "newATextBox";
            this.newATextBox.Size = new System.Drawing.Size(100, 21);
            this.newATextBox.TabIndex = 3;
            this.newATextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // newBTextBox
            // 
            this.newBTextBox.Location = new System.Drawing.Point(220, 122);
            this.newBTextBox.Name = "newBTextBox";
            this.newBTextBox.Size = new System.Drawing.Size(100, 21);
            this.newBTextBox.TabIndex = 4;
            this.newBTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // newCTextBox
            // 
            this.newCTextBox.Location = new System.Drawing.Point(220, 149);
            this.newCTextBox.Name = "newCTextBox";
            this.newCTextBox.Size = new System.Drawing.Size(100, 21);
            this.newCTextBox.TabIndex = 5;
            this.newCTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // newDTextBox
            // 
            this.newDTextBox.Location = new System.Drawing.Point(220, 176);
            this.newDTextBox.Name = "newDTextBox";
            this.newDTextBox.Size = new System.Drawing.Size(100, 21);
            this.newDTextBox.TabIndex = 6;
            this.newDTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 245);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox24);
            this.Controls.Add(this.textBox20);
            this.Controls.Add(this.textBox16);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox23);
            this.Controls.Add(this.textBox19);
            this.Controls.Add(this.textBox15);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.dTextBox);
            this.Controls.Add(this.newDTextBox);
            this.Controls.Add(this.newCTextBox);
            this.Controls.Add(this.newBTextBox);
            this.Controls.Add(this.newATextBox);
            this.Controls.Add(this.newBackgroundTextBox);
            this.Controls.Add(this.newChildNameTextBox);
            this.Controls.Add(this.cTextBox);
            this.Controls.Add(this.bTextBox);
            this.Controls.Add(this.aTextBox);
            this.Controls.Add(this.backgroundTextBox);
            this.Controls.Add(this.childNameTextBox);
            this.Controls.Add(this.menuStrip2);
            this.Name = "Form1";
            this.Text = "DCG Main Title Editor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox childNameTextBox;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox backgroundTextBox;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox aTextBox;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox bTextBox;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.TextBox cTextBox;
        private System.Windows.Forms.TextBox textBox19;
        private System.Windows.Forms.TextBox textBox20;
        private System.Windows.Forms.TextBox newChildNameTextBox;
        private System.Windows.Forms.TextBox dTextBox;
        private System.Windows.Forms.TextBox textBox23;
        private System.Windows.Forms.TextBox textBox24;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem openTab;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.TextBox newBackgroundTextBox;
        private System.Windows.Forms.TextBox newATextBox;
        private System.Windows.Forms.TextBox newBTextBox;
        private System.Windows.Forms.TextBox newCTextBox;
        private System.Windows.Forms.TextBox newDTextBox;
    }
}

