using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {

        //iş katmanını kullanabilmek için veri erişim katmanına ihtiyacımız var.(Ders 10)


        //Dependency Injection kalıbı oluşturduk
        //bağımlılıklardan kurtulduk
        private IProductDal _productDal;

        public ProductManager(IProductDal productDal) //Constroctar kalıp
        {
            _productDal = productDal;
        }

        [ValidationAspect(typeof(ProductValidator),Priority =1)]
        public IResult Add(Product product)
        {
            //Business codes
            //Herhangi bir iş kodumuz varsa buraya gelecek
            //öengin daha önce eklenen ürün isminin bir daha eklenmemesi gibi işlemler, validasyon kodları vb.

          //  ValidationTool.Validate(new ProductValidator(), product);
            _productDal.Add(product);
            return new SuccessResult(Messages.ProductAdded);

            //Eger basarısız msajıda gönderilecekse try catch yapısı kullanılır 
        }

        public IResult Delete(Product product)
        {
            _productDal.Delete(product);
            return new SuccessResult(Messages.ProductDeleted);
        }

        public IDataResult<Product> GetById(int productId)
        {
            return new SuccessDataResult<Product>(_productDal.Get(p => p.ProductId == productId));
        }

        public IDataResult<List<Product>> GetList()
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetList().ToList());
        }

        public IDataResult<List<Product>> GetListByCotegory(int categoryId)
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetList(p => p.CategoryId == categoryId).ToList());
        }

        public IResult Update(Product product)
        {
            _productDal.Update(product);
            return new SuccessResult(Messages.ProductUpdated);
        }
    }
}
