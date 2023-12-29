namespace Calculo_de_idade
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
            dataNascimento = new DateTimePicker();
            label1 = new Label();
            dataDesejada = new DateTimePicker();
            label2 = new Label();
            calcular_data = new Button();
            SuspendLayout();
            // 
            // dataNascimento
            // 
            dataNascimento.Format = DateTimePickerFormat.Short;
            dataNascimento.Location = new Point(84, 73);
            dataNascimento.MaxDate = new DateTime(2014, 12, 31, 0, 0, 0, 0);
            dataNascimento.Name = "dataNascimento";
            dataNascimento.Size = new Size(173, 27);
            dataNascimento.TabIndex = 0;
            dataNascimento.Value = new DateTime(2014, 12, 31, 0, 0, 0, 0);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(84, 40);
            label1.Name = "label1";
            label1.Size = new Size(153, 20);
            label1.TabIndex = 1;
            label1.Text = "Quando você nasceu?";
            // 
            // dataDesejada
            // 
            dataDesejada.Format = DateTimePickerFormat.Short;
            dataDesejada.Location = new Point(373, 73);
            dataDesejada.Name = "dataDesejada";
            dataDesejada.Size = new Size(133, 27);
            dataDesejada.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(373, 40);
            label2.Name = "label2";
            label2.Size = new Size(270, 20);
            label2.TabIndex = 3;
            label2.Text = "Informe uma data para saber sua idade";
            // 
            // calcular_data
            // 
            calcular_data.Location = new Point(259, 143);
            calcular_data.Name = "calcular_data";
            calcular_data.Size = new Size(114, 50);
            calcular_data.TabIndex = 4;
            calcular_data.Text = "Calcular Data";
            calcular_data.UseVisualStyleBackColor = true;
            calcular_data.Click += calcular_data_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(710, 355);
            Controls.Add(calcular_data);
            Controls.Add(label2);
            Controls.Add(dataDesejada);
            Controls.Add(label1);
            Controls.Add(dataNascimento);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dataNascimento;
        private Label label1;
        private DateTimePicker dataDesejada;
        private Label label2;
        private Button calcular_data;
    }
}
