using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// app.MapGet("/", () => "Hello World!");
// app.MapGet("/user",()=>"Pedro Santana");
// app.MapGet("AddHeader",(HttpResponse response)=>{
//   response.Headers.Add("Teste","Pedro Santana");
//   return "Header adicionado para aparecer na mensagem";
//   });
app.MapPost("/saveproduct",(Product product)=>{
  ProductRepository.Add(product);
});
//Route params /product/123
app.MapGet("/getproduct/{code}",([FromRoute]string code)=>{
  var product = ProductRepository.GetBy(code);
  return product;
});
app.MapPut("/editproduct/",(Product product)=>{
  var productEdit = ProductRepository.GetBy(product.Code);
  productEdit.Name = product.Name;
  return productEdit;
});
app.MapDelete("/deleteproduct/{code}",([FromRoute] string code)=>{
  ProductRepository.Delete(code);

});

// //Query params ?dateStart=2021-01-01&dateEnd=2021-01-31
// app.MapGet("/getproduct",([FromQuery] string dateStart,[FromQuery] string dateEnd)=>{
//   return dateStart + " - " + dateEnd;
// });



// app.MapGet("/getproductheader",(HttpRequest request)=>{
//   return request.Headers["product-code"].ToString();
// });

  
app.Run();


public class Product{
  public string? Code { get; set; }
  public string? Name { get; set; }
}

public static class ProductRepository{
  public static List<Product>? Products { get; set; }

  public static void Add(Product product){
    if(Products == null){
      Products = new List<Product>();
    }
    Products.Add(product);
  } 
  public static Product GetBy(string code){
    return Products.FirstOrDefault(x=>x.Code == code );
  }
  public static string Delete(string code){
    var producsToDelete=Products?.Remove(GetBy(code));
    return "Produto Deletado com sucesso";
  }
}