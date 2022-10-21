using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prj_Capa_Entidad
{
    public class EN_Producto
    {
        /*
         *  @idpro ,
            @idprove ,
            @descripcion ,
            @frank ,
            @Pre_compraSol ,
            @pre_CompraDolar ,
            @StockActual ,
            @idCat ,
            @idMar ,
            @Foto ,
            @Pre_Venta_Menor ,
            @Pre_Venta_Mayor ,
            @Pre_Venta_Dolar ,
            @UndMdida ,
            @PesoUnit ,
            @Utilidad ,
            @TipoProd ,
            @ValorporProd ,
         */
        private string _idProd;
        private string _idProve;
        private string _descripcion;
        private string _frank;
        private string _pre_CompraSol;
        private string _pre_CompraDolar;
        private string _stockActual;
        private string _idCat;
        private string _idMar;
        private string _foto;
        private string _pre_Venta_Menor;
        private string _pre_Venta_Mayor;
        private string _pre_Venta_Dolar;
        private string _undMdida;
        private string _pesoUnit;
        private string _utilidad;
        private string _tipoProd;
        private string _valorPorProd;

        public string IdProd { get => _idProd; set => _idProd = value; }
        public string IdProve { get => _idProve; set => _idProve = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public string Frank { get => _frank; set => _frank = value; }
        public string Pre_CompraSol { get => _pre_CompraSol; set => _pre_CompraSol = value; }
        public string Pre_CompraDolar { get => _pre_CompraDolar; set => _pre_CompraDolar = value; }
        public string StockActual { get => _stockActual; set => _stockActual = value; }
        public string IdCat { get => _idCat; set => _idCat = value; }
        public string IdMar { get => _idMar; set => _idMar = value; }
        //public string Foto { get => _foto; set => _foto = value; }
        public string Foto { get => _foto; set => _foto = value; }
        public string Pre_Venta_Menor { get => _pre_Venta_Menor; set => _pre_Venta_Menor = value; }
        public string Pre_Venta_Mayor { get => _pre_Venta_Mayor; set => _pre_Venta_Mayor = value; }
        public string Pre_Venta_Dolar { get => _pre_Venta_Dolar; set => _pre_Venta_Dolar = value; }
        public string UndMdida { get => _undMdida; set => _undMdida = value; }
        public string PesoUnit { get => _pesoUnit; set => _pesoUnit = value; }
        public string Utilidad { get => _utilidad; set => _utilidad = value; }
        public string TipoProd { get => _tipoProd; set => _tipoProd = value; }
        public string ValorPorProd { get => _valorPorProd; set => _valorPorProd = value; }
        
    }
}
