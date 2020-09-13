# RetailProductMicroservices
Retail Product Microservice for the submission of assignment by FSDH group
The project contains 2 microservices, one for single sign on and the other for stock trading
The project structure is the same in the 2 projects.
The models are in the Domain/Models folder
The controllers in the controllers folder
The Services in the services folder
The Services repositories in the repositories folder
The repositories consists of crud methods for the apis, all the repositories follow the same convention for the http methods, GET,POST,PUT,DELETE
The repository pattern is for loose coupling 
Unfortunately, i was not able to call all the services in the startup class due to time constraint. Only Countries AdScope was being able to implement
