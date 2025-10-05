using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_Antivirus01.Controladores
{

    /*
     * CLASE: ADMIN_ARCHIVO
     * DESARROLLADOES: THOMAS_GOMEZ
     * FECHA: 16/08/2025
     * 
     * ESTRUCTURA: 
     * Parametros
     *  -_dirreccionFile
     * Metodos
     *  +LeerArchivo
     *  
     * La clase AdminArchivo permite crear un objeto que almacena la ubicación de un archivo en un 
     * atributo tipo string (string _direccionFile). A partir de esta ubicación, la clase proporciona 
     * un método (byte[] LeerArchivo()) que lee el contenido del archivo y devuelve la información en 
     * un arreglo de bytes (byte[]).
     */

    internal class AdminArchivo
    {
        // Creamos los atributos de usuario 
        // Almacena la ubucacion del arhivo
        private string? _direccionFile;

        // Creamos el constructor
        public AdminArchivo(string ubicacionFile)
        {
            DireccionFile = ubicacionFile;
        }

        // Creamos los accesores 
        // Le damos control de errores a la instaciacion del objeto
        public string DireccionFile
        {
            get => _direccionFile!;
            // Nos aseguramos que el arhicvo exita y si el valor el null pues que la canesa se evalue como vacia
            set => _direccionFile = File.Exists(value ?? "") ? value : throw new Exception("El arhivo no existe");
        }

        // Creamos el metodo lamda para leer el archivo retorna un arrray de byte[] con la informacion del arhivo
        public byte[] LeerArchivo() => File.ReadAllBytes(DireccionFile);
    }
}
