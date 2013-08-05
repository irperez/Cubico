using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cubico
{
    public static class Units
    {

        public static class Length
        {
			public const string Feet = "Feet";
            public const string Inches = "Inches";
            public const string Meters = "Metre";
            public const string Yards = "Yard";
            public const string Chains = "Chain";
            public const string Miles = "Mile";
            public const string Kilometers = "Kilometre";
            public const string Megameters = "Megametre";
            public const string Gigameters = "Gigametre";
            public const string Millimeters = "Millimetre";
            public const string Furlong = "Furlong";
            public const string Thou = "Thou";
            public const string Microns = "Micron";
            public const string Centimeters = "Centimetre";
        }

        public static class Temperature
        {
            public const string Kelvin = "Kelvin";
            public const string Celsius = "Celsius";
            public const string Farenheit = "Farenheit";
            public const string Millikelvin = "Millikelvin";
            public const string Microkelvin = "Microkelvin";
            public const string Nanokelvin = "Nanokelvin";
            public const string Kilokelvin = "Kilokelvin";
            public const string Megakelvin = "Megakelvin";
            public const string Reaumur = "Reaumur";
            public const string Rankine = "Rankine";
        }

        public static class Mass
        {
            public const string Kilogram = "Kilogram";
            public const string Gram = "Gram";
            public const string Milligram = "Milligram";
            public const string Microgram = "Microgram";
            public const string Nanograms = "Nanogram";
            public const string Megagrams = "Megagram";
            public const string Gigagrams = "Gigagram";
            public const string Pounds = "Pounds";
            public const string Ounces = "Ounces";
            public const string MetricTons = "Tonne (Metric)";
            public const string Tons = "Ton (Short US)";
            public const string CWT = "CWT";
        }

        public static class Area 
        {
            public const string SquareMiles = "Square Mile";
            public const string SquareFeet = "Square Feet";
            public const string SquareInches = "Square Inch";
            public const string SquareMeters = "Square Metre";
            public const string Acres = "Acre";
            public const string SquareCentimeters = "Square centimeter";
            public const string SquareYards = "Square yard";
            public const string SquareKilometers = "Square kilometer";
            public const string Hectare = "Hectare";
        }
        public static class Time 
        {
            public const string Hours = "Hour";
            public const string Minutes = "Minute";
            public const string Seconds = "Second";
            public const string Milliseconds = "Millisecond";
            public const string Days = "Day";
            public const string Weeks = "Week";
        }
        public static class Speed 
        {
            public const string MetersPerSecond = "Metres per second";
            public const string KilometersPerHour = "Kilometres per hour";
            public const string MilesPerHour = "Miles per hour";
            public const string MetersPerMinute = "Metres per minute";
            public const string FeetPerSecond = "Feet per second";
        }
        public static class Force 
        {
            public const string Newtons = "Newton";
            public const string Dyne = "Dyne";
            public const string PoundsForce = "Pounds force";
            public const string TonsForce = "Tons force";
            public const string TonnesForce = "Tonnes force";
            public const string Meganewtons = "Meganewton";
            public const string Giganewtons = "Giganewton";
            public const string Kilonewtons = "Kilonewton";
            public const string Millinewtons = "Millinewton";
            public const string Micronewtons = "Micronewton";
            public const string Nanonewtons = "Nanonewton";
        }
        public static class Momentum 
        {
            public const string KilogramMetersPerSecond = "Kilogram metres per second";
            public const string PoundFeetPerHour = "Pound feet per hour";
            public const string GramCentimetersPerSecond = "Gram centimetres per second";
            public const string PoundFeetPerMinute = "Pound feet per minute";
            public const string PoundFeetPerSecond = "Pound feet per second";
        }
        public static class Power 
        {
            public const string Watts = "Watt";
            public const string Horsepower = "Horsepower";
            public const string Megawatts = "Megawatt";
            public const string Kilowatts = "Kilowatt";
            public const string Microwatts = "Microwatt";
            public const string Nanowatts = "Nanowatt";
            public const string Milliwatts = "Milliwatt";
            public const string BTUPerMinute = "BTU per minute";
            public const string FootPoundPerMinute = "Foot-pound per minute";
        }
        public static class Energy 
        {
            public const string Joules = "Joule";
            public const string Erg = "Erg";
            public const string Calories = "Calorie";
            public const string BTUs = "British thermal unit";
            public const string Therm = "Therm";
            public const string Millijoules = "Millijoule";
            public const string Megajoules = "Megajoule";
            public const string Kilojoules = "Kilojoule";
            public const string Gigajoules = "Gigajoule";
            public const string Microjoules = "Microjoule";
            public const string Nanojoules = "Nanojoule";
        }
        public static class PlaneAngle 
        {
            public const string Radians = "Radian";
            public const string Degrees = "Degree";
            public const string Gradian = "Gradian";
            public const string Revolutions = "Revolution";
        }
        public static class Volume 
        {
            public const string CubicInches = "Cubic inch";
            public const string CubicFeet = "Cubic foot";
            public const string CubicYards = "Cubic yard";
            public const string CubicMeters = "Cubic meter";
            public const string CubicCentimeters = "Cubic centimetre";
            public const string Liters = "Liter";
            public const string FluidOunces = "Fluid ounce (US)";
            public const string Gallons = "Gallons (US)";
            public const string Pint = "Pint";
            public const string Quart = "Quart";
        }
        //public static class FluidVolume { }
        public static class BloodPressure 
        {
            public const string MillimetersOfMercury = "Millimetres of mercury";
        }
        public static class Unit 
        {
            public const string Units = "Unit";
        }
        public static class AbsorbedRadiationDose 
        {
            public const string Centigray = "Centigray";
            public const string Milligray = "Milligray";
            public const string Microgray = "Microgray";
            public const string Kilogray = "Kilogray";
        }
        public static class Radioactivity 
        {
            public const string Curie = "Curie";
            public const string Millicurie = "Millicurie";
        }
        public static class CompoundEquivalentWeight 
        {
            public const string Equivalent = "Equivalent";
            public const string Milliequivalent = "Milliequivalent";
        }
        public static class MemorySize
        {
            public const string Bits = "bit";
            public const string Bytes = "byte";
            public const string Kilobits = "kilobit";
            public const string Kilobytes = "kilobbyte";
			public const string Megabits = "megabit";
			public const string Megabytes = "megabyte";
			public const string Gigabit = "gigabit";
            public const string Gigabytes = "gigabyte";
            public const string Terabits = "Terabits";
            public const string Terabytes = "Terabyte";
            public const string Petabits = "Petabits";
            public const string Petabytes = "Petabyte";
        }
    }
}
