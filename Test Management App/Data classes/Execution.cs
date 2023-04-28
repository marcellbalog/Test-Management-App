using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Execution
{
	public int ID { get; set; }
	public int TestID { get; set; }
	public DateTime Date { get; set; }
	public int Time { get; set; }
	public int Result { get; set; }
	public int FailedStepID { get; set; }
	public string Comment { get; set; }

	public string ResultName => GetResultName();

	public Color ResultColor => GetResultColor();
	public Color GetResultColor()
	{
		Color color;
		switch (Result)
		{
			case 0:
				color = Color.Crimson;
				break;
			case 1:
				color = Color.Lime;
				break;
			case 2:
				color = Color.Orange;
				break;
			default:
				color = Color.Gray;
				break;
		}

		return color;
	}

	public string GetResultName()
	{
		string name;
		switch (Result)
		{
			case 0:
				name = "FAIL";
				break;
			case 1:
				name = "SUCCESS";
				break;
			case 2:
				name = "TERMINATED";
				break;
			default:
				name = "FAIL";
				break;
		}

		return name;
	}

}

