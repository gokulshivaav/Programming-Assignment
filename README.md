Programming Assignment
📌 Overview

This repository contains solutions for a multi-part programming assignment covering C# Object-Oriented Programming and Python-based applications including client-server communication and web scraping.

📂 Project Structure
Que.1 → C# Churros Order Management System  
Que.2 → C# Periodic Table Application  
Que.3 → Python Client-Server Application (TCP + Database)  
Que.4 → Python Web Scraping & CSV Processing  
🧩 Task 1: Churros Order System (C#)
✔ Features:
Menu-driven console application
Order placement and delivery system
Queue-based order handling (FIFO)
Bill calculation
Unit testing for billing functionality
✔ Concepts Used:
Classes & Objects
Encapsulation
Constructors
Properties
Queue (Data Structure)
🧪 Task 2: Periodic Table (C#)
✔ Features:
Stores first 30 elements
User inputs atomic number
Displays element details (Name, Class)
Loop-based interaction
✔ Concepts Used:
Dictionary (Data Structure)
Classes & Objects
User Input Handling
🌐 Task 3: Client-Server Application (Python)
✔ Features:
TCP-based communication
Client collects user data
Server processes and stores data
Unique registration ID generation
SQLite database integration
✔ Technologies Used:
socket (TCP communication)
sqlite3 (database)
uuid (unique ID generation)
📊 Task 4: Web Scraping (Python)
✔ Features:
Extracts book data from website
Retrieves:
Book Name
Price
Rating
Stores data in CSV file
Reads and displays CSV content
✔ Technologies Used:
requests (HTTP requests)
BeautifulSoup (HTML parsing)
csv (file handling)
⚙️ Requirements
C#:
.NET SDK
Visual Studio Code
Python:

Install required libraries:

pip install requests beautifulsoup4
▶️ How to Run
Task 1 & 2 (C#):
dotnet run
Task 3 (Python):
# Terminal 1 (Server)
python server.py

# Terminal 2 (Client)
python client.py
Task 4 (Python):
python scraper.py
📁 Output Files
customers.db → Database (Task 3)
books.csv → Scraped data (Task 4)
🎯 Learning Outcomes
Applied Object-Oriented Programming principles
Implemented data structures effectively
Built client-server architecture using TCP
Worked with databases and persistent storage
Performed web scraping and data processing
👨‍💻 Author

Gokul Shiva Kumar

📌 Notes
This project is developed for academic purposes
All data from scraping website is for demonstration only