matriz = [
   [1, 1, 1, 3],
   [2, 2, 2, 7],
   [3, 3, 3, 9],
   [4, 4, 4, 13] ]

for lista in matriz:
    if (lista[3])!=sum(lista)-lista[3]:
        lista[3]=sum(lista)-lista[3]
print(matriz)