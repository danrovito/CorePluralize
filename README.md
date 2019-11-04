![](https://github.com/danrovito/Pluralize.NET.Core/workflows/Main%20Workflow/badge.svg)

# What is it?
This is a C# port of Blake Embrey's [pluralize](https://github.com/blakeembrey/pluralize) library which helps in pluralizing or singularizing any English word.

# How
**Install from NuGet**
```
Install-Package Pluralize.NET.Core
```

**Include using directive**
```C#
using Pluralize.NET.Core
```
**Write code**
```C#
var singular = new Pluralizer().Singularize("Horses");
var plural = new Pluralizer().Pluralize("Horse");
```

**Profit!**

# Licence
[MIT](https://github.com/sarathkcm/Pluralize.NET/blob/master/LICENCE) - because the original project is MIT
