# Create Workout

## Create Workout Request

```js
POST /Workouts
```

```json
{
    "workoutLocation" : "Fitness Last",
    "workoutStartDateTime": "2024-07-20T08:00:00",
    "workoutNotes": "Good session!"
}
```

### Create Workout Response

```js
201 Created
```

```yml
Location: {{host}}/Workouts/{{id}}
```

```json
{
    "workoutID": "00000000-0000-0000-0000-000000000001",
    "workoutLocation" : "Fitness Last",
    "workoutStartDateTime": "2024-07-20T08:00:00",
    "workoutNotes": "Good session!",
    "exercises":[
        
    ]
}
```

# Get Workout

### Get Workout Request

```js
GET /Workouts/{{id}}
```

### Get Workout Response

```js
200 Ok
```

```json
{
    "workoutID": "00000000-0000-0000-0000-000000000001",
    "workoutLocation" : "Fitness Last",
    "workoutStartDateTime": "2024-07-20T08:00:00",
    "workoutNotes": "Good session!",
    "exercises":[
        
    ]
}
```

# Update Workout

### Update Workout Request

```js
PUT /Workouts/{{id}}
```

```json
{
    "workoutID": "00000000-0000-0000-0000-000000000001",
    "workoutLocation" : "Fitness Last",
    "workoutStartDateTime": "2024-07-20T08:00:00",
    "workoutNotes": "Good session!",
    "exercises":[
        
    ]
}
```

### Update Workout Response

```js
204 No Content
```

or

```js
201 Created
```

```yml
Location: {{host}}/Workouts/{{id}}
```

# Delete Workout

### Delete Workout Request

```js
DELETE /Workouts/{{id}}
```

### Delete Workout Response

```js
204 No Content
```

# Add Exercise

### Add Exercise Request

```js
POST /Exercises
```

```json
{
    "linkedWorkoutID": "00000000-0000-0000-0000-000000000001",
    "exerciseName": "Bench press",
    "numberOfSets": 5,
    "weightEachSet": [
        60.0,
        80.0,
        90.0,
        100.0,
        112.5
    ],
    repsEachSet: [
        12,
        8,
        5,
        3,
        2
    ],
    "notes": ""
}
```


### Add Exercise Response

```js
201 Created
```

```yml
Location: {{host}}/Exercises/{{id}}
```

```json
{
    "linkedWorkoutID": "00000000-0000-0000-0000-000000000001",
    "exerciseID": "00000000-0000-0000-0000-000000000002",
    "exerciseName": "Bench press",
    "numberOfSets": 5,
    "weightEachSet": [
        60.0,
        80.0,
        90.0,
        100.0,
        112.5
    ],
    repsEachSet: [
        12,
        8,
        5,
        3,
        2
    ],
    "notes": ""
}
```

# Get Exercise

### Get Exercise Request

```js
GET /Exercises/{{id}}
```

### Get Exercise Response

```js
200 Ok
```

```json
{
    "linkedWorkoutID": "00000000-0000-0000-0000-000000000001",
    "exerciseID": "00000000-0000-0000-0000-000000000002",
    "exerciseName": "Bench press",
    "numberOfSets": 5,
    "weightEachSet": [
        60.0,
        80.0,
        90.0,
        100.0,
        112.5
    ],
    repsEachSet: [
        12,
        8,
        5,
        3,
        2
    ],
    "notes": ""
}
```

# Update Exercise

### Update Exercise Request

```js
PUT /Exercises/{{id}}
```

```json
{
    "linkedWorkoutID": "00000000-0000-0000-0000-000000000001",
    "exerciseID": "00000000-0000-0000-0000-000000000002",
    "exerciseName": "Bench press",
    "numberOfSets": 5,
    "weightEachSet": [
        60.0,
        80.0,
        90.0,
        100.0,
        112.5
    ],
    repsEachSet: [
        12,
        8,
        5,
        3,
        2
    ],
    "notes": ""
}
```

### Update Exercise Response

```js
204 No Content
```

or

```js
201 Created
```

```yml
Location: {{host}}/Exercises/{{id}}
```

# Delete Exercise

### Delete Exercise Request

```js
DELETE /Exercises/{{id}}
```

### Delete Exercise Response

```js
204 No Content
```

# Credits

- [ErrorOr](https://github.com/amantinband/error-or) - A union of an error or a result developed by a Microsoft Employee. I followed his Restful API tutorial initially, though modified the examples and stucture. 
- Note: he seems to have been inspired by Rust's "Result" struct approach, which I am somewhat familar with and it is a nice way to handle errors.
