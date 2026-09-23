using firstRESTFulService.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace firstRESTFulService.Controllers
{
    //[] are called as attributes, attiibutes are information given to compiler to treat the code in a certain way
    [Route("api/[controller]")] //to access the methods of this controller
    [ApiController] //makes it a controller - 
    public class ProductsController : ControllerBase
    {

        // we write action methods here
        //methods will return Http Status codes
        //methods decorated with Http Verbs ,
        //[HTTPGET] for select or get data, image, video, user can get anything from server
        //[HTTPPOST] for create(insert) data, image, video, user can get anything from server
        //[HTTPPUT] for update(insert) data, image, video, user can get anything from server
        //[HTTPDELETE] for delete(insert) data, image, video, user can get anything from server
        //[HTTPPATCH] for update(insert) data, image, video, user can get anything from server


        ProductsModel model = new ProductsModel(); // this is bad and worst code, we will use Dependency injection here

        #region Get Methods

        [HttpGet]
        [Route("allproducts")]
        public IActionResult GetAllProducts()
        {
            return Ok(model.GetALlProducts());

        }

        [HttpGet]
        [Route("searchbyid/{id}")]
        public IActionResult SearchProductById(int id)
        {
            try
            {
                return Ok(model.GetProductByID(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("searchbycategory/{category}")]
        public IActionResult SearchByCategory(string category) {  
            try
            {
                return Ok(model.GetProductsByCategory(category));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("totalproducts")]
        public IActionResult GetTotalProducts() 
        { 
            return Ok(model.TotalProducts());
        }
        #endregion


        [HttpPost]
        [Route("addnewproduct")]
        public IActionResult AddNewProduct(ProductsModel newProduct)
        {
            try
            {
               var addResult =  model.AddProduct(newProduct);
                return Created("",addResult);
            }
            catch (Exception es)
            {

                return BadRequest(es.Message);
            }      
               
        }

        [HttpDelete]
        [Route("deleteproduct/{id}")]
        public IActionResult DeleteProduct(int id)
        { 
            try
            {
                var deleteResult = model.DeleteProduct(id);
                return Ok(deleteResult);


            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("updateproduct")]
        public IActionResult EditProduct(ProductsModel product_to_update)
        {
            try
            {
                var updateResult = model.UpdateProduct(product_to_update);
                return Ok(updateResult);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }


        }


            













    }
}
