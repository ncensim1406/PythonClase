lista = [1.0, 1.5, 15.0, 19.99, -2.0, -1.44, 55.4]
for i in range(len(lista)):
    if lista[i] >0:
        if i % 2 == 0:
            lista[i]= lista[i]*0.9
            print("indice: ",i," precio antes: ", lista[i]*1.2, " precio ahora: ", lista[i])
        else:
            lista[i] = lista[i] *0.8
            print("indice: ",i," precio antes: ", lista[i]*1.2, " precio ahora: ", lista[i])
    