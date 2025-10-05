using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using p_Antivirus01.Modelos;

namespace p_Antivirus01.Controladores
{

    /*
    * CLASE: ANALIZADOR
    * DESARROLLADORES: THOMAS_GOMEZ 
    * FECHA: 16/08/2025
    * 
    * ESTRUCTURA:
    * Parámetros
    *  -_infoByteFile
    *  -_virus
    * Métodos
    *  +InfoByteFile
    *  +Virus
    *  +AnarlizarTipoVirus
    *  -HashearArray
    *  
    * La clase Analizador se encarga de procesar un arreglo de bytes que representa la información de un archivo.
    * A partir de estos datos, utiliza funciones de hashing polinomial para generar firmas en conjuntos de 4 bytes.
    * Posteriormente compara dichas firmas con las almacenadas en la clase Virus, con el fin de determinar si 
    * el archivo contiene secuencias que correspondan a virus registrados.
    * 
    * El método principal (List<string> AnarlizarTipoVirus()) retorna una lista con los nombres de los virus
    * detectados, evitando duplicados. Para su funcionamiento, emplea el método privado HashearArray(), el cual
    * calcula los valores hash de la información por medio de operaciones de prefijo y módulos primos.
    */

    internal class Analizador
    {

        // Creamos los atributos de usuario
        // Almacena el array de bytes correspondientes a la informacion del archivo
        private byte[]? _infoByteFile;

        // Creamos los atributos de regla
        // Almacena la clase virus
        private Virus _virus;

        //Creamos el constructor
        public Analizador(byte[] infoByteFile, Virus virusRegistrado)
        {
            InfoByteFile = infoByteFile;
            Virus = virusRegistrado;
        }

        // Dejamos este constructor para pruebas...
        //public Analizador(Virus virusRegistrado)
        //{
        //    InfoByteFile = new byte[] { 101, 111, 115, 46 };
        //    Virus = virusRegistrado;
        //}

        // Creamos el accesor
        // Le damos control errores no permitimos el array de bytes vacio o null
        public byte[] InfoByteFile
        {
            get => _infoByteFile!;
            set => _infoByteFile = !(value.Length == 0 || value == null) ? value : throw new Exception("Error el arhivo esta vacio");
        }

        // Creamos el accesor 
        internal Virus Virus { get => _virus; set => _virus = value; }

        // Creamos el metodo para el econtrar el hash en un array
        private List<long[]> HashearArray(byte[] info)
        {
            // Creamoslas constantes
            const byte conjuntoHash = 3;
            const long _prime1A = 257;
            const long _prime2A = 998244353;

            const long _prime1B = 367;
            const long _prime2B = 1001265673;

            // Creamos la lista de hashses
            List<long> hashprefix1 = new List<long>();
            List<long> hashprefix2 = new List<long>();

            // Creamos la lista de los exponentes y la matriz de hash
            List<long> expo1 = new List<long>();
            List<long> expo2 = new List<long>();
            List<long[]> hashRango = new List<long[]>();

            // Asignamos sus valores base para la recursividad 
            hashprefix1.Add(info[0]);
            hashprefix2.Add(info[0]);

            expo1.Add(1);
            expo2.Add(1);

            // Calculamos las dos operaciones
            for (int i = 1; i < info.Length; i++)
            {
                // Calculamos el hash
                hashprefix1.Add(prefixOperation(hashprefix1[i - 1], _prime1A, info[i], _prime2A));
                hashprefix2.Add(prefixOperation(hashprefix2[i - 1], _prime1B, info[i], _prime2B));

                // Calculamos el exponente
                expo1.Add(prefixOperation(expo1[i - 1], _prime1A, 0, _prime2A));
                expo2.Add(prefixOperation(expo2[i - 1], _prime1B, 0, _prime2B));
            }

            // Llenamos el hashRango en conjuntos de 4 
            for (int i = 0, j = conjuntoHash; i < hashprefix1.Count - conjuntoHash && j < hashprefix1.Count; i++, j++)
            {
                
                // Si el incio es cero retornamos el hash del indice final
                if (i == 0)
                {
                    hashRango.Add(new long[]
                    { hashprefix1[j], hashprefix2[j] });
                }
                else
                {
                    hashRango.Add(new long[]
                    { busquedaHash(hashprefix1, expo1, _prime2A, i, j), busquedaHash(hashprefix2, expo2, _prime2B, i, j) });
                }


            }

            // Creamos un lamda para realizar las busquedas
            static long busquedaHash(List<long> hash, List<long> exp, long mod, int i, int j)
                => (((hash[j] - hash[i - 1] * exp[j - i + 1]) % mod) + mod) % mod ;

            // Creamos una funcion lamda para calcular el prefixSum
            static long prefixOperation(long valorAnterior, long primeA, uint byteinfo, long modulo)
                => (valorAnterior * primeA + byteinfo) % modulo;

            // Retornamos el hash con los conjuntos agrupados de a 4 caracteres
            return hashRango;
        }

        // Creamos un metodo para detectar los virus que tiene el archivo retorna una lista de los virus detectados
        public List<string> AnarlizarTipoVirus()
        {
            // Creamos un diccionario con el hash del virus y cual virus es
            Dictionary<string, string> diccVirusHash = new Dictionary<string, string>();

            // Creamos una lista para almacenar la matriz de hash (agrupados de 4 caracteres) del archivo
            List<long[]> infoHash = new List<long[]>();

            // Creamos la varibles para almacenar el tipo de virus detectado
            List<string> virusDetectados = new List<string>();
            string typeVirus;

            // Calculamos el hash del archivo
            infoHash = HashearArray(InfoByteFile);

            // Llenamos el diccionario de virus Hash
            foreach (KeyValuePair<string, byte[]> claveValor in Virus.DiccVirus)
            {
                diccVirusHash[String.Join(", ", HashearArray(claveValor.Value)[0])] = claveValor.Key;
            }

            // Buscamos en el diccionario que tipo de secuencia de virus presenta el arhivo
            foreach (var parHashInfo in infoHash)
            {
                if (diccVirusHash.TryGetValue(String.Join(", ", parHashInfo), out typeVirus!))
                {
                    // Aseguramos de no registrar dos veces el mismo virus
                    if (!virusDetectados.Contains(typeVirus)) virusDetectados.Add(typeVirus);
                }
            }
            return virusDetectados;
        }

    }
}
