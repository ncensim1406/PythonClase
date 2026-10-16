while True:
    try:
        num = int(input("Introduzca un numero"))
        if num % 2 == 0:
            print("El numero es par")
        else:
            break
    except ValueError:
        print("El numero que has introducido no es entero")