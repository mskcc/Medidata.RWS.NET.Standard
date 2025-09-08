#!/bin/bash

# RWS Sample Application Runner
# This script helps you run the sample application with proper parameters

echo "🚀 Medidata RWS .NET Standard Sample Application"
echo "================================================"
echo ""

# Check if minimum parameters are provided
if [ $# -lt 3 ]; then
    echo "Usage: $0 <username> <password> <project> [environment]"
    echo ""
    echo "Examples:"
    echo "  $0 username password \"Study Name\""
    echo "  $0 username password \"Study Name\" \"Prod\""
    echo ""
    echo "Note: Use quotes around parameters that contain spaces or special characters"
    echo ""
    echo "Or run with --help to see all options:"
    echo "  dotnet run -- --help"
    exit 1
fi

USERNAME="$1"
PASSWORD="$2"
PROJECT="$3"
ENVIRONMENT="$4"

# Debug output
echo "📋 Parameters received:"
echo "   Username: $USERNAME"
echo "   Password: [${#PASSWORD} characters]"
echo "   Project: '$PROJECT'"
if [ -n "$ENVIRONMENT" ]; then
    echo "   Environment: '$ENVIRONMENT'"
else
    echo "   Environment: (not specified)"
fi
echo ""

echo "🔧 Building application..."
dotnet build --verbosity quiet

if [ $? -ne 0 ]; then
    echo "❌ Build failed. Please fix compilation errors first."
    exit 1
fi

echo "✅ Build successful!"
echo ""

# Validate required parameters
if [ -z "$USERNAME" ] || [ -z "$PASSWORD" ] || [ -z "$PROJECT" ]; then
    echo "❌ Error: Username, password, and project are all required!"
    echo "   Username: '$USERNAME'"
    echo "   Password: [${#PASSWORD} characters]"
    echo "   Project: '$PROJECT'"
    exit 1
fi

echo "🚀 Executing application..."
echo ""

# Execute directly with proper parameter passing
if [ -n "$ENVIRONMENT" ]; then
    dotnet run -- --username "$USERNAME" --password "$PASSWORD" --project "$PROJECT" --environment "$ENVIRONMENT"
else
    dotnet run -- --username "$USERNAME" --password "$PASSWORD" --project "$PROJECT"
fi 