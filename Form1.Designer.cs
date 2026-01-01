namespace C__Winform_报警实时监控
{
    partial class form
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.通信参数 = new System.Windows.Forms.GroupBox();
            this.button_disobserve = new System.Windows.Forms.Button();
            this.button_observe = new System.Windows.Forms.Button();
            this.button_disconnect = new System.Windows.Forms.Button();
            this.button_connect = new System.Windows.Forms.Button();
            this.textBox_length = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_Start = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_data = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ComboBox_Stop = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox_Check = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_Bauder = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_SerialPort = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button_device = new System.Windows.Forms.Button();
            this.button_ob9 = new System.Windows.Forms.Button();
            this.button_ob8 = new System.Windows.Forms.Button();
            this.button_ob4 = new System.Windows.Forms.Button();
            this.button_ob7 = new System.Windows.Forms.Button();
            this.button_ob3 = new System.Windows.Forms.Button();
            this.button_ob6 = new System.Windows.Forms.Button();
            this.button_ob2 = new System.Windows.Forms.Button();
            this.button_ob5 = new System.Windows.Forms.Button();
            this.button_ob1 = new System.Windows.Forms.Button();
            this.button_ob0 = new System.Windows.Forms.Button();
            this.通信参数.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // 通信参数
            // 
            this.通信参数.Controls.Add(this.button_disobserve);
            this.通信参数.Controls.Add(this.button_observe);
            this.通信参数.Controls.Add(this.button_disconnect);
            this.通信参数.Controls.Add(this.button_connect);
            this.通信参数.Controls.Add(this.textBox_length);
            this.通信参数.Controls.Add(this.label8);
            this.通信参数.Controls.Add(this.textBox_Start);
            this.通信参数.Controls.Add(this.label7);
            this.通信参数.Controls.Add(this.textBox_data);
            this.通信参数.Controls.Add(this.label5);
            this.通信参数.Controls.Add(this.ComboBox_Stop);
            this.通信参数.Controls.Add(this.label6);
            this.通信参数.Controls.Add(this.comboBox_Check);
            this.通信参数.Controls.Add(this.label4);
            this.通信参数.Controls.Add(this.comboBox_Bauder);
            this.通信参数.Controls.Add(this.label3);
            this.通信参数.Controls.Add(this.comboBox_SerialPort);
            this.通信参数.Controls.Add(this.label2);
            this.通信参数.Location = new System.Drawing.Point(22, 27);
            this.通信参数.Name = "通信参数";
            this.通信参数.Size = new System.Drawing.Size(861, 230);
            this.通信参数.TabIndex = 0;
            this.通信参数.TabStop = false;
            this.通信参数.Text = "通信参数";
            // 
            // button_disobserve
            // 
            this.button_disobserve.Location = new System.Drawing.Point(643, 134);
            this.button_disobserve.Name = "button_disobserve";
            this.button_disobserve.Size = new System.Drawing.Size(170, 62);
            this.button_disobserve.TabIndex = 3;
            this.button_disobserve.Text = "停止监听";
            this.button_disobserve.UseVisualStyleBackColor = true;
            this.button_disobserve.Click += new System.EventHandler(this.button_disobserve_Click);
            // 
            // button_observe
            // 
            this.button_observe.Location = new System.Drawing.Point(449, 134);
            this.button_observe.Name = "button_observe";
            this.button_observe.Size = new System.Drawing.Size(170, 62);
            this.button_observe.TabIndex = 3;
            this.button_observe.Text = "开始监听";
            this.button_observe.UseVisualStyleBackColor = true;
            this.button_observe.Click += new System.EventHandler(this.button_observe_Click);
            // 
            // button_disconnect
            // 
            this.button_disconnect.Location = new System.Drawing.Point(255, 134);
            this.button_disconnect.Name = "button_disconnect";
            this.button_disconnect.Size = new System.Drawing.Size(170, 62);
            this.button_disconnect.TabIndex = 3;
            this.button_disconnect.Text = "断开连接";
            this.button_disconnect.UseVisualStyleBackColor = true;
            this.button_disconnect.Click += new System.EventHandler(this.button_disconnect_Click);
            // 
            // button_connect
            // 
            this.button_connect.Location = new System.Drawing.Point(57, 134);
            this.button_connect.Name = "button_connect";
            this.button_connect.Size = new System.Drawing.Size(170, 62);
            this.button_connect.TabIndex = 3;
            this.button_connect.Text = "建立连接";
            this.button_connect.UseVisualStyleBackColor = true;
            this.button_connect.Click += new System.EventHandler(this.button_connect_Click);
            // 
            // textBox_length
            // 
            this.textBox_length.Location = new System.Drawing.Point(537, 79);
            this.textBox_length.Name = "textBox_length";
            this.textBox_length.Size = new System.Drawing.Size(94, 25);
            this.textBox_length.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(462, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "地址长度：";
            // 
            // textBox_Start
            // 
            this.textBox_Start.Location = new System.Drawing.Point(304, 84);
            this.textBox_Start.Name = "textBox_Start";
            this.textBox_Start.Size = new System.Drawing.Size(94, 25);
            this.textBox_Start.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(229, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "起始地址：";
            // 
            // textBox_data
            // 
            this.textBox_data.Location = new System.Drawing.Point(749, 34);
            this.textBox_data.Name = "textBox_data";
            this.textBox_data.Size = new System.Drawing.Size(94, 25);
            this.textBox_data.TabIndex = 2;
            this.textBox_data.Text = "8";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(687, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "数据位：";
            // 
            // ComboBox_Stop
            // 
            this.ComboBox_Stop.FormattingEnabled = true;
            this.ComboBox_Stop.Location = new System.Drawing.Point(89, 86);
            this.ComboBox_Stop.Name = "ComboBox_Stop";
            this.ComboBox_Stop.Size = new System.Drawing.Size(121, 23);
            this.ComboBox_Stop.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "停止位：";
            // 
            // comboBox_Check
            // 
            this.comboBox_Check.FormattingEnabled = true;
            this.comboBox_Check.Location = new System.Drawing.Point(537, 36);
            this.comboBox_Check.Name = "comboBox_Check";
            this.comboBox_Check.Size = new System.Drawing.Size(121, 23);
            this.comboBox_Check.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(464, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "校验位：";
            // 
            // comboBox_Bauder
            // 
            this.comboBox_Bauder.FormattingEnabled = true;
            this.comboBox_Bauder.Items.AddRange(new object[] {
            "9600",
            "4800",
            "2400",
            "1200"});
            this.comboBox_Bauder.Location = new System.Drawing.Point(304, 36);
            this.comboBox_Bauder.Name = "comboBox_Bauder";
            this.comboBox_Bauder.Size = new System.Drawing.Size(121, 23);
            this.comboBox_Bauder.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(231, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "波特率：";
            // 
            // comboBox_SerialPort
            // 
            this.comboBox_SerialPort.FormattingEnabled = true;
            this.comboBox_SerialPort.Location = new System.Drawing.Point(89, 36);
            this.comboBox_SerialPort.Name = "comboBox_SerialPort";
            this.comboBox_SerialPort.Size = new System.Drawing.Size(121, 23);
            this.comboBox_SerialPort.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "端口号：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.richTextBox1);
            this.groupBox2.Location = new System.Drawing.Point(22, 263);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(859, 212);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "日记记录";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(3, 21);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(853, 188);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button_ob9);
            this.groupBox3.Controls.Add(this.button_ob8);
            this.groupBox3.Controls.Add(this.button_ob4);
            this.groupBox3.Controls.Add(this.button_ob7);
            this.groupBox3.Controls.Add(this.button_ob3);
            this.groupBox3.Controls.Add(this.button_ob6);
            this.groupBox3.Controls.Add(this.button_ob2);
            this.groupBox3.Controls.Add(this.button_ob5);
            this.groupBox3.Controls.Add(this.button_ob1);
            this.groupBox3.Controls.Add(this.button_ob0);
            this.groupBox3.Location = new System.Drawing.Point(25, 509);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(628, 168);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "监控地址状态";
            // 
            // button_device
            // 
            this.button_device.BackColor = System.Drawing.Color.Red;
            this.button_device.Location = new System.Drawing.Point(678, 519);
            this.button_device.Name = "button_device";
            this.button_device.Size = new System.Drawing.Size(187, 158);
            this.button_device.TabIndex = 1;
            this.button_device.Text = "设备已断开";
            this.button_device.UseVisualStyleBackColor = false;
            // 
            // button_ob9
            // 
            this.button_ob9.Location = new System.Drawing.Point(511, 105);
            this.button_ob9.Name = "button_ob9";
            this.button_ob9.Size = new System.Drawing.Size(105, 43);
            this.button_ob9.TabIndex = 0;
            this.button_ob9.Text = "地址9";
            this.button_ob9.UseVisualStyleBackColor = true;
            // 
            // button_ob8
            // 
            this.button_ob8.Location = new System.Drawing.Point(388, 105);
            this.button_ob8.Name = "button_ob8";
            this.button_ob8.Size = new System.Drawing.Size(105, 43);
            this.button_ob8.TabIndex = 0;
            this.button_ob8.Text = "地址8";
            this.button_ob8.UseVisualStyleBackColor = true;
            // 
            // button_ob4
            // 
            this.button_ob4.Location = new System.Drawing.Point(511, 38);
            this.button_ob4.Name = "button_ob4";
            this.button_ob4.Size = new System.Drawing.Size(105, 43);
            this.button_ob4.TabIndex = 0;
            this.button_ob4.Text = "地址4";
            this.button_ob4.UseVisualStyleBackColor = true;
            // 
            // button_ob7
            // 
            this.button_ob7.Location = new System.Drawing.Point(268, 105);
            this.button_ob7.Name = "button_ob7";
            this.button_ob7.Size = new System.Drawing.Size(105, 43);
            this.button_ob7.TabIndex = 0;
            this.button_ob7.Text = "地址7";
            this.button_ob7.UseVisualStyleBackColor = true;
            // 
            // button_ob3
            // 
            this.button_ob3.Location = new System.Drawing.Point(388, 38);
            this.button_ob3.Name = "button_ob3";
            this.button_ob3.Size = new System.Drawing.Size(105, 43);
            this.button_ob3.TabIndex = 0;
            this.button_ob3.Text = "地址3";
            this.button_ob3.UseVisualStyleBackColor = true;
            // 
            // button_ob6
            // 
            this.button_ob6.Location = new System.Drawing.Point(147, 105);
            this.button_ob6.Name = "button_ob6";
            this.button_ob6.Size = new System.Drawing.Size(105, 43);
            this.button_ob6.TabIndex = 0;
            this.button_ob6.Text = "地址6";
            this.button_ob6.UseVisualStyleBackColor = true;
            // 
            // button_ob2
            // 
            this.button_ob2.Location = new System.Drawing.Point(268, 38);
            this.button_ob2.Name = "button_ob2";
            this.button_ob2.Size = new System.Drawing.Size(105, 43);
            this.button_ob2.TabIndex = 0;
            this.button_ob2.Text = "地址2";
            this.button_ob2.UseVisualStyleBackColor = true;
            // 
            // button_ob5
            // 
            this.button_ob5.Location = new System.Drawing.Point(21, 105);
            this.button_ob5.Name = "button_ob5";
            this.button_ob5.Size = new System.Drawing.Size(105, 43);
            this.button_ob5.TabIndex = 0;
            this.button_ob5.Text = "地址5";
            this.button_ob5.UseVisualStyleBackColor = true;
            // 
            // button_ob1
            // 
            this.button_ob1.Location = new System.Drawing.Point(147, 38);
            this.button_ob1.Name = "button_ob1";
            this.button_ob1.Size = new System.Drawing.Size(105, 43);
            this.button_ob1.TabIndex = 0;
            this.button_ob1.Text = "地址1";
            this.button_ob1.UseVisualStyleBackColor = true;
            // 
            // button_ob0
            // 
            this.button_ob0.Location = new System.Drawing.Point(21, 38);
            this.button_ob0.Name = "button_ob0";
            this.button_ob0.Size = new System.Drawing.Size(105, 43);
            this.button_ob0.TabIndex = 0;
            this.button_ob0.Text = "地址0";
            this.button_ob0.UseVisualStyleBackColor = true;
            // 
            // form
            // 
            this.ClientSize = new System.Drawing.Size(905, 746);
            this.Controls.Add(this.button_device);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.通信参数);
            this.Name = "form";
            this.Text = "报警实时监控";
            this.通信参数.ResumeLayout(false);
            this.通信参数.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox 通信参数;
        private System.Windows.Forms.ComboBox comboBox_SerialPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_Check;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_Bauder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_data;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_Start;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox ComboBox_Stop;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_disobserve;
        private System.Windows.Forms.Button button_observe;
        private System.Windows.Forms.Button button_disconnect;
        private System.Windows.Forms.Button button_connect;
        private System.Windows.Forms.TextBox textBox_length;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button_ob0;
        private System.Windows.Forms.Button button_device;
        private System.Windows.Forms.Button button_ob9;
        private System.Windows.Forms.Button button_ob8;
        private System.Windows.Forms.Button button_ob4;
        private System.Windows.Forms.Button button_ob7;
        private System.Windows.Forms.Button button_ob3;
        private System.Windows.Forms.Button button_ob6;
        private System.Windows.Forms.Button button_ob2;
        private System.Windows.Forms.Button button_ob5;
        private System.Windows.Forms.Button button_ob1;
    }
}

