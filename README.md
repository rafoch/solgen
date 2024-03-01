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
- [ ] Linting errors or mispells in diagram structure
- [ ] Downloading/Exporting diagram to .NET Solution structure
- [ ] Generating UI Diagrams to visualize diagram state
- [ ] Docker installation

### Nice to have
- [ ] Implement AI to convert text to diagram structure
- [ ] Creating templates for further usage
- [ ] Having own file extension
- [ ] Add Support for other languages than .net e.g. Rust/Go/Java
- [ ] Change from Project/Solution structure to monorepo that contains many subprojects
- [ ] Linking via github and **track** the changes between diagram and repo
- [ ] Add Specifications to project for cloud usage e.g. specify app as app-service/azure-function and create terraform deployment file
- [ ] Add Persistency layer for application

## Docker compose

<!-- TODO -->

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

It all should be generated as zip file 

---
## Documentation

<!-- TODO -->
---
## Inspiration

https://structurizr.com/ <br/>
https://eraser.io/

## Last but not least
Project is created for **100commit** challenge by https://devmentors.io/ -> https://100commitow.pl/