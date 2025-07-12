# Dependence Injection
## Definition
> Dependence Injection is a design pattern that used to achieve Inversion of Control(Ioc);
> 
> where a class's dependencies are injected from outside, rather than a class instantiating them itself.
> 
> Instead of a class creating its own dependencies, they are "injected" into it through its constructor, properties, or methods. 
> 
> This way, the class doesn't need to manage its dependencies, and they can be easily replaced with different implementations if needed.
> 
> Make the code more maintainable, flexible, and testable
> 
> Commonly use Constructor Injection