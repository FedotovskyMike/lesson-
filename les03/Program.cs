void FillArray(int[] collection)
//void метод который ни чего не возвращает
{
    int Length = collection.Length;
    int index = 0;
    while(index < Length)
    {
        collection[index] = new Random().Nex(1, 10);
        index ++;
    }
}



int[] array = new int[10]; //определили массив из 10 эле-в

/* метод */ FillArray //заполнил определённый нами массив 
/* метод */ PrintArray(array); //распечатывает массив