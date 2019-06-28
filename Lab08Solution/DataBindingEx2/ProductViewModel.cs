namespace DataBindingEx2
{
    class ProductViewModel : ViewModelBase
    {
        public ProductViewModel()
        {
            this.Products = DataGenerator.CreateProducts();
            this.Product = new Product();
        }

        private Product product;
        public Product Product
        {
            get
            {
                return this.product;
            }

            set
            {
                this.product = value;
                OnPropertyChanged("Product");
            }
        }

        public ProductCollection Products { get; set; }

        public void SetDisplayProduct(Product product)
        {
            this.Product = new Product
            {
                ProductId = product.ProductId,
                Quantity = product.Quantity,
                Sku = product.Sku,
                Description = product.Description,
                Cost = product.Cost,
                IsTaxable = product.IsTaxable
            };
        }

        public Product GetDisplayProduct()
        {
            OnPropertyChanged("Product");
            return this.Product;
        }
    }
}
