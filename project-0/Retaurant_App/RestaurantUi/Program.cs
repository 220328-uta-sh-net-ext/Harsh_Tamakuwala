﻿global using Serilog;

using RestaurantUi;
using RestaurantBl;



Log.Logger = new LoggerConfiguration().WriteTo.File("./Logs/user.txt").MinimumLevel.Debug().MinimumLevel.Information()
    .CreateLogger();

bool repeat = true;
InitialRestaurantClass initialRestaurantClass = new InitialRestaurantClass();
AdminUserMenu menu = new AdminUserMenu();

var result = initialRestaurantClass.getinitiated();

if (result == "Login Successful")
{
    Log.Information(Globals.userName +"Login Successful");
    Console.WriteLine(Globals.userName + "Login Successful");
    Log.Information("Login Successful");
    while (repeat)
    {
        menu.Display();
        string ans = menu.UserChoice();

        switch (ans)
        {
            case "AddNewRestaurant":
                //call SearchPokemon method
                Console.Clear();
                AddRestaurant addRestaurant = new AddRestaurant();
                addRestaurant.AddNewRestaurant();
                Console.WriteLine("AddNewRestaurant() Method implementation is in progress....");

                break;
            case "SearchRestaurant":
                //call SearchPokemon method
                Console.Clear();
                RestaurantOperation.SearchRestaurant();
                Console.WriteLine("SearchRestaurant() Method implementation is in progress....");

                break;
            case "CalculateAllRestaurantAvgRating":
                //call SearchPokemon method
                Console.Clear();
                RestaurantOperation.AvgRatingOfRestaurants();
                Console.WriteLine("CalculateAllRestaurantAvgRating() Method implementation is in progress....");
                break;
            case "ViewRestaurantReview":
                //call SearchPokemon method
                Console.Clear();
                RestaurantOperation.ViewReviews();
                Console.WriteLine("DisplayRestaurantDetail() Method implementation is in progress....");
                break;
            case "ViewRestaurantDetails":
                //call SearchPokemon method
                Console.Clear();
                RestaurantOperation.ViewRestaurantDetails();
                Console.WriteLine("ViewRestaurantDetails() Method implementation is in progress....");
                break;
            case "AddUserReview":
                //call SearchPokemon method
                Console.Clear();
                RestaurantOperation.AddReview();
                Console.WriteLine("AddUserReview() Method implementation is in progress....");
                break;
            case "DisplayRestaurantDetail":
                //call SearchPokemon method
                Console.Clear();
                RestaurantOperation.DisplayRestaurantDetail();
                Console.WriteLine("DisplayRestaurantDetail() Method implementation is in progress....");
                break;
            case "SearchUserAsAdmin":
                //call SearchPokemon method
                Console.Clear();
                RestaurantOperation.SearchUserAsAdmin();
                Console.WriteLine("SearchUserAsAdmin() Method implementation is in progress....");
                break;
            case "MainMenu":
                Console.Clear();
             
                menu = new AdminUserMenu();
                break;
            case "Exit":
                Console.Clear();
                repeat = false;
                break;
            default:
                Console.WriteLine("View does not exist");
                Console.WriteLine("Please press <enter> to continue");
                Console.ReadLine();
                break;
        }
    }
}
else
{
    Console.Clear();
    Log.Information("Login failed");
    Console.WriteLine("Invalid credential.");
    Console.WriteLine("\n----------Login Failed!!----------\n");
    Environment.Exit(0);
}
