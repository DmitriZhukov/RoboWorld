# RoboWorld
Just for fun


Overview
We are living in the int world. Specification cleary says coordinates are ints. But ideally we better consider using generics to be able to use decimal or long.
Also rotation is stated only as multiplier to 90 degrees, like North or East. But what if want to use smaller values like 15 degrees. So we keep angle in degrees.
We want to be able to add new functionality. 
Add new commands. Add new robots. Add new planets.
Good place to use IOC containers for instantiating objects. We are fine to use native .NET.
We are using native logging framework.
Development stages
We start from simple monolith application but the goal is to grow into full scale microservices architecture.  Typically that would be implemented as set of backend services with one or several APIs exposed, a database, very likely we would need some message broker and or in memory cache to build integration between components. If we decide later to move towards corporate architecture, then we need to design Components and Services they implement. So our first experimental application provides
Some simple interfaces – command line and file. Later we might implement something more
We can split development into standard two weeks sprints. 
Some thing can be added at some later times – like add some IOC usages.
Infrastructure and network. 
Do we need database and application clusters, recovery etc?
Draw diagram show servers, network zones, ports.
CI/DI
Describe enviroments? Which? PROD, UAT, IFT, PreProd? Intergration, Regression tests?
Unit Testing. 
Test some basic operation like moving, rotation. Should be easy to test.


