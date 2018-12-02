# SparkleypieFiguresOutInheritance

## Interface vs Abstract class

#### Interface

```
public interface ILogger
{
    void WriteLog(string txt);
}
```

is basically exactly the same as:

#### Abstract class

```
public abstract class ILogger
{
    public abstract void WriteLog(string txt);

    public virtual void WriteLogMetDateTime(string txt)
    {
        WriteLog(DateTime.Now + ": " + txt);
    }
}
```

Except in an abstract class you can also add methods.

#### Implementing an interface

```
public class ConsoleLogger : ILogger
{
    public void WriteLog(string txt)
    {
        Console.WriteLine(txt);
    }
}


#### Implementing an abstract class

```
public class ConsoleLogger : ILogger
{
    //override is needed because method is marked as abstract
    public override void WriteLog(string txt)
    {
        Console.WriteLine(txt);
    }
    
    //overriding virtual methods is also allowed, but is optional
    //If this method is not implemented, and someone calls something like ILogger logger = new ConsoleLogger() it would simply call the base class
    public override void WriteLogMetDateTime(string txt)
    {
        Console.WriteLine("Not supported");
    }
}
```

## Some facts

### Interfaces

| Nr | Description |
| -- | -- |
| 1 | An interface is a contract |
| 2 | In an interface there's never a private / public modifier because everything is always public. |
| 3 | Interfaces can't contain code because they are a contract. This also explains why private members don't make sense. |

### (Abstract) classes

| Nr | Description |
| -- | -- |
| 1 | An abstract class is basically the same as an interface but can contain methods, usually those methods are created because they contain code that's shared accross all implementations of the abstract class. (E.g. see above) |
| 2 | A method can be virtual, nothing or abstract |


| Modifier | Description |
| -- | -- |
| virtual | Can be overridden by an implementing class |
| abstract | An abstract method must be overridden (just like normal methods in an interface) |
| nothing | If you don't specify a modifier you can't really override the method (there's some more depth to this, but this is the simple explanation) |
