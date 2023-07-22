using System.ComponentModel.DataAnnotations;

namespace Test.Models
{
    public class ModelTest
    {
        [Required(ErrorMessage = "El nombre es requerido.")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El correo es requerido.")]
        [EmailAddress(ErrorMessage = "El correo no es válido.")]
        public string Correo { get; set; }


        [Range(1, int.MaxValue, ErrorMessage = "La pregunta 1 es requerida.")]
        public int Pregunta1 { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "La pregunta 2 es requerida.")]
        public int Pregunta2 { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "La pregunta 3 es requerida.")]
        public int Pregunta3 { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "La pregunta 4 es requerida.")]
        public int Pregunta4 { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "La pregunta 5 es requerida.")]
        public int Pregunta5 { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "La pregunta 6 es requerida.")]
        public int Pregunta6 { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "La pregunta 7 es requerida.")]
        public int Pregunta7 { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "La pregunta 8 es requerida.")]
        public int Pregunta8 { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "La pregunta 9 es requerida.")]
        public int Pregunta9 { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "La pregunta 10 es requerida.")]
        public int Pregunta10 { get; set; }
    }
}
