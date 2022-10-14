using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prj_Capa_Entidad
{
    public class EN_Proveedor
    {
        //variables encapsuladas;
        private string _idProveedor;
        private string _nombreProveedor;
        private string _direccion;
        private string _telefono;
        private string _rubro;
        private string _ruc;
        private string _correo;
        private string _contacto;
        private string _fotoLogo;
        //A propiedades con su getter y su setter para poder acceder a ellas
        public string IdProveedor { get => _idProveedor; set => _idProveedor = value; }
        public string NombreProveedor { get => _nombreProveedor; set => _nombreProveedor = value; }
        public string Direccion { get => _direccion; set => _direccion = value; }
        public string Telefono { get => _telefono; set => _telefono = value; }
        public string Rubro { get => _rubro; set => _rubro = value; }
        public string Ruc { get => _ruc; set => _ruc = value; }
        public string Correo { get => _correo; set => _correo = value; }
        public string Contacto { get => _contacto; set => _contacto = value; }
        public string FotoLogo { get => _fotoLogo; set => _fotoLogo = value; }

        //Para usar estas propiedes, solo debemos instanciar esta clase

    }
}
