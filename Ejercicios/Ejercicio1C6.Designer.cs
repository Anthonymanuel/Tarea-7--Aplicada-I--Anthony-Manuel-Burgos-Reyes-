﻿namespace Ejercicios
{
    partial class Ejercicio1C6
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
            this.calcularButton = new System.Windows.Forms.Button();
            this.calificacionListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.promedioTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // calcularButton
            // 
            this.calcularButton.Location = new System.Drawing.Point(294, 203);
            this.calcularButton.Name = "calcularButton";
            this.calcularButton.Size = new System.Drawing.Size(75, 23);
            this.calcularButton.TabIndex = 2;
            this.calcularButton.Text = "Calcular";
            this.calcularButton.UseVisualStyleBackColor = true;
            this.calcularButton.Click += new System.EventHandler(this.calcularButton_Click);
            // 
            // calificacionListBox
            // 
            this.calificacionListBox.FormattingEnabled = true;
            this.calificacionListBox.Location = new System.Drawing.Point(12, 34);
            this.calificacionListBox.Name = "calificacionListBox";
            this.calificacionListBox.Size = new System.Drawing.Size(719, 95);
            this.calificacionListBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Promedio";
            // 
            // promedioTextBox
            // 
            this.promedioTextBox.Location = new System.Drawing.Point(85, 144);
            this.promedioTextBox.Name = "promedioTextBox";
            this.promedioTextBox.ReadOnly = true;
            this.promedioTextBox.Size = new System.Drawing.Size(100, 20);
            this.promedioTextBox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(239, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Calcula el promedio ";
            // 
            // Ejercicio1C6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 261);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.promedioTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calificacionListBox);
            this.Controls.Add(this.calcularButton);
            this.Name = "Ejercicio1C6";
            this.Text = "Ejercicio 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button calcularButton;
        private System.Windows.Forms.ListBox calificacionListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox promedioTextBox;
        private System.Windows.Forms.Label label2;
    }
}