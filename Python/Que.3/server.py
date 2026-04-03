import socket
import sqlite3
import uuid

conn = sqlite3.connect("customers.db")
cursor = conn.cursor()

cursor.execute("""
CREATE TABLE IF NOT EXISTS customers (
    reg_id TEXT,
    name TEXT,
    address TEXT,
    pps TEXT,
    license TEXT
)
""")

server = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
server.bind(("localhost", 12346))
server.listen(1)

print("Server running... Waiting for connection...")

while True:
    client_socket, addr = server.accept()
    print("Connected:", addr)

    data = client_socket.recv(1024).decode()

    name, address, pps, license_doc = data.split(",")

    reg_id = str(uuid.uuid4())[:8]

    cursor.execute("INSERT INTO customers VALUES (?, ?, ?, ?, ?)",
                   (reg_id, name, address, pps, license_doc))
    conn.commit()

    client_socket.send(reg_id.encode())
    client_socket.close()