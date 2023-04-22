# NiharsBookStore

On March 2, 2023, this project was initiated in order to finish Assignment 2. The project makes use of ASP.NET MVC with Core 3.1 and has HTTPS and single-account authentication enabled.

The project has undergone the following changes:
altered the Welcome page's copyright and navigation.
added a themed template based on the "Lux" theme from bootswatch.com, and added a dropdown menu to the layout_cshtml code.
In order to perform CRUD operations on the Category class, a Category Model, a new table, and a new folder named "Repository" were all built.
IRepository.cs was made to handle CRUD operations on the Category class, and separate repositories were made for the category and other potential future models.

created the ISP_Calls.cs interface and added it to the SP_Call.cs class in the IRepository folder.
IRepository folder was expanded to include the IUnitOfWork interface, which was then used in a new class.
The same techniques used to create Category CRUD were utilised to create Cover Type CRUD. CoverType.cs was added to the Models folder along with CoverTypeRepository and ICoverTypeRepository Interface.
UnitOfWork and IUnitOfWork now include CoverType, Updated the database and created a migration for CoverType.
Cover Type was subjected to CRUD operations, added to the NavBar, given a CoverType Controller with all necessary Action Methods, and had its Index View switch to DataTables.
Product was added to the Repository, the IProductRepository Interface, the ProductRepository Class (with the Update method modified), and the UnitOfWork and IUnitOfWork interfaces.
To carry out the CRUD operations, a Product Controller was made, and the IWebHostEvironment method and associated using statement were added to the Microsoft.AspNetCore.Hosting.

To finish Assignment 3, the project was last edited on April 13, 2023, and a detailed description of those modifications may be seen in the change log.

