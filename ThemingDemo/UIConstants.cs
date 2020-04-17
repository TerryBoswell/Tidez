using System;
using System.Collections.Generic;
using System.Text;

namespace Tidez
{
    public static class UIConstants
    {
        public enum Location
        {
            BowleysBar = 1112367,
            RockyPoint = 1112369,
            OCPier = 8570280,
            OCInlet = 8570283
        }
        public const string Bowleys_Bar = "Bowleys Bar";
        public const string Rockey_Point = "Rocky Point";
        public const string Ocean_City_Fishing_Pier = "Ocean City Fishing Pier";
        public const string Ocent_City_Inlet = "Ocean City Inlet";

        public static AllLocationOptions NumberOfLocationOptions = new AllLocationOptions
        {
            new LocationData { Description = Bowleys_Bar, Value = Location.BowleysBar },
            new LocationData { Description = Rockey_Point, Value = Location.RockyPoint },
            new LocationData { Description = Ocean_City_Fishing_Pier, Value = Location.OCPier },
            new LocationData { Description = Ocent_City_Inlet, Value = Location.OCInlet }
        };
        public static string SelectedLocation = Bowleys_Bar;
    }
    public class AllLocationOptions : List<LocationData>
    {
        public AllLocationOptions(params LocationData[] args)
        {
            this.AddRange(args);
        }

        public AllLocationOptions() { }
    }

    public class LocationData
    {
        public string Description { get; set; }
        public UIConstants.Location Value { get; set; }
    }
    //public static class RecipeUIConstants
    //{
    //    public static string RecipeNameLabel = "Recipe Name";
    //    public static string CookTimeLabel = "Cook Time";
    //    public static string IngredientsLabel = "Ingredients";
    //    public static string DirectionsLabel = "Directions";
    //    public static string NumberOfServingsLabel = "Number of Servings";

    //    public static Thickness PickerMargin = new Thickness(15, 0);

    //    public static AllServingOptions NumberOfServingsOptions = new AllServingOptions
    //{
    //    new ServingOption { Description = "Individual", Servings = 1 },
    //    new ServingOption { Description = "Family Sized", Servings = 4 },
    //    new ServingOption { Description = "Buffet", Servings = 12 }
    //};
    //}
}
