
lista1 = [6, 1, 8, 7, 3, 2, 4, 9, 5]
def separar_lista(lista):
    pares =[]
    impares =[]
    for x in lista:
        if x % 2 == 0:
            pares.append(x)
        else:
            impares.append(x)
        pares = sorted(pares)
        impares = sorted(impares)
    return pares, impares
pares1, impares1= separar_lista(lista1)
print(pares1)
print(impares1)