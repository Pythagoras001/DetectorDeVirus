using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_Antivirus01.Modelos
{

    /*
    * CLASE: VIRUS
    * DESARROLLADORES: THOMAS_GOMEZ 
    * FECHA: 25/08/2025
    * 
    * ESTRUCTURA:
    * Parámetros
    *  -_diccVirus
    * Métodos
    *  +DiccVirus
    *  +AgregarSecuencia
    *  +eliminarSecuencia
    *  
    * La clase Virus gestiona un diccionario de secuencias de bytes que representan firmas de diferentes virus.
    * Cada entrada del diccionario asocia un nombre de virus (string) con su respectiva secuencia (byte[]).
    * Proporciona métodos para acceder al diccionario, agregar nuevas secuencias con un nombre específico y 
    * eliminar secuencias existentes, asegurando la validez de los datos y evitando duplicados.
    */

    public class Virus
    {
        // Creamos los atributos de estado
        private Dictionary<string, byte[]> _diccVirus = new Dictionary<string, byte[]>
        {
            { "Usama", new byte[] {15, 30, 15, 49 }},
            { "Amtrax", new byte[] {72, 72, 15, 29 }},
            { "éBola", new byte[] {29, 32, 53, 29 }},
            { "Ah1N1", new byte[] {72, 32, 32, 20 }},
            { "Covid19", new byte[] {30, 25, 20, 19 }}
        };

        // Creamos el constructor
        public Virus() { }

        // Creamos el accesor
        public Dictionary<string, byte[]> DiccVirus { get => _diccVirus;}

        // Creamos un metodo para agregar una nueva secuencia
        public void AgregarSecuencia(byte[] newSecuencia, string newNombre)
        {
            if (newSecuencia.Length > 4 || newSecuencia.Length <= 0) 
                throw new Exception("Secuencia Invalida");

            if (DiccVirus.ContainsKey(newNombre)) throw new Exception("La secuencia ya exite");

            _diccVirus.Add(newNombre, newSecuencia);
        }

        // Creamos un metodo para eliminar una secuencia
        public void eliminarSecuencia(string nameVirus)
        {
            if (!(DiccVirus.ContainsKey(nameVirus))) throw new Exception("El virus no exite");

            _diccVirus.Remove(nameVirus);
        }
    }
}
