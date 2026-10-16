cadena = input("Introduzca una cadena de texto")

cadenaLimpia = cadena.lower().replace(" ","")

cadenaVacia =[]

for caracter in cadenaLimpia:
    if caracter not in cadenaVacia:
        frecuencia = cadenaLimpia.count(caracter)
        print("El caracter " , caracter , " se repite ", frecuencia , " veces")
        cadenaVacia.append(caracter)

