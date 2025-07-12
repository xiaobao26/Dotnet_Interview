# Nullable
## Definition
> Normally, value type in C# cannot be null, we must assign a value when we declare it.
> 
> With nullable(Syntax sugar: "?") we can let value type be null without compiler error

## Benefits:
> Model real data Databases often allow NULL in numeric/date columns. int? or DateTime? maps perfectly to that.
> 
> Cleaner APIs: Instead of magic sentinel values (-1 for “unset”), you get explicit null-semantics.
>
> Pattern matching & null coalescing