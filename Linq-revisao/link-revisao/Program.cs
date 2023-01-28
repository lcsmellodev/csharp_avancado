using Linq_revisao.Entities;

//funcao auxiliar
static void Print<T>(string message, IEnumerable<T> collection)
{
    Console.WriteLine(message);
    foreach(T obj in collection)
    {
        Console.WriteLine(obj);
    }
    Console.WriteLine();


}

Category c1 = new Category() { Id = 1, Name = "Tools", Tier = 2 };
Category c2 = new Category() { Id = 2, Name = "Computers", Tier = 1 };
Category c3 = new Category() { Id = 3, Name = "Electronics", Tier = 1 };

List<Product> products = new List<Product>() {
                new Product() { Id = 1, Name = "Computer", Price = 1100.0, Category = c2 },
                new Product() { Id = 2, Name = "Hammer", Price = 90.0, Category = c1 },
                new Product() { Id = 3, Name = "TV", Price = 1700.0, Category = c3 },
                new Product() { Id = 4, Name = "Notebook", Price = 1300.0, Category = c2 },
                new Product() { Id = 5, Name = "Saw", Price = 80.0, Category = c1 },
                new Product() { Id = 6, Name = "Tablet", Price = 700.0, Category = c2 },
                new Product() { Id = 7, Name = "Camera", Price = 700.0, Category = c3 },
                new Product() { Id = 8, Name = "Printer", Price = 350.0, Category = c3 },
                new Product() { Id = 9, Name = "MacBook", Price = 1800.0, Category = c2 },
                new Product() { Id = 10, Name = "Sound Bar", Price = 700.0, Category = c3 },
                new Product() { Id = 11, Name = "Level", Price = 70.0, Category = c1 }
            };

//var r1 = products.Where(x => x.Category.Tier == 1 && x.Price < 900.00);

// sintaxe alternativa

var r1 =
    from p in products
    where p.Category.Tier == 1 && p.Price < 900.0
    select p;

Print("Produtos tier 1 e preço < 900.00", r1);

var r2 = products
    .Where(p => p.Category.Name == "Tools")
    .Select(p => p.Name);
    

Print("Apenas nomes dos produtos que tem categoria Tools", r2);

//var r3 = products.Where(p => p.Name[0] == 'C').Select(p => new { p.Name, p.Price/*, CategoryName = p.Category.Name*/ }); 
// o ultimo parametro é uma maneira de fazer o alias. Se não o fizer vai dar erro de compilação porque p nome é igual


//sintaxe alternativa
var r3 =
    from p in products
    where p.Name[0] == 'C'
    select new
    {
        p.Name,
        p.Price,
        CategoryName = p.Category.Name
    };

Print("Nomes começados com 'C' e objeto anônimo", r3);

var r4 = products.Where(p => p.Category.Tier == 1)
    .OrderBy(p => p.Price)
    .ThenBy(P => P.Name);

Print("Filtra os tier 1, ordena primeiramente por preço e, segundamente, por nome", r4);

//var r5 = r4.Skip(2).Take(4);
var r5 =
    (from p in r4
     select p).Skip(2).Take(4);

Print("Pula os 2 primeiros e então pega 4 elementos", r4);

var r6 = products.FirstOrDefault();
//Se for utilizado  o método products.First() eu tenho que garantir que r6 vai receber algo, senão será lançada uma excessão
Console.WriteLine("First or default test1: " + r6);

var r7 = products.Where(p => p.Price > 3000.0).FirstOrDefault();
Console.WriteLine("First or default test2:" + r7);

var r8 = products.Where(p => p.Id == 3).SingleOrDefault();
//análogo ao Single, porém o Single serve apenas para as buscas que retornam ou 1 ou nenhum valor.
//se retornar mais de 1 valor é lançada uma excessão também
Console.WriteLine("Single or default test1: " + r6);

var r9 = products.Where(p => p.Id == 30).SingleOrDefault();
Console.WriteLine("Single or default test1: " + r6);

var r10 = products.Max(p => p.Price);
Console.WriteLine("Max price:" + r10);

var r11 = products.Min(p => p.Price);

