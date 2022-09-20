using Au.TS;

[JSWrap]
public class TestForTS
{
    public string GetHello()
    {
        return "hello world";
    }

    [JSIgnore]
    public string NoneFunc()
    {
        return "NONE";
    }
}
