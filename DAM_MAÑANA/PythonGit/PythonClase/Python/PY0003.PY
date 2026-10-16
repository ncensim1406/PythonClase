lista1 = []
while True:
    nombre = input("Introduzca un nombre de asistente (escriba fin para finalizar)")
    if nombre=="fin":
        
        break
    else:
        lista1.append(nombre)
print(lista1)
numeroNombre = input("Introduce un nombre ")
print("El nombre ",numeroNombre," aparece ",lista1.count(numeroNombre)," veces")
print("El nombre aparece por primera vez en la posicion ", lista1.index(numeroNombre)+1)
lista1.remove(numeroNombre)
vip = input("Introduzca un nombre vip")
lista1.insert(0,vip)
print(lista1)