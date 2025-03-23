# DI
Dependency Injection Asp.net Core Mvc Entity framework Razor

Steps:

Data ========> ApplicationDbContext.cs                     [class file]

DI\Models  ========> Product.cs                            [class file]

Folder Path : DI\Repository  ========> IProduct.cs         [ it is a Interface ]       Example: public List<Product> fetchProduct();

Folder Path : DI\Service     ========> ProductService.cs   [it is class file]   Initialize Object of Application Db using Constructor    ===> Auto Implement

DI\Controllers    ====>  ProductController.cs       { Calling of the Service Action/Method which is nothing but the same Interface Action/Method Name}
                                                     Initialize Object of Interface Db using Constructor     Example : IProduct prod;  
                                                                                                                        Constructor (IProduct prod) 
                                                                                                                        { this.prod =prod; }

Note ----- Program.cs file =====> Add ==> Scope Lifetime          -> Interface name and Service name 

DI\Views\Product   ====>      1) AddProduct.cshtml      -> Insert Page
                            (2) FetchUpdate.cshtml     -> Edit Page while Populate Data 
                            (3) Index.cshtml          ->  Table for View and Edit and Delete



