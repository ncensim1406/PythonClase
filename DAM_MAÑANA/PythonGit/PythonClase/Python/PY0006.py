inventario_inicial = {'CUS001': 12, 'CUS002': 5, 'CUS003': 0}
ventas = ['CUS001', 'CUS002', 'CUS001', 'CUS004']
reposiciones = {'CUS002': 10, 'CUS004': 7}

inventario_copia = inventario_inicial.copy()
lista =[]

for codigo in ventas:
    if codigo in inventario_copia:
        lista.append(codigo)
    inventario_copia.setdefault(codigo,0)
    inventario_copia[codigo]-=1

for codigo,cantidad in reposiciones.items():
    inventario_copia[codigo]= inventario_copia.get(codigo)+cantidad

print("Hay un total de ",len(inventario_copia), " elementos")
print("Unidades totales: ",sum(inventario_copia.values()))

borrar = []
for codigo in inventario_copia:
    if inventario_copia[codigo] <1:
        borrar.append(codigo)
for codigo in borrar:
    inventario_copia.pop(codigo)


mensaje = input("Introduzca el codigo del stock")
if mensaje not in inventario_copia:
    print("No existe ningun stock con ese codigo")
else:
    print("El stock es de : ", inventario_copia[mensaje])

print("-----Inventario inicial ", inventario_inicial)
print("-----Inventario copiado ", inventario_copia)
inventario_inicial.clear()
print("-----Inventario inicial ", inventario_inicial)