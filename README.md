# UbiSoftCoreApiScores
# UbiSoftCoreApiScores

This service is a simple API for receive, store and retrieve user scores for games.

## Overview

Service is based on ASP.NET Core, written on C# and uses SQL Server EntityFramework as data storage.


- API to manage users and games

git clone https://github.com/patilsantosh2810/UbiSoftCoreApiScores
dotnet run -MySQL "Server=(local)\\sqlexpress;Database=UbiApiScore;Trusted_Connection=True;MultipleActiveResultSets=True;"
```
GET: api/LeaderBoard


POST api/LeaderBoard

```
 {
    	"userName": "Ubisoft",
        "rank": 10,
        "kills": 15,
        "score": 450,
        "match": "SuperMario"
    }
```
