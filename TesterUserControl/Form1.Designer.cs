using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace TesterUserControl
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            if (disposing)
            {
                moveTimer?.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            marioUc1 = new MarioControlLibrary.MarioUc();
            SuspendLayout();
            // 
            // marioUc1
            // 
            marioUc1.Location = new Point(286, 100);
            marioUc1.Name = "marioUc1";
            marioUc1.Size = new Size(177, 126);
            marioUc1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(marioUc1);
            Name = "Form1";
            Text = "MarioControl";
            ResumeLayout(false);
        }

        private MarioControlLibrary.MarioUc marioUc1;
    }
}