2023-03-03
1505
Author's Name: Nihar Sadhu


On March 2, 2023
, I created a new project on the lab computer to complete assignment 2.
I set up ASP.NET MVC with core 3.1 and enabled HTTPS with individual account authentication.
I reviewed the Areas folder, model, views, and controllers to ensure everything was properly set up.

15:09
I commented out the options part in Startup.cs and confirmed 
that the application was still functioning correctly.
My action items included modifying the navigation, which 
resembled assignment 1, and changing the copyright from static to dynamic.

15:16
I made changes to the Welcome page and thoroughly tested them to ensure that they functioned as intended.
I also added a comment to line 65 of Startup.cs.

 
I resumed work on my project. At 15:23,
I visited bootswatch.com to find appropriate themed 
templates for my project. I decided on the "Flatly" theme and navigated 
to the roots folder > lib > bootstrap > dist > css.

I updated the original bootstrap file name to bootstrap_bk.
css while adding a new bootstrap file to the folder for the newly selected theme.

Then, I updated my layout_cshtml code and added a dropdown menu in it.

Assignment 2

2023-04-04

    0111
    I built the application to check if it was still working.

    01:20
    I created a migrations file and modified the database name,
    then added the migration file using the NuGet Package Manager Console.
    
    01:43
    I updated the database via PM Console and ran the application.

    02:07
    I added a new table to the DB by creating a Category Model and pushed it to the DB.
    
    Next, I added a new class file to the .Models project and modified it.

    02:15
    I added the migration file via PM Console, updated the database, confirmed
    the new Categories table via the SQL SOE, and pushed the commits.
    After creating the Category.cs file, I added it to the ApplicationDbContext.



    2023-04-05

    03:43
    I created a new folder named 'Repository' and added an 'IRepository' folder inside it.
    I added an IRepository.cs interface to the folder itself and modified
    it to perform CRUD operations on the Category class.
    I encountered some errors in a particular file, so I used the using statement
    to view the potential fixes and implement the interface.
    I modified the code to create constructors and dependency injection (DI).
    Next, I created individual repos for category and all potential models to be
    added in the future, including CategporyRepository.cs and ICategporyRepository.cs.
    I modified the CategporyRepository.cs file and the ICategporyRepository.cs interface accordingly.
    Using .NET LINQ, I retrieved the first or default category object and passed
    the id as a generic entity that matched the category ID.

    05:13
New migration file name: AddCategoryToDb


    07:14
    Added ISP_Calls.cs interface in the IRepository folder and implemented it in SP_Call.cs class.
    
    2023-04-06

    10:23
    Added IUnitOfWork interface in the IRepository folder and implemented it in a new class.

    Added a new CategoryController.cs in the Areas/Admin folder and modified the code to access IUnitOfWork.
    
    11:21
    Created a new Views folder with the same name as the controller and added a new Index view to it.
    Moved the "Category" link to the Content Management drop-down in _Layout.cshtml.
    Modified UpSert.cshtml to add asp-action and added @title variable and @section call 
    to Scripts to validate input.
    Created an Upsert POST action method in the CategoryController.cs file,
    removed some methods from CategoryRepository.cs, and moved the _unitOfWork.Save()
    method with the return.
    Added an HTTPDelete API call and delete method in category.js.
    Added delete functionality with onclick event to the Delete function in category.js.
    Added the (Delete)url function code.
    Data entered by the user into the table is not displaying in the database.


    Assignment 3
    date: 2023-04-13

    1:08
    Created Cover Type CRUD with the exact same methods used for Category CRUD
     Added CoverType.cs in the Model’s folder CoverType Modelwith ID and,Name


    1:38

    Added CoverType to the   Added CoverTypeRepository, Added ICoverTypeRepository Interface
    Added CoverType to UnitOfWork and IUnitofWork, Push CoverType to the Database (Create migration and update the DB)


2:01

Performed CRUD operations on Cover Type, Added Cover Type to NavBar,
Added CoverType Controller with all required Action Methods Cover Type Index View to use DataTables
Cover Type Upsert View takes care of creating and updating CoverType
The delete CoverType is done using the API Call.


2:18

Added Migration for the product (AddProductToDb)

2:36

Added Product to the Repository, then Added IProductRepository Interface
later Added ProductRepository Class (note modifications to the
Update method)Added Product to UnitOfWork and IUnitofWork


3:01
Added Product Controller To the Areas > Admin >Controllers to perform the CRUD operations
Added the IWebHostEvironment call and its using statement to the Microsoft.AspNetCore.
Hosting (note the changes to the public ProductController method.




3:12

Created a ViewModel in the Models project to hold the Product object
and select list for Category and CoverType Modify the
ProductVM class so it is public and intall the Microsoft.AspNetCore.
Mvc.ViewFeatures package.

3:55

Modified the ProductController so the IActionResult Upsert calls to the
ProductVM view model, include the using statements to the ViewModels folder and
Microsoft.AspNetCore.Mvc.Rendering

Commented out the Upsert post method for now Modify the API call to
include the Category and CoverType properites, Added an Index view Copy the Index.cshtml
code fromViews/Category and
modify to the Product List header, Create New Product and add
the following properties – Title / ISBN / Price / Author Category reference a product.js file.
Copy/Paste the category.js and rename to product.js (modify the URL to point to Product)
Modify the _Layout.cshtml to add a new link to Product

21:55
Fixing few errors in the CoverTypeRepository


Assignment 3.3

date: 2023-04-19

1:20

Later, I continued to expand

the wwwroot > images > products
folder by including a new folder and a
subfolder alongside it.


Additionally, the product Upsert Post action
function is located inside the ProductController setup folder. 
I attempted to run the programme
while the activities were taking place, but it displayed numerous errors, 




3:40

I discovered the error—the reaso
n the system was throwing up so man
y errors for me was beacuse a typing error 
in covertype.



5:20

After spending some time trying to find a solution,
I finally came to the conclusion that I could fix
the error by entering the sql database and making certain modifications. 

All the issues I was experiencing
vanished after I changed the name "Categoory" to "CoverType"!

After that, I tried running the
application, and everything went very smoothly! 


7:40


I made the product's index.cshtml as the home page. 

The ProductList should always be the first page
to load when the page loads. attempting to devise methods for searching through it.


2022-04-21

2:06
Made changes in the home page to show the product list.