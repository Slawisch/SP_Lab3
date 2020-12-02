using System.ComponentModel;

namespace SP_Lab3
{
    partial class AddUserForm
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
            this.passTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cancelBt = new System.Windows.Forms.Button();
            this.applyBt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameTb
            // 
            this.nameTb.Location = new System.Drawing.Point(97, 12);
            this.nameTb.Name = "nameTb";
            this.nameTb.Size = new System.Drawing.Size(100, 20);
            this.nameTb.TabIndex = 0;
            // 
            // passTb
            // 
            this.passTb.Location = new System.Drawing.Point(97, 38);
            this.passTb.Name = "passTb";
            this.passTb.Size = new System.Drawing.Size(100, 20);
            this.passTb.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Name:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Password:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cancelBt
            // 
            this.cancelBt.Location = new System.Drawing.Point(106, 64);
            this.cancelBt.Name = "cancelBt";
            this.cancelBt.Size = new System.Drawing.Size(92, 30);
            this.cancelBt.TabIndex = 19;
            this.cancelBt.Text = "Cancel";
            this.cancelBt.UseVisualStyleBackColor = true;
            this.cancelBt.Click += new System.EventHandler(this.cancelBt_Click);
            // 
            // applyBt
            // 
            this.applyBt.Location = new System.Drawing.Point(12, 64);
            this.applyBt.Name = "applyBt";
            this.applyBt.Size = new System.Drawing.Size(92, 30);
            this.applyBt.TabIndex = 18;
            this.applyBt.Text = "Apply";
            this.applyBt.UseVisualStyleBackColor = true;
            this.applyBt.Click += new System.EventHandler(this.applyBt_Click);
            // 
            // AddUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(209, 99);
            this.Controls.Add(this.cancelBt);
            this.Controls.Add(this.applyBt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passTb);
            this.Controls.Add(this.nameTb);
            this.Name = "AddUserForm";
            this.Text = "AddUserForm";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button applyBt;
        private System.Windows.Forms.Button cancelBt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameTb;
        private System.Windows.Forms.TextBox passTb;

        #endregion
    }
}