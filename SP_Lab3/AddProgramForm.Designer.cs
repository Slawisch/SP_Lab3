using System.ComponentModel;

namespace SP_Lab3
{
    partial class AddProgramForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.nameTb = new System.Windows.Forms.TextBox();
            this.osCb = new System.Windows.Forms.ComboBox();
            this.companyTb = new System.Windows.Forms.TextBox();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.versionNum = new System.Windows.Forms.NumericUpDown();
            this.ramNum = new System.Windows.Forms.NumericUpDown();
            this.cpuNum = new System.Windows.Forms.NumericUpDown();
            this.hddNum = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.applyBt = new System.Windows.Forms.Button();
            this.cancelBt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.versionNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.ramNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.cpuNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.hddNum)).BeginInit();
            this.SuspendLayout();
            // 
            // nameTb
            // 
            this.nameTb.Location = new System.Drawing.Point(117, 12);
            this.nameTb.Name = "nameTb";
            this.nameTb.Size = new System.Drawing.Size(100, 20);
            this.nameTb.TabIndex = 0;
            // 
            // osCb
            // 
            this.osCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.osCb.FormattingEnabled = true;
            this.osCb.Location = new System.Drawing.Point(117, 38);
            this.osCb.Name = "osCb";
            this.osCb.Size = new System.Drawing.Size(100, 21);
            this.osCb.TabIndex = 1;
            // 
            // companyTb
            // 
            this.companyTb.Location = new System.Drawing.Point(117, 65);
            this.companyTb.Name = "companyTb";
            this.companyTb.Size = new System.Drawing.Size(100, 20);
            this.companyTb.TabIndex = 2;
            // 
            // dateTime
            // 
            this.dateTime.Location = new System.Drawing.Point(12, 218);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(205, 20);
            this.dateTime.TabIndex = 3;
            // 
            // versionNum
            // 
            this.versionNum.Location = new System.Drawing.Point(117, 91);
            this.versionNum.Name = "versionNum";
            this.versionNum.Size = new System.Drawing.Size(100, 20);
            this.versionNum.TabIndex = 4;
            // 
            // ramNum
            // 
            this.ramNum.Location = new System.Drawing.Point(117, 117);
            this.ramNum.Maximum = new decimal(new int[] {100000, 0, 0, 0});
            this.ramNum.Name = "ramNum";
            this.ramNum.Size = new System.Drawing.Size(100, 20);
            this.ramNum.TabIndex = 5;
            // 
            // cpuNum
            // 
            this.cpuNum.Location = new System.Drawing.Point(117, 143);
            this.cpuNum.Maximum = new decimal(new int[] {100000, 0, 0, 0});
            this.cpuNum.Name = "cpuNum";
            this.cpuNum.Size = new System.Drawing.Size(100, 20);
            this.cpuNum.TabIndex = 6;
            // 
            // hddNum
            // 
            this.hddNum.Location = new System.Drawing.Point(117, 169);
            this.hddNum.Maximum = new decimal(new int[] {100000, 0, 0, 0});
            this.hddNum.Name = "hddNum";
            this.hddNum.Size = new System.Drawing.Size(100, 20);
            this.hddNum.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Name:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "OS Type:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label3.Location = new System.Drawing.Point(12, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Company:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label4.Location = new System.Drawing.Point(12, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Version:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label5.Location = new System.Drawing.Point(12, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "RAM:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label6.Location = new System.Drawing.Point(12, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "CPU:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label7.Location = new System.Drawing.Point(12, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "HDD:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label8.Location = new System.Drawing.Point(12, 195);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Installation Date:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // applyBt
            // 
            this.applyBt.Location = new System.Drawing.Point(12, 244);
            this.applyBt.Name = "applyBt";
            this.applyBt.Size = new System.Drawing.Size(92, 30);
            this.applyBt.TabIndex = 16;
            this.applyBt.Text = "Apply";
            this.applyBt.UseVisualStyleBackColor = true;
            this.applyBt.Click += new System.EventHandler(this.applyBt_Click);
            // 
            // cancelBt
            // 
            this.cancelBt.Location = new System.Drawing.Point(125, 244);
            this.cancelBt.Name = "cancelBt";
            this.cancelBt.Size = new System.Drawing.Size(92, 30);
            this.cancelBt.TabIndex = 17;
            this.cancelBt.Text = "Cancel";
            this.cancelBt.UseVisualStyleBackColor = true;
            this.cancelBt.Click += new System.EventHandler(this.cancelBt_Click);
            // 
            // AddProgramForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 281);
            this.Controls.Add(this.cancelBt);
            this.Controls.Add(this.applyBt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hddNum);
            this.Controls.Add(this.cpuNum);
            this.Controls.Add(this.ramNum);
            this.Controls.Add(this.versionNum);
            this.Controls.Add(this.dateTime);
            this.Controls.Add(this.companyTb);
            this.Controls.Add(this.osCb);
            this.Controls.Add(this.nameTb);
            this.Name = "AddProgramForm";
            this.Text = "AddProgramForm";
            ((System.ComponentModel.ISupportInitialize) (this.versionNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.ramNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.cpuNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.hddNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button applyBt;
        private System.Windows.Forms.Button cancelBt;
        private System.Windows.Forms.TextBox companyTb;
        private System.Windows.Forms.NumericUpDown cpuNum;
        private System.Windows.Forms.DateTimePicker dateTime;
        private System.Windows.Forms.NumericUpDown hddNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox nameTb;
        private System.Windows.Forms.ComboBox osCb;
        private System.Windows.Forms.NumericUpDown ramNum;
        private System.Windows.Forms.NumericUpDown versionNum;

        #endregion
    }
}