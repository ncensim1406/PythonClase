def funcion1(*args):
    num=[]
    for y in args:
        num.append(y)
    num.pop(0)
    num.pop()
    print(num)
funcion1(1,2,3,4,5,6,7,8,9,10)

def funcion2(*args):
    num=[]
    for y in args:
        num.append(y)
    cont=0
    for y in num:
        cont+=1
        if cont!=1 and cont!=len(num):
            print(y," ",end="")

funcion2(1,2,3,4,5,6,7,8,9,10)
print()
def funcion3(*args):
    num=[]
    cont=0
    for y in args:
        cont+=1
        if cont!=1 and cont!=len(args):
            print(y," ",end="")


funcion3(1,2,3,4,5,6,7,8,9,10)