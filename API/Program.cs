using API.context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
app.MapGet("/products/{id}",([FromRoute]int id,ApplicationDbContext context)=>{
  var product = context.Products.Include(p=>p.Category).Include(p=>p.Tags).Where(p=>p.Id==id).First();
  if(product!=null){
    return Results.Ok(product);
  }
  return Results.NotFound();
});
app.MapPut("/products/{id}",([FromRoute] int id,ProductRequest productRequest,ApplicationDbContext context)=>{
  var product = context.Products.Include(p=>p.Tags).Where(p=>p.Id==id).First();
  product.Code=productRequest.Code;
  product.Name=productRequest.Name;
  product.Description=productRequest.Description;
  var category=context.Category.Where(c=>c.Id==productRequest.CategoryId).First();
  product.Category=category;
  if(productRequest.Tags!= null){

    product.Tags=new List<Tag>();
    foreach(var tag in productRequest.Tags){
      product.Tags.Add(new Tag{
        Name=tag
      });
    }
  }
  context.SaveChanges();
  return Results.Ok();
});
app.MapDelete("/products/{id}",([FromRoute] int id,ApplicationDbContext context)=>{
  var product = context.Products.Where(p=>p.Id==id).First();
  context.Products.Remove(product);
  context.SaveChanges();
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
