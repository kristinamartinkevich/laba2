using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace frdg
{
	class Program
	{
		// ������ ����� ���������� ������ � 4-��
		// ������� ����������
		static Tuple<int, float, string, char> Corteg(int a, string text)
		{


			int[] numbers = { 4542, 897, 32, 85, 756, 421 };
			int minValue = numbers.Min();
			int maxValue = numbers.Max<int>();
			int sum = 0;
			foreach (int value in numbers)
			{
				sum += value;
			}

            string s = "�����:" +sum;
			char ch = (char)(text[0]);?           
			

			return Tuple.Create<int, float, string, char>(minValue, maxValue, s, ch);
		}

		static void Main(string[] args)
		{
			var myTuple = Corteg(25, "Hello");
			Console.WriteLine("{0}\n����������� ��������: {1}\n������������ ��������: "
				+ "{2}\n������ ������: {3}\n", myTuple.Item3, myTuple.Item1, myTuple.Item2, myTuple.Item4);

			
		}

	}

	public class Tuple<T1, T2, T3, T4, T5, T6, T7, TRest>
	{
	}
}