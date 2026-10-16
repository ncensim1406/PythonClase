import time

cadena = input("Introduce una cadena: ")
caracter = input("Introduce el carácter que quieres sustituir: ")
sustituto = input("Introduce el carácter por el que quieres sustituir: ")

if len(caracter) != 1 or len(sustituto) != 1:
    print("Error: debes introducir un solo carácter en cada caso.")
    time.sleep(3)
    exit()

resultado = cadena.replace(caracter, sustituto)

print("\tCadena antigua:", cadena)
print("\tCadena modificada:", resultado)
