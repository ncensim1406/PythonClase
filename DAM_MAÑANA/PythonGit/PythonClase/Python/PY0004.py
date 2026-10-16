menu_base = ["Ensalada", "Sopa", "Pasta"]

menu_hoy = menu_base.copy() 

menu_hoy.extend(["Pescado", "Postre"])

plato_retirado = menu_hoy.pop()

if "Sopa" in menu_hoy:
    menu_hoy.remove("Sopa")

indice_a_eliminar = 1 
menu_hoy.remove(menu_hoy[indice_a_eliminar])


print("Menú de hoy al revés:", menu_hoy[::-1])


menu_base.clear()

print("\n--- Demostración final ---")
print("Lista base original (vaciada):", menu_base)
print("Lista menú de hoy (intacta):", menu_hoy)
