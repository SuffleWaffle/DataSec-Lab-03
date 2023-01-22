namespace DataSec_Lab_03_PRJ
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TextBoxPOut = new System.Windows.Forms.TextBox();
            this.TextBoxKeyOut = new System.Windows.Forms.TextBox();
            this.TextBoxCOut = new System.Windows.Forms.TextBox();
            this.labelPOut = new System.Windows.Forms.Label();
            this.labelKeyOut = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonRESET = new System.Windows.Forms.Button();
            this.buttonXOR = new System.Windows.Forms.Button();
            this.TextBoxCIn = new System.Windows.Forms.TextBox();
            this.TextBoxKeyIn = new System.Windows.Forms.TextBox();
            this.TextBoxPIn = new System.Windows.Forms.TextBox();
            this.labelC = new System.Windows.Forms.Label();
            this.labelKey = new System.Windows.Forms.Label();
            this.labelP = new System.Windows.Forms.Label();
            this.encGroupBox = new System.Windows.Forms.GroupBox();
            this.decGroupBox = new System.Windows.Forms.GroupBox();
            this.toolTipHEX = new System.Windows.Forms.ToolTip(this.components);
            this.encGroupBox.SuspendLayout();
            this.decGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBoxPOut
            // 
            this.TextBoxPOut.Location = new System.Drawing.Point(30, 20);
            this.TextBoxPOut.Name = "TextBoxPOut";
            this.TextBoxPOut.ReadOnly = true;
            this.TextBoxPOut.Size = new System.Drawing.Size(100, 20);
            this.TextBoxPOut.TabIndex = 40;
            this.TextBoxPOut.UseWaitCursor = true;
            // 
            // TextBoxKeyOut
            // 
            this.TextBoxKeyOut.Location = new System.Drawing.Point(30, 50);
            this.TextBoxKeyOut.Name = "TextBoxKeyOut";
            this.TextBoxKeyOut.ReadOnly = true;
            this.TextBoxKeyOut.Size = new System.Drawing.Size(100, 20);
            this.TextBoxKeyOut.TabIndex = 39;
            this.TextBoxKeyOut.UseWaitCursor = true;
            // 
            // TextBoxCOut
            // 
            this.TextBoxCOut.Location = new System.Drawing.Point(30, 80);
            this.TextBoxCOut.Name = "TextBoxCOut";
            this.TextBoxCOut.ReadOnly = true;
            this.TextBoxCOut.Size = new System.Drawing.Size(100, 20);
            this.TextBoxCOut.TabIndex = 38;
            this.TextBoxCOut.UseWaitCursor = true;
            // 
            // labelPOut
            // 
            this.labelPOut.AutoSize = true;
            this.labelPOut.Location = new System.Drawing.Point(138, 20);
            this.labelPOut.Name = "labelPOut";
            this.labelPOut.Size = new System.Drawing.Size(23, 13);
            this.labelPOut.TabIndex = 37;
            this.labelPOut.Text = "= P";
            this.labelPOut.UseWaitCursor = true;
            // 
            // labelKeyOut
            // 
            this.labelKeyOut.AutoSize = true;
            this.labelKeyOut.Location = new System.Drawing.Point(138, 53);
            this.labelKeyOut.Name = "labelKeyOut";
            this.labelKeyOut.Size = new System.Drawing.Size(34, 13);
            this.labelKeyOut.TabIndex = 36;
            this.labelKeyOut.Text = "= Key";
            this.labelKeyOut.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(138, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "= C";
            this.label3.UseWaitCursor = true;
            // 
            // buttonRESET
            // 
            this.buttonRESET.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRESET.Location = new System.Drawing.Point(230, 80);
            this.buttonRESET.Name = "buttonRESET";
            this.buttonRESET.Size = new System.Drawing.Size(75, 40);
            this.buttonRESET.TabIndex = 33;
            this.buttonRESET.Text = "RESET";
            this.buttonRESET.UseVisualStyleBackColor = true;
            this.buttonRESET.UseWaitCursor = true;
            this.buttonRESET.Click += new System.EventHandler(this.buttonRESET_Click);
            // 
            // buttonXOR
            // 
            this.buttonXOR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonXOR.Location = new System.Drawing.Point(230, 30);
            this.buttonXOR.Name = "buttonXOR";
            this.buttonXOR.Size = new System.Drawing.Size(75, 40);
            this.buttonXOR.TabIndex = 32;
            this.buttonXOR.Text = "XOR";
            this.buttonXOR.UseVisualStyleBackColor = true;
            this.buttonXOR.UseWaitCursor = true;
            this.buttonXOR.Click += new System.EventHandler(this.buttonXOR_Click);
            // 
            // TextBoxCIn
            // 
            this.TextBoxCIn.Location = new System.Drawing.Point(63, 80);
            this.TextBoxCIn.Name = "TextBoxCIn";
            this.TextBoxCIn.ReadOnly = true;
            this.TextBoxCIn.Size = new System.Drawing.Size(100, 20);
            this.TextBoxCIn.TabIndex = 31;
            this.TextBoxCIn.UseWaitCursor = true;
            // 
            // TextBoxKeyIn
            // 
            this.TextBoxKeyIn.Location = new System.Drawing.Point(63, 50);
            this.TextBoxKeyIn.Name = "TextBoxKeyIn";
            this.TextBoxKeyIn.Size = new System.Drawing.Size(100, 20);
            this.TextBoxKeyIn.TabIndex = 30;
            this.TextBoxKeyIn.UseWaitCursor = true;
            // 
            // TextBoxPIn
            // 
            this.TextBoxPIn.Location = new System.Drawing.Point(63, 20);
            this.TextBoxPIn.Name = "TextBoxPIn";
            this.TextBoxPIn.Size = new System.Drawing.Size(100, 20);
            this.TextBoxPIn.TabIndex = 29;
            this.TextBoxPIn.UseWaitCursor = true;
            // 
            // labelC
            // 
            this.labelC.AutoSize = true;
            this.labelC.Location = new System.Drawing.Point(22, 82);
            this.labelC.Name = "labelC";
            this.labelC.Size = new System.Drawing.Size(23, 13);
            this.labelC.TabIndex = 28;
            this.labelC.Text = "C =";
            this.labelC.UseWaitCursor = true;
            // 
            // labelKey
            // 
            this.labelKey.AutoSize = true;
            this.labelKey.Location = new System.Drawing.Point(22, 53);
            this.labelKey.Name = "labelKey";
            this.labelKey.Size = new System.Drawing.Size(34, 13);
            this.labelKey.TabIndex = 27;
            this.labelKey.Text = "Key =";
            this.labelKey.UseWaitCursor = true;
            // 
            // labelP
            // 
            this.labelP.AutoSize = true;
            this.labelP.Location = new System.Drawing.Point(22, 23);
            this.labelP.Name = "labelP";
            this.labelP.Size = new System.Drawing.Size(23, 13);
            this.labelP.TabIndex = 26;
            this.labelP.Text = "P =";
            this.labelP.UseWaitCursor = true;
            // 
            // encGroupBox
            // 
            this.encGroupBox.Controls.Add(this.TextBoxPIn);
            this.encGroupBox.Controls.Add(this.labelP);
            this.encGroupBox.Controls.Add(this.labelKey);
            this.encGroupBox.Controls.Add(this.labelC);
            this.encGroupBox.Controls.Add(this.TextBoxKeyIn);
            this.encGroupBox.Controls.Add(this.TextBoxCIn);
            this.encGroupBox.Location = new System.Drawing.Point(20, 10);
            this.encGroupBox.Name = "encGroupBox";
            this.encGroupBox.Size = new System.Drawing.Size(200, 120);
            this.encGroupBox.TabIndex = 52;
            this.encGroupBox.TabStop = false;
            this.encGroupBox.Text = "Encryption";
            this.encGroupBox.UseWaitCursor = true;
            // 
            // decGroupBox
            // 
            this.decGroupBox.Controls.Add(this.TextBoxCOut);
            this.decGroupBox.Controls.Add(this.label3);
            this.decGroupBox.Controls.Add(this.labelKeyOut);
            this.decGroupBox.Controls.Add(this.labelPOut);
            this.decGroupBox.Controls.Add(this.TextBoxKeyOut);
            this.decGroupBox.Controls.Add(this.TextBoxPOut);
            this.decGroupBox.Location = new System.Drawing.Point(320, 10);
            this.decGroupBox.Name = "decGroupBox";
            this.decGroupBox.Size = new System.Drawing.Size(200, 120);
            this.decGroupBox.TabIndex = 53;
            this.decGroupBox.TabStop = false;
            this.decGroupBox.Text = "Decryption";
            this.decGroupBox.UseWaitCursor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 141);
            this.Controls.Add(this.decGroupBox);
            this.Controls.Add(this.encGroupBox);
            this.Controls.Add(this.buttonRESET);
            this.Controls.Add(this.buttonXOR);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Lab03 - XOR Text";
            this.UseWaitCursor = true;
            this.encGroupBox.ResumeLayout(false);
            this.encGroupBox.PerformLayout();
            this.decGroupBox.ResumeLayout(false);
            this.decGroupBox.PerformLayout();
            this.ResumeLayout(false);
        }

        // private System.Windows.Forms.Label labelP;
        // private System.Windows.Forms.Label labelKey;
        // private System.Windows.Forms.Label labelC;

        #endregion
        private System.Windows.Forms.TextBox TextBoxPOut;
        private System.Windows.Forms.TextBox TextBoxKeyOut;
        private System.Windows.Forms.TextBox TextBoxCOut;
        private System.Windows.Forms.Label labelPOut;
        private System.Windows.Forms.Label labelKeyOut;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonRESET;
        private System.Windows.Forms.Button buttonXOR;
        private System.Windows.Forms.TextBox TextBoxCIn;
        private System.Windows.Forms.TextBox TextBoxKeyIn;
        private System.Windows.Forms.TextBox TextBoxPIn;
        private System.Windows.Forms.Label labelC;
        private System.Windows.Forms.Label labelKey;
        private System.Windows.Forms.Label labelP;
        private System.Windows.Forms.GroupBox encGroupBox;
        private System.Windows.Forms.GroupBox decGroupBox;
        private System.Windows.Forms.ToolTip toolTipHEX;
    }
}

