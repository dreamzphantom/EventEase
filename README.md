# EventEase

EventEase is a Blazor web application created for the Coursera **Blazor for Front-End Development** peer-graded assignment.

## Run the project

1. Install the .NET 8 SDK.
2. Open a terminal in the `EventEase` folder.
3. Run `dotnet restore`.
4. Run `dotnet run`.
5. Open the local URL shown in the terminal.

## Rubric features

- **Event Card:** `Components/Shared/EventCard.razor` displays event fields and demonstrates two-way binding with `@bind`.
- **Routing:** Routes include `/`, `/events/{Id:int}`, `/register`, and `/attendance`, plus not-found handling.
- **Optimization and debugging:** The app uses typed route constraints, a shared event data source, server interactivity only on pages that need it, form validation, and error/not-found handling.
- **Registration Form:** Uses `EditForm`, data annotations, validation messages, and required fields.
- **Session state:** `UserSessionService` is a scoped service that stores the current registration for the session.
- **Attendance Tracker:** Supports editing names, adding attendees, and checking attendees in.

## How Microsoft Copilot assisted

1. **Foundation:** Copilot helped generate the Event Card structure, event model, sample data, and two-way data binding.
2. **Routing and debugging:** Copilot helped configure page routes, an integer route parameter for event details, navigation links, and not-found behavior.
3. **Optimization:** Copilot helped reduce duplicated data, scope interactive rendering to applicable pages, add input validation, and improve error handling.
4. **Advanced features:** Copilot helped build the validated Registration Form, scoped user-session state service, and interactive Attendance Tracker.
5. **Final review:** Copilot organized the project and README so each peer-grading requirement can be located quickly.

## Technology

- .NET 8
- Blazor Web App
- C#
- HTML and CSS
- Microsoft Copilot
