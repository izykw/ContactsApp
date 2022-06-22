#define Name "ContactsApp"
#define Version "0.0.1"
#define Publisher  "Pakhomov Maxim"
#define URL "https://github.com/izykw"
#define ExeName "ContactsApp"

[Setup]
AppId = {{AC2F2855-FF95-4C0D-81EB-46E4052298FE}

AppName={#Name}
AppVersion={#Version}
AppPublisher={#Publisher}
AppPublisherURL={#URL}
AppSupportURL={#URL}
AppUpdatesURL={#URL}

DefaultDirName = {pf}\{#Name}
DefaultGroupName = {#Name}

OutputDir=..\setup
OutputBaseFileName=setup

SetupIconFile=ContactsApp.ico

Compression=lzma
SolidCompression=yes

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"
Name: "russian"; MessagesFile: "compiler:Languages\Russian.isl"

[Tasks]
; �������� ������ �� ������� �����
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]

; ����������� ����
Source: "..\Release\ContactsApp.View.exe"; DestDir: "{app}"; Flags: ignoreversion

; ������������� �������
Source: "..\Release\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs

[Icons]

Name: "{group}\{#Name}"; Filename: "{app}\{#ExeName}"
Name: "{commondesktop}\{#Name}"; Filename: "{app}\{#ExeName}"; Tasks: desktopicon