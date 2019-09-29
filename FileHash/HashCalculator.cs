using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FileHash
{

	class HashCalculator
	{

		string fileName;
		string md5, sha1, sha256, sha384, sha512;

		public HashCalculator(string fileName)
		{
			this.FileName = fileName;
			

		}

		public string MD5 { get => md5; }
		public string SHA1 { get => sha1; }
		public string SHA256 { get => sha256; }
		public string SHA384 { get => sha384; }
		public string SHA512 { get => sha512; }
		public string FileName {
			get { return fileName; }
			set {
				fileName = value;
				md5 = sha1 = sha256 = sha384 = sha512 = String.Empty;
				CalculateHashes();
				}

		}
			   
		void CalculateHashes()
		{
			var fileStream = File.OpenRead(fileName);
			// Be sure it's positioned to the beginning of the stream.
			fileStream.Position = 0;

			byte[] binaryData = new Byte[fileStream.Length];
			long bytesRead = fileStream.Read(binaryData, 0, (int)fileStream.Length);
			if (bytesRead == fileStream.Length)
			{
				Parallel.Invoke(
					() => CalculateMD5Hash(binaryData),
					() => CalculateSHA1Hash(binaryData),
					() => CalculateSHA256Hash(binaryData),
					() => CalculateSHA384Hash(binaryData),
					() => CalculateSHA512Hash(binaryData)
				);
			}
			fileStream.Dispose();

		}

		// Verify a hash against a string.
		private bool VerifyHash(HashAlgorithm hashAlgorithm, string input, string hash)
		{
			// Hash the input.
			var hashOfInput = GetHash(hashAlgorithm, input);

			// Create a StringComparer an compare the hashes.
			StringComparer comparer = StringComparer.OrdinalIgnoreCase;

			return comparer.Compare(hashOfInput, hash) == 0;
		}

		private void CalculateMD5Hash(byte[] input)
		{
			using (var md5 = System.Security.Cryptography.MD5.Create())
			{
				this.md5 = GetHash(md5, input);
			}
		}

		private void CalculateSHA1Hash(byte[] input)
		{
			using (var sha1 = System.Security.Cryptography.SHA1.Create())
			{
				this.sha1 = GetHash(sha1, input);
			}
		}

		private void CalculateSHA256Hash(byte[] input)
		{
			using (var sha256 = System.Security.Cryptography.SHA256.Create())
			{
				this.sha256 = GetHash(sha256, input);
			}
		}

		private void CalculateSHA384Hash(byte[] input)
		{
			using (var sha384 = System.Security.Cryptography.SHA384.Create())
			{
				this.sha384 = GetHash(sha384, input);
			}
		}

		private void CalculateSHA512Hash(byte[] input)
		{
			using (var sha512 = System.Security.Cryptography.SHA512.Create())
			{
				this.sha512=  GetHash(sha512, input);
			}
		}

		private string GetHash(HashAlgorithm hashAlgorithm, string input)
		{
			// Convert the input string to a byte array and compute the hash.
			byte[] bytes = Encoding.UTF8.GetBytes(input);

			return GetHash(hashAlgorithm, bytes);
		}
		private string GetHash(HashAlgorithm hashAlgorithm, byte[] input)
		{
			byte[] hash = hashAlgorithm.ComputeHash(input);
			return HashToString(hash);
		}

		private string HashToString(byte[] hash)
		{
			// Create a new Stringbuilder to collect the bytes
			// and create a string.
			var sBuilder = new StringBuilder();

			// Loop through each byte of the hashed data 
			// and format each one as a hexadecimal string.
			for (int i = 0; i < hash.Length; i++)
			{
				sBuilder.Append(hash[i].ToString("x2"));
			}

			// Return the hexadecimal string.
			return sBuilder.ToString();
		}
	}
}
