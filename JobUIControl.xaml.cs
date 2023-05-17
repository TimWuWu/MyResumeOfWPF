using MyResumeOfWPF.PDO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MyResumeOfWPF
{
    /// <summary>
    /// JobUIControl.xaml 的交互逻辑
    /// </summary>
    public partial class JobUIControl : UserControl
    {
        private JobRow jobRowUI;

        public JobRow JobRowUI
        {
            get { return jobRowUI; }
            set 
            { 
                jobRowUI = value;
                CompanyName = jobRowUI.CompanyNameColumn;
                Title= jobRowUI.TitleColumn;
                Input= jobRowUI.InputColumn;
                Output= jobRowUI.OutputColumn;
                Duty= jobRowUI.DutyColumn;
            }
        }

        //从数据源为UI引入数据
        public JobUIControl()
        {          
            InitializeComponent();           
        }

        public JobUIControl(JobRow inputjobdata)
        {
            JobRowUI= inputjobdata;
            InitializeComponent();
        }

        public string CompanyName
        {
            get { return (string)GetValue(CompanyNameProperty); }
            set { SetValue(CompanyNameProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CompanyName.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CompanyNameProperty =
            DependencyProperty.Register("CompanyName", typeof(string), typeof(JobUIControl), 
                new PropertyMetadata("Mycompany"));

        public string Title
        {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Title.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TitleProperty =
            DependencyProperty.Register("Title", typeof(string), typeof(JobUIControl), 
                new PropertyMetadata("MyTitle"));

        public string Input
        {
            get { return (string)GetValue(InputProperty); }
            set { SetValue(InputProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Input.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty InputProperty =
            DependencyProperty.Register("Input", typeof(string), typeof(JobUIControl), 
                new PropertyMetadata("2015年4月4日"));

        public string Output
        {
            get { return (string)GetValue(OutputProperty); }
            set { SetValue(OutputProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Output.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty OutputProperty =
            DependencyProperty.Register("Output", typeof(string), typeof(JobUIControl), 
                new PropertyMetadata("2016年5月5日"));

        public string Duty
        {
            get { return (string)GetValue(DutyProperty); }
            set { SetValue(DutyProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Duty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty DutyProperty =
            DependencyProperty.Register("Duty", typeof(string), typeof(JobUIControl), 
                new PropertyMetadata("工作职责"));
    }
}
