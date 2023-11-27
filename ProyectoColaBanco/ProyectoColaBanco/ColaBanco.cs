using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoColaBanco
{
    internal class ColaBanco
    {
        //Colas
        //Niveles de Prioridad
        
        //Alta Prioridad
        public Queue <Cliente> ColaCiudadanoOro = new Queue<Cliente>();
        
        //Media Alta Priodidad
        public Queue <Cliente> ColaCreditosBancarios = new Queue<Cliente>();
        
        //Media Baja Priodidad
        public Queue <Cliente> ColaPlataforma = new Queue<Cliente>();
        
        //Baja Prioridad
        public Queue <Cliente> ColaTramiteUnico = new Queue<Cliente>();
    }
}
