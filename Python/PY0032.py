while True:
    try:

        num, num2 = int(input("Introduzca un numero entero")), int(input("Introduzca un numero entero"))
        print("1 - Sumar")
        print("2 - Restar")
        print("3 - Dividir")
        print("4 - Multiplicar")
        print("'salir'")
        sel = input("Introduzca la seleccion").lower()
        sumas = lambda x,y: x+y
        restas = lambda x,y: x-y
        div = lambda x,y: x/y
        multi = lambda x,y: x+y
        match sel:
            case "1":
                resul = sumas(num,num2)
                print(f"La suma es {resul:.2f}")
            case "2":
                resul = restas(num,num2)
                print(f"La resta es {resul:.2f}")
            case "3":
                try:
                    resul = div(num,num2)
                    print(f"La division es {resul:.2f}")
                except ZeroDivisionError:
                    print("No se puede dividir por cero")
            case "4":
                resul = multi(num,num2)
                print(f"La multiplicacion es {resul:.2f}")
            case "salir":
                break
    except ValueError:
        print("Introduzca un numero entero porfavor...")