# Spotify Songs Backup

This application is made to backup local music to a spotify playlist

#### Tech Stack:
- C# asp.net core
- Vue
- Azure Blob Storage
- Azure Table Storage
- Docker

#### Setup:

- For setting up Azurite for local development, execute the following commands and modify where necessary:
-  `docker pull mcr.microsoft.com/azure-storage/azurite`
-  `docker run -d --name azurite -p 10000:10000 -p 10001:10001 -p 10002:10002 mcr.microsoft.com/azure-storage/azurite`
