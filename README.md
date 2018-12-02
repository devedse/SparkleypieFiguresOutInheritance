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
