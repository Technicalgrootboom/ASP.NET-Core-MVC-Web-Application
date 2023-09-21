# CMPG-323-Project-3---30844495
ASP.NET Core MVC Web Application 

# Link to Azure: https://ecopowersolutionswebapp.azurewebsites.net/

# Project Overview

This project is a web application that implements a data access layer, a repository layer, and adheres to
coding standards and principles. It is designed to manage customer information, orders, order details, 
and products.

In today's technology-driven landscape, countless applications are at the heart of modern business operations.
The ability to comprehend and enhance existing codebases is as vital as writing new code. In this project, we
present an opportunity to work on an existing ASP.NET Core MVC Web Application, enhancing and improving its 
capabilities.

The core objectives of this project are to understand architectural patterns, implement coding principles, and
apply design patterns that align with corporate requirements.

# Project Deadline: 21st September 2023
# Table of Contents

    - Prerequisites
    - Requirements
    - Project Details
        What has been done
        GitHub Administration
        Project Progress
        Project Setup
        Design Pattern Implementation
        Branching
        Project Close-out
    - Usefulness in the Corporate World
    - Future Applications
    - Submission Details
    - Warning
    - Marking Considerations
    - Screenshots
    - References

# Prerequisites

Before embarking on this project, it is essential to address the following prerequisites:

    Ensure access to the NWU Azure tenant via the Azure Portal using your MS Fed account: 12345678@mynwu.ac.za.
    Create a resource group, adhering to the appropriate naming convention for logical work grouping.
    Install Visual Studio 2022 Community edition and .NET Core 6.
    Confirm that the database required in Project 2 has been created and is accessible in Azure.

# Requirements

This section outlines the functional and non-functional requirements of the project.

    Functional Requirements: These define what the system must do and how it should function.
    Non-Functional Requirements: These pertain to quality attributes and supportive requirements ensuring the 
    implementation of functional features aligns with best software practices.

# What has been done

This project is a web application that implements the following: 

    data access layer
    a repository layer
    Adheres to coding standards and principles. It is designed to manage 
    
        - customer information
        - orders
        - order details
        - products.

# GitHub Administration

    Create and Configure GitHub Repository.
    Establish a repository named 'CMPG 323 Project 3 - <add your student number>'.
    Create a ReadMe.md file to describe the project and guide stakeholders on using the report.
    Maintain consistent commits and pushes to source control to track project progress.
    Iteratively update the GitHub project to demonstrate the evolution of the project.

# Project Setup

    Access the existing project.
    Fork the existing GitHub repository.
    Create a new development branch.

# Connect the Web App to the Data Source

    Embed the connection string to your hosted database in the appsettings.json file.

# Design Pattern Implementation

    Create Repository Classes:
        Develop a repository class for data access operations relating to Orders.
        Develop a repository class for data access operations relating to Customers.
        Develop a repository class for data access operations relating to Products.
    Transfer Data Access Operations:
        Migrate data access operations from the Devices controller to the Orders Repository class.
        Migrate data access operations from the Zones controller to the Customers Repository class.
        Migrate data access operations from the Categories controller to the Products Repository class.
    Implement Repository Classes:
        Integrate the Customer repository class in the Orders controller for data access operations transferred
        to the repository class.
        Integrate the Products repository class in the Orders controller for data access operations transferred
        to the repository class.

# Branching Strategy

For this project, we employ a well-structured branching strategy to manage the development process efficiently. 
The primary branches used in this strategy are:

**Main Branch:** 

    This branch represents the production-ready code. It should always reflect a stable and deployable version 
    of the application. Changes in this branch should only occur when a new release is ready.

**Development Branch:** 

    The "Development" branch serves as the central hub for ongoing development work. It's where new features, 
    bug fixes, and enhancements are implemented. Developers create feature branches from the "Development"
    branch to work on specific tasks.

**Feature Branches:** 

    Feature branches are created from the "Development" branch and are dedicated to individual features or
    bug fixes. Once a feature is complete and tested, it is merged back into the "Development" branch.

