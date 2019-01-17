            int mevcut;
           
            Console.Write("sınıf mevcudu :");
            mevcut = int.Parse(Console.ReadLine());
            ogrenci temp = new ogrenci();
            ogrenci orta = new ogrenci();
            ogrenci[] ogr = new ogrenci[mevcut];


            for(int i = 0; i < mevcut; i++)
            {
                ogr[i] = new ogrenci();
                Console.Write("{0}. öğrencinin adını giriniz: ", i+1);
                ogr[i].SetAd(Console.ReadLine());
                Console.Write("{0}. öğrencinin soyadını giriniz: ", i+1);
                ogr[i].SetSoyad(Console.ReadLine());
                Console.Write("{0}. öğrencinin numarasını giriniz: ", i+1);
                ogr[i].SetNo(Console.ReadLine());
                Console.Write("{0}. öğrencinin not ortalamasını giriniz: ", i+1);
                ogr[i].SetOrtalama(double.Parse(Console.ReadLine()));

                
            }

            for (int j = 0; j < mevcut; j++)
            {
                Console.WriteLine(ogr[j].ToString());
            }

            for (int j = 0; j < mevcut; j++)
            {
                temp += ogr[j];
            }

            orta = temp / mevcut;

            Console.WriteLine("Sınıf Ortalaması :" + orta.GetOrtalama());

            Console.ReadKey();
