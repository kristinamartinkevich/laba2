using System;
using System.Text;
using System.ValueTuple;
      
namespace ygyg
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("1a || ����������� ����:");
            sbyte sbyteValue = -77;
            Console.WriteLine("sbyte " + sbyteValue);

            byte byteValue = 56;
            Console.WriteLine("byte " + byteValue);

            char charValue = 'h';
            Console.WriteLine("char " + charValue);

            bool boolValue = true;
            Console.WriteLine("bool " + boolValue);

            short shortValue = 5485;
            Console.WriteLine("short " + shortValue);

            int intValue = 19495;
            Console.WriteLine("int " + intValue);

            uint uintValue = 584;
            Console.WriteLine("uint " + uintValue);

            long longValue = 969305;
            Console.WriteLine("long " + longValue);

            ulong ulongValue = 958392;
            Console.WriteLine("ulong " + ulongValue);

            float floatValue = 54.5463f;
            Console.WriteLine("float " + floatValue);

            double doubleValue = -12.991114578;
            Console.WriteLine("double " + doubleValue);

            decimal decimalValue = -38.54m;
            Console.WriteLine("decimal " + decimalValue);

            //������� ��������������
            Console.WriteLine("1b || ������� ��������������:");
            sbyte sb = -98;
            short sb1 = sb;
            Console.WriteLine(sb1);

            ushort ush = 65;
            uint ush1 = ush;
            Console.WriteLine(ush1);

            long lg = -187;
            float lg1 = lg;
            Console.WriteLine(lg1);

            byte bt = 201;
            double bt1 = bt;
            Console.WriteLine(bt1);


            ulong ul = 973;
            float ul1 = ul;
            Console.WriteLine(ul1);

            //����� ��������������

            Console.WriteLine("1b || ����� ��������������:");
            ulong ulo = 897867543;
            byte ulo1;
            ulo1 = (byte)ulo;
            Console.WriteLine(ulo1);

            double db = 89.7543;
            int db1;
            db1 = (int)db;
            Console.WriteLine(db1);

            float ft = 89.43f;
            char ft1;
            ft1 = (char)ft;
            Console.WriteLine(ft1);

            float flt = 7878.90f;
            short flt1;
            flt1 = (short)flt;
            Console.WriteLine(flt1);

            char ch = 'u';
            short ch1;
            ch1 = (short)ch;
            Console.WriteLine(ch1);

            //��������/����������
            Console.WriteLine("1c || ��������/����������:");
            int i = 564;
            object o = (object)i; //��������

            o = 987;
            i = (int)o; //����������

			//������ �������������� ���������� 
			Console.WriteLine("1d || ������ �������������� ����������:");
            var ppp = 7;
            var s = "������";
            Console.WriteLine(s);
            Console.WriteLine(ppp);
            var b = new[] { 7, 9, 6 };

            //nullable
            Console.WriteLine("1e || Nullable");
            int? c = null;
            bool? j = null;
            Console.WriteLine(c);
            Console.WriteLine(j);

			//��������� �������� 
            Console.WriteLine("2a || ��������� �������� � �� ���������:");
            string g = "hello";
            string k = "hello";
            Console.WriteLine("g=k?"+g == k);

            Console.WriteLine("2b || ���������,�����������, ��������� ��������� � ��.");
            string str1 = "������1";
            string str2 = "������2";
            string str3 = "������3";

            string join = string.Join(str1, str2,null);
            Console.WriteLine(join);

			string copy = string.Copy(str3);
			Console.WriteLine(copy);

            int ind = 3;
            int length = 2;
			string sub = str2.Substring(ind,length);
			Console.WriteLine(sub);

            const string spl="hello world!";
            string[] slova = spl.Split(' ');
            foreach (string word in slova)
            {
                Console.WriteLine(word);
            }

            string sr= "� ������";
            string posle=sr.Insert(8, " C#");
			Console.WriteLine(posle);

			string ctroka = "hello world";
			string rp = ctroka.Replace("o", "");
			Console.WriteLine(rp);


			Console.WriteLine("2c || null ������");

				string s1 = null;
				string s2 = string.Empty;
				string s3 = "";
				Console.WriteLine(s1 == s2);
				Console.WriteLine(s1 == s3);
				Console.WriteLine(s2 == s3);

            Console.WriteLine("2d || StringBuilder");

			StringBuilder MyStringBuilder = new StringBuilder("Hello");
			MyStringBuilder.Append(" World!");
			Console.WriteLine(MyStringBuilder);

			StringBuilder MyStringBuilder1 = new StringBuilder("Hello World!");
			MyStringBuilder1.Insert(6, "Beautiful ");
			Console.WriteLine(MyStringBuilder1);

			StringBuilder MyStringBuilder2= new StringBuilder("Hello World!");
			MyStringBuilder2.Remove(5, 7);
			Console.WriteLine(MyStringBuilder2);

			StringBuilder MyStringBuilder3 = new StringBuilder("Hello World!");
			MyStringBuilder3.Replace('!', '?');
			Console.WriteLine(MyStringBuilder3);

			Console.WriteLine("3a || ��������� ������");


            int[,] myArr = new int[3, 4];

			Random ran = new Random();
			for (int n = 0; n < 3; n++)
			{
				for (int m = 0; m < 4; m++)
				{
					myArr[n, m] = ran.Next(1, 15);
					Console.Write("{0}\t", myArr[n, m]);
				}
				Console.WriteLine();
			}
            Console.WriteLine("3b || ���������� ������ �����");
            string[] week = { "�����", "���", "������"};

			foreach (string y in week)
				Console.WriteLine(y);

            int sz = week.Length;
			Console.WriteLine("������ �������:", sz);

		    week[Array.IndexOf(week, "���")] = "������";

			foreach (string y in week)
				Console.WriteLine(y);

				Console.WriteLine("3c || �� ���������� ������");
			//int p = 0;
			//int[][] mssv = new int[4][];
			//mssv[0] = new int[2];
			//mssv[1] = new int[3];
			//mssv[2] = new int[4];


			//for (; p < 2; p++)
			//{
			//mssv[0][i] = p;
			//Console.Write("{0}\t", mssv[3][p]);
			//}

			//Console.WriteLine();
			//for (p = 0;p < 3; p++)
			//{
			//mssv[1][p] = p;
			//Console.Write("{0}\t", mssv[3][p]);
			//}

			//Console.WriteLine();
			//for (p = 0; p < 4; p++)
			//{
			//mssv[2][p] = p;
			//Console.Write("{0}\t", mssv[3][p]);
			//}


			//Console.ReadLine();

			Console.WriteLine("3d || ������ ��������������");

            var mas = new object[0];
			var stg = "";
            Console.WriteLine("4a � c d || �������");

			var population = Tuple.Create("Minsk", 'm', 1911000,43);
			Console.WriteLine("��������� � {0} � 2013: {1:N0}",
							  population.Item1, population.Item3);

            Console.WriteLine("4b || ����������� � ������������� �������");
            var unnamed = ("one", "two");
            var named = (first: "one", second: "two");


            Console.WriteLine("4e || �������� ��� �������");
            var t1 = (1, "A");
			var t2 = (2, "B");

			var results = t1.CompareTo(t2);
            Console.WriteLine(results);

		}
        }
}