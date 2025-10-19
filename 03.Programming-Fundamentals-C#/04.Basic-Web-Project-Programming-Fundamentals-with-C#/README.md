# 📄 ParkingSystem-MVC

## Overview

This is a simple ASP.NET Core MVC application simulating a basic Parking System.  
The application manages cars in memory and supports the following functionality:

- Listing cars  
- Adding a car  
- Deleting a car  

**Note:** All Views and some resource files are provided by SoftUni and are not included in this repository due to copyright restrictions. The repository contains only the core logic implemented by the author.

---

---

## Code Implementation

### 1. Program.cs
```csharp
var builder = WebApplication.CreateBuilder(args);

// Add services to the container
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure HTTP request pipeline
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// Default route
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
```

---

### 2. Models/Car.cs
```
using System.ComponentModel.DataAnnotations;

namespace ParkingSystem.Models
{
    public class Car
    {
        [Required]
        public string CarMake { get; set; }

        [Required]
        public string PlateNumber { get; set; }
    }
}
```

---

### 3. Data/DataAccess.cs
```
using System.Collections.Generic;
using ParkingSystem.Models;

namespace ParkingSystem.Data
{
    public static class DataAccess
    {
        public static List<Car> Cars { get; } = new List<Car>();
    }
}
```

---

### 4. Controllers/HomeController.cs
```
using Microsoft.AspNetCore.Mvc;
using ParkingSystem.Data;

namespace ParkingSystem.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var cars = DataAccess.Cars;
            return View(cars);
        }
    }
}
```

---

### 5. Controllers/CarController.cs
```
using Microsoft.AspNetCore.Mvc;
using ParkingSystem.Data;
using ParkingSystem.Models;
using System.Linq;

namespace ParkingSystem.Controllers
{
    public class CarController : Controller
    {
        [HttpPost]
        public IActionResult AddCar(Car car)
        {
            if (ModelState.IsValid)
            {
                DataAccess.Cars.Add(car);
            }
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public IActionResult DeleteCar(string plateNumber)
        {
            var car = DataAccess.Cars.FirstOrDefault(c => c.PlateNumber == plateNumber);
            if (car != null)
            {
                DataAccess.Cars.Remove(car);
            }
            return RedirectToAction("Index", "Home");
        }
    }
}
```
## Notes

- Demonstrates MVC pattern in ASP.NET Core.  
- Views are intentionally omitted to avoid copyright issues.  
- Core logic for managing cars is fully implemented.
