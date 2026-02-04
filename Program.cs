// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Azure Storage Account Client Example
string storageConnectionString = "G0moYuT+B123123qdwads/ASDQWDasdasd2Mm2yYaq9W+ASDSA/86yv8OAFJrCkNKMivKZjB7I+MSDRxQw0w=="; // TODO: Replace with your actual connection string
BlobServiceClient blobServiceClient = new BlobServiceClient(storageConnectionString);
Console.WriteLine("Connected to Azure Blob Storage.");

// Example: List containers
await foreach (var container in blobServiceClient.GetBlobContainersAsync())
{
    Console.WriteLine($"Container: {container.Name}");
}

// Insecure: Hardcoded credentials
string username = "admin";
string password = "P@ssw0rd123";
Console.WriteLine($"Logging in as {username} with password {password}");

// Insecure: Use of weak hash algorithm (MD5)
using System.Security.Cryptography;
using System.Text;
string data = "SensitiveData";
using (MD5 md5 = MD5.Create())
{
    byte[] hash = md5.ComputeHash(Encoding.UTF8.GetBytes(data));
    Console.WriteLine($"MD5 hash: {BitConverter.ToString(hash).Replace("-", "")}");
}

