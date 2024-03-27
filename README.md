# SOLGEN
<!-- LINKS -->
![plot](./logo_192.png)
---
Are you a Tech Lead or Software Architect in small or medium company? 

Have you ever struggled to create new project for client and creating project structure from scratch, repeating the same actions every time ?

If yes then, here's come **SOLGEN** <br/>
Open source tool for creating, building and store project structure via diagrams as code

---

## Features

### Must Have

- [ ] Writing project structure by diagram as code approach
- [ ] Downloading/Exporting diagram to .NET Solution structure
- [ ] Generating UI Diagrams to visualize diagram state
- [x] Docker installation
- [] Site with code editor
- [] Generic code for further languages implementation

### Nice to have
- [ ] Linting errors or mispells in diagram structure
- [ ] Implement AI to convert text to diagram structure
- [ ] Creating templates for further usage
- [ ] Having own file extension
- [ ] Add Support for other languages than .net e.g. Rust/Go/Java
- [ ] Change from Project/Solution structure to monorepo that contains many subprojects
- [ ] Linking via github and **track** the changes between diagram and repo
- [ ] Add Specifications to project for cloud usage e.g. specify app as app-service/azure-function and create terraform deployment file
- [ ] Add Persistency layer for application
- [ ] docker hub publish

## Docker compose

1. Download Repo
2. Execute command `docker-compose up -d`
3. Open browser and go to: http://localhost:3000/

[//]: # (4. Options )


### Docker config 
There is no config yet

#### Port
If any of the port of an application is already used, you can easly change it in `docker-compose` file

---
## Examples

```
sln SolutionName {
    folder DummyFolder {
        csharp ProjectName {

        }

        csharp SecondProject {

         }
    }
    csharp ExampleProject {

    }
}
```

The above structure will provide the full .NET solution with corresponding structure as shown below

expected response should be: 

```
|- SoltuionName.sln
|--- Dummy folder 
|----- ProjectName 
|-------- ProjectName.csproj
|----- SecondProject 
|-------- SecondProject.csproj
|--- ExampleProject
|----- ExampleProject.csproj

```

There may be a possibility for exporting such a structure as a zip file. 

---
## Documentation

The documentation section that provides information about core functionalities of the application

#### Tokenizer

Tokenizer is a mechanism that gets your input and then translate it to a list of words/symbols are contained in the input. 

**Important** : The tokens that are returned are the only one that are specified in code, ie. you need to define a token type to get this in return 
<!-- TODO -->
#### Parser
<!-- TODO -->
Translates the provided **Tokens** into proper language code structure according to language choose. 
In first implementation where will be only C# Code supported

#### Linter 

<!-- TODO -->

### Core

Provides a whole services to do the job

#### Modules
Modules are core of the system, they provides implementation for various programming languages, each module contains proper mechanisms to parse input and deliver proper output


##### C# module (CSharp Module)
Module that provides needed members of parsing and preparing solution to be generated and exported as zip solution

[//]: # (Docker supp)
---
## Inspiration

https://structurizr.com/ <br/>
https://eraser.io/

## Last but not least
Project is created for **100commit** challenge by https://devmentors.io/ -> https://100commitow.pl/