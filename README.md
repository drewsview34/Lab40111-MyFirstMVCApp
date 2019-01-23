# Lab40111 - My First MVC App

Lab 40111 My First MVC App

Developer: Andrew Hinojosa

- Contributors:???
- Collaborator: ???

Actual Time To Complete: ???

## 1. Summary
This is an app is creatin my first ASP.NET Core MVC Web Application

## 2. Step By Step Directions ("Happy Path")

#Your MVC Web Application should contain the following:
* Add the MVC Middleware and include template routing (the route must be explicitly defined)
* Only 1 controller. The home controller, with 3 actions (2 Index, and 1 Results)
	- Remember the difference between HTTPGET and HTTPPOST
	- Upon posting back to the server, call the Results action to redirect to the results view.
* Views to generate the home page and search results
	- Use a form tag to accept user input
	- Use Tag Helpers to help redirect you from results page to the Home page. (HINT: the _ViewImports.cshml file may be required)
* Include HTML/CSS in your final product. This is required.
	- It doesn’t have to be fancy, just make it look nice.
* Enable use of Static Files in your website and create a style sheet and incorporate some creativity into your application.
* A model class named TimePerson that contains the following properties(these are the headers of the csv file):
	- public int Year { get; set; }
	- public string Honor { get; set; }
	- public string Name { get; set; }
	- public string Country { get; set; }
	- public int BirthYear { get; set; }
	- public int DeathYear { get; set; }
	- public string Title { get; set; }
	- public string Category { get; set; }
	- public string Context { get; set; }
* Create a static method within this model named GetPersons that brings in the range of years, and returns List<TimePerson>.
* Create the internal logic to read in the file, filter the data from the given inputted range using LINQ queries and Lambda expressions, and return the final filtered list of persons.

# Hints
* Using what you know about reading in external files, and the System.File library, convert the CSV file provided into readable data that can be used within the program. CSV files are delimited using commas. Use what you know from Class 03, and read in the data using the proper delimiter.
* Traversing through the file, line by line, convert each line item of the CSV to a TimePerson object and add it to the collection.
* Using LINQ queries and Lambda expressions, filter out list given the range inputted. You code should take into account a few edge cases of inputting an invalid range (e.g. 2001 - 1985), as well as any other reasonable edge cases.
* Return the collection with the data that matches the year range.
* Use the debugger to get a visible look at what is being imported and confirm the format. This will help you visualize what you need to do.

## 3. Visual Output 
![Lab40111](???)
