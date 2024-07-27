# Create Workout

## Create Workout Request

```js
POST /workouts
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
    ],
    "workoutDateTime": "2024-07-20T108:00:00"
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
    ],
    "workoutDateTime": "2024-07-20T108:00:00"
}
```

## Get Workout

### Get Workout Request

```js
GET /workouts/{{id}}
```

### Get Workout Response

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
    ],
    "workoutDateTime": "2024-07-20T108:00:00"
}
```

## Update Workout

### Update Workout Request

```js
PUT /workouts/{{id}}
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
    ],
    "workoutDateTime": "2024-07-20T108:00:00"
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
Location: {{host}}/workouts/{{id}}
```

## Delete Workout

### Delete Workout Request

```js
DELETE /workouts/{{id}}
```

### Delete Workout Response

```js
204 No Content
```

# Credits

- [ErrorOr](https://github.com/amantinband/error-or) - A simple, fluent discriminated union of an error or a result.
