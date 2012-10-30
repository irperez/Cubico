using System;

public class UnitTestCategory
{

    //Integration Test: Relies on external dependencies in order to complete, such as a database, file system or network.
    public const string Integration = "Integration";

    //Unit Test occurs within the code.
    public const string Unit = "Unit";

    //CRUD Test: The test performs Create, Retrieve, Update, Delete calls on the database.
    public const string CRUD = "CRUD";

    //Unit Test takes more than 3 seconds.
    public const string SlowTest = "SlowTest";

    //Unit Test specifically for unit conversions drawing from the database.
    public const string UnitConversion = "UnitConversion";

    //Unit Test for expected exceptions.
    public const string ExceptionTest = "ExceptionTest";

}

