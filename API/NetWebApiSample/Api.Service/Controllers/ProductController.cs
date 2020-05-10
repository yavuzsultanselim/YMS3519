using Api.Service.Filters;
using DAL.Context;
using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Api.Service.Controllers
{
    //[Authorize]
    [BasicAuthFilter]
    public class ProductController : ApiController
    {
        AppDbContext db = new AppDbContext();

        //All Products
        public HttpResponseMessage GetProducts()
        {
            return Request.CreateResponse(HttpStatusCode.OK, db.Products.ToList());
        }

        //Get Product
        public HttpResponseMessage GetProduct(int id)//1001
        {
            Product product = db.Products.Find(id);
            if (product == null)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "ürün bulunamadı");
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.OK, product );
            }
            
        }
        
        //Create Product
        public HttpResponseMessage CreateProduct(Product product)
        {
            if (product != null)
            {
                db.Products.Add(product);
                db.SaveChanges();
                return Request.CreateResponse(HttpStatusCode.Created, product);
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "ürün bulunamadı");
            }
        }

        //Delete Product
        public HttpResponseMessage DeleteProduct(int id)
        {

            Product product = db.Products.FirstOrDefault(x => x.ID == id);
            if (product != null)
            {
                db.Products.Remove(product);
                db.SaveChanges();
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "ürün bulunamadı");
            }
        }

        //Update Product
        [HttpPut]
        //tanımlamış olduğunuz metot ismi eğer herhangi bir http fiiline denk gelirse Örn. Post,Put,Delete,Get vs... metot ismini değiştirmenize gerek yoktur. Ancak farklı bir isimde oluşturulan metot'a farklı bir eylem tanımlamak istediğinizde o metodun başına [] eklemelisiniz. Örn. [HttpPut]
        public HttpResponseMessage UpdateProduct(Product product,int id)
        {
            Product updated = db.Products.FirstOrDefault(x => x.ID == id);
            if (updated != null)
            {
                updated.ProductName = product.ProductName;
                updated.UnitPrice = product.UnitPrice;
                updated.UnitsInStock = product.UnitsInStock;
                db.SaveChanges();
                return Request.CreateResponse(HttpStatusCode.OK,$"{id} numaralı ürün güncellendi.");
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "ürün bulunamadı");
            }
        }

    }
}
