#Задача №49. Решение в группах
#Создать телефонный справочник с
#возможностью импорта и экспорта данных в
#формате .txt. Фамилия, имя, отчество, номер
#телефона - данные, которые должны находиться
#в файле.
#1. Программа должна выводить данные
#2. Программа должна сохранять данные в
#текстовом файле
#3. Пользователь может ввести одну из
#характеристик для поиска определенной
#записи(Например имя или фамилию
#человека)
#4. Использование функций. Ваша программа
#не должна быть линейной

#def show_menu() -> int:
#    print("\nВыберите необходимое действие:\n"
#          "1. Отобразить весь справочник\n"
#          "2. Найти абонента по фамилии\n"
#          "3. Найти абонента по номеру телефона\n"
#          "4. Добавить абонента в справочник\n"
#          "5. Сохранить справочник в текстовом формате\n"
#          "6. Закончить работу")
#    choice = int(input())
#    return choice




#def read_csv(filename: str) -> list:
#    data = []
#    fields = ["Фамилия", "Имя", "Телефон", "Описание"]
#    with open(filename, 'r', encoding='utf-8') as fin:
#        for line in fin:
#            record = dict(zip(fields, line.strip().split(',')))
#            data.append(record)



#    return data




#def add_user(data: list, user_data: str):
#    fields = ["Фамилия", "Имя", "Телефон", "Описание"]
#    record = dict(zip(fields, user_data.split(',')))
#    data.append(record)


def write_txt(filename: str, data: list):
    with open(filename, 'w', encoding='utf-8') as fout:

        for i in range(len(data)):
            s = ''
            for v in data[i].values():
                s += v + ','
            fout.write(f'{s[:-1]}\n')


def write_csv(filename: str, data: list):
    with open(filename, 'w', encoding='utf-8') as fout:
        for i in range(len(data)):
            s = ''
            for v in data[i].values():
                s += v + ','
            fout.write(f'{s[:-1]}\n')





def read_csv(filename: str) -> list:
    data = []
    fields = ["Фамилия", "Имя", "Телефон", "Описание"]
    with open(filename, 'r', encoding='utf-8') as fin:
        for line in fin:
            record = dict(zip(fields, line.strip().split(',')))
            data.append(record)



    return data


def find_by_name(data: list, last_name: str) -> str:
    for el in data:
        if el.get("Фамилия") == last_name:
            return el.get("Телефон")
    return "Такой абонент отсутвует"


def find_by_number(data: list, phone_number: str) -> str:
    for el in data:
        if el.get("Телефон") == phone_number:
            return f'{el.get("Фамилия")}, {el.get("Имя")}'
    return "Такой абонент отсутвует"


def add_user(data: list, user_data: str):
    fields = ["Фамилия", "Имя", "Телефон", "Описание"]
    record = dict(zip(fields, user_data.split(',')))
    data.append(record)