lista = ["España", "Argentina", "Perú"]
cont = 0
while True:

    print("MENÚ. Elija una de las siguientes opciones marcando su número")
    print("1. Imprimir alfabéticamente en orden ascendente")
    print("2. Imprimir alfabéticamente en orden descendente")
    print("3. Añadir País")
    print("4. Eliminar Pais")
    print("5. Salir")
    try:
        opcion = input("Elija una opcion")
        cont += 1
        match opcion:
            case "1":
                aux = lista.copy()
                aux.sort()
                print(aux)
                for i in range(1,61):
                    print("#")
                    print("\t")
                    print("\t")
            case "2":
                aux = lista.copy()
                aux.sort(reverse=True)
                print(aux)
                for i in range(1,61):
                    print("#")
                    print("\t")
                    print("\t")
            case "3":
                pais = input("Introduzca un nuevo pais").strip().capitalize()
                lista.append(pais)
                for i in range(1,61):
                    print("#")
                    print("\t")
                    print("\t")
            case "4":
                pais = input("Introduzca el nombre del pais que quiere eliminar").strip().capitalize()
                lista.remove(pais)
                for i in range(1,61):
                    print("#")
                    print("\t")
                    print("\t")
            case "5":
                break
            case _:
                print("Porfavor introduzca un valor valido")
    except ValueError:
        print("Porfavor introduzca un valor valido")
    print("Ejecucion numero: ",cont)
print("Muchas gracias por utilizar el programa, usted ha utilizado ", cont, " intentos. Un saludo!")


