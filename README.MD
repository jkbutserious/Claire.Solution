# Pierre's Vendors

#### C# practice for Epicodus, 07.24.2020

## By Jeff Kim

## Description

Pierre's friend Claire has been looking to streamline her business and better manage her stylists and clients.

This project uses C# and MVC to create a web interface that will allow Claire to add stylists to her system and keep track of each stylist's clients. Claire will be able to add clients in each stylist's details page and make sure that clients cannot be added without a stylist. 

## Specifications

| Behavior | Input | Output |  Completed(Y/N?)  |
| -------- | ----- | ------ | -------- |
| Create an object called Stylist with properties for name and a list of Clients |  |  | N |
| Create an object called Client with properties for name and their associated Stylist | | | N |
| Allow users to create a new Stylist object through a user interface |  |  | N |
| Allow users to create a new Client from a Stylist object's details page |  |  | N |
| Maintain a one-to-many relationship via a SQL database | | | N |

## Setup/Installation Requirements

Requirements:
* [.NET Core SDK 2.2](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.203-windows-x64-installer)

To use this program:

1. Open your preferred browser.
2. Navigate to https://github.com/jkbutserious/HairSalon.Solution.git.
3. Click the **Code** button and click **Download ZIP** to clone the repository to your computer.
4. Open the Windows PowerShell console, VS Code Bash terminal, or the MacOS Terminal and use the 
    
    ```cd [YOUR DOWNLOAD FILEPATH]/HairSalon.Solution/HairSalon```
    
    command to navigate to the HairSalon subdirectory.
5. Use the 

    ```dotnet restore```

    command to install the necessary packages on your computer.

6. Use the 

    ```dotnet run```

    command to run the program.

7. Use the web interface to add vendors and orders and keep track of Claire's business.

8. If you have any issues running this program, please reach out to the developer or troubleshoot at your own risk.

You will receive output in the form of a range of numbers and strings.

To contribute to this project:

1. Open your preferred browser.
2. Navigate to https://github.com/jkbutserious/HairSalon.Solution.
3. Log into or sign up for your GitHub account.
4. Click the **Fork** button to copy the repository and all source code.
5. From your forked repository, you can download or clone the repository, by clicking the **Code** button.
  * To clone the repository in Visual Studio Code's terminal, use the command

    ```git clone https://github.com/jkbutserious/HairSalon.Solution```
  * To clone the repository in GitHub Desktop, click the **Open in Desktop** option
  * To download the repository, click the **Download ZIP** option, save the archive to your computer, and extract it to the folder of your choice
6. Use your preferred code editor to edit the appropriate model and view files. New classes should be added in the Models subdirectory and should use the ```Pierre.Models``` namespace. **Note**: the following file is a C# project files and should not be edited:
  * HairSalon.csproj
7. Save any changes you make in your code editor and use your preferred git solution to commit your changes.
8. Push your changes to your forked repository.

#### Additional Setup/Installation Notes:

* You do not need to run a server to view this document.

* No additional code is necessary to view this project.   

## Known Bugs

_No known issues. Please contact me if you have any problems._


## Support and contact details

To report any issues with this page or to contribute to this project, contact Jeff Kim at kim2jy@hotmail.com.

## Technologies Used

* C#
* .NET Core 2.2
* Visual Studio Code 
* Git and Git BASH 


### License

Copyright © 2020 Jeffrey Kim

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.