# Electricity Tariff Comparison 
 A web application that compares electricity tariffs and calculates annual costs based on consumption.

## Features
- Compare different electricity tariffs
- Calculate annual costs based on consumption (kWh/year)
- Responsive web interface
- Real-time cost calculation
- Detailed breakdown of base and consumption costs
  
## Prerequisites
- .NET SDK 7.0 or later
- A modern web browser

## Installation

### Using the Install Script (Linux)

1. Clone the repository:
bash
git clone https://github.com/sonalbali/Electricity-Tariff-Comparison.git

cd Electricity-Tariff-Comparison
2. Make the install script executable:
bash
chmod +x install.sh


### Manual Installation (Windows)

1. Clone the repository:
 bash
git clone https://github.com/sonalbali/Electricity-Tariff-Comparison.git
cd Electricity-Tariff-Comparison
2. Restore dependencies:
   bash
dotnet restore
3. Build and run the application:
   bash
dotnet build
dotnet run --project Tariff_Comparison

## Usage
1. Open your web browser and navigate to `http://localhost:5259/index.html` 
2. Enter your annual electricity consumption in kWh
3. Click "Compare Tariffs" to see the comparison results
4. View the detailed breakdown of costs for each tariff

## Project Structure

- `Controllers/` - API endpoints
- `Models/` - Data models
- `Services/` - Business logic and calculations
- `Data/` - Data providers
- `wwwroot/` - Static files and frontend

## API Endpoints
- GET `/api/tariffs/compare?consumption={value}` - Get tariff comparisons for given consumption


