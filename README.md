# 📚 School Subjects Information System

A C# Console Application built for managing and exploring information about school subjects. Developed as part of a software engineering internship challenge.

## 🚀 Features

- Choose from a **predefined list of subjects** (Math, English, Art, etc.).
- View detailed information about each subject.
- **Extendable**: Fetch additional subjects from external sources (REST API/JSON).
- Clean, modular, and **SOLID-compliant** architecture.
- Uses **asynchronous programming** to handle external data fetching.
- Easily extendable to support databases or other APIs.

## 🧠 Subject Data Model

Each subject contains:

- `Name` – Name of the subject.
- `Description` – Overview of what the subject covers.
- `WeeklyClasses` – Number of sessions per week.
- `Literature` – List of books/materials used.
- ✅ Future-ready: Add custom fields easily.

## 🏗️ Architecture Overview

### Project Structure

```bash
SchoolSubjectsApp/
│
├── Models/                    # Core domain models and interfaces
│   ├── ISubject.cs
│   └── BaseSubject.cs
│
├── Services/                  # Business logic & external integration
│   ├── SubjectService.cs
│   ├── IExternalSubjectService.cs
│   └── ExternalSubjectService.cs
│
├── Repositories/             # Data access layer
│   ├── Interface/
│   │   └── ISubjectRepository.cs
│   └── Implementation/
│       └── SubjectRepositoryImpl.cs
│
├── subjects.json             # Local static data
├── Program.cs                # Main console app logic
 
