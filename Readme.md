entire-📘 Event Registration Application

A full-stack Event Registration System built with:

Angular 17+ (Frontend)

.NET 8 Web API (Backend)

CORS-enabled cross-domain communication

In-memory event storage (EventService)

This project allows users to:

✔ View all available events
✔ Check seat availability
✔ Register for an event
✔ Instantly update UI using Angular async pipes

🚀 Project Structure
/EventRegistrationApp
/EventRegistrationAPI → ASP.NET Core Web API backend
/event-frontend → Angular frontend application
README.md
⚙️ Backend (.NET 8 Web API)
👉 Technologies

.NET 8

C#

Minimal Hosting Model

Dependency Injection

CORS Policy Enabled for Angular

In-memory event management

👉 Run the API

Navigate to backend folder:

cd EventRegistrationAPI

Run:

dotnet run

This will start the API, usually on:

http://localhost:7275

Correct endpoint:

GET /api/Events
POST /api/Events
POST /api/Events/{id}/register
🌐 Frontend (Angular 17+)
👉 Technologies

Standalone Angular components

HttpClient for API calls

Async pipe for clean change detection

Tailwind or CSS styling (optional)

👉 Install dependencies
cd event-frontend
npm install
👉 Start Angular App
ng serve

App runs at:

http://localhost:4200
🔄 Frontend–Backend Communication

Your Angular service calls the API at:

http://localhost:7275/api/Events

Make sure this matches the port shown in your API console.

🔐 CORS Configuration

Your Program.cs:

builder.Services.AddCors(options =>
{
options.AddPolicy("AllowAngular", policy =>
{
policy.AllowAnyOrigin()
.AllowAnyMethod()
.AllowAnyHeader();
});
});

app.UseRouting();
app.UseCors("AllowAngular");

This allows Angular to communicate with the API without CORS errors.

🎯 Features
✔ List All Events

Displays event name, date, max seats, remaining seats.

✔ Register for an Event

Simple participant registration per event.

✔ Auto UI Updates

Async pipe removes ExpressionChanged errors.

🧩 Event Object Example
{
"id": 1,
"title": "Tech Conference",
"eventDate": "2025-02-01T00:00:00",
"maxSeats": 100,
"participants": [
{ "name": "John Doe", "email": "john@example.com" }
]
}
📡 API Routes
Method Route Description
GET /api/Events Get all events
POST /api/Events Create new event
POST /api/Events/{id}/register Register a participant
🛠 Build for Production
Angular:
ng build
.NET API:
dotnet publish -c Release
📸 Screenshots (Optional)

You can add UI screenshots like:

![Event List](screenshots/events.png)
![Registration Form](screenshots/register.png)
📄 License

MIT License – free to use & modify.

🙌 Contributions

Pull requests, suggestions, and improvements are welcome.
