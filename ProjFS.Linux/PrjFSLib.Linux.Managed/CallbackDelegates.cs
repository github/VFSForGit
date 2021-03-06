using System.Runtime.InteropServices;

namespace PrjFSLib.Linux
{
    // Callbacks
    public delegate Result EnumerateDirectoryCallback(
        ulong commandId,
        string relativePath,
        int triggeringProcessId,
        string triggeringProcessName);

    public delegate Result GetFileStreamCallback(
        ulong commandId,
        string relativePath,
        byte[] providerId,
        byte[] contentId,
        int triggeringProcessId,
        string triggeringProcessName,
        int fd);

    public delegate void LogErrorCallback(
        string errorMessage);

    public delegate void LogWarningCallback(
        string warningMessage);

    public delegate void LogInfoCallback(
        string infoMessage);

    // Pre-event notifications
    public delegate Result NotifyPreDeleteEvent(
        string relativePath,
        bool isDirectory);

    public delegate Result NotifyPreRenameEvent(
        string relativePath,
        string relativeDestinationPath,
        bool isDirectory);

    public delegate Result NotifyFilePreConvertToFullEvent(
        string relativePath);

    // Informational post-event notifications
    public delegate void NotifyNewFileCreatedEvent(
        string relativePath,
        bool isDirectory);

    public delegate void NotifyFileDeletedEvent(
        string relativePath,
        bool isDirectory);

    public delegate void NotifyFileRenamedEvent(
        string relativePath,
        string relativeDestinationPath,
        bool isDirectory);

    public delegate void NotifyHardLinkCreatedEvent(
        string relativeExistingFilePath,
        string relativeNewLinkPath);

    public delegate void NotifyFileModified(
        string relativePath);
}
