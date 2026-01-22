# Sports Facility Management System

A full-stack web application for managing sports facility operations — sessions, bookings, users, and role-based access.

## Overview
This project supports end-to-end facility workflows:
- Admin management (system overview + control of entities)
- Staff operations (session and facility handling)
- Member experience (browse sessions, sign up, manage participation)
- Authentication and role-based access

## Tech Stack
- ASP.NET Core
- C#
- MySQL
- Entity Framework Core (Migrations)
- HTML/CSS + Bootstrap

## Key Features
- Role-based authentication (Admin / Staff / Member)
- Session creation, editing, and management
- Member sign-up flows
- Database-driven architecture with EF Core migrations

## Getting Started (Local Setup)
1. Clone the repository
2. Create `appsettings.json` (use `appsettings.example.json` as a template)
3. Configure your MySQL connection string
4. Run migrations and start the app

## Notes
`appsettings.json` is intentionally excluded from the repo to avoid exposing secrets. Use `appsettings.example.json` to configure your local environment.
