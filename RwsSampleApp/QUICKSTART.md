# Quick Start Guide

Get up and running with the Medidata RWS .NET Standard library in under 5 minutes.

## Prerequisites

- .NET 8.0 SDK
- Medidata credentials
- Access to a study

## Running the Sample

1. **Navigate to the sample directory:**
   ```bash
   cd RwsSampleApp
   ```

2. **Run the sample:**
   ```bash
   ./run-sample.sh your_username your_password "Study Name"
   ```

   Or with an environment:
   ```bash
   ./run-sample.sh your_username your_password "Study Name" "Prod"
   ```

## What You'll See

The application will:
- Connect to Medidata RWS
- Retrieve study subjects
- Get study version metadata  
- Display response timing and content

## Example Output

```
🚀 Medidata RWS .NET Standard Library Sample App
=================================================

📋 Connection Details:
   Username: your_username
   Password: [****** (12 characters)]
   Project: Study Name

📡 Connecting to Medidata RWS...
✅ Connected to: [subdomain].mdsol.com/RaveWebServices

📋 Retrieving study subjects...
   Project: Study Name

⏱️  Request completed in: 1234ms
📊 Response Status: OK

✅ Sample completed successfully!
```

## Troubleshooting

- **Authentication Error**: Check username/password
- **Study Not Found**: Verify study name and access permissions
- **Server Error**: Contact your Medidata administrator

## Next Steps

- Review the code in `Program.cs`
- Check out the full documentation in `README.md`
- Explore other RWS library features 