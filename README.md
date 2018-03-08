# FreeDiskSpace
Utility for windows which return free disk space available for the given partition.

#### Command line: 
FreeDiskSpace.exe `partition name` (FreeDiskSpace.exe "C")

# ClearOnBoot
Utility which clears the file for path provided.

#### Command line:
ClearOnBoot.exe `path to clear` (ClearOnBoot.exe "C://data")

# ClearSchTasks
Utility for windows which checks and clears with the provided PID and path.

#### Command line:
ClearSchTasks.exe `'path to folder' 'Task Scheduler Name' 'Process Id'` (ClearSchTasks.exe "C://data" "SymphonyTask-K" 1234)


Note: all the application in the utils requires .NET 3.5 framework (or higher).

#### Dev Env Notes:
preinstall script in package.json will build release version of package.  MSBuild.exe must be in path to build.  MSBuild.exe is available when installing Visual Studio.
