namespace firstRESTFulService.Models
{
    public class ProductsModel
    {

        #region Properties
        public int ProductID { get; set; }
        public string ProductName { get; set; } = "";

        public string CategoryName { get; set; } = "";
        public string Description { get; set; } = "";
        public int Price { get; set; }
        #endregion

        #region Seed Data
        //this is a hardcoded list, but in real it can be from database or excel file or any other source
        static List<ProductsModel> productsList = new List<ProductsModel>()
        {
            new ProductsModel() { ProductID = 1, ProductName = "Pepsi", CategoryName = "Cold-Drink", Description = "A cold drink to beat your thirst and add energy", Price = 2},
            new ProductsModel() { ProductID = 2, ProductName = "Lays", CategoryName = "Junk food", Description = "A yummy and tasty snack for quick filler to kill your hunger", Price = 4 },
            new ProductsModel() { ProductID = 3, ProductName = "Ferrero", CategoryName = "Choclates", Description = "Sweet and delicious choclates for your pocket", Price = 6 },
            new ProductsModel() { ProductID = 4, ProductName = "Nike", CategoryName = "Shoes", Description = "Just do wrong the right way", Price = 20 },
            new ProductsModel() { ProductID = 5, ProductName = "IPhone", CategoryName = "Phone", Description = "Nothing new comes here", Price = 3000 },
            new ProductsModel() { ProductID = 6, ProductName = "Adidas", CategoryName = "Shoes", Description = "Just do wrong the right way", Price = 20 },
            new ProductsModel() { ProductID = 7, ProductName = "Puma", CategoryName = "Shoes", Description = "something new", Price = 6000 },



        };

        #endregion

        #region CRUD Methods

             #region Get Methods
        public List<ProductsModel> GetALlProducts()
        { 
            return productsList;
        }

        public ProductsModel GetProductByID(int id)
        {
            //this is LINQ
            //var p = from pr in productsList
            //        where pr.ProductID == id
            //        select pr;

            //Lambda

            var p2 = productsList.SingleOrDefault(pr => pr.ProductID == id); //returns a null if product is not present

            if(p2 != null)
            {

                return p2;
            }
            else
            {
                throw new Exception("Product Not found in system");
            }
        }

        public int TotalProducts()
        {
            return productsList.Count;
        }

        public List<ProductsModel> GetProductsByCategory(string category)
        { 
               var p = from pr in productsList
                    where pr.CategoryName == category
                    select pr;
                

            return p.ToList();
        }
        #endregion

             #region Add, delete and Update Methods
        public string AddProduct(ProductsModel product)
        {

            //we cando validation here

            if (product.Price < 2)
            {
                throw new Exception("Price should be more than 2");
            }
            else
            {
                productsList.Add(product);

                return "Product added successfully";
            }
        }

        public string DeleteProduct(int id)
        {
            var p = productsList.Where(pr => pr.ProductID == id).Single();

            if (p != null)
            {
                productsList.Remove(p);
                return "Product deleted successfully";
            }
            else
            {
                throw new Exception("Product not found in system"); 
            }
        }

        public string UpdateProduct(ProductsModel product)
        {
            var p = productsList.Where(pr => pr.ProductID == product.ProductID).Single();

            if (p != null)
            {
                p.ProductName = product.ProductName;
                p.CategoryName = product.CategoryName;
                p.Description = product.Description;
                p.Price = product.Price;

                return "Product updated successfully";
            }
            else
            {
                throw new Exception("Invalid product Id");
            }
          
        }

        #endregion


       #endregion


    }
}
