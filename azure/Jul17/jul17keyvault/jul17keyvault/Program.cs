﻿using System;
using System.Threading.Tasks;
using Azure.Identity;
using Azure.Security.KeyVault.Secrets;
namespace jul17keyvault
{
   

        class Program
        {
            static async Task Main(string[] args)
            {
                const string secretName = "mv-secret-1";
                var keyVaultName = "mv-strings";
                var kvUri = $"https://{keyVaultName}.vault.azure.net";

                var client = new SecretClient(new Uri(kvUri), new DefaultAzureCredential());

            var secretValue = "This is my second secret connection string";
    
            Console.Write($"Creating a secret in {keyVaultName} called '{secretName}' with the value '{secretValue}' ...");
                await client.SetSecretAsync(secretName, secretValue);
                Console.WriteLine(" done.");

                Console.WriteLine("Forgetting your secret.");
                secretValue = string.Empty;
                Console.WriteLine($"Your secret is '{secretValue}'.");

                Console.WriteLine($"Retrieving your secret from {keyVaultName}.");
                var secret = await client.GetSecretAsync(secretName);
                Console.WriteLine($"Your secret is '{secret.Value.Value}'.");

                //Console.Write($"Deleting your secret from {keyVaultName} ...");
                //DeleteSecretOperation operation = await client.StartDeleteSecretAsync(secretName);
                //// You only need to wait for completion if you want to purge or recover the secret.
                //await operation.WaitForCompletionAsync();
                //Console.WriteLine(" done.");

                //Console.Write($"Purging your secret from {keyVaultName} ...");
                //await client.PurgeDeletedSecretAsync(secretName);
                //Console.WriteLine(" done.");
            }
        }
    }


