$Folder = "$pwd\FileResultRenamed"
$File = "$pwd\FileTaskResult.txt"
Write-Host "WriteHost command is executed"
Write-Host @Folder
Write-Host "TestPath command is executed"
if(Test-Path -Path $Folder)
{
	Write-Host "RemoveItem command is executed"
	Remove-Item $Folder
}
Write-Host "StartSleep command is executed"
Start-Sleep -Seconds 3
Write-Host "TestPath command is executed"
if(Test-Path -Path $File)
{
	Write-Host "RemoveItem command is executed"
	Remove-Item $File
}
Write-Host "StartSleep command is executed"
Start-Sleep -Seconds 3
Write-Host "NewItem is executed to create FileTaskResult folder"
New-Item "$pwd\FileTaskResult" -ItemType Directory
$LastDirectory = "$pwd"
Write-Host "Set-location is executed toChange directory to FileResultRenamed"
Set-Location "FileTaskResult"
Write-Host "NewItem is executed to create hello.txt"
New-Item "hello.txt" -ItemType File
Write-Host "New Item is executed to create FileTaskResult.txt"
New-Item "FileTaskResult.txt" -ItemType File
$CurrentDirectory = "$pwd"
Write-Host "OutFile command is executed to write current path to FileTaskResult.txt"
$CurrentDirectory | Out-File -FilePath .\FileTaskResult.txt
Write-Host "OutFile command is executed to write a custom sentence to FileTaskResult.txt"
"This is a test" | Out-File -FilePath .\FileTaskResult.txt -Append
Write-Host "dir command is executed"
dir
Write-Host "Copy Item is executed to copy FileTaskResult.txt to previous directory"
Copy-Item "$CurrentDirectory\FileTaskResult.txt" -Destination $LastDirectory
Write-Host "Rename Item is executed to change the name of hello.txt to Renamed.txt"
Rename-Item "$CurrentDirectory\hello.txt" -NewName "Renamed.txt"
Write-Host "dir command is executed"
dir
Write-Host "Move Item is executed to move Renamed.txt to the previous directory"
if(Test-Path -Path "$CurrentDirectory\Renamed.txt")
{
Move-Item -Path "$CurrentDirectory\Renamed.txt" -Destination $LastDirectory
}
else
{
Move-Item -Path "$CurrentDirectory\Renamed.txt" -Destination $LastDirectory -Force
}
Write-Host "cd.. is executed to go to the previous directory"
cd..
Write-Host "Rename Item is executed to rename FileTaskResult folder"
Rename-Item "$CurrentDirectory" -NewName "$LastDirectory\FileResultRenamed"