// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

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