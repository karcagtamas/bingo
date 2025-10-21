namespace Bingo;

public static class Utils
{
    public static void WithNonNull<T>(T? obj, Action<T> action)
    {
        if (obj != null)
        {
            action(obj);
        }
    }

    public static async Task WithNonNull<T>(T? obj, Func<T, Task> action)
    {
        if (obj != null)
        {
            await action(obj);
        }
    }

    public static async Task WithNonNullAsync<T>(Task<T?> task, Func<T, Task> action)
    {
        await WithNonNull(await task, action);
    }

    public static TResult MapOrElse<T, TResult>(T? obj, Func<T, TResult> mapper, TResult o)
    {
        return obj != null ? mapper(obj) : o;
    }
}