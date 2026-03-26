import requests
from bs4 import BeautifulSoup
import csv

print("Starting scraping...")

# Step 1: Website link
url = "https://books.toscrape.com/catalogue/category/books/travel_2/index.html"

# Step 2: Get page
response = requests.get(url)
response.encoding = "utf-8"

# Step 3: Convert to readable format
soup = BeautifulSoup(response.text, "html.parser")

# Step 4: Find all books
books = soup.find_all("article", class_="product_pod")

print("Books found:", len(books))

# Step 5: Extract data
data = []

for book in books:
    # Book name
    name = book.h3.a["title"]

    # Price
    price = book.find("p", class_="price_color").text

    # Rating
    rating = book.p["class"][1]

    print("Book:", name, "| Price:", price, "| Rating:", rating)

    data.append([name, price, rating])

# Step 6: Save to CSV
with open("books.csv", "w", newline="", encoding="utf-8") as file:
    writer = csv.writer(file)

    writer.writerow(["Book Name", "Price", "Rating"])
    writer.writerows(data)

print("\nData saved to books.csv")

# Step 7: Read CSV
print("\nReading from CSV:\n")

with open("books.csv", "r", encoding="utf-8") as file:
    reader = csv.reader(file)

    for row in reader:
        print(row)