namespace ConversorRadianesUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        //Con el siguiente evento haremos que el boton se torne rojo cuando pasemos el mouse sobre el
        private void calculateSecantButton_MouseHover(object sender, EventArgs e)
        {
            calculateSecantButton.BackColor = Color.Red;
        }

        //Con este evento el boton volvera al color celeste cuando quitemos el mouse
        private void calculateSecantButton_MouseLeave(object sender, EventArgs e)
        {
            calculateSecantButton.BackColor = Color.Cyan;
        }

        private void calculateSecantButton_MouseClick(object sender, MouseEventArgs e)
        {
            double angleDegrees;
            try
            {
                double.TryParse(anguloTextBox.Text, out angleDegrees);

                // Convertir el angulo en radianes
                double angleRadians = angleDegrees * (Math.PI / 180);

                // Calculaar ambas secantes
                double secantDegrees = 1 / Math.Cos(angleRadians);
                double secantRadians = 1 / Math.Cos(angleDegrees);

                // Mostrar resultados
                degreeResultsLabel.Text = $"Secante en grados: {Math.Round(secantDegrees, 4)}";
                radiansResultsLabel.Text = $"Secante en radianes: {Math.Round(secantRadians, 4)}";
               
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        //Validaciones
        private void anguloTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(anguloTextBox.Text))
            {
                e.Cancel = true;
                validationErrorProvider.SetError(anguloTextBox, "La edad no debe estar vacio");
                angleErrorLabel.Text = "El angulo debe contener un numero";
                MessageBox.Show("Insertar un numero", "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                anguloTextBox.Focus();
            }
            else if (!double.TryParse(anguloTextBox.Text, out double angle))
            {
                e.Cancel = true;
                validationErrorProvider.SetError(anguloTextBox, "La edad debe ser un numero valido");
                angleErrorLabel.Text = "El angulo debe ser un numero valido";
                MessageBox.Show("Insertar un numero valido", "Error",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Error);
            }
            else
            {
                e.Cancel = false;
                validationErrorProvider.SetError(anguloTextBox, "");
                angleErrorLabel.Text = "";
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }

  
    }
}
