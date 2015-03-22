# Cubico
An extensive measurement, unit, & data conversion library for .NET.

## What can it be used for?
Taking and storing measurements reliably, performing calculations between different units of measurement, and sending measurements over webservices, making it very easy to work with! Also, it can be used as an extensible unit converter, providing the ability to easily add units of measurement and their calculations between units very easily and precisely.

### Example Usage
```csharp
var twoFeet = new Measurement(2, Units.Length.Feet);
var twelveInches = new Measurement(12, Units.Length.Inches);
var result = twoFeet + twelveInches;
Console.WriteLine(result.GetValueAs(Units.Length.Yards).ToString()); // = 1 yard
```
	
## Features
* Over 16 classes of units
* Over 130 units of measure
* One immutable type called "Measurement" that implements IEquatable, IComparable with operator overloads.
* Unit enum for easy browsing and finding of units.
* ToString implementation for easy string formatting.
* Easily extensible by editing an XML file.
* Over 2000 unit tests to ensure quality and precision.

## Unit Categories to Date
* Area
* Digital Storage (Bytes)
* Energy
* Fluid Volume
* Force
* Hexadecimals
* Length
* Mass
* Momentum
* Plane Angle
* Power
* Speed
* Temperature
* Time
* Volume
* Radioactivity

## Accuracy & Precision
The accuracy of unit conversions is one of the missions for this library. From experience, a lot of the unit converters out there are not precise, especially when scientific precision is needed. Since using double precision is not precise by definition, it becomes very hard to come up with unit conversions that are precise. This library has come up with approximately 2000 unit tests, each testing a conversion with various test scenarios.

## Installing
Run the following command in the Package Manager Console or go to the NuGet site for the complete relase history.

Install-Package Cubico

Build Targets:

* .Net 4.0 Full/Client
* .Net 4.5 Full/Client
* .NET 4.5.1

## Contributions
Feel free to add to the units of measure list.  All I ask is that you perform matching tests for each type of conversion.  Please follow the pattern performed in each test.

## License
Copyright 2012-2015 Ivan R. Perez & Taylor Shuler.

This software is licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except for what is in compliance with the License.

You may obtain a copy of this license at

```
http://www.apache.org/licenses/LICENSE-2.0
```

Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either expressed or implied.

See the License for the specific language governing permissions and limitations.