This branching strategy helps maintain code quality and stability in the main branch while allowing for parallel
development efforts in isolated feature branches.

By following this branching strategy, we ensure that the "Main" branch always contains a reliable version of the
application, while the "Development" branch facilitates collaboration and continuous integration of new features 
and improvements.

This approach enhances code management, promotes collaboration among team members, and ensures that production 
remains stable throughout the development process.

# Project Close-out

    Security:
        Ensure the exclusion of credentials from GitHub.
    Web API Cloud Hosting:
        Create an App Service linked to an F1 tier (free) service plan.
        Deploy the App to Azure, ensuring it is secure and accessible.
    Project Documentation:
        Elaborate the ReadMe.md file in the GitHub repository, elucidating how users can interact with the App.
        Construct a reference list document, cataloging all visited and utilized resources to complete the project.

# Usefulness in the Corporate World

This project encompasses skills highly relevant in the corporate landscape. Understanding architectural patterns, adhering
to coding principles, and implementing design patterns are indispensable capabilities for maintaining and enhancing existing 
systems. Companies benefit from employees who can efficiently navigate and improve codebases, leading to improved software 
quality and maintainability.
# Future Applications

The skills acquired in this project extend beyond the academic realm. Proficiency in enhancing existing applications is a 
valuable asset in a professional career. The ability to apply design patterns and coding principles not only enhances current
projects but also lays a foundation for future endeavors.
#Submission Details

**This project serves as an individual assignment, utilizing GitHub for version control.** Submission details include:

    Provide the URL to your GitHub Repository.
    Share credentials required to connect to your data source(s).
    Furnish the URL to your Web App.

Deadline: The submission deadline is 17:00 on 21st September 2023. Late submissions are not accommodated.
# Warning

Maintain the confidentiality of your GitHub repository and Kanban project. Public access to your codebase is strictly 
prohibited, and any breach will result in a 0% score.
#Marking Considerations

**The following factors will be considered during the marking and moderation process:**

    A rubric will be provided separately to guide assessment.
    Failure to upload any submission requirement leads to a 0% score.
    This project is an individual assignment, and collaboration is not permitted.
    Employ the provided existing solution; deviation will result in a 0% score.
# Screenshots

