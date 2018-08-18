*Firstly we created a movie class in Models file.
	->Created id and name properties.
*After that, created a controller under controllers(Denetleyici) file.
	->We created mvc empty because we will create the controller from scratch. {MoviesController}
	->Changed index method as random.
	->Added new var named movie and added "shrek!" as name.
*Now, we need to add Random's view into Views/Movies.
	->If we select partial view, that means it is like a widget you can use this view in another views.
	->But we will use a layout page. It is like a template. Default MVC project has a layout under Views/Shared/Layout.cshtml.