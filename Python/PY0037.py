def muestraPersona(dni,/,**kwargs):
    print(f"DNI: {dni}")
    for llave, valor in kwargs.items():
        print(f"{llave}: {valor}")

muestraPersona("33333333", Nombre="Jose",Edad="12",Sexo="Helicoptero")