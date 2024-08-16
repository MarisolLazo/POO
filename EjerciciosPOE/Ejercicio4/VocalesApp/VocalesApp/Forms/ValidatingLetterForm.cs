using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VocalesApp.Forms
{
    public partial class ValidatingLetterForm : Form
    {
        public ValidatingLetterForm()
        {
            InitializeComponent();
        }

        private void ValidatingLetterTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                // Definir las vocales que no deben ser permitidas
                char[] vocales = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

                // Verificar si la tecla presionada es una vocal
                if (Array.Exists(vocales, vocal => vocal == (char)e.KeyCode))
                {

                    validatingErrorProvider.SetError(ValidatingLetterTextBox, "No debe ingresar vocales"); ;
                    ValidatingLetterTextBox.Focus();
                    MessageBox.Show("Error", "No puede ingresar vocales",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    // Mostrar el mensaje de advertencia
                 
                  

                    // Eliminar el último carácter ingresado (la vocal)
                    if (ValidatingLetterTextBox.Text.Length > 0)
                    {
                        ValidatingLetterTextBox.Text = ValidatingLetterTextBox.Text.Remove(ValidatingLetterTextBox.Text.Length - 1);
                        ValidatingLetterTextBox.SelectionStart = ValidatingLetterTextBox.Text.Length; // Mover el cursor al final del texto
                        
                        

                    }
                }
                else
                {
                    validatingErrorProvider.Clear();
                }
            }
            catch (Exception ex)
            {
                // Mostrar mensaje de error en caso de excepción
                MessageBox.Show($"Se produjo un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
    }
}
