#Хакер Василий получил доступ к классному журналу и хочет заменить все свои минимальные оценки на
#максимальные. Напишите программу, которая заменяет оценки Василия, но наоборот: все максимальные –
#на минимальные.
#Input: 5 -> 1 3 3 3 4 Output: 1 3 3 3 1

#marks_number = int(input ("Введите количество оценок : "))
#marks = [int(input (f'Введите оценку {i} : ')) for i in range(marks_number)]
#print(*marks)
#max_mark = max(marks)
#min_mark = min (marks)
#for i in range(marks_number):
#    if marks [i] == max_mark : marks [i] =min_mark
#marks = map((lambda x : min_mark if (x==max_mark) else x), marks)
#print(*marks)

#решить рекурсией - факториал

#n = int(input("Введите число: "))

#def factorial(n):
#    if n == 1:
#        return 1
#    else:
#        return n * factorial(n-1)


#print(f"Факториал числа {n} -  {factorial(n)}")


#Задача No31. Общее обсуждение
#Последовательностью Фибоначчи называется последовательность чисел a0, a1, ..., an, ..., где
#a0 = 0, a1 = 1, ak = ak-1 + ak-2 (k > 1). Требуется найти N-е число Фибоначчи
#Input: 7 Output: 21

#n = int(input("Ведите число: "))

#def fibonachi(n):
#    if n <= 1:
#        return 1
#    else:
#        return fibonachi(n-1) + fibonachi(n-2)
    
#print(fibonachi(n))


#Напишите функцию, которая принимает одно число и проверяет, является ли оно простым
#Напоминание: Простое число - это число, которое имеет 2 делителя: 1 и n(само число)
#Input: 5 Output: yes

#n = int(input("введите число: "))



# def simpleCheck(n):
#     for i in range(2,n):
#         if n%i == 0:
#             return False
#     return True

#i = n-1
#def simplerecur(n, i):
    
    if i==1:
        return True
    else:
        if n%i==0:
            return False
        return simplerecur(n, i-1)



#print(simplerecur(n, i))

#def func(n,count = 2):
#    if n < 2:
#        return False
#    elif n == 2:
#        return True
#    elif (n % count) == 0:
#        return False
#    elif count*count > n:
#        return True
#    else:
#        return func(n,count+1)

#print(func(n))