import socket

print("Client started...")

client = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
client.connect(("localhost", 12346))

print("Connected to server")

print("Enter your details:")

name = input("Name: ")
address = input("Address: ")
pps = input("PPS Number: ")
license_doc = input("Driving License: ")

data = f"{name},{address},{pps},{license_doc}"

client.send(data.encode())

reg_id = client.recv(1024).decode()

print("\nRegistration Successful!")
print("Your ID:", reg_id)

client.close()