using System;
using System.IO;
using System.Text;
using System.Security.Cryptography;

namespace SkounyCrypt
{
    class AES256
    {
        // Generate 256bit key from a given key
        private static byte[] genAesMaxKey(string password)
        {
            byte[] result = new byte[32];
            byte[] pass = Encoding.UTF8.GetBytes(password);
            int p = 0;
            for (int i = 0; i <= result.Length - 1; i++)
            {
                result[i] = pass[p];
                if (p < pass.Length - 2) p += 2; else p = 0;
            }
            return result;
        }
        // Generate 128bit IV from a given key
        private static byte[] genAesMaxIV(string password)
        {
            byte[] result = new byte[16];
            byte[] pass = Encoding.UTF8.GetBytes(password);
            int p = 1;
            for (int i = 0; i <= result.Length - 1; i++)
            {
                result[i] = pass[p];
                if (p < pass.Length - 2) p += 2; else p = 1;
            }
            return result;
        }
        // Encrypt bytes using AES-256 key
        public static byte[] EncryptBytes(byte[] data, string password)
        {
            byte[] encrypted;
            // Create an AesManaged object with the specified key and IV.
            using (AesManaged aesAlg = new AesManaged())
            {
                aesAlg.Key = genAesMaxKey(password);
                aesAlg.IV = genAesMaxIV(password);
                // Create a decrytor to perform the stream transform.
                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);
                // Create the streams used for encryption.
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (BinaryWriter swEncrypt = new BinaryWriter(csEncrypt))
                        {
                            //Write all data to the stream.
                            swEncrypt.Write(data);
                        }
                        encrypted = msEncrypt.ToArray();
                    }
                }
            }
            // Return the encrypted bytes from the memory stream.
            return encrypted;
        }
        // Decrypt bytes using AES-256 key
        public static byte[] DecryptBytes(byte[] data, string password)
        {
            // Declare the string used to hold the decrypted text.
            byte[] result = { };
            // Create an AesManaged object with the specified key and IV.
            using (AesManaged aesAlg = new AesManaged())
            {
                aesAlg.Key = genAesMaxKey(password);
                aesAlg.IV = genAesMaxIV(password);
                // Create a decrytor to perform the stream transform.
                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);
                // Create the streams used for decryption.
                using (MemoryStream msDecrypt = new MemoryStream(data))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (BinaryReader srDecrypt = new BinaryReader(csDecrypt))
                        {
                            int i = 0;
                            while (true)
                            {
                                byte[] buffer = new byte[1024];
                                i = srDecrypt.Read(buffer, 0, buffer.Length);
                                if (i > 0)
                                {
                                    Array.Resize<byte>(ref result, result.Length + i);
                                    Array.Copy(buffer, 0, result, result.Length - i, i);
                                }
                                else
                                {
                                    break;
                                }
                            }
                        }
                    }
                }
            }
            return result;
        }
    }
}
