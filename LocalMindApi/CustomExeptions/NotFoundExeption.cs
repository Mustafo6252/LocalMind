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

/* 
eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1LzA1L2lkZW50aXR5L2NsYWltcy9uYW1laWRlbnRpZmllciI6IjQzYWIzMDRmLWQ3NzItNDU5ZC05MjcxLWJkZjE2Mjg0ZTYwYiIsImh0dHA6Ly9zY2hlbWFzLnhtbHNvYXAub3JnL3dzLzIwMDUvMDUvaWRlbnRpdHkvY2xhaW1zL25hbWUiOiJBZG1pbiIsImh0dHA6Ly9zY2hlbWFzLm1pY3Jvc29mdC5jb20vd3MvMjAwOC8wNi9pZGVudGl0eS9jbGFpbXMvcm9sZSI6IlN0dWRlbnQiLCJGdWxsTmFtZSI6Ik11c3RhZm8gUmF2c2hhbm92IiwiZXhwIjoxNzU1MjY0OTE1LCJpc3MiOiJEZXZUaXBzIiwiYXVkIjoiRGV2VGlwcyJ9.udd4knQoPFxer4okw8Of_wR6vAMtWsDl35DAv57JrSg"
*/