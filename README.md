# Blazor WebAssembly Frontend - Restaurant App
Watch live at : https://thanblazorrest.netlify.app/

Go to Reservation, reserve a table. Go to Admin to see the reservations.

Many thanks to the author of the template: https://www.justinmind.com/open-resource?url=/design-templates/restaurant-landing-page.vp

<img width="1632" height="920" alt="image" src="https://github.com/user-attachments/assets/8ca69a73-e1f1-48d3-897c-4cfa3e31d274" />

  
Frontend Summary (Blazor WASM)

Tech Stack: C# (.NET 8), Blazor WebAssembly, Tailwind CSS, Lucide.Blazor.

This is a Single Page Application (SPA) that runs C# code directly in the browser via WebAssembly. It utilizes the .NET ecosystem for logic and type safety.

    Architecture & Features:

        Component-Based: Uses .razor files which combine HTML markup and C# logic in a single file (@code { ... }).

        Strong Typing: Uses shared C# Models (ReservationModel) to ensure data sent to the API matches exactly what the backend expects.

        Configuration: Uses appsettings.json (and appsettings.Development.json) to handle API URLs for different environments (Local vs. Production).

        Styling: Integrates Tailwind CSS via an NPM build script, allowing utility classes to be used directly in Razor markup.

    Key Files & Structure:

        Program.cs: The entry point. It loads configuration, registers the HttpClient, and sets the API Base URL.

        Layout/MainLayout.razor: The global application shell containing the Navigation Bar and the @Body placeholder.

        Pages/:

            Home.razor: Landing page with Hero, Intro, and Event sections.

            Reservation.razor: A C#-driven 3-step wizard (Guests, Calendar logic, Time slots) handling API submission.

            Admin.razor: A dashboard that fetches reservation lists from the backend using Http.GetFromJsonAsync.

            Menu.razor: Displays food items using C# foreach loops over data lists.

        Models/ReservationModel.cs: The C# class defining the structure of reservation data (mapping _id, people, date, etc.).

        wwwroot/css/: Contains the input (app.css) and compiled (site.css) Tailwind styles.

    How to Run:

        Install Dependencies:

            Run npm install (to setup Tailwind).

            Run dotnet restore (to setup C# packages).

        Build CSS:

            Run npm run build:css (starts the Tailwind watcher).

        Run App:

            Open a new terminal and run dotnet watch (starts the Blazor server on a random port, usually http://localhost:5xxx).