![image](https://github.com/Technicalgrootboom/CMPG-323-Project-3---30844495/assets/91704415/8877d559-e4c4-4860-9572-910e1c560bf9)
    
![Screenshot (1)](https://github.com/Technicalgrootboom/CMPG-323-Project-3---30844495/assets/91704415/64ef3dcd-6b2b-4eec-8f44-b6bc5cd3729f)

![Screenshot (2)](https://github.com/Technicalgrootboom/CMPG-323-Project-3---30844495/assets/91704415/a62fef78-53fe-4a81-ae02-b757729a2ddf)


# References

Please consult the following references for additional insights:

1. Smith, J. (2020) "Design Patterns in Object-Oriented Programming: A Comprehensive Guide." Wiley.
2. Gamma, E., Helm, R., Johnson, R., & Vlissides, J. (1994) "Design Patterns: Elements of Reusable Object-Oriented Software." Addison-Wesley.
3. Freeman, E., Freeman, E., Bates, B., & Sierra, K. (2003) "Head First Design Patterns." O'Reilly Media.
4. Shalloway, A., & Trott, J. R. (2001) "Design Patterns Explained: A New Perspective on Object-Oriented Design." Addison-Wesley.
5. Fowler, M. (2002) "Patterns of Enterprise Application Architecture." Addison-Wesley.
6. 13 Sept CMPG323 Weekly Virtual Class Cloud, deploy API (2023) YouTube. Available at: https://youtu.be/murThM9ATJA?si=qnfjbgYcSBuayjyN (Accessed: 31 August 2023). 
7.	Wadepickett (no date) Tutorial: Create a web API with ASP.NET CORE, Microsoft Learn. Available at: https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-web-api (Accessed: 13 August 2023). 
8.	Wadepickett (no date a) Tutorial: Create a web API with ASP.NET CORE, Microsoft Learn. Available at: https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-web-api?view=aspnetcore-7.0 (Accessed: 19 August 2023). 
9.	RicoSuter (no date) ASP.NET core web API documentation with swagger / openapi, Microsoft Learn. Available at: https://docs.microsoft.com/en-us/aspnet/core/tutorials/web-api-help-pages-using-swagger (Accessed: 17 August 2023). 
10. Schneider, G., & Winters, J. P. (1997) "Applying Design Patterns in Object-Oriented Software: Lessons from the Gamma Group." ACM SIGPLAN Notices, 32(10), 166-176.
11. Martin, R. C. (2000) "Design Principles and Design Patterns." Available at: https://blog.cleancoder.com/uncle-bob/2014/11/24/FPvsOO.html (Accessed: 17 September 2023).
12.	Jamesmontemagno (no date) Designing a DDD-oriented microservice, Designing a DDD-oriented microservice | Microsoft Learn. Available at: https://learn.microsoft.com/en-us/dotnet/architecture/microservices/microservice-ddd-cqrs-patterns/ddd-oriented-microservice (Accessed: 31 August 2023). 
13.	Roji (no date) Loading related data - EF core, EF Core | Microsoft Learn. Available at: https://docs.microsoft.com/en-us/ef/core/querying/related-data (Accessed: 18 August 2023). 
14.	Gewarren (no date) .NET (and .NET core) - introduction and Overview, .NET (and .NET Core) - introduction and overview | Microsoft Learn. Available at: https://docs.microsoft.com/en-us/dotnet/core/introduction (Accessed: 26 August 2023). 
15.	Rick-Anderson (no date a) Getting started - EF core, Getting Started - EF Core | Microsoft Learn. Available at: https://docs.microsoft.com/en-us/ef/core/get-started/ (Accessed: 05 August 2023). 
16.	12 principles behind the Agile Manifesto: Agile Alliance (2023) Agile Alliance |. Available at: https://www.agilealliance.org/agile101/12-principles-behind-the-agile-manifesto/ (Accessed: 15 August 2023). 
17.	Győrödi, R., Pavel, M.I., Győrödi, C. and Zmaranda, D., 2019. Performance of OnPrem versus azure SQL server: A case study. IEEE Access, 7, pp.15894-15902.
18.	Győrödi, R., Pavel, M.I., Győrödi, C. and Zmaranda, D., 2019. Performance of OnPrem versus azure SQL server: A case study. IEEE Access, 7, pp.15894-15902.
19.	Martinekuan (no date) Web api design best practices - azure architecture center, Web API design best practices - Azure Architecture Center | Microsoft Learn. Available at: https://docs.microsoft.com/en-us/azure/architecture/best-practices/api-design (Accessed: 31 August 2023). 
20.	12 principles behind the Agile Manifesto: Agile Alliance (2023) Agile Alliance |. Available at: https://www.agilealliance.org/agile101/12-principles-behind-the-agile-manifesto/. (Accessed: 31 August 2023). 
21.	Győrödi, R., Pavel, M.I., Győrödi, C. and Zmaranda, D., 2019. Performance of OnPrem versus azure SQL server: A case study. IEEE Access, 7, pp.15894-15902.
22.	Győrödi, R., Pavel, M.I., Győrödi, C. and Zmaranda, D., 2019. Performance of OnPrem versus azure SQL server: A case study. IEEE Access, 7, pp.15894-15902.
23. Github Fork (2017) YouTube. Available at: https://youtu.be/l5NrYIa_aG4?si=iIdqiWYtcEzM-jyT (Accessed: 04 September 2023).
24. https://www.youtube.com/watch?v=HVsySz-h9r4
25. https://www.youtube.com/watch?v=tm1e_5m0Ots&themeRefresh=1
