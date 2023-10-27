using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace SistemaInventario.Modelos
{
    public class BodegaProducto()
	{
		[Key]
		public int Id { get; set; }
		[Required]
		public int BodegaId { get; set; }
		[ForeignKey("BodegaId")]
		public Bodega Bodega { get; set;}
		[Required]
		public int ProductoId { get; set; }
		[ForeignKey("ProductoId")]
		public Producto Producto { get; set; }
	    [Required]
	    public int Cantidad { get; set; }
	}
}
