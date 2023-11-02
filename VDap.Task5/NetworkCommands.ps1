Test-Connection 127.0.0.1
Test-Connection google.com
Get-NetIPAddress | Out-File -FilePath "IPAddressesInfo.txt"
Resolve-DnsName google.com
Get-NetTCPConnection -State Established | Format-Table