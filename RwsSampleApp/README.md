# RWS Sample Console Application

This is a simple console application that demonstrates how to use the **Medidata.RWS.NET.Standard** library to connect to Medidata RWS and retrieve study data.

## What it does

The sample app performs two basic operations:
1. **Retrieves study subjects** - Gets a list of all subjects in a study
2. **Retrieves study versions** - Gets version information for a study

## Prerequisites

- .NET 8.0 SDK or later
- Valid Medidata credentials
- Access to at least one study on the platform

## How to build and run

### Option 1: Using the provided shell script (Recommended)

1. **Make the script executable (first time only):**
   ```bash
   cd RwsSampleApp
   chmod +x run-sample.sh
   ```

2. **Run with the script:**
   ```bash
   ./run-sample.sh username password "Study Name"
   
   # With environment specified:
   ./run-sample.sh username password "Study Name" "Prod"
   ```

### Option 2: Using dotnet directly

1. **Build the application:**
   ```bash
   cd RwsSampleApp
   dotnet build
   ```

2. **Run the application:**
   ```bash
   dotnet run -- --username username --password password --project "Study Name"
   ```

   With optional environment:
   ```bash
   dotnet run -- --username username --password password --project "Study Name" --environment Prod
   ```

## Command Line Parameters

- `--username` (required): Medidata username
- `--password` (required): Medidata password  
- `--project` (required): Study/project name
- `--environment` (optional): Environment name (e.g., "Prod", "Test")

## Example Usage

### Using the shell script:
```bash
# Basic usage
./run-sample.sh username password "Study Name"

# With environment specified
./run-sample.sh username password "Study Name" "Prod"
```

### Using dotnet directly:
```bash
# Basic usage
dotnet run -- --username username --password password --project "Study Name"

# With environment specified
dotnet run -- --username username --password password --project "Study Name" --environment "Prod"
```

## Sample Output

When successful, you'll see output like:
```
🚀 Medidata RWS .NET Standard Library Sample App
=================================================

📋 Connection Details:
   Username: username
   Password: [****** (8 characters)]
   Project: Study Name

📡 Connecting to innovate.mdsol.com...
✅ Connected to: innovate.mdsol.com/RaveWebServices

📋 Retrieving study subjects...
   Project: Study Name

⏱️  Request completed in: 1234.56ms
📊 Response Status: OK

📄 Response Preview (first 500 characters):
──────────────────────────────────────────────────
<?xml version="1.0" encoding="utf-8"?>
<ODM xmlns="http://www.cdisc.org/ns/odm/v1.3"...
──────────────────────────────────────────────────

📏 Total response length: 12345 characters

📚 Retrieving study versions...
⏱️  Request completed in: 567.89ms
📊 Response Status: OK

✅ Sample completed successfully!
```

## Error Handling

The application includes comprehensive error handling for:
- **Authorization errors** - Invalid credentials or insufficient permissions
- **RWS-specific errors** - API errors from the Medidata platform
- **General exceptions** - Network issues, malformed responses, etc.

## Security Note

⚠️ **Important**: Never hardcode credentials in source code. This sample accepts credentials via command line for demonstration purposes only. In production applications, use secure credential storage methods like:
- Environment variables
- Azure Key Vault
- AWS Secrets Manager
- Secure configuration files with restricted access

## Next Steps

This sample demonstrates the basics. The RWS library supports many more operations:
- Posting clinical data
- Retrieving audit records
- Getting metadata definitions
- Working with datasets
- And much more!

Check the main library documentation for additional capabilities. 