
# Calculator-Api
Simple 2 term calculator API using AspNetCore in C#


## API Reference


#### Get calculation

```http
  GET /api/calculation/${first}/${next}/${type}
```

| Parameter | Type     | Description                       |
| :-------- | :------- | :-------------------------------- |
| `first`      | `double` | **Required**. First term |
| `next`      | `double` | **Required**. Second term |
| `type`      | `string` | **Required**. Operator |


Takes two numbers and returns and returns the answer.
Valid types are `add`, `subtract`, `multiply`, and `divide`

The response will be in json as follows:
```JSON
{
  "first": 0,
  "next": 0,
  "type": "string",
  "result": 0
}
```



## Example

Request:
```http
https://localhost:7206/api/calculation/43/55/Multiply
```
Response:
```json
{
    "first": 43,
    "next": 55,
    "type": "Multiply",
    "result": 2365
}
```
