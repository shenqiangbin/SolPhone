namespace ZaiPangWin
{
    partial class Form1
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
            this.btn_loadMachine = new System.Windows.Forms.Button();
            this.listbox_machine = new System.Windows.Forms.ListBox();
            this.txt_adb = new System.Windows.Forms.TextBox();
            this.lbl_adb = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_CheckMsg = new System.Windows.Forms.Label();
            this.rtbMsg = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtInterval = new System.Windows.Forms.TextBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.pointX = new System.Windows.Forms.TextBox();
            this.pointY = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_loadMachine
            // 
            this.btn_loadMachine.Location = new System.Drawing.Point(12, 103);
            this.btn_loadMachine.Name = "btn_loadMachine";
            this.btn_loadMachine.Size = new System.Drawing.Size(120, 23);
            this.btn_loadMachine.TabIndex = 0;
            this.btn_loadMachine.Text = "加载模拟器";
            this.btn_loadMachine.UseVisualStyleBackColor = true;
            this.btn_loadMachine.Click += new System.EventHandler(this.btn_loadMachine_Click);
            // 
            // listbox_machine
            // 
            this.listbox_machine.FormattingEnabled = true;
            this.listbox_machine.ItemHeight = 12;
            this.listbox_machine.Location = new System.Drawing.Point(12, 132);
            this.listbox_machine.Name = "listbox_machine";
            this.listbox_machine.Size = new System.Drawing.Size(120, 148);
            this.listbox_machine.TabIndex = 1;
            // 
            // txt_adb
            // 
            this.txt_adb.Location = new System.Drawing.Point(100, 20);
            this.txt_adb.Name = "txt_adb";
            this.txt_adb.Size = new System.Drawing.Size(384, 21);
            this.txt_adb.TabIndex = 2;
            // 
            // lbl_adb
            // 
            this.lbl_adb.AutoSize = true;
            this.lbl_adb.Location = new System.Drawing.Point(17, 23);
            this.lbl_adb.Name = "lbl_adb";
            this.lbl_adb.Size = new System.Drawing.Size(83, 12);
            this.lbl_adb.TabIndex = 3;
            this.lbl_adb.Text = "adb文件路径：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_CheckMsg);
            this.groupBox1.Controls.Add(this.txt_adb);
            this.groupBox1.Controls.Add(this.lbl_adb);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(547, 78);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "基本配置";
            // 
            // lbl_CheckMsg
            // 
            this.lbl_CheckMsg.AutoSize = true;
            this.lbl_CheckMsg.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_CheckMsg.Location = new System.Drawing.Point(431, 48);
            this.lbl_CheckMsg.Name = "lbl_CheckMsg";
            this.lbl_CheckMsg.Size = new System.Drawing.Size(53, 12);
            this.lbl_CheckMsg.TabIndex = 5;
            this.lbl_CheckMsg.Text = "信息展示";
            // 
            // rtbMsg
            // 
            this.rtbMsg.Location = new System.Drawing.Point(12, 309);
            this.rtbMsg.Name = "rtbMsg";
            this.rtbMsg.Size = new System.Drawing.Size(547, 191);
            this.rtbMsg.TabIndex = 5;
            this.rtbMsg.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "消息展示：";
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("SimSun", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStart.Location = new System.Drawing.Point(148, 159);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(409, 121);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "开始";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtInterval
            // 
            this.txtInterval.Location = new System.Drawing.Point(289, 132);
            this.txtInterval.Name = "txtInterval";
            this.txtInterval.Size = new System.Drawing.Size(160, 21);
            this.txtInterval.TabIndex = 2;
            this.txtInterval.Text = "0.5";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(146, 135);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(125, 12);
            this.lblTime.TabIndex = 3;
            this.lblTime.Text = "时间间隔(单位：秒)：";
            // 
            // pointX
            // 
            this.pointX.Location = new System.Drawing.Point(211, 104);
            this.pointX.Name = "pointX";
            this.pointX.Size = new System.Drawing.Size(79, 21);
            this.pointX.TabIndex = 2;
            // 
            // pointY
            // 
            this.pointY.Location = new System.Drawing.Point(370, 104);
            this.pointY.Name = "pointY";
            this.pointY.Size = new System.Drawing.Size(79, 21);
            this.pointY.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(146, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "抢购X坐标";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(307, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "抢购Y坐标";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 511);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pointY);
            this.Controls.Add(this.pointX);
            this.Controls.Add(this.txtInterval);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbMsg);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listbox_machine);
            this.Controls.Add(this.btn_loadMachine);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_loadMachine;
        private System.Windows.Forms.ListBox listbox_machine;
        private System.Windows.Forms.TextBox txt_adb;
        private System.Windows.Forms.Label lbl_adb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_CheckMsg;
        private System.Windows.Forms.RichTextBox rtbMsg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtInterval;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.TextBox pointX;
        private System.Windows.Forms.TextBox pointY;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

