# Eau Claire's Salon

#### C# practice for Epicodus, 07.31.2020

## By Jeff Kim

## Description

Pierre's friend Claire has been looking to streamline her business and better manage her stylists and clients.

This project uses C#, MySQL, Entity Framework, and MVC to create a web interface that will allow Claire to add stylists to a database and use her system to keep track of each stylist's clients. Claire will be able to add clients in each stylist's details page and make sure that clients cannot be added without a stylist. 

## Specifications

| Behavior | Input | Output |  Completed(Y/N?)  |
| -------- | ----- | ------ | -------- |
| Create an object called Stylist with properties for name and a list of Clients |  |  | Y |
| Create an object called Client with properties for name and their associated Stylist | | | Y |
| Allow users to create a new Stylist object through a user interface |  |  | Y |
| Allow users to create a new Client from a Stylist object's details page |  |  | Y |
| Maintain a one-to-many relationship via a SQL database | | | Y |

## Setup/Installation Requirements

**Requirements:**
* [.NET Core SDK 2.2](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.203-windows-x64-installer)
* [MySQL Server 8.0.19](https://dev.mysql.com/downloads/file/?id=484919)
* [MySQL Workbench 8.0.19](https://dev.mysql.com/downloads/file/?id=484919)
* Entity Framework

To recreate the database using MySQL Workbench:

_**Note**: These instructions assume that you have installed and set up your MySQL Server according to Epicodus's guidelines. For more information, see [Installing and Configuring MySQL](https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-and-configuring-mysql)._

1. Open Windows PowerShell, the MacOS Terminal, or your VS Code terminal and use the command ``mysql -uroot -pepicodus`` to ensure that your server is running.
2. Open MySQL Workbench and double click your server instance.
3. Click the **Schemas** tab.
4. Click the **Create a new Schema in the connected server** button in the top navbar (fourth button from the left).
5. For the **Database Name**, enter jeff_kim and keep the rest of the settings on their default values.
6. Click **Apply** > **Apply** > **Finish**.
7. In the **Schemas** sidebar, expand **jeff_kim**, right-click **Tables**, and click **Create Table**.
8. In the **Name** field, enter *clients*.
9. Create the following rows in the table:

    | **Column Name** | **Datatype** | **PK** | **NN** | **UQ** | **B** | **UN** | **ZF** | **AI** | **G** | **Default/Expression** |
    |-----------------|--------------|--------|--------|--------|-------|-------|--------|--------|-------|------------------------|
    | ClientId | INT | X | X |   |   |   | X |   |   |
    | name | VARCHAR(255) | | | | | | | | | |
    | StylistId | INT | | | | | | | | | '0'|
10. Click Click **Apply** > **Apply** > **Finish**.
11. Right-click **Tables**, and click **Create Table**.
12. In the **Name** field, enter *stylists*.
13. Create the following rows in the table:

    | **Column Name** | **Datatype** | **PK** | **NN** | **UQ** | **B** | **UN** | **ZF** | **AI** | **G** | **Default/Expression** |
    |-----------------|--------------|--------|--------|--------|-------|-------|--------|--------|-------|------------------------|
    | StylistId | INT | X | X | | | | | X | | |
    | name | VARCHAR(255) | | | | | | | | | NULL |
14. Click **Apply** > **Apply** > **Finish**.


**To use this program:**

1. Open your preferred browser.
2. Navigate to https://github.com/jkbutserious/HairSalon.Solution.git.
3. Click the **Code** button and click **Download ZIP** to clone the repository to your computer.
4. Open the Windows PowerShell console, VS Code Bash terminal, or the MacOS Terminal and use the ``cd [YOUR DOWNLOAD FILEPATH]/HairSalon.Solution/HairSalon`` command to navigate to the HairSalon subdirectory.
5. Use the ``dotnet restore`` command to install the necessary packages on your computer.
6. Use the ``dotnet run`` command to run the program.
7. Use the web interface to add stylists and clients and keep track of Claire's business.
8. Ensure that the following code is present in your *appsettings.json* file:

    ```
    {
      "ConnectionStrings": {
          "DefaultConnection": "Server=localhost;Port=3306;database=jeff_kim;uid=root;pwd=epicodus;"
      }
    }
    ```

9. If you have any issues running this program, please reach out to the developer or troubleshoot at your own risk.

**To contribute to this project:**

1. Open your preferred browser.
2. Navigate to https://github.com/jkbutserious/HairSalon.Solution.
3. Log into or sign up for your GitHub account.
4. Click the **Fork** button to copy the repository and all source code.
5. From your forked repository, you can download or clone the repository, by clicking the **Code** button.
  * To clone the repository in Visual Studio Code's terminal, use the command

    ```git clone https://github.com/[YOUR-USER-NAME-HERE]/HairSalon.Solution```
  * To clone the repository in GitHub Desktop, click the **Open in Desktop** option
  * To download the repository, click the **Download ZIP** option, save the archive to your computer, and extract it to the folder of your choice
6. Use your preferred code editor to edit the appropriate model and view files. New classes should be added in the Models subdirectory and should use the ``HairSalon.Models`` namespace. **Note**: the HairSalon.csproj file is a C# project file and should not be edited.
7. Save any changes you make in your code editor and use your preferred git solution to commit your changes.
8. Push your changes to your forked repository.

#### Additional Setup/Installation Notes:

* No additional code is necessary to view this project.   

## Known Bugs

_No known issues. Please contact me if you have any problems._


## Support and contact details

To report any issues with this page or to contribute to this project, contact Jeff Kim at kim2jy@hotmail.com.

## Technologies Used

* C#
* .NET Core 2.2
* MySQL Server 8.0.19
* MySQL Workbench 8.0.19
* Entity Framework
* MVC
* Visual Studio Code 
* Git and Git BASH 


### License

Copyright © 2020 Jeffrey Kim

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.