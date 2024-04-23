class AppPrueba
{
    public static void Main(string[] args)
    {
        string usuario, direccion, menu, ham;
        string men1;
        int comb1, desa1, ham1, gourmet1, niños1, post1, cant;
        //VARIABLE PARA ESCOGER ESPECIALIDAD PIZZA
        int pizza, pizza1;
        //VARIABLE PARA QUE EL PRECIO EMPIECE EN 0
        double preciofinal = 0;
        //VARIABLE PARA QUE FUNCIONE EL SWITCH
        string p = "Si";
        //VARIABLE SELECCIONAR MÉTODO DE PAGO
        int selec = 0;
        double dinero = 0;
        //VARIABLES TARJETA DE CREDITO
        double select = 0;
        double tarjeta = 0;
        int cvv = 0;

        Console.WriteLine("Bienvenido a Rapids Food, por favor ingrese su nombre:");
        usuario = Console.ReadLine();
        Console.WriteLine("Por favor ingrese su dirección");
        direccion = Console.ReadLine();
        Console.WriteLine("¿Qué desea ordenar este día?");
        Console.WriteLine("Hamburguesas (1)      Pizzas   (2)           Pollo    (3)");
        Console.WriteLine("Comida China (4)    Sandwiches (5)    Comida Mexicana (6)");
        Console.WriteLine("Cafetería    (7)       Carne   (8)          Mariscos  (9)");
        Console.WriteLine("Heladería    (10)     Pupusas  (11)          Otros    (12)");
        menu = Console.ReadLine();
        switch (menu)
        {
            //MENU HAMBURGUESAS
            case ("1"):
                Console.WriteLine("Qué restaurante desea ordenar");
                Console.WriteLine("McDonalds  (1)    Burguer King (2)    Wendy´s (3)");
                Console.WriteLine("Red Pepper (4)      El Place   (5)    Denny´s (6)");
                ham = Console.ReadLine();
                switch (ham)
                {
                    //MENU MCDONALDS
                    case ("1"):
                        while (p == "Si")
                        {
                            Console.WriteLine("Bienvenido al menú de McDonalds, ¿Qué desea ordenar?");
                            Console.WriteLine("Promociones (1)      Desayunos   (2)   Hamburguesas (3)");
                            Console.WriteLine("Gourmet     (4)    Menú infantil (5)      Postres   (6)");
                            men1 = Console.ReadLine();
                            switch (men1)
                            {
                                //MENU PROMOCIONES MCDONALDS
                                case ("1"):
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine("40 Nuggets + 4 Papas Regulares + una soda de 1.5 lt.....................$15.99 (1)");
                                    Console.WriteLine("3 McPollo + 3 Quesoburguesas + 10 Nuggets + 3 Papas Regulares...........$16.99 (2)");
                                    Console.WriteLine("4 Quesoburguesas más 2 Papas Regulares más 2 Sodas en lata..............$9.99  (3)");
                                    Console.WriteLine("2 BigMac + 2 Quesoburguesas + 3 Papas Medianas + soda de 1.5 lt.........$16.99 (4)");
                                    Console.WriteLine("2 Cuarto de Libra + 2 BigMac + 4 Papas Grandes + Soda 1.5 lt............$21.99 (5)");
                                    comb1 = int.Parse(Console.ReadLine());
                                    if (comb1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la promoción número" + " " + comb1 + " " + "y su precio es de " + "$" + (15.99 * cant));
                                        preciofinal = preciofinal + (15.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la promoción número" + " " + comb1 + " " + "y su precio es de " + "$" + (16.99 * cant));
                                        preciofinal = preciofinal + (16.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la promoción número" + " " + comb1 + " " + "y su precio es de " + "$" + (9.99 * cant));
                                        preciofinal = preciofinal + (9.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 4)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la promoción número" + " " + comb1 + " " + "y su precio es de " + "$" + (16.99 * cant));
                                        preciofinal = preciofinal + (16.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 5)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la promoción número" + " " + comb1 + " " + "y su precio es de " + "$" + (21.99 * cant));
                                        preciofinal = preciofinal + (21.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                                //MENU DESAYUNOS MCDONALDS
                                case ("2"):
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine("McMuffin Tocino Doble y Huevo + Hashbrown + Jugo de Naranja....................................$5.45 (1)");
                                    Console.WriteLine("McMuffin Super Salvadoreño con Jamón + Hashbrown + Jugo de Naranja.............................$5.20 (2)");
                                    Console.WriteLine("McMuffin Super Salvadoreño con Salchicha + Hashbrown + Jugo de Naranja.........................$4.70 (3)");
                                    Console.WriteLine("McWrap de salchicha, tocino y queso + Hashbrown + Jugo de Naranja..............................$5.05 (4)");
                                    Console.WriteLine("Burrito de salchicha, huevo revuelto, queso, chile pimiento + Hashbrown + Jugo de Naranja......$6.70 (5)");
                                    desa1 = int.Parse(Console.ReadLine());
                                    if (desa1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el desayuno número" + " " + desa1 + " " + "y su precio es de " + "$" + (5.45 * cant));
                                        preciofinal = preciofinal + (5.45 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (desa1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el desayuno número" + " " + desa1 + " " + "y su precio es de " + "$" + (5.20 * cant));
                                        preciofinal = preciofinal + (5.20 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (desa1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el desayuno número" + " " + desa1 + " " + "y su precio es de " + "$" + (4.70 * cant));
                                        preciofinal = preciofinal + (4.70 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (desa1 == 4)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el desayuno número" + " " + desa1 + " " + "y su precio es de " + "$" + (5.05 * cant));
                                        preciofinal = preciofinal + (5.05 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (desa1 == 5)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el desayuno número" + " " + desa1 + " " + "y su precio es de " + "$" + (6.70 * cant));
                                        preciofinal = preciofinal + (6.70 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                                //MENU HAMBURGUESAS MCDONALDS
                                case ("3"):
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine("Big Mac + Papas Medianas + Soda en lata...........................$6.85 (1)");
                                    Console.WriteLine("McBacon Doble + Papas Medianas + Soda en lata.....................$6.10 (2)");
                                    Console.WriteLine("Cuarto de libra con queso + Papas Medianas + Soda en lata.........$7.05 (3)");
                                    Console.WriteLine("McNífica de Res + Papas Medianas + Soda en lata...................$7.30 (4)");
                                    Console.WriteLine("Big Tasty Pollo + Papas Medianas + Soda en Lata...................$7.50 (5)");
                                    ham1 = int.Parse(Console.ReadLine());
                                    if (ham1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la hamburguesa número" + " " + ham1 + " " + "y su precio es de " + "$" + (6.85 * cant));
                                        preciofinal = preciofinal + (6.85 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (ham1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la hamburguesa número" + " " + ham1 + " " + "y su precio es de " + "$" + (6.10 * cant));
                                        preciofinal = preciofinal + (6.10 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (ham1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la hamburguesa número" + " " + ham1 + " " + "y su precio es de " + "$" + (7.05 * cant));
                                        preciofinal = preciofinal + (7.05 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (ham1 == 4)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la hamburguesa número" + " " + ham1 + " " + "y su precio es de " + "$" + (7.30 * cant));
                                        preciofinal = preciofinal + (7.30 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (ham1 == 5)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la hamburguesa número" + " " + ham1 + " " + "y su precio es de " + "$" + (7.50 * cant));
                                        preciofinal = preciofinal + (7.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                                //MENU GOURMET MCDONALDS
                                case ("4"):
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine("Smokehouse Gourmet + Papas Medianas + Soda en lata............$8.20 (1)");
                                    Console.WriteLine("Pico Guacamol Res + Papas Medianas + Soda en lata.............$8.45 (2)");
                                    Console.WriteLine("Pico Guacamol Pollo + Papas Medianas + Soda en lata...........$7.95 (3)");
                                    Console.WriteLine("Clásica Gourmet Res + Papas Medianas + Soda en lata...........$8.45 (4)");
                                    Console.WriteLine("Clásica Gourmet Pollo + Papas Medianas + Soda en lata.........$7.95 (5)");
                                    gourmet1 = int.Parse(Console.ReadLine());
                                    if (gourmet1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la hamburguesa gourmet número" + " " + gourmet1 + " " + "y su precio es de " + "$" + (8.20 * cant));
                                        preciofinal = preciofinal + (8.20 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (gourmet1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la hamburguesa gourmet número" + " " + gourmet1 + " " + "y su precio es de " + "$" + (8.45 * cant));
                                        preciofinal = preciofinal + (8.45 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (gourmet1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la hamburguesa gourmet número" + " " + gourmet1 + " " + "y su precio es de " + "$" + (7.95 * cant));
                                        preciofinal = preciofinal + (7.95 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (gourmet1 == 4)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la hamburguesa gourmet número" + " " + gourmet1 + " " + "y su precio es de " + "$" + (8.45 * cant));
                                        preciofinal = preciofinal + (8.45 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (gourmet1 == 5)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la hamburguesa gourmet número" + " " + gourmet1 + " " + "y su precio es de " + "$" + (7.95 * cant));
                                        preciofinal = preciofinal + (7.95 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                                //MENU INFANTIL MCDONALDS
                                case ("5"):
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine("Hamburguesa jr + Pure de Manzana + Papa Kids + Soda en lata + Juguete.......$5.49 (1)");
                                    Console.WriteLine("Quesoburguesa + Pure de Manzana + Papa Kids + Soda en lata + Juguete........$5.49 (2)");
                                    Console.WriteLine("4 McNuggets + Yogurt de Fresa + Papa Kids + Soda en lata + Juguete..........$5.49 (3)");
                                    Console.WriteLine("Hamburguesa + Papas Medianas + Soda en lata + Juguete.......................$5.49 (4)");
                                    Console.WriteLine("Derretido + Yogurt de Fresa + Papa Kids + Soda en lata + Juguete............$5.49 (5)");
                                    niños1 = int.Parse(Console.ReadLine());
                                    if (niños1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el menú infantil número" + " " + niños1 + " " + "y su precio es de " + "$" + (5.49 * cant));
                                        preciofinal = preciofinal + (5.49 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (niños1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el menú infantil número" + " " + niños1 + " " + "y su precio es de " + "$" + (5.49 * cant));
                                        preciofinal = preciofinal + (5.49 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (niños1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el menú infantil número" + " " + niños1 + " " + "y su precio es de " + "$" + (5.49 * cant));
                                        preciofinal = preciofinal + (5.49 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (niños1 == 4)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el menú infantil número" + " " + niños1 + " " + "y su precio es de " + "$" + (5.49 * cant));
                                        preciofinal = preciofinal + (5.49 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (niños1 == 5)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el menú infantil número" + " " + niños1 + " " + "y su precio es de " + "$" + (5.49 * cant));
                                        preciofinal = preciofinal + (5.49 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                                //MENU POSTRES MCDONALDS
                                case ("6"):
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine("McFlurry Oreo Chocolate......$2.65 (1)");
                                    Console.WriteLine("McFlurry Oreo Fresa..........$2.65 (2)");
                                    Console.WriteLine("McFlurry M&M´s Chocolate.....$2.65 (3)");
                                    Console.WriteLine("McFlurry M&M´s Fresa.........$2.65 (4)");
                                    Console.WriteLine("Pastel de Manzana............$1.80 (5)");
                                    post1 = int.Parse(Console.ReadLine());
                                    if (post1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el postre número" + " " + post1 + " " + "y su precio es de " + "$" + (2.65 * cant));
                                        preciofinal = preciofinal + (2.65 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (post1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el postre número" + " " + post1 + " " + "y su precio es de " + "$" + (2.65 * cant));
                                        preciofinal = preciofinal + (2.65 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (post1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el postre número" + " " + post1 + " " + "y su precio es de " + "$" + (2.65 * cant));
                                        preciofinal = preciofinal + (2.65 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (post1 == 4)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el postre número" + " " + post1 + " " + "y su precio es de " + "$" + (2.65 * cant));
                                        preciofinal = preciofinal + (2.65 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (post1 == 5)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el postre número" + " " + post1 + " " + "y su precio es de " + "$" + (1.80 * cant));
                                        preciofinal = preciofinal + (1.80 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                            }
                        }
                        break;
                    //MENU BURGER KING
                    case ("2"):
                        while (p == "Si")
                        {
                            Console.WriteLine("Bienvenido al menú de Burger King, ¿Qué desea ordenar?");
                            Console.WriteLine("Promociones (1)      Desayunos   (2)   Hamburguesas (3)");
                            Console.WriteLine("Genius      (4)    Menú infantil (5)      Postres   (6)");
                            men1 = Console.ReadLine();
                            switch (men1)
                            {
                                //MENU PROMOCIONES BURGER KING
                                case ("1"):
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine("3 Whopper + 3 Papas + 3 Sodas.........................................$16.99 (1)");
                                    Console.WriteLine("2 Whopper + 2 Quesoburguesas + 4 Papas + 4 Sodas......................$18.39 (2)");
                                    Console.WriteLine("1 Whopper + 1 Steakhouse + 2 Quesoburguesas + 4 Papas + 4 Sodas.......$24.99  (3)");
                                    Console.WriteLine("4 Quesoburguesas + 4 Papas + 4 Sodas..................................$15.89 (4)");
                                    Console.WriteLine("2 Whopper + 2 Whopper Jr + 4 Papas + 4 Sodas..........................$19.39 (5)");
                                    comb1 = int.Parse(Console.ReadLine());
                                    if (comb1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la promoción número" + " " + comb1 + " " + "y su precio es de " + "$" + (16.99 * cant));
                                        preciofinal = preciofinal + (16.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la promoción número" + " " + comb1 + " " + "y su precio es de " + "$" + (18.39 * cant));
                                        preciofinal = preciofinal + (18.39 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la promoción número" + " " + comb1 + " " + "y su precio es de " + "$" + (24.99 * cant));
                                        preciofinal = preciofinal + (24.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 4)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la promoción número" + " " + comb1 + " " + "y su precio es de " + "$" + (15.89 * cant));
                                        preciofinal = preciofinal + (15.89 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 5)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la promoción número" + " " + comb1 + " " + "y su precio es de " + "$" + (19.39 * cant));
                                        preciofinal = preciofinal + (19.39 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                                //MENU DESAYUNOS BURGER KING
                                case ("2"):
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine("Sándwich Muffin + Jugo de Naranja...........$3.79 (1)");
                                    Console.WriteLine("Sándwich biscuit + Jugo de Naranja..........$3.59 (2)");
                                    Console.WriteLine("Enormous + Jugo de Naranja..................$4.99 (3)");
                                    Console.WriteLine("Desayuno pancake + Jugo de Naranja..........$4.89 (4)");
                                    Console.WriteLine("Desayuno americano + Jugo de Naranja........$3.99 (5)");
                                    desa1 = int.Parse(Console.ReadLine());
                                    if (desa1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el desayuno número" + " " + desa1 + " " + "y su precio es de " + "$" + (3.79 * cant));
                                        preciofinal = preciofinal + (3.79 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (desa1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el desayuno número" + " " + desa1 + " " + "y su precio es de " + "$" + (3.59 * cant));
                                        preciofinal = preciofinal + (3.59 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (desa1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el desayuno número" + " " + desa1 + " " + "y su precio es de " + "$" + (4.99 * cant));
                                        preciofinal = preciofinal + (4.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (desa1 == 4)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el desayuno número" + " " + desa1 + " " + "y su precio es de " + "$" + (4.89 * cant));
                                        preciofinal = preciofinal + (4.89 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (desa1 == 5)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el desayuno número" + " " + desa1 + " " + "y su precio es de " + "$" + (3.99 * cant));
                                        preciofinal = preciofinal + (3.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                                //MENU HAMBURGUESAS BURGER KING
                                case ("3"):
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine("Big King + Papas Medianas + Soda en lata.................$4.99 (1)");
                                    Console.WriteLine("Whopper + Papas Medianas + Soda en lata..................$6.99 (2)");
                                    Console.WriteLine("Texas Whopper + Papas Medianas + Soda en lata............$7.99 (3)");
                                    Console.WriteLine("Steakhouse + Papas Medianas + Soda en lata...............$8.99 (4)");
                                    Console.WriteLine("Tender Grill Pollo + Papas Medianas + Soda en Lata.......$7.99 (5)");
                                    ham1 = int.Parse(Console.ReadLine());
                                    if (ham1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la hamburguesa número" + " " + ham1 + " " + "y su precio es de " + "$" + (4.99 * cant));
                                        preciofinal = preciofinal + (4.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (ham1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la hamburguesa número" + " " + ham1 + " " + "y su precio es de " + "$" + (6.99 * cant));
                                        preciofinal = preciofinal + (6.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (ham1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la hamburguesa número" + " " + ham1 + " " + "y su precio es de " + "$" + (7.99 * cant));
                                        preciofinal = preciofinal + (7.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (ham1 == 4)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la hamburguesa número" + " " + ham1 + " " + "y su precio es de " + "$" + (8.99 * cant));
                                        preciofinal = preciofinal + (8.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (ham1 == 5)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la hamburguesa número" + " " + ham1 + " " + "y su precio es de " + "$" + (7.99 * cant));
                                        preciofinal = preciofinal + (7.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                                //MENU GENIUS BURGER KING
                                case ("4"):
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine("Genius WHOPPER + Papas Medianas + Soda en lata............$7.79 (1)");
                                    Console.WriteLine("Genius STEAKHOUSE + Papas Medianas + Soda en lata.........$9.49 (2)");
                                    Console.WriteLine("Genius ROYAL CHICKEN + Papas Medianas + Soda en lata......$7.79 (3)");
                                    gourmet1 = int.Parse(Console.ReadLine());
                                    if (gourmet1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la hamburguesa genius número" + " " + gourmet1 + " " + "y su precio es de " + "$" + (7.79 * cant));
                                        preciofinal = preciofinal + (7.79 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (gourmet1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la hamburguesa genius número" + " " + gourmet1 + " " + "y su precio es de " + "$" + (9.49 * cant));
                                        preciofinal = preciofinal + (9.49 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (gourmet1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la hamburguesa genius número" + " " + gourmet1 + " " + "y su precio es de " + "$" + (7.79 * cant));
                                        preciofinal = preciofinal + (7.79 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                                //MENU INFANTIL BURGER KING
                                case ("5"):
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine("King Jr. nuggets + Papas Kids + Soda en lata + Juguete.....................$3.99 (1)");
                                    Console.WriteLine("King Jr. hamburguesa con queso + Papa Kids + Soda en lata + Juguete........$4.69 (2)");
                                    Console.WriteLine("King Jr. derretido  + Papa Kids + Soda en lata + Juguete...................$3.29 (3)");
                                    Console.WriteLine("King Jr. hamburguesa + Papas Medianas + Soda en lata + Juguete.............$4.39 (4)");
                                    niños1 = int.Parse(Console.ReadLine());
                                    if (niños1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el menú infantil número" + " " + niños1 + " " + "y su precio es de " + "$" + (3.99 * cant));
                                        preciofinal = preciofinal + (3.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (niños1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el menú infantil número" + " " + niños1 + " " + "y su precio es de " + "$" + (4.69 * cant));
                                        preciofinal = preciofinal + (4.69 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (niños1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el menú infantil número" + " " + niños1 + " " + "y su precio es de " + "$" + (3.29 * cant));
                                        preciofinal = preciofinal + (3.29 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (niños1 == 4)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el menú infantil número" + " " + niños1 + " " + "y su precio es de " + "$" + (4.39 * cant));
                                        preciofinal = preciofinal + (4.39 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                                //MENU POSTRES BURGER KING
                                case ("6"):
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine("Hershey's pie...........$2.65 (1)");
                                    Console.WriteLine("Pie de manzana..........$1.29 (2)");
                                    Console.WriteLine("Galletas................$1.29 (3)");
                                    post1 = int.Parse(Console.ReadLine());
                                    if (post1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el postre número" + " " + post1 + " " + "y su precio es de " + "$" + (2.65 * cant));
                                        preciofinal = preciofinal + (2.65 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (post1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el postre número" + " " + post1 + " " + "y su precio es de " + "$" + (1.29 * cant));
                                        preciofinal = preciofinal + (1.29 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (post1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el postre número" + " " + post1 + " " + "y su precio es de " + "$" + (1.29 * cant));
                                        preciofinal = preciofinal + (1.29 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                            }
                        }
                        break;
                    //MENU WENDYS
                    case ("3"):
                        while (p == "Si")
                        {
                            Console.WriteLine("Bienvenido al menú de Wendy´s, ¿Qué desea ordenar?");
                            Console.WriteLine("Promociones (1)      Desayunos   (2)   Hamburguesas (3)");
                            Console.WriteLine("Snacks      (4)    Menú infantil (5)      Postres   (6)");
                            men1 = Console.ReadLine();
                            switch (men1)
                            {
                                //MENU PROMOCIONES WENDYS
                                case ("1"):
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine("2 Classica 1/4 de libra + 10 Nuggets + 3 Papas + Soda 1.5 lt...............$18.50 (1)");
                                    Console.WriteLine("2 Big Bacon Classic + 1 Melt + 1/4 de Llibra + 4 Papas + Soda 1.5 lt.......$30.75 (2)");
                                    Console.WriteLine("2 1/4 de Libra + 2 Double Cheeseburger jr + 4 Papas + Soda 1.5 lt..........$20.50 (3)");
                                    Console.WriteLine("Big Bacon + Melt + Baconator Single + 3 Papas + Soda 1.5 lt................$19.95 (4)");
                                    Console.WriteLine("1/4 de Libra + Big Bacon + Chiliburger + Melt + 4 Papas +Soda 1.5 lt.......$25.50 (5)");
                                    comb1 = int.Parse(Console.ReadLine());
                                    if (comb1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la promoción número" + " " + comb1 + " " + "y su precio es de " + "$" + (18.50 * cant));
                                        preciofinal = preciofinal + (18.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la promoción número" + " " + comb1 + " " + "y su precio es de " + "$" + (30.75 * cant));
                                        preciofinal = preciofinal + (30.75 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la promoción número" + " " + comb1 + " " + "y su precio es de " + "$" + (20.50 * cant));
                                        preciofinal = preciofinal + (20.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 4)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la promoción número" + " " + comb1 + " " + "y su precio es de " + "$" + (19.95 * cant));
                                        preciofinal = preciofinal + (19.95 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 5)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la promoción número" + " " + comb1 + " " + "y su precio es de " + "$" + (25.50 * cant));
                                        preciofinal = preciofinal + (25.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                                //MENU DESAYUNOS WENDYS
                                case ("2"):
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine("Breakfast Baconator + Papas + Jugo de Naranja .................$7.50 (1)");
                                    Console.WriteLine("Bacon & Swiss Croissant + Papas + Jugo de Naranja..............$6.25 (2)");
                                    Console.WriteLine("Croissant Black Forest y Huevo + Papas + Jugo de Naranja.......$6.25 (3)");
                                    Console.WriteLine("Burrito típico + Papas + Jugo de Naranja.......................$5.60 (4)");
                                    Console.WriteLine("Desayuno Típico + Jugo de Naranja..............................$5.75 (5)");
                                    desa1 = int.Parse(Console.ReadLine());
                                    if (desa1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el desayuno número" + " " + desa1 + " " + "y su precio es de " + "$" + (7.50 * cant));
                                        preciofinal = preciofinal + (7.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (desa1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el desayuno número" + " " + desa1 + " " + "y su precio es de " + "$" + (6.25 * cant));
                                        preciofinal = preciofinal + (6.25 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (desa1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el desayuno número" + " " + desa1 + " " + "y su precio es de " + "$" + (6.25 * cant));
                                        preciofinal = preciofinal + (6.25 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (desa1 == 4)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el desayuno número" + " " + desa1 + " " + "y su precio es de " + "$" + (5.60 * cant));
                                        preciofinal = preciofinal + (5.60 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (desa1 == 5)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el desayuno número" + " " + desa1 + " " + "y su precio es de " + "$" + (5.75 * cant));
                                        preciofinal = preciofinal + (5.75 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                                //MENU HAMBURGUESAS WENDYS
                                case ("3"):
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine("Big Bacon + Papas Medianas + Soda en lata......................$8.75 (1)");
                                    Console.WriteLine("Melt + Papas Medianas + Soda en lata...........................$8.75 (2)");
                                    Console.WriteLine("Chiliburger + Papas Medianas + Soda en lata....................$7.95 (3)");
                                    Console.WriteLine("Daves Single 1/4 Libra + Papas Medianas + Soda en lata.........$7.95 (4)");
                                    Console.WriteLine("Classic Chicken + Papas Medianas + Soda en Lata................$8.25 (5)");
                                    ham1 = int.Parse(Console.ReadLine());
                                    if (ham1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la hamburguesa número" + " " + ham1 + " " + "y su precio es de " + "$" + (8.75 * cant));
                                        preciofinal = preciofinal + (8.75 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (ham1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la hamburguesa número" + " " + ham1 + " " + "y su precio es de " + "$" + (8.75 * cant));
                                        preciofinal = preciofinal + (8.75 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (ham1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la hamburguesa número" + " " + ham1 + " " + "y su precio es de " + "$" + (7.95 * cant));
                                        preciofinal = preciofinal + (7.95 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (ham1 == 4)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la hamburguesa número" + " " + ham1 + " " + "y su precio es de " + "$" + (7.95 * cant));
                                        preciofinal = preciofinal + (7.95 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (ham1 == 5)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la hamburguesa número" + " " + ham1 + " " + "y su precio es de " + "$" + (8.25 * cant));
                                        preciofinal = preciofinal + (8.25 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                                //MENU SNACKS WENDYS
                                case ("4"):
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine("Papas con Tocino .........$3.50 (1)");
                                    Console.WriteLine("Chili Con Carne Normal....$3.95 (2)");
                                    Console.WriteLine("Chili Cheesy Nachos.......$3.50 (3)");
                                    Console.WriteLine("Papa Tocino...............$4.50 (4)");
                                    Console.WriteLine("Papa Brócoli..............$3.75 (5)");
                                    gourmet1 = int.Parse(Console.ReadLine());
                                    if (gourmet1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el snack número" + " " + gourmet1 + " " + "y su precio es de " + "$" + (3.50 * cant));
                                        preciofinal = preciofinal + (3.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (gourmet1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el snack número" + " " + gourmet1 + " " + "y su precio es de " + "$" + (3.95 * cant));
                                        preciofinal = preciofinal + (3.95 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (gourmet1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el snack número" + " " + gourmet1 + " " + "y su precio es de " + "$" + (3.50 * cant));
                                        preciofinal = preciofinal + (3.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (gourmet1 == 4)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el snack número" + " " + gourmet1 + " " + "y su precio es de " + "$" + (4.50 * cant));
                                        preciofinal = preciofinal + (4.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (gourmet1 == 5)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el snack número" + " " + gourmet1 + " " + "y su precio es de " + "$" + (3.75 * cant));
                                        preciofinal = preciofinal + (3.75 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                                //MENU INFANTIL WENDYS
                                case ("5"):
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine("Kids Nuggets + Papas Kids + Soda en lata + Juguete...............$4.95 (1)");
                                    Console.WriteLine("Kids Quesoburguesa + Papa Kids + Soda en lata + Juguete..........$4.95 (2)");
                                    Console.WriteLine("Kids Jr. Crispy  + Papa Kids + Soda en lata + Juguete............$4.95 (3)");
                                    Console.WriteLine("Kids Hamburguesa + Papas Medianas + Soda en lata + Juguete.......$4.95 (4)");
                                    niños1 = int.Parse(Console.ReadLine());
                                    if (niños1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el menú infantil número" + " " + niños1 + " " + "y su precio es de " + "$" + (4.95 * cant));
                                        preciofinal = preciofinal + (4.95 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (niños1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el menú infantil número" + " " + niños1 + " " + "y su precio es de " + "$" + (4.95 * cant));
                                        preciofinal = preciofinal + (4.95 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (niños1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el menú infantil número" + " " + niños1 + " " + "y su precio es de " + "$" + (4.95 * cant));
                                        preciofinal = preciofinal + (4.95 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (niños1 == 4)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el menú infantil número" + " " + niños1 + " " + "y su precio es de " + "$" + (4.95 * cant));
                                        preciofinal = preciofinal + (4.95 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                                //MENU POSTRES WENDYS
                                case ("6"):
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine("Frosty Vainilla.......$2.25 (1)");
                                    Console.WriteLine("Frosty Chocolate......$2.25 (2)");
                                    Console.WriteLine("Yogurt................$3.50 (3)");
                                    Console.WriteLine("Pie de manzana........$1.75 (4)");
                                    Console.WriteLine("Galletas..............$1.50 (5)");
                                    post1 = int.Parse(Console.ReadLine());
                                    if (post1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el postre número" + " " + post1 + " " + "y su precio es de " + "$" + (2.25 * cant));
                                        preciofinal = preciofinal + (2.25 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (post1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el postre número" + " " + post1 + " " + "y su precio es de " + "$" + (2.25 * cant));
                                        preciofinal = preciofinal + (2.25 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (post1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el postre número" + " " + post1 + " " + "y su precio es de " + "$" + (3.50 * cant));
                                        preciofinal = preciofinal + (3.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (post1 == 4)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el postre número" + " " + post1 + " " + "y su precio es de " + "$" + (1.75 * cant));
                                        preciofinal = preciofinal + (1.75 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (post1 == 5)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el postre número" + " " + post1 + " " + "y su precio es de " + "$" + (1.50 * cant));
                                        preciofinal = preciofinal + (1.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                            }
                        }

                        break;
                    //MENU RED PEPPERS
                    case ("4"):
                        while (p == "Si")
                        {
                            Console.WriteLine("Bienvenido al menú de Red Peppers, ¿Qué desea ordenar?");
                            Console.WriteLine("Promociones (1)      Individuales   (2)   Hamburguesas (3)");
                            men1 = Console.ReadLine();
                            switch (men1)
                            {
                                //MENU PROMOCIONES RED PEPPERS
                                case ("1"):
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine("2 Tocino + 1 Jalapeño + 1 Hongos + 4 papas + Soda .......$24.50 (1)");
                                    Console.WriteLine("Double Big + Tocino + Hongos + 3 Papas + Soda............$22.50 (2)");
                                    Console.WriteLine("Tocino + Hongos + Jalapeño + 3 Papas + Soda..............$20.50 (3)");
                                    comb1 = int.Parse(Console.ReadLine());
                                    if (comb1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la promoción número" + " " + comb1 + " " + "y su precio es de " + "$" + (24.50 * cant));
                                        preciofinal = preciofinal + (24.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la promoción número" + " " + comb1 + " " + "y su precio es de " + "$" + (22.50 * cant));
                                        preciofinal = preciofinal + (22.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la promoción número" + " " + comb1 + " " + "y su precio es de " + "$" + (20.50 * cant));
                                        preciofinal = preciofinal + (20.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                                //MENU INDIVIDUALES RED PEPPERS
                                case ("2"):
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine("Hamburguesa Doble Jr.............$4.50 (1)");
                                    Console.WriteLine("Hamburguesa con Tocino...........$5.00 (2)");
                                    Console.WriteLine("Hamburguesa con Hongos...........$5.00 (3)");
                                    Console.WriteLine("Hamburguesa con Jalapeño.........$5.25 (4)");
                                    Console.WriteLine("Mega Burguer.....................$6.40 (5)");
                                    desa1 = int.Parse(Console.ReadLine());
                                    if (desa1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el menú individual número" + " " + desa1 + " " + "y su precio es de " + "$" + (4.50 * cant));
                                        preciofinal = preciofinal + (4.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (desa1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el menú individual número" + " " + desa1 + " " + "y su precio es de " + "$" + (5 * cant));
                                        preciofinal = preciofinal + (5 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (desa1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el menú individual número" + " " + desa1 + " " + "y su precio es de " + "$" + (5 * cant));
                                        preciofinal = preciofinal + (5 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (desa1 == 4)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el menú individual número" + " " + desa1 + " " + "y su precio es de " + "$" + (5.25 * cant));
                                        preciofinal = preciofinal + (5.25 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (desa1 == 5)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el menú individual número" + " " + desa1 + " " + "y su precio es de " + "$" + (6.40 * cant));
                                        preciofinal = preciofinal + (6.40 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                                //MENU HAMBURGUESAS RED PEPPERS
                                case ("3"):
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine("Combo Junior + Papas + Soda.............$5.00 (1)");
                                    Console.WriteLine("Combo Tocino + Papas + Soda.............$6.50 (2)");
                                    Console.WriteLine("Combo Hongos + Papas + Soda.............$6.50 (3)");
                                    Console.WriteLine("Combo Jalapeños + Papas + Soda .........$6.50 (4)");
                                    Console.WriteLine("Combo Mega Burger + Papas + Soda........$7.50 (5)");
                                    ham1 = int.Parse(Console.ReadLine());
                                    if (ham1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la hamburguesa número" + " " + ham1 + " " + "y su precio es de " + "$" + (5 * cant));
                                        preciofinal = preciofinal + (5 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (ham1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la hamburguesa número" + " " + ham1 + " " + "y su precio es de " + "$" + (6.50 * cant));
                                        preciofinal = preciofinal + (6.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (ham1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la hamburguesa número" + " " + ham1 + " " + "y su precio es de " + "$" + (6.50 * cant));
                                        preciofinal = preciofinal + (6.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (ham1 == 4)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la hamburguesa número" + " " + ham1 + " " + "y su precio es de " + "$" + (6.50 * cant));
                                        preciofinal = preciofinal + (6.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (ham1 == 5)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la hamburguesa número" + " " + ham1 + " " + "y su precio es de " + "$" + (7.50 * cant));
                                        preciofinal = preciofinal + (7.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;

                            }
                        }
                        break;
                    //MENU EL PLACE
                    case ("5"):
                        while (p == "Si")
                        {
                            Console.WriteLine("Bienvenido al menú de El Place, ¿Qué desea ordenar?");
                            Console.WriteLine("Entradas (1)      Tacos   (2)   Hamburguesas (3)");
                            Console.WriteLine("              Platos Fuertes (4)          ");
                            men1 = Console.ReadLine();
                            switch (men1)
                            {
                                //MENU ENTRADAS ELPLACE
                                case ("1"):
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine("Papas Fritas..............$4.25 (1)");
                                    Console.WriteLine("Aros de Cebolla...........$7.25 (2)");
                                    Console.WriteLine("Papas con Chorizo.........$8.50 (3)");
                                    comb1 = int.Parse(Console.ReadLine());
                                    if (comb1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la entrada número" + " " + comb1 + " " + "y su precio es de " + "$" + (4.25 * cant));
                                        preciofinal = preciofinal + (4.25 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la entrada número" + " " + comb1 + " " + "y su precio es de " + "$" + (7.25 * cant));
                                        preciofinal = preciofinal + (7.25 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la entrada número" + " " + comb1 + " " + "y su precio es de " + "$" + (8.50 * cant));
                                        preciofinal = preciofinal + (8.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                                //MENU TACOS ELPLACE
                                case ("2"):
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine("4 Tacos de Carnita...............................$7.25 (1)");
                                    Console.WriteLine("4 Tacos de Camarones.............................$9.50 (2)");
                                    desa1 = int.Parse(Console.ReadLine());
                                    if (desa1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado los tacos número" + " " + desa1 + " " + "y su precio es de " + "$" + (7.25 * cant));
                                        preciofinal = preciofinal + (7.25 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (desa1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado los tacos número" + " " + desa1 + " " + "y su precio es de " + "$" + (9.50 * cant));
                                        preciofinal = preciofinal + (9.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                                //MENU HAMBURGUESAS ELPLACE
                                case ("3"):
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine("Clásica de Res + Papas.............$8.25  (1)");
                                    Console.WriteLine("Quesillo Bacon + Papas.............$10.50 (2)");
                                    Console.WriteLine("Spicy Costilla BBQ + Papas.........$10.50 (3)");
                                    Console.WriteLine("Surfer + Papas.....................$10.95 (4)");
                                    Console.WriteLine("1/2 Libra + Papas..................$10.95 (5)");
                                    ham1 = int.Parse(Console.ReadLine());
                                    if (ham1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la hamburguesa número" + " " + ham1 + " " + "y su precio es de " + "$" + (8.25 * cant));
                                        preciofinal = preciofinal + (8.25 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (ham1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la hamburguesa número" + " " + ham1 + " " + "y su precio es de " + "$" + (10.50 * cant));
                                        preciofinal = preciofinal + (10.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (ham1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la hamburguesa número" + " " + ham1 + " " + "y su precio es de " + "$" + (10.50 * cant));
                                        preciofinal = preciofinal + (10.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (ham1 == 4)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la hamburguesa número" + " " + ham1 + " " + "y su precio es de " + "$" + (10.95 * cant));
                                        preciofinal = preciofinal + (10.95 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (ham1 == 5)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la hamburguesa número" + " " + ham1 + " " + "y su precio es de " + "$" + (10.95 * cant));
                                        preciofinal = preciofinal + (10.95 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                                //PLATOS FUERTES ELPLACE
                                case ("4"):
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine("Churrasco Típico + Frijoles + Papas Horneadas + 2 Tortillas.........$13.80 (1)");
                                    Console.WriteLine("Puyaso + Camarones Salteados + Papas Horneadas + 2 Tortillas........$15.50 (2)");
                                    Console.WriteLine("Trocitos de Pechuga Empanizados.....................................$7.25  (3)");
                                    niños1 = int.Parse(Console.ReadLine());
                                    if (niños1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el plato fuerte número" + " " + niños1 + " " + "y su precio es de " + "$" + (13.80 * cant));
                                        preciofinal = preciofinal + (13.80 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (niños1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el plato fuerte número" + " " + niños1 + " " + "y su precio es de " + "$" + (15.50 * cant));
                                        preciofinal = preciofinal + (15.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (niños1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el plato fuerte número" + " " + niños1 + " " + "y su precio es de " + "$" + (7.25 * cant));
                                        preciofinal = preciofinal + (7.25 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                            }
                        }
                        break;
                    //MENU DENNNYS
                    case ("6"):
                        while (p == "Si")
                        {
                            Console.WriteLine("Bienvenido al menú de Denny´s, ¿Qué desea ordenar?");
                            Console.WriteLine("  Aperitivos    (1)      Desayunos   (2)   Hamburguesas (3)");
                            Console.WriteLine("Platos Fuertes  (4)      Fit Fare    (5)      Extras    (6)");
                            men1 = Console.ReadLine();
                            switch (men1)
                            {
                                //MENU APERITIVOS DENNYS
                                case ("1"):
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine("Zesty Nachos................................$11.50 (1)");
                                    Console.WriteLine("Smothered Cheese Fries......................$7.75  (2)");
                                    Console.WriteLine("Mozzarella Cheese Sticks....................$7.25  (3)");
                                    Console.WriteLine("Chicken Boneless ...........................$10.00 (4)");
                                    Console.WriteLine("Grilled Chicken & Sausage Quesadilla........$10.50 (5)");
                                    comb1 = int.Parse(Console.ReadLine());
                                    if (comb1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el aperitivo número" + " " + comb1 + " " + "y su precio es de " + "$" + (11.50 * cant));
                                        preciofinal = preciofinal + (11.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el aperitivo número" + " " + comb1 + " " + "y su precio es de " + "$" + (7.75 * cant));
                                        preciofinal = preciofinal + (7.75 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el aperitivo número" + " " + comb1 + " " + "y su precio es de " + "$" + (7.25 * cant));
                                        preciofinal = preciofinal + (7.25 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 4)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el aperitivo número" + " " + comb1 + " " + "y su precio es de " + "$" + (10 * cant));
                                        preciofinal = preciofinal + (10 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 5)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el aperitivo número" + " " + comb1 + " " + "y su precio es de " + "$" + (10.50 * cant));
                                        preciofinal = preciofinal + (10.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                                //MENU DESAYUNOS DENNYS
                                case ("2"):
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine("2 Huevos + Plátano + Frijoles + Tortillas/Pan + Crema .......................$8.75 (1)");
                                    Console.WriteLine("3 Huevos + Tocino + Salchichas + Hashbrowns + Pan ...........................$9.50 (2)");
                                    Console.WriteLine("Sandwich de Tocino, Huevos, Jamón, Queso + Hashbrowns........................$10.75 (3)");
                                    Console.WriteLine("2 Pancakes con Arándanos azules + Huevos + Tocino + Hashbrown................$9.50 (4)");
                                    Console.WriteLine("2 Pancakes + Jamón + Tocino + Salchichas + Huevos + Hashbrowns + Pan.........$11.75 (5)");
                                    desa1 = int.Parse(Console.ReadLine());
                                    if (desa1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el desayuno número" + " " + desa1 + " " + "y su precio es de " + "$" + (8.75 * cant));
                                        preciofinal = preciofinal + (8.75 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (desa1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el desayuno número" + " " + desa1 + " " + "y su precio es de " + "$" + (9.50 * cant));
                                        preciofinal = preciofinal + (9.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (desa1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el desayuno número" + " " + desa1 + " " + "y su precio es de " + "$" + (10.75 * cant));
                                        preciofinal = preciofinal + (10.75 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (desa1 == 4)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el desayuno número" + " " + desa1 + " " + "y su precio es de " + "$" + (9.50 * cant));
                                        preciofinal = preciofinal + (9.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (desa1 == 5)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el desayuno número" + " " + desa1 + " " + "y su precio es de " + "$" + (11.75 * cant));
                                        preciofinal = preciofinal + (11.75 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                                //MENU HAMBURGUESAS DENNYS
                                case ("3"):
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine("Classic Cheeseburger + Papas ..............$10.25 (1)");
                                    Console.WriteLine("All American Diner Double + Papas..........$13.75 (2)");
                                    Console.WriteLine("Bacon Slamburger + Papas...................$11.50 (3)");
                                    Console.WriteLine("Double Cheeseburger + Papas................$13.75 (4)");
                                    Console.WriteLine("Chicken Bacon Classic + Papas..............$10.75 (5)");
                                    ham1 = int.Parse(Console.ReadLine());
                                    if (ham1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la hamburguesa número" + " " + ham1 + " " + "y su precio es de " + "$" + (10.25 * cant));
                                        preciofinal = preciofinal + (10.25 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (ham1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la hamburguesa número" + " " + ham1 + " " + "y su precio es de " + "$" + (13.75 * cant));
                                        preciofinal = preciofinal + (13.75 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (ham1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la hamburguesa número" + " " + ham1 + " " + "y su precio es de " + "$" + (11.50 * cant));
                                        preciofinal = preciofinal + (11.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (ham1 == 4)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la hamburguesa número" + " " + ham1 + " " + "y su precio es de " + "$" + (13.75 * cant));
                                        preciofinal = preciofinal + (13.75 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (ham1 == 5)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la hamburguesa número" + " " + ham1 + " " + "y su precio es de " + "$" + (10.75 * cant));
                                        preciofinal = preciofinal + (10.75 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                                //MENU PLATOS FUERTES DENNYS
                                case ("4"):
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine("2 Pechugas de Pollo cubierta con BBQ + Puré de Papas + Pan de Ajo.....................$12.25 (1)");
                                    Console.WriteLine("California Steak + Acompañamientos + Pan de Ajo ......................................$17.75 (2)");
                                    Console.WriteLine("5 onz Churrasco + 5 onz Pollo + Chorizo + Arroz + Chimichurri + Tortillas.............$16.75 (3)");
                                    Console.WriteLine("Steak + Pollo + Cebollas Asadas + Tocino + Hasbrowns + Queso Cheddar Derretido........$12.25 (4)");
                                    Console.WriteLine("Pechuga Pollo + Glasado Bourbon + Champiñones + Pimientos + Brócoli + Papas...........$13.75 (5)");
                                    gourmet1 = int.Parse(Console.ReadLine());
                                    if (gourmet1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el plato fuerte número" + " " + gourmet1 + " " + "y su precio es de " + "$" + (12.25 * cant));
                                        preciofinal = preciofinal + (12.25 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (gourmet1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el plato fuerte número" + " " + gourmet1 + " " + "y su precio es de " + "$" + (17.75 * cant));
                                        preciofinal = preciofinal + (17.75 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (gourmet1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el plato fuerte número" + " " + gourmet1 + " " + "y su precio es de " + "$" + (16.75 * cant));
                                        preciofinal = preciofinal + (16.75 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (gourmet1 == 4)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el plato fuerte número" + " " + gourmet1 + " " + "y su precio es de " + "$" + (12.25 * cant));
                                        preciofinal = preciofinal + (12.25 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (gourmet1 == 5)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el plato fuerte número" + " " + gourmet1 + " " + "y su precio es de " + "$" + (13.75 * cant));
                                        preciofinal = preciofinal + (13.75 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                                //MENU FIT FARE DENNYS
                                case ("5"):
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine("Chicken Loaded Potato Skillet..........$11.00 (1)");
                                    Console.WriteLine("Huevo + Tocino + Muffin + Fruta........$7.75  (2)");
                                    Console.WriteLine("Turkey Omelette........................$10.50 (3)");
                                    Console.WriteLine("Chicken Avocado Sandwich ..............$10.00 (4)");
                                    Console.WriteLine("Fit Fare Veggie Skillet................$9.00  (5)");
                                    niños1 = int.Parse(Console.ReadLine());
                                    if (niños1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el fit fare número" + " " + niños1 + " " + "y su precio es de " + "$" + (11 * cant));
                                        preciofinal = preciofinal + (11 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (niños1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el fit fare número" + " " + niños1 + " " + "y su precio es de " + "$" + (7.75 * cant));
                                        preciofinal = preciofinal + (7.75 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (niños1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el fit fare número" + " " + niños1 + " " + "y su precio es de " + "$" + (10.50 * cant));
                                        preciofinal = preciofinal + (10.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (niños1 == 4)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el fit fare número" + " " + niños1 + " " + "y su precio es de " + "$" + (10 * cant));
                                        preciofinal = preciofinal + (10 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (niños1 == 5)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el fit fare número" + " " + niños1 + " " + "y su precio es de " + "$" + (9 * cant));
                                        preciofinal = preciofinal + (9 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                                //MENU EXTRAS DENNYS
                                case ("6"):
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine("New York Style Cheesecake......$6.75 (1)");
                                    Console.WriteLine("Pancake Puppies..........$6.75 (2)");
                                    Console.WriteLine("Bolsa de Café Dark Roast.....$7.50 (3)");
                                    post1 = int.Parse(Console.ReadLine());
                                    if (post1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el extra número" + " " + post1 + " " + "y su precio es de " + "$" + (6.75 * cant));
                                        preciofinal = preciofinal + (6.75 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (post1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el extra número" + " " + post1 + " " + "y su precio es de " + "$" + (6.75 * cant));
                                        preciofinal = preciofinal + (6.75 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (post1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el extra número" + " " + post1 + " " + "y su precio es de " + "$" + (7.50 * cant));
                                        preciofinal = preciofinal + (7.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                            }
                        }
                        break;
                }
                break;
            //MENU PIZZAS
            case ("2"):
                Console.WriteLine("Qué restaurante desea ordenar");
                Console.WriteLine("Pizza Hut  (1)    Papa John's  (2)    Little Caesars (3)");
                Console.WriteLine(" Domino´s  (4)    Simmer Down  (5)      Inna Jammin  (6)");
                ham = Console.ReadLine();
                switch (ham)
                {
                    //MENU PIZZA HUT
                    case ("1"):
                        while (p == "Si")
                        {
                            Console.WriteLine("Bienvenido al menú de Pizza Hut, ¿Qué desea ordenar?");
                            Console.WriteLine("Combos (1)      Desayunos   (2)       Pizzas  (3)");
                            Console.WriteLine("Pastas (4)      Ensaladas   (5)     Banquetes (6)");
                            Console.WriteLine("       Entradas (7)           Postres (8)");
                            men1 = Console.ReadLine();
                            switch (men1)
                            {
                                //MENU PROMOCIONES PIZZA HUT
                                case ("1"):
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine("Pizza Rectangular + Palitroques Personales + Soda Lata.................$6.25 (1)");
                                    Console.WriteLine("Combo Melts Personal + Soda Lata.......................................$7.25 (2)");
                                    Console.WriteLine("Pan Pizza Super Personal de 1 ingrediente Masa Pan + Soda Lata.........$8.25  (3)");
                                    Console.WriteLine("Pizza Super Personal de especialidad Masa Extra Crispy + Soda Lata.....$9.25 (4)");
                                    Console.WriteLine("My Box con Orilla Cheddar Gold + Alitas + Soda.........................$7.50 (5)");
                                    comb1 = int.Parse(Console.ReadLine());
                                    if (comb1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el combo número" + " " + comb1 + " " + "y su precio es de " + "$" + (6.25 * cant));
                                        preciofinal = preciofinal + (6.25 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el combo número" + " " + comb1 + " " + "y su precio es de " + "$" + (7.25 * cant));
                                        preciofinal = preciofinal + (7.25 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el combo número" + " " + comb1 + " " + "y su precio es de " + "$" + (8.25 * cant));
                                        preciofinal = preciofinal + (8.25 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 4)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el combo número" + " " + comb1 + " " + "y su precio es de " + "$" + (9.25 * cant));
                                        preciofinal = preciofinal + (9.25 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 5)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el combo número" + " " + comb1 + " " + "y su precio es de " + "$" + (7.50 * cant));
                                        preciofinal = preciofinal + (7.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                                //MENU DESAYUNOS PIZZA HUT
                                case ("2"):
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine("3 huevos, 2 pancakes, 2 tiras de tocino, 1 salchicha americana, acompañado de salsa ranchera y miel de maple.......$8.99 (1)");
                                    Console.WriteLine("2 huevos, frijoles fritos, queso mantequilla, rigua con crema, acompañado de pan y salsa ranchera..................$8.99 (2)");
                                    Console.WriteLine("Omellete All American Ham y Cheese, acompañado de salsa ranchera y tostadas de pan blanco..........................$7.99 (3)");
                                    Console.WriteLine("Pancakes de vainilla con Miel y Almendras..........................................................................$4.25 (4)");
                                    Console.WriteLine("Waffles de vainilla con Miel y Almendras...........................................................................$4.25 (5)");
                                    desa1 = int.Parse(Console.ReadLine());
                                    if (desa1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el desayuno número" + " " + desa1 + " " + "y su precio es de " + "$" + (8.99 * cant));
                                        preciofinal = preciofinal + (8.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (desa1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el desayuno número" + " " + desa1 + " " + "y su precio es de " + "$" + (8.99 * cant));
                                        preciofinal = preciofinal + (8.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (desa1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el desayuno número" + " " + desa1 + " " + "y su precio es de " + "$" + (7.99 * cant));
                                        preciofinal = preciofinal + (7.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (desa1 == 4)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el desayuno número" + " " + desa1 + " " + "y su precio es de " + "$" + (4.25 * cant));
                                        preciofinal = preciofinal + (4.25 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (desa1 == 5)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el desayuno número" + " " + desa1 + " " + "y su precio es de " + "$" + (4.25 * cant));
                                        preciofinal = preciofinal + (4.25 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                                //MENU PIZZAS PIZZA HUT
                                case ("3"):
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine("Pizza de 12 Porciones de Pepperoni, carne, tocino, jamón Virginia y queso Mozzarella.................$17.50 (1)");
                                    Console.WriteLine("Pizza de 12 Porciones de Mezcla de quesos Mozzarella, Provolone, Parmesano fresco y queso crema......$17.50 (2)");
                                    Console.WriteLine("Pizza de 8 Porciones de Jamón con Orilla de Queso....................................................$17.50 (3)");
                                    Console.WriteLine("Pizza Extra Crispy de 12 Porciones de Pepperoni .....................................................$15.50 (4)");
                                    Console.WriteLine("Pizza de 12 Porciones Hawaiana con Tocino ...........................................................$17.50 (5)");
                                    ham1 = int.Parse(Console.ReadLine());
                                    if (ham1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la pizza número" + " " + ham1 + " " + "y su precio es de " + "$" + (17.50 * cant));
                                        preciofinal = preciofinal + (17.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (ham1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la pizza número" + " " + ham1 + " " + "y su precio es de " + "$" + (17.50 * cant));
                                        preciofinal = preciofinal + (17.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (ham1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la pizza número" + " " + ham1 + " " + "y su precio es de " + "$" + (17.50 * cant));
                                        preciofinal = preciofinal + (17.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (ham1 == 4)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la pizza número" + " " + ham1 + " " + "y su precio es de " + "$" + (15.50 * cant));
                                        preciofinal = preciofinal + (15.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (ham1 == 5)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la pizza número" + " " + ham1 + " " + "y su precio es de " + "$" + (17.50 * cant));
                                        preciofinal = preciofinal + (17.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                                //MENU PASTAS PIZZA
                                case ("4"):
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine("Lasagna rellena de carne, bañada en salsa bolognesa casera y queso derretido + Nudos Ajo...............$9.50 (1)");
                                    Console.WriteLine("Pasta Rotini en salsa alfredo, vegetales, pechuga de pollo marinada y queso gratinado + Nudos Ajo......$7.95 (2)");
                                    Console.WriteLine("Mezcla de pastas cortas con pechuga de pollo y brócoli, bañadas con una salsa blanca + Nudos Ajo.......$7.95 (3)");
                                    gourmet1 = int.Parse(Console.ReadLine());
                                    if (gourmet1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la pasta número" + " " + gourmet1 + " " + "y su precio es de " + "$" + (9.50 * cant));
                                        preciofinal = preciofinal + (9.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (gourmet1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la pasta número" + " " + gourmet1 + " " + "y su precio es de " + "$" + (7.95 * cant));
                                        preciofinal = preciofinal + (7.95 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (gourmet1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la pasta número" + " " + gourmet1 + " " + "y su precio es de " + "$" + (7.95 * cant));
                                        preciofinal = preciofinal + (7.95 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                                //MENU ENSALADAS PIZZA HUT
                                case ("5"):
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine("Pollo, frijoles, queso cheddar, elote spicy, tortillas de maíz, pico de gallo y aderezo Chipotle Ranch..............$8.95 (1)");
                                    Console.WriteLine("Pollo, tocino, tomate cherry, pepino, aguacate, queso Cheddar, queso fresco marinado en especias y aderezo Ranch....$8.95 (2)");
                                    Console.WriteLine("Pollo sobre lechuga Romana, tomate cherry, crutones, queso Parmesano y aguacate con aderezo César...................$8.95 (3)");
                                    Console.WriteLine("Ensalada con mezcla de lechugas, Kale, pollo, pepperoncini, tomate cherry, aceitunas negras y aderezo italiano......$8.95 (4)");
                                    Console.WriteLine("Lechugas, kale, pollo, pimientos rojos, queso cheddar, piña asada, chips, pepino y aderezo mango habanero...........$8.95 (5)");
                                    niños1 = int.Parse(Console.ReadLine());
                                    if (niños1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la ensalada número" + " " + niños1 + " " + "y su precio es de " + "$" + (8.95 * cant));
                                        preciofinal = preciofinal + (8.95 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (niños1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la ensalada número" + " " + niños1 + " " + "y su precio es de " + "$" + (8.95 * cant));
                                        preciofinal = preciofinal + (8.95 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (niños1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la ensalada número" + " " + niños1 + " " + "y su precio es de " + "$" + (8.95 * cant));
                                        preciofinal = preciofinal + (8.95 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (niños1 == 4)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la ensalada número" + " " + niños1 + " " + "y su precio es de " + "$" + (8.95 * cant));
                                        preciofinal = preciofinal + (8.95 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (niños1 == 5)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la ensalada número" + " " + niños1 + " " + "y su precio es de " + "$" + (8.95 * cant));
                                        preciofinal = preciofinal + (8.95 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                                //MENU BANQUETES PIZZA HUT
                                case ("6"):
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine("2 Pizza Grande masa Tradicional + 6 Palitroques + 9 Nuditos de Ajo......$22.50 (1)");
                                    Console.WriteLine("Pizza 10 Porciones + Pepperoni Bites....................................$19.50 (2)");
                                    Console.WriteLine("Banquete Hut Cheese ingrediente + Palitroques...........................$18.50 (3)");
                                    Console.WriteLine("Pizza Gigante de 10 porciones + 10 Alitas...............................$27.95 (4)");
                                    post1 = int.Parse(Console.ReadLine());
                                    if (post1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el banquete número" + " " + post1 + " " + "y su precio es de " + "$" + (22.50 * cant));
                                        preciofinal = preciofinal + (22.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (post1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el banquete número" + " " + post1 + " " + "y su precio es de " + "$" + (19.50 * cant));
                                        preciofinal = preciofinal + (19.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (post1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el banquete número" + " " + post1 + " " + "y su precio es de " + "$" + (18.50 * cant));
                                        preciofinal = preciofinal + (18.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (post1 == 4)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el desayuno número" + " " + post1 + " " + "y su precio es de " + "$" + (27.95 * cant));
                                        preciofinal = preciofinal + (27.95 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                                //MENU ENTRADAS PIZZA HUT
                                case ("7"):
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine("5 Palitroques.............$3.00 (1)");
                                    Console.WriteLine("5 Hut cheese Dippers......$3.99 (2)");
                                    Console.WriteLine("4 Pan con Ajo Supremo.....$5.00 (3)");
                                    Console.WriteLine("8 Nuditos de Ajo..........$4.00 (4)");
                                    post1 = int.Parse(Console.ReadLine());
                                    if (post1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la entrada número" + " " + post1 + " " + "y su precio es de " + "$" + (3 * cant));
                                        preciofinal = preciofinal + (3 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (post1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la entrada número" + " " + post1 + " " + "y su precio es de " + "$" + (3.99 * cant));
                                        preciofinal = preciofinal + (3.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (post1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la entrada número" + " " + post1 + " " + "y su precio es de " + "$" + (5 * cant));
                                        preciofinal = preciofinal + (5 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (post1 == 4)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la entrada número" + " " + post1 + " " + "y su precio es de " + "$" + (4 * cant));
                                        preciofinal = preciofinal + (4 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                                //MENU POSTRES PIZZA HUT
                                case ("8"):
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine("10 Cinnamon Sticks......$2.50 (1)");
                                    Console.WriteLine("9 Rollos de Canela......$4.00 (2)");
                                    Console.WriteLine("Tres Leches.............$5.75 (3)");
                                    post1 = int.Parse(Console.ReadLine());
                                    if (post1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el postre número" + " " + post1 + " " + "y su precio es de " + "$" + (22.50 * cant));
                                        preciofinal = preciofinal + (22.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (post1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el postre número" + " " + post1 + " " + "y su precio es de " + "$" + (19.50 * cant));
                                        preciofinal = preciofinal + (19.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (post1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el postre número" + " " + post1 + " " + "y su precio es de " + "$" + (18.50 * cant));
                                        preciofinal = preciofinal + (18.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                            }
                        }
                        break;
                    //MENU PAPA JOHNS
                    case ("2"):
                        while (p == "Si")
                        {
                            Console.WriteLine("Bienvenido al menú de Papa John´s, ¿Qué desea ordenar?");
                            Console.WriteLine("Promociones (1)      Pastas   (2)       Pizzas  (3)");
                            Console.WriteLine(" Papadias   (4)     Entradas  (5)       Postres (6)");
                            men1 = Console.ReadLine();
                            switch (men1)
                            {
                                //MENU PROMOCIONES PAPA JOHNS
                                case ("1"):
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine("Pizza Gigante especialidad + Cheesesticks...................................$17.50 (1)");
                                    Console.WriteLine("Pizza Gigante de Ingrediente + Soda 1.25 lt.................................$15.50 (2)");
                                    Console.WriteLine("Pizza grande Orilla Rellena de queso y garlic parmesan de un ingrediente....$10.99  (3)");
                                    comb1 = int.Parse(Console.ReadLine());
                                    if (comb1 == 1)
                                    {
                                        Console.WriteLine("Que especialidad desea la Pizza");
                                        Console.WriteLine("The Works  (1)   New York  (2)   Vegetariana (3)");
                                        Console.WriteLine("Canadiense (4)   Mexicana  (5)    Hawaiana   (6)");
                                        pizza = int.Parse(Console.ReadLine());
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la promoción número" + " " + comb1 + " " + "y el ingrediente número" + " " + pizza + " " + "y su precio es de " + "$" + (17.50 * cant));
                                        preciofinal = preciofinal + (17.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 2)
                                    {
                                        Console.WriteLine("Que especialidad desea la Pizza");
                                        Console.WriteLine(" Jamón   (1)   Tocino   (2)    Carne (3)");
                                        Console.WriteLine("3 Quesos (4)  Salchicha (5)    Pollo (6)");
                                        pizza = int.Parse(Console.ReadLine());
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la promoción número" + " " + comb1 + " " + "y el ingrediente número" + " " + pizza + " " + "y su precio es de " + "$" + (15.50 * cant));
                                        preciofinal = preciofinal + (15.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 3)
                                    {
                                        Console.WriteLine("Que especialidad desea la Pizza");
                                        Console.WriteLine(" Jamón   (1)   Tocino   (2)    Carne (3)");
                                        Console.WriteLine("3 Quesos (4)  Salchicha (5)    Pollo (6)");
                                        pizza = int.Parse(Console.ReadLine());
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la promoción número" + " " + comb1 + " " + "y el ingrediente número" + " " + pizza + " " + "y su precio es de " + "$" + (10.99 * cant));
                                        preciofinal = preciofinal + (10.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                                //MENU PASTAS PAPA JOHNS
                                case ("2"):
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine("Pasta Pollo Tocino + Nudos Ajo...........$5.99 (1)");
                                    Console.WriteLine("Pasta Creamy 5 Cheese + Nudos Ajo........$5.99 (2)");
                                    Console.WriteLine("Pasta Garlic Parmesan + Nudos Ajo........$5.99 (3)");
                                    Console.WriteLine("Pasta Beef & Bacon + Nudos Ajo...........$4.89 (4)");
                                    desa1 = int.Parse(Console.ReadLine());
                                    if (desa1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la pasta número" + " " + desa1 + " " + "y su precio es de " + "$" + (5.99 * cant));
                                        preciofinal = preciofinal + (5.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (desa1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la pasta número" + " " + desa1 + " " + "y su precio es de " + "$" + (5.99 * cant));
                                        preciofinal = preciofinal + (5.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (desa1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la pasta número" + " " + desa1 + " " + "y su precio es de " + "$" + (5.99 * cant));
                                        preciofinal = preciofinal + (5.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (desa1 == 4)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la pasta número" + " " + desa1 + " " + "y su precio es de " + "$" + (5.99 * cant));
                                        preciofinal = preciofinal + (5.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                                //MENU PIZZAS PAPA JOHNS
                                case ("3"):
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine("Salchica Italiana, chile verde, cebolla jamón y pepperoni......................................$16.99 (1)");
                                    Console.WriteLine("Pollo a la parrilla, piña, tocino, cebolla , queso Mozzarella y salsa BBQ......................$17.99 (2)");
                                    Console.WriteLine("Pepperoni, salchicha italiana, hongos, aceitunas negras y orégano..............................$16.99 (3)");
                                    Console.WriteLine("Salsa de pizza, cebolla, chile verde, hongos, aceitunas negras, tomates y queso mozzarella.....$16.99 (4)");
                                    Console.WriteLine("Pepperoni, jamón y hongos......................................................................$16.99 (5)");
                                    Console.WriteLine("Jamón, Tocino, hongos y tomate.................................................................$17.99 (6)");
                                    Console.WriteLine("Pollo a la parrilla, jalapeño, tomates, Hongos y chile verde...................................$16.99 (7)");
                                    ham1 = int.Parse(Console.ReadLine());
                                    if (ham1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la pizza número" + " " + ham1 + " " + "y su precio es de " + "$" + (16.99 * cant));
                                        preciofinal = preciofinal + (16.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (ham1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la pizza número" + " " + ham1 + " " + "y su precio es de " + "$" + (17.99 * cant));
                                        preciofinal = preciofinal + (17.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (ham1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la pizza número" + " " + ham1 + " " + "y su precio es de " + "$" + (16.99 * cant));
                                        preciofinal = preciofinal + (16.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (ham1 == 4)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la pizza número" + " " + ham1 + " " + "y su precio es de " + "$" + (16.99 * cant));
                                        preciofinal = preciofinal + (16.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (ham1 == 5)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la pizza número" + " " + ham1 + " " + "y su precio es de " + "$" + (16.99 * cant));
                                        preciofinal = preciofinal + (16.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (ham1 == 6)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la pizza número" + " " + ham1 + " " + "y su precio es de " + "$" + (17.99 * cant));
                                        preciofinal = preciofinal + (17.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (ham1 == 7)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la pizza número" + " " + ham1 + " " + "y su precio es de " + "$" + (16.99 * cant));
                                        preciofinal = preciofinal + (16.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                                //MENU PAPADIAS PAPA JONHS
                                case ("4"):
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine("Papadia Chicken BBQ......................$5.99 (1)");
                                    Console.WriteLine("Papadia Chessy Veggie Ranch..............$5.99 (2)");
                                    Console.WriteLine("Papadia Jamón y Hongos...................$5.99 (3)");
                                    Console.WriteLine("Papadia Pepperoni y Salchicha Italiana...$5.99 (3)");
                                    gourmet1 = int.Parse(Console.ReadLine());
                                    if (gourmet1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la papadia número" + " " + gourmet1 + " " + "y su precio es de " + "$" + (5.99 * cant));
                                        preciofinal = preciofinal + (5.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (gourmet1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la papadia número" + " " + gourmet1 + " " + "y su precio es de " + "$" + (5.99 * cant));
                                        preciofinal = preciofinal + (5.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (gourmet1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la papadia número" + " " + gourmet1 + " " + "y su precio es de " + "$" + (5.99 * cant));
                                        preciofinal = preciofinal + (5.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (gourmet1 == 4)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la papadia número" + " " + gourmet1 + " " + "y su precio es de " + "$" + (5.99 * cant));
                                        preciofinal = preciofinal + (5.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                                //MENU ENTRADAS PAPA JOHNS
                                case ("5"):
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine("Cheesesticks..........$4.95 (1)");
                                    Console.WriteLine("Garlic Knots..........$3.95 (2)");
                                    Console.WriteLine("Papa Rolls............$4.95 (3)");
                                    Console.WriteLine("Palitos Parm. Ajo.....$4.95 (4)");
                                    Console.WriteLine("Alitas De Pollo.......$6.99 (5)");
                                    Console.WriteLine("Chicken Poppers.......$8.99 (6)");
                                    niños1 = int.Parse(Console.ReadLine());
                                    if (niños1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la entrada número" + " " + niños1 + " " + "y su precio es de " + "$" + (4.95 * cant));
                                        preciofinal = preciofinal + (4.95 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (niños1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la entrada número" + " " + niños1 + " " + "y su precio es de " + "$" + (3.95 * cant));
                                        preciofinal = preciofinal + (3.95 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (niños1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la entrada número" + " " + niños1 + " " + "y su precio es de " + "$" + (4.95 * cant));
                                        preciofinal = preciofinal + (4.95 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (niños1 == 4)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la entrada número" + " " + niños1 + " " + "y su precio es de " + "$" + (4.95 * cant));
                                        preciofinal = preciofinal + (4.39 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (niños1 == 5)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la entrada número" + " " + niños1 + " " + "y su precio es de " + "$" + (6.99 * cant));
                                        preciofinal = preciofinal + (6.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (niños1 == 6)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la entrada número" + " " + niños1 + " " + "y su precio es de " + "$" + (8.99 * cant));
                                        preciofinal = preciofinal + (8.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                                //MENU POSTRES PAPA JOHNS
                                case ("6"):
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine("Banana Cinnapie.........$6.95 (1)");
                                    Console.WriteLine("Cinnamon Knots..........$3.95 (2)");
                                    Console.WriteLine("Cinnamons Rolls.........$4.95 (3)");
                                    Console.WriteLine("Choco Chip Cookie.......$5.50 (4)");
                                    Console.WriteLine("Cinnapie................$6.95 (5)");
                                    post1 = int.Parse(Console.ReadLine());
                                    if (post1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el postre número" + " " + post1 + " " + "y su precio es de " + "$" + (6.95 * cant));
                                        preciofinal = preciofinal + (6.95 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (post1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el postre número" + " " + post1 + " " + "y su precio es de " + "$" + (3.95 * cant));
                                        preciofinal = preciofinal + (3.95 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (post1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el postre número" + " " + post1 + " " + "y su precio es de " + "$" + (4.95 * cant));
                                        preciofinal = preciofinal + (4.95 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (post1 == 4)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el postre número" + " " + post1 + " " + "y su precio es de " + "$" + (5.50 * cant));
                                        preciofinal = preciofinal + (5.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (post1 == 5)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el postre número" + " " + post1 + " " + "y su precio es de " + "$" + (6.95 * cant));
                                        preciofinal = preciofinal + (6.95 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                            }
                        }
                        break;
                    //MENU LITTLE CAESARS
                    case ("3"):
                        while (p == "Si")
                        {
                            Console.WriteLine("Bienvenido al menú de Little Caesars, ¿Qué desea ordenar?");
                            Console.WriteLine("Promociones (1)    Entradas (2)    Pizzas (3)");
                            Console.WriteLine("                    Puffs   (4)");
                            men1 = Console.ReadLine();
                            switch (men1)
                            {
                                //MENU PROMOCIONES LITTLE CAESARS
                                case ("1"):
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine("1 Pizza Gigante Jamón + Crazy Bread + Soda 1.5 lt.....................$10.95 (1)");
                                    Console.WriteLine("Pizza Pepperoni con orilla de queso + Crazy Bread + Soda 1.5 lt.......$13.95 (2)");
                                    Console.WriteLine("1 Pizza Jamón + 1 Pizza Pepperoni + Crazy Bread + Soda 1.5 lt.........$17.20 (3)");
                                    comb1 = int.Parse(Console.ReadLine());
                                    if (comb1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la promoción número" + " " + comb1 + " " + "y su precio es de " + "$" + (10.95 * cant));
                                        preciofinal = preciofinal + (10.95 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la promoción número" + " " + comb1 + " " + "y su precio es de " + "$" + (13.95 * cant));
                                        preciofinal = preciofinal + (13.95 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la promoción número" + " " + comb1 + " " + "y su precio es de " + "$" + (17.20 * cant));
                                        preciofinal = preciofinal + (17.20 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                                //MENU ENTTRADAS LITTLE CAESARS
                                case ("2"):
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine("Crazy Cheese Bread ....$4.00 (1)");
                                    Console.WriteLine("Crazy Bread............$2.70 (2)");
                                    Console.WriteLine("Canelitas..............$2.70 (3)");
                                    desa1 = int.Parse(Console.ReadLine());
                                    if (desa1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la entrada número" + " " + desa1 + " " + "y su precio es de " + "$" + (4 * cant));
                                        preciofinal = preciofinal + (4 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (desa1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la entrada número" + " " + desa1 + " " + "y su precio es de " + "$" + (2.70 * cant));
                                        preciofinal = preciofinal + (2.70 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (desa1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la entrada número" + " " + desa1 + " " + "y su precio es de " + "$" + (2.70 * cant));
                                        preciofinal = preciofinal + (2.70 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                                //MENU PIZZAS LITTLE CAESARS
                                case ("3"):
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine("Clásica de Pepperoni............$6.25 (1)");
                                    Console.WriteLine("Clásica de Jamón................$6.25 (2)");
                                    Console.WriteLine("Clásica de Queso................$6.25 (3)");
                                    ham1 = int.Parse(Console.ReadLine());
                                    if (ham1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la pizza número" + " " + ham1 + " " + "y su precio es de " + "$" + (6.25 * cant));
                                        preciofinal = preciofinal + (6.25 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (ham1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la pizza número" + " " + ham1 + " " + "y su precio es de " + "$" + (6.25 * cant));
                                        preciofinal = preciofinal + (6.25 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (ham1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la pizza número" + " " + ham1 + " " + "y su precio es de " + "$" + (6.25 * cant));
                                        preciofinal = preciofinal + (6.25 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                                //MENU PUFFS LITTLE CAESARS
                                case ("4"):
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine("4 piezas de pan rellenas de pepperoni con salsa de tomate,mantequilla de ajo y parmesano con especias.....$3.25 (1)");
                                    Console.WriteLine("4 piezas de pan rellenas de queso con salsa de tomate,mantequilla de ajo y parmesano con especias.........$3.25 (2)");
                                    gourmet1 = int.Parse(Console.ReadLine());
                                    if (gourmet1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el puff número" + " " + gourmet1 + " " + "y su precio es de " + "$" + (3.25 * cant));
                                        preciofinal = preciofinal + (3.25 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (gourmet1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el puff número" + " " + gourmet1 + " " + "y su precio es de " + "$" + (3.25 * cant));
                                        preciofinal = preciofinal + (3.25 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                            }
                        }
                        break;
                    //MENU DOMINOS
                    case ("4"):
                        while (p == "Si")
                        {
                            Console.WriteLine("Bienvenido al menú de Dominos, ¿Qué desea ordenar?");
                            Console.WriteLine("Promociones (1)      Entradas   (2)     Pizzas (3)");
                            Console.WriteLine("                  Pizza Calzone (4)");
                            men1 = Console.ReadLine();
                            switch (men1)
                            {
                                //MENU PROMOCIONES DOMINOS
                                case ("1"):
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine("2 Pizzas Grandes + Soda lt.........................$15.75 (1)");
                                    Console.WriteLine("Dominísma + Soda 1.5 lt............................$12.99 (2)");
                                    Console.WriteLine("Pizza Gigante + Cheese Bites + Alitas + Soda.......$21.99 (3)");
                                    Console.WriteLine("Pizza Gigante + Cheese Bites ......................$12.99 (3)");
                                    comb1 = int.Parse(Console.ReadLine());
                                    if (comb1 == 1)
                                    {
                                        Console.WriteLine("Que especialidad desea la Primera Pizza");
                                        Console.WriteLine(" Deluxe   (1)   Full Carnes   (2)   Hawaiana (3)   4 Quesos (4)");
                                        pizza = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Que especialidad desea la Segunda Pizza");
                                        Console.WriteLine(" Deluxe   (1)   Full Carnes   (2)   Hawaiana (3)   4 Quesos (4)");
                                        pizza1 = int.Parse(Console.ReadLine());
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la promoción número" + " " + comb1 + " " + " " + "el ingrediente de su 1er pizza es el número" + " " + pizza + " " + " y el segundo el número" + " " + pizza1 + "y su precio es de " + "$" + (15.75 * cant));
                                        preciofinal = preciofinal + (15.75 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la promoción número" + " " + comb1 + " " + "y su precio es de " + "$" + (12.99 * cant));
                                        preciofinal = preciofinal + (12.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 3)
                                    {
                                        Console.WriteLine("Que especialidad desea la Pizza");
                                        Console.WriteLine(" Deluxe   (1)   Full Carnes   (2)   Hawaiana (3)   4 Quesos (4)");
                                        pizza = int.Parse(Console.ReadLine());
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la promoción número" + " " + comb1 + " " + "y el ingrediente es el número" + " " + pizza + "y su precio es de " + "$" + (21.99 * cant));
                                        preciofinal = preciofinal + (21.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 4)
                                    {
                                        Console.WriteLine("Que especialidad desea la Pizza");
                                        Console.WriteLine(" Deluxe   (1)   Full Carnes   (2)   Hawaiana (3)   4 Quesos (4)");
                                        pizza = int.Parse(Console.ReadLine());
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la promoción número" + " " + comb1 + " " + "y el ingrediente es el número" + " " + pizza + "y su precio es de " + "$" + (12.99 * cant));
                                        preciofinal = preciofinal + (12.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                                //MENU ENTRADAS DOMINOS
                                case ("2"):
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine("Cheesy Bites..............$3.99 (1)");
                                    Console.WriteLine("Stuffed Cheesy Bread......$6.99 (2)");
                                    Console.WriteLine("Alitas....................$8.75 (3)");
                                    Console.WriteLine("Cinna Bites...............$4.50 (4)");
                                    desa1 = int.Parse(Console.ReadLine());
                                    if (desa1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la entrada número" + " " + desa1 + " " + "y su precio es de " + "$" + (3.99 * cant));
                                        preciofinal = preciofinal + (3.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (desa1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la entrada número" + " " + desa1 + " " + "y su precio es de " + "$" + (6.99 * cant));
                                        preciofinal = preciofinal + (6.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (desa1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la entrada número" + " " + desa1 + " " + "y su precio es de " + "$" + (8.75 * cant));
                                        preciofinal = preciofinal + (8.75 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (desa1 == 4)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la entrada número" + " " + desa1 + " " + "y su precio es de " + "$" + (4.50 * cant));
                                        preciofinal = preciofinal + (4.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                                //MENU PIZZA DOMINOS
                                case ("3"):
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine("Deluxe.............$17.99 (1)");
                                    Console.WriteLine("Full Carnes........$17.99 (2)");
                                    Console.WriteLine("Hawaiana...........$17.99 (3)");
                                    Console.WriteLine("4 Quesos ..........$17.99 (4)");
                                    ham1 = int.Parse(Console.ReadLine());
                                    if (ham1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la pizza número" + " " + ham1 + " " + "y su precio es de " + "$" + (17.99 * cant));
                                        preciofinal = preciofinal + (17.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (ham1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la pizza número" + " " + ham1 + " " + "y su precio es de " + "$" + (17.99 * cant));
                                        preciofinal = preciofinal + (17.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (ham1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la pizza número" + " " + ham1 + " " + "y su precio es de " + "$" + (17.99 * cant));
                                        preciofinal = preciofinal + (17.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (ham1 == 4)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la pizza número" + " " + ham1 + " " + "y su precio es de " + "$" + (17.99 * cant));
                                        preciofinal = preciofinal + (17.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                                //MENU CALZONES DOMINOS
                                case ("4"):
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine("Pizza Calzone de Pepperoni, Hongos y Extra Queso .....................$5.50 (1)");
                                    Console.WriteLine("Pizza Calzone de Pepperoni, Jamón, Salchicha y Carne..................$5.50 (2)");
                                    Console.WriteLine("Pizza Calzone de Chile Verde, Cebolla, Aceitunas negras y Hongos......$5.50 (3)");
                                    comb1 = int.Parse(Console.ReadLine());
                                    if (comb1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la pizza calzone número" + " " + comb1 + " " + "y su precio es de " + "$" + (5.50 * cant));
                                        preciofinal = preciofinal + (5.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la pizza calzone número" + " " + comb1 + " " + "y su precio es de " + "$" + (5.50 * cant));
                                        preciofinal = preciofinal + (5.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la pizza calzone número" + " " + comb1 + " " + "y su precio es de " + "$" + (5.50 * cant));
                                        preciofinal = preciofinal + (5.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;

                            }
                        }
                        break;
                    //MENU SIMMER DOWN
                    case ("5"):
                        while (p == "Si")
                        {
                            Console.WriteLine("Bienvenido al menú de Simmer Down, ¿Qué desea ordenar?");
                            Console.WriteLine("Entradas (1)      Pastas   (2)   Pizza (3)");
                            Console.WriteLine("                 Ensaladas (4)          ");
                            men1 = Console.ReadLine();
                            switch (men1)
                            {
                                //MENU ENTRADAS SIMMER DOWN
                                case ("1"):
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine("Cheese Ball..................$5.99 (1)");
                                    Console.WriteLine("Patatas con Tocino...........$4.99 (2)");
                                    Console.WriteLine("Fundido Camarón y Pollo......$7.99 (3)");
                                    Console.WriteLine("Fundido Filet Migñón.........$7.99 (4)");
                                    Console.WriteLine("Fundido de Champiñon.........$7.99 (5)");
                                    comb1 = int.Parse(Console.ReadLine());
                                    if (comb1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la entrada número" + " " + comb1 + " " + "y su precio es de " + "$" + (5.99 * cant));
                                        preciofinal = preciofinal + (5.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la entrada número" + " " + comb1 + " " + "y su precio es de " + "$" + (4.99 * cant));
                                        preciofinal = preciofinal + (4.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la entrada número" + " " + comb1 + " " + "y su precio es de " + "$" + (7.99 * cant));
                                        preciofinal = preciofinal + (7.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 4)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la entrada número" + " " + comb1 + " " + "y su precio es de " + "$" + (7.99 * cant));
                                        preciofinal = preciofinal + (7.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 5)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la entrada número" + " " + comb1 + " " + "y su precio es de " + "$" + (7.99 * cant));
                                        preciofinal = preciofinal + (7.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                                //MENU PASTAS SIMMER DOWN
                                case ("2"):
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine("Penne Brócoli Tocino........................................$7.99 (1)");
                                    Console.WriteLine("Pasta de Camarones + Almejas + Calamar + Mejillones.........$12.99 (2)");
                                    desa1 = int.Parse(Console.ReadLine());
                                    if (desa1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la pasta número" + " " + desa1 + " " + "y su precio es de " + "$" + (7.99 * cant));
                                        preciofinal = preciofinal + (7.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (desa1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la pasta número" + " " + desa1 + " " + "y su precio es de " + "$" + (12.99 * cant));
                                        preciofinal = preciofinal + (12.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                                //MENU PIZZAS SIMMER DOWN
                                case ("3"):
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine("Tomate + Queso  + Jamón...................................$5.50 (1)");
                                    Console.WriteLine("Queso + Tomates Cherry + Albahaca.........................$5.50 (2)");
                                    Console.WriteLine("Pollo + Queso + Salsa de Ajo + Cilantro...................$5.50 (3)");
                                    Console.WriteLine("Pollo + Manzana + Almendras + Tocino......................$5.50 (4)");
                                    Console.WriteLine("Chorizo + Pimiento Verde + Cebolla + Chimichurri..........$5.50 (5)");
                                    Console.WriteLine("Calamar + Almejas + Camarones + Cebolla + Pimientos.......$6.00 (6)");
                                    Console.WriteLine("Lomo de Res + Queso + Cilantro + Salsa Punta Jalapeña.....$6.00 (7");
                                    Console.WriteLine("Carne + Pollo + Cebolla + Salsa BBQ + Ajonjolín...........$6.00 (8)");
                                    ham1 = int.Parse(Console.ReadLine());
                                    if (ham1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la pizza número" + " " + ham1 + " " + "y su precio es de " + "$" + (5.50 * cant));
                                        preciofinal = preciofinal + (5.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (ham1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la pizza número" + " " + ham1 + " " + "y su precio es de " + "$" + (5.50 * cant));
                                        preciofinal = preciofinal + (5.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (ham1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la pizza número" + " " + ham1 + " " + "y su precio es de " + "$" + (5.50 * cant));
                                        preciofinal = preciofinal + (5.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (ham1 == 4)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la pizza número" + " " + ham1 + " " + "y su precio es de " + "$" + (5.50 * cant));
                                        preciofinal = preciofinal + (5.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (ham1 == 5)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la pizza número" + " " + ham1 + " " + "y su precio es de " + "$" + (5.50 * cant));
                                        preciofinal = preciofinal + (5.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (ham1 == 6)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la pizza número" + " " + ham1 + " " + "y su precio es de " + "$" + (6 * cant));
                                        preciofinal = preciofinal + (6 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (ham1 == 7)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la pizza número" + " " + ham1 + " " + "y su precio es de " + "$" + (6 * cant));
                                        preciofinal = preciofinal + (6 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (ham1 == 8)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la pizza número" + " " + ham1 + " " + "y su precio es de " + "$" + (6 * cant));
                                        preciofinal = preciofinal + (6 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                                //MENU ENSALADAS SIMMER DOWN
                                case ("4"):
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine("Lechuga + Pollo + Manzana Verde + Zanahoria + Elote + Tocino + Aguacate + Chips.......$7.99 (1)");
                                    Console.WriteLine("Lechuga + Lomo Res + Aguacate + Champiñones + Tomates Cherry + Chips .................$7.99 (2)");
                                    Console.WriteLine("Lechuga + Camarones + Tomate + Zanahoria + Aceitunas negras + Aguacate + Crutones.....$7.99 (3)");
                                    gourmet1 = int.Parse(Console.ReadLine());
                                    if (gourmet1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la ensalada número" + " " + gourmet1 + " " + "y su precio es de " + "$" + (7.99 * cant));
                                        preciofinal = preciofinal + (7.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (gourmet1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la ensalada número" + " " + gourmet1 + " " + "y su precio es de " + "$" + (7.99 * cant));
                                        preciofinal = preciofinal + (7.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (gourmet1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la ensalada número" + " " + gourmet1 + " " + "y su precio es de " + "$" + (7.99 * cant));
                                        preciofinal = preciofinal + (7.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                            }
                        }
                        break;
                    //MENU INNA JAMMIN
                    case ("6"):
                        while (p == "Si")
                        {
                            Console.WriteLine("Bienvenido al menú de Inna Jammin, ¿Qué desea ordenar?");
                            Console.WriteLine("  Entradas (1)          Pizzas (2)          Pastas (3)");
                            Console.WriteLine("       Ensaladas (4)      Quesos Fundidos (5)");
                            men1 = Console.ReadLine();
                            switch (men1)
                            {
                                //MENU ENTRADAS INNA JAMMIN
                                case ("1"):
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine("Cheese Ball.......................$5.99 (1)");
                                    Console.WriteLine("Fundido de Camarón y Pollo........$6.99 (2)");
                                    Console.WriteLine("Fundido de Champiñones............$6.99 (3)");
                                    Console.WriteLine("Fundido a lo Filet Migñón ........$6.99 (4)");
                                    Console.WriteLine("Costilla a lo BBQ.................$4.95 (5)");
                                    comb1 = int.Parse(Console.ReadLine());
                                    if (comb1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la entrada número" + " " + comb1 + " " + "y su precio es de " + "$" + (5.99 * cant));
                                        preciofinal = preciofinal + (5.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la entrada número" + " " + comb1 + " " + "y su precio es de " + "$" + (6.99 * cant));
                                        preciofinal = preciofinal + (6.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la entrada número" + " " + comb1 + " " + "y su precio es de " + "$" + (6.99 * cant));
                                        preciofinal = preciofinal + (6.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 4)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la entrada número" + " " + comb1 + " " + "y su precio es de " + "$" + (6.99 * cant));
                                        preciofinal = preciofinal + (6.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 5)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la entrada número" + " " + comb1 + " " + "y su precio es de " + "$" + (4.95 * cant));
                                        preciofinal = preciofinal + (4.95 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                                //MENU PIZZAS INNA JAMMIN
                                case ("2"):
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine("Jamón .................................................$5.50 (1)");
                                    Console.WriteLine("Loroco + Tocino + Pepperoni  ..........................$5.50 (2)");
                                    Console.WriteLine("Pepperoni + Piña Pesto.................................$5.50 (3)");
                                    Console.WriteLine("4 Quesos...............................................$5.50 (4)");
                                    Console.WriteLine("Jamón + Piña + Jalapeños + Salsa Ajo...................$5.50 (5)");
                                    Console.WriteLine("Tocino + Jamón + Cebolla + Elote rostizado ............$6.00 (6)");
                                    Console.WriteLine("Vegetales + Pepperoni + Jamón + Chorizo + Aceitunas....$6.00 (7)");
                                    Console.WriteLine("Carne + Chorizo + Queso + Frijoles + Guacamole ........$6.00 (8)");
                                    Console.WriteLine("Carne + Cebolla Morada + Queddar + Perejil.............$6.00 (9)");
                                    Console.WriteLine("Camarones + Piña + Salsa Alfredo.......................$6.00 (10)");
                                    desa1 = int.Parse(Console.ReadLine());
                                    if (desa1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la pizza número" + " " + desa1 + " " + "y su precio es de " + "$" + (5.50 * cant));
                                        preciofinal = preciofinal + (5.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (desa1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la pizza número" + " " + desa1 + " " + "y su precio es de " + "$" + (5.50 * cant));
                                        preciofinal = preciofinal + (5.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (desa1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la pizza número" + " " + desa1 + " " + "y su precio es de " + "$" + (5.50 * cant));
                                        preciofinal = preciofinal + (5.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (desa1 == 4)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la pizza número" + " " + desa1 + " " + "y su precio es de " + "$" + (5.50 * cant));
                                        preciofinal = preciofinal + (5.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (desa1 == 5)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la pizza número" + " " + desa1 + " " + "y su precio es de " + "$" + (5.50 * cant));
                                        preciofinal = preciofinal + (5.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (desa1 == 6)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la pizza número" + " " + desa1 + " " + "y su precio es de " + "$" + (6 * cant));
                                        preciofinal = preciofinal + (6 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (desa1 == 7)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la pizza número" + " " + desa1 + " " + "y su precio es de " + "$" + (6 * cant));
                                        preciofinal = preciofinal + (6 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (desa1 == 8)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la pizza número" + " " + desa1 + " " + "y su precio es de " + "$" + (6 * cant));
                                        preciofinal = preciofinal + (6 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (desa1 == 9)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la pizza número" + " " + desa1 + " " + "y su precio es de " + "$" + (6 * cant));
                                        preciofinal = preciofinal + (6 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (desa1 == 10)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la pizza número" + " " + desa1 + " " + "y su precio es de " + "$" + (6 * cant));
                                        preciofinal = preciofinal + (6 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                                //MENU PASTAS INNA JAMMIN
                                case ("3"):
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine("Pasta Fettucine Pollo + Tocino + Vegetales + Hongos ....................................$7.50 (1)");
                                    Console.WriteLine("Pasta Penne Res + Chorizo + Tocino + Hongos.............................................$8.25 (2)");
                                    Console.WriteLine("Pasta Fettucine Salsa Calamardiña + Camarones + Almejas + Calamar + Mejillones..........$8.75 (3)");
                                    ham1 = int.Parse(Console.ReadLine());
                                    if (ham1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la pasta número" + " " + ham1 + " " + "y su precio es de " + "$" + (7.50 * cant));
                                        preciofinal = preciofinal + (7.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (ham1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la pasta número" + " " + ham1 + " " + "y su precio es de " + "$" + (8.25 * cant));
                                        preciofinal = preciofinal + (8.25 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (ham1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la pasta número" + " " + ham1 + " " + "y su precio es de " + "$" + (8.75 * cant));
                                        preciofinal = preciofinal + (8.75 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                                //MENU ENSALADAS INNA JAMMIN
                                case ("4"):
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine("Pechuga + Lechuga + Tomates Cherry + Aguacate + Crotones........................$7.99 (1)");
                                    Console.WriteLine("Camarones + Lechuga + Tomate + Zanahoria + Aceitunas + Aguacate + Crotones......$7.99 (2)");
                                    gourmet1 = int.Parse(Console.ReadLine());
                                    if (gourmet1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la ensalada número" + " " + gourmet1 + " " + "y su precio es de " + "$" + (7.99 * cant));
                                        preciofinal = preciofinal + (7.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (gourmet1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la ensalada número" + " " + gourmet1 + " " + "y su precio es de " + "$" + (7.99 * cant));
                                        preciofinal = preciofinal + (7.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                                //MENU QUESOS FUNDIDOS INNA JAMMIN
                                case ("5"):
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine("Queso fundido de Camarón y Pollo..........$7.99 (1)");
                                    Console.WriteLine("Queso Fundido a lo Filet Migñón...........$7.99 (2)");
                                    Console.WriteLine("Queso Fundido con Champiñones.............$7.99 (3)");
                                    niños1 = int.Parse(Console.ReadLine());
                                    if (niños1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el queso fundido número" + " " + niños1 + " " + "y su precio es de " + "$" + (11 * cant));
                                        preciofinal = preciofinal + (11 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (niños1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el queso fundido número" + " " + niños1 + " " + "y su precio es de " + "$" + (7.75 * cant));
                                        preciofinal = preciofinal + (7.75 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (niños1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el queso fundido número" + " " + niños1 + " " + "y su precio es de " + "$" + (10.50 * cant));
                                        preciofinal = preciofinal + (10.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                            }
                        }
                        break;
                }
                break;
            //MENU POLLO
            case ("3"):
                Console.WriteLine("Qué restaurante desea ordenar");
                Console.WriteLine(" Pollo Campero   (1)    Buffalo Wings (2)    Don Pollo (3)");
                Console.WriteLine("Pollo Campestre  (4)     Pollo Real   (5)        KFC   (6)");
                ham = Console.ReadLine();
                switch (ham)
                {
                    //MENU POLLO CAMPERO
                    case ("1"):
                        while (p == "Si")
                        {
                            Console.WriteLine("Bienvenido al menú de Pollo Campero, ¿Qué desea ordenar?");
                            Console.WriteLine("Promociones (1)      Desayunos (2)     Pollo  (3)");
                            Console.WriteLine(" Banquetes  (4)        Pizza   (5)    Postres (6)");
                            men1 = Console.ReadLine();
                            switch (men1)
                            {
                                //MENU PROMOCIONES POLLO CAMPERO
                                case ("1"):
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine("6 Piezas Pollo + 3 Ensaladas + 3 Panes............................$10.75 (1)");
                                    Console.WriteLine("20 Camperitos + 3 Papas + 2 Hamburguesas .........................$18.10 (2)");
                                    Console.WriteLine("20 Camperitos + 4 Papas + 4 Hamburguesas..........................$20.65 (3)");
                                    Console.WriteLine("3 Piezas Pollo + 2 Papas + 1 Ensalada + Soda +  1 Tres Leches.....$9.00  (4)");
                                    Console.WriteLine("Sándwich Pollo, Lechuga, Pepinillos + Papas + Soda  ..............$6.95  (5)");
                                    comb1 = int.Parse(Console.ReadLine());
                                    if (comb1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la promoción número" + " " + comb1 + " " + "y su precio es de " + "$" + (10.75 * cant));
                                        preciofinal = preciofinal + (10.75 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la promoción número" + " " + comb1 + " " + "y su precio es de " + "$" + (18.10 * cant));
                                        preciofinal = preciofinal + (18.10 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la promoción número" + " " + comb1 + " " + "y su precio es de " + "$" + (20.65 * cant));
                                        preciofinal = preciofinal + (20.65 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 4)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la promoción número" + " " + comb1 + " " + "y su precio es de " + "$" + (9 * cant));
                                        preciofinal = preciofinal + (9 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 5)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la promoción número" + " " + comb1 + " " + "y su precio es de " + "$" + (6.95 * cant));
                                        preciofinal = preciofinal + (6.95 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                                //MENU DESAYUNOS POLLO CAMPERO
                                case ("2"):
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine("Huevos + Frijoles + Plátano + Queso Crema + Pan + Jugo Naranja.............................$5.45 (1)");
                                    Console.WriteLine("Sándwich Pollo, Queso Cheddar, Huevo + Jugo Naranja........................................$5.75 (2)");
                                    Console.WriteLine("Muffin Huevo, Tocino, Frijoles + Hasbrowns + Jugo Naranja..................................$4.35 (3)");
                                    Console.WriteLine("Croissant Doble Huevo, Chorizo, Aguacate, Queso, Chipotle + Hashbrowns + Jugo Naranja......$5.00 (4)");
                                    Console.WriteLine("3 Pancakes + Miel de Abeja + Jugo Naranja..................................................$4.00 (5)");
                                    desa1 = int.Parse(Console.ReadLine());
                                    if (desa1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el desayuno número" + " " + desa1 + " " + "y su precio es de " + "$" + (5.45 * cant));
                                        preciofinal = preciofinal + (5.45 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (desa1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el desayuno número" + " " + desa1 + " " + "y su precio es de " + "$" + (5.75 * cant));
                                        preciofinal = preciofinal + (5.75 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (desa1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el desayuno número" + " " + desa1 + " " + "y su precio es de " + "$" + (4.35 * cant));
                                        preciofinal = preciofinal + (4.35 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (desa1 == 4)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el desayuno número" + " " + desa1 + " " + "y su precio es de " + "$" + (5 * cant));
                                        preciofinal = preciofinal + (5 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (desa1 == 5)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el desayuno número" + " " + desa1 + " " + "y su precio es de " + "$" + (4 * cant));
                                        preciofinal = preciofinal + (4 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                                //MENU POLLO POLLO CAMPERO 
                                case ("3"):
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine("2 Piezas Pollo + Papas + Ensalada + Soda..............$6.70  (1)");
                                    Console.WriteLine("6 Piezas Pollo + 3 Papas + 3 Panes....................$13.50 (2)");
                                    Console.WriteLine("8 Piezas Pollo + 4 Papas + 4 Panes....................$16.25 (3)");
                                    Console.WriteLine("10 Piezas Pollo + 5 Papas + 5 Panes...................$19.50 (4)");
                                    Console.WriteLine("12 Piezas Pollo + 6 Papas + 6 Panes...................$22.75 (5)");
                                    ham1 = int.Parse(Console.ReadLine());
                                    if (ham1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el menú de pollo número" + " " + ham1 + " " + "y su precio es de " + "$" + (6.70 * cant));
                                        preciofinal = preciofinal + (6.70 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (ham1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el menú de pollo número" + " " + ham1 + " " + "y su precio es de " + "$" + (13.50 * cant));
                                        preciofinal = preciofinal + (13.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (ham1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el menú de pollo número" + " " + ham1 + " " + "y su precio es de " + "$" + (16.25 * cant));
                                        preciofinal = preciofinal + (16.25 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (ham1 == 4)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el menú de pollo número" + " " + ham1 + " " + "y su precio es de " + "$" + (19.50 * cant));
                                        preciofinal = preciofinal + (19.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (ham1 == 5)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el menú de pollo número" + " " + ham1 + " " + "y su precio es de " + "$" + (22.75 * cant));
                                        preciofinal = preciofinal + (22.75 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                                //MENU BANQUETES POLLO CAMPERO
                                case ("4"):
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine("20 Camperitos + 3 Papas + 2 Aderezos.........$17.95 (1)");
                                    Console.WriteLine("20 Alitas + 3 Papas + 2 Aderezos.............$18.90 (2)");
                                    Console.WriteLine("30 Camperitos + 4 Papas + 3 Aderezos.........$21.70 (3)");
                                    gourmet1 = int.Parse(Console.ReadLine());
                                    if (gourmet1 == 1)
                                    {
                                        Console.WriteLine("Escoga su primer aderezo");
                                        Console.WriteLine("Barbacoa   (1)   Ranch   (2)   Ajo Cilantro (3)   Oriental (4)");
                                        pizza = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Escoga su segundo aderezo");
                                        Console.WriteLine("Barbacoa   (1)   Ranch   (2)   Ajo Cilantro (3)   Oriental (4)");
                                        pizza1 = int.Parse(Console.ReadLine());
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el banquete número" + " " + gourmet1 + " " + "y su precio es de " + "$" + (17.95 * cant));
                                        preciofinal = preciofinal + (17.95 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (gourmet1 == 2)
                                    {
                                        Console.WriteLine("Escoga su primer aderezo");
                                        Console.WriteLine("Barbacoa   (1)   Ranch   (2)   Ajo Cilantro (3)   Oriental (4)");
                                        pizza = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Escoga su segundo aderezo");
                                        Console.WriteLine("Barbacoa   (1)   Ranch   (2)   Ajo Cilantro (3)   Oriental (4)");
                                        pizza1 = int.Parse(Console.ReadLine());
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el banquete número" + " " + gourmet1 + " " + "y su precio es de " + "$" + (18.90 * cant));
                                        preciofinal = preciofinal + (18.90 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (gourmet1 == 3)
                                    {
                                        Console.WriteLine("Escoga su primer aderezo");
                                        Console.WriteLine("Barbacoa   (1)   Ranch   (2)   Ajo Cilantro (3)   Oriental (4)");
                                        pizza = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Escoga su segundo aderezo");
                                        Console.WriteLine("Barbacoa   (1)   Ranch   (2)   Ajo Cilantro (3)   Oriental (4)");
                                        pizza1 = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Escoga su tercer aderezo");
                                        Console.WriteLine("Barbacoa   (1)   Ranch   (2)   Ajo Cilantro (3)   Oriental (4)");
                                        pizza1 = int.Parse(Console.ReadLine());
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el banquete número" + " " + gourmet1 + " " + "y su precio es de " + "$" + (21.70 * cant));
                                        preciofinal = preciofinal + (21.70 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                                //MENU PIZZA POLLO CAMPERO
                                case ("5"):
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine("Pizza de Camperitos Búffalo.......$13.00 (1)");
                                    Console.WriteLine("Pizza de Queso....................$9.00  (2)");
                                    Console.WriteLine("Pizza de Carnes...................$11.00 (3)");
                                    Console.WriteLine("Pizza Vegetariana.................$11.00 (4)");
                                    Console.WriteLine("Pizza Hawaiana....................$11.00 (5)");
                                    niños1 = int.Parse(Console.ReadLine());
                                    if (niños1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la pizza número" + " " + niños1 + " " + "y su precio es de " + "$" + (13 * cant));
                                        preciofinal = preciofinal + (13 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (niños1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la pizza número" + " " + niños1 + " " + "y su precio es de " + "$" + (9 * cant));
                                        preciofinal = preciofinal + (9 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (niños1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el la pizza número" + " " + niños1 + " " + "y su precio es de " + "$" + (11 * cant));
                                        preciofinal = preciofinal + (11 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (niños1 == 4)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la pizza número" + " " + niños1 + " " + "y su precio es de " + "$" + (11 * cant));
                                        preciofinal = preciofinal + (11 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (niños1 == 5)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la pizza número" + " " + niños1 + " " + "y su precio es de " + "$" + (11 * cant));
                                        preciofinal = preciofinal + (11 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                                //MENU POSTRES POLLO CAMPERO
                                case ("6"):
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine("Flan......................$2.15 (1)");
                                    Console.WriteLine("Tartaleta Fresa...........$3.65 (2)");
                                    Console.WriteLine("Tartaleta Melocotón.......$3.65 (3)");
                                    Console.WriteLine("Tartaleta Tutti Frutti....$3.65 (4)");
                                    Console.WriteLine("Cheesecake Fresa..........$4.15 (5)");
                                    Console.WriteLine("Cheesecake Caramelo.......$4.15 (6)");
                                    Console.WriteLine("Pastel Chocolate..........$3.90 (7)");
                                    Console.WriteLine("Tres Leches...............$3.30 (8)");
                                    post1 = int.Parse(Console.ReadLine());
                                    if (post1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el postre número" + " " + post1 + " " + "y su precio es de " + "$" + (2.15 * cant));
                                        preciofinal = preciofinal + (2.15 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (post1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el postre número" + " " + post1 + " " + "y su precio es de " + "$" + (3.65 * cant));
                                        preciofinal = preciofinal + (3.65 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (post1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el postre número" + " " + post1 + " " + "y su precio es de " + "$" + (3.65 * cant));
                                        preciofinal = preciofinal + (3.65 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (post1 == 4)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el postre número" + " " + post1 + " " + "y su precio es de " + "$" + (3.65 * cant));
                                        preciofinal = preciofinal + (3.65 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (post1 == 5)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el postre número" + " " + post1 + " " + "y su precio es de " + "$" + (4.15 * cant));
                                        preciofinal = preciofinal + (4.15 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (post1 == 6)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el postre número" + " " + post1 + " " + "y su precio es de " + "$" + (4.15 * cant));
                                        preciofinal = preciofinal + (4.15 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (post1 == 7)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el postre número" + " " + post1 + " " + "y su precio es de " + "$" + (3.90 * cant));
                                        preciofinal = preciofinal + (3.90 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (post1 == 8)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el postre número" + " " + post1 + " " + "y su precio es de " + "$" + (3.30 * cant));
                                        preciofinal = preciofinal + (3.30 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                            }
                        }
                        break;
                    //MENU BUFFALO WINGS 
                    case ("2"):
                        while (p == "Si")
                        {
                            Console.WriteLine("Bienvenido al menú de Buffalo Wings, ¿Qué desea ordenar?");
                            Console.WriteLine("Entradas (1)   Otros favoritos (2)   Alitas (3)");
                            Console.WriteLine("           Chunks (4)    Postres (5)");
                            men1 = Console.ReadLine();
                            switch (men1)
                            {
                                //MENU PROMOCIONES BURGER KING
                                case ("1"):
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine("1/2 de Nachos..........$5.95 (1)");
                                    Console.WriteLine("Rollers................$4.99 (2)");
                                    Console.WriteLine("Papas Fritas...........$3.95 (3)");
                                    Console.WriteLine("Papas con Chili........$5.70 (4)");
                                    Console.WriteLine("Jalapeño Poppers.......$5.99 (5)");
                                    Console.WriteLine("Buffries...............$8.99 (6)");
                                    comb1 = int.Parse(Console.ReadLine());
                                    if (comb1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la entrada número" + " " + comb1 + " " + "y su precio es de " + "$" + (5.95 * cant));
                                        preciofinal = preciofinal + (5.95 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la entrada número" + " " + comb1 + " " + "y su precio es de " + "$" + (4.99 * cant));
                                        preciofinal = preciofinal + (4.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la entrada número" + " " + comb1 + " " + "y su precio es de " + "$" + (3.95 * cant));
                                        preciofinal = preciofinal + (3.95 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 4)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la entrada número" + " " + comb1 + " " + "y su precio es de " + "$" + (5.70 * cant));
                                        preciofinal = preciofinal + (5.70 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 5)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la entrada número" + " " + comb1 + " " + "y su precio es de " + "$" + (5.99 * cant));
                                        preciofinal = preciofinal + (5.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 6)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la entrada número" + " " + comb1 + " " + "y su precio es de " + "$" + (8.99 * cant));
                                        preciofinal = preciofinal + (8.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                                //MENU OTROS FAVORITOS BUFFALO WINGS
                                case ("2"):
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine("Costillas...............$10.99 (1)");
                                    Console.WriteLine("Camarones Buffalo.......$11.99 (2)");
                                    Console.WriteLine("Strippers...............$12.95 (3)");
                                    desa1 = int.Parse(Console.ReadLine());
                                    if (desa1 == 1)
                                    {
                                        Console.WriteLine("Escoga su salsa");
                                        Console.WriteLine("Ajo Parmesano (1)  BBQ Tradicional (2)  Lemon Pepper (3)  Buffalo Original (4)");
                                        Console.WriteLine(" Ala pastor   (5)       Sesamo     (6)    Teriyaki   (7)      Chipotle     (8)");
                                        pizza = int.Parse(Console.ReadLine());
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el favorito número" + " " + desa1 + " " + "y su precio es de " + "$" + (10.99 * cant));
                                        preciofinal = preciofinal + (10.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (desa1 == 2)
                                    {
                                        Console.WriteLine("Escoga su salsa");
                                        Console.WriteLine("Ajo Parmesano (1)  BBQ Tradicional (2)  Lemon Pepper (3)  Buffalo Original (4)");
                                        Console.WriteLine(" Ala pastor   (5)       Sesamo     (6)    Teriyaki   (7)      Chipotle     (8)");
                                        pizza = int.Parse(Console.ReadLine());
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el favorito número" + " " + desa1 + " " + "y su precio es de " + "$" + (11.99 * cant));
                                        preciofinal = preciofinal + (11.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (desa1 == 3)
                                    {
                                        Console.WriteLine("Escoga su salsa");
                                        Console.WriteLine("Ajo Parmesano (1)  BBQ Tradicional (2)  Lemon Pepper (3)  Buffalo Original (4)");
                                        Console.WriteLine(" Ala pastor   (5)       Sesamo     (6)    Teriyaki   (7)      Chipotle     (8)");
                                        pizza = int.Parse(Console.ReadLine());
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el favorito número" + " " + desa1 + " " + "y su precio es de " + "$" + (12.95 * cant));
                                        preciofinal = preciofinal + (12.95 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                                //MENU ALITAS BUFFALO WINGS
                                case ("3"):
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine("30 Alas + 2 Papas + 3 Salsas.................$31.95 (1)");
                                    Console.WriteLine("20 Alas + 1 Papa + 2 Salsas..................$20.95 (2)");
                                    Console.WriteLine("10 Alas + Vegetales y ranch + 1 Salsa........$9.55  (3)");
                                    Console.WriteLine("5 Alas + Papas + 1 Salsa.....................$8.50  (4)");
                                    Console.WriteLine("10 Alas Crunchy + Vegetales + 2 Salsas.......$10.45 (5)");
                                    ham1 = int.Parse(Console.ReadLine());
                                    if (ham1 == 1)
                                    {
                                        Console.WriteLine("Escoga su primera salsa");
                                        Console.WriteLine("Ajo Parmesano (1)  BBQ Tradicional (2)  Lemon Pepper (3)  Buffalo Original (4)");
                                        Console.WriteLine(" Ala pastor   (5)       Sesamo     (6)    Teriyaki   (7)      Chipotle     (8)");
                                        pizza = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Escoga su segunda salsa");
                                        Console.WriteLine("Ajo Parmesano (1)  BBQ Tradicional (2)  Lemon Pepper (3)  Buffalo Original (4)");
                                        Console.WriteLine(" Ala pastor   (5)       Sesamo     (6)    Teriyaki   (7)      Chipotle     (8)");
                                        pizza1 = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Escoga su tercer salsa");
                                        Console.WriteLine("Ajo Parmesano (1)  BBQ Tradicional (2)  Lemon Pepper (3)  Buffalo Original (4)");
                                        Console.WriteLine(" Ala pastor   (5)       Sesamo     (6)    Teriyaki   (7)      Chipotle     (8)");
                                        pizza = int.Parse(Console.ReadLine());
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado las alitas número" + " " + ham1 + " " + "y su precio es de " + "$" + (31.95 * cant));
                                        preciofinal = preciofinal + (31.95 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (ham1 == 2)
                                    {
                                        Console.WriteLine("Escoga su primera salsa");
                                        Console.WriteLine("Ajo Parmesano (1)  BBQ Tradicional (2)  Lemon Pepper (3)  Buffalo Original (4)");
                                        Console.WriteLine(" Ala pastor   (5)       Sesamo     (6)    Teriyaki   (7)      Chipotle     (8)");
                                        pizza = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Escoga su segunda salsa");
                                        Console.WriteLine("Ajo Parmesano (1)  BBQ Tradicional (2)  Lemon Pepper (3)  Buffalo Original (4)");
                                        Console.WriteLine(" Ala pastor   (5)       Sesamo     (6)    Teriyaki   (7)      Chipotle     (8)");
                                        pizza1 = int.Parse(Console.ReadLine());
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado las alitas número" + " " + ham1 + " " + "y su precio es de " + "$" + (20.95 * cant));
                                        preciofinal = preciofinal + (20.95 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (ham1 == 3)
                                    {
                                        Console.WriteLine("Escoga su salsa");
                                        Console.WriteLine("Ajo Parmesano (1)  BBQ Tradicional (2)  Lemon Pepper (3)  Buffalo Original (4)");
                                        Console.WriteLine(" Ala pastor   (5)       Sesamo     (6)    Teriyaki   (7)      Chipotle     (8)");
                                        pizza = int.Parse(Console.ReadLine());
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado las alitas número" + " " + ham1 + " " + "y su precio es de " + "$" + (9.55 * cant));
                                        preciofinal = preciofinal + (9.55 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (ham1 == 4)
                                    {
                                        Console.WriteLine("Escoga su salsa");
                                        Console.WriteLine("Ajo Parmesano (1)  BBQ Tradicional (2)  Lemon Pepper (3)  Buffalo Original (4)");
                                        Console.WriteLine(" Ala pastor   (5)       Sesamo     (6)    Teriyaki   (7)      Chipotle     (8)");
                                        pizza = int.Parse(Console.ReadLine());
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado las alitas número" + " " + ham1 + " " + "y su precio es de " + "$" + (8.50 * cant));
                                        preciofinal = preciofinal + (8.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (ham1 == 5)
                                    {
                                        Console.WriteLine("Escoga su primera salsa");
                                        Console.WriteLine("Ajo Parmesano (1)  BBQ Tradicional (2)  Lemon Pepper (3)  Buffalo Original (4)");
                                        Console.WriteLine(" Ala pastor   (5)       Sesamo     (6)    Teriyaki   (7)      Chipotle     (8)");
                                        pizza = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Escoga su segunda salsa");
                                        Console.WriteLine("Ajo Parmesano (1)  BBQ Tradicional (2)  Lemon Pepper (3)  Buffalo Original (4)");
                                        Console.WriteLine(" Ala pastor   (5)       Sesamo     (6)    Teriyaki   (7)      Chipotle     (8)");
                                        pizza1 = int.Parse(Console.ReadLine());
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado las alitas número" + " " + ham1 + " " + "y su precio es de " + "$" + (10.45 * cant));
                                        preciofinal = preciofinal + (10.45 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                                //MENU CHUNKS BUFFALO WINGS
                                case ("4"):
                                    Console.WriteLine("30 Chunks + 2 Papas + 3 Salsas.................$31.95 (1)");
                                    Console.WriteLine("20 Chunks + 1 Papa + 2 Salsas..................$20.95 (2)");
                                    Console.WriteLine("10 Chunks + Vegetales y ranch + 1 Salsa........$9.55  (3)");
                                    Console.WriteLine("5 Chunks + Papas + 1 Salsa.....................$8.50  (4)");
                                    gourmet1 = int.Parse(Console.ReadLine());
                                    if (gourmet1 == 1)
                                    {
                                        Console.WriteLine("Escoga su primera salsa");
                                        Console.WriteLine("Ajo Parmesano (1)  BBQ Tradicional (2)  Lemon Pepper (3)  Buffalo Original (4)");
                                        Console.WriteLine(" Ala pastor   (5)       Sesamo     (6)    Teriyaki   (7)      Chipotle     (8)");
                                        pizza = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Escoga su segunda salsa");
                                        Console.WriteLine("Ajo Parmesano (1)  BBQ Tradicional (2)  Lemon Pepper (3)  Buffalo Original (4)");
                                        Console.WriteLine(" Ala pastor   (5)       Sesamo     (6)    Teriyaki   (7)      Chipotle     (8)");
                                        pizza1 = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Escoga su tercer salsa");
                                        Console.WriteLine("Ajo Parmesano (1)  BBQ Tradicional (2)  Lemon Pepper (3)  Buffalo Original (4)");
                                        Console.WriteLine(" Ala pastor   (5)       Sesamo     (6)    Teriyaki   (7)      Chipotle     (8)");
                                        pizza = int.Parse(Console.ReadLine());
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado los chunks número" + " " + gourmet1 + " " + "y su precio es de " + "$" + (31.95 * cant));
                                        preciofinal = preciofinal + (31.95 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (gourmet1 == 2)
                                    {
                                        Console.WriteLine("Escoga su primera salsa");
                                        Console.WriteLine("Ajo Parmesano (1)  BBQ Tradicional (2)  Lemon Pepper (3)  Buffalo Original (4)");
                                        Console.WriteLine(" Ala pastor   (5)       Sesamo     (6)    Teriyaki   (7)      Chipotle     (8)");
                                        pizza = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Escoga su segunda salsa");
                                        Console.WriteLine("Ajo Parmesano (1)  BBQ Tradicional (2)  Lemon Pepper (3)  Buffalo Original (4)");
                                        Console.WriteLine(" Ala pastor   (5)       Sesamo     (6)    Teriyaki   (7)      Chipotle     (8)");
                                        pizza1 = int.Parse(Console.ReadLine());
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado los chunks número" + " " + gourmet1 + " " + "y su precio es de " + "$" + (20.95 * cant));
                                        preciofinal = preciofinal + (20.95 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (gourmet1 == 3)
                                    {
                                        Console.WriteLine("Escoga su salsa");
                                        Console.WriteLine("Ajo Parmesano (1)  BBQ Tradicional (2)  Lemon Pepper (3)  Buffalo Original (4)");
                                        Console.WriteLine(" Ala pastor   (5)       Sesamo     (6)    Teriyaki   (7)      Chipotle     (8)");
                                        pizza = int.Parse(Console.ReadLine());
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado los chunks número" + " " + gourmet1 + " " + "y su precio es de " + "$" + (9.55 * cant));
                                        preciofinal = preciofinal + (9.55 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (gourmet1 == 4)
                                    {
                                        Console.WriteLine("Escoga su salsa");
                                        Console.WriteLine("Ajo Parmesano (1)  BBQ Tradicional (2)  Lemon Pepper (3)  Buffalo Original (4)");
                                        Console.WriteLine(" Ala pastor   (5)       Sesamo     (6)    Teriyaki   (7)      Chipotle     (8)");
                                        pizza = int.Parse(Console.ReadLine());
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado los chunks número" + " " + gourmet1 + " " + "y su precio es de " + "$" + (8.50 * cant));
                                        preciofinal = preciofinal + (8.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                                //MENU POSTRES BUFFALO WINGS
                                case ("5"):
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine("El Único..........$4.50 (1)");
                                    Console.WriteLine("Brownie BW........$3.50 (2)");
                                    niños1 = int.Parse(Console.ReadLine());
                                    if (niños1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el postre número" + " " + niños1 + " " + "y su precio es de " + "$" + (4.50 * cant));
                                        preciofinal = preciofinal + (4.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (niños1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el postre número" + " " + niños1 + " " + "y su precio es de " + "$" + (3.50 * cant));
                                        preciofinal = preciofinal + (3.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                            }
                        }
                        break;
                    //MENU DON POLLO
                    case ("3"):
                        while (p == "Si")
                        {
                            Console.WriteLine("Bienvenido al menú de Don Pollo, ¿Qué desea ordenar?");
                            Console.WriteLine("Promociones (1)  Pollo (2)  Hamburguesas (3)");
                            Console.WriteLine("           Extras (4)  Postres (5)");
                            men1 = Console.ReadLine();
                            switch (men1)
                            {
                                //MENU PROMOCIONES DON POLLO
                                case ("1"):
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine("12 Piezas Pollo + 6 Papas + 6 Ensaladas + 6 Panes.......$18.50 (1)");
                                    Console.WriteLine("6 Piezas Pollo + 3 Papas................................$8.50  (2)");
                                    Console.WriteLine("10 Piezas Pollo + 3 Papas + 2 Ensaladas.................$14.50 (3)");
                                    comb1 = int.Parse(Console.ReadLine());
                                    if (comb1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la promoción número" + " " + comb1 + " " + "y su precio es de " + "$" + (18.50 * cant));
                                        preciofinal = preciofinal + (18.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la promoción número" + " " + comb1 + " " + "y su precio es de " + "$" + (8.50 * cant));
                                        preciofinal = preciofinal + (8.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la promoción número" + " " + comb1 + " " + "y su precio es de " + "$" + (14.50 * cant));
                                        preciofinal = preciofinal + (14.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                                //MENU POLLO DON POLLO
                                case ("2"):
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine("2 Piezas Pollo + Papas + 2 Panes + Ensalada .............$4.10  (1)");
                                    Console.WriteLine("3 Piezas Pollo + Papas + 2 Panes + Ensalada..............$5.10  (2)");
                                    Console.WriteLine("5 Piezas Pollo + 2 Papas + 2 Ensaladas...................$9.00  (3)");
                                    Console.WriteLine("8 Piezas Pollo + 3 Papas + 3 Ensaladas...................$13.95 (4)");
                                    desa1 = int.Parse(Console.ReadLine());
                                    if (desa1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el menú de pollo número" + " " + desa1 + " " + "y su precio es de " + "$" + (4.10 * cant));
                                        preciofinal = preciofinal + (4.10 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (desa1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el menú de pollo número" + " " + desa1 + " " + "y su precio es de " + "$" + (5.10 * cant));
                                        preciofinal = preciofinal + (5.10 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (desa1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el menú de pollo número" + " " + desa1 + " " + "y su precio es de " + "$" + (9 * cant));
                                        preciofinal = preciofinal + (9 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (desa1 == 4)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el menú de pollo número" + " " + desa1 + " " + "y su precio es de " + "$" + (13.95 * cant));
                                        preciofinal = preciofinal + (13.95 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                                //MENU HAMBURGUESAS DON POLLO
                                case ("3"):
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine("Hamburguesa de Pollo, BBQ y Queso + Papas...............$2.15 (1)");
                                    Console.WriteLine("Hamburguesa Doble de Pollo, BBQ y Queso + Papas.........$2.90 (2)");
                                    Console.WriteLine("3 Hamburguesas de Pollo, BBQ y Queso + 3 Papas..........$6.00 (3)");
                                    Console.WriteLine("Hamburguesa de Pollo y Queso + Papas....................$2.50 (4)");
                                    Console.WriteLine("3 Hamburguesas de Pollo y Queso + 3 Papas...............$7.25 (5)");
                                    ham1 = int.Parse(Console.ReadLine());
                                    if (ham1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la hamburguesa número" + " " + ham1 + " " + "y su precio es de " + "$" + (2.15 * cant));
                                        preciofinal = preciofinal + (2.15 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (ham1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la hamburguesa número" + " " + ham1 + " " + "y su precio es de " + "$" + (2.90 * cant));
                                        preciofinal = preciofinal + (2.90 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (ham1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la hamburguesa número" + " " + ham1 + " " + "y su precio es de " + "$" + (6 * cant));
                                        preciofinal = preciofinal + (6 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (ham1 == 4)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la hamburguesa número" + " " + ham1 + " " + "y su precio es de " + "$" + (2.50 * cant));
                                        preciofinal = preciofinal + (2.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (ham1 == 5)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la hamburguesa número" + " " + ham1 + " " + "y su precio es de " + "$" + (7.25 * cant));
                                        preciofinal = preciofinal + (7.25 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                                //MENU EXTRAS DON POLLO
                                case ("4"):
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine("Papas Pequeñas ...........$1.05 (1)");
                                    Console.WriteLine("Papas Extra Grande........$2.10 (2)");
                                    Console.WriteLine("Ensalada Repollo..........$1.00 (3)");
                                    Console.WriteLine("3 Papas Pequeñas..........$2.95 (4)");
                                    Console.WriteLine("3 Ensaladas Repollo.......$2.75 (5)");
                                    gourmet1 = int.Parse(Console.ReadLine());
                                    if (gourmet1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el extra número" + " " + gourmet1 + " " + "y su precio es de " + "$" + (1.05 * cant));
                                        preciofinal = preciofinal + (1.05 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (gourmet1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el extra número" + " " + gourmet1 + " " + "y su precio es de " + "$" + (2.10 * cant));
                                        preciofinal = preciofinal + (2.10 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (gourmet1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el extra número" + " " + gourmet1 + " " + "y su precio es de " + "$" + (1 * cant));
                                        preciofinal = preciofinal + (1 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (gourmet1 == 4)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el extra número" + " " + gourmet1 + " " + "y su precio es de " + "$" + (2.95 * cant));
                                        preciofinal = preciofinal + (2.95 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (gourmet1 == 5)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el extra número" + " " + gourmet1 + " " + "y su precio es de " + "$" + (2.75 * cant));
                                        preciofinal = preciofinal + (2.75 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                                //MENU POSTRES DON POLLO
                                case ("5"):
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine("Pastel Manzana.........$0.75 (1)");
                                    Console.WriteLine("3 Pastel Manzana.......$2.15 (2)");
                                    Console.WriteLine("Pastel Mango...........$0.75 (3)");
                                    Console.WriteLine("3 Pastel Mango.........$2.15 (4)");
                                    niños1 = int.Parse(Console.ReadLine());
                                    if (niños1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el postre número" + " " + niños1 + " " + "y su precio es de " + "$" + (0.75 * cant));
                                        preciofinal = preciofinal + (0.75 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (niños1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el postre número" + " " + niños1 + " " + "y su precio es de " + "$" + (2.15 * cant));
                                        preciofinal = preciofinal + (2.15 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (niños1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el postre número" + " " + niños1 + " " + "y su precio es de " + "$" + (0.75 * cant));
                                        preciofinal = preciofinal + (0.75 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (niños1 == 4)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el postre número" + " " + niños1 + " " + "y su precio es de " + "$" + (2.15 * cant));
                                        preciofinal = preciofinal + (2.15 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                            }
                        }
                        break;
                    //MENU POLLO CAMPESTRE
                    case ("4"):
                        while (p == "Si")
                        {
                            Console.WriteLine("Bienvenido al menú de Pollo Campestre, ¿Qué desea ordenar?");
                            Console.WriteLine("       Promociones       (1)      Entradas (2)    Pollo  (3)");
                            Console.WriteLine("Hamburguesas y Ciabattas (4)      Extras   (5)   Postres (6)");
                            men1 = Console.ReadLine();
                            switch (men1)
                            {
                                //MENU PROMOCIONES POLLO CAMPESTRE
                                case ("1"):
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine("8 Piezas Pollo + 4 Panes + 4 Papas ............$17.99 (1)");
                                    Console.WriteLine("6 Piezas Pollo + 3 Papas + Pepsi 1.5 lt........$16.50 (2)");
                                    Console.WriteLine("5 Piezas Pollo + 2 Panes + 2 Ensaladas.........$9.99  (3)");
                                    Console.WriteLine("5 Alitas + Papas + Pan + Pepsi.................$6.90  (4)");
                                    Console.WriteLine("8 Alitas + Papas + Pan + Ensalada + Pespi......$8.99  (5)");
                                    comb1 = int.Parse(Console.ReadLine());
                                    if (comb1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la promoción número" + " " + comb1 + " " + "y su precio es de " + "$" + (17.99 * cant));
                                        preciofinal = preciofinal + (17.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la promoción número" + " " + comb1 + " " + "y su precio es de " + "$" + (16.50 * cant));
                                        preciofinal = preciofinal + (16.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la promoción número" + " " + comb1 + " " + "y su precio es de " + "$" + (9.99 * cant));
                                        preciofinal = preciofinal + (9.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 4)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la promoción número" + " " + comb1 + " " + "y su precio es de " + "$" + (6.90 * cant));
                                        preciofinal = preciofinal + (6.90 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 5)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la promoción número" + " " + comb1 + " " + "y su precio es de " + "$" + (8.99 * cant));
                                        preciofinal = preciofinal + (8.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                                //MENU ENTRADAS POLLO CAMPESTRE
                                case ("2"):
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine("4 Pan con Ajo...................$2.50 (1)");
                                    Console.WriteLine("Nachos Jalapeños................$4.30 (2)");
                                    Console.WriteLine("Nachos Campestres Grandes.......$4.75 (3)");
                                    Console.WriteLine("Papas con Chili.................$3.99 (4)");
                                    desa1 = int.Parse(Console.ReadLine());
                                    if (desa1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la entrada número" + " " + desa1 + " " + "y su precio es de " + "$" + (2.50 * cant));
                                        preciofinal = preciofinal + (2.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (desa1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la entrada número" + " " + desa1 + " " + "y su precio es de " + "$" + (4.30 * cant));
                                        preciofinal = preciofinal + (4.30 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (desa1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la entrada número" + " " + desa1 + " " + "y su precio es de " + "$" + (4.75 * cant));
                                        preciofinal = preciofinal + (4.75 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (desa1 == 4)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la entrada número" + " " + desa1 + " " + "y su precio es de " + "$" + (3.99 * cant));
                                        preciofinal = preciofinal + (3.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                                //MENU POLLO POLLO CAMPESTRE
                                case ("3"):
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine("2 Piezas Pollo + Papas + Pan + Soda.................................$6.55 (1)");
                                    Console.WriteLine("3 Piezas Pollo + Papas + Pan + Ensalada + Soda......................$8.55 (2)");
                                    Console.WriteLine("2 Piezas Pollo + 3 Pechugitas + Papas + Ensalada + Pan + Soda.......$9.00 (3)");
                                    Console.WriteLine("4 Pechugitas + Papas + Pan + Soda...................................$7.30 (4)");
                                    Console.WriteLine("6 Pechugitas + Papas + Pan + Ensalada + Soda........................$8.80 (5)");
                                    Console.WriteLine("2 Piezas Pollo + Casamiento + Crema + Queso + Pan + Soda............$6.75 (6)");
                                    Console.WriteLine("Pieza Pollo + Ensalada + Papas + Pan + Soda.........................$5.50 (7)");
                                    ham1 = int.Parse(Console.ReadLine());
                                    if (ham1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el menú de pollo número" + " " + ham1 + " " + "y su precio es de " + "$" + (6.55 * cant));
                                        preciofinal = preciofinal + (6.55 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (ham1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el menú de pollo número" + " " + ham1 + " " + "y su precio es de " + "$" + (8.55 * cant));
                                        preciofinal = preciofinal + (8.55 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (ham1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el menú de pollo número" + " " + ham1 + " " + "y su precio es de " + "$" + (9 * cant));
                                        preciofinal = preciofinal + (9 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (ham1 == 4)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el menú de pollo número" + " " + ham1 + " " + "y su precio es de " + "$" + (7.30 * cant));
                                        preciofinal = preciofinal + (7.30 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (ham1 == 5)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el menú de pollo número" + " " + ham1 + " " + "y su precio es de " + "$" + (8.80 * cant));
                                        preciofinal = preciofinal + (8.80 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (ham1 == 6)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el menú de pollo número" + " " + ham1 + " " + "y su precio es de " + "$" + (6.75 * cant));
                                        preciofinal = preciofinal + (6.75 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (ham1 == 7)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el menú de pollo número" + " " + ham1 + " " + "y su precio es de " + "$" + (5.50 * cant));
                                        preciofinal = preciofinal + (5.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                                //MENU HAMBURGUESAS Y CIABATTAS POLLO CAMPESTRE
                                case ("4"):
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine("Hamburguesa Pollo + Papas + Soda ........................$6.90  (1)");
                                    Console.WriteLine("Hamburguesa Pollo BBQ + Papas + Soda.....................$6.90  (2)");
                                    Console.WriteLine("Hamburguesa Pollo Chipotle + Papas + Soda................$6.90  (3)");
                                    Console.WriteLine("Ciabatta Pollo, Vegetales + Papas + Soda.................$6.75  (4)");
                                    Console.WriteLine("Ciabatta Pollo BBQ, Vegetales + Papas + Soda.............$6.75  (5)");
                                    Console.WriteLine("Ciabatta Pollo Chipotle, Vegetales + Papas + Soda........$6.75  (6)");
                                    Console.WriteLine("Ciabatta Pollo Habanero, Vegetales + Papas + Soda........$6.75  (7)");
                                    Console.WriteLine("Ciabatta Pollo Búffalo, Vegetales + Papas + Soda.........$6.75  (8)");
                                    comb1 = int.Parse(Console.ReadLine());
                                    if (comb1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la hamburguesa número" + " " + comb1 + " " + "y su precio es de " + "$" + (6.90 * cant));
                                        preciofinal = preciofinal + (6.90 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la hamburguesa número" + " " + comb1 + " " + "y su precio es de " + "$" + (6.90 * cant));
                                        preciofinal = preciofinal + (6.90 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la hamburguesa número" + " " + comb1 + " " + "y su precio es de " + "$" + (6.90 * cant));
                                        preciofinal = preciofinal + (6.90 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 4)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la ciabatta número" + " " + comb1 + " " + "y su precio es de " + "$" + (6.75 * cant));
                                        preciofinal = preciofinal + (6.75 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 5)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la ciabatta número" + " " + comb1 + " " + "y su precio es de " + "$" + (6.75 * cant));
                                        preciofinal = preciofinal + (6.75 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 6)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la ciabatta número" + " " + comb1 + " " + "y su precio es de " + "$" + (6.75 * cant));
                                        preciofinal = preciofinal + (6.75 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 7)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la ciabatta número" + " " + comb1 + " " + "y su precio es de " + "$" + (6.75 * cant));
                                        preciofinal = preciofinal + (6.75 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 8)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la ciabatta número" + " " + comb1 + " " + "y su precio es de " + "$" + (6.75 * cant));
                                        preciofinal = preciofinal + (6.75 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                                //MENU EXTRAS POLLO CAMPESTRE
                                case ("5"):
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine("Papas Normales............$2.05 (1)");
                                    Console.WriteLine("Papas Grandes.............$2.20 (2)");
                                    Console.WriteLine("Ensalada Regular..........$1.95 (3)");
                                    Console.WriteLine("Ensalada Familiar.........$4.55 (4)");
                                    desa1 = int.Parse(Console.ReadLine());
                                    if (desa1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el extra número" + " " + desa1 + " " + "y su precio es de " + "$" + (2.05 * cant));
                                        preciofinal = preciofinal + (2.05 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (desa1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el extra número" + " " + desa1 + " " + "y su precio es de " + "$" + (2.20 * cant));
                                        preciofinal = preciofinal + (2.20 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (desa1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el extra número" + " " + desa1 + " " + "y su precio es de " + "$" + (1.95 * cant));
                                        preciofinal = preciofinal + (1.95 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (desa1 == 4)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el extra número" + " " + desa1 + " " + "y su precio es de " + "$" + (4.55 * cant));
                                        preciofinal = preciofinal + (4.55 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                                //MENU POSTRES POLLO CAMPESTRE
                                case ("6"):
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine("Tres Leches Individual.......$2.99 (1)");
                                    Console.WriteLine("Tres Leches Familiar.........$5.99 (2)");
                                    Console.WriteLine("Flan Vainilla................$1.50 (3)");
                                    Console.WriteLine("Quesadilla...................$2.75 (4)");
                                    Console.WriteLine("Big Muffin...................$1.75 (5)");
                                    Console.WriteLine("Vasito de Fruta..............$2.75 (6)");
                                    Console.WriteLine("Vasito de Chocolate..........$2.75 (7)");
                                    ham1 = int.Parse(Console.ReadLine());
                                    if (ham1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el postre número" + " " + ham1 + " " + "y su precio es de " + "$" + (2.99 * cant));
                                        preciofinal = preciofinal + (2.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (ham1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el postre número" + " " + ham1 + " " + "y su precio es de " + "$" + (5.99 * cant));
                                        preciofinal = preciofinal + (5.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (ham1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el postre número" + " " + ham1 + " " + "y su precio es de " + "$" + (1.50 * cant));
                                        preciofinal = preciofinal + (1.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (ham1 == 4)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el postre número" + " " + ham1 + " " + "y su precio es de " + "$" + (2.75 * cant));
                                        preciofinal = preciofinal + (2.75 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (ham1 == 5)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el postre número" + " " + ham1 + " " + "y su precio es de " + "$" + (1.75 * cant));
                                        preciofinal = preciofinal + (1.75 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (ham1 == 6)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el postre número" + " " + ham1 + " " + "y su precio es de " + "$" + (2.75 * cant));
                                        preciofinal = preciofinal + (2.75 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (ham1 == 7)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el postre número" + " " + ham1 + " " + "y su precio es de " + "$" + (2.75 * cant));
                                        preciofinal = preciofinal + (2.75 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                            }
                        }
                        break;
                    //MENU POLLOS REAL 
                    case ("5"):
                        while (p == "Si")
                        {
                            Console.WriteLine("Bienvenido al menú de Pollos Real, ¿Qué desea ordenar?");
                            Console.WriteLine("Entradas  (1)      Desayunos (2)       Pollo    (3)");
                            Console.WriteLine("Antojitos (4)       Pupusas  (5)     Especiales (6)");
                            Console.WriteLine("Ensaladas (7)      Sándwich  (8)      Postres   (9)");
                            men1 = Console.ReadLine();
                            switch (men1)
                            {
                                //MENU ENTRADAS POLLOS REAL
                                case ("1"):
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine("Sopón real.................$5.25 (1)");
                                    Console.WriteLine("Pinchos de mollejitas......$5.25 (2)");
                                    Console.WriteLine("Sopa de frijoles...........$4.75 (3)");
                                    Console.WriteLine("Frijolitos borrachos.......$5.25 (4)");
                                    comb1 = int.Parse(Console.ReadLine());
                                    if (comb1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la entrada número" + " " + comb1 + " " + "y su precio es de " + "$" + (5.25 * cant));
                                        preciofinal = preciofinal + (5.25 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la entrada número" + " " + comb1 + " " + "y su precio es de " + "$" + (5.25 * cant));
                                        preciofinal = preciofinal + (5.25 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la entrada número" + " " + comb1 + " " + "y su precio es de " + "$" + (4.75 * cant));
                                        preciofinal = preciofinal + (4.75 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 4)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la entrada número" + " " + comb1 + " " + "y su precio es de " + "$" + (5.25 * cant));
                                        preciofinal = preciofinal + (5.25 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                                //MENU DESAYUNOS POLLO REAL
                                case ("2"):
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine("Burrito de Huevo, Plátano, Frijoles, Jamón, Tocino + Café................$6.90 (1)");
                                    Console.WriteLine("2 Huevos + Frijoles + Plátanos + Chorizo + Crema + Pan + Café............$6.70 (2)");
                                    Console.WriteLine("Tamal Pollo + Frijoles + Plátano + Crema + Café..........................$6.70 (1)");
                                    Console.WriteLine("2 Huevos + Frijoles + Plátanos + Chorizo + Crema + Pan + Café............$6.50 (2)");
                                    Console.WriteLine("Sándwich Huevo, Jamón, Tocino, Queso + Plátanos + Café...................$7.85 (2)");
                                    desa1 = int.Parse(Console.ReadLine());
                                    if (desa1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el desayuno número" + " " + desa1 + " " + "y su precio es de " + "$" + (6.90 * cant));
                                        preciofinal = preciofinal + (6.90 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (desa1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el desayuno número" + " " + desa1 + " " + "y su precio es de " + "$" + (6.70 * cant));
                                        preciofinal = preciofinal + (6.70 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (desa1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el desayuno número" + " " + desa1 + " " + "y su precio es de " + "$" + (6.70 * cant));
                                        preciofinal = preciofinal + (6.70 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (desa1 == 4)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el desayuno número" + " " + desa1 + " " + "y su precio es de " + "$" + (6.50 * cant));
                                        preciofinal = preciofinal + (6.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (desa1 == 5)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el desayuno número" + " " + desa1 + " " + "y su precio es de " + "$" + (7.85 * cant));
                                        preciofinal = preciofinal + (7.85 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                                //MENU POLLO POLLOS REAL
                                case ("3"):
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine("Pollo entero + Papas + Escabeche + 4 Panes.......................$15.95 (1)");
                                    Console.WriteLine("Pollo entero + Papas + Escabeche + 4 Panes + Soda 1.5 lt.........$17.45 (2)");
                                    Console.WriteLine("Pollo y medio + Papas + Escabeche + 6 Panes + Soda 1.5 lt........$25.75 (3)");
                                    Console.WriteLine("Medio Pollo + Papas + Escabeche + 2 Panes........................$8.85  (4)");
                                    Console.WriteLine("Medio Pollo + Papas + Escabeche + 2 Panes + Soda 1.5 lt..........$9.90  (5)");
                                    ham1 = int.Parse(Console.ReadLine());
                                    if (ham1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el menú de pollo número" + " " + ham1 + " " + "y su precio es de " + "$" + (15.95 * cant));
                                        preciofinal = preciofinal + (15.95 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (ham1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el menú de pollo número" + " " + ham1 + " " + "y su precio es de " + "$" + (17.45 * cant));
                                        preciofinal = preciofinal + (17.45 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (ham1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el menú de pollo número" + " " + ham1 + " " + "y su precio es de " + "$" + (25.75 * cant));
                                        preciofinal = preciofinal + (25.75 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (ham1 == 4)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el menú de pollo número" + " " + ham1 + " " + "y su precio es de " + "$" + (8.85 * cant));
                                        preciofinal = preciofinal + (8.85 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (ham1 == 5)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el menú de pollo número" + " " + ham1 + " " + "y su precio es de " + "$" + (9.90 * cant));
                                        preciofinal = preciofinal + (9.90 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                                //PLATOS ANTOJITOS POLLOS REAL
                                case ("4"):
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine("Empanadas Frijol........$2.10 (1)");
                                    Console.WriteLine("Nuegados................$2.10 (2)");
                                    Console.WriteLine("Tamal de Pollo..........$1.60 (3)");
                                    Console.WriteLine("Yuca Sancochada.........$5.00 (4)");
                                    Console.WriteLine("Plátanos en Miel........$1.75 (5)");
                                    Console.WriteLine("Pasteles de Pollo.......$2.75 (6)");
                                    Console.WriteLine("Plátanos Fritos.........$1.75 (7)");
                                    Console.WriteLine("Riguas..................$1.40 (8)");
                                    Console.WriteLine("Pan con Pollo...........$4.20 (9)");
                                    niños1 = int.Parse(Console.ReadLine());
                                    if (niños1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el antojito número" + " " + niños1 + " " + "y su precio es de " + "$" + (2.10 * cant));
                                        preciofinal = preciofinal + (2.10 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (niños1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el antojito número" + " " + niños1 + " " + "y su precio es de " + "$" + (2.10 * cant));
                                        preciofinal = preciofinal + (2.10 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (niños1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el antojito número" + " " + niños1 + " " + "y su precio es de " + "$" + (1.60 * cant));
                                        preciofinal = preciofinal + (1.60 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (niños1 == 4)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el antojito número" + " " + niños1 + " " + "y su precio es de " + "$" + (5 * cant));
                                        preciofinal = preciofinal + (5 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (niños1 == 5)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el antojito número" + " " + niños1 + " " + "y su precio es de " + "$" + (1.75 * cant));
                                        preciofinal = preciofinal + (1.75 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (niños1 == 6)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el antojito número" + " " + niños1 + " " + "y su precio es de " + "$" + (2.75 * cant));
                                        preciofinal = preciofinal + (2.75 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (niños1 == 7)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el antojito número" + " " + niños1 + " " + "y su precio es de " + "$" + (1.75 * cant));
                                        preciofinal = preciofinal + (1.75 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (niños1 == 8)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el antojito número" + " " + niños1 + " " + "y su precio es de " + "$" + (1.40 * cant));
                                        preciofinal = preciofinal + (1.40 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (niños1 == 9)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el antojito número" + " " + niños1 + " " + "y su precio es de " + "$" + (4.20 * cant));
                                        preciofinal = preciofinal + (4.20 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                                //MENU PUPUSAS POLLOS REAL
                                case ("5"):
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine("Frijol con Queso........$1.15 (1)");
                                    Console.WriteLine("Revueltas...............$1.15 (2)");
                                    Console.WriteLine("Queso con Loroco........$1.25 (3)");
                                    Console.WriteLine("Ayote...................$1.25 (4)");
                                    Console.WriteLine("Queso...................$1.15 (5)");
                                    Console.WriteLine("Chicharrón..............$1.15 (6)");
                                    Console.WriteLine("Chorizo.................$1.45 (7)");
                                    Console.WriteLine("Queso con Chipilín......$1.25 (8)");
                                    Console.WriteLine("Queso con Ajo...........$1.25 (9)");
                                    comb1 = int.Parse(Console.ReadLine());
                                    if (comb1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la pupusa número" + " " + comb1 + " " + "y su precio es de " + "$" + (1.15 * cant));
                                        preciofinal = preciofinal + (4.25 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la pupusa número" + " " + comb1 + " " + "y su precio es de " + "$" + (1.15 * cant));
                                        preciofinal = preciofinal + (7.25 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la pupusa número" + " " + comb1 + " " + "y su precio es de " + "$" + (1.25 * cant));
                                        preciofinal = preciofinal + (8.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 4)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la pupusa número" + " " + comb1 + " " + "y su precio es de " + "$" + (1.25 * cant));
                                        preciofinal = preciofinal + (4.25 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 5)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la pupusa número" + " " + comb1 + " " + "y su precio es de " + "$" + (1.15 * cant));
                                        preciofinal = preciofinal + (7.25 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 6)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la pupusa número" + " " + comb1 + " " + "y su precio es de " + "$" + (1.15 * cant));
                                        preciofinal = preciofinal + (8.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 7)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la pupusa número" + " " + comb1 + " " + "y su precio es de " + "$" + (1.45 * cant));
                                        preciofinal = preciofinal + (4.25 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 8)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la pupusa número" + " " + comb1 + " " + "y su precio es de " + "$" + (1.25 * cant));
                                        preciofinal = preciofinal + (7.25 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 9)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la pupusa número" + " " + comb1 + " " + "y su precio es de " + "$" + (1.25 * cant));
                                        preciofinal = preciofinal + (8.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                                //MENU ESPECIALES POLLOS REAL
                                case ("6"):
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine("Pechuga a la plancha + Vegetales + Chirmol + Tortilla.........$7.95  (1)");
                                    Console.WriteLine("Chicharrones (300 gramos).....................................$10.65 (2)");
                                    Console.WriteLine("Costillas ahumadas (340 gramos)...............................$10.65 (3)");
                                    Console.WriteLine("Costillas en salsa de barbacoa (340 gramos)...................$10.65 (4)");
                                    desa1 = int.Parse(Console.ReadLine());
                                    if (desa1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el especial número" + " " + desa1 + " " + "y su precio es de " + "$" + (7.95 * cant));
                                        preciofinal = preciofinal + (7.95 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (desa1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el especial número" + " " + desa1 + " " + "y su precio es de " + "$" + (10.65 * cant));
                                        preciofinal = preciofinal + (10.65 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (desa1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el especial número" + " " + desa1 + " " + "y su precio es de " + "$" + (10.65 * cant));
                                        preciofinal = preciofinal + (10.65 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (desa1 == 4)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el especial número" + " " + desa1 + " " + "y su precio es de " + "$" + (10.65 * cant));
                                        preciofinal = preciofinal + (10.65 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                                //MENU ENSALADAS POLLOS REAL
                                case ("7"):
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine("Pollo + Elote + Aceitunas + Tomate + Lechuga + Aderezo.............$7.75 (1)");
                                    Console.WriteLine("Lechuga Romana + Aderezo Ranch + Pechuga + Crotones + Queso........$7.75 (2)");
                                    ham1 = int.Parse(Console.ReadLine());
                                    if (ham1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la ensalada número" + " " + ham1 + " " + "y su precio es de " + "$" + (7.75 * cant));
                                        preciofinal = preciofinal + (7.75 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (ham1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la ensalada número" + " " + ham1 + " " + "y su precio es de " + "$" + (7.75 * cant));
                                        preciofinal = preciofinal + (7.75 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                                //MENU SÁNDWICH POLLOS REAL
                                case ("8"):
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine("Sándwich Jamón, Tocino, Queso, Pollo, Lechuga, Huevo, Tomate + Papas.........$7.25 (1)");
                                    Console.WriteLine("Sándwich Pechuga, Queso, Guacamol, Tomate + Papas............................$7.75 (2)");
                                    niños1 = int.Parse(Console.ReadLine());
                                    if (niños1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el sándwich número" + " " + niños1 + " " + "y su precio es de " + "$" + (7.25 * cant));
                                        preciofinal = preciofinal + (7.25 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (niños1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el sándwich número" + " " + niños1 + " " + "y su precio es de " + "$" + (7.75 * cant));
                                        preciofinal = preciofinal + (7.75 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                                //MENU POSTRES POLLOS REAL
                                case ("9"):
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine("Tres leches............$3.75 (1)");
                                    Console.WriteLine("Flan cubano............$3.30 (2)");
                                    Console.WriteLine("Cake de chocolate......$4.20 (3)");
                                    Console.WriteLine("Pie de higo............$3.30 (4)");
                                    Console.WriteLine("CPie de queso..........$4.30 (5)");
                                    niños1 = int.Parse(Console.ReadLine());
                                    if (niños1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el postre número" + " " + niños1 + " " + "y su precio es de " + "$" + (3.75 * cant));
                                        preciofinal = preciofinal + (3.75 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (niños1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el postre número" + " " + niños1 + " " + "y su precio es de " + "$" + (3.30 * cant));
                                        preciofinal = preciofinal + (3.30 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (niños1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el postre número" + " " + niños1 + " " + "y su precio es de " + "$" + (4.20 * cant));
                                        preciofinal = preciofinal + (4.20 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (niños1 == 4)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el postre número" + " " + niños1 + " " + "y su precio es de " + "$" + (3.30 * cant));
                                        preciofinal = preciofinal + (3.30 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (niños1 == 5)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el postre número" + " " + niños1 + " " + "y su precio es de " + "$" + (4.30 * cant));
                                        preciofinal = preciofinal + (4.30 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                            }
                        }
                        break;
                    //MENU KFC
                    case ("6"):
                        while (p == "Si")
                        {
                            Console.WriteLine("Bienvenido al menú de KFC, ¿Qué desea ordenar?");
                            Console.WriteLine("Banquetes (1)       Boxes   (2)   Hamburguesas (3)");
                            Console.WriteLine("  Pollo   (4)      Postres  (5)      Extras    (6)");
                            men1 = Console.ReadLine();
                            switch (men1)
                            {
                                //MENU BANQUETES KFC
                                case ("1"):
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine("6 Piezas + Papas + 3 Biscuits.......................................................$16.99 (1)");
                                    Console.WriteLine("6 Piezas + 2 Hamburguesas Kroncher + Papas + 3 Biscuits + Soda 1.5 lt...............$19.99 (2)");
                                    Console.WriteLine("50 Popcorn + 10 Strips + Papas + Soda 1.5 lt........................................$22.99 (3)");
                                    Console.WriteLine("8 Piezas + Papas + 4 Biscuits.......................................................$20.99 (4)");
                                    Console.WriteLine("8 Piezas + 3 Hamburguesas Kroncher + Puré + Papas + 4 Biscuits + Soda 1.5 lt........$29.99 (5)");
                                    Console.WriteLine("10 Piezas + Papas + 5 Biscuits......................................................$24.99 (6)");
                                    Console.WriteLine("7 Piezas + 2 Hamburguesas Kroncher + Papas + 3 Biscuits + Soda 1.5 lt...............$24.99 (7)");
                                    comb1 = int.Parse(Console.ReadLine());
                                    if (comb1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el banquete número" + " " + comb1 + " " + "y su precio es de " + "$" + (16.99 * cant));
                                        preciofinal = preciofinal + (16.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el banquete número" + " " + comb1 + " " + "y su precio es de " + "$" + (19.99 * cant));
                                        preciofinal = preciofinal + (19.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el banquete número" + " " + comb1 + " " + "y su precio es de " + "$" + (22.99 * cant));
                                        preciofinal = preciofinal + (22.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 4)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el banquete número" + " " + comb1 + " " + "y su precio es de " + "$" + (20.99 * cant));
                                        preciofinal = preciofinal + (20.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 5)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el banquete número" + " " + comb1 + " " + "y su precio es de " + "$" + (29.99 * cant));
                                        preciofinal = preciofinal + (29.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 6)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el banquete número" + " " + comb1 + " " + "y su precio es de " + "$" + (24.99 * cant));
                                        preciofinal = preciofinal + (24.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 7)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el banquete número" + " " + comb1 + " " + "y su precio es de " + "$" + (24.99 * cant));
                                        preciofinal = preciofinal + (24.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                                //MENU BOXES KFC
                                case ("2"):
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine("Hamburguesa Kroncher Coronel + Pieza Pollo + Puré + Biscuit + Soda  ..............$5.75  (1)");
                                    Console.WriteLine("2 Kroncher Corone + 2 Pieza Pollo + 2 Puré + 2 Biscuit Glaseado + 2 Sodas.........$12.00 (2)");
                                    Console.WriteLine("Big Crunch + Pieza Pollo + Papas + Puré + Soda....................................$9.99  (3)");
                                    Console.WriteLine("Hamburguesa Jr. Crunch + Pieza Pollo + Papas + Puré + Soda........................$9.00  (4)");
                                    Console.WriteLine("3 Hamburguesas Crunch Coronel + Pop Corn Familiar + Papa Frita Familiar...........$25.99 (5)");
                                    desa1 = int.Parse(Console.ReadLine());
                                    if (desa1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la box número" + " " + desa1 + " " + "y su precio es de " + "$" + (5.75 * cant));
                                        preciofinal = preciofinal + (5.75 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (desa1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la box número" + " " + desa1 + " " + "y su precio es de " + "$" + (12 * cant));
                                        preciofinal = preciofinal + (12 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (desa1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la box número" + " " + desa1 + " " + "y su precio es de " + "$" + (9.99 * cant));
                                        preciofinal = preciofinal + (9.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (desa1 == 4)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la box número" + " " + desa1 + " " + "y su precio es de " + "$" + (9 * cant));
                                        preciofinal = preciofinal + (9 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (desa1 == 5)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la box número" + " " + desa1 + " " + "y su precio es de " + "$" + (25.99 * cant));
                                        preciofinal = preciofinal + (25.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                                //MENU HAMBURGUESAS KFC
                                case ("3"):
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine("Hamburguesa Pechuga Pollo, Pepinillos, Mayonesa + Papas + Soda.....................................$7.25 (1)");
                                    Console.WriteLine("Hamburguesa Pechuga Pollo, Tomate, Aderezo Coronel, Queso + Papas + Soda...........................$8.25 (2)");
                                    Console.WriteLine("Hamburguesa Jr Pechuga Pollo, Tomate, Lechuga, Queso, Aderezo Coronel, Cebolla + Papas + Soda......$6.50 (3)");
                                    Console.WriteLine("Hamburguesa Pechuga Pollo, Lechuga, Ranch, Salsa Búffalo + Papas + Soda............................$8.25 (4)");
                                    Console.WriteLine("Hamburguesa Pechuga Pollo, Pepinillos, Ranch + BBQ + Papas + Soda..................................$8.25 (5)");
                                    ham1 = int.Parse(Console.ReadLine());
                                    if (ham1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la hamburguesa número" + " " + ham1 + " " + "y su precio es de " + "$" + (7.25 * cant));
                                        preciofinal = preciofinal + (7.25 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (ham1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la hamburguesa número" + " " + ham1 + " " + "y su precio es de " + "$" + (8.25 * cant));
                                        preciofinal = preciofinal + (8.25 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (ham1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la hamburguesa número" + " " + ham1 + " " + "y su precio es de " + "$" + (6.50 * cant));
                                        preciofinal = preciofinal + (6.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (ham1 == 4)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la hamburguesa número" + " " + ham1 + " " + "y su precio es de " + "$" + (8.25 * cant));
                                        preciofinal = preciofinal + (8.25 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (ham1 == 5)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la hamburguesa número" + " " + ham1 + " " + "y su precio es de " + "$" + (8.25 * cant));
                                        preciofinal = preciofinal + (8.25 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                                //MENU POLLO KFC
                                case ("4"):
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine("3 Piezas Pollo + Pop Corn individual + 2 Papas + 2 Sodas..........$15.00 (1)");
                                    Console.WriteLine("5 Piezas Pollo + 2 Papas + 2 Sodas ...............................$14.50 (2)");
                                    Console.WriteLine("3 Piezas Pollo + 3 Strips + 2 Papas + 2 Sodas.....................$15.00 (3)");
                                    Console.WriteLine("Pop Corn Mediano + Papas + Soda...................................$7.99  (4)");
                                    Console.WriteLine("6 Piezas Pollo + 2 Papas + Puré + Soda 1.5 lt.....................$13.99 (5)");
                                    Console.WriteLine("2 Piezas Pollo + 2 Papas + Biscuit + Soda.........................$7.75  (6)");
                                    Console.WriteLine("3 Piezas Pollo + Papas + Biscuit + Soda...........................$8.00  (7)");
                                    gourmet1 = int.Parse(Console.ReadLine());
                                    if (gourmet1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el menú de pollo número" + " " + gourmet1 + " " + "y su precio es de " + "$" + (15 * cant));
                                        preciofinal = preciofinal + (15 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (gourmet1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el menú de pollo número" + " " + gourmet1 + " " + "y su precio es de " + "$" + (14.50 * cant));
                                        preciofinal = preciofinal + (14.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (gourmet1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el menú de pollo número" + " " + gourmet1 + " " + "y su precio es de " + "$" + (15 * cant));
                                        preciofinal = preciofinal + (15 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (gourmet1 == 4)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el menú de pollo número" + " " + gourmet1 + " " + "y su precio es de " + "$" + (7.99 * cant));
                                        preciofinal = preciofinal + (7.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (gourmet1 == 5)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el menú de pollo número" + " " + gourmet1 + " " + "y su precio es de " + "$" + (13.99 * cant));
                                        preciofinal = preciofinal + (13.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (gourmet1 == 6)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el menú de pollo número" + " " + gourmet1 + " " + "y su precio es de " + "$" + (7.75 * cant));
                                        preciofinal = preciofinal + (7.75 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (gourmet1 == 7)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el menú de pollo número" + " " + gourmet1 + " " + "y su precio es de " + "$" + (8 * cant));
                                        preciofinal = preciofinal + (8 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                                //MENU POSTRES KFC
                                case ("5"):
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine("Pie de Queso Berry........$1.45 (1)");
                                    Console.WriteLine("Pie de manzana............$1.45 (2)");
                                    Console.WriteLine("Cheesecake Fresa..........$4.00 (3)");
                                    Console.WriteLine("Cheesecake Caramelo.......$4.00 (4)");
                                    niños1 = int.Parse(Console.ReadLine());
                                    if (niños1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el postre número" + " " + niños1 + " " + "y su precio es de " + "$" + (1.45 * cant));
                                        preciofinal = preciofinal + (1.45 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (niños1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el postre número" + " " + niños1 + " " + "y su precio es de " + "$" + (1.45 * cant));
                                        preciofinal = preciofinal + (1.45 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (niños1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el postre número" + " " + niños1 + " " + "y su precio es de " + "$" + (4 * cant));
                                        preciofinal = preciofinal + (4 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (niños1 == 4)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el postre número" + " " + niños1 + " " + "y su precio es de " + "$" + (4 * cant));
                                        preciofinal = preciofinal + (4 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                                //MENU EXTRAS KFC
                                case ("6"):
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine("1 Biscuit..............$0.55 (1)");
                                    Console.WriteLine("2 Biscuit..............$0.99 (2)");
                                    Console.WriteLine("3 Biscuit..............$1.45 (3)");
                                    Console.WriteLine("4 Biscuit..............$1.50 (4)");
                                    Console.WriteLine("Papa Frita Pequeña.....$2.00 (5)");
                                    Console.WriteLine("Papa Frita Mediana.....$2.25 (6)");
                                    Console.WriteLine("Papa Frita Grande......$2.55 (7)");
                                    post1 = int.Parse(Console.ReadLine());
                                    if (post1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el extra número" + " " + post1 + " " + "y su precio es de " + "$" + (0.55 * cant));
                                        preciofinal = preciofinal + (0.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (post1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el extra número" + " " + post1 + " " + "y su precio es de " + "$" + (0.99 * cant));
                                        preciofinal = preciofinal + (0.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (post1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el extra número" + " " + post1 + " " + "y su precio es de " + "$" + (1.45 * cant));
                                        preciofinal = preciofinal + (1.45 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (post1 == 4)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el extra número" + " " + post1 + " " + "y su precio es de " + "$" + (1.5 * cant));
                                        preciofinal = preciofinal + (1.5 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (post1 == 5)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el extra número" + " " + post1 + " " + "y su precio es de " + "$" + (2 * cant));
                                        preciofinal = preciofinal + (2 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (post1 == 6)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el extra número" + " " + post1 + " " + "y su precio es de " + "$" + (2.25 * cant));
                                        preciofinal = preciofinal + (2.25 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (post1 == 7)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el extra número" + " " + post1 + " " + "y su precio es de " + "$" + (2.55 * cant));
                                        preciofinal = preciofinal + (2.55 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                            }
                        }
                        break;
                }
                break;
            //MENU COMIDA CHINA
            case ("4"):
                Console.WriteLine("Que restaurante desea ordenar");
                Console.WriteLine("ChinaWok          (1)    Panda Express      (2)    Don Li - Las Ramblas  (3)");
                Console.WriteLine("Caifu Restaurante (4)    Celeste Imperio    (5)     ");
                ham = Console.ReadLine();
                switch (ham)
                {
                    //MENU CHINAWOK
                    case ("1"):
                        while (p == "Si")
                        {
                            Console.WriteLine("====================== RESTAURANTE CHINA WOK =========================");
                            Console.WriteLine();
                            Console.WriteLine("Bienvenido al menú de ChinaWok, ¿Qué desea ordenar?");
                            Console.WriteLine("Promociones (1)    Combos Personales  (2)      Banquetes (3)");
                            Console.WriteLine("Sopas       (4)    Entradas           (5)      Postres   (6)");
                            men1 = Console.ReadLine();
                            switch (men1)
                            {
                                //MENU PROMOCIONES CHINAWOK
                                case ("1"):
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine();
                                    Console.WriteLine("====================== MENU PROMOCIONES =========================");
                                    Console.WriteLine();
                                    Console.WriteLine("Bandeja para 3: arroz cantones  +  pollo al wok  +  3 panes ..........................$13.99 (1)");
                                    Console.WriteLine("Bandeja para 3: arroz cantones  +  Chaomein de Pollo al Wok  +  3 panes ..............$13.99 (2)");
                                    Console.WriteLine("Bandeja para 3: arroz cantones  +  Chop Suey de Pollo  +  3 panes.....................$13.99 (3)");
                                    Console.WriteLine("Bandeja para 3: arroz cantones  +  Camarones Agridulces  +  3 panes...................$21.99 (4)");
                                    Console.WriteLine("Bandeja para 3: arroz cantones  +  Camarones Dorados  +  3 panes......................$21.99 (5)");
                                    Console.WriteLine("Bandeja para 3: arroz cantones  +  Camarones con Vegetales al Wok +  3 panes..........$21.99 (6)");
                                    Console.WriteLine("Bandeja para 3: arroz cantones  +  Chop Suey de Camarones   +  3 panes................$21.99 (7)");
                                    comb1 = int.Parse(Console.ReadLine());
                                    if (comb1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la promoción número" + " " + comb1 + " " + "y su precio es de " + "$" + (13.99 * cant));
                                        preciofinal = preciofinal + (13.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la promoción número" + " " + comb1 + " " + "y su precio es de " + "$" + (13.99 * cant));
                                        preciofinal = preciofinal + (13.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la promoción número" + " " + comb1 + " " + "y su precio es de " + "$" + (13.99 * cant));
                                        preciofinal = preciofinal + (13.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 4)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la promoción número" + " " + comb1 + " " + "y su precio es de " + "$" + (21.99 * cant));
                                        preciofinal = preciofinal + (21.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 5)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la promoción número" + " " + comb1 + " " + "y su precio es de " + "$" + (21.99 * cant));
                                        preciofinal = preciofinal + (21.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 6)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la promoción número" + " " + comb1 + " " + "y su precio es de " + "$" + (21.99 * cant));
                                        preciofinal = preciofinal + (21.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 7)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la promoción número" + " " + comb1 + " " + "y su precio es de " + "$" + (21.99 * cant));
                                        preciofinal = preciofinal + (21.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                                //MENU COMBOS PERSONALES CHINAWOK
                                case ("2"):
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine("======================MENU COMBOS PERSONALES=========================");
                                    Console.WriteLine();
                                    Console.WriteLine("Combo Pollo: Pollo Orange       +   Arroz Cantones + Bebida (Pepsi / Mirinda / 7 Up).................$7.99  (1)");
                                    Console.WriteLine("Combo Pollo: Pollo Red Dragon   +   Arroz Cantones + Bebida (Pepsi / Mirinda / 7 Up).................$7.99  (2)");
                                    Console.WriteLine("Combo Pollo: Chaomein con Pollo +   Arroz Cantones + Bebida (Pepsi / Mirinda / 7 Up).................$7.99  (3)");
                                    Console.WriteLine("Combo Camarones: Camarones con Vegetales + Arroz Cantones + Bebida (Pepsi / Mirinda / 7 Up ).........$11.50 (4)");
                                    Console.WriteLine("Combo Camarones: Camarones Empanizados   + Arroz Cantones + Bebida (Pepsi / Mirinda / 7 Up ).........$11.50 (5)");
                                    Console.WriteLine("Combo Carnes: Lomito con Vegetales al Wok + Arroz Cantones + Bebida (Pepsi / Mirinda / 7 Up )........$8.99  (6)");
                                    Console.WriteLine("Combo Carnes: Chaomein con Lomito         + Arroz Cantones + Bebida (Pepsi / Mirinda / 7 Up )........$8.99  (7)");
                                    comb1 = int.Parse(Console.ReadLine());
                                    if (comb1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el combo personal número" + " " + comb1 + " " + "y su precio es de " + "$" + (7.99 * cant));
                                        preciofinal = preciofinal + (7.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el combo personal número" + " " + comb1 + " " + "y su precio es de " + "$" + (7.99 * cant));
                                        preciofinal = preciofinal + (7.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el combo personal número" + " " + comb1 + " " + "y su precio es de " + "$" + (7.99 * cant));
                                        preciofinal = preciofinal + (7.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 4)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el combo personal número" + " " + comb1 + " " + "y su precio es de " + "$" + (11.50 * cant));
                                        preciofinal = preciofinal + (11.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 5)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el combo personal número" + " " + comb1 + " " + "y su precio es de " + "$" + (11.50 * cant));
                                        preciofinal = preciofinal + (11.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 6)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el combo personal número" + " " + comb1 + " " + "y su precio es de " + "$" + (8.99 * cant));
                                        preciofinal = preciofinal + (8.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 7)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el combo personal número" + " " + comb1 + " " + "y su precio es de " + "$" + (8.99 * cant));
                                        preciofinal = preciofinal + (8.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                                //MENU BANQUETES CHINAWOK
                                case ("3"):
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine();
                                    Console.WriteLine("====================== MENU BANQUETES =========================");
                                    Console.WriteLine();
                                    Console.WriteLine("==================== BANQUETES DE POLLO PARA 4 PERSONAS =========================");
                                    Console.WriteLine(" Pollo con Vegetales al Wok + Arroz Cantones con Pollo + 4 panes + 4 wantanes ....................... $21.25 (1)");
                                    Console.WriteLine(" Pollo Orange               + Arroz Cantones con Pollo + 4 panes + 4 wantanes ....................... $22.50 (2)");
                                    Console.WriteLine(" Pollo Red Dragon           + Arroz Cantones con Pollo + 4 panes + 4 wantanes ....................... $22.50 (3)");
                                    Console.WriteLine(" Lomito con Vegetales al Wok + Arroz Cantones con Pollo + 4 panes + 4 wantanes ...................... $25.99 (4)");
                                    Console.WriteLine(" Pierna Asada al Ajo  + Arroz Cantones con Pollo + 4 panes + 4 wantanes ............................. $25.99 (5)");
                                    Console.WriteLine(" Chaomein con Lomito  + Arroz Cantones con Pollo + 4 panes + 4 wantanes ............................. $25.99 (6)");
                                    Console.WriteLine(" Lomito con de Cerdo al Wok con Vegetales + Arroz Cantones con Pollo +  4 panes + 4 wantanes ........ $25.90 (7)");
                                    comb1 = int.Parse(Console.ReadLine());
                                    if (comb1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el banquete número" + " " + comb1 + " " + "y su precio es de " + "$" + (21.25 * cant));
                                        preciofinal = preciofinal + (21.25 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el banquete número" + " " + comb1 + " " + "y su precio es de " + "$" + (22.50 * cant));
                                        preciofinal = preciofinal + (22.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el banquete número" + " " + comb1 + " " + "y su precio es de " + "$" + (22.50 * cant));
                                        preciofinal = preciofinal + (22.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 4)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el banquete número" + " " + comb1 + " " + "y su precio es de " + "$" + (25.99 * cant));
                                        preciofinal = preciofinal + (25.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 5)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el banquete número" + " " + comb1 + " " + "y su precio es de " + "$" + (25.99 * cant));
                                        preciofinal = preciofinal + (25.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 6)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el banquete número" + " " + comb1 + " " + "y su precio es de " + "$" + (25.99 * cant));
                                        preciofinal = preciofinal + (25.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 7)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el banquete número" + " " + comb1 + " " + "y su precio es de " + "$" + (25.90 * cant));
                                        preciofinal = preciofinal + (25.90 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                                //MENU SOPAS CHINAWOK
                                case ("4"):
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine();
                                    Console.WriteLine("====================== MENU SOPAS =========================");
                                    Console.WriteLine();
                                    Console.WriteLine("Sopa 16 onzas  : Sopa Mein de Pollo  .......................................................... $2.75 (1)");
                                    Console.WriteLine("Sopa 16 onzas  : Sopa Mein de Lomito .......................................................... $2.99 (2)");
                                    Console.WriteLine("Combo Sopa : Sopa Mein de Lomito + 1 pan + 1 wantan + Bebida (Pepsi / Mirinda / 7 Up).......... $7.25 (3)");
                                    Console.WriteLine("Combo Sopa : Sopa Mein de Pollo  + 1 pan + 1 wantan + Bebida (Pepsi / Mirinda / 7 Up).......... $6.25 (4)");
                                    Console.WriteLine("Combo Sopa : Sopa Mein de Camarones  + 1 pan + 1 wantan + Bebida (Pepsi / Mirinda / 7 Up)...... $8.25 (5)");
                                    comb1 = int.Parse(Console.ReadLine());

                                    if (comb1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la sopa número" + " " + comb1 + " " + "y su precio es de " + "$" + (2.75 * cant));
                                        preciofinal = preciofinal + (2.75 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la sopa número" + " " + comb1 + " " + "y su precio es de " + "$" + (2.99 * cant));
                                        preciofinal = preciofinal + (2.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la sopa número" + " " + comb1 + " " + "y su precio es de " + "$" + (7.25 * cant));
                                        preciofinal = preciofinal + (7.25 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 4)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la sopa número" + " " + comb1 + " " + "y su precio es de " + "$" + (6.25 * cant));
                                        preciofinal = preciofinal + (6.25 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 5)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la sopa número" + " " + comb1 + " " + "y su precio es de " + "$" + (8.25 * cant));
                                        preciofinal = preciofinal + (8.25 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                                //MENU ENTRADAS CHINAWOK
                                case ("5"):
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine();
                                    Console.WriteLine("====================== MENU ENTRADAS =========================");
                                    Console.WriteLine();
                                    Console.WriteLine("3 Rollitos de Pollo ............................................. $1.50 (1)");
                                    Console.WriteLine("Pincho Ping Pong Individual ..................................... $1.25 (2)");
                                    Console.WriteLine("6 wantanes ...................................................... $3.99 (3)");
                                    Console.WriteLine("12 wantanes  .................................................... $5.75 (4)");
                                    Console.WriteLine("6 Rollitos de Pollo / Jamon...................................... $4.25 (5)");
                                    comb1 = int.Parse(Console.ReadLine());
                                    if (comb1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la entrada número" + " " + comb1 + " " + "y su precio es de " + "$" + (1.50 * cant));
                                        preciofinal = preciofinal + (1.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la entrada número" + " " + comb1 + " " + "y su precio es de " + "$" + (1.25 * cant));
                                        preciofinal = preciofinal + (1.25 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la entrada número" + " " + comb1 + " " + "y su precio es de " + "$" + (3.99 * cant));
                                        preciofinal = preciofinal + (3.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 4)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la entrada número" + " " + comb1 + " " + "y su precio es de " + "$" + (5.75 * cant));
                                        preciofinal = preciofinal + (5.75 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 5)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la entrada número" + " " + comb1 + " " + "y su precio es de " + "$" + (4.25 * cant));
                                        preciofinal = preciofinal + (4.25 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                                //MENU POSTRES CHINAWOK
                                case ("6"):
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine();
                                    Console.WriteLine("====================== MENU POSTRES =========================");
                                    Console.WriteLine();
                                    Console.WriteLine("Muralla de Chocolate (Para 1 Persona) ............................................. $1.50 (1)");
                                    comb1 = int.Parse(Console.ReadLine());
                                    if (comb1 == 1)
                                    {

                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el postre número" + " " + comb1 + " " + "y su precio es de " + "$" + (1.50 * cant));
                                        preciofinal = preciofinal + (1.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                            }
                        }
                        break;
                    case ("2"):
                        while (p == "Si")
                        {
                            Console.WriteLine("====================== RESTAURANTE PANDA EXPRESS =========================");
                            Console.WriteLine();
                            Console.WriteLine("Bienvenido al menú de Panda Express, ¿Qué desea ordenar?");
                            Console.WriteLine("Promociones        (1)    Presentaciones     (2)      Banquetes      (3)");
                            Console.WriteLine("Cajas a la Carta   (4)    Acompañamientos    (5)      Para Compartir (6)");
                            men1 = Console.ReadLine();
                            switch (men1)
                            {
                                //MENU PROMOCIONES PANDA EXPRESS
                                case ("1"):
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine();
                                    Console.WriteLine("====================== MENU PROMOCIONES =========================");
                                    Console.WriteLine();
                                    Console.WriteLine("2 Bowls de Orange Chicken y Arroz Frito ............... $9.50  (1)");
                                    Console.WriteLine("1 Bowl de Pollo Kung Pao  y Arroz Frito ............... $4.00  (2)");
                                    Console.WriteLine("1 Bowl de Pollo Teriyaky  y Arroz Frito ............... $9.50  (3)");
                                    Console.WriteLine("3 Bowls de Orange Chicken  y Arroz Frito .............. $12.20 (4)");
                                    Console.WriteLine("3 Bowls de Pollo Kung Pao  y Arroz Frito .............. $12.20 (5)");
                                    comb1 = int.Parse(Console.ReadLine());

                                    if (comb1 == 1)
                                    {

                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la promocion número" + " " + comb1 + " " + "y su precio es de " + "$" + (9.50 * cant));
                                        preciofinal = preciofinal + (9.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();

                                    }
                                    if (comb1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la promocion número" + " " + comb1 + " " + "y su precio es de " + "$" + (4.00 * cant));
                                        preciofinal = preciofinal + (4.00 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();

                                    }
                                  
                                    if (comb1 == 3)
                                    {

                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la promocion número" + " " + comb1 + " " + "y su precio es de " + "$" + (9.50 * cant));
                                        preciofinal = preciofinal + (9.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();

                                    }
                                    if (comb1 == 4)
                                    {

                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la promocion número" + " " + comb1 + " " + "y su precio es de " + "$" + (12.20 * cant));
                                        preciofinal = preciofinal + (12.20 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();

                                    }   
                                    if (comb1 == 5)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la promocion número" + " " + comb1 + " " + "y su precio es de " + "$" + (12.20 * cant));
                                        preciofinal = preciofinal + (12.20 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                break;
                                case ("2"):
                                    //MENU PRESENTACIONES PANDA EXPRESS
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine();
                                    Console.WriteLine("====================== MENU PRESENTACIONES =========================");
                                    Console.WriteLine();
                                    Console.WriteLine("1 Bowl de Orange Chicken + Arroz Frito + Galleta de la Fortuna .................... $6.10  (1)");
                                    Console.WriteLine("1 Bowl de Brocoli Chicken + Arroz Frito + Galleta de la Fortuna ................... $6.10  (2)");
                                    Console.WriteLine("1 Bowl de Balck Pepper Chicken + Arroz Frito + Galleta de la Fortuna............... $6.10  (3)");
                                    Console.WriteLine("Plato de Camarones al WoK + Arroz Frito + Galleta de la Fortuna ................... $8.45  (4)");
                                    Console.WriteLine("Plato de Pollo Black Pepper  + Arroz Frito  + Galleta de la Fortuna ............... $8.45  (5)");
                                    Console.WriteLine("Plato Grande de Pollo Black Pepper  + Arroz Frito  + Galleta de la Fortuna ....... $10.85  (6)");
                                    Console.WriteLine("Plato Grande de Orange Chicken + Arroz Frito  + Galleta de la Fortuna ............ $10.85  (7)");
                                    Console.WriteLine("Plato Grande de Camarones al WoK + Arroz Frito + Galleta de la Fortuna ........... $12.35  (8)");
                                    Console.WriteLine("Burrito de Orange Chicken + 2 complementos de arroz + salsa de cebollin ........... $6.10  (9)");
                                    Console.WriteLine("Burrito de Kung Pao Chicken + 2 complementos de arroz + salsa de cebollin ......... $6.10  (10)");
                                    Console.WriteLine("Burrito de Camarones al Wok + 2 complementos de arroz + salsa de cebollin ......... $6.10  (11)");
                                    comb1 = int.Parse(Console.ReadLine());
                                    if (comb1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la presentacion número" + " " + comb1 + " " + "y su precio es de " + "$" + (6.10 * cant));
                                        preciofinal = preciofinal + (6.10 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();

                                    }
                                    if (comb1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la presentacion número" + " " + comb1 + " " + "y su precio es de " + "$" + (6.10 * cant));
                                        preciofinal = preciofinal + (6.10 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la presentacion número" + " " + comb1 + " " + "y su precio es de " + "$" + (6.10 * cant));
                                        preciofinal = preciofinal + (6.10 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 4)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la presentacion número" + " " + comb1 + " " + "y su precio es de " + "$" + (8.45 * cant));
                                        preciofinal = preciofinal + (8.45 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 5)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la presentacion número" + " " + comb1 + " " + "y su precio es de " + "$" + (8.45 * cant));
                                        preciofinal = preciofinal + (8.45 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 6)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la presentacion número" + " " + comb1 + " " + "y su precio es de " + "$" + (10.85 * cant));
                                        preciofinal = preciofinal + (10.85 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 7)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la presentacion número" + " " + comb1 + " " + "y su precio es de " + "$" + (10.85 * cant));
                                        preciofinal = preciofinal + (10.85 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 8)
                                    {

                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la presentacion número" + " " + comb1 + " " + "y su precio es de " + "$" + (12.35 * cant));
                                        preciofinal = preciofinal + (12.35 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 9)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la presentacion número" + " " + comb1 + " " + "y su precio es de " + "$" + (6.10 * cant));
                                        preciofinal = preciofinal + (6.10 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 10)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la presentacion número" + " " + comb1 + " " + "y su precio es de " + "$" + (6.10 * cant));
                                        preciofinal = preciofinal + (6.10 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 11)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la presentacion número" + " " + comb1 + " " + "y su precio es de " + "$" + (6.10 * cant));
                                        preciofinal = preciofinal + (6.10 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                                //MENU BANQUETES PANDA EXPRESS
                                case ("3"):
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine();
                                    Console.WriteLine("====================== MENU BANQUETES =========================");
                                    Console.WriteLine();
                                    Console.WriteLine("Banquete Familiar Mediano de Orange Chicken + 1 Complemento de Arroz Frito + Bebida Pepsi ........... $27.90  (1)");
                                    Console.WriteLine("Banquete Familiar Mediano de Pollo Kung Pao + 1 Complemento de Arroz Frito + Bebida Pepsi ........... $27.90  (2)");
                                    Console.WriteLine("Banquete Familiar Mediano de Pollo Black Pepper + 1 Complemento de Arroz Frito + Bebida Pepsi ....... $27.90  (3)");
                                    Console.WriteLine("Banquete Familiar Mediano de Camarones al Wok + 1 Complemento de Arroz Frito + Bebida Pepsi ......... $36.89  (4)");
                                    comb1 = int.Parse(Console.ReadLine());
                                    if (comb1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la banquete número" + " " + comb1 + " " + "y su precio es de " + "$" + (27.90 * cant));
                                        preciofinal = preciofinal + (27.90 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la banquete número" + " " + comb1 + " " + "y su precio es de " + "$" + (27.90 * cant));
                                        preciofinal = preciofinal + (27.90 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la banquete número" + " " + comb1 + " " + "y su precio es de " + "$" + (27.90 * cant));
                                        preciofinal = preciofinal + (27.90 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 4)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la banquete número" + " " + comb1 + " " + "y su precio es de " + "$" + (36.89 * cant));
                                        preciofinal = preciofinal + (36.89 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                                //MENU DE CAJAS A LA CARTA PANDA EXPRESS
                                case ("4"):
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine();
                                    Console.WriteLine("====================== MENU DE CAJAS A LA CARTA =========================");
                                    Console.WriteLine();
                                    Console.WriteLine("Caja Grande de Chow Mein  ................ $6.10   (1)");
                                    Console.WriteLine("Caja Grande de Mix de Vegetales  ......... $6.10   (2)");
                                    Console.WriteLine("Caja Grande de Arroz Frito  .............. $6.10   (3)");
                                    Console.WriteLine("Caja Grande de Arroz Blanco  ............. $6.10   (4)");
                                    Console.WriteLine("Caja Mediana de Pollo Teriyaki  .......... $8.60   (5)");
                                    Console.WriteLine("Caja Mediana de Pollo Kung Pao  .......... $8.60   (6)");
                                    Console.WriteLine("Caja Mediana de Pollo Black Pepper  ...... $8.60   (7)");
                                    Console.WriteLine("Caja Grande de Orange Chicken  ........... $12.25  (8)");
                                    Console.WriteLine("Caja Grande de Pollo Kung Pao  ........... $12.25  (9)");
                                    Console.WriteLine("Caja Grande de Pollo Black Pepper  ....... $12.25  (10)");
                                    comb1 = int.Parse(Console.ReadLine());
                                    if (comb1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la caja grande de complementos número" + " " + comb1 + " " + "y su precio es de " + "$" + (6.10 * cant));
                                        preciofinal = preciofinal + (6.10 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la caja grande de complementos número" + " " + comb1 + " " + "y su precio es de " + "$" + (6.10 * cant));
                                        preciofinal = preciofinal + (6.10 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la caja grande de complementos número" + " " + comb1 + " " + "y su precio es de " + "$" + (6.10 * cant));
                                        preciofinal = preciofinal + (6.10 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 4)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la caja grande de complementos número" + " " + comb1 + " " + "y su precio es de " + "$" + (6.10 * cant));
                                        preciofinal = preciofinal + (6.10 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 5)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la caja mediana número" + " " + comb1 + " " + "y su precio es de " + "$" + (8.60 * cant));
                                        preciofinal = preciofinal + (8.60 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 6)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la caja mediana número" + " " + comb1 + " " + "y su precio es de " + "$" + (8.60 * cant));
                                        preciofinal = preciofinal + (8.60 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 7)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la caja mediana número" + " " + comb1 + " " + "y su precio es de " + "$" + (8.60 * cant));
                                        preciofinal = preciofinal + (8.60 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }

                                    if (comb1 == 8)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la caja grande número" + " " + comb1 + " " + "y su precio es de " + "$" + (12.25 * cant));
                                        preciofinal = preciofinal + (12.25 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 9)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la caja grande número" + " " + comb1 + " " + "y su precio es de " + "$" + (12.25 * cant));
                                        preciofinal = preciofinal + (12.25 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 10)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la caja grande número" + " " + comb1 + " " + "y su precio es de " + "$" + (12.25 * cant));
                                        preciofinal = preciofinal + (12.25 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }

                                    break;
                                //MENU ACOMPAÑAMIENTOS PANDA EXPRESS
                                case ("5"):
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine();
                                    Console.WriteLine("====================== MENU ACOMPAÑAMIENTOS =========================");
                                    Console.WriteLine();
                                    Console.WriteLine("Rollito de Primavera  ....................... $1.80  (1)");
                                    Console.WriteLine("Wantan Indiviual  ........................... $1.10  (2)");
                                    Console.WriteLine("Wantan de Caramelo .......................... $1.60  (3)");
                                    Console.WriteLine("Wantan de Carne  ............................ $1.80  (4)");
                                    Console.WriteLine("Paquete de 10 Galletas de la Fortuna  ....... $1.90  (5)");
                                    comb1 = int.Parse(Console.ReadLine());
                                    if (comb1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el acompañamiento número" + " " + comb1 + " " + "y su precio es de " + "$" + (1.80 * cant));
                                        preciofinal = preciofinal + (1.80 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el acompañamiento número" + " " + comb1 + " " + "y su precio es de " + "$" + (1.10 * cant));
                                        preciofinal = preciofinal + (1.10 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el acompañamiento número" + " " + comb1 + " " + "y su precio es de " + "$" + (1.60 * cant));
                                        preciofinal = preciofinal + (1.60 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 4)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el acompañamiento número" + " " + comb1 + " " + "y su precio es de " + "$" + (1.80 * cant));
                                        preciofinal = preciofinal + (1.80 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 5)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el acompañamiento número" + " " + comb1 + " " + "y su precio es de " + "$" + (1.90 * cant));
                                        preciofinal = preciofinal + (1.90 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                                //MENU PARA COMPARTIR PANDA EXPRESS
                                case ("6"):
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine();
                                    Console.WriteLine("====================== MENU PARA COMPARTIR =========================");
                                    Console.WriteLine();
                                    Console.WriteLine("Bandeja Pollo Orange ....................... $36.90  (1)");
                                    Console.WriteLine("Bandeja Pollo Teriyaki ..................... $49.25  (2)");
                                    comb1 = int.Parse(Console.ReadLine());
                                    if (comb1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el menu para compartir en familia número" + " " + comb1 + " " + "y su precio es de " + "$" + (36.90 * cant));
                                        preciofinal = preciofinal + (36.90 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el menu para compartir en familia número" + " " + comb1 + " " + "y su precio es de " + "$" + (49.25 * cant));
                                        preciofinal = preciofinal + (49.25 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                            }
                        }
                        break;
                    case ("3"):
                        while (p == "Si")
                        {
                            Console.WriteLine("====================== RESTAURANTE DON LI - LAS RAMBLAS =========================");
                            Console.WriteLine();
                            Console.WriteLine("Bienvenido al menú de Don Li - Las Ramblas, ¿Qué desea ordenar?");
                            Console.WriteLine("Ofertas        (1)    Combo Personal     (2)      Combos para Compartir      (3)");
                            Console.WriteLine("Sushi Rolls    (4)    Ramen              (5)      Sopas                      (6)");
                            Console.WriteLine("Bebidas        (7)                                                              ");
                            men1 = Console.ReadLine();
                            switch (men1)
                            {
                                //MENU OFERTAS DON LI
                                case ("1"):
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine();
                                    Console.WriteLine("====================== MENU OFERTAS =========================");
                                    Console.WriteLine();
                                    Console.WriteLine("10 Wantanes de Pollo + Salsa de su Eleccion ............ $5.00   (1)");
                                    Console.WriteLine("Sushi relleno de Camaron + Aguacate + Queso Crema....... $10.00  (2)");
                                    Console.WriteLine("Sushi Relleno de Cangrejo + Aguacate + Pepino .......... $8.00   (3)");
                                    comb1 = int.Parse(Console.ReadLine());
                                    if (comb1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la oferta número" + " " + comb1 + " " + "y su precio es de " + "$" + (5.00 * cant));
                                        preciofinal = preciofinal + (5.00 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la oferta número" + " " + comb1 + " " + "y su precio es de " + "$" + (10.00 * cant));
                                        preciofinal = preciofinal + (10.00 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();

                                    }
                                    if (comb1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la oferta número" + " " + comb1 + " " + "y su precio es de " + "$" + (8.00 * cant));
                                        preciofinal = preciofinal + (8.00 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                                //MENU COMBO PERSONAL DON LI
                                case ("2"):
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine();
                                    Console.WriteLine("====================== MENU COMBO PERSONAL =========================");
                                    Console.WriteLine();
                                    Console.WriteLine("Combo de Pollo Teriyaki con Vegetales + Arroz Cantones ........... $10.25  (1)");
                                    Console.WriteLine("Combo de Pollo Kung Pao con Vegetales + Arroz Cantones ........... $10.25  (2)");
                                    Console.WriteLine("Combo de Pollo en Salsa Naranja + Arroz Cantones ................. $10.25  (3)");
                                    Console.WriteLine("Combo de Lomito de Res con Vegetales + Arroz Cantones ............ $10.00  (4)");
                                    Console.WriteLine("Combo de Lomito de Res KungPao + Arroz Cantones .................. $11.75  (5)");
                                    Console.WriteLine("Combo de Lomito de Res Teriyaki + Arroz Cantones ................. $11.75  (6)");
                                    Console.WriteLine("Combo de Camarones con Vegetales + Arroz Cantones ................ $11.00  (7)");
                                    Console.WriteLine("Combo de Camarones KungPao + Arroz Cantones ...................... $12.75  (8)");
                                    comb1 = int.Parse(Console.ReadLine());
                                    if (comb1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el combo personal numero" + " " + comb1 + " " + "y su precio es de " + "$" + (10.25 * cant));
                                        preciofinal = preciofinal + (10.25 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 2)
                                    {

                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el combo personal numero" + " " + comb1 + " " + "y su precio es de " + "$" + (10.25 * cant));
                                        preciofinal = preciofinal + (10.25 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el combo personal numero" + " " + comb1 + " " + "y su precio es de " + "$" + (10.25 * cant));
                                        preciofinal = preciofinal + (10.25 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 4)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el combo personal numero" + " " + comb1 + " " + "y su precio es de " + "$" + (10.00 * cant));
                                        preciofinal = preciofinal + (10.00 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 5)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el combo personal numero" + " " + comb1 + " " + "y su precio es de " + "$" + (11.75 * cant));
                                        preciofinal = preciofinal + (11.75 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 6)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el combo personal numero" + " " + comb1 + " " + "y su precio es de " + "$" + (11.75 * cant));
                                        preciofinal = preciofinal + (11.75 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 7)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el combo personal numero" + " " + comb1 + " " + "y su precio es de " + "$" + (11.00 * cant));
                                        preciofinal = preciofinal + (11.00 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 8)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el combo personal numero " + " " + comb1 + " " + "y su precio es de " + "$" + (12.75 * cant));
                                        preciofinal = preciofinal + (12.75 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                                //MENU COMBOS PARA COMPARTIR DON LI 
                                case ("3"):
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine();
                                    Console.WriteLine("====================== MENU COMBO PARA COMPARTIR =========================");
                                    Console.WriteLine();
                                    Console.WriteLine("3 Sushi Rolls Crunchy Crab  ...................................... $18.00  (1)");
                                    Console.WriteLine("3 Sushi Rolls California  ........................................ $18.00  (2)");
                                    Console.WriteLine("1 arroz cantones y 1 chao mein con pollo + 10 wantanes ........... $27.00  (3)");
                                    Console.WriteLine("1 Porcion de Pollo + 1 Arroz Cantones + 10 wantanes .............. $22.00  (4)");
                                    Console.WriteLine("5 Sushi Rolls California Tradicional ............................. $32.00  (5)");
                                    Console.WriteLine("5 Sushi Rolls Crunchy Crab........................................ $32.00  (6)");
                                    comb1 = int.Parse(Console.ReadLine());
                                    if (comb1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el combo para compartir en familia numero " + " " + comb1 + " " + "y su precio es de " + "$" + (18.00 * cant));
                                        preciofinal = preciofinal + (18.00 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el combo para compartir en familia numero" + " " + comb1 + " " + "y su precio es de " + "$" + (18.00 * cant));
                                        preciofinal = preciofinal + (18.00 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el combo para compartir en familia numero" + " " + comb1 + " " + "y su precio es de " + "$" + (27.00 * cant));
                                        preciofinal = preciofinal + (27.00 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 4)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el combo para compartir en familia numero" + " " + comb1 + " " + "y su precio es de " + "$" + (22.00 * cant));
                                        preciofinal = preciofinal + (22.00 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 5)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el combo para compartir en familia numero" + " " + comb1 + " " + "y su precio es de " + "$" + (32.00 * cant));
                                        preciofinal = preciofinal + (32.00 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 6)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el combo para compartir en familia numero" + " " + comb1 + " " + "y su precio es de " + "$" + (32.00 * cant));
                                        preciofinal = preciofinal + (32.00 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                                //MENU SUSHI ROLLS 
                                case ("4"):
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine();
                                    Console.WriteLine("====================== MENU SUSHI ROLLS =========================");
                                    Console.WriteLine();
                                    Console.WriteLine("Sushi California Relleno de Cangrejo + Pepino + Aguacate + Salsa Extra ............................... $7.00  (1)");
                                    Console.WriteLine("Sushi Miami Relleno de Cangrejo y Camarones + Aguacate + Salsa Extra + Queso Crema ................... $10.50 (2)");
                                    Console.WriteLine("Sushi Crunchy Crab Relleno de Cangrejo  + Pepino + Aguacate + Salsa Extra ............................ $8.00  (3)");
                                    Console.WriteLine("Sushi Char Siu Relleno de Cerdo Asado + Pepino + Queso Crema + Salsa Extra ........................... $9.50  (4)");
                                    Console.WriteLine("Sushi Crunchy Crab Relleno de Cangrejo  + Pepino + Aguacate + Salsa Extra ............................ $8.00  (5)");
                                    Console.WriteLine("Sushi Dancing Roll Relleno de Cangrejo  + Kanikama + Aguacate + Queso Crema + Salsa Extra ............ $8.50  (6)");
                                    comb1 = int.Parse(Console.ReadLine());
                                    if (comb1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el Sushi Roll numero" + " " + comb1 + " " + "y su precio es de " + "$" + (7.00 * cant));
                                        preciofinal = preciofinal + (7.00 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el Sushi Roll numero" + " " + comb1 + " " + "y su precio es de " + "$" + (10.50 * cant));
                                        preciofinal = preciofinal + (10.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el Sushi Roll numero" + " " + comb1 + " " + "y su precio es de " + "$" + (8.00 * cant));
                                        preciofinal = preciofinal + (8.00 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 4)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el Sushi Roll numero" + " " + comb1 + " " + "y su precio es de " + "$" + (9.50 * cant));
                                        preciofinal = preciofinal + (9.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 5)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el Sushi Roll numero" + " " + comb1 + " " + "y su precio es de " + "$" + (8.00 * cant));
                                        preciofinal = preciofinal + (8.00 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 6)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el Sushi Roll numero" + " " + comb1 + " " + "y su precio es de " + "$" + (8.50 * cant));
                                        preciofinal = preciofinal + (8.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                                //MENU RAMEN
                                case ("5"):
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine();
                                    Console.WriteLine("====================== MENU RAMEN =========================");
                                    Console.WriteLine();
                                    Console.WriteLine("Don Li Ramen con: Cerdo Asado + Hongo Shikate + Alga Nori + Cebollin + Camaron Salteado .............. $12.00 (1)");
                                    Console.WriteLine("Spicy Ramen con Lomo de Cerdo Empanizado + Naruto + Cebollin + Huevo Hervido ......................... $13.50 (2)");
                                    Console.WriteLine("Ramen Thai: Caldo de Pollo + Leche de Coco + Cilantro y Chile Thai + Camarones ....................... $14.00 (3)");
                                    comb1 = int.Parse(Console.ReadLine());
                                    if (comb1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el Ramen numero" + " " + comb1 + " " + "y su precio es de " + "$" + (12.00 * cant));
                                        preciofinal = preciofinal + (12.00 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el Ramen numero" + " " + comb1 + " " + "y su precio es de " + "$" + (13.50 * cant));
                                        preciofinal = preciofinal + (13.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el Ramen numero" + " " + comb1 + " " + "y su precio es de " + "$" + (14.00 * cant));
                                        preciofinal = preciofinal + (14.00 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                                //MENU SOPAS DON LI
                                case ("6"):
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine();
                                    Console.WriteLine("====================== MENU SOPAS =========================");
                                    Console.WriteLine();
                                    Console.WriteLine("Sopa Mein con Carne de Res + Pollo + Camaron + Cebolla .................. $8.50  (1)");
                                    Console.WriteLine("Sopa de Wantan de Pollo + Tallarines + 8 wantanes      .................. $7.50  (2)");
                                    Console.WriteLine("Sopa Dragon con Camarones + wantanes de camaron + Chile Red Dragon ...... $8.50  (3)");
                                    Console.WriteLine("Sopa Don Li con Camarones + Pollo + Res + 4 wantanes de pollo ........... $8.50  (4)");
                                    comb1 = int.Parse(Console.ReadLine());
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine();
                                    Console.WriteLine("====================== MENU SOPAS =========================");
                                    Console.WriteLine();
                                    Console.WriteLine("Sopa Mein con Carne de Res + Pollo + Camaron + Cebolla .................. $8.50  (1)");
                                    Console.WriteLine("Sopa de Wantan de Pollo + Tallarines + 8 wantanes      .................. $7.50  (2)");
                                    Console.WriteLine("Sopa Dragon con Camarones + wantanes de camaron + Chile Red Dragon ...... $8.50  (3)");
                                    Console.WriteLine("Sopa Don Li con Camarones + Pollo + Res + 4 wantanes de pollo ........... $8.50  (4)");
                                    comb1 = int.Parse(Console.ReadLine());
                                    if (comb1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la Sopa numero" + " " + comb1 + " " + "y su precio es de " + "$" + (8.50 * cant));
                                        preciofinal = preciofinal + (8.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la Sopa numero" + " " + comb1 + " " + "y su precio es de " + "$" + (7.50 * cant));
                                        preciofinal = preciofinal + (7.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la Sopa numero" + " " + comb1 + " " + "y su precio es de " + "$" + (8.50 * cant));
                                        preciofinal = preciofinal + (8.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 4)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la Sopa numero" + " " + comb1 + " " + "y su precio es de " + "$" + (8.50 * cant));
                                        preciofinal = preciofinal + (8.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                                //MENU BEBIDAS DON LI 
                                case ("7"):
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine();
                                    Console.WriteLine("====================== MENU BEBIDAS =========================");
                                    Console.WriteLine();
                                    Console.WriteLine("Agua en Botella  ............................... $1.50  (1)");
                                    Console.WriteLine("Gaseosa ( Coca Cola/ Fanta / Pepsi)  ........... $2.00  (2)");
                                    Console.WriteLine("Vaso de Te Helado............................... $2.25  (3)");
                                    Console.WriteLine("Limonada ....................................... $3.00  (4)");
                                    comb1 = int.Parse(Console.ReadLine());
                                    if (comb1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la Bebida numero" + " " + comb1 + " " + "y su precio es de " + "$" + (1.50 * cant));
                                        preciofinal = preciofinal + (1.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la Bebida numero" + " " + comb1 + " " + "y su precio es de " + "$" + (2.00 * cant));
                                        preciofinal = preciofinal + (2.00 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la Bebida numero" + " " + comb1 + " " + "y su precio es de " + "$" + (2.25 * cant));
                                        preciofinal = preciofinal + (2.25 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 4)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la Bebida numero" + " " + comb1 + " " + "y su precio es de " + "$" + (3.00 * cant));
                                        preciofinal = preciofinal + (3.00 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                            }
                        }
                        break;
                    //RESTAURANTE CAIFU 
                    case ("4"):
                        while (p == "Si")
                        {
                            Console.WriteLine("====================== RESTAURANTE CAIFU =========================");
                            Console.WriteLine();
                            Console.WriteLine("Bienvenido al menú de Restaurante Caifu, ¿Qué desea ordenar?");
                            Console.WriteLine("Entradas     (1)    Combos Familiares     (2)      Mariscos      (3)");
                            Console.WriteLine("Cerdo        (4)    Lomitos de Res        (5)      Bebidas       (6)");

                            men1 = Console.ReadLine();
                            switch (men1)
                            {
                                //MENU ENTRADAS CAIFU 
                                case ("1"):
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine();
                                    Console.WriteLine("====================== MENU ENTRADAS =========================");
                                    Console.WriteLine();
                                    Console.WriteLine("4 Tacos Chinos con Pollo + Vegetales + Repollo  ........... $5.00  (1)");
                                    Console.WriteLine("Wantan de Pollo 12 Unidades................................ $4.00  (2)");
                                    Console.WriteLine("Wantan de Camaron 12 Unidades.............................. $4.50  (3)");
                                    comb1 = int.Parse(Console.ReadLine());
                                    if (comb1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la entrada número" + " " + comb1 + " " + "y su precio es de " + "$" + (5.00 * cant));
                                        preciofinal = preciofinal + (5.00 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la entrada número" + " " + comb1 + " " + "y su precio es de " + "$" + (4.00 * cant));
                                        preciofinal = preciofinal + (4.00 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la entrada número" + " " + comb1 + " " + "y su precio es de " + "$" + (4.50 * cant));
                                        preciofinal = preciofinal + (4.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                                //MENU COMBOS FAMILIARES CAIFU
                                case ("2"):
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine();
                                    Console.WriteLine("====================== MENU COMBOS FAMILIARES =========================");
                                    Console.WriteLine();
                                    Console.WriteLine("Pollo con Vegetales + 2 mini bowls de arroz + 2 bedbidas  ............................... $12.99  (1)");
                                    Console.WriteLine("Lomito con Vegetales + Bowl grande de Arroz + 12 Wantanes + Coca Cola 1.25 Lt............ $22.99  (2)");
                                    Console.WriteLine("Pollo Agridulce + Chaomein + Arroz Cantones + 12 Wantanes + Coca Cola 3 lt .............. $30.99   (3)");
                                    comb1 = int.Parse(Console.ReadLine());
                                    if (comb1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el combo familiar número" + " " + comb1 + " " + "y su precio es de " + "$" + (12.99 * cant));
                                        preciofinal = preciofinal + (12.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el combo familiar número" + " " + comb1 + " " + "y su precio es de " + "$" + (22.99 * cant));
                                        preciofinal = preciofinal + (22.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el combo familiar número" + " " + comb1 + " " + "y su precio es de " + "$" + (30.99 * cant));
                                        preciofinal = preciofinal + (30.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                                //MENU MARISCOS CAIFU 
                                case ("3"):
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine();
                                    Console.WriteLine("====================== MENU MARISCOS =========================");
                                    Console.WriteLine();
                                    Console.WriteLine("14 Camarones Empanizados + Salsa Verde + Papas Fritas + Repollo  ................ $9.75  (1)");
                                    Console.WriteLine("8 onzas de Camarones en Mantequilla, Ajo y Vegetales ............................ $9.75  (2)");
                                    Console.WriteLine("14 Camarones en Salsa Agridulce y Vegetales  ...........................  ....... $9.75  (3)");
                                    comb1 = int.Parse(Console.ReadLine());
                                    if (comb1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el combo de mariscos número" + " " + comb1 + " " + "y su precio es de " + "$" + (9.75 * cant));
                                        preciofinal = preciofinal + (9.75 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el combo de mariscos  número" + " " + comb1 + " " + "y su precio es de " + "$" + (9.75 * cant));
                                        preciofinal = preciofinal + (9.75 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el combo de mariscos número" + " " + comb1 + " " + "y su precio es de " + "$" + (9.75 * cant));
                                        preciofinal = preciofinal + (9.75 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                                //MENU CERDO CAIFU 
                                case ("4"):
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine();
                                    Console.WriteLine("====================== MENU CARNE DE CERDO =========================");
                                    Console.WriteLine();
                                    Console.WriteLine("Cerdo Empanizado en Salsa Agridulce  ....................... $9.75  (1)");
                                    Console.WriteLine("Cerdo Asado con Verduras (Brocoli y Zanahoria) ............. $9.75  (2)");
                                    comb1 = int.Parse(Console.ReadLine());
                                    if (comb1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el combo de carne de cerdo número" + " " + comb1 + " " + "y su precio es de " + "$" + (9.75 * cant));
                                        preciofinal = preciofinal + (9.75 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el combo de carne de cerdo número" + " " + comb1 + " " + "y su precio es de " + "$" + (9.75 * cant));
                                        preciofinal = preciofinal + (9.75 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                                //MENU LOMITO DE RES 
                                case ("5"):
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine();
                                    Console.WriteLine("====================== MENU LOMITOS DE RES =========================");
                                    Console.WriteLine();
                                    Console.WriteLine("8 onzas de Lomito de Res con Vegetales  ............................... $9.75  (1)");
                                    Console.WriteLine("8 onzas de Lomito de Res Empanizado en Salsa a Base de Naranja......... $9.75  (2)");
                                    Console.WriteLine("8 onzas de Lomito de Res Empanizado en Salsa Agridulce ................ $9.75  (3)");
                                    comb1 = int.Parse(Console.ReadLine());
                                    if (comb1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el combo de Lomito de Res número" + " " + comb1 + " " + "y su precio es de " + "$" + (9.75 * cant));
                                        preciofinal = preciofinal + (9.75 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el combo de Lomito de Res número" + " " + comb1 + " " + "y su precio es de " + "$" + (9.75 * cant));
                                        preciofinal = preciofinal + (9.75 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el combo de Lomito de Res número" + " " + comb1 + " " + "y su precio es de " + "$" + (9.75 * cant));
                                        preciofinal = preciofinal + (9.75 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                                //MENU BEBIDAS CAIFU 
                                case ("6"):
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine();
                                    Console.WriteLine("====================== MENU BEBIDAS =========================");
                                    Console.WriteLine();
                                    Console.WriteLine("Agua en Botella  ............................... $1.50  (1)");
                                    Console.WriteLine("Gaseosa Uva  ................................... $1.75  (2)");
                                    Console.WriteLine("Gaseosa Naranja  ............................... $1.75  (3)");
                                    Console.WriteLine("Gaseosa CocaCola  .............................. $1.75  (4)");
                                    Console.WriteLine("Gaseosa 7 UP  .................................. $1.75  (5)");
                                    Console.WriteLine("Vaso de Te Helado............................... $2.25  (6)");
                                    Console.WriteLine("Limonada ....................................... $3.00  (7)");
                                    Console.WriteLine("Te Helado ...................................... $2.75  (8)");
                                    comb1 = int.Parse(Console.ReadLine());
                                    if (comb1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la Bebida numero" + " " + comb1 + " " + "y su precio es de " + "$" + (1.50 * cant));
                                        preciofinal = preciofinal + (1.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la Bebida numero" + " " + comb1 + " " + "y su precio es de " + "$" + (1.75 * cant));
                                        preciofinal = preciofinal + (1.75 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la Bebida numero" + " " + comb1 + " " + "y su precio es de " + "$" + (1.75 * cant));
                                        preciofinal = preciofinal + (1.75 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 4)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la Bebida numero" + " " + comb1 + " " + "y su precio es de " + "$" + (1.75 * cant));
                                        preciofinal = preciofinal + (1.75 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 5)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la Bebida numero" + " " + comb1 + " " + "y su precio es de " + "$" + (1.75 * cant));
                                        preciofinal = preciofinal + (1.75 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 6)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la Bebida numero" + " " + comb1 + " " + "y su precio es de " + "$" + (2.25 * cant));
                                        preciofinal = preciofinal + (2.25 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 7)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la Bebida numero" + " " + comb1 + " " + "y su precio es de " + "$" + (3.00 * cant));
                                        preciofinal = preciofinal + (3.00 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 8)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la Bebida numero" + " " + comb1 + " " + "y su precio es de " + "$" + (2.75 * cant));
                                        preciofinal = preciofinal + (2.75 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }

                                    break;
                            }
                        }
                        break;
                    //RESTAURANTE CELESTE IMPERIO
                    case ("5"):
                        while (p == "Si")
                        {
                            Console.WriteLine("====================== RESTAURANTE CELESTE IMPERIO =========================");
                            Console.WriteLine();
                            Console.WriteLine("Bienvenido al menú de Celeste Imperio, ¿Qué desea ordenar?");
                            Console.WriteLine("Combos Familiares     (1)    Plato Mixto     (2)      Entradas         (3)");
                            Console.WriteLine("Mariscos              (4)    Res             (5)      Chao Mein        (6)");
                            Console.WriteLine("Bebidas               (7)      ");
                            men1 = Console.ReadLine();
                            switch (men1)
                            {
                                //MENU COMBOS FAMILIARES CELESTE
                                case ("1"):
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine();
                                    Console.WriteLine("====================== MENU COMBOS FAMILIARES =========================");
                                    Console.WriteLine();
                                    Console.WriteLine("Pollo con Verduras + Arroz Cantones + 12 Wantanes y 4 panes ........... $18.90  (1)");
                                    Console.WriteLine("Chao Mein Mixto + Lomo con Verduras + Arroz Cantones + 12 wantanes..... $27.66  (2)");
                                    Console.WriteLine("Chao Mein Mixto + Pollo con Verduras + Arroz + 12 wantanes ............ $27.10   (3)");
                                    comb1 = int.Parse(Console.ReadLine());
                                    if (comb1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el combo familiar numero" + " " + comb1 + " " + "y su precio es de " + "$" + (18.90 * cant));
                                        preciofinal = preciofinal + (18.90 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el combo familiar numero" + " " + comb1 + " " + "y su precio es de " + "$" + (27.66 * cant));
                                        preciofinal = preciofinal + (27.66 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el combo familiar numero" + " " + comb1 + " " + "y su precio es de " + "$" + (27.10 * cant));
                                        preciofinal = preciofinal + (27.10 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                                //MENU PLATO MIXTO CELESTE
                                case ("2"):
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine();
                                    Console.WriteLine("====================== MENU PLATO MIXTO =========================");
                                    Console.WriteLine();
                                    Console.WriteLine("Arroz Cantones + Chao Mein + Carne de su Eleccion ........... $9.30 (1)");
                                    comb1 = int.Parse(Console.ReadLine());
                                    if (comb1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el plato mixto numero" + " " + comb1 + " " + "y su precio es de " + "$" + (9.30 * cant));
                                        preciofinal = preciofinal + (9.30 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                                //MENU ENTRADAS CELESTE
                                case ("3"):
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine();
                                    Console.WriteLine("====================== MENU ENTRADAS =========================");
                                    Console.WriteLine();
                                    Console.WriteLine("6 Wantanes de Res ............. $4.00 (1)");
                                    Console.WriteLine("6 Wantanes de Camaron.......... $4.60 (2)");
                                    Console.WriteLine("6 Wantanes de Queso ........... $4.50 (3)");
                                    Console.WriteLine("Tacos Chinos 4 Unidades ....... $5.00 (4)");
                                    comb1 = int.Parse(Console.ReadLine());
                                    if (comb1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la entrada numero" + " " + comb1 + " " + "y su precio es de " + "$" + (4.00 * cant));
                                        preciofinal = preciofinal + (4.00 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la entrada numero" + " " + comb1 + " " + "y su precio es de " + "$" + (4.60 * cant));
                                        preciofinal = preciofinal + (4.60 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la entrada numero" + " " + comb1 + " " + "y su precio es de " + "$" + (4.50 * cant));
                                        preciofinal = preciofinal + (4.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 4)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la entrada numero" + " " + comb1 + " " + "y su precio es de " + "$" + (5.00 * cant));
                                        preciofinal = preciofinal + (5.00 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                                //MENU MARISCOS CELESTE
                                case ("4"):
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine();
                                    Console.WriteLine("====================== MENU MARISCOS =========================");
                                    Console.WriteLine();
                                    Console.WriteLine("5 onz camarones empanizados con salsa agridulce ............... $9.90  (1)");
                                    Console.WriteLine("5 onz camarones empanizados con champiñones y verduras ........ $11.30 (2)");
                                    Console.WriteLine("5 onz camarones con chile verde y frijol chino ................ $9.90  (3)");
                                    comb1 = int.Parse(Console.ReadLine());
                                    if (comb1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el combo de mariscos numero" + " " + comb1 + " " + "y su precio es de " + "$" + (9.90 * cant));
                                        preciofinal = preciofinal + (9.90 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el combo de mariscos numero" + " " + comb1 + " " + "y su precio es de " + "$" + (11.30 * cant));
                                        preciofinal = preciofinal + (11.30 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el combo de mariscos numero" + " " + comb1 + " " + "y su precio es de " + "$" + (9.90 * cant));
                                        preciofinal = preciofinal + (9.90 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                                //MENU CARNE DE RES CELESTE
                                case ("5"):
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine();
                                    Console.WriteLine("====================== MENU CARNE DE RES =========================");
                                    Console.WriteLine();
                                    Console.WriteLine("8 onz de Carne de Res con Verdura + 4 wantanes .................. $8.90 (1)");
                                    Console.WriteLine("8 onz de Lomito de Res con Verduras y Curry + 4 wantanes ........ $9.10 (2)");
                                    Console.WriteLine("8 onz de Lomito de Res con Frijol Chino + 4 wantanes ............ $9.10 (3)");
                                    Console.WriteLine("8 onz de Lomito de Res en Salsa de Ostras + 4 wantanes .......... $9.90 (4)");
                                    comb1 = int.Parse(Console.ReadLine());
                                    if (comb1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el combo de carne de res numero" + " " + comb1 + " " + "y su precio es de " + "$" + (8.90 * cant));
                                        preciofinal = preciofinal + (8.90 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el combo de carne de res numero" + " " + comb1 + " " + "y su precio es de " + "$" + (9.10 * cant));
                                        preciofinal = preciofinal + (9.10 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el combo de carne de res numero" + " " + comb1 + " " + "y su precio es de " + "$" + (9.10 * cant));
                                        preciofinal = preciofinal + (9.10 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 4)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el combo de carne de res numero" + " " + comb1 + " " + "y su precio es de " + "$" + (9.90 * cant));
                                        preciofinal = preciofinal + (9.90 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                                //MENU CHAO MEIN CLESTE 
                                case ("6"):
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine();
                                    Console.WriteLine("====================== MENU CHAO MEIN =========================");
                                    Console.WriteLine();
                                    Console.WriteLine("Chao Mein Mixto (Pollo, Res, Camaron) ......... $8.30 (1)");
                                    Console.WriteLine("Chao Mein de Res .............................. $8.80 (2)");
                                    Console.WriteLine("Chao Mein de Cerdo ............................ $8.80 (3)");
                                    Console.WriteLine("Chao Mein de Pollo ............................ $8.80 (4)");
                                    Console.WriteLine("Chao Mein de Camarones ........................ $9.90 (5)");
                                    comb1 = int.Parse(Console.ReadLine());
                                    if (comb1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el combo de chao mein numero" + " " + comb1 + " " + "y su precio es de " + "$" + (8.30 * cant));
                                        preciofinal = preciofinal + (8.30 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el combo de chao mein numero" + " " + comb1 + " " + "y su precio es de " + "$" + (8.80 * cant));
                                        preciofinal = preciofinal + (8.80 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el combo de chao mein numero" + " " + comb1 + " " + "y su precio es de " + "$" + (8.80 * cant));
                                        preciofinal = preciofinal + (8.80 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 4)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el combo de chao mein numero" + " " + comb1 + " " + "y su precio es de " + "$" + (8.80 * cant));
                                        preciofinal = preciofinal + (8.80 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 5)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el combo de chao mein numero" + " " + comb1 + " " + "y su precio es de " + "$" + (9.90 * cant));
                                        preciofinal = preciofinal + (9.90 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                                //MENU BEBIDAS CELESTE 
                                case ("7"):
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine();
                                    Console.WriteLine("====================== MENU BEBIDAS =========================");
                                    Console.WriteLine();
                                    Console.WriteLine("Agua en Botella  ............................... $1.50  (1)");
                                    Console.WriteLine("Gaseosa Uva  ................................... $1.75  (2)");
                                    Console.WriteLine("Gaseosa Naranja  ............................... $1.75  (3)");
                                    Console.WriteLine("Gaseosa CocaCola  .............................. $1.75  (4)");
                                    Console.WriteLine("Gaseosa 7 UP  .................................. $1.75  (5)");
                                    Console.WriteLine("Vaso de Te Helado............................... $2.25  (6)");
                                    Console.WriteLine("Limonada ....................................... $3.00  (7)");
                                    Console.WriteLine("Te Helado ...................................... $2.75  (8)");
                                    comb1 = int.Parse(Console.ReadLine());
                                    if (comb1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la Bebida numero" + " " + comb1 + " " + "y su precio es de " + "$" + (1.50 * cant));
                                        preciofinal = preciofinal + (1.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la Bebida numero" + " " + comb1 + " " + "y su precio es de " + "$" + (1.75 * cant));
                                        preciofinal = preciofinal + (1.75 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la Bebida numero" + " " + comb1 + " " + "y su precio es de " + "$" + (1.75 * cant));
                                        preciofinal = preciofinal + (1.75 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 4)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la Bebida numero" + " " + comb1 + " " + "y su precio es de " + "$" + (1.75 * cant));
                                        preciofinal = preciofinal + (1.75 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 5)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la Bebida numero" + " " + comb1 + " " + "y su precio es de " + "$" + (1.75 * cant));
                                        preciofinal = preciofinal + (1.75 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 6)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la Bebida numero" + " " + comb1 + " " + "y su precio es de " + "$" + (2.25 * cant));
                                        preciofinal = preciofinal + (2.25 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 7)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la Bebida numero" + " " + comb1 + " " + "y su precio es de " + "$" + (3.00 * cant));
                                        preciofinal = preciofinal + (3.00 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 8)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la Bebida numero" + " " + comb1 + " " + "y su precio es de " + "$" + (2.75 * cant));
                                        preciofinal = preciofinal + (2.75 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                            }
                        }
                        break;
                }
                break;
            //MENU SANDWICHS 
            case ("5"):
                Console.WriteLine("Que restaurante desea ordenar");
                Console.WriteLine("Subway      (1)     Denny's      (2)      Ban Ban   (3)");
                Console.WriteLine("Quiznos     (4)");
                ham = Console.ReadLine();
                switch (ham)
                {
                    //MENU SUBWAY 
                    case ("1"):
                        while (p == "Si")
                        {
                            Console.WriteLine("====================== RESTAURANTE SUBWAY =========================");
                            Console.WriteLine();
                            Console.WriteLine("Bienvenido al menú de Subway, ¿Qué desea ordenar?");
                            Console.WriteLine("Promociones        (1)    Subs en Combo    (2)      Subs Individuales   (3)");
                            Console.WriteLine("Bandejas Subway    (4)    Bebidas          (5)      ");
                            men1 = Console.ReadLine();
                            switch (men1)
                            {
                                //MENU PROMOCIONES SUBWAY
                                case "1":
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine();
                                    Console.WriteLine("====================== MENU PROMOCIONES =========================");
                                    Console.WriteLine();
                                    Console.WriteLine("Subway de atun 15cm + Vegetales + Aderezos + Bebida Coca Lata  ...................... $4.50  (1)");
                                    Console.WriteLine("Pizzasub de 15 cm + Queso + Vegetales y Aderezos + Bebida lata + 2 galletas ......... $5.99  (2)");
                                    Console.WriteLine("Subway de Pollo BBQ + Vegetales y aderezos + 1 Soda lata + galletas o chips.......... $6.25  (3)");
                                    Console.WriteLine("2 Subway de Pollo BBQ + Vegetales y aderezos + 2 Soda lata + 2 galletas o chips ..... $7.50  (4)");
                                    Console.WriteLine("4 Subs de 15cms c/u (BMT,Pollo Empanizado, Pizzasub) +Jugo 1.5lt + 4 galletas........ $17.99 (5)");
                                    comb1 = int.Parse(Console.ReadLine());
                                    if (comb1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la promocion numero" + " " + comb1 + " " + "y su precio es de " + "$" + (4.50 * cant));
                                        preciofinal = preciofinal + (4.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la promocion numero" + " " + comb1 + " " + "y su precio es de " + "$" + (5.99 * cant));
                                        preciofinal = preciofinal + (5.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la promocion numero" + " " + comb1 + " " + "y su precio es de " + "$" + (6.25 * cant));
                                        preciofinal = preciofinal + (6.25 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 4)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la promocion numero" + " " + comb1 + " " + "y su precio es de " + "$" + (7.50 * cant));
                                        preciofinal = preciofinal + (7.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 5)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la promocion numero" + " " + comb1 + " " + "y su precio es de " + "$" + (17.99 * cant));
                                        preciofinal = preciofinal + (17.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                                //MENU SUBS EN COMBO SUBWAY
                                case "2":
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine();
                                    Console.WriteLine("====================== MENU SUBS EN COMBO =========================");
                                    Console.WriteLine();
                                    Console.WriteLine("Subway Italiano 15cm + Pepperoni y Salami + Vegetales + Aderezos + Soda en Lata  ............. $6.00  (1)");
                                    Console.WriteLine("Subway de Pavo 15cm + Vegetales + Aderezos + Soda en Lata + Chips  ........................... $6.00  (2)");
                                    Console.WriteLine("Subway de Costillas 15cm BBQ + Vegetales y aderezos + Soda lata + Chips ...................... $6.49  (3)");
                                    Console.WriteLine("Subway de Atun 15cm + Queso + Vegetales y aderezos +  Soda lata + Chips ...................... $6.00  (4)");
                                    Console.WriteLine("Subway Pizza con pepperoni 15cm + salsa de tomate + Aderezos + Soda Lata + Chips ............. $5.65  (5)");
                                    comb1 = int.Parse(Console.ReadLine());
                                    if (comb1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el sub combo numero" + " " + comb1 + " " + "y su precio es de " + "$" + (6.00 * cant));
                                        preciofinal = preciofinal + (6.00 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el sub combo numero" + " " + comb1 + " " + "y su precio es de " + "$" + (6.00 * cant));
                                        preciofinal = preciofinal + (6.00 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el sub combo numero" + " " + comb1 + " " + "y su precio es de " + "$" + (6.49 * cant));
                                        preciofinal = preciofinal + (6.49 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 4)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el sub combo numero" + " " + comb1 + " " + "y su precio es de " + "$" + (6.00 * cant));
                                        preciofinal = preciofinal + (6.00 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 5)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el sub combo numero" + " " + comb1 + " " + "y su precio es de " + "$" + (5.65 * cant));
                                        preciofinal = preciofinal + (5.65 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                                //MENU SUBS INDIVIDUALES SUBWAY
                                case "3":
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine();
                                    Console.WriteLine("====================== MENU SUBS INDIVIDUALES =========================");
                                    Console.WriteLine();
                                    Console.WriteLine("Subway Italiano B.M.T 15cm + Pepperoni y Salami + Vegetales + Aderezos al gusto  ........ $4.50  (1)");
                                    Console.WriteLine("Subway de Pavo 15 cm + Vegetales + Aderezos al gusto  ................................... $4.50  (2)");
                                    Console.WriteLine("Subway de Costillas BBQ 15 cm + Vegetales y aderezos + Queso  ........................... $4.99  (3)");
                                    Console.WriteLine("Subway de Atun 15 cm + Vegetales + Aderezos al gusto .................................... $4.50  (4)");
                                    Console.WriteLine("Subway Pizza con pepperoni 15 cm + salsa de tomate + Aderezos + Queso ................... $4.15  (5)");
                                    comb1 = int.Parse(Console.ReadLine());
                                    if (comb1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el sub individual numero" + " " + comb1 + " " + "y su precio es de " + "$" + (4.50 * cant));
                                        preciofinal = preciofinal + (4.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el sub individual numero" + " " + comb1 + " " + "y su precio es de " + "$" + (4.50 * cant));
                                        preciofinal = preciofinal + (4.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el sub individual numero" + " " + comb1 + " " + "y su precio es de " + "$" + (4.99 * cant));
                                        preciofinal = preciofinal + (4.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 4)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el sub individual numero" + " " + comb1 + " " + "y su precio es de " + "$" + (4.50 * cant));
                                        preciofinal = preciofinal + (4.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 5)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el sub individual numero" + " " + comb1 + " " + "y su precio es de " + "$" + (4.15 * cant));
                                        preciofinal = preciofinal + (4.15 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                                case "4":
                                    //MENU BANDEJAS SUBWAY
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine();
                                    Console.WriteLine("====================== MENU BANDEJAS SUBWAY =========================");
                                    Console.WriteLine();
                                    Console.WriteLine("Bandeja 15 subways 10cm (BMT, Jamon, Pavo, Jamon&Pavo) + 12 galletas + 2 CocaCola 1.5lt  .......... $44.00  (1)");
                                    Console.WriteLine("Bandeja 15 subways 10cm (6 italianos,3 de Pavo, 6 jamon&pavo) + Queso + Vegetales ................. $34.00  (2)");
                                    Console.WriteLine("Bandeja 15 subways 10cm (6 italianos BMT,6 de Pavo, 3 jamon&pavo) + Queso + Vegetales.............. $34.00  (3)");
                                    Console.WriteLine("Bandeja 12 Galletas a elegir sabor de preferencia (Chocochip, Macadamia, Chococlate Blanco) ....... $7.50   (4)");
                                    Console.WriteLine("Bandeja 24 Galletas a elegir sabor de preferencia (Chocochip, Macadamia, Chococlate Blanco) ....... $13.99  (5)");
                                    comb1 = int.Parse(Console.ReadLine());
                                    if (comb1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la bandeja subway numero" + " " + comb1 + " " + "y su precio es de " + "$" + (44.00 * cant));
                                        preciofinal = preciofinal + (44.00 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la bandeja subway numero" + " " + comb1 + " " + "y su precio es de " + "$" + (34.00 * cant));
                                        preciofinal = preciofinal + (34.00 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la bandeja subway numero" + " " + comb1 + " " + "y su precio es de " + "$" + (34.00 * cant));
                                        preciofinal = preciofinal + (34.00 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 4)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la bandeja subway numero" + " " + comb1 + " " + "y su precio es de " + "$" + (7.50 * cant));
                                        preciofinal = preciofinal + (7.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 5)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la bandeja subway numero" + " " + comb1 + " " + "y su precio es de " + "$" + (13.99 * cant));
                                        preciofinal = preciofinal + (13.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                                case "5":
                                    //MENU BEBIDAS SUBWAY
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine();
                                    Console.WriteLine("====================== MENU BEBIDAS =========================");
                                    Console.WriteLine();
                                    Console.WriteLine("Agua en Botella  ............................... $1.50  (1)");
                                    Console.WriteLine("Gaseosa Uva  ................................... $1.75  (2)");
                                    Console.WriteLine("Gaseosa Naranja  ............................... $1.75  (3)");
                                    Console.WriteLine("Gaseosa CocaCola  .............................. $1.75  (4)");
                                    Console.WriteLine("Gaseosa 7 UP  .................................. $1.75  (5)");
                                    Console.WriteLine("Vaso de Te Helado............................... $2.25  (6)");
                                    Console.WriteLine("Limonada ....................................... $3.00  (7)");
                                    Console.WriteLine("Te Helado ...................................... $2.75  (8)");
                                    comb1 = int.Parse(Console.ReadLine());
                                    if (comb1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la Bebida numero" + " " + comb1 + " " + "y su precio es de " + "$" + (1.50 * cant));
                                        preciofinal = preciofinal + (1.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la Bebida numero" + " " + comb1 + " " + "y su precio es de " + "$" + (1.75 * cant));
                                        preciofinal = preciofinal + (1.75 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la Bebida numero" + " " + comb1 + " " + "y su precio es de " + "$" + (1.75 * cant));
                                        preciofinal = preciofinal + (1.75 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 4)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la Bebida numero" + " " + comb1 + " " + "y su precio es de " + "$" + (1.75 * cant));
                                        preciofinal = preciofinal + (1.75 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 5)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la Bebida numero" + " " + comb1 + " " + "y su precio es de " + "$" + (1.75 * cant));
                                        preciofinal = preciofinal + (1.75 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 6)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la Bebida numero" + " " + comb1 + " " + "y su precio es de " + "$" + (2.25 * cant));
                                        preciofinal = preciofinal + (2.25 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 7)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la Bebida numero" + " " + comb1 + " " + "y su precio es de " + "$" + (3.00 * cant));
                                        preciofinal = preciofinal + (3.00 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 8)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la Bebida numero" + " " + comb1 + " " + "y su precio es de " + "$" + (2.75 * cant));
                                        preciofinal = preciofinal + (2.75 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                            }
                        }
                        break;
                    case ("2"):
                        while (p == "Si")
                        {
                            Console.WriteLine("====================== RESTAURANTE DENNY'S =========================");
                            Console.WriteLine();
                            Console.WriteLine("Bienvenido al menú de Denny's, ¿Qué desea ordenar?");
                            Console.WriteLine("Sandwich Personal     (1)    Postres               (2)      Bebidas Frias  (3)");
                            Console.WriteLine("Aperitivos            (4)         ");
                            men1 = Console.ReadLine();
                            switch (men1)
                            {
                                case ("1"):
                                    //MENU SANDWICH PERSONAL
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine();
                                    Console.WriteLine("====================== MENU SANDWICH PERSONAL =========================");
                                    Console.WriteLine();
                                    Console.WriteLine("The Grand Slamwich: Huevos Revueltos, Salchicha, Tocino, Jamon, Queso + Papas Fritas  ...................... $10.75  (1)");
                                    Console.WriteLine("Moons Over My Hammy: Sándwich con 2 huevos revueltos + Jamón + Queso american + Papas hash browns  ......... $9.75   (2)");
                                    Console.WriteLine("Loaded Breakfast Sandwich: Tocino + Jamon + Queso Americano + Huevo al gusto  + Muffin Ingles tostado ...... $7.75   (3)");
                                    comb1 = int.Parse(Console.ReadLine());
                                    if (comb1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el sandwich personal numero" + " " + comb1 + " " + "y su precio es de " + "$" + (10.75 * cant));
                                        preciofinal = preciofinal + (10.75 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el sandwich personal numero" + " " + comb1 + " " + "y su precio es de " + "$" + (9.75 * cant));
                                        preciofinal = preciofinal + (9.75 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el sandwich personal numero" + " " + comb1 + " " + "y su precio es de " + "$" + (7.75 * cant));
                                        preciofinal = preciofinal + (7.75 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                                case ("2"):
                                    //MENU POSTRES DENNYS
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine();
                                    Console.WriteLine("====================== MENU POSTRES =========================");
                                    Console.WriteLine();
                                    Console.WriteLine("New York Style Cheesecake:Cheesecake en una crujiente base + topping de fresa y crema batida   ............. $6.75  (1)");
                                    Console.WriteLine("Pancake Puppies: Deliciosas bolitas de masa de pancake con azúcar y canela y servidas con miel ..............$6.75  (2)");
                                    comb1 = int.Parse(Console.ReadLine());
                                    if (comb1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el postre numero" + " " + comb1 + " " + "y su precio es de " + "$" + (6.75 * cant));
                                        preciofinal = preciofinal + (6.75 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el postre numero" + " " + comb1 + " " + "y su precio es de " + "$" + (6.75 * cant));
                                        preciofinal = preciofinal + (6.75 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                                case ("3"):
                                    //MENU BEBIDAS FRIAS SUBWAY
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine();
                                    Console.WriteLine("====================== MENU BEBIDAS FRIAS =========================");
                                    Console.WriteLine();
                                    Console.WriteLine("Agua en Botella  ............................... $1.75  (1)");
                                    Console.WriteLine("Gaseosa Pepsi Light Lata  ............... ...... $1.85  (2)");
                                    comb1 = int.Parse(Console.ReadLine());
                                    if (comb1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la Bebida numero" + " " + comb1 + " " + "y su precio es de " + "$" + (1.75 * cant));
                                        preciofinal = preciofinal + (1.75 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la Bebida numero" + " " + comb1 + " " + "y su precio es de " + "$" + (1.85 * cant));
                                        preciofinal = preciofinal + (1.85 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                                case ("4"):
                                    //MENU APERITIVOS DENNYS
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine();
                                    Console.WriteLine("====================== MENU APERITIVOS =========================");
                                    Console.WriteLine();
                                    Console.WriteLine("Zesty Nachos................................$11.50 (1)");
                                    Console.WriteLine("Smothered Cheese Fries......................$7.75  (2)");
                                    Console.WriteLine("Mozzarella Cheese Sticks....................$7.25  (3)");
                                    Console.WriteLine("Chicken Boneless ...........................$10.00 (4)");
                                    Console.WriteLine("Grilled Chicken & Sausage Quesadilla........$10.50 (5)");
                                    comb1 = int.Parse(Console.ReadLine());
                                    if (comb1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el aperitivo número" + " " + comb1 + " " + "y su precio es de " + "$" + (11.50 * cant));
                                        preciofinal = preciofinal + (11.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el aperitivo número" + " " + comb1 + " " + "y su precio es de " + "$" + (7.75 * cant));
                                        preciofinal = preciofinal + (7.75 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el aperitivo número" + " " + comb1 + " " + "y su precio es de " + "$" + (7.25 * cant));
                                        preciofinal = preciofinal + (7.25 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 4)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el aperitivo número" + " " + comb1 + " " + "y su precio es de " + "$" + (10 * cant));
                                        preciofinal = preciofinal + (10 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 5)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el aperitivo número" + " " + comb1 + " " + "y su precio es de " + "$" + (10.50 * cant));
                                        preciofinal = preciofinal + (10.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                            }
                        }
                        break;
                    // RESTAURANTE BAN BAN
                    case ("3"):
                        while (p == "Si")
                        {
                            Console.WriteLine("====================== RESTAURANTE BAN BAN =========================");
                            Console.WriteLine();
                            Console.WriteLine("Bienvenido al menú de Ban Ban, ¿Qué desea ordenar?");
                            Console.WriteLine("Sandwich Personal     (1)    Postres               (2)      Bebidas Frias  (3)");
                            Console.WriteLine("Bebidas Calientes     (4)         ");
                            men1 = Console.ReadLine();
                            switch (men1)
                            {
                                case ("1"):
                                    //MENU SANDWICH PERSONAL BAN BAN
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine();
                                    Console.WriteLine("====================== MENU SANDWICH PERSONAL =========================");
                                    Console.WriteLine();
                                    Console.WriteLine("Sandwich de Pollo con 3 rodajas de pan + Ensalada + Salsas de la casa ..............................$3.25 (1)");
                                    Console.WriteLine("Sandwich de Jamon y Queso 3 rodajas de pan + Ensalada + Salsas Especiales + Queso Americano  .......$2.75 (2)");
                                    Console.WriteLine("Croissant de Pollo  ................................................................................$3.25 (3)");
                                    Console.WriteLine("La Nona: Pan Baguette relleno de pollo + Tocino + Aguacate + Lechuga y Aderezo  ....................$5.75 (4)");
                                    Console.WriteLine("Philly Steak: Pan Baguette con fajitas de res + Queso Cheddar + Cebolla + Chile Rojo y Aderezo......$6.75 (5)");
                                    comb1 = int.Parse(Console.ReadLine());
                                    if (comb1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el sandwich personal número" + " " + comb1 + " " + "y su precio es de " + "$" + (3.25 * cant));
                                        preciofinal = preciofinal + (3.25 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el sandwich personal número" + " " + comb1 + " " + "y su precio es de " + "$" + (2.75 * cant));
                                        preciofinal = preciofinal + (2.75 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el sandwich personal número" + " " + comb1 + " " + "y su precio es de " + "$" + (3.25 * cant));
                                        preciofinal = preciofinal + (3.25 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 4)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el sandwich personal número" + " " + comb1 + " " + "y su precio es de " + "$" + (5.75 * cant));
                                        preciofinal = preciofinal + (5.75 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 5)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el sandwich personal número" + " " + comb1 + " " + "y su precio es de " + "$" + (6.75 * cant));
                                        preciofinal = preciofinal + (6.75 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                                case ("2"):
                                    //MENU POSTRES
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine();
                                    Console.WriteLine("====================== MENU POSTRES =========================");
                                    Console.WriteLine();
                                    Console.WriteLine("Porcion de CheeseCake de Fresa ..................$2.99 (1)");
                                    Console.WriteLine("Porcion de CheeseCake de Oreo ...................$2.99 (2)");
                                    Console.WriteLine("Porcion de CheeseCake de Chocolate ..............$2.99 (3)");
                                    Console.WriteLine("Porcion de Pie de Manzana  ......................$2.99 (4)");
                                    Console.WriteLine("Porcion de Tartaleta de Fresa ...................$2.25 (5)");
                                    Console.WriteLine("Porcion de Tres Leches ..........................$2.99 (6)");
                                    comb1 = int.Parse(Console.ReadLine());
                                    if (comb1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el postre número" + " " + comb1 + " " + "y su precio es de " + "$" + (2.99 * cant));
                                        preciofinal = preciofinal + (2.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el postre número" + " " + comb1 + " " + "y su precio es de " + "$" + (2.99 * cant));
                                        preciofinal = preciofinal + (2.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el postre número" + " " + comb1 + " " + "y su precio es de " + "$" + (2.99 * cant));
                                        preciofinal = preciofinal + (2.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 4)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el postre número" + " " + comb1 + " " + "y su precio es de " + "$" + (2.99 * cant));
                                        preciofinal = preciofinal + (2.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 5)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el postre número" + " " + comb1 + " " + "y su precio es de " + "$" + (2.25 * cant));
                                        preciofinal = preciofinal + (2.25 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 6)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el postre número" + " " + comb1 + " " + "y su precio es de " + "$" + (2.99 * cant));
                                        preciofinal = preciofinal + (2.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                                case ("3"):
                                    //MENU BEBIDAS FRIAS BAN BAN 
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine();
                                    Console.WriteLine("====================== MENU BEBIDAS FRIAS =========================");
                                    Console.WriteLine();
                                    Console.WriteLine("Agua en Botella  ............................... $1.50  (1)");
                                    Console.WriteLine("Gaseosa Uva  ................................... $1.75  (2)");
                                    Console.WriteLine("Gaseosa Naranja  ............................... $1.75  (3)");
                                    Console.WriteLine("Gaseosa CocaCola  .............................. $1.75  (4)");
                                    Console.WriteLine("Gaseosa 7 UP  .................................. $1.75  (5)");
                                    Console.WriteLine("Vaso de Te Helado............................... $2.25  (6)");
                                    Console.WriteLine("Limonada ....................................... $3.00  (7)");
                                    Console.WriteLine("Horchata........................................ $1.75  (8)");
                                    comb1 = int.Parse(Console.ReadLine());
                                    if (comb1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la Bebida numero" + " " + comb1 + " " + "y su precio es de " + "$" + (1.50 * cant));
                                        preciofinal = preciofinal + (1.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la Bebida numero" + " " + comb1 + " " + "y su precio es de " + "$" + (1.75 * cant));
                                        preciofinal = preciofinal + (1.75 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la Bebida numero" + " " + comb1 + " " + "y su precio es de " + "$" + (1.75 * cant));
                                        preciofinal = preciofinal + (1.75 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 4)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la Bebida numero" + " " + comb1 + " " + "y su precio es de " + "$" + (1.75 * cant));
                                        preciofinal = preciofinal + (1.75 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 5)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la Bebida numero" + " " + comb1 + " " + "y su precio es de " + "$" + (1.75 * cant));
                                        preciofinal = preciofinal + (1.75 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 6)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la Bebida numero" + " " + comb1 + " " + "y su precio es de " + "$" + (2.25 * cant));
                                        preciofinal = preciofinal + (2.25 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 7)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la Bebida numero" + " " + comb1 + " " + "y su precio es de " + "$" + (3.00 * cant));
                                        preciofinal = preciofinal + (3.00 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 8)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la Bebida numero" + " " + comb1 + " " + "y su precio es de " + "$" + (1.75 * cant));
                                        preciofinal = preciofinal + (1.75 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                                case ("4"):
                                    //MENU BEBIDAS CALIENTES BAN BAN 
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine();
                                    Console.WriteLine("====================== MENU BEBIDAS CALIENTES =========================");
                                    Console.WriteLine();
                                    Console.WriteLine("Taza de Cafe  ............................... $1.25  (1)");
                                    Console.WriteLine("Te de Manzanilla  ........................... $1.00  (2)");
                                    Console.WriteLine("Chocolate Caliente........................... $1.50  (3)");
                                    comb1 = int.Parse(Console.ReadLine());
                                    if (comb1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la Bebida Caliente numero" + " " + comb1 + " " + "y su precio es de " + "$" + (1.25 * cant));
                                        preciofinal = preciofinal + (1.25 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la Bebida Caliente numero" + " " + comb1 + " " + "y su precio es de " + "$" + (1.00 * cant));
                                        preciofinal = preciofinal + (1.00 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la Bebida Caliente numero" + " " + comb1 + " " + "y su precio es de " + "$" + (1.50 * cant));
                                        preciofinal = preciofinal + (1.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                            }
                        }
                        break;
                    case ("4"):
                        while (p == "Si")
                        {
                            Console.WriteLine("====================== RESTAURANTE QUIZNOS =========================");
                            Console.WriteLine();
                            Console.WriteLine("Bienvenido al menú de Quiznos, ¿Qué desea ordenar?");
                            Console.WriteLine("Sandwich Personal     (1)    Combo Sandwich       (2)      Bebidas Frias  (3)");
                            Console.WriteLine("Wrap    (4)         ");
                            men1 = Console.ReadLine();
                            switch (men1)
                            {
                                case ("1"):
                                    //MENU SANDWICH PERSONAL QUIZNOS 
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine();
                                    Console.WriteLine("====================== MENU SANDWICH PERSONAL =========================");
                                    Console.WriteLine();
                                    Console.WriteLine("Sandwich de Pavo Suizo con Queso + Ensalada + Cebolla Morada + Salsa Ranch  .................... $4.50  (1)");
                                    Console.WriteLine("Sandwich BBQ PORK con cerdo mechado + Queso Cheddar + Cebolla Morada + Ensalada  ............... $4.25  (2)");
                                    Console.WriteLine("Sandwich Bistro Steak con Roast Beef + Mozarella y Queso Parmesano + Chile Verde ............... $4.95  (3)");
                                    Console.WriteLine("Sandwich Pollo BBQ con Fajitas de Pollo + Tocino + Queso Mozzarella y Cheddar + Salsa BBQ ...... $4.75  (4)");
                                    Console.WriteLine("Sandwich Pollo Mezquite con Fajitas de Pollo + Tocino + Queso Mozzarella + Salsa Quiznos  ...... $4.75  (5)");
                                    comb1 = int.Parse(Console.ReadLine());
                                    if (comb1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el sandwich numero" + " " + comb1 + " " + "y su precio es de " + "$" + (4.50 * cant));
                                        preciofinal = preciofinal + (4.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el sandwich numero" + " " + comb1 + " " + "y su precio es de " + "$" + (4.25 * cant));
                                        preciofinal = preciofinal + (4.25 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el sandwich numero" + " " + comb1 + " " + "y su precio es de " + "$" + (4.95 * cant));
                                        preciofinal = preciofinal + (4.95 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 4)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el sandwich numero" + " " + comb1 + " " + "y su precio es de " + "$" + (4.75 * cant));
                                        preciofinal = preciofinal + (4.75 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 5)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el sandwich numero" + " " + comb1 + " " + "y su precio es de " + "$" + (4.75 * cant));
                                        preciofinal = preciofinal + (4.75 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                                case ("2"):
                                    //MENU COMBO SANDWICH QUIZNOS 
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine();
                                    Console.WriteLine("====================== MENU COMBO SANDWICH =========================");
                                    Console.WriteLine();
                                    Console.WriteLine("Sandwich de Pavo Suizo con Queso + Ensalada + Cebolla Morada + Salsa Ranch + Soda y Papas  .................... $5.50  (1)");
                                    Console.WriteLine("Sandwich BBQ PORK con cerdo mechado + Queso Cheddar + Cebolla Morada + Ensalada + Soda y Papas  ............... $5.25  (2)");
                                    Console.WriteLine("Sandwich Bistro Steak con Roast Beef + Mozarella y Queso Parmesano + Chile Verde + Soda y Papas ............... $5.95  (3)");
                                    Console.WriteLine("Sandwich Pollo BBQ con Fajitas de Pollo + Tocino + Queso Mozzarella y Cheddar + Salsa BBQ + Soda y Papas  ..... $5.75  (4)");
                                    Console.WriteLine("Sandwich Pollo Mezquite con Fajitas de Pollo + Tocino + Queso Mozzarella + Salsa Quiznos + Soda y Papas  ...... $5.75  (5)");
                                    comb1 = int.Parse(Console.ReadLine());
                                    if (comb1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el combo de sandwich numero" + " " + comb1 + " " + "y su precio es de " + "$" + (5.50 * cant));
                                        preciofinal = preciofinal + (5.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el combo de sandwich numero" + " " + comb1 + " " + "y su precio es de " + "$" + (5.25 * cant));
                                        preciofinal = preciofinal + (5.25 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el combo de sandwich numero" + " " + comb1 + " " + "y su precio es de " + "$" + (5.95 * cant));
                                        preciofinal = preciofinal + (5.95 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 4)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el combo de sandwich numero" + " " + comb1 + " " + "y su precio es de " + "$" + (5.75 * cant));
                                        preciofinal = preciofinal + (5.75 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 5)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el combo de sandwich numero" + " " + comb1 + " " + "y su precio es de " + "$" + (5.75 * cant));
                                        preciofinal = preciofinal + (5.75 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                                case ("3"):
                                    //MENU BEBIDAS FRIAS QUIZNOS
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine();
                                    Console.WriteLine("====================== MENU BEBIDAS FRIAS =========================");
                                    Console.WriteLine();
                                    Console.WriteLine("Agua en Botella  ............................... $1.50  (1)");
                                    Console.WriteLine("Gaseosa Uva  ................................... $1.75  (2)");
                                    Console.WriteLine("Gaseosa Naranja  ............................... $1.75  (3)");
                                    Console.WriteLine("Gaseosa CocaCola  .............................. $1.75  (4)");
                                    Console.WriteLine("Gaseosa 7 UP  .................................. $1.75  (5)");
                                    Console.WriteLine("Vaso de Te Helado............................... $2.25  (6)");
                                    Console.WriteLine("Limonada ....................................... $3.00  (7)");
                                    comb1 = int.Parse(Console.ReadLine());
                                    if (comb1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la Bebida numero" + " " + comb1 + " " + "y su precio es de " + "$" + (1.50 * cant));
                                        preciofinal = preciofinal + (1.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la Bebida numero" + " " + comb1 + " " + "y su precio es de " + "$" + (1.75 * cant));
                                        preciofinal = preciofinal + (1.75 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la Bebida numero" + " " + comb1 + " " + "y su precio es de " + "$" + (1.75 * cant));
                                        preciofinal = preciofinal + (1.75 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 4)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la Bebida numero" + " " + comb1 + " " + "y su precio es de " + "$" + (1.75 * cant));
                                        preciofinal = preciofinal + (1.75 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 5)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la Bebida numero" + " " + comb1 + " " + "y su precio es de " + "$" + (1.75 * cant));
                                        preciofinal = preciofinal + (1.75 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 6)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la Bebida numero" + " " + comb1 + " " + "y su precio es de " + "$" + (2.25 * cant));
                                        preciofinal = preciofinal + (2.25 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 7)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la Bebida numero" + " " + comb1 + " " + "y su precio es de " + "$" + (3.00 * cant));
                                        preciofinal = preciofinal + (3.00 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                                case ("4"):
                                    //MENU WRAP QUIZNOS
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine();
                                    Console.WriteLine("====================== MENU WRAPS =========================");
                                    Console.WriteLine();
                                    Console.WriteLine("Wrap Bistro con Roast Beef + Mozarella y Queso Parmesano + Chile Verde .................. $5.75  (1)");
                                    Console.WriteLine("Wrap Pollo con fajas de pollo + Mozarella y Queso Parmesano + Salsa Quiznos ............. $6.25  (2)");
                                    Console.WriteLine("Wrap Pavo & Veggie con Queso + Ensalada + Cebolla Morada + Salsa Ranch  ................. $6.00  (3)");
                                    Console.WriteLine("Wrap Steak con Carne de Res + Mozarella y Queso Parmesano + Chile Verde + Cebolla ....... $6.45  (4)");
                                    comb1 = int.Parse(Console.ReadLine());
                                    if (comb1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el Wrap numero" + " " + comb1 + " " + "y su precio es de " + "$" + (5.75 * cant));
                                        preciofinal = preciofinal + (5.75 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el Wrap numero" + " " + comb1 + " " + "y su precio es de " + "$" + (6.25 * cant));
                                        preciofinal = preciofinal + (6.25 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el Wrap numero" + " " + comb1 + " " + "y su precio es de " + "$" + (6.00 * cant));
                                        preciofinal = preciofinal + (6.00 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 4)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el Wrap numero" + " " + comb1 + " " + "y su precio es de " + "$" + (6.45 * cant));
                                        preciofinal = preciofinal + (6.45 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                            }
                        }
                        break;
                }
                break;
            case ("6"):
                Console.WriteLine("Que restaurante desea ordenar");
                Console.WriteLine("LacaLaca     (1)     La Campana        (2)      TacoBell   (3)");
                Console.WriteLine("El Zocalo    (4)     Taqueria la 20    (5)      ");
                ham = Console.ReadLine();
                switch (ham)
                {
                    //MENU LACALACA
                    case ("1"):
                        while (p == "Si")
                        {
                            Console.WriteLine("====================== RESTAURANTE LACALACA =========================");
                            Console.WriteLine();
                            Console.WriteLine("Bienvenido al menú de LacaLaca, ¿Qué desea ordenar?");
                            Console.WriteLine("Promociones        (1)    Para Compartir   (2)      Los Especiales    (3)");
                            Console.WriteLine("Carnes X Libra     (4)    Bebidas          (5)      ");
                            men1 = Console.ReadLine();
                            switch (men1)
                            {
                                //MENU  PROMOCIONES LACALACA
                                case ("1"):
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine();
                                    Console.WriteLine("====================== MENU PROMOCIONES =========================");
                                    Console.WriteLine();
                                    Console.WriteLine("Taza de LacaLaca: Compra una llevate una extra gratis ............................................. $15.00  (1)");
                                    Console.WriteLine("Carnes X Libra: 1 libra de Pastor + 15 tortillas + Cebolla y Cilantro + Frijoles + Guacamol ....... $15.99  (2)");
                                    Console.WriteLine("Carnes X Libra: 1 libra de Pollo + 15 tortillas + Cebolla y Cilantro + Frijoles + Guacamol ........ $15.99  (3)");
                                    Console.WriteLine("Carnes X Libra: 1 libra de Carnitas + 15 tortillas + Cebolla y Cilantro + Frijoles + Guacamol ..... $15.99  (4)");
                                    Console.WriteLine("Carnes X Libra: 1 libra de Res + 15 tortillas + Cebolla y Cilantro + Frijoles + Guacamol .......... $15.99  (5)");
                                    comb1 = int.Parse(Console.ReadLine());
                                    if (comb1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la promocion numero" + " " + comb1 + " " + "y su precio es de " + "$" + (15.00 * cant));
                                        preciofinal = preciofinal + (15.00 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la promocion numero" + " " + comb1 + " " + "y su precio es de " + "$" + (15.99 * cant));
                                        preciofinal = preciofinal + (15.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la promocion numero" + " " + comb1 + " " + "y su precio es de " + "$" + (15.99 * cant));
                                        preciofinal = preciofinal + (15.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 4)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la promocion numero" + " " + comb1 + " " + "y su precio es de " + "$" + (15.99 * cant));
                                        preciofinal = preciofinal + (15.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 5)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la promocion numero" + " " + comb1 + " " + "y su precio es de " + "$" + (15.99 * cant));
                                        preciofinal = preciofinal + (15.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }



                                    break;
                                case ("2"):
                                    //MENU PARA COMPARTIR LACALACA
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine();
                                    Console.WriteLine("====================== MENU PARA COMPARTIR =========================");
                                    Console.WriteLine();
                                    Console.WriteLine("Chilachos medianos de Carne de Res (Tortilla Chips+ Salsa Verde + Guacamole + Queso Rayado+ Frijoles) ......... $10.99  (1)");
                                    Console.WriteLine("Los Sopes (Enchiladas de Res con Queso Rayado + Cebolla + Lechuga + Frijol Laca)............................... $5.35   (2)");
                                    Console.WriteLine("Reino Chilachos (tortilla chips + salsa verde o roja + guacamole + queso rayado, frijoles laca)  .............. $13.99  (3)");
                                    comb1 = int.Parse(Console.ReadLine());
                                    if (comb1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el menu para compartir numero" + " " + comb1 + " " + "y su precio es de " + "$" + (10.99 * cant));
                                        preciofinal = preciofinal + (10.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el menu para compartir numero" + " " + comb1 + " " + "y su precio es de " + "$" + (5.35 * cant));
                                        preciofinal = preciofinal + (5.35 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el menu para compartir numero" + " " + comb1 + " " + "y su precio es de " + "$" + (13.99 * cant));
                                        preciofinal = preciofinal + (13.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                                case ("3"):
                                    //MENU LOS ESPECIALES LACALACA
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine();
                                    Console.WriteLine("====================== MENU LOS ESPECIALES =========================");
                                    Console.WriteLine();
                                    Console.WriteLine("3 Tacos de Res + Cebolla + Cilantro + Salsas de la Casa  ........................................... $4.99  (1)");
                                    Console.WriteLine("3 Tacos de Pollo + Cebolla + Cilantro + Salsas de la Casa........................................... $4.99  (2)");
                                    Console.WriteLine("Burrito de Res con frijol + guacamole +queso y cebollitas refritas en chipotle con mayonesa ........ $7.69  (3)");
                                    Console.WriteLine("Burrito de Pollo con frijol + guacamole +queso y cebollitas refritas en chipotle con mayonesa ...... $7.69  (4)");
                                    Console.WriteLine("Gringas de Res envueltas en 2 tortillas de harina y queso .......................................... $4.99  (5)");
                                    Console.WriteLine("Gringas de Pollo envueltas en 2 tortillas de harina y queso ........................................ $4.99  (6)");
                                    Console.WriteLine("Sandwich de Pollo + Queso fundido + Mayonesa + Salsas de la casa.................................... $4.99  (7)");
                                    Console.WriteLine("Sandwich de Res + Queso fundido + Mayonesa + Salsas de la casa...................................... $4.99  (8)");
                                    comb1 = int.Parse(Console.ReadLine());
                                    if (comb1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el especial numero" + " " + comb1 + " " + "y su precio es de " + "$" + (4.99 * cant));
                                        preciofinal = preciofinal + (4.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el especial numero" + " " + comb1 + " " + "y su precio es de " + "$" + (4.99 * cant));
                                        preciofinal = preciofinal + (4.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el especial numero" + " " + comb1 + " " + "y su precio es de " + "$" + (7.69 * cant));
                                        preciofinal = preciofinal + (7.69 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 4)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el especial numero" + " " + comb1 + " " + "y su precio es de " + "$" + (7.69 * cant));
                                        preciofinal = preciofinal + (7.69 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 5)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el especial numero" + " " + comb1 + " " + "y su precio es de " + "$" + (4.99 * cant));
                                        preciofinal = preciofinal + (4.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 6)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el especial numero" + " " + comb1 + " " + "y su precio es de " + "$" + (4.99 * cant));
                                        preciofinal = preciofinal + (4.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 7)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el especial numero" + " " + comb1 + " " + "y su precio es de " + "$" + (4.99 * cant));
                                        preciofinal = preciofinal + (4.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 8)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el especial numero" + " " + comb1 + " " + "y su precio es de " + "$" + (4.99 * cant));
                                        preciofinal = preciofinal + (4.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                                case ("4"):
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine();
                                    Console.WriteLine("====================== MENU CARNES X LIBRA =========================");
                                    Console.WriteLine();
                                    Console.WriteLine("Carnes X Libra: 1 libra de Pastor + 15 tortillas + Cebolla y Cilantro + Frijoles + Guacamol ....... $15.99  (1)");
                                    Console.WriteLine("Carnes X Libra: 1 libra de Pollo + 15 tortillas + Cebolla y Cilantro + Frijoles + Guacamol ........ $15.99  (2)");
                                    Console.WriteLine("Carnes X Libra: 1 libra de Carnitas + 15 tortillas + Cebolla y Cilantro + Frijoles + Guacamol ..... $15.99  (3)");
                                    Console.WriteLine("Carnes X Libra: 1 libra de Res + 15 tortillas + Cebolla y Cilantro + Frijoles + Guacamol .......... $15.99  (4)");
                                    Console.WriteLine("Carnes X Libra: 1 libra de Chilorio + 15 tortillas + Cebolla y Cilantro + Frijoles + Guacamol ..... $15.99  (5)");
                                    comb1 = int.Parse(Console.ReadLine());
                                    if (comb1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el menu de Carnes X Libra numero" + " " + comb1 + " " + "y su precio es de " + "$" + (15.99 * cant));
                                        preciofinal = preciofinal + (15.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el menu de Carnes X Libra numero" + " " + comb1 + " " + "y su precio es de " + "$" + (15.99 * cant));
                                        preciofinal = preciofinal + (15.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el menu de Carnes X Libra numero" + " " + comb1 + " " + "y su precio es de " + "$" + (15.99 * cant));
                                        preciofinal = preciofinal + (15.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 4)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el menu de Carnes X Libra numero" + " " + comb1 + " " + "y su precio es de " + "$" + (15.99 * cant));
                                        preciofinal = preciofinal + (15.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 5)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el menu de Carnes X Libra numero" + " " + comb1 + " " + "y su precio es de " + "$" + (15.99 * cant));
                                        preciofinal = preciofinal + (15.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                                case ("5"):
                                    //MENU BEBIDAS LACALACA
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine();
                                    Console.WriteLine("====================== MENU BEBIDAS =========================");
                                    Console.WriteLine();
                                    Console.WriteLine("Agua en Botella  ............................... $1.50  (1)");
                                    Console.WriteLine("Gaseosa Uva  ................................... $1.75  (2)");
                                    Console.WriteLine("Gaseosa Naranja  ............................... $1.75  (3)");
                                    Console.WriteLine("Gaseosa CocaCola  .............................. $1.75  (4)");
                                    Console.WriteLine("Gaseosa 7 UP  .................................. $1.75  (5)");
                                    Console.WriteLine("Vaso de Te Helado............................... $2.25  (6)");
                                    Console.WriteLine("Limonada ....................................... $3.00  (7)");
                                    Console.WriteLine("Horchata........................................ $1.75  (8)");
                                    comb1 = int.Parse(Console.ReadLine());
                                    if (comb1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la Bebida numero" + " " + comb1 + " " + "y su precio es de " + "$" + (1.50 * cant));
                                        preciofinal = preciofinal + (1.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la Bebida numero" + " " + comb1 + " " + "y su precio es de " + "$" + (1.75 * cant));
                                        preciofinal = preciofinal + (1.75 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la Bebida numero" + " " + comb1 + " " + "y su precio es de " + "$" + (1.75 * cant));
                                        preciofinal = preciofinal + (1.75 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 4)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la Bebida numero" + " " + comb1 + " " + "y su precio es de " + "$" + (1.75 * cant));
                                        preciofinal = preciofinal + (1.75 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 5)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la Bebida numero" + " " + comb1 + " " + "y su precio es de " + "$" + (1.75 * cant));
                                        preciofinal = preciofinal + (1.75 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 6)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la Bebida numero" + " " + comb1 + " " + "y su precio es de " + "$" + (2.25 * cant));
                                        preciofinal = preciofinal + (2.25 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 7)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la Bebida numero" + " " + comb1 + " " + "y su precio es de " + "$" + (3.00 * cant));
                                        preciofinal = preciofinal + (3.00 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 8)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la Bebida numero" + " " + comb1 + " " + "y su precio es de " + "$" + (1.75 * cant));
                                        preciofinal = preciofinal + (1.75 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                            }

                        }
                        break;
                    case ("2"):
                        while (p == "Si")
                        {
                            Console.WriteLine("====================== RESTAURANTE LA CAMPANA  =========================");
                            Console.WriteLine();
                            Console.WriteLine("Bienvenido al menú de La Campana, ¿Qué desea ordenar?");
                            Console.WriteLine("Desayuno              (1)    Para Compartir             (2)      Tipicos Mexicanos    (3)");
                            Console.WriteLine("Banquete en Familia   (4)    Carne Asada a la Parrilla  (5)      Bebidas              (6)");
                            men1 = Console.ReadLine();
                            switch (men1)
                            {
                                case ("1"):
                                    //MENU DESAYUNO LA CAMPANA 
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine();
                                    Console.WriteLine("====================== MENU DESAYUNOS =========================");
                                    Console.WriteLine();
                                    Console.WriteLine("Sandwich con Huevo + frijoles + guacamol + jamón + Cafe/Jugo ..................................... $4.25  (1)");
                                    Console.WriteLine("Desayuno Tipico con huevos revueltos + frijoles + plátanos y crema + Cafe/Jugo ................... $4.75  (2)");
                                    Console.WriteLine("Desayuno Economico con duevos revueltos y frijoles + Cafe/Jugo.................................... $2.75  (3)");
                                    comb1 = int.Parse(Console.ReadLine());
                                    if (comb1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el desayuno numero" + " " + comb1 + " " + "y su precio es de " + "$" + (4.25 * cant));
                                        preciofinal = preciofinal + (4.25 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el desayuno numero" + " " + comb1 + " " + "y su precio es de " + "$" + (4.75 * cant));
                                        preciofinal = preciofinal + (4.75 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el desayuno numero" + " " + comb1 + " " + "y su precio es de " + "$" + (2.75 * cant));
                                        preciofinal = preciofinal + (2.75 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                                case ("2"):
                                    //MENU PARA COMPARTIR LA CAMPANA
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine();
                                    Console.WriteLine("====================== MENU PARA COMPARTIR  =========================");
                                    Console.WriteLine();
                                    Console.WriteLine("Sandwich con Pollo + Queso + Vegetales Frescos + Bebida  ............ $4.75  (1)");
                                    Console.WriteLine("Entrada de Sopa de Tortilla  ........................................ $2.75  (2)");
                                    comb1 = int.Parse(Console.ReadLine());
                                    if (comb1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el menu para compartir numero" + " " + comb1 + " " + "y su precio es de " + "$" + (4.75 * cant));
                                        preciofinal = preciofinal + (4.75 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el menu para compartir numero" + " " + comb1 + " " + "y su precio es de " + "$" + (2.75 * cant));
                                        preciofinal = preciofinal + (2.75 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                                case ("3"):
                                    //MENU TIPICOS MEXICANOS 
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine();
                                    Console.WriteLine("====================== MENU TIPICOS MEXCANOS  =========================");
                                    Console.WriteLine();
                                    Console.WriteLine("Torta Mexicana de Res ........................................ $6.50  (1)");
                                    Console.WriteLine("Torta Mexicana de Pollo ...................................... $6.50  (2)");
                                    Console.WriteLine("Torta Mexicana Mixta ......................................... $6.50  (3)");
                                    Console.WriteLine("Torta Mexicana Al Pastor ..................................... $6.50  (4)");
                                    Console.WriteLine("4 Tacos Mexicanos Al Pastor .................................. $6.50  (5)");
                                    Console.WriteLine("4 Tacos Mexicanos de Pollo ................................... $6.50  (6)");
                                    Console.WriteLine("4 Tacos Mexicanos de Res ..................................... $6.50  (7)");
                                    Console.WriteLine("3 Enchiladas Al Pastor ....................................... $6.50  (8)");
                                    Console.WriteLine("3 Enchiladas de Res .......................................... $6.50  (9)");
                                    Console.WriteLine("3 Enchiladas de Pollo ........................................ $6.50 (10)");
                                    Console.WriteLine("Alambre de Res (Carne+tomate+cebolla+chile verde+queso) ...... $6.50 (11)");
                                    Console.WriteLine("Alambre de Pollo (Carne+tomate+cebolla+chile verde+queso) .... $6.50 (12)");
                                    comb1 = int.Parse(Console.ReadLine());
                                    if (comb1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el tipico mexicano numero" + " " + comb1 + " " + "y su precio es de " + "$" + (6.50 * cant));
                                        preciofinal = preciofinal + (6.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el tipico mexicano numero" + " " + comb1 + " " + "y su precio es de " + "$" + (6.50 * cant));
                                        preciofinal = preciofinal + (6.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el tipico mexicano numero" + " " + comb1 + " " + "y su precio es de " + "$" + (6.50 * cant));
                                        preciofinal = preciofinal + (6.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 4)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el tipico mexicano numero" + " " + comb1 + " " + "y su precio es de " + "$" + (6.50 * cant));
                                        preciofinal = preciofinal + (6.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 5)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el tipico mexicano numero" + " " + comb1 + " " + "y su precio es de " + "$" + (6.50 * cant));
                                        preciofinal = preciofinal + (6.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 6)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el tipico mexicano numero" + " " + comb1 + " " + "y su precio es de " + "$" + (6.50 * cant));
                                        preciofinal = preciofinal + (6.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 7)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el tipico mexicano numero" + " " + comb1 + " " + "y su precio es de " + "$" + (6.50 * cant));
                                        preciofinal = preciofinal + (6.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 8)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el tipico mexicano numero" + " " + comb1 + " " + "y su precio es de " + "$" + (6.50 * cant));
                                        preciofinal = preciofinal + (6.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 9)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el tipico mexicano numero" + " " + comb1 + " " + "y su precio es de " + "$" + (6.50 * cant));
                                        preciofinal = preciofinal + (6.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 10)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el tipico mexicano numero" + " " + comb1 + " " + "y su precio es de " + "$" + (6.50 * cant));
                                        preciofinal = preciofinal + (6.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 11)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el tipico mexicano numero" + " " + comb1 + " " + "y su precio es de " + "$" + (6.50 * cant));
                                        preciofinal = preciofinal + (6.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 12)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el tipico mexicano numero" + " " + comb1 + " " + "y su precio es de " + "$" + (6.50 * cant));
                                        preciofinal = preciofinal + (6.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                                case ("4"):
                                    //MENU BANQUETE EN FAMILIA
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine();
                                    Console.WriteLine("====================== MENU BAQUETE EN FAMILIA  =========================");
                                    Console.WriteLine();
                                    Console.WriteLine("Taquiza de 16 unidades de Pollo.................................. $18.99  (1)");
                                    Console.WriteLine("Taquiza de 16 unidades de Res ................................... $18.99  (2)");
                                    Console.WriteLine("Taquiza de 16 unidades de Al Pastor ............................. $18.99  (3)");
                                    Console.WriteLine("Parrillada para 2 personas  ..................................... $18.99  (4)");
                                    Console.WriteLine("Parrillada para 4 personas  ..................................... $28.99  (5)");
                                    comb1 = int.Parse(Console.ReadLine());
                                    if (comb1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el banquete en familia numero" + " " + comb1 + " " + "y su precio es de " + "$" + (18.99 * cant));
                                        preciofinal = preciofinal + (18.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el banquete en familia numero" + " " + comb1 + " " + "y su precio es de " + "$" + (18.99 * cant));
                                        preciofinal = preciofinal + (18.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el banquete en familia numero" + " " + comb1 + " " + "y su precio es de " + "$" + (18.99 * cant));
                                        preciofinal = preciofinal + (18.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 4)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el banquete en familia numero" + " " + comb1 + " " + "y su precio es de " + "$" + (18.99 * cant));
                                        preciofinal = preciofinal + (18.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 5)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el banquete en familia numero" + " " + comb1 + " " + "y su precio es de " + "$" + (28.99 * cant));
                                        preciofinal = preciofinal + (28.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                                case ("5"):
                                    //MENU CARNE ASADA A LA PARRILLA LA CAMPANA
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine();
                                    Console.WriteLine("====================== MENU CARNE ASADA A LA PARRILLA  =========================");
                                    Console.WriteLine();
                                    Console.WriteLine("Churrasco con Chirimol + casamiento + guacamol + chorizo ............. $8.99  (1)");
                                    Console.WriteLine("Carne Campesina con Frijol + Arroz + chorizo y papas ................. $8.99  (2)");
                                    Console.WriteLine("Carne Asada con Chirimol + casamiento + guacamol  .................... $7.99  (3)");
                                    Console.WriteLine("Chicharrones 1/2 libra con casamiento + guacamol  .................... $7.99  (4)");
                                    Console.WriteLine("8 onzas de Costilla de Cerdo con Chirimol + Papas Salteadas .......... $7.99  (5)");
                                    comb1 = int.Parse(Console.ReadLine());
                                    if (comb1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el menu carne asada a la parrilla numero" + " " + comb1 + " " + "y su precio es de " + "$" + (8.99 * cant));
                                        preciofinal = preciofinal + (8.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el menu carne asada a la parrilla numero" + " " + comb1 + " " + "y su precio es de " + "$" + (8.99 * cant));
                                        preciofinal = preciofinal + (8.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el menu carne asada a la parrilla numero" + " " + comb1 + " " + "y su precio es de " + "$" + (7.99 * cant));
                                        preciofinal = preciofinal + (7.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 4)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el menu carne asada a la parrilla numero" + " " + comb1 + " " + "y su precio es de " + "$" + (7.99 * cant));
                                        preciofinal = preciofinal + (7.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 5)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el menu carne asada a la parrilla numero" + " " + comb1 + " " + "y su precio es de " + "$" + (7.99 * cant));
                                        preciofinal = preciofinal + (7.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                                case ("6"):
                                    //MENU BEBIDAS LA CAMPANA
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine();
                                    Console.WriteLine("====================== MENU BEBIDAS =========================");
                                    Console.WriteLine();
                                    Console.WriteLine("Agua en Botella  ............................... $1.50  (1)");
                                    Console.WriteLine("Gaseosa Uva  ................................... $1.75  (2)");
                                    Console.WriteLine("Gaseosa Naranja  ............................... $1.75  (3)");
                                    Console.WriteLine("Gaseosa CocaCola  .............................. $1.75  (4)");
                                    Console.WriteLine("Gaseosa 7 UP  .................................. $1.75  (5)");
                                    Console.WriteLine("Vaso de Te Helado............................... $2.25  (6)");
                                    Console.WriteLine("Limonada ....................................... $3.00  (7)");
                                    Console.WriteLine("Horchata........................................ $1.75  (8)");
                                    comb1 = int.Parse(Console.ReadLine());
                                    if (comb1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la Bebida numero" + " " + comb1 + " " + "y su precio es de " + "$" + (1.50 * cant));
                                        preciofinal = preciofinal + (1.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la Bebida numero" + " " + comb1 + " " + "y su precio es de " + "$" + (1.75 * cant));
                                        preciofinal = preciofinal + (1.75 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la Bebida numero" + " " + comb1 + " " + "y su precio es de " + "$" + (1.75 * cant));
                                        preciofinal = preciofinal + (1.75 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 4)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la Bebida numero" + " " + comb1 + " " + "y su precio es de " + "$" + (1.75 * cant));
                                        preciofinal = preciofinal + (1.75 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 5)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la Bebida numero" + " " + comb1 + " " + "y su precio es de " + "$" + (1.75 * cant));
                                        preciofinal = preciofinal + (1.75 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 6)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la Bebida numero" + " " + comb1 + " " + "y su precio es de " + "$" + (2.25 * cant));
                                        preciofinal = preciofinal + (2.25 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 7)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la Bebida numero" + " " + comb1 + " " + "y su precio es de " + "$" + (3.00 * cant));
                                        preciofinal = preciofinal + (3.00 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 8)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la Bebida numero" + " " + comb1 + " " + "y su precio es de " + "$" + (1.75 * cant));
                                        preciofinal = preciofinal + (1.75 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                            }
                        }
                        break;
                    case ("3"):
                        while (p == "Si")
                        {
                            Console.WriteLine("====================== RESTAURANTE TACO BELL  =========================");
                            Console.WriteLine();
                            Console.WriteLine("Bienvenido al menú de Taco Bell, ¿Qué desea ordenar?");
                            Console.WriteLine("Promociones              (1)   Combo Familiar        (2)      Tacos Y Burritos     (3)");
                            Console.WriteLine("Para Compartir           (4)   Papas                 (5)      Bebidas              (6)");
                            men1 = Console.ReadLine();
                            switch (men1)
                            {
                                case ("1"):
                                    //MENU PROMOCIONES TACO BELL
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine();
                                    Console.WriteLine("====================== MENU PROMOCIONES =========================");
                                    Console.WriteLine();
                                    Console.WriteLine("Combo Tribu Pa'4: 4 burritos + 4 Tacos + 1 Nachos BellGrande + 4 Flautas de Leche + 4 Bebidas  ................ $20.35  (1)");
                                    Console.WriteLine("4 burritos california+ 4 chalupas nachos cheese + 2 nachos party + 2 flautas + 1 pepsi de 1.5L  ............... $20.99  (2)");
                                    Console.WriteLine("Para Fullearte: 2 burritos 5 capas + papas y bebida mediana  .................................................. $4.99   (3)");
                                    comb1 = int.Parse(Console.ReadLine());
                                    if (comb1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la promocion numero" + " " + comb1 + " " + "y su precio es de " + "$" + (20.35 * cant));
                                        preciofinal = preciofinal + (20.35 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la promocion numero" + " " + comb1 + " " + "y su precio es de " + "$" + (20.99 * cant));
                                        preciofinal = preciofinal + (20.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la promocion numero" + " " + comb1 + " " + "y su precio es de " + "$" + (4.99 * cant));
                                        preciofinal = preciofinal + (4.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                                case ("2"):
                                    // MENU COMBO FAMILIAR 
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine();
                                    Console.WriteLine("====================== MENU COMBO FAMILIAR =========================");
                                    Console.WriteLine();
                                    Console.WriteLine("Combo Full Pack: 4 burritos + 4 Tacos + 1 Nacho Bell Grande + 2 Cinnamon twists + Pepsi 1.5lt ................ $18.99  (1)");
                                    comb1 = int.Parse(Console.ReadLine());
                                    if (comb1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el combo familiar numero" + " " + comb1 + " " + "y su precio es de " + "$" + (18.99 * cant));
                                        preciofinal = preciofinal + (18.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                                case ("3"):
                                    //MENU TACOS Y BURRITOS TACO BELL
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine();
                                    Console.WriteLine("====================== MENU TACOS Y BURRITOS =========================");
                                    Console.WriteLine();
                                    Console.WriteLine("1 Taco Original: Carne Al pastor + fresca lechuga + queso cheddar ...................................... $1.72   (1)");
                                    Console.WriteLine("1 Taco Original: Carne de Res + fresca lechuga + queso cheddar ......................................... $1.72   (2)");
                                    Console.WriteLine("Burrito 5 capas: Carne Al Pastor + frijoles + salsa queso + crema agria + queso cheddar ................ $2.83   (3)");
                                    Console.WriteLine("Big Burrito Steak : Carne de Res + frijoles + salsa queso + crema agria + queso cheddar ................ $3.40   (4)");
                                    Console.WriteLine("Burrito 5 capas: Carne Mixta + frijoles + salsa queso + crema agria + queso cheddar .................... $2.83   (5)");
                                    comb1 = int.Parse(Console.ReadLine());
                                    if (comb1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el menu tacos y burritos" + " " + comb1 + " " + "y su precio es de " + "$" + (1.72 * cant));
                                        preciofinal = preciofinal + (1.72 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el menu tacos y burritos" + " " + comb1 + " " + "y su precio es de " + "$" + (2.83 * cant));
                                        preciofinal = preciofinal + (2.83 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el menu tacos y burritos" + " " + comb1 + " " + "y su precio es de " + "$" + (3.40 * cant));
                                        preciofinal = preciofinal + (3.40 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 4)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el menu tacos y burritos" + " " + comb1 + " " + "y su precio es de " + "$" + (1.72 * cant));
                                        preciofinal = preciofinal + (1.72 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 5)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el menu tacos y burritos" + " " + comb1 + " " + "y su precio es de " + "$" + (2.83 * cant));
                                        preciofinal = preciofinal + (2.83 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                                case ("4"):
                                    //MENU PARA COMPARTIR TACO BELL
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine();
                                    Console.WriteLine("====================== MENU PARA COMPARTIR =========================");
                                    Console.WriteLine();
                                    Console.WriteLine("10 pack de tacos originales (Res, Pastor, Pollo, Cerdo)........................................... $10.00  (1)");
                                    Console.WriteLine("Burrito 5 capas: Burrito 5 Capas + Papas + Bebida  ............................................... $4.75   (2)");
                                    Console.WriteLine("Quesadilla Steak: Quesadilla de Steak + Papas Grandes + Bebida ................................... $6.50   (3)");
                                    Console.WriteLine("Quesadilla de Pollo: Quesadilla de Pollo+ Papas Grandes + Bebida ................................. $6.50   (4)");
                                    Console.WriteLine("Crunchy Wrap Supreme: Crunchy Wrap Supreme con Carne Mixta + Papas Grandes + Bebida .............. $5.44   (5)");
                                    comb1 = int.Parse(Console.ReadLine());
                                    if (comb1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el menu para compartir" + " " + comb1 + " " + "y su precio es de " + "$" + (10.00 * cant));
                                        preciofinal = preciofinal + (10.00 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el menu para compartir" + " " + comb1 + " " + "y su precio es de " + "$" + (4.75 * cant));
                                        preciofinal = preciofinal + (4.75 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el menu para compartir" + " " + comb1 + " " + "y su precio es de " + "$" + (6.50 * cant));
                                        preciofinal = preciofinal + (6.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 4)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el menu para compartir" + " " + comb1 + " " + "y su precio es de " + "$" + (6.50 * cant));
                                        preciofinal = preciofinal + (6.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 5)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el menu para compartir" + " " + comb1 + " " + "y su precio es de " + "$" + (5.44 * cant));
                                        preciofinal = preciofinal + (5.44 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                                case ("5"):
                                    //MENU PAPAS TACOBELL
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine();
                                    Console.WriteLine("====================== MENU PAPAS =========================");
                                    Console.WriteLine();
                                    Console.WriteLine("Mexican Papas: papas crunchy + salsa + Chimol + guacamole ...................................... $2.77   (1)");
                                    Console.WriteLine("Papas Medianas ................................................................................. $1.74   (2)");
                                    Console.WriteLine("Papas Grandes .................................................................................. $1.92   (3)");
                                    Console.WriteLine("Papas Supreme con carne sazonada + salsa queso + crema agria + tomate fresco ................... $3.14   (4)");
                                    comb1 = int.Parse(Console.ReadLine());
                                    if (comb1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la especialidad de papas numero" + " " + comb1 + " " + "y su precio es de " + "$" + (2.77 * cant));
                                        preciofinal = preciofinal + (2.77 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la especialidad de papas numero" + " " + comb1 + " " + "y su precio es de " + "$" + (1.74 * cant));
                                        preciofinal = preciofinal + (1.74 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la especialidad de papas numero" + " " + comb1 + " " + "y su precio es de " + "$" + (1.92 * cant));
                                        preciofinal = preciofinal + (1.92 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 4)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la especialidad de papas numero" + " " + comb1 + " " + "y su precio es de " + "$" + (3.14 * cant));
                                        preciofinal = preciofinal + (3.14 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                                case ("6"):
                                    //MENU BEBIDAS TACOBELL
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine();
                                    Console.WriteLine("====================== MENU BEBIDAS =========================");
                                    Console.WriteLine();
                                    Console.WriteLine("Agua en Botella  ............................... $1.50  (1)");
                                    Console.WriteLine("Gaseosa Uva  ................................... $1.75  (2)");
                                    Console.WriteLine("Gaseosa Naranja  ............................... $1.75  (3)");
                                    Console.WriteLine("Gaseosa CocaCola  .............................. $1.75  (4)");
                                    Console.WriteLine("Gaseosa 7 UP  .................................. $1.75  (5)");
                                    Console.WriteLine("Vaso de Te Helado............................... $2.25  (6)");
                                    Console.WriteLine("Limonada ....................................... $3.00  (7)");
                                    comb1 = int.Parse(Console.ReadLine());
                                    if (comb1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la Bebida numero" + " " + comb1 + " " + "y su precio es de " + "$" + (1.50 * cant));
                                        preciofinal = preciofinal + (1.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la Bebida numero" + " " + comb1 + " " + "y su precio es de " + "$" + (1.75 * cant));
                                        preciofinal = preciofinal + (1.75 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la Bebida numero" + " " + comb1 + " " + "y su precio es de " + "$" + (1.75 * cant));
                                        preciofinal = preciofinal + (1.75 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 4)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la Bebida numero" + " " + comb1 + " " + "y su precio es de " + "$" + (1.75 * cant));
                                        preciofinal = preciofinal + (1.75 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 5)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la Bebida numero" + " " + comb1 + " " + "y su precio es de " + "$" + (1.75 * cant));
                                        preciofinal = preciofinal + (1.75 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 6)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la Bebida numero" + " " + comb1 + " " + "y su precio es de " + "$" + (2.25 * cant));
                                        preciofinal = preciofinal + (2.25 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 7)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la Bebida numero" + " " + comb1 + " " + "y su precio es de " + "$" + (3.00 * cant));
                                        preciofinal = preciofinal + (3.00 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                            }
                        }
                        break;
                    case ("4"):
                        while (p == "Si")
                        {
                            Console.WriteLine("====================== RESTAURANTE EL ZOCALO  =========================");
                            Console.WriteLine();
                            Console.WriteLine("Bienvenido al menú de Taco Bell, ¿Qué desea ordenar?");
                            Console.WriteLine("Pa' Comenzar             (1)   Sopas                 (2)      Pa' Taque-Arte   (3)");
                            Console.WriteLine("Para Compartir           (4)   Los Recomendados      (5)      Bebidas          (6)");
                            men1 = Console.ReadLine();
                            switch (men1)
                            {
                                case ("1"):
                                    //MENU PA COMENZAR ZOCALO
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine();
                                    Console.WriteLine("====================== MENU PA' COMENZAR =========================");
                                    Console.WriteLine();
                                    Console.WriteLine("Nacho Macho de Res: Frijoles + nachos + salsa roja + aguacate + crema + queso rallado + tomate .................. $9.50  (1)");
                                    Console.WriteLine("Nacho Macho de Pastor: Frijoles + nachos + salsa roja + aguacate + crema + queso rallado + tomate ............... $9.50  (2)");
                                    Console.WriteLine("Nacho Macho de Pollo: Frijoles + nachos + salsa roja + aguacate + crema + queso rallado + tomate ................ $9.50  (3)");
                                    Console.WriteLine("Los Sopes: 4 tacos de tortilla + birria de res +queso gratinado + jalapeño + cebolla y cilantro  ................ $7.75  (4)");
                                    Console.WriteLine("Esquite: Maiz cocido + crema especial + mayonesa + queso rallado y cilantro ..................................... $4.75  (5)");
                                    comb1 = int.Parse(Console.ReadLine());
                                    if (comb1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la entrada numero" + " " + comb1 + " " + "y su precio es de " + "$" + (9.50 * cant));
                                        preciofinal = preciofinal + (9.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la entrada numero" + " " + comb1 + " " + "y su precio es de " + "$" + (9.50 * cant));
                                        preciofinal = preciofinal + (9.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la entrada numero" + " " + comb1 + " " + "y su precio es de " + "$" + (9.50 * cant));
                                        preciofinal = preciofinal + (9.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 4)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la entrada numero" + " " + comb1 + " " + "y su precio es de " + "$" + (7.75 * cant));
                                        preciofinal = preciofinal + (7.75 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 5)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la entrada numero" + " " + comb1 + " " + "y su precio es de " + "$" + (4.75 * cant));
                                        preciofinal = preciofinal + (4.75 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                                case ("2"):
                                    //MENU SOPAS ZOCALO
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine();
                                    Console.WriteLine("====================== MENU SOPAS =========================");
                                    Console.WriteLine();
                                    Console.WriteLine("1/2 Sopa de Tortilla con queso + tortilla rallada, aguacate, crema, queso rallado y cilantro  ...................... $4.65  (1)");
                                    Console.WriteLine("Sopa de Tortilla con queso + tortilla rallada, aguacate, crema, queso rallado y cilantro  .......................... $6.95  (2)");
                                    Console.WriteLine("Pozole Mexicano:con Carne de Res + maíz + tostada con lechuga+ cebolla+ chicharra crocante cilantro + limón ........ $7.75  (3)");
                                    comb1 = int.Parse(Console.ReadLine());
                                    if (comb1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la sopa" + " " + comb1 + " " + "y su precio es de " + "$" + (4.65 * cant));
                                        preciofinal = preciofinal + (4.65 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la sopa" + " " + comb1 + " " + "y su precio es de " + "$" + (6.95 * cant));
                                        preciofinal = preciofinal + (4.65 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la sopa" + " " + comb1 + " " + "y su precio es de " + "$" + (7.75 * cant));
                                        preciofinal = preciofinal + (7.75 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                                case ("3"):
                                    //MENU PA TAQUEARTE ZOCALO
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine();
                                    Console.WriteLine("====================== MENU PA'TAQUE-ARTE =========================");
                                    Console.WriteLine();
                                    Console.WriteLine("Tacos Clasicos: 3 Tacos de Res con Cilantro y Cebolla + Salsas de la Casa ......................... $5.50  (1)");
                                    Console.WriteLine("Tacos Clasicos: 3 Tacos de Pollo con Cilantro y Cebolla + Salsas de la Casa ....................... $5.50  (2)");
                                    Console.WriteLine("Tacos Clasicos: 3 Tacos de Al Pastor con Cilantro y Cebolla + Salsas de la Casa ................... $5.50  (3)");
                                    Console.WriteLine("3 Tacos de Birria de Res con Cilantro y Cebolla + Caldo de Birria + Jalapeño ...................... $8.75  (4)");
                                    Console.WriteLine("3 Tacos Chilangos con costra de queso + carne de Res encebollada +salsas+ curtido +chicharra....... $8.50  (5)");
                                    Console.WriteLine("Tacos de cochinita pibil con carnitas en salsa pibil + aguacate + cebolla y frijoles  ............. $7.95  (6)");
                                    comb1 = int.Parse(Console.ReadLine());
                                    if (comb1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el menu Pa'Taque-Arte numero" + " " + comb1 + " " + "y su precio es de " + "$" + (5.50 * cant));
                                        preciofinal = preciofinal + (5.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el menu Pa'Taque-Arte numero" + " " + comb1 + " " + "y su precio es de " + "$" + (5.50 * cant));
                                        preciofinal = preciofinal + (5.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el menu Pa'Taque-Arte numero" + " " + comb1 + " " + "y su precio es de " + "$" + (5.50 * cant));
                                        preciofinal = preciofinal + (5.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 4)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el menu Pa'Taque-Arte numero" + " " + comb1 + " " + "y su precio es de " + "$" + (8.75 * cant));
                                        preciofinal = preciofinal + (8.75 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 5)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el menu Pa'Taque-Arte numero" + " " + comb1 + " " + "y su precio es de " + "$" + (8.50 * cant));
                                        preciofinal = preciofinal + (8.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 6)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el menu Pa'Taque-Arte numero" + " " + comb1 + " " + "y su precio es de " + "$" + (7.95 * cant));
                                        preciofinal = preciofinal + (7.95 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                                case ("4"):
                                    //MENU PARA COMPARTIR
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine();
                                    Console.WriteLine("====================== MENU PARA COMPARTIR =========================");
                                    Console.WriteLine();
                                    Console.WriteLine("Taquiza El Zócalo: Con 3 variedades de carne + cebollines +fríjoles +guacamole +15 tortillas............ $16.50  (1)");
                                    Console.WriteLine("Taquero Mucho:Con 2 carnes de elección encebolladas + aguacate + frijolitos y 10 tortillas.............. $12.99  (2)");
                                    comb1 = int.Parse(Console.ReadLine());
                                    if (comb1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el menu para compartir" + " " + comb1 + " " + "y su precio es de " + "$" + (16.50 * cant));
                                        preciofinal = preciofinal + (16.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el menu para compartir" + " " + comb1 + " " + "y su precio es de " + "$" + (12.99 * cant));
                                        preciofinal = preciofinal + (12.99 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                                case ("5"):
                                    //MENU LOS RECOMENDADOS ZOCALO
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine();
                                    Console.WriteLine("====================== MENU LOS RECOMENDADOS =========================");
                                    Console.WriteLine();
                                    Console.WriteLine("Pancho Villa:8 tacos dorados + carne de Res + salsa roja y crema + guacamole + frijol frito + queso rallado ........... $8.25  (1)");
                                    Console.WriteLine("Pancho Villa:8 tacos dorados + carne de Pollo + salsa roja y crema + guacamole + frijol frito + queso rallado ......... $8.25  (2)");
                                    Console.WriteLine("Pancho Villa:8 tacos dorados + carne Al Pastor + salsa roja y crema + guacamole + frijol frito + queso rallado ........ $8.25  (3)");
                                    Console.WriteLine("Tacos de Canasto Mixto (2 de Res/ 2 de Pastor/ 2 de Pollo) salsas de la casa + guacamol + cilantro y cebolla .......... $6.95  (4)");
                                    Console.WriteLine("Sincronizadas con carne de Res + queso gratinado + frijoles + salsa roja + guacamol + queso rallado ................... $8.50  (5)");
                                    Console.WriteLine("Sincronizadas con carne de Pollo + queso gratinado + frijoles + salsa roja + guacamol + queso rallado ................. $8.50  (6)");
                                    Console.WriteLine("Sincronizadas con carne Al Pastor + queso gratinado + frijoles + salsa roja + guacamol + queso rallado ................ $8.50  (7)");
                                    comb1 = int.Parse(Console.ReadLine());
                                    if (comb1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el menu recomendado" + " " + comb1 + " " + "y su precio es de " + "$" + (8.25 * cant));
                                        preciofinal = preciofinal + (8.25 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el menu recomendado" + " " + comb1 + " " + "y su precio es de " + "$" + (8.25 * cant));
                                        preciofinal = preciofinal + (8.25 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el menu recomendado" + " " + comb1 + " " + "y su precio es de " + "$" + (8.25 * cant));
                                        preciofinal = preciofinal + (8.25 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 4)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el menu recomendado" + " " + comb1 + " " + "y su precio es de " + "$" + (6.95 * cant));
                                        preciofinal = preciofinal + (6.95 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 5)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el menu recomendado" + " " + comb1 + " " + "y su precio es de " + "$" + (8.50 * cant));
                                        preciofinal = preciofinal + (8.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 6)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el menu recomendado" + " " + comb1 + " " + "y su precio es de " + "$" + (8.50 * cant));
                                        preciofinal = preciofinal + (8.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 7)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el menu recomendado" + " " + comb1 + " " + "y su precio es de " + "$" + (8.50 * cant));
                                        preciofinal = preciofinal + (8.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                                case ("6"):
                                    //MENU BEBIDAS ZOCALO
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine();
                                    Console.WriteLine("====================== MENU BEBIDAS =========================");
                                    Console.WriteLine();
                                    Console.WriteLine("Agua en Botella  ............................... $1.50  (1)");
                                    Console.WriteLine("Gaseosa Uva  ................................... $1.75  (2)");
                                    Console.WriteLine("Gaseosa Naranja  ............................... $1.75  (3)");
                                    Console.WriteLine("Gaseosa CocaCola  .............................. $1.75  (4)");
                                    Console.WriteLine("Gaseosa 7 UP  .................................. $1.75  (5)");
                                    Console.WriteLine("Vaso de Te Helado............................... $2.25  (6)");
                                    Console.WriteLine("Limonada ....................................... $3.00  (7)");
                                    comb1 = int.Parse(Console.ReadLine());
                                    if (comb1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la Bebida numero" + " " + comb1 + " " + "y su precio es de " + "$" + (1.50 * cant));
                                        preciofinal = preciofinal + (1.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la Bebida numero" + " " + comb1 + " " + "y su precio es de " + "$" + (1.75 * cant));
                                        preciofinal = preciofinal + (1.75 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la Bebida numero" + " " + comb1 + " " + "y su precio es de " + "$" + (1.75 * cant));
                                        preciofinal = preciofinal + (1.75 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 4)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la Bebida numero" + " " + comb1 + " " + "y su precio es de " + "$" + (1.75 * cant));
                                        preciofinal = preciofinal + (1.75 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 5)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la Bebida numero" + " " + comb1 + " " + "y su precio es de " + "$" + (1.75 * cant));
                                        preciofinal = preciofinal + (1.75 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 6)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la Bebida numero" + " " + comb1 + " " + "y su precio es de " + "$" + (2.25 * cant));
                                        preciofinal = preciofinal + (2.25 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 7)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la Bebida numero" + " " + comb1 + " " + "y su precio es de " + "$" + (3.00 * cant));
                                        preciofinal = preciofinal + (3.00 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                            }
                        }
                        break;
                    case ("5"):
                        while (p == "Si")
                        {
                            Console.WriteLine("====================== TAQUERIA LA 20  =========================");
                            Console.WriteLine();
                            Console.WriteLine("Bienvenido al menú de Taco Bell, ¿Qué desea ordenar?");
                            Console.WriteLine("Burritos            (1)   Tacos           (2)     Tortas     (3)");
                            Console.WriteLine("Quesadillas         (4)   Sopas           (5)     Bebidas    (6)");
                            men1 = Console.ReadLine();
                            switch (men1)
                            {
                                case ("1"):
                                    //MENU BURRITOS LA 20
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine();
                                    Console.WriteLine("====================== MENU BURRITOS =========================");
                                    Console.WriteLine();
                                    Console.WriteLine("Burrito de Carne Al Pastor  .................... $4.00  (1)");
                                    Console.WriteLine("Burrito de Carne de Res  ....................... $4.50  (2)");
                                    Console.WriteLine("Burrito de Carne Asada  ........................ $4.50  (3)");
                                    Console.WriteLine("Burrito de Carne de Pollo ...................... $4.00  (4)");
                                    Console.WriteLine("Burrito de Birria  ............................. $5.00  (5)");
                                    Console.WriteLine("Burrito de Lengua  ............................. $5.00  (6)");
                                    Console.WriteLine("Burrito de Chorizo  ............................ $4.00  (7)");
                                    Console.WriteLine("Burrito de Carne Mixta  ........................ $4.00  (8)");
                                    comb1 = int.Parse(Console.ReadLine());
                                    if (comb1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el burrito numero" + " " + comb1 + " " + "y su precio es de " + "$" + (4.00 * cant));
                                        preciofinal = preciofinal + (4.00 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el burrito numero" + " " + comb1 + " " + "y su precio es de " + "$" + (4.50 * cant));
                                        preciofinal = preciofinal + (4.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el burrito numero" + " " + comb1 + " " + "y su precio es de " + "$" + (4.50 * cant));
                                        preciofinal = preciofinal + (4.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 4)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el burrito numero" + " " + comb1 + " " + "y su precio es de " + "$" + (4.00 * cant));
                                        preciofinal = preciofinal + (4.00 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 5)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el burrito numero" + " " + comb1 + " " + "y su precio es de " + "$" + (5.00 * cant));
                                        preciofinal = preciofinal + (5.00 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 6)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el burrito numero" + " " + comb1 + " " + "y su precio es de " + "$" + (5.00 * cant));
                                        preciofinal = preciofinal + (5.00 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 7)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el burrito numero" + " " + comb1 + " " + "y su precio es de " + "$" + (4.00 * cant));
                                        preciofinal = preciofinal + (4.00 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 8)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado el burrito numero" + " " + comb1 + " " + "y su precio es de " + "$" + (4.00 * cant));
                                        preciofinal = preciofinal + (4.00 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                                case ("2"):
                                    //MENU TACOS LA 20
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine();
                                    Console.WriteLine("====================== MENU TACOS =========================");
                                    Console.WriteLine();
                                    Console.WriteLine("3 Tacos de Carne Al Pastor  .................... $4.25  (1)");
                                    Console.WriteLine("3 Tacos de Carne de Res  ....................... $4.75  (2)");
                                    Console.WriteLine("3 Tacos de Carne Asada  ........................ $4.50  (3)");
                                    Console.WriteLine("3 Tacos de Carne de Pollo ...................... $4.25  (4)");
                                    Console.WriteLine("3 Tacos de Birria  ............................. $5.00  (5)");
                                    Console.WriteLine("3 Tacos de Lengua  ............................. $5.00  (6)");
                                    Console.WriteLine("3 Tacos de Chorizo  ............................ $4.25  (7)");
                                    Console.WriteLine("3 Tacos de Carne Mixta  ........................ $4.25  (8)");
                                    comb1 = int.Parse(Console.ReadLine());
                                    if (comb1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la orden de tacos numero" + " " + comb1 + " " + "y su precio es de " + "$" + (4.25 * cant));
                                        preciofinal = preciofinal + (4.25 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la orden de tacos numero" + " " + comb1 + " " + "y su precio es de " + "$" + (4.75 * cant));
                                        preciofinal = preciofinal + (4.75 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la orden de tacos numero" + " " + comb1 + " " + "y su precio es de " + "$" + (4.50 * cant));
                                        preciofinal = preciofinal + (4.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 4)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la orden de tacos numero" + " " + comb1 + " " + "y su precio es de " + "$" + (4.25 * cant));
                                        preciofinal = preciofinal + (4.25 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 5)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la orden de tacos numero" + " " + comb1 + " " + "y su precio es de " + "$" + (5.00 * cant));
                                        preciofinal = preciofinal + (5.00 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 6)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la orden de tacos numero" + " " + comb1 + " " + "y su precio es de " + "$" + (5.00 * cant));
                                        preciofinal = preciofinal + (5.00 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 7)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la orden de tacos numero" + " " + comb1 + " " + "y su precio es de " + "$" + (4.25 * cant));
                                        preciofinal = preciofinal + (4.25 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 8)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la orden de tacos numero" + " " + comb1 + " " + "y su precio es de " + "$" + (4.25 * cant));
                                        preciofinal = preciofinal + (4.25 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                                case ("3"):
                                    //MENU TORTAS ZOCALO
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine();
                                    Console.WriteLine("====================== MENU TORTAS =========================");
                                    Console.WriteLine();
                                    Console.WriteLine("Torta de Carne Al Pastor  ...................... $4.50  (1)");
                                    Console.WriteLine("Torta de Carne de Res  ......................... $5.00  (2)");
                                    Console.WriteLine("Torta de Carne Asada  .......................... $5.00  (3)");
                                    Console.WriteLine("Torta de Carne de Pollo ........................ $4.50  (4)");
                                    Console.WriteLine("Torta de Birria  ............................... $6.00  (5)");
                                    Console.WriteLine("Torta de Lengua  ............................... $6.00  (6)");
                                    Console.WriteLine("Torta de Chorizo  .............................. $4.50  (7)");
                                    Console.WriteLine("Torta de Carne Mixta  .......................... $4.50  (8)");
                                    comb1 = int.Parse(Console.ReadLine());
                                    if (comb1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la torta numero" + " " + comb1 + " " + "y su precio es de " + "$" + (4.50 * cant));
                                        preciofinal = preciofinal + (4.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la torta numero" + " " + comb1 + " " + "y su precio es de " + "$" + (5.00 * cant));
                                        preciofinal = preciofinal + (5.00 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la torta numero" + " " + comb1 + " " + "y su precio es de " + "$" + (5.00 * cant));
                                        preciofinal = preciofinal + (5.00 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 4)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la torta numero" + " " + comb1 + " " + "y su precio es de " + "$" + (4.50 * cant));
                                        preciofinal = preciofinal + (4.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 5)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la torta numero" + " " + comb1 + " " + "y su precio es de " + "$" + (6.00 * cant));
                                        preciofinal = preciofinal + (6.00 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 6)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la torta numero" + " " + comb1 + " " + "y su precio es de " + "$" + (6.00 * cant));
                                        preciofinal = preciofinal + (6.00 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 7)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la torta numero" + " " + comb1 + " " + "y su precio es de " + "$" + (4.50 * cant));
                                        preciofinal = preciofinal + (4.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 8)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la torta numero" + " " + comb1 + " " + "y su precio es de " + "$" + (4.50 * cant));
                                        preciofinal = preciofinal + (4.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                                case ("4"):
                                    //MENU QUESADILLAS LA 20
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine();
                                    Console.WriteLine("====================== MENU QUESADILLAS =========================");
                                    Console.WriteLine();
                                    Console.WriteLine("Quesadilla de Carne Al Pastor  ................. $2.50  (1)");
                                    Console.WriteLine("Quesadilla de Carne de Res  .................... $2.75  (2)");
                                    Console.WriteLine("Quesadilla de Carne Asada  ..................... $2.75  (3)");
                                    Console.WriteLine("Quesadilla de Carne de Pollo ................... $2.50  (4)");
                                    Console.WriteLine("Quesadilla de Birria  .......................... $3.00  (5)");
                                    Console.WriteLine("Quesadilla de Lengua  .......................... $3.00  (6)");
                                    Console.WriteLine("Quesadilla de Chorizo  ......................... $2.50  (7)");
                                    Console.WriteLine("Quesadilla de Carne Mixta  ..................... $2.50  (8)");
                                    comb1 = int.Parse(Console.ReadLine());
                                    if (comb1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la quesadilla numero" + " " + comb1 + " " + "y su precio es de " + "$" + (2.50 * cant));
                                        preciofinal = preciofinal + (2.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la quesadilla numero" + " " + comb1 + " " + "y su precio es de " + "$" + (2.75 * cant));
                                        preciofinal = preciofinal + (2.75 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la quesadilla numero" + " " + comb1 + " " + "y su precio es de " + "$" + (2.75 * cant));
                                        preciofinal = preciofinal + (2.75 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 4)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la quesadilla numero" + " " + comb1 + " " + "y su precio es de " + "$" + (2.50 * cant));
                                        preciofinal = preciofinal + (2.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 5)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la quesadilla numero" + " " + comb1 + " " + "y su precio es de " + "$" + (3.00 * cant));
                                        preciofinal = preciofinal + (3.00 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 6)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la quesadilla numero" + " " + comb1 + " " + "y su precio es de " + "$" + (3.00 * cant));
                                        preciofinal = preciofinal + (3.00 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 7)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la quesadilla numero" + " " + comb1 + " " + "y su precio es de " + "$" + (2.50 * cant));
                                        preciofinal = preciofinal + (2.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 8)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la quesadilla numero" + " " + comb1 + " " + "y su precio es de " + "$" + (2.50 * cant));
                                        preciofinal = preciofinal + (2.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                                case ("5"):
                                    //MENU SOPAS LA 20
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine();
                                    Console.WriteLine("====================== MENU SOPAS =========================");
                                    Console.WriteLine();
                                    Console.WriteLine("1/2 de Sopa de Tortilla con Chicharron + Aguacate + Limon + Queso Rayado ............ $2.50  (1)");
                                    Console.WriteLine("Sopa de Tortilla con Chicharron + Aguacate + Limon + Queso Rayado.................... $5.00  (2)");
                                    comb1 = int.Parse(Console.ReadLine());
                                    if (comb1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la sopa numero" + " " + comb1 + " " + "y su precio es de " + "$" + (2.50 * cant));
                                        preciofinal = preciofinal + (2.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la sopa numero" + " " + comb1 + " " + "y su precio es de " + "$" + (5.00 * cant));
                                        preciofinal = preciofinal + (5.00 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;
                                case ("6"):
                                    //MENU BEBIDAS LA 20
                                    Console.WriteLine("¿Qué desea pedir? Ingrese el número que aparece en el extremo derecho");
                                    Console.WriteLine();
                                    Console.WriteLine("====================== MENU BEBIDAS =========================");
                                    Console.WriteLine();
                                    Console.WriteLine("Agua en Botella  ............................... $1.50  (1)");
                                    Console.WriteLine("Gaseosa Uva  ................................... $1.75  (2)");
                                    Console.WriteLine("Gaseosa Naranja  ............................... $1.75  (3)");
                                    Console.WriteLine("Gaseosa CocaCola  .............................. $1.75  (4)");
                                    Console.WriteLine("Gaseosa 7 UP  .................................. $1.75  (5)");
                                    Console.WriteLine("Vaso de Te Helado............................... $2.25  (6)");
                                    Console.WriteLine("Limonada ....................................... $3.00  (7)");
                                    comb1 = int.Parse(Console.ReadLine());
                                    if (comb1 == 1)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la Bebida numero" + " " + comb1 + " " + "y su precio es de " + "$" + (1.50 * cant));
                                        preciofinal = preciofinal + (1.50 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 2)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la Bebida numero" + " " + comb1 + " " + "y su precio es de " + "$" + (1.75 * cant));
                                        preciofinal = preciofinal + (1.75 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 3)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la Bebida numero" + " " + comb1 + " " + "y su precio es de " + "$" + (1.75 * cant));
                                        preciofinal = preciofinal + (1.75 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 4)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la Bebida numero" + " " + comb1 + " " + "y su precio es de " + "$" + (1.75 * cant));
                                        preciofinal = preciofinal + (1.75 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 5)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la Bebida numero" + " " + comb1 + " " + "y su precio es de " + "$" + (1.75 * cant));
                                        preciofinal = preciofinal + (1.75 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 6)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la Bebida numero" + " " + comb1 + " " + "y su precio es de " + "$" + (2.25 * cant));
                                        preciofinal = preciofinal + (2.25 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    if (comb1 == 7)
                                    {
                                        Console.WriteLine("¿Cantidad a ordenar?");
                                        cant = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Usted ha ordenado la Bebida numero" + " " + comb1 + " " + "y su precio es de " + "$" + (3.00 * cant));
                                        preciofinal = preciofinal + (3.00 * cant);
                                        Console.WriteLine("¿Desea ordenar algo más?");
                                        p = Console.ReadLine();
                                    }
                                    break;



                            }

                        }
                        break;
                }
                break;
        }
        Console.WriteLine(usuario + " " + "su precio total a pagar es de " + "$" + preciofinal);
        while(selec != 1 & selec != 2)
        {
            Console.WriteLine("Desea pagar con Efectivo (1) o Tarjeta (2)");
            selec = int.Parse(Console.ReadLine());
        }
        switch (selec)
        {
            case 1:
                while (dinero < preciofinal)
                {
                    Console.WriteLine("¿Cuánto dinero va a dar?");
                    dinero = double.Parse(Console.ReadLine());
                    if (dinero == preciofinal)
                    {
                        Console.WriteLine("Usted pagará exacto al repartidor");
                    }
                    if (dinero > preciofinal)
                    {
                        Console.WriteLine("Su vuelto será de $" + (dinero - preciofinal));
                    }
                }
                break;
            case 2:
                    Console.WriteLine("Seleccione su tipo de tarjeta");
                    Console.WriteLine("Visa (1) MasterCard (2) American Express (3)");
                    select = int.Parse(Console.ReadLine());
                    switch (select)
                    {
                        case 1:
                            while (tarjeta <= 99999999999 | tarjeta >= 1000000000000)
                            {
                                Console.WriteLine("Ingrese el número de tarjeta de crédito");
                                tarjeta = double.Parse(Console.ReadLine());
                            }
                            while (cvv <= 99 | cvv >= 1000)
                            {
                                Console.WriteLine("Ingrese el CVV de su tarjeta de crédito");
                                cvv = int.Parse(Console.ReadLine());
                            }
                            break;
                        case 2:
                            while (tarjeta <= 99999999999 | tarjeta >= 1000000000000)
                            {
                                Console.WriteLine("Ingrese el número de tarjeta de crédito");
                                tarjeta = double.Parse(Console.ReadLine());
                            }
                            while (cvv <= 99 | cvv >= 1000)
                            {
                                Console.WriteLine("Ingrese el CVV de su tarjeta de crédito");
                                cvv = int.Parse(Console.ReadLine());
                            }
                            break;
                        case 3:
                            while (tarjeta <= 99999999999 | tarjeta >= 1000000000000)
                            {
                                Console.WriteLine("Ingrese el número de tarjeta de crédito");
                                tarjeta = double.Parse(Console.ReadLine());
                            }
                            while (cvv <= 999 | cvv >= 10000)
                            {
                                Console.WriteLine("Ingrese el CVV de su tarjeta de crédito");
                                cvv = int.Parse(Console.ReadLine());
                            }
                            break;
                    }
                    Console.WriteLine("Se ha completado con éxito la transacción de $" + preciofinal);
                    break;
        }
        Console.WriteLine("Su pedido llegará en un lapso de entre 15 y 30 minutos en la dirección:" + " " + direccion);
        Console.WriteLine("Gracias por comprar con nosotros, disfrute su comida ;)");
    }
}   
