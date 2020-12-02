using System.ComponentModel;

namespace SP_Lab3
{
    partial class EditHarwareForm
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
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.hddNum = new System.Windows.Forms.NumericUpDown();
            this.cpuNum = new System.Windows.Forms.NumericUpDown();
            this.ramNum = new System.Windows.Forms.NumericUpDown();
            this.osCb = new System.Windows.Forms.ComboBox();
            this.cancelBt = new System.Windows.Forms.Button();
            this.applyBt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.hddNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.cpuNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.ramNum)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label7.Location = new System.Drawing.Point(12, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 20);
            this.label7.TabIndex = 26;
            this.label7.Text = "HDD:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label6.Location = new System.Drawing.Point(12, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 20);
            this.label6.TabIndex = 25;
            this.label6.Text = "CPU:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label5.Location = new System.Drawing.Point(12, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "RAM:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "OS Type:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // hddNum
            // 
            this.hddNum.Location = new System.Drawing.Point(117, 87);
            this.hddNum.Maximum = new decimal(new int[] {100000, 0, 0, 0});
            this.hddNum.Name = "hddNum";
            this.hddNum.Size = new System.Drawing.Size(100, 20);
            this.hddNum.TabIndex = 20;
            // 
            // cpuNum
            // 
            this.cpuNum.Location = new System.Drawing.Point(117, 61);
            this.cpuNum.Maximum = new decimal(new int[] {10000, 0, 0, 0});
            this.cpuNum.Name = "cpuNum";
            this.cpuNum.Size = new System.Drawing.Size(100, 20);
            this.cpuNum.TabIndex = 19;
            // 
            // ramNum
            // 
            this.ramNum.Location = new System.Drawing.Point(117, 35);
            this.ramNum.Maximum = new decimal(new int[] {100000, 0, 0, 0});
            this.ramNum.Name = "ramNum";
            this.ramNum.Size = new System.Drawing.Size(100, 20);
            this.ramNum.TabIndex = 18;
            // 
            // osCb
            // 
            this.osCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.osCb.FormattingEnabled = true;
            this.osCb.Location = new System.Drawing.Point(117, 8);
            this.osCb.Name = "osCb";
            this.osCb.Size = new System.Drawing.Size(100, 21);
            this.osCb.TabIndex = 15;
            // 
            // cancelBt
            // 
            this.cancelBt.Location = new System.Drawing.Point(125, 113);
            this.cancelBt.Name = "cancelBt";
            this.cancelBt.Size = new System.Drawing.Size(92, 30);
            this.cancelBt.TabIndex = 28;
            this.cancelBt.Text = "Cancel";
            this.cancelBt.UseVisualStyleBackColor = true;
            this.cancelBt.Click += new System.EventHandler(this.cancelBt_Click);
            // 
            // applyBt
            // 
            this.applyBt.Location = new System.Drawing.Point(12, 113);
            this.applyBt.Name = "applyBt";
            this.applyBt.Size = new System.Drawing.Size(92, 30);
            this.applyBt.TabIndex = 27;
            this.applyBt.Text = "Apply";
            this.applyBt.UseVisualStyleBackColor = true;
            this.applyBt.Click += new System.EventHandler(this.applyBt_Click);
            // 
            // EditHarwareForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 152);
            this.Controls.Add(this.cancelBt);
            this.Controls.Add(this.applyBt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.hddNum);
            this.Controls.Add(this.cpuNum);
            this.Controls.Add(this.ramNum);
            this.Controls.Add(this.osCb);
            this.Name = "EditHarwareForm";
            this.Text = "EditHarwareForm";
            ((System.ComponentModel.ISupportInitialize) (this.hddNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.cpuNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.ramNum)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button applyBt;
        private System.Windows.Forms.Button cancelBt;
        private System.Windows.Forms.NumericUpDown cpuNum;
        private System.Windows.Forms.NumericUpDown hddNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox osCb;
        private System.Windows.Forms.NumericUpDown ramNum;

        #endregion
    }
}