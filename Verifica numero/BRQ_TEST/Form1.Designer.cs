namespace BRQ_TEST
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
            TXT_TEST = new TextBox();
            BTN_TEST = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // TXT_TEST
            // 
            TXT_TEST.Location = new Point(199, 99);
            TXT_TEST.Name = "TXT_TEST";
            TXT_TEST.Size = new Size(125, 27);
            TXT_TEST.TabIndex = 0;
            // 
            // BTN_TEST
            // 
            BTN_TEST.Location = new Point(199, 152);
            BTN_TEST.Name = "BTN_TEST";
            BTN_TEST.Size = new Size(125, 29);
            BTN_TEST.TabIndex = 1;
            BTN_TEST.Text = "CLIQUE AQUI";
            BTN_TEST.UseVisualStyleBackColor = true;
            BTN_TEST.Click += BTN_TEST_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 102);
            label1.Name = "label1";
            label1.Size = new Size(130, 20);
            label1.TabIndex = 2;
            label1.Text = "Digite um número";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(501, 307);
            Controls.Add(label1);
            Controls.Add(BTN_TEST);
            Controls.Add(TXT_TEST);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TXT_TEST;
        private Button BTN_TEST;
        private Label label1;
    }
}
