import math
x = input().split()
x = [float(i) for i in x]
print(x)
a1 = x[0]
a2 = math.radians(x[1])
a3 = x[2]
a4 = math.radians(x[3])
a5 = x[4]
first = round((a1 / a2) ** 0.5, 5)
second = round(math.log(a5, 10), 5) 
another_one = round(firstsecond, 5)
third = round(pow(a4, a5), 5)
fourth = round(math.tan(a2-a4),5)
fifth = round(a2/a3, 5)
sixth = round(fourth/fifth, 5)
seventh = round(math.sin(a2))
eighth = round(seventhsixth, 5)
print(round(another_one-third-eighth,2))
