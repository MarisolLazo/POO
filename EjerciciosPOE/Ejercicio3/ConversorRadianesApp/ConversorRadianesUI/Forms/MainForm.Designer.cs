namespace ConversorRadianesUI
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
            components = new System.ComponentModel.Container();
            anguloTextBox = new TextBox();
            calculateSecantButton = new Button();
            degreeResultsLabel = new Label();
            radiansResultsLabel = new Label();
            label1 = new Label();
            angleLabel = new Label();
            validationErrorProvider = new ErrorProvider(components);
            angleErrorLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)validationErrorProvider).BeginInit();
            SuspendLayout();
            // 
            // anguloTextBox
            // 
            anguloTextBox.BackColor = SystemColors.InactiveCaption;
            anguloTextBox.Location = new Point(261, 138);
            anguloTextBox.Margin = new Padding(5, 4, 5, 4);
            anguloTextBox.Name = "anguloTextBox";
            anguloTextBox.Size = new Size(210, 29);
            anguloTextBox.TabIndex = 0;
            anguloTextBox.Validating += anguloTextBox_Validating;
            // 
            // calculateSecantButton
            // 
            calculateSecantButton.BackColor = Color.Cyan;
            calculateSecantButton.Location = new Point(283, 197);
            calculateSecantButton.Margin = new Padding(5, 4, 5, 4);
            calculateSecantButton.Name = "calculateSecantButton";
            calculateSecantButton.Size = new Size(160, 111);
            calculateSecantButton.TabIndex = 1;
            calculateSecantButton.Text = "Calcular Secante";
            calculateSecantButton.UseVisualStyleBackColor = false;
            calculateSecantButton.MouseClick += calculateSecantButton_MouseClick;
            calculateSecantButton.MouseLeave += calculateSecantButton_MouseLeave;
            calculateSecantButton.MouseHover += calculateSecantButton_MouseHover;
            // 
            // degreeResultsLabel
            // 
            degreeResultsLabel.AutoSize = true;
            degreeResultsLabel.Location = new Point(102, 335);
            degreeResultsLabel.Margin = new Padding(5, 0, 5, 0);
            degreeResultsLabel.Name = "degreeResultsLabel";
            degreeResultsLabel.Size = new Size(0, 22);
            degreeResultsLabel.TabIndex = 2;
            // 
            // radiansResultsLabel
            // 
            radiansResultsLabel.AutoSize = true;
            radiansResultsLabel.Location = new Point(416, 335);
            radiansResultsLabel.Margin = new Padding(5, 0, 5, 0);
            radiansResultsLabel.Name = "radiansResultsLabel";
            radiansResultsLabel.Size = new Size(0, 22);
            radiansResultsLabel.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(189, 43);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(405, 22);
            label1.TabIndex = 4;
            label1.Text = "CALCULADORA DE SECANTES Y RADIANES";
            // 
            // angleLabel
            // 
            angleLabel.AutoSize = true;
            angleLabel.Location = new Point(102, 109);
            angleLabel.Name = "angleLabel";
            angleLabel.Size = new Size(504, 22);
            angleLabel.TabIndex = 5;
            angleLabel.Text = "Ingrese el angulo secante para convertirla a radianes y grados";
            // 
            // validationErrorProvider
            // 
            validationErrorProvider.ContainerControl = this;
            // 
            // angleErrorLabel
            // 
            angleErrorLabel.AutoSize = true;
            angleErrorLabel.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            angleErrorLabel.ForeColor = Color.Red;
            angleErrorLabel.Location = new Point(261, 171);
            angleErrorLabel.Name = "angleErrorLabel";
            angleErrorLabel.Size = new Size(0, 19);
            angleErrorLabel.TabIndex = 6;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(741, 436);
            Controls.Add(angleErrorLabel);
            Controls.Add(angleLabel);
            Controls.Add(label1);
            Controls.Add(radiansResultsLabel);
            Controls.Add(degreeResultsLabel);
            Controls.Add(calculateSecantButton);
            Controls.Add(anguloTextBox);
            Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 4, 5, 4);
            Name = "MainForm";
            Text = "CalculadorForm";
            FormClosing += MainForm_FormClosing;
            ((System.ComponentModel.ISupportInitialize)validationErrorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox anguloTextBox;
        private Button calculateSecantButton;
        private Label degreeResultsLabel;
        private Label radiansResultsLabel;
        private Label label1;
        private Label angleLabel;
        private ErrorProvider validationErrorProvider;
        private Label angleErrorLabel;
    }
}
