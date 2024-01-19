from pythonosc.udp_client import SimpleUDPClient

def send_message(msg):
    ip = "127.0.0.1"
    port = 4999
    address = "/dollars/generate"
    client = SimpleUDPClient(ip, port)
    client.send_message(address, msg)

send_message("a man raising the right hands")

        