APIVerve.API.WebsiteImagesScraper API
============

Web Image Scraper is a simple tool for scraping images from a website. It returns the URLs of the images found on the website.

![Build Status](https://img.shields.io/badge/build-passing-green)
![Code Climate](https://img.shields.io/badge/maintainability-B-purple)
![Prod Ready](https://img.shields.io/badge/production-ready-blue)

This is a .NET Wrapper for the [APIVerve.API.WebsiteImagesScraper API](https://apiverve.com/marketplace/webimagescraper)

---

## Installation

Using the .NET CLI:
```
dotnet add package APIVerve.API.WebsiteImagesScraper
```

Using the Package Manager:
```
nuget install APIVerve.API.WebsiteImagesScraper
```

Using the Package Manager Console:
```
Install-Package APIVerve.API.WebsiteImagesScraper
```

From within Visual Studio:

1. Open the Solution Explorer
2. Right-click on a project within your solution
3. Click on Manage NuGet Packages
4. Click on the Browse tab and search for "APIVerve.API.WebsiteImagesScraper"
5. Click on the APIVerve.API.WebsiteImagesScraper package, select the appropriate version in the right-tab and click Install

---

## Configuration

Before using the webimagescraper API client, you have to setup your account and obtain your API Key.
You can get it by signing up at [https://apiverve.com](https://apiverve.com)

---

## Quick Start

Here's a simple example to get you started quickly:

```csharp
using System;
using APIVerve;

class Program
{
    static async Task Main(string[] args)
    {
        // Initialize the API client
        var apiClient = new WebsiteImagesScraperAPIClient("[YOUR_API_KEY]");

        var queryOptions = new WebsiteImagesScraperQueryOptions {
  url = "https://en.wikipedia.org/wiki/Solar_System"
};

        // Make the API call
        try
        {
            var response = await apiClient.ExecuteAsync(queryOptions);

            if (response.Error != null)
            {
                Console.WriteLine($"API Error: {response.Error}");
            }
            else
            {
                Console.WriteLine("Success!");
                // Access response data using the strongly-typed ResponseObj properties
                Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(response, Newtonsoft.Json.Formatting.Indented));
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Exception: {ex.Message}");
        }
    }
}
```

---

## Usage

The APIVerve.API.WebsiteImagesScraper API documentation is found here: [https://docs.apiverve.com/ref/webimagescraper](https://docs.apiverve.com/ref/webimagescraper).
You can find parameters, example responses, and status codes documented here.

### Setup

###### Authentication
APIVerve.API.WebsiteImagesScraper API uses API Key-based authentication. When you create an instance of the API client, you can pass your API Key as a parameter.

```csharp
// Create an instance of the API client
var apiClient = new WebsiteImagesScraperAPIClient("[YOUR_API_KEY]");
```

---

## Usage Examples

### Basic Usage (Async/Await Pattern - Recommended)

The modern async/await pattern provides the best performance and code readability:

```csharp
using System;
using System.Threading.Tasks;
using APIVerve;

public class Example
{
    public static async Task Main(string[] args)
    {
        var apiClient = new WebsiteImagesScraperAPIClient("[YOUR_API_KEY]");

        var queryOptions = new WebsiteImagesScraperQueryOptions {
  url = "https://en.wikipedia.org/wiki/Solar_System"
};

        var response = await apiClient.ExecuteAsync(queryOptions);

        if (response.Error != null)
        {
            Console.WriteLine($"Error: {response.Error}");
        }
        else
        {
            Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(response, Newtonsoft.Json.Formatting.Indented));
        }
    }
}
```

### Synchronous Usage

If you need to use synchronous code, you can use the `Execute` method:

```csharp
using System;
using APIVerve;

public class Example
{
    public static void Main(string[] args)
    {
        var apiClient = new WebsiteImagesScraperAPIClient("[YOUR_API_KEY]");

        var queryOptions = new WebsiteImagesScraperQueryOptions {
  url = "https://en.wikipedia.org/wiki/Solar_System"
};

        var response = apiClient.Execute(queryOptions);

        if (response.Error != null)
        {
            Console.WriteLine($"Error: {response.Error}");
        }
        else
        {
            Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(response, Newtonsoft.Json.Formatting.Indented));
        }
    }
}
```

---

## Error Handling

The API client provides comprehensive error handling. Here are some examples:

### Handling API Errors

```csharp
using System;
using System.Threading.Tasks;
using APIVerve;

public class Example
{
    public static async Task Main(string[] args)
    {
        var apiClient = new WebsiteImagesScraperAPIClient("[YOUR_API_KEY]");

        var queryOptions = new WebsiteImagesScraperQueryOptions {
  url = "https://en.wikipedia.org/wiki/Solar_System"
};

        try
        {
            var response = await apiClient.ExecuteAsync(queryOptions);

            // Check for API-level errors
            if (response.Error != null)
            {
                Console.WriteLine($"API Error: {response.Error}");
                Console.WriteLine($"Status: {response.Status}");
                return;
            }

            // Success - use the data
            Console.WriteLine("Request successful!");
            Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(response, Newtonsoft.Json.Formatting.Indented));
        }
        catch (ArgumentException ex)
        {
            // Invalid API key or parameters
            Console.WriteLine($"Invalid argument: {ex.Message}");
        }
        catch (System.Net.Http.HttpRequestException ex)
        {
            // Network or HTTP errors
            Console.WriteLine($"Network error: {ex.Message}");
        }
        catch (Exception ex)
        {
            // Other errors
            Console.WriteLine($"Unexpected error: {ex.Message}");
        }
    }
}
```

### Comprehensive Error Handling with Retry Logic

```csharp
using System;
using System.Threading.Tasks;
using APIVerve;

public class Example
{
    public static async Task Main(string[] args)
    {
        var apiClient = new WebsiteImagesScraperAPIClient("[YOUR_API_KEY]");

        // Configure retry behavior (max 3 retries)
        apiClient.SetMaxRetries(3);        // Retry up to 3 times (default: 0, max: 3)
        apiClient.SetRetryDelay(2000);     // Wait 2 seconds between retries

        var queryOptions = new WebsiteImagesScraperQueryOptions {
  url = "https://en.wikipedia.org/wiki/Solar_System"
};

        try
        {
            var response = await apiClient.ExecuteAsync(queryOptions);

            if (response.Error != null)
            {
                Console.WriteLine($"API Error: {response.Error}");
            }
            else
            {
                Console.WriteLine("Success!");
                Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(response, Newtonsoft.Json.Formatting.Indented));
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Failed after retries: {ex.Message}");
        }
    }
}
```

---

## Advanced Features

### Custom Headers

Add custom headers to your requests:

```csharp
var apiClient = new WebsiteImagesScraperAPIClient("[YOUR_API_KEY]");

// Add custom headers
apiClient.AddCustomHeader("X-Custom-Header", "custom-value");
apiClient.AddCustomHeader("X-Request-ID", Guid.NewGuid().ToString());

var queryOptions = new WebsiteImagesScraperQueryOptions {
  url = "https://en.wikipedia.org/wiki/Solar_System"
};

var response = await apiClient.ExecuteAsync(queryOptions);

// Remove a header
apiClient.RemoveCustomHeader("X-Custom-Header");

// Clear all custom headers
apiClient.ClearCustomHeaders();
```

### Request Logging

Enable logging for debugging:

```csharp
var apiClient = new WebsiteImagesScraperAPIClient("[YOUR_API_KEY]", isDebug: true);

// Or use a custom logger
apiClient.SetLogger(message =>
{
    Console.WriteLine($"[LOG] {DateTime.Now:yyyy-MM-dd HH:mm:ss} - {message}");
});

var queryOptions = new WebsiteImagesScraperQueryOptions {
  url = "https://en.wikipedia.org/wiki/Solar_System"
};

var response = await apiClient.ExecuteAsync(queryOptions);
```

### Retry Configuration

Customize retry behavior for failed requests:

```csharp
var apiClient = new WebsiteImagesScraperAPIClient("[YOUR_API_KEY]");

// Set retry options
apiClient.SetMaxRetries(3);           // Retry up to 3 times (default: 0, max: 3)
apiClient.SetRetryDelay(1500);        // Wait 1.5 seconds between retries (default: 1000ms)

var queryOptions = new WebsiteImagesScraperQueryOptions {
  url = "https://en.wikipedia.org/wiki/Solar_System"
};

var response = await apiClient.ExecuteAsync(queryOptions);
```

### Dispose Pattern

The API client implements `IDisposable` for proper resource cleanup:

```csharp
using (var apiClient = new WebsiteImagesScraperAPIClient("[YOUR_API_KEY]"))
{
    var queryOptions = new WebsiteImagesScraperQueryOptions {
  url = "https://en.wikipedia.org/wiki/Solar_System"
};
    var response = await apiClient.ExecuteAsync(queryOptions);
    Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(response, Newtonsoft.Json.Formatting.Indented));
}
// HttpClient is automatically disposed here
```

---

## Example Response

```json
{
  "status": "ok",
  "error": null,
  "data": {
    "imageCount": 72,
    "images": [
      {
        "external": false,
        "src": "http://en.wikipedia.org/wiki/Solar_System/static/images/icons/wikipedia.png"
      },
      {
        "external": false,
        "src": "http://en.wikipedia.org/wiki/Solar_System/static/images/mobile/copyright/wikipedia-wordmark-en.svg"
      },
      {
        "external": false,
        "src": "http://en.wikipedia.org/wiki/Solar_System/static/images/mobile/copyright/wikipedia-tagline-en.svg"
      },
      {
        "external": false,
        "src": "http://en.wikipedia.org/wiki/Solar_System//upload.wikimedia.org/wikipedia/en/thumb/e/e7/Cscr-featured.svg/20px-Cscr-featured.svg.png"
      },
      {
        "external": false,
        "src": "http://en.wikipedia.org/wiki/Solar_System//upload.wikimedia.org/wikipedia/en/thumb/1/1b/Semi-protection-shackle.svg/20px-Semi-protection-shackle.svg.png"
      },
      {
        "external": false,
        "src": "http://en.wikipedia.org/wiki/Solar_System//upload.wikimedia.org/wikipedia/commons/thumb/4/47/Sound-icon.svg/20px-Sound-icon.svg.png"
      },
      {
        "external": false,
        "src": "http://en.wikipedia.org/wiki/Solar_System//upload.wikimedia.org/wikipedia/commons/thumb/1/19/Solar_System_true_color.jpg/290px-Solar_System_true_color.jpg"
      },
      {
        "external": false,
        "src": "http://en.wikipedia.org/wiki/Solar_System//upload.wikimedia.org/wikipedia/commons/thumb/a/ac/Solar_System_true_color_%28title_and_caption%29.jpg/290px-Solar_System_true_color_%28title_and_caption%29.jpg"
      },
      {
        "external": false,
        "src": "http://en.wikipedia.org/wiki/Solar_System//upload.wikimedia.org/wikipedia/commons/thumb/5/56/Soot-line1.jpg/300px-Soot-line1.jpg"
      },
      {
        "external": false,
        "src": "http://en.wikipedia.org/wiki/Solar_System//upload.wikimedia.org/wikipedia/commons/thumb/7/7c/Sun_red_giant.svg/220px-Sun_red_giant.svg.png"
      },
      {
        "external": false,
        "src": "http://en.wikipedia.org/wiki/Solar_System//upload.wikimedia.org/wikipedia/commons/thumb/c/cc/Solar_system_orrery_inner_planets.gif/220px-Solar_system_orrery_inner_planets.gif"
      },
      {
        "external": false,
        "src": "http://en.wikipedia.org/wiki/Solar_System//upload.wikimedia.org/wikipedia/commons/thumb/c/c1/Solar_system_orrery_outer_planets.gif/220px-Solar_system_orrery_outer_planets.gif"
      },
      {
        "external": false,
        "src": "http://en.wikipedia.org/wiki/Solar_System//upload.wikimedia.org/wikipedia/commons/thumb/d/df/Solar_System_distance_to_scale.svg/550px-Solar_System_distance_to_scale.svg.png"
      },
      {
        "external": false,
        "src": "http://en.wikipedia.org/wiki/Solar_System//upload.wikimedia.org/wikipedia/commons/thumb/f/f7/PIA21424_-_The_TRAPPIST-1_Habitable_Zone.jpg/338px-PIA21424_-_The_TRAPPIST-1_Habitable_Zone.jpg"
      },
      {
        "external": false,
        "src": "http://en.wikipedia.org/wiki/Solar_System//upload.wikimedia.org/wikipedia/commons/thumb/f/f0/Diagram_of_different_habitable_zone_regions_by_Chester_Harman.jpg/338px-Diagram_of_different_habitable_zone_regions_by_Chester_Harman.jpg"
      },
      {
        "external": false,
        "src": "http://en.wikipedia.org/wiki/Solar_System//upload.wikimedia.org/wikipedia/commons/thumb/8/83/The_Sun_in_white_light.jpg/220px-The_Sun_in_white_light.jpg"
      },
      {
        "external": false,
        "src": "http://en.wikipedia.org/wiki/Solar_System//upload.wikimedia.org/wikipedia/commons/thumb/d/d7/Terrestrial_planet_sizes_3.jpg/220px-Terrestrial_planet_sizes_3.jpg"
      },
      {
        "external": false,
        "src": "http://en.wikipedia.org/wiki/Solar_System//upload.wikimedia.org/wikipedia/commons/thumb/1/11/Inner_solar_system_objects_top_view_for_wiki.png/220px-Inner_solar_system_objects_top_view_for_wiki.png"
      },
      {
        "external": false,
        "src": "http://en.wikipedia.org/wiki/Solar_System//upload.wikimedia.org/wikipedia/commons/thumb/8/86/The_Four_Largest_Asteroids.jpg/220px-The_Four_Largest_Asteroids.jpg"
      },
      {
        "external": false,
        "src": "http://en.wikipedia.org/wiki/Solar_System//upload.wikimedia.org/wikipedia/commons/thumb/6/67/Planet_collage_to_scale_%28captioned%29.jpg/220px-Planet_collage_to_scale_%28captioned%29.jpg"
      },
      {
        "external": false,
        "src": "http://en.wikipedia.org/wiki/Solar_System//upload.wikimedia.org/wikipedia/commons/thumb/5/5b/Kuiper_belt_plot_objects_of_outer_solar_system.png/220px-Kuiper_belt_plot_objects_of_outer_solar_system.png"
      },
      {
        "external": false,
        "src": "http://en.wikipedia.org/wiki/Solar_System//upload.wikimedia.org/wikipedia/commons/thumb/e/ed/TheKuiperBelt_classes-en.svg/220px-TheKuiperBelt_classes-en.svg.png"
      },
      {
        "external": false,
        "src": "http://en.wikipedia.org/wiki/Solar_System//upload.wikimedia.org/wikipedia/commons/thumb/5/58/TheKuiperBelt_Projections_100AU_Classical_SDO.svg/220px-TheKuiperBelt_Projections_100AU_Classical_SDO.svg.png"
      },
      {
        "external": false,
        "src": "http://en.wikipedia.org/wiki/Solar_System//upload.wikimedia.org/wikipedia/commons/thumb/5/56/Distant_object_orbits_%2B_Planet_Nine.png/290px-Distant_object_orbits_%2B_Planet_Nine.png"
      },
      {
        "external": false,
        "src": "http://en.wikipedia.org/wiki/Solar_System//upload.wikimedia.org/wikipedia/commons/thumb/f/f0/Magnetosphere_Levels.jpg/220px-Magnetosphere_Levels.jpg"
      },
      {
        "external": false,
        "src": "http://en.wikipedia.org/wiki/Solar_System//upload.wikimedia.org/wikipedia/commons/thumb/b/ba/Comet_Hale-Bopp_1995O1.jpg/220px-Comet_Hale-Bopp_1995O1.jpg"
      },
      {
        "external": false,
        "src": "http://en.wikipedia.org/wiki/Solar_System//upload.wikimedia.org/wikipedia/commons/thumb/2/2d/Meteor_shower_in_the_Chilean_Desert_%28annotated_and_cropped%29.jpg/220px-Meteor_shower_in_the_Chilean_Desert_%28annotated_and_cropped%29.jpg"
      },
      {
        "external": false,
        "src": "http://en.wikipedia.org/wiki/Solar_System//upload.wikimedia.org/wikipedia/commons/thumb/5/56/Kuiper_belt_-_Oort_cloud-en.svg/220px-Kuiper_belt_-_Oort_cloud-en.svg.png"
      },
      {
        "external": false,
        "src": "http://en.wikipedia.org/wiki/Solar_System//upload.wikimedia.org/wikipedia/commons/thumb/1/1f/Interstellar_medium_annotated.jpg/550px-Interstellar_medium_annotated.jpg"
      },
      {
        "external": false,
        "src": "http://en.wikipedia.org/wiki/Solar_System//upload.wikimedia.org/wikipedia/commons/thumb/7/7c/The_Local_Interstellar_Cloud_and_neighboring_G-cloud_complex.svg/220px-The_Local_Interstellar_Cloud_and_neighboring_G-cloud_complex.svg.png"
      },
      {
        "external": false,
        "src": "http://en.wikipedia.org/wiki/Solar_System//upload.wikimedia.org/wikipedia/commons/thumb/1/19/Milky_Way_side_view.png/220px-Milky_Way_side_view.png"
      },
      {
        "external": false,
        "src": "http://en.wikipedia.org/wiki/Solar_System//upload.wikimedia.org/wikipedia/commons/thumb/7/70/Apparent_retrograde_motion_of_Mars_in_2003.gif/220px-Apparent_retrograde_motion_of_Mars_in_2003.gif"
      },
      {
        "external": false,
        "src": "http://en.wikipedia.org/wiki/Solar_System//upload.wikimedia.org/wikipedia/commons/thumb/4/4e/The_Solar_System%2C_with_the_orbits_of_5_remarkable_comets._LOC_2013593161_%28cropped%29.jpg/220px-The_Solar_System%2C_with_the_orbits_of_5_remarkable_comets._LOC_2013593161_%28cropped%29.jpg"
      },
      {
        "external": false,
        "src": "http://en.wikipedia.org/wiki/Solar_System//upload.wikimedia.org/wikipedia/commons/thumb/8/83/Solar_system.jpg/22px-Solar_system.jpg"
      },
      {
        "external": false,
        "src": "http://en.wikipedia.org/wiki/Solar_System//upload.wikimedia.org/wikipedia/commons/thumb/5/5c/Earth-moon.jpg/32px-Earth-moon.jpg"
      },
      {
        "external": false,
        "src": "http://en.wikipedia.org/wiki/Solar_System//upload.wikimedia.org/wikipedia/commons/thumb/0/00/Crab_Nebula.jpg/28px-Crab_Nebula.jpg"
      },
      {
        "external": true,
        "src": "https://wikimedia.org/api/rest_v1/media/math/render/svg/45e5789e5d9c8f7c79744f43ecaaf8ba42a8553a"
      },
      {
        "external": true,
        "src": "https://wikimedia.org/api/rest_v1/media/math/render/svg/0355a973ffa402dc57f8f4371f702db85b17e989"
      },
      {
        "external": true,
        "src": "https://wikimedia.org/api/rest_v1/media/math/render/svg/876ecaef49f096f44b57f0258336275f8ba3a373"
      },
      {
        "external": true,
        "src": "https://wikimedia.org/api/rest_v1/media/math/render/svg/db73983682cbebba39553ac1760903b39e050466"
      },
      {
        "external": true,
        "src": "https://wikimedia.org/api/rest_v1/media/math/render/svg/ea2097c0262c82b8e921dfcc2cc9873e238bc31c"
      },
      {
        "external": true,
        "src": "https://wikimedia.org/api/rest_v1/media/math/render/svg/5a386d5764fd35c853376fd570d4c46300b19867"
      },
      {
        "external": false,
        "src": "http://en.wikipedia.org/wiki/Solar_System//upload.wikimedia.org/wikipedia/en/thumb/6/62/PD-icon.svg/12px-PD-icon.svg.png"
      },
      {
        "external": false,
        "src": "http://en.wikipedia.org/wiki/Solar_System//upload.wikimedia.org/wikipedia/en/thumb/6/62/PD-icon.svg/12px-PD-icon.svg.png"
      },
      {
        "external": false,
        "src": "http://en.wikipedia.org/wiki/Solar_System//upload.wikimedia.org/wikipedia/commons/thumb/4/47/Sound-icon.svg/45px-Sound-icon.svg.png"
      },
      {
        "external": false,
        "src": "http://en.wikipedia.org/wiki/Solar_System//upload.wikimedia.org/wikipedia/en/thumb/0/06/Wiktionary-logo-v2.svg/19px-Wiktionary-logo-v2.svg.png"
      },
      {
        "external": false,
        "src": "http://en.wikipedia.org/wiki/Solar_System//upload.wikimedia.org/wikipedia/en/thumb/4/4a/Commons-logo.svg/14px-Commons-logo.svg.png"
      },
      {
        "external": false,
        "src": "http://en.wikipedia.org/wiki/Solar_System//upload.wikimedia.org/wikipedia/commons/thumb/2/24/Wikinews-logo.svg/21px-Wikinews-logo.svg.png"
      },
      {
        "external": false,
        "src": "http://en.wikipedia.org/wiki/Solar_System//upload.wikimedia.org/wikipedia/commons/thumb/f/fa/Wikiquote-logo.svg/16px-Wikiquote-logo.svg.png"
      },
      {
        "external": false,
        "src": "http://en.wikipedia.org/wiki/Solar_System//upload.wikimedia.org/wikipedia/commons/thumb/4/4c/Wikisource-logo.svg/18px-Wikisource-logo.svg.png"
      },
      {
        "external": false,
        "src": "http://en.wikipedia.org/wiki/Solar_System//upload.wikimedia.org/wikipedia/commons/thumb/f/fa/Wikibooks-logo.svg/19px-Wikibooks-logo.svg.png"
      },
      {
        "external": false,
        "src": "http://en.wikipedia.org/wiki/Solar_System//upload.wikimedia.org/wikipedia/commons/thumb/0/0b/Wikiversity_logo_2017.svg/21px-Wikiversity_logo_2017.svg.png"
      },
      {
        "external": false,
        "src": "http://en.wikipedia.org/wiki/Solar_System//upload.wikimedia.org/wikipedia/commons/thumb/f/ff/Wikidata-logo.svg/21px-Wikidata-logo.svg.png"
      },
      {
        "external": false,
        "src": "http://en.wikipedia.org/wiki/Solar_System//upload.wikimedia.org/wikipedia/commons/4/43/Solar_System_Template_2.png"
      },
      {
        "external": false,
        "src": "http://en.wikipedia.org/wiki/Solar_System//upload.wikimedia.org/wikipedia/commons/thumb/8/83/Solar_system.jpg/22px-Solar_system.jpg"
      },
      {
        "external": false,
        "src": "http://en.wikipedia.org/wiki/Solar_System//upload.wikimedia.org/wikipedia/commons/thumb/0/00/Crab_Nebula.jpg/28px-Crab_Nebula.jpg"
      },
      {
        "external": false,
        "src": "http://en.wikipedia.org/wiki/Solar_System//upload.wikimedia.org/wikipedia/commons/thumb/4/43/The_Earth_seen_from_Apollo_17_with_transparent_background.png/28px-The_Earth_seen_from_Apollo_17_with_transparent_background.png"
      },
      {
        "external": false,
        "src": "http://en.wikipedia.org/wiki/Solar_System//upload.wikimedia.org/wikipedia/en/thumb/e/e2/Symbol_portal_class.svg/16px-Symbol_portal_class.svg.png"
      },
      {
        "external": false,
        "src": "http://en.wikipedia.org/wiki/Solar_System//upload.wikimedia.org/wikipedia/en/thumb/e/e2/Symbol_portal_class.svg/16px-Symbol_portal_class.svg.png"
      },
      {
        "external": false,
        "src": "http://en.wikipedia.org/wiki/Solar_System//upload.wikimedia.org/wikipedia/en/thumb/9/96/Symbol_category_class.svg/16px-Symbol_category_class.svg.png"
      },
      {
        "external": false,
        "src": "http://en.wikipedia.org/wiki/Solar_System//upload.wikimedia.org/wikipedia/en/thumb/4/4a/Commons-logo.svg/12px-Commons-logo.svg.png"
      },
      {
        "external": false,
        "src": "http://en.wikipedia.org/wiki/Solar_System//upload.wikimedia.org/wikipedia/en/thumb/9/96/Symbol_category_class.svg/16px-Symbol_category_class.svg.png"
      },
      {
        "external": false,
        "src": "http://en.wikipedia.org/wiki/Solar_System//upload.wikimedia.org/wikipedia/commons/thumb/5/5f/He1523a.jpg/14px-He1523a.jpg"
      },
      {
        "external": false,
        "src": "http://en.wikipedia.org/wiki/Solar_System//upload.wikimedia.org/wikipedia/en/thumb/e/e4/SaganWalk.0.Sun.jpg/70px-SaganWalk.0.Sun.jpg"
      },
      {
        "external": false,
        "src": "http://en.wikipedia.org/wiki/Solar_System//upload.wikimedia.org/wikipedia/en/thumb/8/8a/OOjs_UI_icon_edit-ltr-progressive.svg/10px-OOjs_UI_icon_edit-ltr-progressive.svg.png"
      },
      {
        "external": false,
        "src": "http://en.wikipedia.org/wiki/Solar_System//upload.wikimedia.org/wikipedia/commons/thumb/8/83/Solar_system.jpg/15px-Solar_system.jpg"
      },
      {
        "external": false,
        "src": "http://en.wikipedia.org/wiki/Solar_System//upload.wikimedia.org/wikipedia/commons/thumb/0/00/Crab_Nebula.jpg/19px-Crab_Nebula.jpg"
      },
      {
        "external": false,
        "src": "http://en.wikipedia.org/wiki/Solar_System//upload.wikimedia.org/wikipedia/commons/thumb/4/43/The_Earth_seen_from_Apollo_17_with_transparent_background.png/19px-The_Earth_seen_from_Apollo_17_with_transparent_background.png"
      },
      {
        "external": false,
        "src": "http://en.wikipedia.org/wiki/Solar_System//upload.wikimedia.org/wikipedia/commons/thumb/5/5f/He1523a.jpg/16px-He1523a.jpg"
      },
      {
        "external": false,
        "src": "http://en.wikipedia.org/wiki/Solar_System//upload.wikimedia.org/wikipedia/commons/thumb/d/d6/RocketSunIcon.svg/19px-RocketSunIcon.svg.png"
      },
      {
        "external": false,
        "src": "http://en.wikipedia.org/wiki/Solar_System/static/images/footer/wikimedia-button.svg"
      },
      {
        "external": false,
        "src": "http://en.wikipedia.org/wiki/Solar_System/w/resources/assets/mediawiki_compact.svg"
      }
    ],
    "maxLinksReached": false,
    "url": "http://en.wikipedia.org/wiki/Solar_System"
  }
}
```

---

## Customer Support

Need any assistance? [Get in touch with Customer Support](https://apiverve.com/contact).

---

## Updates
Stay up to date by following [@apiverveHQ](https://twitter.com/apiverveHQ) on Twitter.

---

## Legal

All usage of the APIVerve website, API, and services is subject to the [APIVerve Terms of Service](https://apiverve.com/terms) and all legal documents and agreements.

---

## License
Licensed under the The MIT License (MIT)

Copyright (&copy;) 2025 APIVerve, and EvlarSoft LLC

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
