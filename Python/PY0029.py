def fibonazi(num):
    a =1
    b=0
    for por in range(num):
        b=a+b
        a=b-a
    print(b)
fibonazi(12)