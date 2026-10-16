try:
    num = int(input("Introduzca un numero"))
    num2 = int(input("Introduzca un numero"))
    num3 = int(input("Introduzca un numero"))
    media = num*0.15 + num2*0.35 + num3*0.5
    print(media)
except ValueError:
    print("El valor que has introducido es un float")