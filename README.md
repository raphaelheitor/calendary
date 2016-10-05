[![Build Status](https://travis-ci.org/raphaelheitor/calendary.svg?branch=master)](https://travis-ci.org/raphaelheitor/calendary)
# Calendary
Library created to help work with dates and periods.

Functions already available:

####DateTimeExtension
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
