using System.CommandLine;
using Medidata.RWS.NET.Standard.Core;
using Medidata.RWS.NET.Standard.Core.Requests;
using Medidata.RWS.NET.Standard.Core.Responses;
using Medidata.RWS.NET.Standard.Exceptions;

namespace RwsSampleApp;

class Program
{
    static async Task<int> Main(string[] args)
    {
        var usernameOption = new Option<string>(
            "--username",
            "Your Medidata username"
        ) { IsRequired = true };
        
        var passwordOption = new Option<string>(
            "--password", 
            "Your Medidata password"
        ) { IsRequired = true };
        
        var projectOption = new Option<string>(
            "--project",
            "Project name (study name)"
        ) { IsRequired = true };
        
        var environmentOption = new Option<string>(
            "--environment",
            "Environment name (e.g., Prod, Test)"
        ) { IsRequired = false };

        var rootCommand = new RootCommand("Sample app to demonstrate Medidata RWS .NET Standard library")
        {
            usernameOption,
            passwordOption,
            projectOption,
            environmentOption
        };

        rootCommand.SetHandler(async (username, password, project, environment) =>
        {
            await RunSampleAsync(username!, password!, project!, environment);
        }, usernameOption, passwordOption, projectOption, environmentOption);

        return await rootCommand.InvokeAsync(args);
    }

    static async Task RunSampleAsync(string username, string password, string project, string? environment = null)
    {
        Console.WriteLine("🚀 Medidata RWS .NET Standard Library Sample App");
        Console.WriteLine("=================================================");
        Console.WriteLine();

        // Validate required parameters
        if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(project))
        {
            Console.WriteLine("❌ Error: Username, password, and project are all required!");
            Console.WriteLine($"   Username: '{username}'");
            Console.WriteLine($"   Password: [{password?.Length ?? 0} characters]");
            Console.WriteLine($"   Project: '{project}'");
            return;
        }

        Console.WriteLine("📋 Connection Details:");
        Console.WriteLine($"   Username: {username}");
        Console.WriteLine($"   Password: [****** ({password.Length} characters)]");
        Console.WriteLine($"   Project: {project}");
        if (!string.IsNullOrEmpty(environment))
            Console.WriteLine($"   Environment: {environment}");
        Console.WriteLine();

        try
        {
            // Create connection to Medidata RWS
            Console.WriteLine("📡 Connecting to Medidata RWS...");
            var connection = new RwsConnection("innovate", username, password);
            
            Console.WriteLine($"✅ Connected to: {connection.SubDomain}.mdsol.com/{connection.VirtualDirectory}");
            Console.WriteLine();

            // Test 1: Get Study Subjects
            Console.WriteLine("📋 Retrieving study subjects...");
            Console.WriteLine($"   Project: {project}");
            if (!string.IsNullOrEmpty(environment))
                Console.WriteLine($"   Environment: {environment}");
            Console.WriteLine();

            var subjectsRequest = new StudySubjectsRequest(project, environment ?? "", status: true, links: true);
            var subjectsResponse = await connection.SendRequestAsync(subjectsRequest);
            
            Console.WriteLine($"⏱️  Request completed in: {connection.RequestTime.TotalMilliseconds:F2}ms");
            Console.WriteLine($"📊 Response Status: {connection.LastResult?.StatusCode}");
            Console.WriteLine();

            // Get response content as string
            var responseContent = await connection.LastResult.Content.ReadAsStringAsync();
            Console.WriteLine("📄 Response Preview (first 500 characters):");
            Console.WriteLine("─".PadRight(50, '─'));
            Console.WriteLine(responseContent.Length > 500 ? responseContent.Substring(0, 500) + "..." : responseContent);
            Console.WriteLine("─".PadRight(50, '─'));
            Console.WriteLine();
            Console.WriteLine($"📏 Total response length: {responseContent.Length} characters");

            // Test 2: Get Study Versions (simpler request)
            Console.WriteLine();
            Console.WriteLine("📚 Retrieving study versions...");
            
            var versionsRequest = new StudyVersionsRequest(project);
            var versionsResponse = await connection.SendRequestAsync(versionsRequest);
            
            Console.WriteLine($"⏱️  Request completed in: {connection.RequestTime.TotalMilliseconds:F2}ms");
            Console.WriteLine($"📊 Response Status: {connection.LastResult?.StatusCode}");
            
            // Get response content as string
            var versionsContent = await connection.LastResult.Content.ReadAsStringAsync();
            Console.WriteLine();
            Console.WriteLine("📄 Study Versions Response:");
            Console.WriteLine("─".PadRight(50, '─'));
            Console.WriteLine(versionsContent.Length > 300 ? versionsContent.Substring(0, 300) + "..." : versionsContent);
            Console.WriteLine("─".PadRight(50, '─'));

            Console.WriteLine();
            Console.WriteLine("✅ Sample completed successfully!");
        }
        catch (RwsAuthorizationException ex)
        {
            Console.WriteLine();
            Console.WriteLine("❌ Authorization Error:");
            Console.WriteLine($"   {ex.Message}");
            Console.WriteLine("   Please check your username and password.");
        }
        catch (RwsException ex)
        {
            Console.WriteLine();
            Console.WriteLine("❌ RWS Error:");
            Console.WriteLine($"   {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine();
            Console.WriteLine("❌ Unexpected Error:");
            Console.WriteLine($"   {ex.Message}");
            Console.WriteLine($"   Type: {ex.GetType().Name}");
        }
    }
} 