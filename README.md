# .Net-Core-3.0-API
A .net core RESTFUL API to feed ORDER and ORDER DETAİL tables.
Example request
{
"accountCode": "IKEA",
"number": "00001",
"orderTime": "",
"customerName": "customer1 test", 
"customerEmail": "test@test.com", 
"orderTotal": 100.00,
 "orderDetails": [
{
"itemCode": "ITEM001", 
"quantity": 1
}, 
{
"itemCode": "ITEM002", 
"quantity": 3
}
] 
}
