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
    "id": "00000000-0000-0000-0000-000000000000",
    "workoutLocation" : "Fitness Last",
    "workoutStartDateTime": "2024-07-20T08:00:00",
    "workoutNotes": "Good session!"
}
```

## Get Workout

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
    "id": "00000000-0000-0000-0000-000000000000",
    "workoutLocation" : "Fitness Last",
    "workoutStartDateTime": "2024-07-20T08:00:00",
    "workoutNotes": "Good session!"
}
```

## Update Workout

### Update Workout Request

```js
PUT /Workouts/{{id}}
```

```json
{
    "workoutLocation" : "Fitness Last",
    "workoutStartDateTime": "2024-07-20T08:00:00",
    "workoutNotes": "Good session!"
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

## Delete Workout

### Delete Workout Request

```js
DELETE /Workouts/{{id}}
```

### Delete Workout Response

```js
204 No Content
```

## Create Exercise

### Create Exercise Request

```js
POST /Exercises
```

```json
{
    "exerciseName": "Bench press",
    "sets": 5,
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
    ]
}
```


### Create Exercise Response

```js
201 Created
```

```yml
Location: {{host}}/Exercises/{{id}}
```

```json
{
    "id": "00000000-0000-0000-0000-000000000000",
    "exerciseName": "Bench press",
    "sets": 5,
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
    ]
}
```

## Get Exercise

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
    "id": "00000000-0000-0000-0000-000000000000",
    "exerciseName": "Bench press",
    "sets": 5,
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
    ]
}
```

## Update Exercise

### Update Exercise Request

```js
PUT /Exercises/{{id}}
```

```json
{
    "exerciseName": "Bench press",
    "sets": 5,
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
    ]
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

## Delete Exercise

### Delete Exercise Request

```js
DELETE /Exercises/{{id}}
```

### Delete Exercise Response

```js
204 No Content
```

# Credits

- [ErrorOr](https://github.com/amantinband/error-or) - A simple union of an error or a result. Note: seems to be inspired by Rust's approach.
