using System;

namespace Exemplo_EplayersMvc.Models
{
    public class Partida
    {
        public int IdPartida { get; set;}
        public int IdJogador1 { get; set;}
        public int IdJogador2 { get; set;}
        public DateTime HorarioInicio { get; set; }
        public DateTime HorarioTermino{ get; set; }
    }
}