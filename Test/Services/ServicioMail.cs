using System.Net.Mail;
using System.Net;
using Test.Models;

namespace Test.Services
{
    public class ServicioMail : IServicioEmail
    {
        public void EnviarCorreo(ModelTest model, int score)
        {
            string message;

            message = "Nombre: " + model.Nombre + "\n";
            message += "Pregunta 1: " + model.Pregunta1 + "\n";
            message += "Pregunta 2: " + model.Pregunta2 + "\n";
            message += "Pregunta 3: " + model.Pregunta3 + "\n";
            message += "Pregunta 4: " + model.Pregunta4 + "\n";
            message += "Pregunta 5: " + model.Pregunta5 + "\n";
            message += "Pregunta 6: " + model.Pregunta6 + "\n";
            message += "Pregunta 7: " + model.Pregunta7 + "\n";
            message += "Pregunta 8: " + model.Pregunta8 + "\n";
            message += "Pregunta 9: " + model.Pregunta9 + "\n";
            message += "Pregunta 10: " + model.Pregunta10 + "\n";

            message += "Puntuación: " + score + "\n\n";
            if (score >= 30)
                message += "Resultado: Tienes una autoestima Elevada: Es considerado una autoestima normal, dentro de los " +
                    "parametros normales, esto no quiere decir que seas el mejor en todo.\n";
            else if (score >= 25)
                message += "Resultado: Tienes una autoestima media: No representas problemas de autoestima graves " +
                    "pero es conveniente que trates de mejorar.\n";
            else
                message += "Resultado: Tienes una autoestima baja: Esto quiere decir que tienes" +
                    "problemas significativos de autoestima. La mejor recomendacion es que trates de mejorar" +
                    "en aquello que sientes que tines dificultades.\n";


            // Crea un nuevo objeto MailMessage
            MailMessage mail = new MailMessage("test@mailtrap.io", model.Correo);
            mail.Subject = "Resultado del Test de Autoestima";
            mail.Body = message;

            // Crea un nuevo SmtpClient
            SmtpClient client = new SmtpClient("smtp.mailtrap.io");
            client.Port = 587;
            client.Credentials = new NetworkCredential("Usuario", "Paswoord");
            client.EnableSsl = true;

            try
            {
                client.Send(mail); // Enviar el correo electrónico
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}
