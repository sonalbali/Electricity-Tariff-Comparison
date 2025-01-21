#!/bin/bash

# Check if .NET SDK is installed
if ! command -v dotnet &> /dev/null
then
    echo ".NET SDK not found. Installing..."
    wget https://packages.microsoft.com/config/ubuntu/20.04/packages-microsoft-prod.deb -O packages-microsoft-prod.deb
    sudo dpkg -i packages-microsoft-prod.deb
    sudo apt-get update
    sudo apt-get install -y apt-transport-https
    sudo apt-get install -y dotnet-sdk-7.0
else
    echo ".NET SDK is already installed"
fi

# Build and run the application
dotnet restore
dotnet build
dotnet run --project Tariff_Comparison