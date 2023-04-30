using System;

namespace Server
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.time_Label = new System.Windows.Forms.Label();
            this.panelView = new System.Windows.Forms.Panel();
            this.timer1 = new System.Timers.Timer();
            this.panelMenu.SuspendLayout();
            this.panelView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timer1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.Purple;
            this.panelMenu.Controls.Add(this.button4);
            this.panelMenu.Controls.Add(this.button3);
            this.panelMenu.Controls.Add(this.button2);
            this.panelMenu.Controls.Add(this.button1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 450);
            this.panelMenu.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button4.Location = new System.Drawing.Point(12, 324);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(170, 76);
            this.button4.TabIndex = 3;
            this.button4.Text = "Добавить учеников";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button3.Location = new System.Drawing.Point(12, 230);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(170, 76);
            this.button3.TabIndex = 2;
            this.button3.Text = "Удалить группу";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button2.Location = new System.Drawing.Point(12, 139);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(170, 76);
            this.button2.TabIndex = 1;
            this.button2.Text = "Создать группу";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button1.Location = new System.Drawing.Point(12, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 76);
            this.button1.TabIndex = 0;
            this.button1.Text = "Провести урок";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // time_Label
            // 
            this.time_Label.AutoSize = true;
            this.time_Label.BackColor = System.Drawing.Color.Transparent;
            this.time_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.time_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(73)))));
            this.time_Label.Location = new System.Drawing.Point(167, 9);
            this.time_Label.Name = "time_Label";
            this.time_Label.Size = new System.Drawing.Size(0, 32);
            this.time_Label.TabIndex = 1;
            // 
            // panelView
            // 
            this.panelView.Controls.Add(this.time_Label);
            this.panelView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelView.Location = new System.Drawing.Point(200, 0);
            this.panelView.Name = "panelView";
            this.panelView.Size = new System.Drawing.Size(600, 450);
            this.panelView.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000D;
            this.timer1.SynchronizingObject = this;
            this.timer1.Elapsed += new System.Timers.ElapsedEventHandler(this.timer1_Elapsed);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(43)))), ((int)(((byte)(122)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelView);
            this.Controls.Add(this.panelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelView.ResumeLayout(false);
            this.panelView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timer1)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Timers.Timer timer1;

        private System.Windows.Forms.Panel panelView;

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label time_Label;

        private System.Windows.Forms.Panel panelMenu;

        #endregion
    }
}