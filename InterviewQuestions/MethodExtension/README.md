# Extension Methods

## Definition:
> Extension method is a static method that "extends" an existing type with new functionality,
> 
> without having new subclass(inheritance) or modify its original source.

## Rules:
> Must live in a static class
> 
> Must be static method
> 
> scoped by namesapce

## Best Practices
> Don’t over-extend: Only add methods that are truly natural on the target type, or you risk polluting IntelliSense.
> 
> Name collisions: If an instance method already exists with the same signature, the instance method wins over the extension.
> 
> Performance: There’s no extra runtime cost versus calling a static helper directly—extension methods compile to plain static calls.
> 
> Discoverability: Keep your extension classes grouped in an appropriate namespace, and document them well.