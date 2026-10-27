def suma_n_numeros(x=0,*args):
    for y in args:
        x+=y
    return x
print(suma_n_numeros(1,2,2,5))
print("")

def suma_n_enteros(x=0,*args):
    for y in args:
        if(isinstance(y,int)):
            x+=y
        else:
            print(f"{y} no es un numero entero")
    return x
print(suma_n_enteros(1,2,2,8.5,5))
print("")

def suma_dos_o_mas_numeros(x,o,/,*args):
    x+=o
    for y in args:
        if(isinstance(y,int)):
            x+=y
        else:
            print(f"{y} no es un numero entero")
    return x
print(suma_dos_o_mas_numeros(1))