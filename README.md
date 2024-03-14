# SchoolActivity
 .NET Core API with Rules Engine

## Tutorial

- **Step 1**: Import Database schema and data in ```.Archives``` folder.
- **Step 2**: Run the project
- **Step 3**: Using sample APIs to test the project by follwing:
    - ```GET``` ```https://localhost:8888/classroom/weeklygrade/6A1?month=1&week=1```
    - ```GET``` ```https://localhost:8888/classroom/weeklygrade/6A1?month=1&week=2```
    - ```GET``` ```https://localhost:8888/classroom/weeklygrade/7A2?month=1&week=3```
    - ```GET``` ```https://localhost:8888/classroom/weeklygrade/7A2?month=1&week=4```

For seeing details how to implement Rules Engine in this project, please select ```Services/ClassroomService.cs``` file with implemented method ```ClassroomGradingByWeek```.