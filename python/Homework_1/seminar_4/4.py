#Напишите программу, которая принимает на вход строку, и отслеживает, сколько раз каждый символ уже
#встречался. Количество повторов добавляется к символам с помощью постфикса формата _n.
#Input: a a a b c a a d c d d
#Output: a a_1 a_2 b c a_3 a_4 d c_1 d_1 d_2
#Для решения данной задачи используйте функцию .split()

#text="a a a b c a a d c d d".split()
#res={}
#for i in "a a a b c a a d c d d":
#    if i not in res:
#    res[i]=0
#    print(i, end= " ")
#else: 
#    res[i]+=1
#    print (i, "_", res[i], end=" ")

#stroka = input().split()
#result = {}
#for i in stroka:
#    if i in result:
#        print(f'{i}_{result[i]}', end=' ')
#    else:
#        print(i, end=' ')
#    result[i] = result.get(i, 0) + 1


#Пользователь вводит текст(строка). Словом считается последовательность непробельных символов идущих 
#подряд, слова разделены одним или большим числом пробелов. Определите, сколько различных слов 
#содержится в этом тексте.
#Input: She sells sea shells on the sea shore The shells that she sells are sea shells 
#I'm sure.So if she sells sea shells on the sea shore I'm sure that the shells are sea shore shells
#Output: 13

#text="She sells sea shells on the sea shore The shells that she sells are sea shells I'm sure.So if she sells sea shells on the sea shore I'm sure that the shells are sea shore shells"
#text=text.upper()
#text=text.split()       #находим разделители и разделяем строку
#text=set(text)          #преобразуем строку в множество. исключаем повторяющиеся значения
#text=str(text)          #преобразуем множество обратно в строку
#print(text)
#count=text.count(" ")+1 #считаем кол-во элементов в строке
#print(count)