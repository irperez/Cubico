# Cubico
An extensive Measurement & Unit Conversion library for .Net.

## What can it be used for?
Taking and storing measurements reliably and performing calculations even between different units of measure
and keeping the ability to send measurements over webservices while making it very easy to work with.  And of
course it can be used as an extensible unit converter giving the ability to easily add units of measure and their
calculation between units very easily and precisely.

## Example Usage

	var length = new Measurement(2, "ft");
	var add = new Measurement(12, "in");
	var result = length + add;
	Console.WriteLine(result.GetValueAs("yrd").ToString()); //1 yard
	
## Unit Categories to Date
Length, Temperature, Mass, Area, Volume, Time, Speed, Force, Momentum, Power, Energy, Plane Angle, Fluid Volume

## Accuracy & Precision
The accuracy of the unit conversions is one of the missions for this library.  From my experience, alot of the
unit converters out there are not precise especially when scientific precision is needed.  And since using
double precision is not precise by definition, it becomes very hard to come up with unit conversions that are
precise.  This library has come up with approximately 2000 unit tests testing each conversion with various test
scenarios.