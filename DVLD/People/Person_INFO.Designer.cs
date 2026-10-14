namespace DVLD.People
{
    partial class Person_INFO
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
            this.ctrL_Person_INFO1 = new DVLD.People.controll.CTRL_Person_INFO();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ctrL_Person_INFO1
            // 
            this.ctrL_Person_INFO1.Location = new System.Drawing.Point(5, 91);
            this.ctrL_Person_INFO1.Name = "ctrL_Person_INFO1";
            this.ctrL_Person_INFO1.Size = new System.Drawing.Size(841, 325);
            this.ctrL_Person_INFO1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(303, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 62);
            this.label1.TabIndex = 1;
            this.label1.Text = "Person";
            // 
            // Person_INFO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 428);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrL_Person_INFO1);
            this.Name = "Person_INFO";
            this.Text = "Person_INFO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private controll.CTRL_Person_INFO ctrL_Person_INFO1;
        private System.Windows.Forms.Label label1;
    }
}