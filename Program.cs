string[] array = {"hello","2","world",":-)"};
// string[] array = {"1234","1567","-2","computer science"};
// string[] array = {"Russia","Denmark","Kazan"};

string[] NewArray(string[] array){
    int count = 0;
    for (int i=0; i<array.Length; i++){
        if (array[i].Length<=3){
            count++;
        }
    }
    string[] newArray = new string[count];
    for (int i=0, j = 0; i<array.Length; i++){
        if (array[i].Length<=3){
            newArray[j] = array[i];
            j++;
        }
    }
    return newArray;
}

void ShowArray(string[] array){
    for (int i=0; i<array.Length; i++){
        Console.Write($"{array[i]}, ");
    }
}

string[] newArray = NewArray(array);
ShowArray(newArray);