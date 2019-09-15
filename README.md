# LyndaDecryptorUI
![LyndaDecryptorUI](/../master/LyndaDecryptorUI/Resources/LyndaDecryptorUI_running.png?raw=true "LyndaDecryptorUI")  
  
Lynda Desktop Video Decryptor with Graphical User Interface. This application is a fork of ([Lynda-Decryptor](https://github.com/h4ck-rOOt/Lynda-Decryptor))

## How to use
- Run the LyndaDecryptorUI.exe
- Choose **File Mode** for single file or **Folder Mode** for all files in folder
- Check **Use Database** option to pick file names automatically from SQLite Database
- Check **Subtitle** option to generate subtitles for videos
- Browse Input File/Folder or choose from List
- Browse Output folder or choose from List
- Browse Database File if Use Database option has been checked
- Finally hit **Start Decryption** to decrypt the video(s)
- Optionally hit **Favorites** buttons to Add/Remove your favorite locations

## Download
Download the [Portable Version](https://github.com/softsingh/LyndaDecryptorUI/releases/download/portable/LyndaDecryptorUI.zip) or [Setup File](https://github.com/softsingh/LyndaDecryptorUI/releases/download/installer/LyndaDecryptorUI_Setup.zip)

## How to Compile
- Open **LyndaDecryptorUI.sln** in Visual Studio
- Install **System.Data.SQLite** NuGet package (Tools -> NuGet Package Manager -> Manage Nuget Packages for Solution)
