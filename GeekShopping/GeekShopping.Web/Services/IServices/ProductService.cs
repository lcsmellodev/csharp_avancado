using GeekShopping.Web.Models;


namespace GeekShopping.Web.Services.IServices
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _client;
        public const string BasePath = "api/v1/product";

        public ProductService(HttpClient client)
        {
            _client = client;   
        }

        public async Task<IEnumerable<ProductModel>> FindAllProducts()
        {
            var response = await _client.GetAsync(BasePath);
            return await response.Content.ReadFromJsonAsync<List<ProductModel>>();
        }

        public async Task<ProductModel> FindProductById(long id)
        {
            var response = await _client.GetAsync($"{BasePath}/{id}");
            return await response.Content.ReadFromJsonAsync<ProductModel>();
        }
        public async Task<ProductModel> CreateProduct(ProductModel model)
        {
            var response = await _client.PostAsJsonAsync($"{BasePath}",model);
            return await response.Content.ReadFromJsonAsync<ProductModel>();
        }
         public async Task<ProductModel> UpdateProduct(ProductModel model)
         {
            var response = await _client.PutAsJsonAsync($"{BasePath}", model);
            return await response.Content.ReadFromJsonAsync<ProductModel>();
         }

        public async Task<bool> DeleteProductById(long id)
        {
            var response = await _client.DeleteAsync($"{BasePath}/{id}");
            if(response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<bool>();
            }
            else
            {
                throw new Exception($"Algo deu errado ao deletar o produto de id {id}");
            }
          
        }

        

       
    }
}
