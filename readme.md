# Service Collection Accessor
this package help you to work around the issue with DI and Static classes

## Usage

1-Add package to your project

2- inject it : services.AddServiceCollectionAccessor();

3- use it anywhere you need like this: 
```
private static LogData GetLogData() => ServiceCollectionAccessor.Services.BuildServiceProvider().GetRequiredService<LogData>();
```
or any other way you need it

4- smile :)