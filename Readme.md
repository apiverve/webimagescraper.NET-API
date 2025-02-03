Website Images Scraper API
============

Web Image Scraper is a simple tool for scraping images from a website. It returns the URLs of the images found on the website.

![Build Status](https://img.shields.io/badge/build-passing-green)
![Code Climate](https://img.shields.io/badge/maintainability-B-purple)
![Prod Ready](https://img.shields.io/badge/production-ready-blue)

This is a .NET Wrapper for the [Website Images Scraper API](https://apiverve.com/marketplace/api/webimagescraper)

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

1. Open the Solution Explorer.
2. Right-click on a project within your solution.
3. Click on Manage NuGet Packages...
4. Click on the Browse tab and search for "APIVerve.API.WebsiteImagesScraper".
5. Click on the APIVerve.API.WebsiteImagesScraper package, select the appropriate version in the right-tab and click Install.


---

## Configuration

Before using the webimagescraper API client, you have to setup your account and obtain your API Key.  
You can get it by signing up at [https://apiverve.com](https://apiverve.com)

---

## Usage

The Website Images Scraper API documentation is found here: [https://docs.apiverve.com/api/webimagescraper](https://docs.apiverve.com/api/webimagescraper).  
You can find parameters, example responses, and status codes documented here.

### Setup

###### Authentication
Website Images Scraper API uses API Key-based authentication. When you create an instance of the API client, you can pass your API Key as a parameter.

```
// Create an instance of the API client
var apiClient = new WebsiteImagesScraperAPIClient("[YOUR_API_KEY]", true);
```

---


### Perform Request
Using the API client, you can perform requests to the API.

###### Define Query

```
var queryOptions = new WebsiteImagesScraperQueryOptions {
  url = "https://en.wikipedia.org/wiki/Solar_System"
};
```

###### Simple Request

```
var response = apiClient.Execute(queryOptions);
if(response.error != null) {
	Console.WriteLine(response.error);
} else {
    var jsonResponse = JsonConvert.SerializeObject(response, Newtonsoft.Json.Formatting.Indented);
    Console.WriteLine(jsonResponse);
}
```

###### Example Response

```
{
  "status": "ok",
  "error": null,
  "data": {
    "url": "http://en.wikipedia.org/wiki/Solar_System",
    "imageCount": 72,
    "images": [
      {
        "src": "http://en.wikipedia.org/wiki/Solar_System/static/images/icons/wikipedia.png",
        "external": false
      },
      {
        "src": "http://en.wikipedia.org/wiki/Solar_System/static/images/mobile/copyright/wikipedia-wordmark-en.svg",
        "external": false
      },
      {
        "src": "http://en.wikipedia.org/wiki/Solar_System/static/images/mobile/copyright/wikipedia-tagline-en.svg",
        "external": false
      },
      {
        "src": "http://en.wikipedia.org/wiki/Solar_System//upload.wikimedia.org/wikipedia/en/thumb/e/e7/Cscr-featured.svg/20px-Cscr-featured.svg.png",
        "external": false
      },
      {
        "src": "http://en.wikipedia.org/wiki/Solar_System//upload.wikimedia.org/wikipedia/en/thumb/1/1b/Semi-protection-shackle.svg/20px-Semi-protection-shackle.svg.png",
        "external": false
      },
      {
        "src": "http://en.wikipedia.org/wiki/Solar_System//upload.wikimedia.org/wikipedia/commons/thumb/4/47/Sound-icon.svg/20px-Sound-icon.svg.png",
        "external": false
      },
      {
        "src": "http://en.wikipedia.org/wiki/Solar_System//upload.wikimedia.org/wikipedia/commons/thumb/1/19/Solar_System_true_color.jpg/290px-Solar_System_true_color.jpg",
        "external": false
      },
      {
        "src": "http://en.wikipedia.org/wiki/Solar_System//upload.wikimedia.org/wikipedia/commons/thumb/a/ac/Solar_System_true_color_%28title_and_caption%29.jpg/290px-Solar_System_true_color_%28title_and_caption%29.jpg",
        "external": false
      },
      {
        "src": "http://en.wikipedia.org/wiki/Solar_System//upload.wikimedia.org/wikipedia/commons/thumb/5/56/Soot-line1.jpg/300px-Soot-line1.jpg",
        "external": false
      },
      {
        "src": "http://en.wikipedia.org/wiki/Solar_System//upload.wikimedia.org/wikipedia/commons/thumb/7/7c/Sun_red_giant.svg/220px-Sun_red_giant.svg.png",
        "external": false
      },
      {
        "src": "http://en.wikipedia.org/wiki/Solar_System//upload.wikimedia.org/wikipedia/commons/thumb/c/cc/Solar_system_orrery_inner_planets.gif/220px-Solar_system_orrery_inner_planets.gif",
        "external": false
      },
      {
        "src": "http://en.wikipedia.org/wiki/Solar_System//upload.wikimedia.org/wikipedia/commons/thumb/c/c1/Solar_system_orrery_outer_planets.gif/220px-Solar_system_orrery_outer_planets.gif",
        "external": false
      },
      {
        "src": "http://en.wikipedia.org/wiki/Solar_System//upload.wikimedia.org/wikipedia/commons/thumb/d/df/Solar_System_distance_to_scale.svg/550px-Solar_System_distance_to_scale.svg.png",
        "external": false
      },
      {
        "src": "http://en.wikipedia.org/wiki/Solar_System//upload.wikimedia.org/wikipedia/commons/thumb/f/f7/PIA21424_-_The_TRAPPIST-1_Habitable_Zone.jpg/338px-PIA21424_-_The_TRAPPIST-1_Habitable_Zone.jpg",
        "external": false
      },
      {
        "src": "http://en.wikipedia.org/wiki/Solar_System//upload.wikimedia.org/wikipedia/commons/thumb/f/f0/Diagram_of_different_habitable_zone_regions_by_Chester_Harman.jpg/338px-Diagram_of_different_habitable_zone_regions_by_Chester_Harman.jpg",
        "external": false
      },
      {
        "src": "http://en.wikipedia.org/wiki/Solar_System//upload.wikimedia.org/wikipedia/commons/thumb/8/83/The_Sun_in_white_light.jpg/220px-The_Sun_in_white_light.jpg",
        "external": false
      },
      {
        "src": "http://en.wikipedia.org/wiki/Solar_System//upload.wikimedia.org/wikipedia/commons/thumb/d/d7/Terrestrial_planet_sizes_3.jpg/220px-Terrestrial_planet_sizes_3.jpg",
        "external": false
      },
      {
        "src": "http://en.wikipedia.org/wiki/Solar_System//upload.wikimedia.org/wikipedia/commons/thumb/1/11/Inner_solar_system_objects_top_view_for_wiki.png/220px-Inner_solar_system_objects_top_view_for_wiki.png",
        "external": false
      },
      {
        "src": "http://en.wikipedia.org/wiki/Solar_System//upload.wikimedia.org/wikipedia/commons/thumb/8/86/The_Four_Largest_Asteroids.jpg/220px-The_Four_Largest_Asteroids.jpg",
        "external": false
      },
      {
        "src": "http://en.wikipedia.org/wiki/Solar_System//upload.wikimedia.org/wikipedia/commons/thumb/6/67/Planet_collage_to_scale_%28captioned%29.jpg/220px-Planet_collage_to_scale_%28captioned%29.jpg",
        "external": false
      },
      {
        "src": "http://en.wikipedia.org/wiki/Solar_System//upload.wikimedia.org/wikipedia/commons/thumb/5/5b/Kuiper_belt_plot_objects_of_outer_solar_system.png/220px-Kuiper_belt_plot_objects_of_outer_solar_system.png",
        "external": false
      },
      {
        "src": "http://en.wikipedia.org/wiki/Solar_System//upload.wikimedia.org/wikipedia/commons/thumb/e/ed/TheKuiperBelt_classes-en.svg/220px-TheKuiperBelt_classes-en.svg.png",
        "external": false
      },
      {
        "src": "http://en.wikipedia.org/wiki/Solar_System//upload.wikimedia.org/wikipedia/commons/thumb/5/58/TheKuiperBelt_Projections_100AU_Classical_SDO.svg/220px-TheKuiperBelt_Projections_100AU_Classical_SDO.svg.png",
        "external": false
      },
      {
        "src": "http://en.wikipedia.org/wiki/Solar_System//upload.wikimedia.org/wikipedia/commons/thumb/5/56/Distant_object_orbits_%2B_Planet_Nine.png/290px-Distant_object_orbits_%2B_Planet_Nine.png",
        "external": false
      },
      {
        "src": "http://en.wikipedia.org/wiki/Solar_System//upload.wikimedia.org/wikipedia/commons/thumb/f/f0/Magnetosphere_Levels.jpg/220px-Magnetosphere_Levels.jpg",
        "external": false
      },
      {
        "src": "http://en.wikipedia.org/wiki/Solar_System//upload.wikimedia.org/wikipedia/commons/thumb/b/ba/Comet_Hale-Bopp_1995O1.jpg/220px-Comet_Hale-Bopp_1995O1.jpg",
        "external": false
      },
      {
        "src": "http://en.wikipedia.org/wiki/Solar_System//upload.wikimedia.org/wikipedia/commons/thumb/2/2d/Meteor_shower_in_the_Chilean_Desert_%28annotated_and_cropped%29.jpg/220px-Meteor_shower_in_the_Chilean_Desert_%28annotated_and_cropped%29.jpg",
        "external": false
      },
      {
        "src": "http://en.wikipedia.org/wiki/Solar_System//upload.wikimedia.org/wikipedia/commons/thumb/5/56/Kuiper_belt_-_Oort_cloud-en.svg/220px-Kuiper_belt_-_Oort_cloud-en.svg.png",
        "external": false
      },
      {
        "src": "http://en.wikipedia.org/wiki/Solar_System//upload.wikimedia.org/wikipedia/commons/thumb/1/1f/Interstellar_medium_annotated.jpg/550px-Interstellar_medium_annotated.jpg",
        "external": false
      },
      {
        "src": "http://en.wikipedia.org/wiki/Solar_System//upload.wikimedia.org/wikipedia/commons/thumb/7/7c/The_Local_Interstellar_Cloud_and_neighboring_G-cloud_complex.svg/220px-The_Local_Interstellar_Cloud_and_neighboring_G-cloud_complex.svg.png",
        "external": false
      },
      {
        "src": "http://en.wikipedia.org/wiki/Solar_System//upload.wikimedia.org/wikipedia/commons/thumb/1/19/Milky_Way_side_view.png/220px-Milky_Way_side_view.png",
        "external": false
      },
      {
        "src": "http://en.wikipedia.org/wiki/Solar_System//upload.wikimedia.org/wikipedia/commons/thumb/7/70/Apparent_retrograde_motion_of_Mars_in_2003.gif/220px-Apparent_retrograde_motion_of_Mars_in_2003.gif",
        "external": false
      },
      {
        "src": "http://en.wikipedia.org/wiki/Solar_System//upload.wikimedia.org/wikipedia/commons/thumb/4/4e/The_Solar_System%2C_with_the_orbits_of_5_remarkable_comets._LOC_2013593161_%28cropped%29.jpg/220px-The_Solar_System%2C_with_the_orbits_of_5_remarkable_comets._LOC_2013593161_%28cropped%29.jpg",
        "external": false
      },
      {
        "src": "http://en.wikipedia.org/wiki/Solar_System//upload.wikimedia.org/wikipedia/commons/thumb/8/83/Solar_system.jpg/22px-Solar_system.jpg",
        "external": false
      },
      {
        "src": "http://en.wikipedia.org/wiki/Solar_System//upload.wikimedia.org/wikipedia/commons/thumb/5/5c/Earth-moon.jpg/32px-Earth-moon.jpg",
        "external": false
      },
      {
        "src": "http://en.wikipedia.org/wiki/Solar_System//upload.wikimedia.org/wikipedia/commons/thumb/0/00/Crab_Nebula.jpg/28px-Crab_Nebula.jpg",
        "external": false
      },
      {
        "src": "https://wikimedia.org/api/rest_v1/media/math/render/svg/45e5789e5d9c8f7c79744f43ecaaf8ba42a8553a",
        "external": true
      },
      {
        "src": "https://wikimedia.org/api/rest_v1/media/math/render/svg/0355a973ffa402dc57f8f4371f702db85b17e989",
        "external": true
      },
      {
        "src": "https://wikimedia.org/api/rest_v1/media/math/render/svg/876ecaef49f096f44b57f0258336275f8ba3a373",
        "external": true
      },
      {
        "src": "https://wikimedia.org/api/rest_v1/media/math/render/svg/db73983682cbebba39553ac1760903b39e050466",
        "external": true
      },
      {
        "src": "https://wikimedia.org/api/rest_v1/media/math/render/svg/ea2097c0262c82b8e921dfcc2cc9873e238bc31c",
        "external": true
      },
      {
        "src": "https://wikimedia.org/api/rest_v1/media/math/render/svg/5a386d5764fd35c853376fd570d4c46300b19867",
        "external": true
      },
      {
        "src": "http://en.wikipedia.org/wiki/Solar_System//upload.wikimedia.org/wikipedia/en/thumb/6/62/PD-icon.svg/12px-PD-icon.svg.png",
        "external": false
      },
      {
        "src": "http://en.wikipedia.org/wiki/Solar_System//upload.wikimedia.org/wikipedia/en/thumb/6/62/PD-icon.svg/12px-PD-icon.svg.png",
        "external": false
      },
      {
        "src": "http://en.wikipedia.org/wiki/Solar_System//upload.wikimedia.org/wikipedia/commons/thumb/4/47/Sound-icon.svg/45px-Sound-icon.svg.png",
        "external": false
      },
      {
        "src": "http://en.wikipedia.org/wiki/Solar_System//upload.wikimedia.org/wikipedia/en/thumb/0/06/Wiktionary-logo-v2.svg/19px-Wiktionary-logo-v2.svg.png",
        "external": false
      },
      {
        "src": "http://en.wikipedia.org/wiki/Solar_System//upload.wikimedia.org/wikipedia/en/thumb/4/4a/Commons-logo.svg/14px-Commons-logo.svg.png",
        "external": false
      },
      {
        "src": "http://en.wikipedia.org/wiki/Solar_System//upload.wikimedia.org/wikipedia/commons/thumb/2/24/Wikinews-logo.svg/21px-Wikinews-logo.svg.png",
        "external": false
      },
      {
        "src": "http://en.wikipedia.org/wiki/Solar_System//upload.wikimedia.org/wikipedia/commons/thumb/f/fa/Wikiquote-logo.svg/16px-Wikiquote-logo.svg.png",
        "external": false
      },
      {
        "src": "http://en.wikipedia.org/wiki/Solar_System//upload.wikimedia.org/wikipedia/commons/thumb/4/4c/Wikisource-logo.svg/18px-Wikisource-logo.svg.png",
        "external": false
      },
      {
        "src": "http://en.wikipedia.org/wiki/Solar_System//upload.wikimedia.org/wikipedia/commons/thumb/f/fa/Wikibooks-logo.svg/19px-Wikibooks-logo.svg.png",
        "external": false
      },
      {
        "src": "http://en.wikipedia.org/wiki/Solar_System//upload.wikimedia.org/wikipedia/commons/thumb/0/0b/Wikiversity_logo_2017.svg/21px-Wikiversity_logo_2017.svg.png",
        "external": false
      },
      {
        "src": "http://en.wikipedia.org/wiki/Solar_System//upload.wikimedia.org/wikipedia/commons/thumb/f/ff/Wikidata-logo.svg/21px-Wikidata-logo.svg.png",
        "external": false
      },
      {
        "src": "http://en.wikipedia.org/wiki/Solar_System//upload.wikimedia.org/wikipedia/commons/4/43/Solar_System_Template_2.png",
        "external": false
      },
      {
        "src": "http://en.wikipedia.org/wiki/Solar_System//upload.wikimedia.org/wikipedia/commons/thumb/8/83/Solar_system.jpg/22px-Solar_system.jpg",
        "external": false
      },
      {
        "src": "http://en.wikipedia.org/wiki/Solar_System//upload.wikimedia.org/wikipedia/commons/thumb/0/00/Crab_Nebula.jpg/28px-Crab_Nebula.jpg",
        "external": false
      },
      {
        "src": "http://en.wikipedia.org/wiki/Solar_System//upload.wikimedia.org/wikipedia/commons/thumb/4/43/The_Earth_seen_from_Apollo_17_with_transparent_background.png/28px-The_Earth_seen_from_Apollo_17_with_transparent_background.png",
        "external": false
      },
      {
        "src": "http://en.wikipedia.org/wiki/Solar_System//upload.wikimedia.org/wikipedia/en/thumb/e/e2/Symbol_portal_class.svg/16px-Symbol_portal_class.svg.png",
        "external": false
      },
      {
        "src": "http://en.wikipedia.org/wiki/Solar_System//upload.wikimedia.org/wikipedia/en/thumb/e/e2/Symbol_portal_class.svg/16px-Symbol_portal_class.svg.png",
        "external": false
      },
      {
        "src": "http://en.wikipedia.org/wiki/Solar_System//upload.wikimedia.org/wikipedia/en/thumb/9/96/Symbol_category_class.svg/16px-Symbol_category_class.svg.png",
        "external": false
      },
      {
        "src": "http://en.wikipedia.org/wiki/Solar_System//upload.wikimedia.org/wikipedia/en/thumb/4/4a/Commons-logo.svg/12px-Commons-logo.svg.png",
        "external": false
      },
      {
        "src": "http://en.wikipedia.org/wiki/Solar_System//upload.wikimedia.org/wikipedia/en/thumb/9/96/Symbol_category_class.svg/16px-Symbol_category_class.svg.png",
        "external": false
      },
      {
        "src": "http://en.wikipedia.org/wiki/Solar_System//upload.wikimedia.org/wikipedia/commons/thumb/5/5f/He1523a.jpg/14px-He1523a.jpg",
        "external": false
      },
      {
        "src": "http://en.wikipedia.org/wiki/Solar_System//upload.wikimedia.org/wikipedia/en/thumb/e/e4/SaganWalk.0.Sun.jpg/70px-SaganWalk.0.Sun.jpg",
        "external": false
      },
      {
        "src": "http://en.wikipedia.org/wiki/Solar_System//upload.wikimedia.org/wikipedia/commons/thumb/8/83/Solar_system.jpg/15px-Solar_system.jpg",
        "external": false
      },
      {
        "src": "http://en.wikipedia.org/wiki/Solar_System//upload.wikimedia.org/wikipedia/commons/thumb/0/00/Crab_Nebula.jpg/19px-Crab_Nebula.jpg",
        "external": false
      },
      {
        "src": "http://en.wikipedia.org/wiki/Solar_System//upload.wikimedia.org/wikipedia/commons/thumb/4/43/The_Earth_seen_from_Apollo_17_with_transparent_background.png/19px-The_Earth_seen_from_Apollo_17_with_transparent_background.png",
        "external": false
      },
      {
        "src": "http://en.wikipedia.org/wiki/Solar_System//upload.wikimedia.org/wikipedia/commons/thumb/5/5f/He1523a.jpg/16px-He1523a.jpg",
        "external": false
      },
      {
        "src": "http://en.wikipedia.org/wiki/Solar_System//upload.wikimedia.org/wikipedia/commons/thumb/d/d6/RocketSunIcon.svg/19px-RocketSunIcon.svg.png",
        "external": false
      },
      {
        "src": "http://en.wikipedia.org/wiki/Solar_System//upload.wikimedia.org/wikipedia/en/thumb/8/8a/OOjs_UI_icon_edit-ltr-progressive.svg/10px-OOjs_UI_icon_edit-ltr-progressive.svg.png",
        "external": false
      },
      {
        "src": "http://en.wikipedia.org/wiki/Solar_System/static/images/footer/wikimedia-button.svg",
        "external": false
      },
      {
        "src": "http://en.wikipedia.org/wiki/Solar_System/w/resources/assets/poweredby_mediawiki.svg",
        "external": false
      }
    ],
    "maxLinksReached": false
  },
  "code": 200
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

Copyright (&copy;) 2024 APIVerve, and Evlar LLC

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.