pizzas = {"Margarita" : 8, "Cuatro quesos": 12.5, "Pepperoni" : 10  }
def menu_pizzas(picha:dict):
    while True:
        cont =1
        pizza = sorted(picha.items(),key=lambda x: (x[1], x[0]))
        copiaAux = picha.copy()
        for key,valor in pizza:
            print(f"{cont}. {key}  - {valor:.2f}")
            cont+=1
        respuesta = input("Desea añadir una pizza?").lower()
        if(respuesta=="si"):
            try:
                respuesta2 = input("Dime el nombre de la pizza").lower()
                respuesta3 = float(input("Dime el precio de la pizza").lower())
                if(respuesta2 in picha):
                    copiaAux[respuesta2]=respuesta3
                else:
                    copiaAux[respuesta2]=respuesta3
                picha=copiaAux
            except ValueError:
                "Por favor introduzca un precio correcto"
menu_pizzas(pizzas)