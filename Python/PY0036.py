from datetime import date

def agregar_tarea(desctarea, registro=None, usuario="sistema"):
    if registro is None:
        registro = []

    tarea = {
        "desctarea": desctarea,
        "fecha": date.today(),
        "usuario": usuario
    }

    registro.append(tarea)
    return registro

if __name__ == "__main__":
    registro_jorge= agregar_tarea("añadir envio sms",usuario="jorge")
    registro_jorge = agregar_tarea("corrijo envio sms",registro_jorge,usuario="jorge")

    registro_ana = agregar_tarea("corrijo bug1",usuario="ana")
    registro_ana = agregar_tarea("corrijo bug2" , registro_ana,usuario="ana")
print(registro_jorge)
print(registro_ana)