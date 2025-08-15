using System;

namespace LocalMindApi.CustomExeptions;

public class NotFoundExeption:Exception
{
    public NotFoundExeption()
    { }

    public NotFoundExeption(string message) : base(message)
    { }

    public NotFoundExeption(string message, Exception innerException) : base(message, innerException)
    { }
}