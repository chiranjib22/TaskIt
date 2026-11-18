# TaskIt

TaskIt is a task management application that I'm building as a long-term learning project while strengthening my C# and .NET development skills.

The project will evolve gradually: it starts as a **C# console application** and will expand into a more complete application as I learn additional concepts and technologies.

> **Project status:** Early development  
> The initial focus is on building a working console-based task manager. Features and documentation will be updated as the project grows.

## Goals

- Practise C# fundamentals and object-oriented programming through a practical project.
- Learn to design and organize code into clear responsibilities.
- Improve problem-solving, debugging, and software design skills.
- Gradually explore the .NET ecosystem by evolving the same project instead of starting over with unrelated tutorials.

## Planned roadmap

The roadmap is intentionally flexible. Each stage will be approached when the relevant concepts have been studied and practised.

### 1. Console application — first milestone

Build the core task-management experience using C#.

Planned capabilities:

- Create and view tasks.
- Update and delete tasks.
- Mark tasks as complete.
- Assign a priority and track task status.
- Search and filter tasks.
- Work with task collections in memory.

Concepts to practise:

- Classes, objects, properties, and constructors
- Encapsulation and methods
- Collections and loops
- Conditional logic and input validation
- Basic exception handling

### 2. Deeper C# concepts

Improve the design and capabilities of the console application while exploring topics such as:

- Interfaces and abstraction
- Inheritance and polymorphism where appropriate
- Generics and delegates
- Events
- LINQ
- File handling and serialization
- Asynchronous programming
- Dependency injection

### 3. Data persistence

Introduce a database so tasks can be saved between application runs.

Topics to explore:

- Relational database fundamentals
- SQL and data modelling
- Entity Framework Core
- CRUD operations and migrations
- Relationships and basic transaction handling

### 4. ASP.NET Core Web API

Evolve TaskIt into a backend service.

Topics to explore:

- RESTful API design
- Controllers and routing
- DTOs and model validation
- Dependency injection and middleware
- Entity Framework Core integration
- Authentication and authorization

### 5. ASP.NET Core MVC

Build a web interface for managing tasks.

Topics to explore:

- MVC architecture
- Razor views
- Model binding and validation
- Forms and routing
- Integration with the application backend

### 6. Further improvements

As the project matures, possible additions include:

- User accounts and personal task lists
- Projects or task groups
- Task assignment and collaboration
- Comments and activity history
- Notifications and background processing
- Automated tests
- Logging, deployment, and CI/CD

These are future ideas, not features currently promised or implemented.

## Development approach

TaskIt is being developed incrementally. The priority is to understand the concepts behind each feature, implement them, and improve the design through review and refactoring.

The project will not adopt complex architecture or design patterns before they are useful. The aim is to understand **why** a design decision is appropriate, not simply to use a particular pattern.

## Current focus

The first milestone is a small console application that can create, store in memory, and display multiple tasks.

The initial task model is expected to include:

- **Id** — unique task identifier
- **Title** — short task name
- **Description** — optional details
- **Priority** — Low, Medium, or High
- **Status** — Pending, In Progress, or Completed
- **CreatedAt** — creation date and time
- **DueDate** — optional target date

The exact model and feature scope may change as implementation and learning progress.

## Getting started

The project is under development, and setup instructions will be added once the initial application structure is in place.

## License

No license has been specified yet.
