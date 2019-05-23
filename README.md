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

## Contributing

1. Fork it (<https://github.com/symphonyoss/electron-utils/fork>)
2. Create your feature branch (`git checkout -b feature/fooBar`)
3. Read our [contribution guidelines](.github/CONTRIBUTING.md) and [Community Code of Conduct](https://www.finos.org/code-of-conduct)
4. Commit your changes (`git commit -am 'Add some fooBar'`)
5. Push to the branch (`git push origin feature/fooBar`)
6. Create a new Pull Request

## License
The code in this repository is distributed under the Apache License, Version 2.0.

Copyright 2018-2019 Symphony Communication Services, LLC
