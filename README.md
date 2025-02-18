# About The Project
This is a simple implementation of the console-based Tic-Tac-Toe game. It allows two players to take turns in a 3x3 grid. The game ends when one player achieves three marks in a row, column, or diagonal, or when all spaces are filled (a draw).

# Installation Guide
## 1. Install .NET SDK on Ubuntu

- Before running a .NET Core application, install the .NET SDK to compile and execute .NET applications.
- Update package list and install required dependencies
```sh
sudo apt update && sudo apt install -y wget apt-transport-https
```
- Download and install the Microsoft package signing key
```sh
wget https://packages.microsoft.com/config/ubuntu/$(lsb_release -rs)/packages-microsoft-prod.deb -O packages-microsoft-prod.deb
sudo dpkg -i packages-microsoft-prod.deb
sudo apt update
```
- Install .NET SDK
```sh
sudo apt install -y dotnet-sdk-9.0  # Change version if needed
```

## 2. Verify Installation
```sh
dotnet --version
```

This should return the installed .NET SDK version.

## 3. Clone a .NET Core Console Application from GitHub
```sh
git clone https://github.com/yadanarphyo/tic-tac-toe-game.git
cd <repository_directory>
```
Replace <repository_directory> with the name of the cloned repository folder.

## 4. Restore Dependencies
```sh
dotnet restore
```
This installs any required dependencies specified in the project.

## 5. Compile the Application
```sh
dotnet build
```
This compiles the project and generates an executable.

## 6. Run the Application
```sh
dotnet run
```
This executes the console application.
