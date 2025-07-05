using System;

namespace SevenZipExtractor
{
    internal class ArchiveOpenCallback : IArchiveOpenCallback, ICryptoGetTextPassword
    {
        public string Password { get; }

        public ArchiveOpenCallback(string password = null)
        {
            Password = password ?? "";
        }

        public void SetTotal(IntPtr files, IntPtr bytes)
        {
        }

        public void SetCompleted(IntPtr files, IntPtr bytes)
        {
        }

        public int CryptoGetTextPassword(out string password)
        {
            password = this.Password;
            return 0;
        }
    }
}