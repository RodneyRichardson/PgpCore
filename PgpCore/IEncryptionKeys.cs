using System.Collections.Generic;
using Org.BouncyCastle.Bcpg.OpenPgp;

namespace PgpCore
{
    /// <summary>
    /// Encryption Keys
    /// 
    /// You can supply any or all of these, however, if PrivateKeys 
    /// are required Secret keys should also be supplied
    /// </summary>
    public interface IEncryptionKeys
    {
        IEnumerable<PgpPublicKey> EncryptKeys { get; }
        IEnumerable<PgpPublicKey> VerificationKeys { get; }
        PgpPrivateKey SigningPrivateKey { get; }
        PgpSecretKey SigningSecretKey { get; }
        PgpPublicKey PublicKey { get; }
        IEnumerable<PgpPublicKey> PublicKeys { get; }
        PgpPrivateKey PrivateKey { get; }
        PgpSecretKey SecretKey { get; }
        PgpSecretKeyRingBundle SecretKeys { get; }

        PgpPrivateKey FindSecretKey(long keyId);
    }
}