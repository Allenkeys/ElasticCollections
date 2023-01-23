#  ELastic Collections

> An implementation of late binding using the ExpandoObject class. ExpandoObject instances can add and remove members at run-time.


## Built With

- Major languages: C#
- Frameworks: .NET 6.0
- Technologies: Github and Visual Studio

## Getting Started

To get a local copy up and running follow these simple example steps.
 - Clone the repository into your local machine
 - Open the cloned file in Vscode or the solutions file in Visual Studio
 - Navigate to project path and run: `dotnet run`  

## Expected Output
```
  DomainBL dbl = new();
  dbl.Display("Name", "Price", "Quantity");
    //Dell XPS, 1200.99, 20
    //Ergonomic Chair, 1100.99, 25
    //Oakwood Table, 4000.99, 30

  dbl.Display("Name", "Price", "Unknown property");
    //The specified key 'Unknown property' does not exist in the ExpandoObject.    

  dbl.Display();
    //1, Dell XPS, 20, $1200.99, PCs, 35

    //2, Ergonomic Chair, 25, $1100.99, Chairs, 357

    //3, Oakwood Table, 30, $4000.99, Tables, 368
``` 

### Prerequisites
  - Basic understanding of C#
  - A github account and Visual Studio installed in local machine

## Authors

👤 **Joshua Eze**

- GitHub: [@Allenkeys](https://github.com/Allenkeys)
- Twitter: [@jdgraay](https://twitter.com/jdgraay)
- LinkedIn: [Eze Joshua](https://linkedin.com/in/eze-joshua)

## 🤝 Contributing

Contributions, issues, and feature requests are welcome!

Feel free to check the [issues page](https://github.com/Allenkeys/ElasticCollections)

## Show your support

Give a ⭐️ if you like this project!

## Acknowledgments


## 📝 License

This project is [MIT](./LICENSE) licensed.