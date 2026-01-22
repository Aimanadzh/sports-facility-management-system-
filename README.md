# Sports Facility Management System

A web-based system designed to streamline sports facility operations by managing sessions, users, and bookings through a role-based platform.

---

## Problem
Sports facilities often rely on manual processes or fragmented tools to manage:
- Session scheduling
- Member registrations
- Staff coordination
- Facility usage tracking

This leads to inefficiencies, scheduling conflicts, and poor user experience.

---

## Users
- **Admins** — oversee the system, manage data, and monitor operations
- **Staff** — manage sessions and facility resources
- **Members** — browse sessions, sign up, and manage participation

---

## Solution
This system centralizes all facility operations into a single platform with:
- Role-based authentication and access control
- Session creation, editing, and management
- Member registration and participation tracking
- Database-driven architecture for scalability

---

## Tech Stack
- **Backend:** ASP.NET Core (C#)
- **Database:** MySQL
- **ORM:** Entity Framework Core
- **Frontend:** Razor Pages, HTML, CSS, Bootstrap

---

## Scope & Constraints
- Designed as a university independent study project
- Focused on core facility workflows rather than payments or analytics
- Prioritized clarity, maintainability, and role separation

---

## Product Decisions
- Implemented role-based access to reflect real-world facility operations
- Used EF Core migrations for safe database evolution
- Excluded sensitive configuration files to follow security best practices

---

## Future Roadmap
- Analytics dashboard for admins
- Booking conflict detection
- Mobile-friendly UI
- Notifications and reminders
- Payment integration

---

## Local Setup
1. Clone the repository
2. Create `appsettings.json` using `appsettings.example.json`
3. Configure MySQL connection
4. Run migrations
5. Start the application
