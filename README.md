# Resume Work №1

## Принцип работы программы:

1. Создан метод который будет запрашивать у пользователя размерность массива, потом по очереди вводить строки в массив и возвращать заполненый массив.

2. Создан метод который на вход принимает массив. Создна переменная **count**. Далее запускается цикл по переборке всего массива. В нем устанавливается условие что при нахождении в массиве строки длинной менее 4-х символов счетчик увеличивается на еденицу *(это нужно для того чтобы узнать сколько ячеек нам надо в результирующем массиве)*. Потом был создан массив размерностью **count** и после обнуленно значение **count**. Повторно запускается цикл на перевор массива и так же довавленно условие что при нахождении строки менее 4-х символов это строка добавляется в результирующий массив на позицию **count** и после увеличивается значение **count** на 1. После чего метод возвращает результирующий массив. 
![Вот наглядное изображение работы алгоритма](algoritm.png "Алгоритм")

3. Далее создан метод по выводу массива на экран *(если в массиве нет элементов выводится надпись "Массив пуст.")*.
 
4. Далее поочередно создаются соответствующие переменные и вызываются эти методы с передачей в них соответсвующих параметров.
