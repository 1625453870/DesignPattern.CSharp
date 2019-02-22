using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterm.SimpleFactory
{
    
    /// <summary>
    /// 柱状图
    /// </summary>
    public class HistogramChart:IChartable
    {
        public HistogramChart()
        {
            Console.WriteLine("创建柱状图...");
        }

        public void Display()
        {
            Console.WriteLine("显示柱状图...");
        }
    }

    /// <summary>
    /// 线形图 
    /// </summary>
    public class LineChart : IChartable
    {
        public LineChart()
        {
            Console.WriteLine("创建折线图...");
        }

        public void Display()
        {
            Console.WriteLine("显示折线图...");
        }
    }

    /// <summary>
    /// 饼图 
    /// </summary>
    public class PieChart : IChartable
    {
        public PieChart()
        {
            Console.WriteLine("创建饼状图...");
        }

        public void Display()
        {
            Console.WriteLine("显示饼状图...");
        }
    }
}
