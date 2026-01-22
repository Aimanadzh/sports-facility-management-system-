# PM Case Study  
## Sports Facility Management System

---

## Context

Many small and mid-sized sports facilities (gyms, studios, training centers) operate with fragmented processes for managing sessions, instructors, and participants.

Scheduling is often handled through spreadsheets, messaging apps, or manual coordination, which leads to:

- Conflicting schedules  
- Poor visibility into session availability  
- Manual, error-prone booking processes  
- Lack of accountability across roles  

This project addresses a real operational problem:  
**how to give facilities a single, structured system to manage sessions and bookings clearly, reliably, and at scale.**

---

## Product Purpose

The product centralizes **session management and bookings**, while clearly separating responsibilities between different user roles.

**Core principle:**  
Each user sees only what they need, can perform only the actions relevant to them, and understands exactly what’s happening in the system.

---

## Users & Capabilities

### Admin (Facility Owner / Manager)

**Purpose:** Full operational control and system oversight.

**Capabilities:**
- Create, edit, and delete sports sessions  
- Assign rooms, instructors, and time slots  
- Manage system-wide data (rooms, session types, skills)  
- View all bookings and participant lists  
- Access an admin dashboard with a complete overview  

**Why this matters:**  
Admins need accuracy, visibility, and control. The system allows them to configure everything without relying on staff or manual coordination.

---

### Staff (Instructors)

**Purpose:** Execute and manage day-to-day operations.

**Capabilities:**
- View assigned sessions  
- See participant lists per session  
- Access a staff-specific dashboard  
- Monitor schedules without editing system-wide settings  

**Why this matters:**  
Staff need clarity, not complexity. They operate within a defined structure, and the interface removes unnecessary options to prevent mistakes.

---

### Member (Participant)

**Purpose:** Discover and book sessions easily.

**Capabilities:**
- Browse available sessions  
- View session details (time, room, instructor, availability)  
- Sign up for sessions  
- Access a personal dashboard with current bookings  

**Why this matters:**  
Members need a simple, intuitive flow. The system removes administrative noise and focuses only on discovery and booking.

---

## Core Product Functionality

### 1. Role-Based Access Control

- Dedicated dashboard per role  
- Clear permissions  
- Focused workflows  

This prevents confusion and enforces operational discipline.

---

### 2. Session Lifecycle Management

Sessions can be:
- Created  
- Edited  
- Viewed  
- Deleted  

Each session includes:
- Time and duration  
- Room assignment  
- Instructor assignment  
- Participant tracking  

This gives facilities full control over scheduling logic.

---

### 3. Booking & Participation Tracking

- Members can sign up for sessions  
- Admins and staff can see who is attending  
- Accurate participant records are maintained  

This replaces manual attendance lists and messaging-based coordination.

---

### 4. Structured Data Model

The system uses a relational database design to maintain:

- Clear relationships between sessions, rooms, users, and bookings  
- Data integrity and scalability  

This makes future features (analytics, capacity planning, notifications) easy to add.

---

## Key Product Decisions

### Decision 1: Strong Role Separation

Instead of a single “do-everything” interface, the product provides **three distinct user experiences** aligned with real responsibilities.

**Result:**
- Fewer errors  
- Faster onboarding  
- Clear accountability  

---

### Decision 2: Feature Focus Over Feature Count

Intentionally excluded:
- Payments  
- Notifications  
- Mobile application support  

This kept the product focused on **core operational value**: scheduling and bookings.

---

### Decision 3: Maintainability First

The product prioritizes:
- Clear architecture  
- Predictable workflows  
- Easy extensibility  

This ensures long-term usability rather than short-term feature overload.

---

## PM Takeaway

This project demonstrates my ability to:

- Identify real operational problems  
- Translate them into structured product scope  
- Design role-based experiences  
- Make deliberate trade-offs between value and complexity  
- Own a product from problem definition to delivery
