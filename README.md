# 🏉 Pass It On Rugby Academy

**Pass It On Rugby Academy** is a web-based platform that connects players with certified coaches for professional rugby training sessions.  
The system allows players to register, book sessions, make secure PayFast payments, and receive booking confirmations — while coaches can manage availability, monitor payments, and view session statistics.

---

## 👥 Project Team – Pitch Perfect Devs

| Name | Student Number | Role & Responsibilities |
|------|----------------|------------------------|
| **Okuhle Nyawo** | ST10299658 | **Project Manager** – Oversaw project scope, managed sprint schedules, and ensured client communication. Coordinated between backend, frontend, and documentation teams to align with WIL deliverables. |
| **Cebolenkosi Nyawo** | ST10293982 | **Front-End Developer** – Designed and implemented the main user interface using ASP.NET Razor and Tailwind CSS. Focused on responsiveness, accessibility, and UI integration with backend controllers. |
| **David Dingani** | ST10358804 | **Back-End Developer (User Management & API)** – Implemented login, registration, and authentication features using ASP.NET Identity and Entity Framework Core. Ensured secure user management and data validation. |
| **Lethabo Penniston** | ST10302369 | **Back-End Developer (Database & Payments)** – Developed and optimised the Azure SQL database, handled Entity Framework migrations, and integrated the PayFast payment gateway for secure transactions. |
| **Lisha Naidoo** | ST10404816 | **Developer (Frontend Testing & Functionality)** – Tested and refined frontend workflows, validated user interactions, and assisted with booking system logic. Contributed to DevOps setup and testing automation. |
| **Luke Lutchmiah** | ST10288560 | **Developer (System Testing & Backend Support)** – Assisted with backend debugging, test case creation, and performance verification. Helped ensure smooth CI/CD integration and data flow reliability. |

---

## 📂 Project Overview

