    int[] num;        //Khai báo mảng array                                 
    num = new int[] { 5, 10, 15, 20, 25, 30 };  // Khởi tạo mảng

    for (int k =0; k < num.Length; k++)
    {
        Console.WriteLine(num[k]);
    }

    string[] cars;    //Khai báo mảng array
    cars = new string[] { "Toyota", "Huydai", "Mazda", "Ford", "Honda" };  // Khởi tạo mảng

    foreach (string v_car in cars)
    {
        Console.WriteLine(v_car);
    }