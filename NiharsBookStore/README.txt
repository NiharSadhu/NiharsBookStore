2023-02-03
1505
Author's Name: Nihar Sadhu


On March 2, 2023, I created a new project on the lab computer to complete assignment 2. I set up ASP.NET MVC with core 3.1 and enabled HTTPS with individual account authentication. I reviewed the Areas folder, model, views, and controllers to ensure everything was properly set up.

At 15:09, I commented out the options part in Startup.cs and confirmed that the application was still functioning correctly. My action items included modifying the navigation, which resembled assignment 1, and changing the copyright from static to dynamic.

At 15:16, I made changes to the Welcome page and thoroughly tested them to ensure that they functioned as intended. I also added a comment to line 65 of Startup.cs.

The following day, on March 3 at 15:14, I resumed work on my project. At 15:23, I visited bootswatch.com to find appropriate themed templates for my project. I decided on the "Flatly" theme and navigated to the roots folder > lib > bootstrap > dist > css.

I updated the original bootstrap file name to bootstrap_bk.css while adding a new bootstrap file to the folder for the newly selected theme.

Then, I updated my layout_cshtml code and added a dropdown menu in it.

Assignment 2

    I built the application to check if it was still working.
    
    I created a migrations file and modified the database name, then added the migration file using the NuGet Package Manager Console.
    
    I updated the database via PM Console and ran the application.
    
    I added a new table to the DB by creating a Category Model and pushed it to the DB.
    
    Next, I added a new class file to the .Models project and modified it.
    
    I added the migration file via PM Console, updated the database, confirmed the new Categories table via the SQL SOE, and pushed the commits.
    After creating the Category.cs file, I added it to the ApplicationDbContext.
    
    I created a new folder named 'Repository' and added an 'IRepository' folder inside it.
    I added an IRepository.cs interface to the folder itself and modified it to perform CRUD operations on the Category class.
    I encountered some errors in a particular file, so I used the using statement to view the potential fixes and implement the interface.
    I modified the code to create constructors and dependency injection (DI).
    Next, I created individual repos for category and all potential models to be added in the future, including CategporyRepository.cs and ICategporyRepository.cs.
    I modified the CategporyRepository.cs file and the ICategporyRepository.cs interface accordingly.
    Using .NET LINQ, I retrieved the first or default category object and passed the id as a generic entity that matched the category ID.

New migration file name: aspnet-NiharsBookStore-AF5D1E1F-F128-4430-B5F2-95683BB80D40


    Added ISP_Calls.cs interface in the IRepository folder and implemented it in SP_Call.cs class.
    
    Added IUnitOfWork interface in the IRepository folder and implemented it in a new class.
    Added a new CategoryController.cs in the Areas/Admin folder and modified the code to access IUnitOfWork.
    Created a new Views folder with the same name as the controller and added a new Index view to it.
    Moved the "Category" link to the Content Management drop-down in _Layout.cshtml.
    Modified UpSert.cshtml to add asp-action and added @title variable and @section call to Scripts to validate input.
    Created an Upsert POST action method in the CategoryController.cs file, removed some methods from CategoryRepository.cs, and moved the _unitOfWork.Save() method with the return.
    Added an HTTPDelete API call and delete method in category.js.
    Added delete functionality with onclick event to the Delete function in category.js.
    Added the (Delete)url function code.
    Data entered by the user into the table is not displaying in the database.




    1:08
    Created Cover Type CRUD with the exact same methods used for Category CRUD
    • Added CoverType.cs in the Model’s folder
    • CoverType Model
    •  with ID and,
    • Name


    1:38

    Added CoverType to the Repository
• Added CoverTypeRepository Class
• Added ICoverTypeRepository Interface
• Added CoverType to UnitOfWork and IUnitofWork
• Push CoverType to the Database (Create migration and update the DB)


2:01

Performed CRUD operations on Cover Type
• Added Cover Type to NavBar
• Added CoverType Controller with all required Action Methods
• Cover Type Index View to use DataTables
• Cover Type Upsert View takes care of creating and updating CoverType
• The delete CoverType is done using the API Call.


2:18

Added Migration for the product

2:36

Added Product to the Repository
 Added IProductRepository
Interface
Added ProductRepository Class
(note modifications to the
Update method)
Added Product to UnitOfWork and
IUnitofWork


3:01
Added Product Controller
• To the Areas > Admin >
Controllers to perform
the CRUD operations
• Added the
IWebHostEvironment
call and its using
statement to the
Microsoft.AspNetCore.
Hosting (note the
changes to the public
ProductController
method.




3:12

Created a ViewModel in
the Models project to
hold the Product object
and select list for
Category and CoverType
• Modify the
ProductVM class so it
is public and intall the
Microsoft.AspNetCore.
Mvc.ViewFeatures
package.

3:55

Modified the ProductController so the IActionResult Upsert calls to the
ProductVM view model, include the using statements to the ViewModels folder and
Microsoft.AspNetCore.Mvc.Rendering

Commented out the
Upsert post method
for now Modify the API call to
include the Category
and CoverType
properites
• Add an Index view
• Copy the Index.cshtml
code from
Views/Category and
modify to the Product
List header, Create
New Product and add
the following
properties – Title /
ISBN / Price / Author /
Category and
reference a new
product.js file.
• Copy/Paste the
category.js and
rename to product.js
(modify the URL to
point to Product)
• Modify the
_Layout.cshtml to add
a new link to Product

