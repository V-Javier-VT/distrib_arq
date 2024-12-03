import grpc
import hello_pb2
import hello_pb2_grpc

# Conexión al servidor gRPC
channel = grpc.insecure_channel('localhost:50051')
stub = hello_pb2_grpc.HelloServiceStub(channel)

# Realiza una solicitud
response = stub.SayHello(hello_pb2.HelloRequest(name="Usuario"))
print(f"Respuesta del servidor: {response.message}")
