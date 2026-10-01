using FactoryPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.Notificadores
{
    public class SmsNotificador : INotificador
    {
        public void Enviar(string mensaje)
        {
            Console.WriteLine($"[SMS] {mensaje}");
        }
    }
}