This project was developed using **ASP.NET Core MVC (C#)** in **Visual Studio 2022**, following the **Model–View–Controller (MVC)** architectural pattern.

### 🧩 Key Features
- **Secure user authentication** using ASP.NET Identity  
- **Session booking & management** with integrated calendar scheduling  
- **Online payments** via the PayFast gateway (with IPN verification)  
- **Azure SQL Database** for cloud data storage  
- **Entity Framework Core** for migrations and CRUD operations  
- **Responsive front-end** built with Razor Views and Tailwind CSS  
- **Role-based access control** for Admins, Coaches, and Players  
- **Integrated unit testing** using NUnit  

---

## 🧱 Architecture

| Layer | Description |
|:------|:-------------|
| **Presentation Layer** | Razor Views and Tailwind CSS used to deliver a responsive, accessible interface. |
| **Application Layer** | Controllers handle requests and business logic for bookings, authentication, and payments. |
| **Data Layer** | Azure SQL Database stores users, sessions, bookings, and payments securely. |
| **Cloud Services** | Azure App Service (hosting), Azure Key Vault (secret management), Azure Blob Storage (media). |

The system implements a **three-tier architecture** and follows **MVC design principles** for maintainability and scalability.

---

## 🔐 Security Practices

- **HTTPS / TLS 1.3** enforced for all communication  
- **Azure Key Vault** used to store connection strings and API keys  
- **Input validation and sanitisation** for all user forms  
- **Role-based access control** ensures least-privilege permissions  
- **PayFast PCI-compliant transactions** for secure payment processing  
- **Defence in depth**: multiple layers of validation, authentication, and encryption  

---

## ⚙️ DevOps Pipeline

The project uses **GitHub Actions** for continuous integration and deployment (CI/CD).

### 🛠 Workflow Overview
1. **Build Stage** – Compiles the solution and restores NuGet dependencies.  
2. **Test Stage** – Executes NUnit unit tests automatically.  
3. **Static Code Analysis** – Runs **CodeQL** and **Dependabot** scans for vulnerabilities.  
4. **Deploy Stage** – Publishes the application to **Azure App Service** upon successful tests.

### 📈 Evidence
- Unit tests successfully pass in Visual Studio (NUnit Explorer).  
- CodeQL workflow results appear under the project’s **Security → Code Scanning Alerts**.  
- Dependabot automatically monitors outdated or insecure dependencies.

---

## 🧪 Unit Testing

All test cases are contained in the `RugbyWebApp.Tests` project.

| Test Class | Purpose |
|-------------|----------|
| `BookingTests.cs` | Verifies booking–session–user linkage |
| `HomeControllerTests.cs` | Checks routing and page rendering |
| `ModelValidationTests.cs` | Validates data-annotation rules |

All tests have passed successfully during the CI/CD run.

---

## 💰 Running Costs & Scalability

The system is hosted on **Azure**, with scalable cloud services:

| Service | Scaling | Notes |
|----------|----------|-------|
| **Azure App Service** | Automatic scaling by CPU % | Handles traffic spikes efficiently |
| **Azure SQL Database** | DTU-based scaling | Predictive two-year growth modelling applied |
| **Azure Blob Storage** | Pay-per-use | Supports media and document storage |

Predictive modelling considers best-, worst-, and average-growth scenarios to estimate future hosting costs.

---

## 👩‍💻 Change Management & Adoption

- Players and coaches receive guided onboarding through email verification.  
- Admin dashboard ensures continuous system monitoring and updates.  
- A maintenance plan is in place to apply security patches and manage Azure resources.  
- Documentation and GitHub issues are used for version tracking and feedback.

---

## ⚖️ License

This repository is licensed under the **MIT License**.

> This license was chosen to allow open reuse and modification for learning and collaboration, while requiring proper attribution to the original authors.  
> It reflects ethical software practice and aligns with academic integrity principles outlined in the IIE Digital Law & Ethics module.

---

## 🧾 Technical References (Code & Frameworks Used)

- **Microsoft (2025)** – *Configure ASP.NET Core Identity.* [Microsoft Learn](https://learn.microsoft.com/en-us/aspnet/core/security/authentication/identity-configuration?view=aspnetcore-9.0)  
- **Microsoft (2024)** – *ASP.NET Core Documentation.* [Microsoft Learn](https://learn.microsoft.com/en-us/aspnet/core/?view=aspnetcore-9.0)  
- **Microsoft (2025)** – *Azure Blob Storage Documentation.* [Microsoft Learn](https://learn.microsoft.com/en-us/azure/storage/blobs/)  
- **Microsoft (2025)** – *Azure SQL Database Documentation.* [Microsoft Learn](https://learn.microsoft.com/en-us/azure/azure-sql/database/?view=azuresql)  
- **Microsoft (2025)** – *Azure Storage Overview.* [Microsoft Learn](https://learn.microsoft.com/en-us/azure/storage/)  
- **GitHub Docs (2025)** – *About GitHub Actions for CI/CD.* [GitHub Actions Docs](https://docs.github.com/en/actions)  
- **GitHub (2025)** – *Collaborating with Pull Requests.* [GitHub Docs](https://docs.github.com/en/pull-requests/collaborating-with-pull-requests)  
- **PayFast Developers (2025)** – *Integration Guide and API Documentation.* [PayFast Docs](https://developers.payfast.co.za/documentation/)  
- **OWASP Foundation (2025)** – *Top 10 Web Application Security Risks.* [OWASP Project](https://owasp.org/www-project-top-ten/)  
- **NUnit (2025)** – *Unit Testing Best Practices.* [NUnit Docs](https://docs.nunit.org/)  
- **Tailwind Labs (2025)** – *Tailwind CSS Framework Documentation.* [Tailwind CSS](https://tailwindcss.com/)  
- **PlantUML (2025)** – *Diagram and Architecture Documentation Tool.* [PlantUML](https://plantuml.com/)  

---

## 🏁 Summary

This project demonstrates the implementation of:
- Secure cloud architecture (Azure services)  
- Continuous integration and deployment with GitHub Actions  
- Comprehensive unit testing using NUnit  
- Ethical software practice through licensing and referencing  

> > 🧠 *Note:* This repository was forked from the main **Pass It On Rugby Academy** source for testing and DevOps implementation.  
> This ensured that CI/CD, unit tests, and CodeQL scans could run independently without interfering with the main production codebase.


