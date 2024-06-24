#define MyAppName "SkounyCrypt"
#define MyAppExeName "SkounyCrypt.exe"
#define MyAppVersion GetFileVersion(".\bin\Release\SkounyCrypt.exe")
#define MyAppPublisher "Skounakis Yiannis"
#define MyAppURL "http://skouny.net/"

[Setup]
AppId={{27306331-e859-436b-8fda-98f4427befcc}}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
AppVerName={#MyAppName} {#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURL}
AppUpdatesURL={#MyAppURL}
DefaultDirName={pf}\{#MyAppName}
DefaultGroupName={#MyAppName}
OutputDir=.
OutputBaseFilename=SkounyCrypt_Setup_{#MyAppVersion}
Compression=lzma2/ultra64
SolidCompression=yes
PrivilegesRequired=admin
ChangesAssociations=yes
LicenseFile=GPL_v3_0.txt

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"

[Files]
Source: "Setup\dotNetFx40_Client_setup.exe"; DestDir: "{app}"; DestName: "dotNetFx40_Client_setup.exe"; Flags: deleteafterinstall
Source: ".\bin\Release\{#MyAppExeName}"; DestDir: "{app}"

[Icons]
Name: "{group}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{commondesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon

[Run]
Filename: "{app}\dotNetFx40_Client_setup.exe"; Parameters: "/passive /promptrestart"; Check: DotNet4ClientNotInstalled     
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent

[Registry]
Root: HKCR; Subkey: ".egz"; ValueType: string; ValueName: ""; ValueData: "{#MyAppName}"; Flags: uninsdeletekey
Root: HKCR; Subkey: "{#MyAppName}"; ValueType: string; ValueName: ""; ValueData: "{#MyAppName} File"; Flags: uninsdeletekey
Root: HKCR; Subkey: "{#MyAppName}\DefaultIcon"; ValueType: string; ValueName: ""; ValueData: "{app}\{#MyAppExeName},0"
Root: HKCR; Subkey: "{#MyAppName}\shell\open\command"; ValueType: string; ValueName: ""; ValueData: """{app}\{#MyAppExeName}"" ""%1"""
Root: HKCR; Subkey: "*\shell\Open with {#MyAppName}"; ValueType: string; ValueName: ""; ValueData: ""; Flags: uninsdeletekey
Root: HKCR; Subkey: "*\shell\Open with {#MyAppName}\command"; ValueType: string; ValueName: ""; ValueData: """{app}\{#MyAppExeName}"" ""%1"""; Flags: uninsdeletekey

[Code]
function DotNet4ClientNotInstalled(): Boolean;
var
  RegQuery: boolean;
  ResultDWord: Cardinal;
begin
  RegQuery := RegQueryDWordValue(HKEY_LOCAL_MACHINE, 'SOFTWARE\Microsoft\NET Framework Setup\NDP\v4\Client', 'Install', ResultDWord);
  if ResultDWord = 1 then begin
    Result := False;
  end else begin
    Result := True;
  end;
end;
