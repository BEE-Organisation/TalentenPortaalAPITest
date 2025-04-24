using System;

namespace BlobStorage
{
    public class AzureBlobSettings
    {
        public AzureBlobSettings(string storageAccount, 
                                       string storageKey,
                                       string containerName)
        {
            if (string.IsNullOrEmpty(storageAccount))
                throw new ArgumentNullException(nameof(storageAccount));

            if (string.IsNullOrEmpty(storageKey))
                throw new ArgumentNullException(nameof(storageKey));

            if (string.IsNullOrEmpty(containerName))
                throw new ArgumentNullException(nameof(containerName));

            StorageAccount = storageAccount;
            StorageKey = storageKey;
            ContainerName = containerName;
        }

        public string StorageAccount { get; }
        public string StorageKey { get; }
        public string ContainerName { get; }
    }
}
