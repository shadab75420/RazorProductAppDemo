# RazorProductApp

A simple ASP.NET Core Razor Pages application demonstrating **complex model binding with collections**.

---

## Overview

This project demonstrates how to:

* Bind a complex model (Product) in Razor Pages
* Handle collections (List of Categories)
* Accept user input through forms
* Display a list of submitted products dynamically

---

## Technologies Used

* ASP.NET Core Razor Pages
* C#
* HTML

---

## Features

* Add a product with:

  * Product ID
  * Name
  * Description
  * Multiple categories
* Model binding using BindProperty
* Collection binding using indexed inputs
* Display list of products with categories
* Simple and clean UI

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
│   ├── Privacy.cshtml
│   └── Shared/
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
4. Open browser and go to:

```
http://localhost:5000
```

---

## How It Works

### Model

* Product model contains:

  * ProductID
  * Name
  * Description
  * List of Categories

### Form Submission

* User enters product details
* Categories are bound using indexed inputs
* Data is handled in OnPost() method

### Data Display

* Products are displayed using a loop
* Categories are shown as a list

---

## Key Concepts

* Razor Pages lifecycle (OnGet, OnPost)
* Complex model binding
* Collection binding using index
* Form handling in ASP.NET Core

---

## Limitations

* Data is stored in memory
* Data resets when the application restarts

---

## Future Improvements

* Add validation
* Use database for persistent storage
* Add dynamic category fields
* Improve UI using Bootstrap

