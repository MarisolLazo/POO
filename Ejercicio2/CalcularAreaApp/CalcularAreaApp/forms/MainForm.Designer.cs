namespace CalcularAreaApp
{
    partial class MainForm
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
            calcularAreaLabel = new Label();
            elipseButton = new Button();
            paralelogramoButton = new Button();
            SuspendLayout();
            // 
            // calcularAreaLabel
            // 
            calcularAreaLabel.AutoSize = true;
            calcularAreaLabel.Location = new Point(323, 19);
            calcularAreaLabel.Name = "calcularAreaLabel";
            calcularAreaLabel.Size = new Size(82, 15);
            calcularAreaLabel.TabIndex = 0;
            calcularAreaLabel.Text = "Calcular Areas";
            // 
            // elipseButton
            // 
            elipseButton.Location = new Point(81, 93);
            elipseButton.Name = "elipseButton";
            elipseButton.Size = new Size(234, 111);
            elipseButton.TabIndex = 1;
            elipseButton.Text = "Area Elipse";
            elipseButton.UseVisualStyleBackColor = true;
            elipseButton.Click += elipseButton_Click;
            // 
            // paralelogramoButton
            // 
            paralelogramoButton.Location = new Point(401, 93);
            paralelogramoButton.Name = "paralelogramoButton";
            paralelogramoButton.Size = new Size(234, 111);
            paralelogramoButton.TabIndex = 2;
            paralelogramoButton.Text = "Area Paralelogramo";
            paralelogramoButton.UseVisualStyleBackColor = true;
            paralelogramoButton.Click += paralelogramoButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(paralelogramoButton);
            Controls.Add(elipseButton);
            Controls.Add(calcularAreaLabel);
            Name = "MainForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label calcularAreaLabel;
        private Button elipseButton;
        private Button paralelogramoButton;
    }
}
