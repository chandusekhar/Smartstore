﻿namespace Smartstore.Admin.Models.Catalog
{
    public class ProductAttributeOptionsSetModel : EntityModelBase
    {
        public int ProductAttributeId { get; set; }

        public string Name { get; set; }
        public bool Expanded { get; set; }
    }
}
