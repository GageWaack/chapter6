namespace RentPrice
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
            this.txtFloors = new System.Windows.Forms.TextBox();
            this.txtRooms = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCalculateRooms = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtFloors
            // 
            this.txtFloors.Location = new System.Drawing.Point(386, 144);
            this.txtFloors.Name = "txtFloors";
            this.txtFloors.Size = new System.Drawing.Size(100, 20);
            this.txtFloors.TabIndex = 0;
            // 
            // txtRooms
            // 
            this.txtRooms.Location = new System.Drawing.Point(386, 207);
            this.txtRooms.Name = "txtRooms";
            this.txtRooms.Size = new System.Drawing.Size(100, 20);
            this.txtRooms.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(322, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Floor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(267, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "number of rooms";
            // 
            // btnCalculateRooms
            // 
            this.btnCalculateRooms.Location = new System.Drawing.Point(411, 265);
            this.btnCalculateRooms.Name = "btnCalculateRooms";
            this.btnCalculateRooms.Size = new System.Drawing.Size(75, 23);
            this.btnCalculateRooms.TabIndex = 4;
            this.btnCalculateRooms.Text = "Calculate";
            this.btnCalculateRooms.UseVisualStyleBackColor = true;
            this.btnCalculateRooms.Click += new System.EventHandler(this.btnCalculateRooms_Click);
            // 
            // lblResult
            // 
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResult.Location = new System.Drawing.Point(365, 326);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(140, 93);
            this.lblResult.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnCalculateRooms);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRooms);
            this.Controls.Add(this.txtFloors);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFloors;
        private System.Windows.Forms.TextBox txtRooms;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCalculateRooms;
        private System.Windows.Forms.Label lblResult;
    }
}

