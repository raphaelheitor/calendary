[![Build Status](https://travis-ci.org/raphaelheitor/calendary.svg?branch=master)](https://travis-ci.org/raphaelheitor/calendary)
[![NuGet](http://img.shields.io/nuget/v/calendary.svg?style=flat)](https://www.nuget.org/packages/calendary/)
# Calendary
Library created to help work with dates and periods.

Functions already available:

####DateTimeExtension (remember, add using ExtensionMethods;)
#####Tomorrow:
```csharp
DateTime date = new DateTime(2016, 9, 5);
date.Tomorrow(); //9-6-2016
```
#####Yesterday:
```csharp
DateTime date = new DateTime(2016, 9, 5);
date.Yesterday(); //9-4-2016
```
#####Age:
```csharp
DateTime date = DateTime.Now.AddYears(-20).AddDays(5);
date.Age(); //19
```
#####AgeInDays:
```csharp
DateTime date = DateTime.Now.AddDays(-15);
date.AgeInDays(); //15
```
#####Next DayofWeek
```csharp
DateTime date = new DateTime(2016, 10, 16);
date.NextSunday().Date; //2016-10-23
//all week days
```
#####Last DayofWeek
```csharp
DateTime date = new DateTime(2016, 10, 23);
date.LastSunday().Date; //2016-10-16
//all week days
```
#####DateTimeExtension (Checker)
######Between:
```csharp
DateTime date = new DateTime(2016, 10, 21);
DateTime first = new DateTime(2016, 10, 20);
DateTime last = new DateTime(2016, 10, 25);
date.Between(first, last); //true
```
######Birthday:
```csharp
DateTime born = new DateTime(1990, 10, 20);
DateTime birthday = new DateTime(2016, 10, 20);
born.IsBirthday(birthday); //true
born.IsBirthday(); //false (based on actual date)
```
######Future:
```csharp
DateTime date = new DateTime(2090, 10, 20);
date.IsFuture(); //true
```
######Past:
```csharp
DateTime date = new DateTime(1990, 10, 20);
date.IsPast(); //true
```
######DayOfWeek:
```csharp
DateTime date = new DateTime(2016, 10, 21);
date.IsFriday(); //true
date.IsSaturday(); //false
date.IsSunday(); //false
date.IsMonday(); //false
date.IsTuesday(); //false
date.IsWednesday(); //false
date.IsThursday(); //false
```
####DatePeriod
#####Period:
```csharp
DateTime init = DateTime.Now;
DateTime end = DateTime.Now.AddDays(5);
DatePeriod dp = new DatePeriod(init, end);
dp.Period(); //return list of date in period
```
#####PeriodWithBusinessDaysOnly:
```csharp
DateTime init = DateTime.Now;
DateTime end = DateTime.Now.AddDays(5);
DatePeriod dp = new DatePeriod(init, end);
dp.PeriodWithBusinessDaysOnly(); //return list of date in period(removing not business days)
```
#####Period with exception list:
```csharp
var except = new List<DateTime>();
except.Add(DateTime.Now.AddDays(1));

DateTime init = DateTime.Now;
DateTime end = DateTime.Now.AddDays(5);
DatePeriod dp = new DatePeriod(init, end, except);
dp.Period(); //return list of date in period, removing a exception dates
```
#####PeriodWithBusinessDaysOnly with exception list:
```csharp
var except = new List<DateTime>();
except.Add(DateTime.Now.AddDays(1));

DateTime init = DateTime.Now;
DateTime end = DateTime.Now.AddDays(5);
DatePeriod dp = new DatePeriod(init, end, except);
dp.PeriodWithBusinessDaysOnly(); //return list of date in period(removing not business days), removing a exception dates
```
