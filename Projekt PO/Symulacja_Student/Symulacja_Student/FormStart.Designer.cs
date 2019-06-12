namespace Symulacja_Student
{
    partial class FormStart
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
            this.labelData = new System.Windows.Forms.Label();
            this.labelSpryt = new System.Windows.Forms.Label();
            this.textBoxSpryt = new System.Windows.Forms.TextBox();
            this.textBoxZmeczenie = new System.Windows.Forms.TextBox();
            this.labelZmeczenie = new System.Windows.Forms.Label();
            this.textBoxWiedza = new System.Windows.Forms.TextBox();
            this.textBoxPrzyswajanieWiedzy = new System.Windows.Forms.TextBox();
            this.labelWiedza = new System.Windows.Forms.Label();
            this.labelPrzyswajanieWiedzy = new System.Windows.Forms.Label();
            this.buttonSimulation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelData.Location = new System.Drawing.Point(151, 28);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(503, 44);
            this.labelData.TabIndex = 0;
            this.labelData.Text = "Wprowadź dane początkowe";
            // 
            // labelSpryt
            // 
            this.labelSpryt.AutoSize = true;
            this.labelSpryt.Location = new System.Drawing.Point(190, 124);
            this.labelSpryt.Name = "labelSpryt";
            this.labelSpryt.Size = new System.Drawing.Size(41, 17);
            this.labelSpryt.TabIndex = 1;
            this.labelSpryt.Text = "Spryt";
            // 
            // textBoxSpryt
            // 
            this.textBoxSpryt.Location = new System.Drawing.Point(341, 124);
            this.textBoxSpryt.Name = "textBoxSpryt";
            this.textBoxSpryt.Size = new System.Drawing.Size(100, 22);
            this.textBoxSpryt.TabIndex = 2;
            // 
            // textBoxZmeczenie
            // 
            this.textBoxZmeczenie.Location = new System.Drawing.Point(341, 170);
            this.textBoxZmeczenie.Name = "textBoxZmeczenie";
            this.textBoxZmeczenie.Size = new System.Drawing.Size(100, 22);
            this.textBoxZmeczenie.TabIndex = 3;
            // 
            // labelZmeczenie
            // 
            this.labelZmeczenie.AutoSize = true;
            this.labelZmeczenie.Location = new System.Drawing.Point(190, 170);
            this.labelZmeczenie.Name = "labelZmeczenie";
            this.labelZmeczenie.Size = new System.Drawing.Size(77, 17);
            this.labelZmeczenie.TabIndex = 4;
            this.labelZmeczenie.Text = "Zmęczenie";
            // 
            // textBoxWiedza
            // 
            this.textBoxWiedza.Location = new System.Drawing.Point(341, 213);
            this.textBoxWiedza.Name = "textBoxWiedza";
            this.textBoxWiedza.Size = new System.Drawing.Size(100, 22);
            this.textBoxWiedza.TabIndex = 5;
            // 
            // textBoxPrzyswajanieWiedzy
            // 
            this.textBoxPrzyswajanieWiedzy.Location = new System.Drawing.Point(341, 256);
            this.textBoxPrzyswajanieWiedzy.Name = "textBoxPrzyswajanieWiedzy";
            this.textBoxPrzyswajanieWiedzy.Size = new System.Drawing.Size(100, 22);
            this.textBoxPrzyswajanieWiedzy.TabIndex = 6;
            // 
            // labelWiedza
            // 
            this.labelWiedza.AutoSize = true;
            this.labelWiedza.Location = new System.Drawing.Point(190, 213);
            this.labelWiedza.Name = "labelWiedza";
            this.labelWiedza.Size = new System.Drawing.Size(55, 17);
            this.labelWiedza.TabIndex = 7;
            this.labelWiedza.Text = "Wiedza";
            // 
            // labelPrzyswajanieWiedzy
            // 
            this.labelPrzyswajanieWiedzy.AutoSize = true;
            this.labelPrzyswajanieWiedzy.Location = new System.Drawing.Point(190, 256);
            this.labelPrzyswajanieWiedzy.Name = "labelPrzyswajanieWiedzy";
            this.labelPrzyswajanieWiedzy.Size = new System.Drawing.Size(140, 17);
            this.labelPrzyswajanieWiedzy.TabIndex = 8;
            this.labelPrzyswajanieWiedzy.Text = "Przyswajanie Wiedzy";
            // 
            // buttonSimulation
            // 
            this.buttonSimulation.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSimulation.Location = new System.Drawing.Point(289, 322);
            this.buttonSimulation.Name = "buttonSimulation";
            this.buttonSimulation.Size = new System.Drawing.Size(228, 71);
            this.buttonSimulation.TabIndex = 9;
            this.buttonSimulation.Text = "Rozpocznij symulację";
            this.buttonSimulation.UseVisualStyleBackColor = true;
            this.buttonSimulation.Click += new System.EventHandler(this.ButtonSimulation_Click);
            // 
            // FormStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSimulation);
            this.Controls.Add(this.labelPrzyswajanieWiedzy);
            this.Controls.Add(this.labelWiedza);
            this.Controls.Add(this.textBoxPrzyswajanieWiedzy);
            this.Controls.Add(this.textBoxWiedza);
            this.Controls.Add(this.labelZmeczenie);
            this.Controls.Add(this.textBoxZmeczenie);
            this.Controls.Add(this.textBoxSpryt);
            this.Controls.Add(this.labelSpryt);
            this.Controls.Add(this.labelData);
            this.Name = "FormStart";
            this.Text = "FormStart";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.Label labelSpryt;
        private System.Windows.Forms.TextBox textBoxSpryt;
        private System.Windows.Forms.TextBox textBoxZmeczenie;
        private System.Windows.Forms.Label labelZmeczenie;
        private System.Windows.Forms.TextBox textBoxWiedza;
        private System.Windows.Forms.TextBox textBoxPrzyswajanieWiedzy;
        private System.Windows.Forms.Label labelWiedza;
        private System.Windows.Forms.Label labelPrzyswajanieWiedzy;
        private System.Windows.Forms.Button buttonSimulation;
    }
}