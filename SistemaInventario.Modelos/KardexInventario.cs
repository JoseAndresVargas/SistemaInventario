using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SistemaInventario.Modelos

{
    public KardexInventario()
	{
        [Key]
        public int Id { get; set; }
        [Required]
        public string BodegaProductoId { get; set; }
        [ForeignKey("BodegaProductoId")]
        public BodegaProducto BodegaProducto { get; set; }
        [Required]
        [MaxLength(100)]
        public string Tipo { get; set; } //ENT - SAL
        [Required]
        public string Detalle { get; set; }
        [Required]
        public string StockAnterior { get; set; }
        [Required]
        public string Cantidad { get; set; }
        [Required]
        public double Costo { get; set; }
        [Required]
        public string Stock { get; set; }
        [Required]
        public double Total { get; set; }
        [Required]
        public string UsuarioAplicacionId { get; set; }
        [ForeignKey("UsuarioAplicacionId")]
        public UsuarioAplicacion UsuarioAplicacion { get; set; }
        [Required]
        public DateTime FechaRegistro { get; set; }
    }
}
