namespace SP_Lab3
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.delProgramBt = new System.Windows.Forms.Button();
            this.addProgramBt = new System.Windows.Forms.Button();
            this.UpdProgramBt = new System.Windows.Forms.Button();
            this.addUserBt = new System.Windows.Forms.Button();
            this.delUserBt = new System.Windows.Forms.Button();
            this.compUserBt = new System.Windows.Forms.Button();
            this.addProgramUserBt = new System.Windows.Forms.Button();
            this.delProgramUserBt = new System.Windows.Forms.Button();
            this.editParamsBt = new System.Windows.Forms.Button();
            this.compProgramsBt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 37);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(220, 290);
            this.listBox1.TabIndex = 0;
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(294, 37);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(225, 290);
            this.listBox2.TabIndex = 1;
            this.listBox2.DoubleClick += new System.EventHandler(this.listBox2_DoubleClick);
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label1.Location = new System.Drawing.Point(63, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Programs";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label2.Location = new System.Drawing.Point(352, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "Users";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(0, 400);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(533, 2);
            this.label3.TabIndex = 4;
            // 
            // delProgramBt
            // 
            this.delProgramBt.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.delProgramBt.Location = new System.Drawing.Point(167, 333);
            this.delProgramBt.Name = "delProgramBt";
            this.delProgramBt.Size = new System.Drawing.Size(65, 48);
            this.delProgramBt.TabIndex = 5;
            this.delProgramBt.Text = "-";
            this.delProgramBt.UseVisualStyleBackColor = true;
            this.delProgramBt.Click += new System.EventHandler(this.delProgramBt_Click);
            // 
            // addProgramBt
            // 
            this.addProgramBt.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.addProgramBt.Location = new System.Drawing.Point(12, 333);
            this.addProgramBt.Name = "addProgramBt";
            this.addProgramBt.Size = new System.Drawing.Size(65, 48);
            this.addProgramBt.TabIndex = 6;
            this.addProgramBt.Text = "+";
            this.addProgramBt.UseVisualStyleBackColor = true;
            this.addProgramBt.Click += new System.EventHandler(this.addProgramBt_Click);
            // 
            // UpdProgramBt
            // 
            this.UpdProgramBt.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.UpdProgramBt.Location = new System.Drawing.Point(83, 333);
            this.UpdProgramBt.Name = "UpdProgramBt";
            this.UpdProgramBt.Size = new System.Drawing.Size(38, 48);
            this.UpdProgramBt.TabIndex = 7;
            this.UpdProgramBt.Text = "↻";
            this.UpdProgramBt.UseVisualStyleBackColor = true;
            this.UpdProgramBt.Click += new System.EventHandler(this.UpdProgramBt_Click);
            // 
            // addUserBt
            // 
            this.addUserBt.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.addUserBt.Location = new System.Drawing.Point(294, 333);
            this.addUserBt.Name = "addUserBt";
            this.addUserBt.Size = new System.Drawing.Size(65, 48);
            this.addUserBt.TabIndex = 8;
            this.addUserBt.Text = "+";
            this.addUserBt.UseVisualStyleBackColor = true;
            this.addUserBt.Click += new System.EventHandler(this.addUserBt_Click);
            // 
            // delUserBt
            // 
            this.delUserBt.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.delUserBt.Location = new System.Drawing.Point(454, 333);
            this.delUserBt.Name = "delUserBt";
            this.delUserBt.Size = new System.Drawing.Size(65, 48);
            this.delUserBt.TabIndex = 9;
            this.delUserBt.Text = "-";
            this.delUserBt.UseVisualStyleBackColor = true;
            this.delUserBt.Click += new System.EventHandler(this.delUserBt_Click);
            // 
            // compUserBt
            // 
            this.compUserBt.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.compUserBt.Location = new System.Drawing.Point(365, 333);
            this.compUserBt.Name = "compUserBt";
            this.compUserBt.Size = new System.Drawing.Size(83, 48);
            this.compUserBt.TabIndex = 10;
            this.compUserBt.Text = "~";
            this.compUserBt.UseVisualStyleBackColor = true;
            this.compUserBt.Click += new System.EventHandler(this.compUserBt_Click);
            // 
            // addProgramUserBt
            // 
            this.addProgramUserBt.Font = new System.Drawing.Font("Microsoft YaHei", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.addProgramUserBt.Location = new System.Drawing.Point(238, 37);
            this.addProgramUserBt.Name = "addProgramUserBt";
            this.addProgramUserBt.Size = new System.Drawing.Size(50, 113);
            this.addProgramUserBt.TabIndex = 11;
            this.addProgramUserBt.Text = "→";
            this.addProgramUserBt.UseVisualStyleBackColor = true;
            this.addProgramUserBt.Click += new System.EventHandler(this.button7_Click);
            // 
            // delProgramUserBt
            // 
            this.delProgramUserBt.Font = new System.Drawing.Font("Microsoft YaHei", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.delProgramUserBt.Location = new System.Drawing.Point(238, 214);
            this.delProgramUserBt.Name = "delProgramUserBt";
            this.delProgramUserBt.Size = new System.Drawing.Size(50, 113);
            this.delProgramUserBt.TabIndex = 12;
            this.delProgramUserBt.Text = "←";
            this.delProgramUserBt.UseVisualStyleBackColor = true;
            this.delProgramUserBt.Click += new System.EventHandler(this.delProgramUserBt_Click);
            // 
            // editParamsBt
            // 
            this.editParamsBt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.editParamsBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.editParamsBt.Location = new System.Drawing.Point(505, 401);
            this.editParamsBt.Name = "editParamsBt";
            this.editParamsBt.Size = new System.Drawing.Size(26, 20);
            this.editParamsBt.TabIndex = 13;
            this.editParamsBt.Text = "↺";
            this.editParamsBt.UseVisualStyleBackColor = true;
            this.editParamsBt.Click += new System.EventHandler(this.editParamsBt_Click);
            // 
            // compProgramsBt
            // 
            this.compProgramsBt.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.compProgramsBt.Location = new System.Drawing.Point(123, 333);
            this.compProgramsBt.Name = "compProgramsBt";
            this.compProgramsBt.Size = new System.Drawing.Size(38, 48);
            this.compProgramsBt.TabIndex = 14;
            this.compProgramsBt.Text = "~";
            this.compProgramsBt.UseVisualStyleBackColor = true;
            this.compProgramsBt.Click += new System.EventHandler(this.compProgramsBt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 421);
            this.Controls.Add(this.compProgramsBt);
            this.Controls.Add(this.editParamsBt);
            this.Controls.Add(this.delProgramUserBt);
            this.Controls.Add(this.addProgramUserBt);
            this.Controls.Add(this.compUserBt);
            this.Controls.Add(this.delUserBt);
            this.Controls.Add(this.addUserBt);
            this.Controls.Add(this.UpdProgramBt);
            this.Controls.Add(this.addProgramBt);
            this.Controls.Add(this.delProgramBt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button addProgramBt;
        private System.Windows.Forms.Button addProgramUserBt;
        private System.Windows.Forms.Button addUserBt;
        private System.Windows.Forms.Button compProgramsBt;
        private System.Windows.Forms.Button compUserBt;
        private System.Windows.Forms.Button delProgramBt;
        private System.Windows.Forms.Button delProgramUserBt;
        private System.Windows.Forms.Button delUserBt;
        private System.Windows.Forms.Button editParamsBt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button UpdProgramBt;

        #endregion
    }
}