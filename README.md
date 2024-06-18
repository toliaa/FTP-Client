# FTP-Client
# FTP Client Application

This FTP client application allows you to connect to an FTP server and perform various operations such as uploading files, downloading files, creating directories, deleting files and directories, renaming files, and managing server settings.

## Features

- **Connect to FTP Server:** Enter host address, username, and password to establish a connection.
- **Upload Files:** Select a file from your local machine and upload it to the remote FTP server.
- **Download Files:** Download files from the FTP server to your local machine.
- **Manage Directories:** Create, delete, and rename directories on the FTP server.
- **View File Details:** Get file size and modification time.
- **Append to Files:** Append data to an existing file on the FTP server.

## Getting Started

To use this application, follow these steps:

1. **Clone the repository:**
   git clone https://github.com/toliaa/FTP-Client.git

2. **Open the solution in Visual Studio:**
- Navigate to the `FTP` folder and open `FTP.sln` in Visual Studio.

3. **Build and run the application:**
- Build the solution (`Ctrl+Shift+B`) and run the application (`F5`).

4. **Configure FTP Server Settings:**
- Open the settings form (`Settings -> Server Settings`) to configure FTP server connection details. These settings will be saved in `settings.txt`.

5. **Connect to FTP Server:**
- Enter the FTP server details (host, username, password) in the settings form and click `Save`.

6. **Perform Operations:**
- Use the main form to upload, download, manage directories, and perform other FTP operations.


## Technologies Used

- C# for the backend logic
- WinForms for the user interface
- FluentFTP library for FTP operations

## License

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details.

   
