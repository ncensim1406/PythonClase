import math

radio =  int(input("Dame el radio : "))
area = lambda x: math.pi*x**2
resultado = area(radio)
print(f"{resultado:.2f}")