# GetCounter documentation

## Introduction
The API provides a counter that can be called by any user
- The current counter can be retrieved by anyone
- The counter can be incremented by anyone
- The counter is global and may be stored in memory

## Overview
- To retrieve the counter call /getcounter 
- To increase the counter call /increment

## Authentication
No Authentications

## Error Codes
The conventional http error codes

## Rate limit
No limits


GET https://localhost:5001/v1/counter

https://localhost:5001/v1/counter

Example RequestDefault

curl --request GET \
  --url https://localhost:5001/v1/counter

GET https://localhost:5001/v1/getcounter

https://localhost:5001/v1/getcounter

Example RequestDefault

curl --request GET \
  --url https://localhost:5001/v1/getcounter

GET https://localhost:5001/v1/increment

https://localhost:5001/v1/increment

Example RequestDefault

curl --request GET \
  --url https://localhost:5001/v1/increment
