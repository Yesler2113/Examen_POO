using Test.Models;

namespace Test.Services
{
    public interface IServicioEmail
    {
        void EnviarCorreo(ModelTest model, int score);
    }
}