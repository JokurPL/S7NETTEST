
namespace S7NETTEST
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ipLabel = new System.Windows.Forms.TextBox();
            this.connectBtn = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.connectPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.onVar1 = new System.Windows.Forms.Button();
            this.offVar1 = new System.Windows.Forms.Button();
            this.offVar2 = new System.Windows.Forms.Button();
            this.onVar2 = new System.Windows.Forms.Button();
            this.offVar3 = new System.Windows.Forms.Button();
            this.onVar3 = new System.Windows.Forms.Button();
            this.stateVar1 = new System.Windows.Forms.Label();
            this.controlPanel = new System.Windows.Forms.Panel();
            this.stateVar2 = new System.Windows.Forms.Label();
            this.stateVar3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.connectPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.controlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(321, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Test S7Net+";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(353, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "© Mateusz Pietrzak";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Gainsboro;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(93, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "PLC IP:";
            // 
            // ipLabel
            // 
            this.ipLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ipLabel.Location = new System.Drawing.Point(14, 67);
            this.ipLabel.Name = "ipLabel";
            this.ipLabel.Size = new System.Drawing.Size(277, 31);
            this.ipLabel.TabIndex = 3;
            // 
            // connectBtn
            // 
            this.connectBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.connectBtn.Location = new System.Drawing.Point(14, 119);
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Size = new System.Drawing.Size(277, 49);
            this.connectBtn.TabIndex = 4;
            this.connectBtn.Text = "Połącz";
            this.connectBtn.UseVisualStyleBackColor = true;
            this.connectBtn.Click += new System.EventHandler(this.connectBtn_Click);
            // 
            // colorDialog1
            // 
            this.colorDialog1.Color = System.Drawing.Color.LightSeaGreen;
            // 
            // connectPanel
            // 
            this.connectPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.connectPanel.Controls.Add(this.connectBtn);
            this.connectPanel.Controls.Add(this.ipLabel);
            this.connectPanel.Controls.Add(this.label3);
            this.connectPanel.Location = new System.Drawing.Point(26, 168);
            this.connectPanel.Name = "connectPanel";
            this.connectPanel.Size = new System.Drawing.Size(301, 196);
            this.connectPanel.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.offVar1);
            this.panel2.Controls.Add(this.onVar1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(32, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(170, 196);
            this.panel2.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.offVar2);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.onVar2);
            this.panel3.Location = new System.Drawing.Point(208, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(170, 196);
            this.panel3.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.offVar3);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.onVar3);
            this.panel4.Location = new System.Drawing.Point(384, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(170, 196);
            this.panel4.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lato", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(16, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 33);
            this.label4.TabIndex = 0;
            this.label4.Text = "Zmienna 1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lato", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(13, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 33);
            this.label5.TabIndex = 1;
            this.label5.Text = "Zmienna 2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lato", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(16, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 33);
            this.label6.TabIndex = 2;
            this.label6.Text = "Zmienna 3";
            // 
            // onVar1
            // 
            this.onVar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.onVar1.Font = new System.Drawing.Font("Lato", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.onVar1.Location = new System.Drawing.Point(14, 59);
            this.onVar1.Name = "onVar1";
            this.onVar1.Size = new System.Drawing.Size(132, 43);
            this.onVar1.TabIndex = 1;
            this.onVar1.Text = "ZAŁĄCZ";
            this.onVar1.UseVisualStyleBackColor = false;
            this.onVar1.Click += new System.EventHandler(this.onVar1_Click);
            // 
            // offVar1
            // 
            this.offVar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.offVar1.Font = new System.Drawing.Font("Lato", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.offVar1.Location = new System.Drawing.Point(14, 118);
            this.offVar1.Name = "offVar1";
            this.offVar1.Size = new System.Drawing.Size(132, 43);
            this.offVar1.TabIndex = 2;
            this.offVar1.Text = "WYŁĄCZ";
            this.offVar1.UseVisualStyleBackColor = false;
            this.offVar1.Click += new System.EventHandler(this.offVar1_Click);
            // 
            // offVar2
            // 
            this.offVar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.offVar2.Font = new System.Drawing.Font("Lato", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.offVar2.Location = new System.Drawing.Point(19, 118);
            this.offVar2.Name = "offVar2";
            this.offVar2.Size = new System.Drawing.Size(132, 43);
            this.offVar2.TabIndex = 4;
            this.offVar2.Text = "WYŁĄCZ";
            this.offVar2.UseVisualStyleBackColor = false;
            this.offVar2.Click += new System.EventHandler(this.offVar2_Click);
            // 
            // onVar2
            // 
            this.onVar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.onVar2.Font = new System.Drawing.Font("Lato", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.onVar2.Location = new System.Drawing.Point(19, 59);
            this.onVar2.Name = "onVar2";
            this.onVar2.Size = new System.Drawing.Size(132, 43);
            this.onVar2.TabIndex = 3;
            this.onVar2.Text = "ZAŁĄCZ";
            this.onVar2.UseVisualStyleBackColor = false;
            this.onVar2.Click += new System.EventHandler(this.onVar2_Click);
            // 
            // offVar3
            // 
            this.offVar3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.offVar3.Font = new System.Drawing.Font("Lato", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.offVar3.Location = new System.Drawing.Point(18, 118);
            this.offVar3.Name = "offVar3";
            this.offVar3.Size = new System.Drawing.Size(132, 43);
            this.offVar3.TabIndex = 6;
            this.offVar3.Text = "WYŁĄCZ";
            this.offVar3.UseVisualStyleBackColor = false;
            this.offVar3.Click += new System.EventHandler(this.offVar3_Click);
            // 
            // onVar3
            // 
            this.onVar3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.onVar3.Font = new System.Drawing.Font("Lato", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.onVar3.Location = new System.Drawing.Point(18, 59);
            this.onVar3.Name = "onVar3";
            this.onVar3.Size = new System.Drawing.Size(132, 43);
            this.onVar3.TabIndex = 5;
            this.onVar3.Text = "ZAŁĄCZ";
            this.onVar3.UseVisualStyleBackColor = false;
            this.onVar3.Click += new System.EventHandler(this.onVar3_Click);
            // 
            // stateVar1
            // 
            this.stateVar1.AutoSize = true;
            this.stateVar1.Font = new System.Drawing.Font("Lato", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.stateVar1.Location = new System.Drawing.Point(40, 202);
            this.stateVar1.Name = "stateVar1";
            this.stateVar1.Size = new System.Drawing.Size(95, 42);
            this.stateVar1.TabIndex = 9;
            this.stateVar1.Text = "Stan:";
            // 
            // controlPanel
            // 
            this.controlPanel.Controls.Add(this.stateVar3);
            this.controlPanel.Controls.Add(this.stateVar2);
            this.controlPanel.Controls.Add(this.stateVar1);
            this.controlPanel.Controls.Add(this.panel2);
            this.controlPanel.Controls.Add(this.panel4);
            this.controlPanel.Controls.Add(this.panel3);
            this.controlPanel.Location = new System.Drawing.Point(333, 168);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(564, 319);
            this.controlPanel.TabIndex = 10;
            // 
            // stateVar2
            // 
            this.stateVar2.AutoSize = true;
            this.stateVar2.Font = new System.Drawing.Font("Lato", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.stateVar2.Location = new System.Drawing.Point(221, 202);
            this.stateVar2.Name = "stateVar2";
            this.stateVar2.Size = new System.Drawing.Size(95, 42);
            this.stateVar2.TabIndex = 10;
            this.stateVar2.Text = "Stan:";
            // 
            // stateVar3
            // 
            this.stateVar3.AutoSize = true;
            this.stateVar3.Font = new System.Drawing.Font("Lato", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.stateVar3.Location = new System.Drawing.Point(400, 202);
            this.stateVar3.Name = "stateVar3";
            this.stateVar3.Size = new System.Drawing.Size(95, 42);
            this.stateVar3.TabIndex = 11;
            this.stateVar3.Text = "Stan:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lato", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(48, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 23);
            this.label7.TabIndex = 3;
            this.label7.Text = "M0.0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lato", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(53, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 23);
            this.label8.TabIndex = 4;
            this.label8.Text = "M0.1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lato", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(56, 169);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 23);
            this.label9.TabIndex = 11;
            this.label9.Text = "M0.2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(910, 499);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.connectPanel);
            this.Controls.Add(this.controlPanel);
            this.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Test S7Net+";
            this.connectPanel.ResumeLayout(false);
            this.connectPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.controlPanel.ResumeLayout(false);
            this.controlPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ipLabel;
        private System.Windows.Forms.Button connectBtn;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Panel connectPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button offVar1;
        private System.Windows.Forms.Button onVar1;
        private System.Windows.Forms.Button offVar2;
        private System.Windows.Forms.Button onVar2;
        private System.Windows.Forms.Button offVar3;
        private System.Windows.Forms.Button onVar3;
        private System.Windows.Forms.Label stateVar1;
        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.Label stateVar3;
        private System.Windows.Forms.Label stateVar2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}