using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad.src
{
    public static class GeneradorIds
    {
        public static Dictionary<Type, int> _contadores = new Dictionary<Type, int>();

        public static int ObtenerNuevoId(Type tipo)
        {
            if (!_contadores.ContainsKey(tipo))
            {
                _contadores[tipo] = 0; // Inicializar el contador para este tipo
            }

            _contadores[tipo]++; // Incrementar el contador
            return _contadores[tipo]; // Retornar el nuevo ID
        }
    }
}
