namespace VocalesApp.Forms
{
    partial class ValidatingLetterForm
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            ValidatingLetterTextBox = new TextBox();
            validatingErrorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)validatingErrorProvider).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(249, 25);
            label1.Name = "label1";
            label1.Size = new Size(161, 24);
            label1.TabIndex = 0;
            label1.Text = "Control de Letras";
            // 
            // ValidatingLetterTextBox
            // 
            ValidatingLetterTextBox.Location = new Point(249, 68);
            ValidatingLetterTextBox.Multiline = true;
            ValidatingLetterTextBox.Name = "ValidatingLetterTextBox";
            ValidatingLetterTextBox.Size = new Size(161, 35);
            ValidatingLetterTextBox.TabIndex = 1;
            ValidatingLetterTextBox.KeyUp += ValidatingLetterTextBox_KeyUp;
            // 
            // validatingErrorProvider
            // 
            validatingErrorProvider.ContainerControl = this;
            // 
            // ValidatingLetterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ValidatingLetterTextBox);
            Controls.Add(label1);
            Name = "ValidatingLetterForm";
            Text = "ValidatingLetterForm";
            ((System.ComponentModel.ISupportInitialize)validatingErrorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox ValidatingLetterTextBox;
        private ErrorProvider validatingErrorProvider;
    }
}