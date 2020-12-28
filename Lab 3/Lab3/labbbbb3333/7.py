from timer import cm_timer_1
from print_result import print_result
from module2 import uniqueSort
from labbbbb3333 import field
from module1 import gen_random
import re
import json
import sys


path = 'data_light.json'




with open(path, encoding='Windows-1251') as f:
    data = json.load(f)





@ print_result
def f1(arg):
    return uniqueSort([elem['job-name'] for elem in arg])


@ print_result
def f2(arg):
    return list(filter(lambda x: 'программист' in x, arg))


@ print_result
def f3(arg):
    return list(map(lambda x: x + " с опытом Python", arg))


@ print_result
def f4(arg):
    return list(map(lambda x: x + ", зарплата " + str(*gen_random(1, 100000, 200000)) + " руб", arg))


if __name__ == '__main__':
    with cm_timer_1():
        f4(f3(f2(f1(data))))