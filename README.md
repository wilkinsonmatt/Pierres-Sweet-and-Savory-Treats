# Pierres-Sweet-and-Savory-Treats

#### By Matt Wilkinson

#### A simple MVC web application an application with user authentication and a many-to-many relationship that helps pierre to market his sweet and savory treats.

## Technologies Used

* C#
* .NET
* ASP.NET Core MVC
* Razor
* MySQL
* Markdown
* HTML
* CSS
* EF Core

## Description & Schema

This is a MVC web application an application with user authentication and a many-to-many relationship. 

A user can log in and log out. Only logged in users should have create, update and delete functionality. All users should be able to have read functionality.
 
It has a many-to-many relationship between Treats and Flavors. A treat can have many flavors (such as sweet, savory, spicy, or creamy) and a flavor can have many treats. For instance, the "sweet" flavor could include chocolate croissants, cheesecake, and so on.

Once logged in a user can see a list of the Treats and flavors. Users can also click on an individual treat or flavor to see all the treats/flavors that belong to it.

## Setup & Installation Requirements

* Download/Clone entire github file
* Open root directory with Bash
* cd into Pierres-Sweet-and-Savory-Treats/Bakery
* Create an appsetting.json file at the root directory
* Create an _appsettings.json_ file in the __Bakery__ directory and copy in the following:

```
{ 
  "ConnectionStrings": { 
    "DefaultConnection": "Server=localhost;Port=3306;database=Matt_Wilkinson;uid=root;pwd=[YOUR PASSWORD];" 
  } 
}
```

* Navigate to the __Bakery__ directory in your terminal and enter the following commands, in order:
```console
$ dotnet build
$ dotnet restore
$ dotnet ef migrations add Initial
$ dotnet ef database update
$ dotnet ef migrations add addIdentity
$ dotnet ef database update
$ dotnet watch run
```
* click on  <http://localhost:5000>

## Known Bugs

* None


## License

Copyright (c) 2022 Matt Wilkinson

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR I
  
