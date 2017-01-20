# InstallationFiles

This is a very simple Winforms-application to manage your (small) Installation-files. For example: if you are developing mobile applications, you want to store these install-files somewhere save. This is one easy solution and saves the files you want to your Dropbox-account.

## How does it work?
The application will use the Root-folder of your Dropbox-account as the Applications-folder. It will read every folder in the Root and will mark it as an Application.
When you double-click an Application, it will again read every folder in the choosen Application-folder. Every folder it finds, will be marked as a Version.
Yet again once a Version is double-clicked, all (Installation-)files in that folder will be shown.

So it's very simple:
- Application 1
    - Version 1.1
        - Install-file 1.1.1
        - Install-file 1.1.2
    - Version 1.2
        - Install-file 1.2.1
    - Version 1.3
        - Install-file 1.3.1

- Application 2
    - Version 2.1
        - Install-file 2.1.1
        - Install-file 2.1.2
        - Install-file 2.1.3
        - Install-file 2.1.4

## Download an installation-file
By double-clicking a file the application will ask if you really want to download this file. Once agreed the file will be downloaded in your Documents-folder.

## New Application/Version/Installation-file
To create a new Application or Version, or to upload a new Installation-file you can use the buttons at the bottom of the different sections. Then a new screen pops open where you can enter a name (for Application and Version) or a File-picker will prompt for a specific file.

## What Dropbox-account
The only thing you need to do, is create a new developers Dropbox-account and create a new Application. In this screen you can generate a new Access Token. You will need to insert this string-value in the settings-file that will open up when you first open this application.
