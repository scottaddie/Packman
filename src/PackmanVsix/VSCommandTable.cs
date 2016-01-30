namespace PackmanVsix
{
    using System;
    
    /// <summary>
    /// Helper class that exposes all GUIDs used across VS Package.
    /// </summary>
    internal sealed partial class PackageGuids
    {
        public const string guidLibrarianPackageString = "ce753d0f-f511-4b2b-93de-5cc50145dca6";
        public const string guidLibrarianCmdSetString = "9056cd3b-314d-462b-888e-95801ee4b05b";
        public const string guidVenusCmdIdString = "c7547851-4e3a-4e5b-9173-fa6e9c8bd82c";
        public static Guid guidLibrarianPackage = new Guid(guidLibrarianPackageString);
        public static Guid guidLibrarianCmdSet = new Guid(guidLibrarianCmdSetString);
        public static Guid guidVenusCmdId = new Guid(guidVenusCmdIdString);
    }
    /// <summary>
    /// Helper class that encapsulates all CommandIDs uses across VS Package.
    /// </summary>
    internal sealed partial class PackageIds
    {
        public const int ContextMenuGroup = 0x1020;
        public const int InstallLibrary = 0x0100;
        public const int RestoreAll = 0x0200;
        public const int IDG_VENUS_CTX_REFERENCE = 0x001B;
        public const int IDG_CTX_REFERENCE = 0x0102;
    }
}
