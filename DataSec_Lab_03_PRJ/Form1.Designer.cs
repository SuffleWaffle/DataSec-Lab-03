namespace DataSec_Lab_03_PRJ
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
            this.groupBoxCypher = new System.Windows.Forms.GroupBox();
            this.groupBoxDecypher = new System.Windows.Forms.GroupBox();
            this.buttonXOR = new System.Windows.Forms.Button();
            this.buttonRESET = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // groupBoxCypher
            // 
            this.groupBoxCypher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxCypher.Location = new System.Drawing.Point(20, 25);
            this.groupBoxCypher.Name = "groupBoxCypher";
            this.groupBoxCypher.Size = new System.Drawing.Size(200, 150);
            this.groupBoxCypher.TabIndex = 0;
            this.groupBoxCypher.TabStop = false;
            this.groupBoxCypher.Text = "Cypher";
            this.groupBoxCypher.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBoxDecypher
            // 
            this.groupBoxDecypher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxDecypher.Location = new System.Drawing.Point(340, 25);
            this.groupBoxDecypher.Name = "groupBoxDecypher";
            this.groupBoxDecypher.Size = new System.Drawing.Size(200, 150);
            this.groupBoxDecypher.TabIndex = 1;
            this.groupBoxDecypher.TabStop = false;
            this.groupBoxDecypher.Text = "Decypher";
            // 
            // buttonXOR
            // 
            this.buttonXOR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonXOR.Location = new System.Drawing.Point(240, 40);
            this.buttonXOR.Name = "buttonXOR";
            this.buttonXOR.Size = new System.Drawing.Size(80, 50);
            this.buttonXOR.TabIndex = 3;
            this.buttonXOR.Text = "XOR";
            this.buttonXOR.UseVisualStyleBackColor = true;
            this.buttonXOR.Click += new System.EventHandler(this.buttonXOR_Click);
            // 
            // buttonRESET
            // 
            this.buttonRESET.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRESET.Location = new System.Drawing.Point(240, 110);
            this.buttonRESET.Name = "buttonRESET";
            this.buttonRESET.Size = new System.Drawing.Size(80, 50);
            this.buttonRESET.TabIndex = 4;
            this.buttonRESET.Text = "RESET";
            this.buttonRESET.UseVisualStyleBackColor = true;
            this.buttonRESET.Click += new System.EventHandler(this.buttonRESET_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(564, 201);
            this.Controls.Add(this.buttonRESET);
            this.Controls.Add(this.buttonXOR);
            this.Controls.Add(this.groupBoxDecypher);
            this.Controls.Add(this.groupBoxCypher);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "Form1";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button buttonRESET;

        private System.Windows.Forms.Button buttonXOR;

        private System.Windows.Forms.GroupBox groupBoxDecypher;

        private System.Windows.Forms.GroupBox groupBoxCypher;

        #endregion
    }
}