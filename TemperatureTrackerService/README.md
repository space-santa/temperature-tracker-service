Create a file `SyncTime.ps1` on the Pi containing the PowerShell script to run `w32tm /resync /force`.
Then run this script to create a scheduled task that runs it on start up.

```
schtasks /Create /SC ONSTART /TN TimeSync /TR c:\SyncTime.ps1
```

That will force it to sync the time when it starts up.  It seems this registry key below also needs to be set to your NTP server that it's going to sync to.  Mine is set to our domain controller and it's working fine.

```
set-itemproperty -Path HKLM:\SYSTEM\CurrentControlSet\Services\W32Time\Parameters -Name NtpServer -Value 127.0.0.1,0x9
```