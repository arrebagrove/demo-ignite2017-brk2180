using System.Net;
using System.Text;

public static async Task Run(HttpRequest req, Stream myOneDriveFile, TraceWriter log)
{
    string data = req.Query
        .FirstOrDefault(q => string.Compare(q.Key, "text", true) == 0)
        .Value;
    await myOneDriveFile.WriteAsync(Encoding.UTF8.GetBytes(data), 0, data.Length);
    return;
}