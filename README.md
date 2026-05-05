# RazorProductApp

An ASP.NET Core Razor Pages application demonstrating advanced concepts including **complex model binding, partial views, and custom routing**.

---

## Overview

This project is developed as part of a coding assignment to demonstrate key features of Razor Pages:

* Complex model binding with collections
* Reusable UI using partial views
* Custom routing with route parameters

---

## Technologies Used

* ASP.NET Core Razor Pages
* C#
* HTML

---

## User Stories Implementation

### User Story 1: Model Binding with Complex Types and Collections

* Created a `Product` model with:

  * ProductID
  * Name
  * Description
  * List of Categories
* Implemented form to accept product details
* Used indexed binding for categories
* Displayed list of products on the same page

---

### User Story 2: Partial Views

* Created reusable partial view:

  ```
  Pages/Shared/_ProductCard.cshtml
  ```
* Displays product summary including categories
* Used partial view inside Index page:

  ```
  <partial name="_ProductCard" model="product" />
  ```
* Improved code reusability and modular design

---

### User Story 3: Custom Routing

* Created a new Razor Page: `ProductDetails`
* Configured route using:

  ```
  @page "{id:int}"
  ```
* Accessed data using route parameter:

  ```
  /ProductDetails/1
  ```
* Displayed product details dynamically

---

## Project Structure

```
RazorProductApp/
│
├── Models/
│   └── Product.cs
│
├── Pages/
│   ├── Index.cshtml
│   ├── Index.cshtml.cs
│   ├── ProductDetails.cshtml
│   ├── ProductDetails.cshtml.cs
│   ├── Shared/
│   │   └── _ProductCard.cshtml
│   └── Privacy.cshtml
│
├── wwwroot/
├── appsettings.json
└── Program.cs
```

---

## How to Run

1. Open the project in Visual Studio
2. Build the solution
3. Run the application
4. Open browser and navigate to:

```
http://localhost:5000
```

---

## Application Flow

1. Add a product using the form
2. Product appears in the list (rendered via partial view)
3. Click "View Details"
4. Redirects to product details page using route parameter

---

## Key Concepts Demonstrated

* Razor Pages lifecycle (OnGet, OnPost)
* Model binding with complex objects
* Collection binding using indexed inputs
* Partial views for reusable UI
* Custom routing with parameters

---

## Limitations

* Data is stored in memory using a static list
* Data resets when the application restarts

---

## Future Improvements

* Add form validation
* Use a database for persistent storage
* Add dynamic category fields
* Improve UI with Bootstrap
