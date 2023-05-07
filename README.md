# UnitConversion

## Introduction
  Application is use to convert metric unit to imerial unit and vice versa.
  
## Technical Requirement
  Dot Net 6,
  Visual Studio 2022,
  SQL Server 2012

## Information for Developer
  Unit Conversion Get api is used for unit conversion
**_Conversion?unitName=temperature&unitType=c&unitValue=5_**
  
  Conversion Rate is fetched from SQL and Entity Framework is used as ORM for that.
  Calculation is done in the Service layer for unit.
  
  Application is configured for 3 units TEMPERATURE(F-C vice versa),Weight(kg-Pound vice versa),
  CAPACITY(Litre to galloon vice versa).
  
  Application also has unit test using nunit framework.
  
 ## How to run application
  
  Request to the api call
  
  UnitName - Name of the unit e.g. Temperature 
  Unit Type - Type of the unit to which you want to convert. e.g. C (Fahrenheit to Celsius)      
  UnitValue - Value to be converted e.g. 5
  
  This input will give output as 
    
    -15C  
   
