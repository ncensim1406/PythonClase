
def elementos_comunes(lista1, lista2):
    comunes = list(filter(lambda x: x in lista2, lista1))
    return list(set(comunes))


lista1 = [1, 2, 3, 4, 5, 2]
lista2 = [2, 4, 6, 8]

resultado = elementos_comunes(lista1, lista2)

print("Lista de elementos comunes:", resultado)
