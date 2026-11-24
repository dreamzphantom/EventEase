using EventEase.Models;

namespace EventEase.Services;

public class UserSessionService
{
    public RegistrationModel? CurrentRegistration { get; private set; }
    public bool IsRegistered => CurrentRegistration is not null;

    public event Action? OnChange;

    public void SaveRegistration(RegistrationModel registration)
    {
        CurrentRegistration = new RegistrationModel
        {
            FullName = registration.FullName,
            Email = registration.Email,
            EventId = registration.EventId,
            AcceptPolicy = registration.AcceptPolicy
        };
        OnChange?.Invoke();
    }

    public void Clear()
    {
        CurrentRegistration = null;
        OnChange?.Invoke();
    }
}
