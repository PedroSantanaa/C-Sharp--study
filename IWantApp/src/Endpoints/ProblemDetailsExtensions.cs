using Flunt.Notifications;

namespace IWantApp.Endpoints;

public class ProblemDetailsExtensions
{
    public Dictionary<string, string[]> ConvertToProblemDetails(this IReadOnlyCollection<Notification> notifications)
    {
        return notifications.GroupBy(g => g.Key).ToDictionary(g => g.Key, g => g.Select(x => x.Message).ToArray());
    }
}
