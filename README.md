# Micro Company

Micro Company is a fictional company's "asset register", designed and developed using Microservices architecture.

## Description

Micro Company comprises of two services:

- Platform service tracks all the platforms/systems used in the company.
  - Built by the infrastructure team.
  - Used by the infrastructure team, the technical support team, the engineering team, the accounting team, and the procurement team.
- Command service stores commands used to operate registed platforms/systems.
  - Built by the technical support team.
  - Used by the technical support team, the infrastructure team, and the engineering team.

## Technologies

- Frameworks: [.NET](https://dotnet.microsoft.com/en-us/).
- Libraries: [Entity Framework](https://docs.microsoft.com/en-us/ef/).
- Database: [MySQL](https://www.mysql.com/).
- Others: [Docker](https://www.docker.com/), [Kubernetes](https://kubernetes.io/).

## Contributing

Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change. Please make sure to update tests as appropriate.

## License

[MIT](https://choosealicense.com/licenses/mit/)
