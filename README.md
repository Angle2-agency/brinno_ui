# BrinnoBlazorUIKit

This is a Blazor Server application built with .NET, showcasing various UI components and styling techniques. It demonstrates the use of DevExpress Blazor components alongside standard HTML and Bootstrap elements.

## Project Description

`BrinnoBlazorUIKit` is a web application built using the Blazor Server hosting model. It serves as a demonstration of how to integrate various UI components, including those from DevExpress, with custom styling and layouts. The application includes a responsive sidebar navigation menu, a header with interactive elements, and a main content area that showcases different UI elements.

## Features

- **Sidebar Navigation:** A collapsible sidebar menu allows users to navigate between different sections of the application.
- **Header with Actions:** The header includes a menu toggle button, a notification bell icon, and a user profile dropdown.
- **DevExpress Blazor Components:** The project utilizes various DevExpress Blazor components, such as `DxGridLayout`, `DxButton`, `DxMenu`, `DxAccordion`, `DxTextBox`, `DxSearchBox`, `DxComboBox`, `DxDropDownButton`, and `DxDataGrid`.
- **Custom Styling:** The application uses a combination of SCSS and CSS to achieve a unique and consistent visual style.
- **Bootstrap Integration:** Bootstrap classes are used for layout and styling, providing a familiar and robust foundation.
- **Demonstration of UI Elements:** The `Index.razor` page demonstrates various HTML elements, Bootstrap components, and DevExpress Blazor components.
- **Typography:** Custom typography is defined using SCSS variables and the Montserrat font.
- **Shadows:** Custom shadows are defined and used throughout the application.
- **Buttons:** Various button styles and sizes are demonstrated.
- **Text Inputs:** Different types of text inputs, including error states, are shown.
- **Search Box:** A DevExpress search box is implemented.
- **Combo Box:** A DevExpress combo box is implemented.
- **DropDown Button:** A DevExpress drop-down button is implemented.
- **Data Grid:** A DevExpress data grid is implemented to display tabular data with sorting and filtering capabilities.
- **Alerts and Toasts:** Components for displaying alerts and toast notifications.
- **Badges:** Components for displaying badges with customizable styles.
- **Charts:** Components for rendering charts and visualizations.
- **File Upload:** A component for uploading files.
- **Modal Dialogs:** Components for displaying modal dialogs.
- **Tabs and Switchers:** Components for tabbed navigation and view mode switching.
- **Tables:** Components for displaying tabular data with custom styles.

## Technologies Used

- **Blazor Server:** The application is built using the Blazor Server hosting model.
- **.NET:** The project is based on the .NET framework.
- **DevExpress Blazor:** A suite of UI components for Blazor.
- **Bootstrap:** A CSS framework for layout and styling.
- **SCSS:** A CSS preprocessor for managing styles.
- **HTML:** The markup language for the web pages.
- **CSS:** The styling language for the web pages.
- **Razor:** The templating language used in Blazor.

## Getting Started

### Prerequisites

- .NET SDK (latest version recommended)
- A code editor (e.g., Visual Studio, Visual Studio Code)
- Node.js (for SCSS compilation, if you modify SCSS files)

### Installation

1.  **Clone the repository:**

    ```bash
    git clone <repository-url>
    ```

2.  **Navigate to the project directory:**

    ```bash
    cd BrinnoBlazorUIKit
    ```

3.  **Restore NuGet packages:**

    ```bash
    dotnet restore
    ```

4.  **Install npm packages:**

    ```bash
    npm install
    ```

### Running the Application

1.  **Build the SCSS files:**

    ```bash
    npm run sass
    ```

2.  **Build the project:**

    ```bash
    dotnet build
    ```

3.  **Run the project:**

    ```bash
    dotnet run
    ```

4.  **Open your browser and navigate to** `https://localhost:<port>` (the port will be displayed in the console output).

## Project Structure

- **`Pages/`:** Contains the Razor components for the application's pages (e.g., `Index.razor`, `DataGridDemo.razor`).
- **`Components/`:** Contains reusable UI components, such as:
  - `Alerts.razor`
  - `Badges.razor`
  - `Buttons.razor`
  - `Charts.razor`
  - `CheckBoxes.razor`
  - `ComboBox.razor`
  - `CustomViewModeSwitcher.razor`
  - `DropDownBox.razor`
  - `FileUpload.razor`
  - `Headers.razor`
  - `Inputs.razor`
  - `Modal.razor`
  - `Radios.razor`
  - `Switchers.razor`
  - `Table.razor`
  - `Tabs.razor`
  - `Toasts.razor`
  - `Typography.razor`
- **`Shared/`:** Contains shared components and layouts (e.g., `MainLayout.razor`, `NavMenu.razor`).
- **`wwwroot/`:** Contains static files like CSS, JavaScript, and images.
  - **`wwwroot/scss/`:** Contains SCSS files for styling.
  - **`wwwroot/images/`:** Contains image assets.
- **`BrinnoBlazorUIKit.csproj`:** The project file.

## Styling and Design

- **SCSS:** The project uses SCSS for styling, which is located in the `wwwroot/scss/` directory.
  - `_variables.scss`: Defines color palettes, font sizes, and other reusable style variables.
  - `_typography.scss`: Defines typography styles, including font families and heading styles.
  - `_components.scss`: Defines styles for custom components and UI elements.
- **CSS:** Compiled CSS files are generated from SCSS and are located in the `wwwroot/css/` directory.
- **Component-specific CSS:** Each component has its own CSS file, for example `MainLayout.razor.css` and `NavMenu.razor.css`.
