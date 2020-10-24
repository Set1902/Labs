
import math
print('Ковалев Сергей ИУ5-52Б')
while True:
    try:
      
        a=int(input('a='))
        if a!=0:
            b=int(input('b='))
            c=int(input('c='))
            d=(b*b)-(4*a*c)
            print('D=',d)
            if d>0:
                y1=int((-b + math.sqrt(d)) / (2 * a))
                y2=int((-b - math.sqrt(d)) / (2 * a))
                if y1<0:
                    print('нет корней x1 x2 ')
                if y1>0:
                    x1=pow(y1,0.5)
                    x2=-1*pow(y1,0.5)
                    print('x1=',x1)
                    print('x2=',x2)
                if y1==0:
                    print(0)
                if y2<0:
                    print('нет корней x3 x4 ')
                if y2>0:
                    x3=pow(y2,0.5)
                    x4=-1*pow(y2,0.5)
                    print('x3',x3)
                    print('x4',x4)
                if y2==0:
                    print(0)
            if d==0:
                y1=(-b) / (2 * a)
                if y1<0:
                    print('нет корней')
                if y1>0:
                    x1=pow(y1,0.5)
                    x2=-1*pow(y1,0.5)
                    print('x1',x1)
                    print('x2',x2)
                if y1==0:
                    print(0)
            if d<0:
                print('нет корней')

    except :
        print("Ошибка - это не число")
