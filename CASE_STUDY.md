PM Case Study- Sports Facility Management System
Context: 
Many small and mid-sized sports facilities (gyms, studios, training centers) operate with fragmented processes for managing sessions, instructors, and participants. Scheduling is often handled via spreadsheets, messaging apps, or manual coordination, which leads to:
Conflicting schedules
Poor visibility into session availability
Manual, error-prone booking processes
Lack of accountability across roles
This project addresses a real operational problem: how to give facilities a single, structured system to manage sessions and bookings clearly, reliably, and at scale.
Product Purpose:
The product is designed to centralize session management and bookings, while clearly separating responsibilities between different user roles.
The core idea: Each user sees only what they need, can perform only the actions relevant to them, and understands exactly what’s happening in the system.
Users & What They Can Do 
1. Admin (Facility Owner / Manager)
Purpose: Full operational control and system oversight.
Main capabilities:
Create, edit, and delete sports sessions
Assign rooms, instructors, and time slots
Manage system-wide data (rooms, session types, skills)
View all bookings and participant lists
Access an admin dashboard with a full overview
Why this matters:
Admins need accuracy, visibility, and control. The system ensures they can configure everything without relying on staff or manual coordination.

2. Staff (Instructors)
Purpose: Execute and manage daily operations.
Main capabilities:
View assigned sessions
See participant lists per session
Access a staff-specific dashboard
Monitor session schedules without editing system-wide settings
Why this matters:
Staff need clarity, not complexity. They don’t create system structure, they operate within it. The interface removes unnecessary options to prevent mistakes.

3. Member 
Purpose: Discover and book sessions easily.
Main capabilities:
Browse available sessions
View session details (time, room, instructor, availability)
Sign up for sessions
Access a personal dashboard with their bookings
Why this matters:
Members need a simple, intuitive flow. The system removes friction by focusing only on discovery and booking, no administrative noise.


Core Product Functionality 
1. Role-Based Access Control
Each user role has:
A dedicated dashboard
Clear permissions
A focused workflow
This prevents confusion and enforces operational discipline.
2. Session Lifecycle Management
Sessions can be:
Created
Edited
Viewed
Deleted
Each session includes:
Time & duration
Room assignment
Instructor
Participant tracking
This gives facilities full control over scheduling logic.
3. Booking & Participation Tracking
Members can sign up for sessions
Admins and staff can see who is attending
The system maintains accurate participant records
This replaces manual attendance lists and messaging-based coordination.
4. Structured Data Model
The system uses a relational database design to maintain clear relationships between sessions, rooms, users, and bookings. As well as data integrity and scalability
This makes future features (analytics, capacity planning, notifications) easy to add.

Key Product Decisions (Real PM Thinking)
Decision 1: Strong Role Separation
Instead of one “do-everything” interface, I designed three distinct experiences. 
Result: Fewer errors, faster onboarding and clear accountability

Decision 2: Feature Focus Over Feature Count
I intentionally did not include: Payments, notifications and a mobile app. This allowed focus on core operational value: scheduling + bookings.

Decision 3: Maintainability First
The product prioritizes:
Clear architecture
Predictable workflows
Easy extensibility
This ensures long-term usability, not short-term feature overload.



