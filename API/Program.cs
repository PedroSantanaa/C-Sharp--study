using API.context;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<ApplicationDbContext>();
var app = builder.Build();

// app.MapGet("/", () => "Hello World!");
// app.MapGet("/user",()=>"Pedro Santana");
// app.MapGet("AddHeader",(HttpResponse response)=>{
//   response.Headers.Add("Teste","Pedro Santana");
//   return "Header adicionado para aparecer na mensagem";
app.MapPost("/products",(Product product)=>{
//   });
  ProductRepository.Add(product);
  return Results.Created($"/products/{product.Code}",product);
});
//Route params /product/123
app.MapGet("/products/{code}",([FromRoute]string code)=>{
  var product = ProductRepository.GetBy(code);
  if(product!=null){
    return Results.Ok(product);
  }
  return Results.NotFound();
});
app.MapPut("/products/",(Product product)=>{
  var productEdit = ProductRepository.GetBy(product.Code);
  productEdit.Name = product.Name;
  return Results.Ok(productEdit);
});
app.MapDelete("/products/{code}",([FromRoute] string code)=>{
  ProductRepository.Delete(code);
  return Results.Ok();

});

// //Query params ?dateStart=2021-01-01&dateEnd=2021-01-31
// app.MapGet("/getproduct",([FromQuery] string dateStart,[FromQuery] string dateEnd)=>{
//   return dateStart + " - " + dateEnd;
// });



// app.MapGet("/getproductheader",(HttpRequest request)=>{
//   return request.Headers["product-code"].ToString();
// });

  
app.Run();


public class Category{
  public int Id { get; set; }
  public string? Name { get; set; }
}

public class Tag{
  public int Id { get; set; }
  public string Name { get; set; }
  public int ProductId { get; set; }
}
public class Product{
  public int Id { get; set; }
  public string? Code { get; set; }
  public string? Name { get; set; }
  public string? Description { get; set; } 
  public int CategoryId { get; set; }
  public Category Category { get; set; }
  public List<Tag> Tags { get; set; }
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