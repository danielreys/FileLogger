# FileLogger

Implement a log into your c# aplication.

## Getting Started

These instructions will help you set the framework in your project and also for testing the logs.

### Prerequisites

Create your project and download the framework.

### Adding the framework

First add the framework 

```
Visual studio : Add -> existing project
```

And add the reference to your Project

```
Visual Studio : Right click your project references and click "add reference", then select the name reference.  
```

## Methods
Warning: The FileLogger class is declarated as static.

### Start 

You can add this code line on your form method once it is inicializated.

```
 FileLogger.start();
```

### Close

You can add this line inside your FormClosed method.

```
FileLogger.close();
```
### Set name (Optional)

You can set the name of the form to write it on the logs file.

```
FileLogger.setName("FormName");
```
## Test an Exception
You can add this line to intentially throw a *logException* to check the logs handling an exception.

```
FileLogger.test();
```
## Logs.txt location
The logs.txt file will be created inside our project .exe path.
Check inside the following folders on your project bin -> debug 

## Built With

## Authors

* **Daniel Reyes** 
