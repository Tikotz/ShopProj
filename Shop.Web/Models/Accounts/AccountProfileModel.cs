using Shop.Web.Models.Order;
using Shop.Web.Views.Food;
using System;
using System.Globalization;

namespace Shop.Web.Models.Accounts
{
    public class AccountProfileModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string PhoneNumber{ get; set; }
        public string Email { get; set; }
        public string ImageUrl { get; set; }
        public decimal Balance { get; set; }
        public string BalanceFormat{ get => Balance.ToString("c", CultureInfo.CreateSpecificCulture("en-US")); }
        public string AdressLine1 { get; set; }
        public string AdressLine2 { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public DateTime MemberSince { get; set; }
        public int OrederCount { get; set; }
        public string Role { get; set; }
        public decimal TotalSpent { get; set; }
        public string TotalSpentFormat { get => TotalSpent.ToString("c", CultureInfo.CreateSpecificCulture("en-US")) ;}
        public IEquatable<OrderIndexModel> LatestOrders { get; set; }
        public IEquatable<FoodSummaryModel> MostPopularFoods { get; set; }
    }

}
