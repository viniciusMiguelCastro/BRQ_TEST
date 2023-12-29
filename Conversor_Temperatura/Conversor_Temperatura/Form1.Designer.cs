namespace Conversor_Temperatura
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            calcular_teperatura = new Button();
            temperatura = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)temperatura).BeginInit();
            SuspendLayout();
            // 
            // calcular_teperatura
            // 
            calcular_teperatura.Location = new Point(252, 181);
            calcular_teperatura.Name = "calcular_teperatura";
            calcular_teperatura.Size = new Size(150, 29);
            calcular_teperatura.TabIndex = 0;
            calcular_teperatura.Text = "Calcular";
            calcular_teperatura.UseVisualStyleBackColor = true;
            calcular_teperatura.Click += calcular_teperatura_Click;
            // 
            // temperatura
            // 
            temperatura.DecimalPlaces = 2;
            temperatura.Location = new Point(252, 111);
            temperatura.Name = "temperatura";
            temperatura.Size = new Size(150, 27);
            temperatura.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(temperatura);
            Controls.Add(calcular_teperatura);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)temperatura).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button calcular_teperatura;
        private NumericUpDown temperatura;
    }
}
