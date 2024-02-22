
public static class Runner
{
    public static Task RunAsync()
    {
        return Task.Delay(1000);
    }

    public static bool IsPalindrome(string str)
    {
        return str == new string(str.Reverse().ToArray());
    }
}