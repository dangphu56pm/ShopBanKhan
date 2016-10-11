using System;

namespace ShopKhanMat.Model.Abstract
{
    public interface IAuditable
    {
        DateTime? CreatedDate { set; get; }
        string CreatedBy { get; set; }
        DateTime? UpdatedDate { set; get; }
        string UpdatedBy { get; set; }
        string MetaKeyword { get; set; }
        string MetaDescription { get; set; }
        bool Status { get; set; }
    }
}