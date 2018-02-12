using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Uygulama
{
    class SqlHelper                             //   <-----   staticte yapabilirdik.
    {                            


        // 1 ) const ile sabit değer tanımlayabiliyorum(değeri değiştirilemeyen fieldlardır)                             (const işe sabit tanımlanan değişkenin değerini o anda vermek şarttır.)
        // 2 ) static ile sabit değer tanımlanabilir. Readonly keyword ile değeri değiştirilemeyen fieldlar yaratırız. ama ilk değeri o anda vermek şart değildir. Constructor metodunda da ilk değer verilebilir.
        static SqlHelper()
        {
            ConnectionStringStaticReadonly = "server=.;database=Northwind;Integrated Security=true;";

            cnn2 = new SqlConnection(ConnectionStringStaticReadonly);
        }
        
        //const => constant

        //1.Yöntem
        public const string ConnectionString = "server=.;database=Northwind;Integrated Security=true;";

        //2.Yöntem
        public static string ConnectionStringStatic = "server=.;database=Northwind;Integrated Security=true;";

        //3.Yöntem
        public static string ConnectionStringStaticReadonly;
                        // herhangi birini çağırabiliriz.

        //4.Yöntem => Kod tarafında SqlConnection dan instance almamak icin kullanıyorum.                             SqlHelper ın constructorında instance alma işlemini gerçekleştirdik.
        public static SqlConnection cnn2;

    }
}
