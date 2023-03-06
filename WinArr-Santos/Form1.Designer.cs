namespace WinArr_Santos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SetBtextBox = new System.Windows.Forms.TextBox();
            this.SetAtextBox = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.Intersectionlbl = new System.Windows.Forms.Label();
            this.Differencelbl = new System.Windows.Forms.Label();
            this.SymmetricalDifferencelbl = new System.Windows.Forms.Label();
            this.Unionlbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Set A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Set B";
            // 
            // SetBtextBox
            // 
            this.SetBtextBox.Location = new System.Drawing.Point(146, 88);
            this.SetBtextBox.Name = "SetBtextBox";
            this.SetBtextBox.Size = new System.Drawing.Size(186, 20);
            this.SetBtextBox.TabIndex = 1;
            // 
            // SetAtextBox
            // 
            this.SetAtextBox.Location = new System.Drawing.Point(146, 52);
            this.SetAtextBox.Name = "SetAtextBox";
            this.SetAtextBox.Size = new System.Drawing.Size(186, 20);
            this.SetAtextBox.TabIndex = 1;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(73, 160);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(111, 24);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Intersection";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(73, 190);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(101, 24);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Difference";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.Location = new System.Drawing.Point(73, 220);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(191, 24);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Symmetrical Difference";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton4.Location = new System.Drawing.Point(73, 250);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(69, 24);
            this.radioButton4.TabIndex = 2;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Union";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // Intersectionlbl
            // 
            this.Intersectionlbl.AutoSize = true;
            this.Intersectionlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Intersectionlbl.Location = new System.Drawing.Point(281, 162);
            this.Intersectionlbl.Name = "Intersectionlbl";
            this.Intersectionlbl.Size = new System.Drawing.Size(51, 20);
            this.Intersectionlbl.TabIndex = 3;
            this.Intersectionlbl.Text = "label3";
            // 
            // Differencelbl
            // 
            this.Differencelbl.AutoSize = true;
            this.Differencelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Differencelbl.Location = new System.Drawing.Point(281, 192);
            this.Differencelbl.Name = "Differencelbl";
            this.Differencelbl.Size = new System.Drawing.Size(51, 20);
            this.Differencelbl.TabIndex = 3;
            this.Differencelbl.Text = "label4";
            // 
            // SymmetricalDifferencelbl
            // 
            this.SymmetricalDifferencelbl.AutoSize = true;
            this.SymmetricalDifferencelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SymmetricalDifferencelbl.Location = new System.Drawing.Point(281, 222);
            this.SymmetricalDifferencelbl.Name = "SymmetricalDifferencelbl";
            this.SymmetricalDifferencelbl.Size = new System.Drawing.Size(51, 20);
            this.SymmetricalDifferencelbl.TabIndex = 3;
            this.SymmetricalDifferencelbl.Text = "label5";
            // 
            // Unionlbl
            // 
            this.Unionlbl.AutoSize = true;
            this.Unionlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Unionlbl.Location = new System.Drawing.Point(281, 252);
            this.Unionlbl.Name = "Unionlbl";
            this.Unionlbl.Size = new System.Drawing.Size(51, 20);
            this.Unionlbl.TabIndex = 3;
            this.Unionlbl.Text = "label6";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Unionlbl);
            this.Controls.Add(this.SymmetricalDifferencelbl);
            this.Controls.Add(this.Differencelbl);
            this.Controls.Add(this.Intersectionlbl);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.SetAtextBox);
            this.Controls.Add(this.SetBtextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SetBtextBox;
        private System.Windows.Forms.TextBox SetAtextBox;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Label Intersectionlbl;
        private System.Windows.Forms.Label Differencelbl;
        private System.Windows.Forms.Label SymmetricalDifferencelbl;
        private System.Windows.Forms.Label Unionlbl;
    }
}

