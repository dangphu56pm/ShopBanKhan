using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopKhanMat.Web.Models
{
    [Serializable]
    public class ShoppingCartViewModel
    {
        public int ProductId { set; get; }
        public ProductViewModel Product { set; get; }
        public int Quantity { set; get; }
    }
}