using System.Collections.Generic;

namespace atividade_iii.Models
{
    public class ListaAgendamento
    {
        private static List<Agendamento> agenda = new List<Agendamento>();


        public static void incluir(Agendamento lista){
            agenda.Add(lista);
        }
        public static List<Agendamento> listar(){
            return agenda;
        }
    }
}