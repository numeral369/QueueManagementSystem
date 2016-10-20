using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Senhas_teste.Models
{
    public class SenhaModel
    {
        public enum Tipo { A, B, C, D, E };
        public enum Estado { NaoCHAMADA, ATENDIDA, CANCELADA, REDIRECIONADA};

        public int ID { get; set; }
        public Tipo TipoDeSenha { get; set; }
        public Estado EstadoDeAtendimento { get; set; }
        public DateTime DataDeEmissao { get; set; }
        public int NumeroDaSenha { get; set; }
    }
}