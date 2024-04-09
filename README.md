# Imperial-Australian_Bank
This bank code is for an assessment <br> 

## Introduction

This project entails the development of a banking software application tailored for a major bank in New South Wales, Australia. The application comprises four key modules: signup, login, deposit, and withdraw. Assessment 2 focuses on the signup and login modules, while subsequent assessments will cover additional banking operations.

### Signup Module
The signup module collects user information necessary for account creation. Users input their details, which are then validated and stored securely.

### Login Module
The login module verifies user credentials against registered information. Upon successful verification, users gain access to the banking system, enabling them to perform various financial transactions.

### Program Development
The project involves the implementation of appropriate methods within the Bank class to facilitate user authentication and data management. These methods ensure the secure and efficient operation of the banking software application.

## Installation
### For downloading Visual Studios
To set up Visual Studio and get started with the banking software application, follow these steps:

1. **Install Visual Studio**:
   - If you haven't already, download and install Visual Studio from the official [Visual Studio website](https://visualstudio.microsoft.com/downloads/).
   - Follow the on-screen instructions to complete the installation process.

2. **Open Visual Studio**:
   - Launch Visual Studio from your desktop or Start menu.

3. **Create a New Project**:
   - Click on "File" > "New" > "Project...".
   - In the "Create a new project" window, select "Console App (.NET Core)".
   - Choose a name and location for your project.
   - Click "Create" to create the project.

4. **Write Your Code**:
   - In the Solution Explorer window, you'll see your newly created project.
   - Double-click on the `Program.cs` file to open it.
   - Write your C# code within the `Main` method or create additional methods as needed.

5. **Build and Run**:
   - To build your project, press Ctrl+Shift+B or go to "Build" > "Build Solution".
   - To run your project, press F5 or go to "Debug" > "Start Debugging". Alternatively, you can press Ctrl+F5 to start without debugging.

6. **View Output**:
   - The output of your console application will appear in the Output window at the bottom of the Visual Studio interface.
   - Any `Console.WriteLine()` statements in your code will display text in the console window.

7. **Navigate Project Folder**:
   - To access the project folder in Windows Explorer:
     - Right-click on the project name in Solution Explorer.
     - Select "Open Folder in File Explorer".

8. **Add Additional Files**:
   - To add existing files to your project:
     - Right-click on the project name in Solution Explorer.
     - Select "Add" > "Existing Item...".
     - Choose the files you want to add and click "Add".

9. **Manage NuGet Packages**:
   - To manage NuGet packages for your project:
     - Right-click on the project name in Solution Explorer.
     - Select "Manage NuGet Packages...".
     - Use the NuGet Package Manager window to search for, install, or remove packages.

10. **Debugging**:
    - Set breakpoints in your code by clicking in the margin next to the line number.
    - Start debugging your application (F5) to run it with breakpoints enabled.
    - When a breakpoint is hit, you can inspect variables and step through your code using the debugging toolbar.

11. **Publish or Deploy**:
    - To publish your console application:
      - Right-click on the project name in Solution Explorer.
      - Select "Publish...".
      - Follow the prompts to choose a publishing target and configure publishing options.

This integrated installation guide provides a comprehensive overview of setting up Visual Studio and creating a Console C# project, followed by instructions for downloading and extracting the banking software application. Adjustments may be needed based on your specific project requirements and Visual Studio version.]

### For downloading the files directly
To get started with the banking software application, follow these simple steps:

1. **Download Required Files**:
   - Click on the following links to download the necessary zip files:
     - <a href="https://github.com/GitHubSASH24/Imperial-Australian_Bank/raw/main/zMainScreen.zip" download>zMainScreen.zip</a>
     - <a href="https://github.com/GitHubSASH24/Imperial-Australian_Bank/raw/main/zSign_In_Code.zip" download>zSign_In_Code.zip</a>
     - <a href="https://github.com/GitHubSASH24/Imperial-Australian_Bank/raw/main/zSignup_Registration.zip" download>zSignup_Registration.zip</a>
     
2. **Extract Zip Files**:
   - Once the zip files are downloaded, locate them in your downloads folder or the directory where your browser saves files.
   - Right-click on each zip file and select "Extract" or "Extract All" to unzip the contents. You can choose a destination folder for extraction or use the default location.

3. **Open Project Folder**:
   - Navigate to the folder where you extracted the zip files. You should find separate folders for each module (zMainScreen, zSign_In_Code, zSignup_Registration).

4. **Start Using the Application**:
   - You are now ready to explore the banking software application. Refer to the README files within each module folder for specific instructions on usage and setup.
This installation guide provides clear instructions for users to download and extract the required zip files, ensuring they can quickly set up and begin using the banking software application. Adjust the hyperlinks and file names as necessary to match the actual download locations and filenames.

## Project Usage Guide in Visual Studio

### 1. Sign-Up Module:

#### Sign-Up Process:
1. Open Visual Studio.
2. Load the solution file (`zSignup_Registration.sln`) located in the `zSignup_Registration` folder.
3. Navigate to the `Signup.cs` or similar file within the Solution Explorer.
4. Review and modify the code as necessary to customize the sign-up process.
5. Build the solution by clicking on "Build" > "Build Solution" or pressing Ctrl+Shift+B.
6. Run the application by clicking on "Debug" > "Start Debugging" or pressing F5.
7. Follow the on-screen instructions to provide necessary information such as name, email, address, etc.
8. Once signed up, your information will be stored securely for future login.

#### File Significance:
- **`Signup.cs`**: This C# file contains the logic for the sign-up process, collecting and storing user information securely.
- **`Database.cs`**: This C# file handles database operations, ensuring the secure storage of user data.

### 2. Login Module:

