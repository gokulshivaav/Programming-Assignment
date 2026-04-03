
Programming Assignment – C# & Python Applications

Overview

This repository contains the implementation of four programming tasks using **C# (.NET)** and **Python**. The project demonstrates concepts such as object-oriented programming, client-server communication, and web scraping, along with version control and CI/CD integration using GitHub Actions.


Project Structure

20097813/
│
├── Csharp/
│   ├── Que.1/   → Churros Ordering System
│   └── Que.2/   → Periodic Table Application
│
├── Python/
│   ├── Que.3/   → Client-Server Registration System
│   └── Que.4/   → Web Scraper (Books Data)
│
├── .github/workflows/ → GitHub Actions (CI/CD)
└── README.md

Technologies Used

* C# (.NET 8 / 10)
* Python 3
* Git & GitHub
* GitHub Actions (CI/CD)
* Libraries:

  * requests
  * beautifulsoup4

How to Run the Project

Task 1 – Churros Ordering System (C#)

cd Csharp/Que.1/ChurrosApp
dotnet run

✔ Displays menu
✔ Allows order placement


Task 2 – Periodic Table Application (C#)

cd "Csharp/Que.2/Periodic Table"
dotnet run

✔ Accepts element name
✔ Displays atomic details

Task 3 – Client-Server System (Python)

Start Server:

cd Python/Que.3
python server.py

Start Client (new terminal):

cd Python/Que.3
python client.py

✔ Sends user details
✔ Generates unique ID


Task 4 – Web Scraper (Python)

cd Python/Que.4
python scraper.py

✔ Extracts:
* Book Name
* Price
* Rating

✔ Saves data to:
books.csv

GitHub Actions (CI/CD)

This project includes an automated workflow using GitHub Actions.

Workflow Features:

* Runs on every push
* Builds C# Task 1
* Executes Python scraper
* Ensures code integrity

✔ Status:

All workflows passing successfully 


Key Features

* Object-Oriented Programming in C#
* Socket Programming (Client-Server)
* Web Scraping using Python
* File Handling (CSV)
* Version Control using Git
* CI/CD Pipeline Implementation

Outputs

* Console-based execution for all tasks
* CSV file generated for scraped data
* Server-client communication logs


Conclusion

This project successfully demonstrates:

* Multi-language development (C# + Python)
* Real-world application scenarios
* Automated testing and deployment using GitHub Actions


Author

Gokul Shiva Kumar
📍 Dublin, Ireland
📧 gokulshivaav@gmail.com

 Notes

* Ensure Python and .NET SDK are installed before running
* Run server before client in Task 3
* Internet connection required for web scraping

