Here will be placed all db-entities of entire solution.
All db entities of the whole solution will be placed here. 


>>> 27-06-2021 00:15
Два основные типа: директория и файл
файл имеет прихвостень - дополнительную информацию, или просто файл с типом, который использует супермодуль расчета.
прихвостень файла оформляется через наследование от файла с прибавлением вложенного класса навигационного свойства доп информации.
class File
name
text
owner
id
type

class Maraphon: File
MaraphonInfo info

class MaraphonInfo
int id
int ownerId
int purposeWords;

мне в любом случае нужно выводить в одну таблицу элементы разных типов. поэтому маршрутизатор точно нужен.