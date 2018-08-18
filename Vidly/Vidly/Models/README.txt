

*Firstly we created a movie class in Models file.
	->Created id and name properties.

*After that, created a controller under controllers(Denetleyici) file.
	->We created mvc empty because we will create the controller from scratch. {MoviesController}
	->Changed index method as random.
	->Added new var named movie and added "shrek!" as name.

*Now, we need to add Random's view into Views/Movies.
	->If we select partial view, that means it is like a widget you can use this view in another views.
	->But we will use a layout page. It is like a template. Default MVC project has a layout under Views/Shared/Layout.cshtml.
	->When we added the view, it generated a code in html and c#. 
	-> @{} is prefix for c# codes.

*Get back to MoviesController and write movie var between view's paranthesis.

*After that, get back to Random.cshtml(our view).
	->Change the heading(h2) to render the name of the movie.
	->@Model gives us access to c# codes but we can not reach to name of movie so we write code in the beginning to reach them.( @model Vidly.Models.Movie )
	->Now we add @Model.Name in h2 code and render it. We see the name of movie(shrek) in Movies/Random address.