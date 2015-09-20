namespace Ejercicios
{
    partial class Ejercicio2C6
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
            this.calificacionListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.promedioTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.menorTextBox = new System.Windows.Forms.TextBox();
            this.calcularButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // calificacionListBox
            // 
            this.calificacionListBox.FormattingEnabled = true;
            this.calificacionListBox.Location = new System.Drawing.Point(12, 28);
            this.calificacionListBox.Name = "calificacionListBox";
            this.calificacionListBox.Size = new System.Drawing.Size(719, 95);
            this.calificacionListBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Promedio";
            // 
            // promedioTextBox
            // 
            this.promedioTextBox.Location = new System.Drawing.Point(66, 141);
            this.promedioTextBox.Name = "promedioTextBox";
            this.promedioTextBox.ReadOnly = true;
            this.promedioTextBox.Size = new System.Drawing.Size(100, 20);
            this.promedioTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(213, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Menor";
            // 
            // menorTextBox
            // 
            this.menorTextBox.Location = new System.Drawing.Point(268, 141);
            this.menorTextBox.Name = "menorTextBox";
            this.menorTextBox.ReadOnly = true;
            this.menorTextBox.Size = new System.Drawing.Size(100, 20);
            this.menorTextBox.TabIndex = 4;
            // 
            // calcularButton
            // 
            this.calcularButton.Location = new System.Drawing.Point(293, 205);
            this.calcularButton.Name = "calcularButton";
            this.calcularButton.Size = new System.Drawing.Size(75, 23);
            this.calcularButton.TabIndex = 5;
            this.calcularButton.Text = "Calcular";
            this.calcularButton.UseVisualStyleBackColor = true;
            this.calcularButton.Click += new System.EventHandler(this.calcularButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(254, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Calcula el promedio  y el menor ";
            // 
            // Ejercicio2C6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 261);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.calcularButton);
            this.Controls.Add(this.menorTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.promedioTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calificacionListBox);
            this.Name = "Ejercicio2C6";
            this.Text = "Ejercicio 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox calificacionListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox promedioTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox menorTextBox;
        private System.Windows.Forms.Button calcularButton;
        private System.Windows.Forms.Label label3;
    }
}