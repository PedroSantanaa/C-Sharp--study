using API.context;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSqlServer<ApplicationDbContext>(builder.Configuration["Database:SqlServer"]);
var app = builder.Build();

// app.MapGet("/", () => "Hello World!");
// app.MapGet("/user",()=>"Pedro Santana");
// app.MapGet("AddHeader",(HttpResponse response)=>{
//   response.Headers.Add("Teste","Pedro Santana");
//   return "Header adicionado para aparecer na mensagem";
app.MapPost("/products",(ProductRequest productRequest,ApplicationDbContext context)=>{ 
  var category=context.Category.Where(c=>c.Id==productRequest.CategoryId).First();
  var product=new Product{
    Code=productRequest.Code,
    Name=productRequest.Name,
    Description=productRequest.Description,
    Category=category
  };
  if(productRequest.Tags!= null){

    product.Tags=new List<Tag>();
    foreach(var tag in productRequest.Tags){
      product.Tags.Add(new Tag{
        Name=tag
      });
    }
  }
  context.Products.Add(product);
  context.SaveChanges();
  return Results.Created($"/products/{product.Id}",product.Id);
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
