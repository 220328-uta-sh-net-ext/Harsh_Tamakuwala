﻿using System;
using RestaurantDl;
using RestaurantModel;

namespace RestaurantBl
{
    public class AddRestaurant
    {
        public AddRestaurant()
        {
        }
        RestaurantRepository restaurantRepository = new RestaurantRepository();
        RestaurantModelClass restaurantModelClass = new RestaurantModelClass();

        public void AddNewRestaurant()
        {

            Console.WriteLine("\n----------Restaurant Details----------\n");
        nameSection:
            Console.Write("Restaurant Name: ");
            try
            {
                restaurantModelClass.RestaurantName = Console.ReadLine();
            }
            catch
            {
                Console.WriteLine("restaurant name should not be empty!");
                goto nameSection;
            }

            Console.Write("Restaurant AddressLine1: ");
            restaurantModelClass.Address1 = Console.ReadLine();

            Console.Write("Restaurant City: ");
            restaurantModelClass.city = Console.ReadLine();

            Console.Write("Restaurant state: ");
            restaurantModelClass.state = Console.ReadLine();

        zipSection:
            Console.Write("Restaurant Zip Code: ");
            try
            {
                restaurantModelClass.ZipCode = Console.ReadLine();
            }
            catch
            {
                Console.WriteLine("restaurant zipcode should not be empty!");
                goto zipSection;
            }

            Console.Write("Restaurant Cost Type($,$$,$$$): ");
            restaurantModelClass.CostType = Console.ReadLine();

            Console.Write("Restaurant Website: ");
            restaurantModelClass.Website = Console.ReadLine();

        contactSection:
            Console.Write("Restaurant Contact No: ");
       
            try
            {
                restaurantModelClass.ContactNo = Convert.ToDecimal(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter valid contact number!!");
                goto contactSection;
            }

            var result = restaurantRepository.AddItemToDB(restaurantModelClass);
            if (result == "Restaurant Added!!!")
            {
                Log.Information("Restaurant successfully added");
                Console.WriteLine("Restaurant Added!!!");
            }
            else
            {
                Log.Information(" faild : ", result.ToString());
                Console.WriteLine("\nSometing went wrong. please try again!!");
            }
        }
    }
}

