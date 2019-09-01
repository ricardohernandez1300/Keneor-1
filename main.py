import socket
def main():
    socket_server = socket.socket()
    socket_server.bind( ('localhost',8888) )
    socket_server.listen(5)
    while True:
        conexion, addr = socket_server.accept()
        print ("New Connection")
        print (addr)
        conexion.send(b"Hola Mundo")
        conexion.close()

main()