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