#### Login Process:
1. Open Visual Studio.
2. Load the solution file (`zSign_In_Code.sln`) located in the `zSign_In_Code` folder.
3. Navigate to the `Login.cs` or similar file within the Solution Explorer.
4. Review and modify the code as necessary to customize the login process.
5. Build the solution.
6. Run the application.
7. Enter your registered email and password.
8. Upon successful authentication, you will gain access to further banking operations.

#### File Significance:
- **`Login.cs`**: This C# file contains the logic for the login process, verifying user credentials against registered information and granting access upon successful authentication.
- **`Database.cs`**: This C# file continues to handle database operations, facilitating the retrieval and verification of user credentials.

### 3. Main Screen Module:

#### Access Main Screen:
1. Open Visual Studio.
2. Load the solution file (`zMainScreen.sln`) located in the `zMainScreen` folder.
3. Navigate to the `MainScreen.cs` or similar file within the Solution Explorer.
4. Review and modify the code as necessary to customize the main screen interface and functionality.
5. Build and run the application to access the main screen of the banking application, offering access to essential banking features.

#### File Significance:
- **`MainScreen.cs`**: This C# file contains the logic for the main screen of the banking application, offering access to essential banking features.
- **`Database.cs`**: This C# file continues to handle database operations, ensuring seamless integration with user account data.

### 4. Deposit and Withdraw Modules (Assessment 3):

#### Future Functionality:
- The deposit and withdraw modules will be developed in Assessment 3 within Visual Studio, expanding the banking application's functionality to include financial transactions.
- Stay tuned for updates on these modules in subsequent releases.
This usage guide provides step-by-step instructions on how to use the project within Visual Studio, emphasizing the significance of each included file in facilitating different aspects of the banking software application. Adjustments may be needed based on specific project requirements and Visual Studio version.

Sure, here's a list of main features enabled by the included files in the banking software application:

## Features
1. **Sign-Up Module:**
   - User registration process to create new accounts securely.
   - Collection of user information including name, email, address, etc.
   - Storage of user data in a secure database for future access.

2. **Login Module:**
   - User authentication to verify credentials against registered information.
   - Access control to allow verified users to perform banking operations.
   - Secure handling of user login information to ensure data privacy.

3. **Main Screen Module:**
   - Display of essential banking features such as account balance, transaction history, etc.
   - User-friendly interface for easy navigation and interaction.
   - Integration with backend systems to provide real-time account information.

4. **Deposit and Withdraw Modules (Assessment 3):**
   - Implementation of financial transaction functionalities such as deposit and withdrawal.
   - Secure handling of monetary transactions to ensure data integrity and security.
   - Logging and tracking of transaction history for auditing and accountability purposes.

These features collectively provide a comprehensive banking solution, enabling users to create accounts, securely log in, access account information, and perform financial transactions within a reliable and user-friendly environment. As the project progresses, additional features and functionalities will be added to enhance the banking experience further.

## File Inclusion

### zMainScreen.zip (by Eva)
This file contains [describe contents of zMainScreen.zip]. It was contributed by Eva.
<a href="https://github.com/GitHubSASH24/Imperial-Australian_Bank/raw/main/zMainScreen.zip" download>Download zMainScreen.zip</a>

### zSign_In_Code.zip (by Spencer)
This file includes [describe contents of zSign_In_Code.zip]. It was contributed by Spencer.
<a href="https://github.com/GitHubSASH24/Imperial-Australian_Bank/raw/main/zSign_In_Code.zip" download>Download zSign_In_Code.zip</a>

### zSignup_Registration.zip (by Abdul S.H. Syed)
This archive contains [describe contents of zSignup_Registration.zip]. It was contributed by Abdul S.H. Syed.
<a href="https://github.com/GitHubSASH24/Imperial-Australian_Bank/raw/main/zSignup_Registration.zip" download>Download zSignup_Registration.zip</a>

## Contributing
Thank you for your interest in contributing to the banking software project! We welcome contributions from the community to help improve and enhance the functionality of our application. Here are some guidelines to follow when contributing:

1. **Familiarize Yourself with the Project:**
   - Before contributing, take the time to familiarize yourself with the project structure, codebase, and existing features.

2. **Check for Existing Issues:**
   - Check the project's issue tracker for any existing issues or feature requests.
   - If you plan to work on a specific issue, please assign it to yourself to avoid duplication of effort.

3. **Fork the Repository:**
   - Fork the repository to your GitHub account.
   - Create a new branch for your contributions based on the `main` branch.

4. **Make Changes:**
   - Make your desired changes or additions to the codebase.
   - Ensure that your code follows the project's coding conventions and style guidelines.

5. **Test Your Changes:**
   - Test your changes locally to ensure they work as expected.
   - Write tests if necessary to cover new functionality or fix bugs.

6. **Commit Your Changes:**
   - Commit your changes with clear and descriptive commit messages.
   - Reference any related issues in your commit messages using GitHub's issue linking feature.

7. **Push Changes and Submit Pull Request:**
   - Push your changes to your forked repository.
   - Submit a pull request (PR) to the `main` branch of the original repository.
   - Provide a detailed description of your changes in the PR description.

8. **Review and Feedback:**
   - Participate in the code review process by responding to feedback and addressing any requested changes.
   - Be open to constructive criticism and willing to collaborate with other contributors.

9. **Stay Engaged:**
   - Stay engaged with the community by participating in discussions and offering assistance to other contributors.
   - Consider becoming a regular contributor to the project by tackling more issues and adding new features over time.

Thank you for your contributions and for helping make our banking software application even better! If you have any questions or need assistance, feel free to reach out to the project maintainers. We appreciate your support!
**DO NOT QUESTION NAME OF SAID BANK**
