# Tenders api

Wrapper around https://tenders.guru/pl/api that allows doing filtering of exposed data.

## Getting Started

These instructions will get you a copy of the project up and running on your local machine for development and testing purposes.

### Prerequisites

- .NET Core SDK (version 8.X or higher) - [Download](https://dotnet.microsoft.com/download)
- Your favorite code editor (e.g., Visual Studio, Visual Studio Code, Rider)

### Installing

1. Clone the repository:

   ```bash
   git clone https://github.com/mariusz-pawlowski/tenders-api.git

### Runing

Navigate to "\src\Tenders.Api"

1. run ```dotnet restore```
2. run ```dotnet run```.

(or)

Open *.sln file in VisualStudio/Rider.
In appsettings.Developement.json file, application is configured to run on port 80. Click "Run project" and it will start on url ```http://localhost/```

## Testing

### Integration tests

Each requirement has been covered with integration tests. You can find them in ```TendersApiIntegrationTests.cs``` file.

### Manual tests

Query endpoints using browser:
```
http://localhost/api/tenders
http://localhost/api/tenders?PriceEuroFrom=800&PriceEuroTo=900
http://localhost/api/tenders?OrderByPriceEuro=DESC
http://localhost/api/tenders?DateFrom=2021-07-26&DateTo=2021-07-27
http://localhost/api/tenders?OrderByDate=ASC
http://localhost/api/suppliers/23072/tenders
http://localhost/api/tenders/564243
```

## Implementation summary

### Architecture

- Projects organization follows ```clean architecture``` guidlines.
- WebApi endpoints follows REST guidelines.
- Application use-cases have been covered using ```CQRS``` pattern.
- Project done in .NET Core 8.

### Solution
```https://tenders.guru/pl/api``` does not allow for filtering. But our requirements says about focusing only on first 100 results.
Taking assumption that those data do not change very often, and (probably) tenders.guru.api has applied its own caching mechanism, I've decided to cache ```https://tenders.guru/pl/api``` response.
We do not want cache to be updated by requests, because that can lead to serious pefromance problems. Because of that, there will be just a single party available to update cached ```https://tenders.guru/pl/api``` response. ```TendersCacheRefreshBackgroundService``` is a background job, that will perform update every single minute (configurable value).
Because of that, each query has comparable execution time.

### Filtering

Filters are done through URL queries
That decision is driven by following factors:
+ readability
+ filters do not contain sensitive data, so we do not to use POST to hide them in a body
+ not complex structures, no risk for url to be too long

### Paging

To use pagination add following headers:
"x-page-number"
"x-page-size"

If those headers won't be present in a request, then default values will be taken: 1 & 100

## Quality requirements

### Scalability
Project has docker image, so is ready to be hosted on multiple pods.

### Maintainability

To cover further use-cases, we need to add respective Query&QueryHandler to the solution.
To add additional filters, then just extend ```GetTendersFilteredParameters.cs``` class.

### Testability

Each functional requirement has been covered with integration test.
For demo purposes UnitsTests have been skipped, but can be added if needed.

### Readablitiy 

Project organization using architecture guidelines.



   
