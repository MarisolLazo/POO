const nodemailer = require('nodemailer');

class EmailSender {
  constructor() {
    // Configurar el transporte de correo
    this.transporter = nodemailer.createTransport({
      service: 'smtp-mail.outlook.com',
      auth: {
        user: 'marisollazo2005@outlook.com',
        pass: '12345678M10L'
      }
    });
  }

  // Método para enviar un correo electrónico
  sendEmail() {
    const mailOptions = {
      from: 'marisollazo2005@outlook.com',
      to: 'j.william03@hotmail.com',
      subject: 'Pude Ing',
      text: 'Ya tengo mi tarea vista para subir'
    };

    // Enviar el correo electrónico
    this.transporter.sendMail(mailOptions, (error, info) => {
      if (error) {
        console.log('Error al enviar el correo electrónico:', error);
      } else {
        console.log('Correo electrónico enviado:', info.response);
      }
    });
  }
}

// Crear una instancia de la clase EmailSender
const emailSender = new EmailSender();


emailSender.sendEmail(to, subject, message);



